using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace OnlineNeuralNetworkTrainer
{
    public partial class MainForm : Form
    {
        private Process process;
        private SpinnerForm sf = new SpinnerForm();
        private Thread Spinner_th;
        private readonly string debugTAG = "[MF]";
        public MainForm()
        {
            InitializeComponent();
            this.MainFormInitialise();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MainFormInitialise()
        {
            SystemManager.Log(this.debugTAG,"MainFormInitialise called",false);
            this.Text = "NN Trainer v" + SystemManager.SoftwareVersion;
            this.batchSizeDropMenu.SelectedIndex = 0;
            this.optimFuncDropMenu.SelectedIndex = 0;
            this.lossFuncDropMenu.SelectedIndex = 0;
            string database_file = Path.GetDirectoryName(Application.ExecutablePath) + "\\data\\testdata\\data.db";
            SystemManager.dbm.database_file = database_file;
            SystemManager.dbm.LoadDatabase();
        }

        private void load_model_btn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click load model button", false);
            this.mainTablessControl.SelectedIndex = 0;
        }

        private void inputDataBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click input data button", false);
            this.mainTablessControl.SelectedIndex = 1;
        }

        private void ConfigModelBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click configure model button", false);
            this.mainTablessControl.SelectedIndex = 2;
        }

        private void selectHistoryModelBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click select history model button", false);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON model files (*model*.json)|*model*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string modelFileName = ofd.FileName;
                JSONReader jr = new JSONReader() { };
                SystemManager.CurrentKerasModel = jr.ReadArchitectureFromJsonFile(modelFileName);
                string txt = SystemManager.CurrentKerasModel.GetModelBriefSummary();
                string weightFileName = modelFileName.Replace("model","weight");
                if (File.Exists(weightFileName))
                {
                    SystemManager.Log(this.debugTAG,"weight loaded", false);
                    double[] weights = jr.ReadWeightsFromJsonFile(weightFileName);
                    SystemManager.CurrentKerasModel.weightsLongArray = weights;
                    SystemManager.CurrentKerasModel.ExpandWeightsLongArray();
                    txt += "Weight File Loaded\n";
                }
                else
                {
                    SystemManager.Log(this.debugTAG,"weight json not found", true);
                    txt += "Weight File Not Found\n";
                }
                this.ConsoleLabel.Text = txt;
            }
        }

        private void trainModelBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click train model button", false);
            string exepath = Path.GetDirectoryName(Application.ExecutablePath);
            string pyScriptPath = exepath + "\\data\\Trainerbackend.exe";
            string ConfigPath = exepath + "\\data\\testdata";
            string dataPath = exepath + "\\data\\testdata\\data.csv";
            if (SystemManager.CurrentKerasModel == null)
            {
                SystemManager.Log(this.debugTAG,"Current model not configured", true);
                MessageBox.Show("ERROR: please load a model or config a model first");
                Console.WriteLine("[DEBUG] at Form1.cs, in trainModelBtn_Click() Keras Model not loaded");
                return;
            }
            if (!File.Exists(pyScriptPath))
            {
                SystemManager.Log(this.debugTAG,"backend script not found", true);
                MessageBox.Show("ERROR: Backend script missing");
                Console.WriteLine("[DEBUG] at Form1.cs, in trainModelBtn_Click() file missing");
                return;
            }
            if (!File.Exists(dataPath))
            {
                SystemManager.Log(this.debugTAG,"data not loaded", true);
                MessageBox.Show("ERROR: training data missing");
                Console.WriteLine("[DEBUG] at Form1.cs, in trainModelBtn_Click() file missing");
                return;
            }
            bool success = SystemManager.CurrentKerasModel.ExportConfig(ConfigPath);
            if (!success)
            {
                SystemManager.Log(this.debugTAG,"Export config file writing error", true);
                MessageBox.Show("config file writing error, please check user permission");
                return;
            }
            try
            {
                SystemManager.Log(this.debugTAG,"try start training", false);
                if (process == null)
                {
                    process = new Process();
                }
                Directory.SetCurrentDirectory(exepath + "\\data");
                var processStartInfo = new ProcessStartInfo("cmd.exe", " /C Trainerbackend");
                processStartInfo.UseShellExecute = false;
                processStartInfo.ErrorDialog = false;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.CreateNoWindow = true;
                process.StartInfo = processStartInfo;
                ConsoleLabel.Text = "";
                TrainProgressBar.Value = 0;
                bool processStarted = process.Start();
                StartSpinnerThread();
                this.ConsoleLabel.Text = "Initialising Tensorflow Backend...";
                BGW_Train.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message = ex.InnerException.Message;
                }
                SystemManager.Log(this.debugTAG,"run cmd error, exception: " + message, true);
                Console.Write("[DEBUG] at Form1.cs, in trainModelBtn_Click() cmd exe error: " + message);
                MessageBox.Show("ERROR: running backend script exception");
            }
        }

        private void BGW_Train_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                if (line.Contains("Epoch"))
                {
                    string currentConsoleLabelStr = ConsoleLabel.Text + "\n" + line;
                    int numLines = currentConsoleLabelStr.Split('\n').Length;
                    if (numLines > 7)
                    {
                        currentConsoleLabelStr = SystemManager.DeleteLines(currentConsoleLabelStr, 1);
                    }
                    int progress = Convert.ToInt16(line.Substring(line.IndexOf(' ')+1,line.Length-11))/10;
                    BGW_Train.ReportProgress(progress,currentConsoleLabelStr);
                }
                else if (line.Contains("train complete"))
                {
                    string currentConsoleLabelStr = ConsoleLabel.Text + "\n" + line;
                    int numLines = currentConsoleLabelStr.Split('\n').Length;
                    if (numLines > 7)
                    {
                        currentConsoleLabelStr = SystemManager.DeleteLines(currentConsoleLabelStr, 1);
                    }
                    BGW_Train.ReportProgress(100, currentConsoleLabelStr);
                }
            }
        }

        private void BGW_Train_onProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TrainProgressBar.Value = e.ProgressPercentage;
            ConsoleLabel.Text = e.UserState.ToString();
        }

        private void BGW_Train_onWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SystemManager.Log(this.debugTAG,"model training process completed", false);
            StopSpinnerThread();
            string exepath = Path.GetDirectoryName(Application.ExecutablePath);
            Directory.SetCurrentDirectory(exepath);
            MessageBox.Show("Training Completed");
        }

        private void StartSpinnerThread()
        {
            SystemManager.Log(this.debugTAG,"initialising spinner", false);
            left_panel.Enabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            mainTablessControl.Enabled = false;
            Spinner_th = new Thread(new ThreadStart(delegate
            {
                sf.Location = new Point(this.Size.Width / 2 + this.Location.X - sf.Size.Width / 2, this.Size.Height / 3 + this.Location.Y - sf.Size.Height / 2);
                sf.StartPosition = FormStartPosition.Manual;
                sf.ShowDialog();
            }));
            Spinner_th.Start();
        }

        private void StopSpinnerThread()
        {
            SystemManager.Log(this.debugTAG,"disabling spinner", false);
            Spinner_th.Abort();
            left_panel.Enabled = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            mainTablessControl.Enabled = true;
        }

        private void applyConfigBtn_Click(object sender, EventArgs e)
        {
            SystemManager.TempKerasModel.batch_size = Convert.ToInt32(batchSizeDropMenu.SelectedItem.ToString());
            SystemManager.TempKerasModel.optim_func = optimFuncDropMenu.SelectedItem.ToString();
            SystemManager.TempKerasModel.loss_func = lossFuncDropMenu.SelectedItem.ToString();
        }

        private void ApplyNumLayerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfLayers = Convert.ToInt32(numOFLayerTB.Text);
                if (numOfLayers < 2 || numOfLayers > 50)
                {
                    throw new ArgumentException("parameter cannot be out of range (2-50)","original");
                }
                SystemManager.TempKerasModel.NumLayers = numOfLayers;
                SystemManager.TempKerasModel.NumNeuronLayers = new int[numOfLayers];
                for (int i = 0; i < numOfLayers; i++)
                {
                    this.LayerSelectorDropMenu.Items.Add((i+1).ToString());
                }
                this.LayerSelectorDropMenu.SelectedIndex = 0;
                this.ConsoleLabel.Text = "Number Of Layers Applied: " + numOfLayers.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("[DEBUG] at Form1.cs, in ApplyNumLayerBtn_Click() error input number: " + ex.Message);
                MessageBox.Show("Please input an integer ranged between (2 - 50)");
            }
        }

        private void ApplyNumNeuronsBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click apply num neurons button", false);
            try
            {
                int selectedLayer = this.LayerSelectorDropMenu.SelectedIndex;
                int numOfNeurons = Convert.ToInt32(neuronsTB.Text);
                if (numOfNeurons < 2 || numOfNeurons > 50)
                {
                    throw new ArgumentException("parameter cannot be out of range (2-50)", "original");
                }
                SystemManager.TempKerasModel.NumNeuronLayers[selectedLayer] = numOfNeurons;
                this.ConsoleLabel.Text = "Number Of Neurons for Layer " +  selectedLayer.ToString() + 
                    " Applied: " + numOfNeurons.ToString();
            }
            catch (Exception ex)
            {
                SystemManager.Log(this.debugTAG,"invalid input from num neuron, exception: " + ex.Message, true);
                Console.WriteLine("[DEBUG] at Form1.cs, in ApplyNumNeuronsBtn_Click() error input number: " + ex.Message);
                MessageBox.Show("Please input an integer ranged between (2 - 50)");
            }
        }

        private void loadHistorySettingBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click load history settings button", false);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON model files (*model*.json)|*model*.json";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string modelFileName = ofd.FileName;
                JSONReader jr = new JSONReader() { };
                SystemManager.CurrentKerasModel = jr.ReadArchitectureFromJsonFile(modelFileName);
                string txt = SystemManager.CurrentKerasModel.GetModelBriefSummary();
                this.ConsoleLabel.Text = txt;
            }
        }

        private void ApplyAllSettingBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click apply all settings button", false);
            if (SystemManager.TempKerasModel.IsReadyForTraining())
            {
                SystemManager.Log(this.debugTAG,"model ready for training", false);
                SystemManager.CurrentKerasModel = SystemManager.TempKerasModel;
                string txt = SystemManager.CurrentKerasModel.GetModelBriefSummary();
                this.ConsoleLabel.Text = txt;
            }
            else
            {
                SystemManager.Log(this.debugTAG,"model not ready for training", false);
                MessageBox.Show("Model configuration not ready");
            }
        }

        private void predictBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click predict button", false);
            try
            {
                //TODO: input limited to 5 in this demo, adjust in future
                double[] inputsArray = new double[5];
                inputsArray[0] = Convert.ToDouble(feature1TB.Text);
                inputsArray[1] = Convert.ToDouble(feature2TB.Text);
                inputsArray[2] = Convert.ToDouble(feature3TB.Text);
                inputsArray[3] = Convert.ToDouble(feature4TB.Text);
                inputsArray[4] = Convert.ToDouble(feature5TB.Text);
                double result = SystemManager.CurrentKerasModel.Predict(inputsArray);
                this.ConsoleLabel.Text = "Prediction: Output = " + result.ToString("0.##");
                SystemManager.Log(this.debugTAG,"Predict success, results: " + result.ToString("0.##"), false);
            }
            catch (Exception ex)
            {
                SystemManager.Log(this.debugTAG,"Predict failed, exception: " + ex.Message, true);
                Console.WriteLine("[DEBUG] at Form1.cs, in predictBtn_Click ex: " + ex.Message);
                MessageBox.Show("ERROR occurs when preforming prediction, please check if the model is loaded and all inputs are valid");
            }
        }

        private void csvExportBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click csvExport button", false);
            if (SystemManager.dbm.selectedDataLength != 0)
            {
                SystemManager.Log(this.debugTAG,"start data export", false);
                this.BGW_export_csv.RunWorkerAsync();
            }
            else
            {
                SystemManager.Log(this.debugTAG,"failed to start export, no data selection", true);
                MessageBox.Show("No selected data yet!");
            }
        }

        private void saveDataBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click save data button", false);
            try
            {
                //TODO: input limited to 5 in this demo, adjust in future
                double[] inputsArray = new double[6];
                inputsArray[0] = Convert.ToDouble(feature1TB.Text);
                inputsArray[1] = Convert.ToDouble(feature2TB.Text);
                inputsArray[2] = Convert.ToDouble(feature3TB.Text);
                inputsArray[3] = Convert.ToDouble(feature4TB.Text);
                inputsArray[4] = Convert.ToDouble(feature5TB.Text);
                inputsArray[5] = Convert.ToDouble(resultTB.Text);
                SystemManager.dbm.AddToDB(inputsArray);
                SystemManager.Log(this.debugTAG,"save data success", false);
                this.ConsoleLabel.Text = "add data success";
            }
            catch (Exception ex)
            {
                SystemManager.Log(this.debugTAG,"save data failed, exception: " + ex.Message, true);
                Console.WriteLine("[DEBUG] at Form1.cs, in saveDataBtn_Click ex: " + ex.Message);
                MessageBox.Show("ERROR occurs when saving data, please check if all inputs are valid");
            }
        }

        private void sqlSelectBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click sql select button", false);
            SelectDataForm sdf = new SelectDataForm(this);
            this.Hide();
            sdf.ShowDialog(this);
        }

        private void BGW_import_csv_DoWork(object sender, DoWorkEventArgs e)
        {
            SystemManager.dbm.ImportFromCSV(e.Argument.ToString(), sender as BackgroundWorker);
        }

        private void BGW_import_csv_onProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ConsoleLabel.Text = e.UserState.ToString();
        }

        private void importCSVBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on click import csv button", false);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "comma seperated file (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SystemManager.Log(this.debugTAG,"file selected: " + ofd.FileName, false);
                string csvFileName = ofd.FileName;
                BGW_import_csv.RunWorkerAsync(csvFileName);
                this.StartSpinnerThread();
            }
        }
        public void onSDFSelectedData(bool isConfirmed)
        {
            SystemManager.Log(this.debugTAG,"call back on sdf selected data", false);
            if (isConfirmed)
            {
                int datalen = SystemManager.dbm.selectedDataLength;
                if (datalen == 0)
                {
                    SystemManager.Log(this.debugTAG,"selected data 0 length", false);
                    this.ConsoleLabel.Text = "no data is selected";
                }
                else
                {
                    SystemManager.Log(this.debugTAG,"selected data length: " + SystemManager.dbm.selectedDataLength.ToString(), false);
                    this.ConsoleLabel.Text = "Selected data from data base, length: " + SystemManager.dbm.selectedDataLength.ToString();
                }
            }
            else
            {
                SystemManager.Log(this.debugTAG,"canceled", false);
                this.ConsoleLabel.Text = "operation canceled";
            }
        }

        private void visualiseBtn_Click(object sender, EventArgs e)
        {
            SystemManager.Log(this.debugTAG,"on clik visulise data button", false);
            if (SystemManager.CurrentKerasModel == null)
            {
                SystemManager.Log(this.debugTAG,"no model is loaded", false);
                MessageBox.Show("Please load a model first");
                return;
            }
            if (SystemManager.dbm.selectedDataLength == 0 || SystemManager.dbm.selectedData == null)
            {
                SystemManager.Log(this.debugTAG,"no data is selecred", false);
                MessageBox.Show("Please select data first");
                return;
            }
            StartSpinnerThread();
            BGW_visualise_data.RunWorkerAsync();
        }

        private void BGW_visualise_data_DoWork(object sender, DoWorkEventArgs e)
        {
            int len = SystemManager.dbm.selectedDataLength;
            double[] predicted_values = new double[len];
            double[] expected_values = SystemManager.dbm.selectedData[5].ToArray();
            double[] inputsArray = new double[5];
            for (int i = 0; i < len; i++)
            {
                //add 1 to avoid system access violation error, this is then sompensated in dll
                inputsArray = null;
                GC.Collect();
                inputsArray = new double[5];
                inputsArray[0] = SystemManager.dbm.selectedData[0][i];
                inputsArray[1] = SystemManager.dbm.selectedData[1][i];
                inputsArray[2] = SystemManager.dbm.selectedData[2][i];
                inputsArray[3] = SystemManager.dbm.selectedData[3][i];
                inputsArray[4] = SystemManager.dbm.selectedData[4][i];
                predicted_values[i] = SystemManager.CurrentKerasModel.Predict(inputsArray);
            }
            SystemManager.PMPerformaceView.data.Add(predicted_values);
            SystemManager.PMPerformaceView.data.Add(expected_values);
        }

        private void BGW_visualise_data_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SystemManager.Log(this.debugTAG,"visualising data process completed", false);
            SystemManager.PMPerformaceView.InitializeGraph(performanceView, "Predicted Values vs Expected Values", new string[] { "Predicted","Expected" });
            int[] temp = Enumerable.Range(0, SystemManager.PMPerformaceView.data[0].Length).ToArray<int>();
            double[] idx = Array.ConvertAll<int,double>(temp, d => (double)d);
            SystemManager.PMPerformaceView.AddData(performanceView, idx, SystemManager.PMPerformaceView.data[0], 0);
            SystemManager.PMPerformaceView.AddData(performanceView, idx, SystemManager.PMPerformaceView.data[1], 1);
            performanceView.RestoreScale(performanceView.GraphPane);
            StopSpinnerThread();
        }

        private void BGW_import_csv_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SystemManager.Log(this.debugTAG,"csv import completed", false);
            this.StopSpinnerThread();
        }

        private void BGW_export_csv_DoWork(object sender, DoWorkEventArgs e)
        {
            string exepath = Path.GetDirectoryName(Application.ExecutablePath);
            string dataPath = exepath + "\\data\\testdata\\data.csv";
            SystemManager.dbm.ExportToCSV(BGW_export_csv,dataPath);
            this.StartSpinnerThread();
        }

        private void BGW_export_csv_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SystemManager.Log(this.debugTAG,"ecv export completed", false);
            ConsoleLabel.Text = "Export completed";
            this.StopSpinnerThread();
        }

        private void BGW_export_csv_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ConsoleLabel.Text = e.UserState.ToString();
        }
    }
}

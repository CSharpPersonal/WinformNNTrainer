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

namespace OnlineNeuralNetworkTrainer
{
    public partial class MainForm : Form
    {
        private Process process;
        SpinnerForm sf = new SpinnerForm();
        Thread Spinner_th;
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
            this.Text = "NN Trainer v" + SystemManager.SoftwareVersion;
            this.batchSizeDropMenu.SelectedIndex = 0;
            this.optimFuncDropMenu.SelectedIndex = 0;
            this.lossFuncDropMenu.SelectedIndex = 0;
        }

        private void load_model_btn_Click(object sender, EventArgs e)
        {
            this.mainTablessControl.SelectedIndex = 0;
        }

        private void inputDataBtn_Click(object sender, EventArgs e)
        {
            this.mainTablessControl.SelectedIndex = 1;
        }

        private void ConfigModelBtn_Click(object sender, EventArgs e)
        {
            this.mainTablessControl.SelectedIndex = 2;
        }

        private void selectHistoryModelBtn_Click(object sender, EventArgs e)
        {
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
                    double[] weights = jr.ReadWeightsFromJsonFile(weightFileName);
                    SystemManager.CurrentKerasModel.weightsLongArray = weights;
                    SystemManager.CurrentKerasModel.ExpandWeightsLongArray();
                    txt += "Weight File Loaded\n";
                }
                else
                {
                    txt += "Weight File Not Found\n";
                }
                this.ConsoleLabel.Text = txt;
            }
        }

        private void trainModelBtn_Click(object sender, EventArgs e)
        {
            string exepath = Path.GetDirectoryName(Application.ExecutablePath);
            string pyScriptPath = exepath + "\\data\\Trainerbackend.exe";
            string ConfigPath = exepath + "\\data\\testdata";
            string dataPath = exepath + "\\data\\testdata\\data.csv";
            if (SystemManager.CurrentKerasModel == null)
            {
                MessageBox.Show("ERROR: please load a model or config a model first");
                Console.WriteLine("[DEBUG] at Form1.cs, in trainModelBtn_Click() Keras Model not loaded");
                return;
            }
            if (!File.Exists(pyScriptPath))
            {
                MessageBox.Show("ERROR: Backend script missing");
                Console.WriteLine("[DEBUG] at Form1.cs, in trainModelBtn_Click() file missing");
                return;
            }
            if (!File.Exists(dataPath))
            {
                MessageBox.Show("ERROR: training data missing");
                Console.WriteLine("[DEBUG] at Form1.cs, in trainModelBtn_Click() file missing");
                return;
            }
            bool success = SystemManager.CurrentKerasModel.ExportConfig(ConfigPath);
            if (!success)
            {
                MessageBox.Show("config file writing error, please check user permission");
                return;
            }
            try
            {
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
                BGW_Train.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message = ex.InnerException.Message;
                }
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
            StopSpinnerThread();
            string exepath = Path.GetDirectoryName(Application.ExecutablePath);
            Directory.SetCurrentDirectory(exepath);
            MessageBox.Show("Training Completed");
        }

        private void StartSpinnerThread()
        {
            left_panel.Enabled = false;
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
            Spinner_th.Abort();
            left_panel.Enabled = true;
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
                Console.WriteLine("[DEBUG] at Form1.cs, in ApplyNumNeuronsBtn_Click() error input number: " + ex.Message);
                MessageBox.Show("Please input an integer ranged between (2 - 50)");
            }
        }

        private void loadHistorySettingBtn_Click(object sender, EventArgs e)
        {
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
            if (SystemManager.TempKerasModel.IsReadyForTraining())
            {
                SystemManager.CurrentKerasModel = SystemManager.TempKerasModel;
                string txt = SystemManager.CurrentKerasModel.GetModelBriefSummary();
                this.ConsoleLabel.Text = txt;
            }
            else
            {
                MessageBox.Show("Model configuration not ready");
            }
        }
    }
}

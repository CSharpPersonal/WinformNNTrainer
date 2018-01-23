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
    }
}

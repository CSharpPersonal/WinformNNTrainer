namespace OnlineNeuralNetworkTrainer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.main_panel = new System.Windows.Forms.Panel();
            this.right_panel = new System.Windows.Forms.Panel();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.left_panel = new System.Windows.Forms.Panel();
            this.ConfigModelBtn = new System.Windows.Forms.Button();
            this.inputDataBtn = new System.Windows.Forms.Button();
            this.loadModelBtn = new System.Windows.Forms.Button();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.BGW_Train = new System.ComponentModel.BackgroundWorker();
            this.mainTablessControl = new TablessControl();
            this.LoadModel = new System.Windows.Forms.TabPage();
            this.selectHistoryModelBtn = new System.Windows.Forms.Button();
            this.AddData = new System.Windows.Forms.TabPage();
            this.ConfigModel = new System.Windows.Forms.TabPage();
            this.TrainProgressBar = new System.Windows.Forms.ProgressBar();
            this.trainModelBtn = new System.Windows.Forms.Button();
            this.trainFuncPanel = new System.Windows.Forms.Panel();
            this.main_panel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.mainTablessControl.SuspendLayout();
            this.LoadModel.SuspendLayout();
            this.ConfigModel.SuspendLayout();
            this.trainFuncPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.right_panel);
            this.main_panel.Controls.Add(this.left_panel);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(670, 439);
            this.main_panel.TabIndex = 0;
            // 
            // right_panel
            // 
            this.right_panel.Controls.Add(this.ConsoleLabel);
            this.right_panel.Controls.Add(this.mainTablessControl);
            this.right_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_panel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.right_panel.Location = new System.Drawing.Point(170, 0);
            this.right_panel.Name = "right_panel";
            this.right_panel.Size = new System.Drawing.Size(500, 439);
            this.right_panel.TabIndex = 1;
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConsoleLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConsoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ConsoleLabel.Location = new System.Drawing.Point(0, 322);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(500, 117);
            this.ConsoleLabel.TabIndex = 1;
            this.ConsoleLabel.Text = "Console";
            // 
            // left_panel
            // 
            this.left_panel.BackgroundImage = global::OnlineNeuralNetworkTrainer.Properties.Resources.left_panel_bgi;
            this.left_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left_panel.Controls.Add(this.ConfigModelBtn);
            this.left_panel.Controls.Add(this.inputDataBtn);
            this.left_panel.Controls.Add(this.loadModelBtn);
            this.left_panel.Controls.Add(this.logo_pb);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 0);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(170, 439);
            this.left_panel.TabIndex = 0;
            // 
            // ConfigModelBtn
            // 
            this.ConfigModelBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ConfigModelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigModelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConfigModelBtn.Location = new System.Drawing.Point(3, 135);
            this.ConfigModelBtn.Name = "ConfigModelBtn";
            this.ConfigModelBtn.Size = new System.Drawing.Size(160, 26);
            this.ConfigModelBtn.TabIndex = 3;
            this.ConfigModelBtn.Text = "Config Model";
            this.ConfigModelBtn.UseVisualStyleBackColor = false;
            this.ConfigModelBtn.Click += new System.EventHandler(this.ConfigModelBtn_Click);
            // 
            // inputDataBtn
            // 
            this.inputDataBtn.BackColor = System.Drawing.Color.DarkRed;
            this.inputDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputDataBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDataBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.inputDataBtn.Location = new System.Drawing.Point(4, 103);
            this.inputDataBtn.Name = "inputDataBtn";
            this.inputDataBtn.Size = new System.Drawing.Size(160, 26);
            this.inputDataBtn.TabIndex = 2;
            this.inputDataBtn.Text = "Input Data";
            this.inputDataBtn.UseVisualStyleBackColor = false;
            this.inputDataBtn.Click += new System.EventHandler(this.inputDataBtn_Click);
            // 
            // loadModelBtn
            // 
            this.loadModelBtn.BackColor = System.Drawing.Color.DarkRed;
            this.loadModelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadModelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadModelBtn.Location = new System.Drawing.Point(4, 71);
            this.loadModelBtn.Name = "loadModelBtn";
            this.loadModelBtn.Size = new System.Drawing.Size(160, 26);
            this.loadModelBtn.TabIndex = 1;
            this.loadModelBtn.Text = "Load Model";
            this.loadModelBtn.UseVisualStyleBackColor = false;
            this.loadModelBtn.Click += new System.EventHandler(this.load_model_btn_Click);
            // 
            // logo_pb
            // 
            this.logo_pb.BackColor = System.Drawing.Color.Transparent;
            this.logo_pb.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo_pb.Location = new System.Drawing.Point(0, 0);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(170, 64);
            this.logo_pb.TabIndex = 0;
            this.logo_pb.TabStop = false;
            // 
            // BGW_Train
            // 
            this.BGW_Train.WorkerReportsProgress = true;
            this.BGW_Train.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_Train_DoWork);
            this.BGW_Train.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGW_Train_onProgressChanged);
            this.BGW_Train.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_Train_onWorkerCompleted);
            // 
            // mainTablessControl
            // 
            this.mainTablessControl.Controls.Add(this.LoadModel);
            this.mainTablessControl.Controls.Add(this.AddData);
            this.mainTablessControl.Controls.Add(this.ConfigModel);
            this.mainTablessControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTablessControl.Location = new System.Drawing.Point(0, 0);
            this.mainTablessControl.Name = "mainTablessControl";
            this.mainTablessControl.SelectedIndex = 0;
            this.mainTablessControl.Size = new System.Drawing.Size(500, 319);
            this.mainTablessControl.TabIndex = 0;
            // 
            // LoadModel
            // 
            this.LoadModel.Controls.Add(this.selectHistoryModelBtn);
            this.LoadModel.Location = new System.Drawing.Point(4, 22);
            this.LoadModel.Name = "LoadModel";
            this.LoadModel.Padding = new System.Windows.Forms.Padding(3);
            this.LoadModel.Size = new System.Drawing.Size(492, 293);
            this.LoadModel.TabIndex = 0;
            this.LoadModel.Text = "load model";
            this.LoadModel.UseVisualStyleBackColor = true;
            // 
            // selectHistoryModelBtn
            // 
            this.selectHistoryModelBtn.BackColor = System.Drawing.Color.DarkRed;
            this.selectHistoryModelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectHistoryModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectHistoryModelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.selectHistoryModelBtn.Location = new System.Drawing.Point(6, 6);
            this.selectHistoryModelBtn.Name = "selectHistoryModelBtn";
            this.selectHistoryModelBtn.Size = new System.Drawing.Size(160, 26);
            this.selectHistoryModelBtn.TabIndex = 2;
            this.selectHistoryModelBtn.Text = "Select History Model";
            this.selectHistoryModelBtn.UseVisualStyleBackColor = false;
            this.selectHistoryModelBtn.Click += new System.EventHandler(this.selectHistoryModelBtn_Click);
            // 
            // AddData
            // 
            this.AddData.Location = new System.Drawing.Point(4, 22);
            this.AddData.Name = "AddData";
            this.AddData.Padding = new System.Windows.Forms.Padding(3);
            this.AddData.Size = new System.Drawing.Size(492, 293);
            this.AddData.TabIndex = 1;
            this.AddData.Text = "Add Data";
            this.AddData.UseVisualStyleBackColor = true;
            // 
            // ConfigModel
            // 
            this.ConfigModel.Controls.Add(this.trainFuncPanel);
            this.ConfigModel.Location = new System.Drawing.Point(4, 22);
            this.ConfigModel.Name = "ConfigModel";
            this.ConfigModel.Size = new System.Drawing.Size(492, 293);
            this.ConfigModel.TabIndex = 2;
            this.ConfigModel.Text = "Config Model";
            this.ConfigModel.UseVisualStyleBackColor = true;
            // 
            // TrainProgressBar
            // 
            this.TrainProgressBar.Location = new System.Drawing.Point(3, 5);
            this.TrainProgressBar.Name = "TrainProgressBar";
            this.TrainProgressBar.Size = new System.Drawing.Size(320, 26);
            this.TrainProgressBar.TabIndex = 3;
            // 
            // trainModelBtn
            // 
            this.trainModelBtn.BackColor = System.Drawing.Color.DarkRed;
            this.trainModelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainModelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainModelBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.trainModelBtn.Location = new System.Drawing.Point(329, 5);
            this.trainModelBtn.Name = "trainModelBtn";
            this.trainModelBtn.Size = new System.Drawing.Size(160, 26);
            this.trainModelBtn.TabIndex = 2;
            this.trainModelBtn.Text = "Train";
            this.trainModelBtn.UseVisualStyleBackColor = false;
            this.trainModelBtn.Click += new System.EventHandler(this.trainModelBtn_Click);
            // 
            // trainFuncPanel
            // 
            this.trainFuncPanel.Controls.Add(this.trainModelBtn);
            this.trainFuncPanel.Controls.Add(this.TrainProgressBar);
            this.trainFuncPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trainFuncPanel.Location = new System.Drawing.Point(0, 259);
            this.trainFuncPanel.Name = "trainFuncPanel";
            this.trainFuncPanel.Size = new System.Drawing.Size(492, 34);
            this.trainFuncPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 439);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "NN Trainer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main_panel.ResumeLayout(false);
            this.right_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.mainTablessControl.ResumeLayout(false);
            this.LoadModel.ResumeLayout(false);
            this.ConfigModel.ResumeLayout(false);
            this.trainFuncPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel right_panel;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Button loadModelBtn;
        private System.Windows.Forms.PictureBox logo_pb;
        private TablessControl mainTablessControl;
        private System.Windows.Forms.TabPage LoadModel;
        private System.Windows.Forms.TabPage AddData;
        private System.Windows.Forms.Label ConsoleLabel;
        private System.Windows.Forms.Button selectHistoryModelBtn;
        private System.Windows.Forms.Button inputDataBtn;
        private System.Windows.Forms.TabPage ConfigModel;
        private System.Windows.Forms.Button ConfigModelBtn;
        private System.Windows.Forms.Button trainModelBtn;
        private System.ComponentModel.BackgroundWorker BGW_Train;
        private System.Windows.Forms.ProgressBar TrainProgressBar;
        private System.Windows.Forms.Panel trainFuncPanel;
    }
}


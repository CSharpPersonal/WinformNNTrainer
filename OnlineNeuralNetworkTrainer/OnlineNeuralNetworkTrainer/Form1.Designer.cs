﻿namespace OnlineNeuralNetworkTrainer
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
            this.loadHistorySettingBtn = new System.Windows.Forms.Button();
            this.ApplyAllSettingBtn = new System.Windows.Forms.Button();
            this.trainConfigGB = new System.Windows.Forms.GroupBox();
            this.applyConfigBtn = new System.Windows.Forms.Button();
            this.lossFuncDropMenu = new System.Windows.Forms.ComboBox();
            this.optimFuncDropMenu = new System.Windows.Forms.ComboBox();
            this.batchSizeDropMenu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.netArchitechGB = new System.Windows.Forms.GroupBox();
            this.ApplyNumNeuronsBtn = new System.Windows.Forms.Button();
            this.ApplyNumLayerBtn = new System.Windows.Forms.Button();
            this.neuronsTB = new System.Windows.Forms.TextBox();
            this.neuronLbl = new System.Windows.Forms.Label();
            this.LayerSelectorDropMenu = new System.Windows.Forms.ComboBox();
            this.LayerLbl = new System.Windows.Forms.Label();
            this.numLayLbl = new System.Windows.Forms.Label();
            this.numOFLayerTB = new System.Windows.Forms.TextBox();
            this.trainFuncPanel = new System.Windows.Forms.Panel();
            this.trainModelBtn = new System.Windows.Forms.Button();
            this.TrainProgressBar = new System.Windows.Forms.ProgressBar();
            this.main_panel.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.mainTablessControl.SuspendLayout();
            this.LoadModel.SuspendLayout();
            this.ConfigModel.SuspendLayout();
            this.trainConfigGB.SuspendLayout();
            this.netArchitechGB.SuspendLayout();
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
            this.ConfigModel.Controls.Add(this.loadHistorySettingBtn);
            this.ConfigModel.Controls.Add(this.ApplyAllSettingBtn);
            this.ConfigModel.Controls.Add(this.trainConfigGB);
            this.ConfigModel.Controls.Add(this.netArchitechGB);
            this.ConfigModel.Controls.Add(this.trainFuncPanel);
            this.ConfigModel.Location = new System.Drawing.Point(4, 22);
            this.ConfigModel.Name = "ConfigModel";
            this.ConfigModel.Size = new System.Drawing.Size(492, 293);
            this.ConfigModel.TabIndex = 2;
            this.ConfigModel.Text = "Config Model";
            this.ConfigModel.UseVisualStyleBackColor = true;
            // 
            // loadHistorySettingBtn
            // 
            this.loadHistorySettingBtn.BackColor = System.Drawing.Color.DarkRed;
            this.loadHistorySettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadHistorySettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadHistorySettingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadHistorySettingBtn.Location = new System.Drawing.Point(237, 240);
            this.loadHistorySettingBtn.Name = "loadHistorySettingBtn";
            this.loadHistorySettingBtn.Size = new System.Drawing.Size(213, 26);
            this.loadHistorySettingBtn.TabIndex = 10;
            this.loadHistorySettingBtn.Text = "Load Setting From Existing Model";
            this.loadHistorySettingBtn.UseVisualStyleBackColor = false;
            this.loadHistorySettingBtn.Click += new System.EventHandler(this.loadHistorySettingBtn_Click);
            // 
            // ApplyAllSettingBtn
            // 
            this.ApplyAllSettingBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ApplyAllSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyAllSettingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyAllSettingBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ApplyAllSettingBtn.Location = new System.Drawing.Point(13, 240);
            this.ApplyAllSettingBtn.Name = "ApplyAllSettingBtn";
            this.ApplyAllSettingBtn.Size = new System.Drawing.Size(160, 26);
            this.ApplyAllSettingBtn.TabIndex = 9;
            this.ApplyAllSettingBtn.Text = "Use Above Setting";
            this.ApplyAllSettingBtn.UseVisualStyleBackColor = false;
            this.ApplyAllSettingBtn.Click += new System.EventHandler(this.ApplyAllSettingBtn_Click);
            // 
            // trainConfigGB
            // 
            this.trainConfigGB.Controls.Add(this.applyConfigBtn);
            this.trainConfigGB.Controls.Add(this.lossFuncDropMenu);
            this.trainConfigGB.Controls.Add(this.optimFuncDropMenu);
            this.trainConfigGB.Controls.Add(this.batchSizeDropMenu);
            this.trainConfigGB.Controls.Add(this.label3);
            this.trainConfigGB.Controls.Add(this.label2);
            this.trainConfigGB.Controls.Add(this.label1);
            this.trainConfigGB.Location = new System.Drawing.Point(4, 122);
            this.trainConfigGB.Name = "trainConfigGB";
            this.trainConfigGB.Size = new System.Drawing.Size(485, 112);
            this.trainConfigGB.TabIndex = 6;
            this.trainConfigGB.TabStop = false;
            this.trainConfigGB.Text = "Training Config";
            // 
            // applyConfigBtn
            // 
            this.applyConfigBtn.BackColor = System.Drawing.Color.DarkRed;
            this.applyConfigBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyConfigBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyConfigBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.applyConfigBtn.Location = new System.Drawing.Point(286, 74);
            this.applyConfigBtn.Name = "applyConfigBtn";
            this.applyConfigBtn.Size = new System.Drawing.Size(160, 26);
            this.applyConfigBtn.TabIndex = 8;
            this.applyConfigBtn.Text = "Apply";
            this.applyConfigBtn.UseVisualStyleBackColor = false;
            this.applyConfigBtn.Click += new System.EventHandler(this.applyConfigBtn_Click);
            // 
            // lossFuncDropMenu
            // 
            this.lossFuncDropMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lossFuncDropMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lossFuncDropMenu.FormattingEnabled = true;
            this.lossFuncDropMenu.Items.AddRange(new object[] {
            "mape",
            "mse",
            "mae"});
            this.lossFuncDropMenu.Location = new System.Drawing.Point(152, 78);
            this.lossFuncDropMenu.Name = "lossFuncDropMenu";
            this.lossFuncDropMenu.Size = new System.Drawing.Size(89, 21);
            this.lossFuncDropMenu.TabIndex = 7;
            // 
            // optimFuncDropMenu
            // 
            this.optimFuncDropMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optimFuncDropMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optimFuncDropMenu.FormattingEnabled = true;
            this.optimFuncDropMenu.Items.AddRange(new object[] {
            "adam",
            "sgd",
            "rmsprop",
            "adagrad",
            "adadelta",
            "adamax",
            "nadam",
            "tfoptimizer"});
            this.optimFuncDropMenu.Location = new System.Drawing.Point(152, 48);
            this.optimFuncDropMenu.Name = "optimFuncDropMenu";
            this.optimFuncDropMenu.Size = new System.Drawing.Size(89, 21);
            this.optimFuncDropMenu.TabIndex = 6;
            // 
            // batchSizeDropMenu
            // 
            this.batchSizeDropMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batchSizeDropMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batchSizeDropMenu.FormattingEnabled = true;
            this.batchSizeDropMenu.Items.AddRange(new object[] {
            "10",
            "32",
            "64",
            "100",
            "1000",
            "5000"});
            this.batchSizeDropMenu.Location = new System.Drawing.Point(152, 17);
            this.batchSizeDropMenu.Name = "batchSizeDropMenu";
            this.batchSizeDropMenu.Size = new System.Drawing.Size(89, 21);
            this.batchSizeDropMenu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "loss function";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "optimization function";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Batch size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // netArchitechGB
            // 
            this.netArchitechGB.Controls.Add(this.ApplyNumNeuronsBtn);
            this.netArchitechGB.Controls.Add(this.ApplyNumLayerBtn);
            this.netArchitechGB.Controls.Add(this.neuronsTB);
            this.netArchitechGB.Controls.Add(this.neuronLbl);
            this.netArchitechGB.Controls.Add(this.LayerSelectorDropMenu);
            this.netArchitechGB.Controls.Add(this.LayerLbl);
            this.netArchitechGB.Controls.Add(this.numLayLbl);
            this.netArchitechGB.Controls.Add(this.numOFLayerTB);
            this.netArchitechGB.Location = new System.Drawing.Point(4, 4);
            this.netArchitechGB.Name = "netArchitechGB";
            this.netArchitechGB.Size = new System.Drawing.Size(485, 112);
            this.netArchitechGB.TabIndex = 5;
            this.netArchitechGB.TabStop = false;
            this.netArchitechGB.Text = "Net Architecture";
            // 
            // ApplyNumNeuronsBtn
            // 
            this.ApplyNumNeuronsBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ApplyNumNeuronsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyNumNeuronsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyNumNeuronsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ApplyNumNeuronsBtn.Location = new System.Drawing.Point(286, 64);
            this.ApplyNumNeuronsBtn.Name = "ApplyNumNeuronsBtn";
            this.ApplyNumNeuronsBtn.Size = new System.Drawing.Size(160, 26);
            this.ApplyNumNeuronsBtn.TabIndex = 7;
            this.ApplyNumNeuronsBtn.Text = "Apply";
            this.ApplyNumNeuronsBtn.UseVisualStyleBackColor = false;
            this.ApplyNumNeuronsBtn.Click += new System.EventHandler(this.ApplyNumNeuronsBtn_Click);
            // 
            // ApplyNumLayerBtn
            // 
            this.ApplyNumLayerBtn.BackColor = System.Drawing.Color.DarkRed;
            this.ApplyNumLayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyNumLayerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyNumLayerBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ApplyNumLayerBtn.Location = new System.Drawing.Point(286, 14);
            this.ApplyNumLayerBtn.Name = "ApplyNumLayerBtn";
            this.ApplyNumLayerBtn.Size = new System.Drawing.Size(160, 26);
            this.ApplyNumLayerBtn.TabIndex = 6;
            this.ApplyNumLayerBtn.Text = "Apply";
            this.ApplyNumLayerBtn.UseVisualStyleBackColor = false;
            this.ApplyNumLayerBtn.Click += new System.EventHandler(this.ApplyNumLayerBtn_Click);
            // 
            // neuronsTB
            // 
            this.neuronsTB.Location = new System.Drawing.Point(180, 68);
            this.neuronsTB.Name = "neuronsTB";
            this.neuronsTB.Size = new System.Drawing.Size(61, 20);
            this.neuronsTB.TabIndex = 5;
            // 
            // neuronLbl
            // 
            this.neuronLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neuronLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neuronLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.neuronLbl.Location = new System.Drawing.Point(119, 67);
            this.neuronLbl.Name = "neuronLbl";
            this.neuronLbl.Size = new System.Drawing.Size(55, 20);
            this.neuronLbl.TabIndex = 4;
            this.neuronLbl.Text = "Neurons";
            this.neuronLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayerSelectorDropMenu
            // 
            this.LayerSelectorDropMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LayerSelectorDropMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerSelectorDropMenu.FormattingEnabled = true;
            this.LayerSelectorDropMenu.Location = new System.Drawing.Point(54, 68);
            this.LayerSelectorDropMenu.Name = "LayerSelectorDropMenu";
            this.LayerSelectorDropMenu.Size = new System.Drawing.Size(59, 21);
            this.LayerSelectorDropMenu.TabIndex = 3;
            // 
            // LayerLbl
            // 
            this.LayerLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LayerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayerLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LayerLbl.Location = new System.Drawing.Point(6, 68);
            this.LayerLbl.Name = "LayerLbl";
            this.LayerLbl.Size = new System.Drawing.Size(55, 20);
            this.LayerLbl.TabIndex = 2;
            this.LayerLbl.Text = "Layer";
            this.LayerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numLayLbl
            // 
            this.numLayLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numLayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLayLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numLayLbl.Location = new System.Drawing.Point(7, 18);
            this.numLayLbl.Name = "numLayLbl";
            this.numLayLbl.Size = new System.Drawing.Size(118, 20);
            this.numLayLbl.TabIndex = 1;
            this.numLayLbl.Text = "Number of layers";
            this.numLayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOFLayerTB
            // 
            this.numOFLayerTB.Location = new System.Drawing.Point(131, 18);
            this.numOFLayerTB.Name = "numOFLayerTB";
            this.numOFLayerTB.Size = new System.Drawing.Size(110, 20);
            this.numOFLayerTB.TabIndex = 0;
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
            // TrainProgressBar
            // 
            this.TrainProgressBar.Location = new System.Drawing.Point(3, 5);
            this.TrainProgressBar.Name = "TrainProgressBar";
            this.TrainProgressBar.Size = new System.Drawing.Size(320, 26);
            this.TrainProgressBar.TabIndex = 3;
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
            this.trainConfigGB.ResumeLayout(false);
            this.netArchitechGB.ResumeLayout(false);
            this.netArchitechGB.PerformLayout();
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
        private System.Windows.Forms.GroupBox trainConfigGB;
        private System.Windows.Forms.GroupBox netArchitechGB;
        private System.Windows.Forms.Button ApplyNumNeuronsBtn;
        private System.Windows.Forms.Button ApplyNumLayerBtn;
        private System.Windows.Forms.TextBox neuronsTB;
        private System.Windows.Forms.Label neuronLbl;
        private System.Windows.Forms.ComboBox LayerSelectorDropMenu;
        private System.Windows.Forms.Label LayerLbl;
        private System.Windows.Forms.Label numLayLbl;
        private System.Windows.Forms.TextBox numOFLayerTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadHistorySettingBtn;
        private System.Windows.Forms.Button ApplyAllSettingBtn;
        private System.Windows.Forms.Button applyConfigBtn;
        private System.Windows.Forms.ComboBox lossFuncDropMenu;
        private System.Windows.Forms.ComboBox optimFuncDropMenu;
        private System.Windows.Forms.ComboBox batchSizeDropMenu;
    }
}


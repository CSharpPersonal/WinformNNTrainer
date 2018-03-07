namespace OnlineNeuralNetworkTrainer
{
    partial class spinner_panel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.spinner_main_panel = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.spinner_PB = new System.Windows.Forms.PictureBox();
            this.spinner_main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinner_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // spinner_main_panel
            // 
            this.spinner_main_panel.Controls.Add(this.spinner_PB);
            this.spinner_main_panel.Controls.Add(this.title_lbl);
            this.spinner_main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinner_main_panel.Location = new System.Drawing.Point(0, 0);
            this.spinner_main_panel.Name = "spinner_main_panel";
            this.spinner_main_panel.Size = new System.Drawing.Size(515, 303);
            this.spinner_main_panel.TabIndex = 0;
            // 
            // title_lbl
            // 
            this.title_lbl.BackColor = System.Drawing.Color.DodgerBlue;
            this.title_lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.title_lbl.Location = new System.Drawing.Point(0, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(515, 58);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "PROCESSING...";
            this.title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spinner_PB
            // 
            this.spinner_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.spinner_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spinner_PB.Image = global::OnlineNeuralNetworkTrainer.Properties.Resources.spinner;
            this.spinner_PB.Location = new System.Drawing.Point(0, 58);
            this.spinner_PB.Name = "spinner_PB";
            this.spinner_PB.Size = new System.Drawing.Size(515, 245);
            this.spinner_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spinner_PB.TabIndex = 1;
            this.spinner_PB.TabStop = false;
            // 
            // spinner_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spinner_main_panel);
            this.Name = "spinner_panel";
            this.Size = new System.Drawing.Size(515, 303);
            this.spinner_main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinner_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel spinner_main_panel;
        private System.Windows.Forms.PictureBox spinner_PB;
        private System.Windows.Forms.Label title_lbl;
    }
}

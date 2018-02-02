namespace OnlineNeuralNetworkTrainer
{
    partial class SpinnerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.processTitleLabel = new System.Windows.Forms.Label();
            this.SpinnerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // processTitleLabel
            // 
            this.processTitleLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.processTitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.processTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processTitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.processTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.processTitleLabel.Name = "processTitleLabel";
            this.processTitleLabel.Size = new System.Drawing.Size(284, 56);
            this.processTitleLabel.TabIndex = 1;
            this.processTitleLabel.Text = "PROCESSING";
            this.processTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpinnerPictureBox
            // 
            this.SpinnerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SpinnerPictureBox.Image = global::OnlineNeuralNetworkTrainer.Properties.Resources.spinner;
            this.SpinnerPictureBox.Location = new System.Drawing.Point(12, 59);
            this.SpinnerPictureBox.Name = "SpinnerPictureBox";
            this.SpinnerPictureBox.Size = new System.Drawing.Size(260, 152);
            this.SpinnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpinnerPictureBox.TabIndex = 0;
            this.SpinnerPictureBox.TabStop = false;
            // 
            // SpinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.processTitleLabel);
            this.Controls.Add(this.SpinnerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpinnerForm";
            this.ShowInTaskbar = false;
            this.Text = "SpinnerForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SpinnerPictureBox;
        private System.Windows.Forms.Label processTitleLabel;
    }
}
namespace OnlineNeuralNetworkTrainer
{
    partial class DataStructureBrowserForm
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
            this.structWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // structWebBrowser
            // 
            this.structWebBrowser.AllowNavigation = false;
            this.structWebBrowser.AllowWebBrowserDrop = false;
            this.structWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.structWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.structWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.structWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.structWebBrowser.Name = "structWebBrowser";
            this.structWebBrowser.ScrollBarsEnabled = false;
            this.structWebBrowser.Size = new System.Drawing.Size(363, 348);
            this.structWebBrowser.TabIndex = 0;
            this.structWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.structWebBrowser_DocumentCompleted);
            // 
            // DataStructureBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 348);
            this.Controls.Add(this.structWebBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DataStructureBrowserForm";
            this.Text = "DataStructureBrowserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataStructureBrowserForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser structWebBrowser;
    }
}
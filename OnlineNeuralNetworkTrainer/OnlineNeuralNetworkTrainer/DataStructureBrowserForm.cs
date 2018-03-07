using System.IO;
using System;
using System.Windows.Forms;

namespace OnlineNeuralNetworkTrainer
{
    public partial class DataStructureBrowserForm : Form
    {
        private MainForm parentForm;
        public DataStructureBrowserForm(MainForm ParentForm)
        {
            InitializeComponent();
            this.parentForm = ParentForm;
            string html_dir = Path.GetDirectoryName(Application.ExecutablePath) + "\\html\\index.html";
            this.structWebBrowser.Url = new Uri(html_dir);
        }

        public void RefreshBrowser()
        {
            this.structWebBrowser.Refresh();
        }

        private void DataStructureBrowserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.CallBackOnDSBFClosed();
        }

        private void structWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (structWebBrowser.ReadyState == WebBrowserReadyState.Complete)
            {

            }
        }
    }
}

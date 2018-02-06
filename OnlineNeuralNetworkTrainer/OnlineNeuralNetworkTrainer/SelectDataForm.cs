using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineNeuralNetworkTrainer
{
    public partial class SelectDataForm : Form
    {
        private MainForm entryForm;
        Thread Spinner_th;
        SpinnerForm sf = new SpinnerForm();
        public SelectDataForm(MainForm entryForm)
        {
            InitializeComponent();
            this.entryForm = entryForm;
        }

        private void sdf_cancel_btn_Click(object sender, EventArgs e)
        {
            if (BGW_loadDB.IsBusy)
            {
                BGW_loadDB.CancelAsync();
            }
            SystemManager.dbm.selectedData = null;
            this.Hide();
            entryForm.onSDFSelectedData(false);
            entryForm.Show();
        }

        private void sdf_selectAll_btn_Click(object sender, EventArgs e)
        {
            this.sdf_progbar.Value = 0;
            this.sdf_upper_panel.Enabled = false;
            this.sdf_mid_panel.Enabled = false;
            this.sdf_confirm_btn.Enabled = false;
            BGW_loadDB.RunWorkerAsync();
            
        }

        private void sdf_confirm_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            entryForm.onSDFSelectedData(true);
            entryForm.Show();
        }

        private void BGW_loadDB_DoWork(object sender, DoWorkEventArgs e)
        {
            SystemManager.dbm.SelectAllData(this.BGW_loadDB);
        }
        private void BGW_loadDB_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.sdf_progress_lbl.Text = e.UserState.ToString();
            this.sdf_progbar.Value = e.ProgressPercentage;
        }
        private void BGW_loadDB_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.sdf_upper_panel.Enabled = true;
            this.sdf_mid_panel.Enabled = true;
            this.sdf_confirm_btn.Enabled = true;
        }
    }
}

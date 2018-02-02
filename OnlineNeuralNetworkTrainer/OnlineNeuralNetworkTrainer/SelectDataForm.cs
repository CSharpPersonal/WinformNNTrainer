using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineNeuralNetworkTrainer
{
    public partial class SelectDataForm : Form
    {
        public SelectDataForm()
        {
            InitializeComponent();
        }

        private void sdf_cancel_btn_Click(object sender, EventArgs e)
        {
            SystemManager.dbm.selectedData = null;
            this.Hide();
        }

        private void sdf_selectAll_btn_Click(object sender, EventArgs e)
        {
            SystemManager.dbm.SelectAllData();
        }

        private void sdf_confirm_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

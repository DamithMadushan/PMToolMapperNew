using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTM.Model.Models;

namespace PMToolMapper
{
    public partial class DataLoading : UserControl
    {
        public DataLoading()
        {
            InitializeComponent();
        }

        private void DataLoading_Load(object sender, EventArgs e)
        {
            lblLoading.Text = LoadingMessage.Loadingmsg;
        }



        private void lblLoading_Click(object sender, EventArgs e)
        {

        }
    }
}

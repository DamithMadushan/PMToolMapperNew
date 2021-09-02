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
    public partial class TFSInfo : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler OkButtonClickTFS;

        public TFSInfo()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxOrganization.Text) && !string.IsNullOrEmpty(textBoxToken.Text))
            {
                TFSInfoModel.Organization = textBoxOrganization.Text;
                TFSInfoModel.Token = textBoxToken.Text;

                OkButtonClickTFS(this, e);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

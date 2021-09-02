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
    public partial class JiraInfo : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler OkButtonClickJira;

        public JiraInfo()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxUrl.Text) && !string.IsNullOrEmpty(textBoxEmail.Text) && !string.IsNullOrEmpty(textBoxToken.Text))
            {
                JiraInfoModel.Url = textBoxUrl.Text;
                JiraInfoModel.Email = textBoxEmail.Text;
                JiraInfoModel.Token = textBoxToken.Text;

                OkButtonClickJira(this, e);
            }


        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void lblpm_Click(object sender, EventArgs e)
        {

        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxToken_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

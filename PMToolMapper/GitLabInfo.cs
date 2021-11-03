using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMToolMapper
{
    public partial class GitLabInfo : UserControl
    {

        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler OkButtonClickGitLab;

        public GitLabInfo()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            GitLabInfoModel.userid = textBoxUserId.Text;
            GitLabInfoModel.token = textBoxToken.Text;

            OkButtonClickGitLab(this, e);
        }
    }
}

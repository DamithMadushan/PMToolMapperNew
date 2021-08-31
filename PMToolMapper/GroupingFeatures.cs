using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTM.BusinessLogic;

namespace PMToolMapper
{
    public partial class GroupingFeatures : UserControl
    {
        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        public event EventHandler OkButtonClick;

        public GroupingFeatures()
        {
            InitializeComponent();
        }

        private void GroupingFeatures_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {

            MappingTempData.commonBasic = basicCheckbox.Checked;
            MappingTempData.commonAdvanced = advancedchkbox.Checked;
            MappingTempData.extraFeatures = extrachkbox.Checked;

            OkButtonClick(this, e);

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            basicCheckbox.Checked = false;
            advancedchkbox.Checked = false;
            extrachkbox.Checked = false;
        }
    }
}

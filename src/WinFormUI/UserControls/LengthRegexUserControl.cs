using System;
using System.Windows.Forms;

namespace SocanCode.UserControls
{
    public partial class LengthRegexUserControl : UserControl
    {
        public event EventHandler ButtonClick;
        public LengthRegexUserControl()
        {
            InitializeComponent();
        }

        private void btnGenLength_Click(object sender, EventArgs e)
        {
            if (ButtonClick != null)
                ButtonClick(sender, e);
        }

        private void txtMinLength_ValueChanged(object sender, EventArgs e)
        {
            if (txtMinLength.Value != txtMaxLength.Value)
                btnGenLength.Text = string.Format("{{{0},{1}}}", txtMinLength.Value < 0 ? "" : txtMinLength.Value.ToString(),
                    txtMaxLength.Value < 0 ? "" : txtMaxLength.Value.ToString());
            else
                btnGenLength.Text = string.Format("{{{0}}}", txtMinLength.Value < 0 ? "" : txtMinLength.Value.ToString());
        }
    }
}

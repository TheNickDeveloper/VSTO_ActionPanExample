using System;
using System.Windows.Forms;

namespace VSTO_example
{
    public partial class UserControlCustomPan : UserControl
    {
        public UserControlCustomPan()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ogText = txbFilePath.Text;
            var fileFolderBrowser = new FileFolderBrowser();
            txbFilePath.Text = fileFolderBrowser.GetFilePath(ogText);
        }
    }
}

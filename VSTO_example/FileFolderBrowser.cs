using System.Windows.Forms;

namespace VSTO_example
{
    public class FileFolderBrowser
    {
        public string GetFilePath(string ogText)
        {
            var openFileDia = new OpenFileDialog();
            return openFileDia.ShowDialog() == DialogResult.OK
                ? openFileDia.FileName : ogText;
        }

        public string GetFolderPath(string ogText)
        {
            var openFolderDia = new FolderBrowserDialog();

            return openFolderDia.ShowDialog() == DialogResult.OK
                ? openFolderDia.SelectedPath : ogText;
        }
    }
}

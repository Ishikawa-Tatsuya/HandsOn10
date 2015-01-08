using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsTarget
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonMessageBoxClick(object sender, EventArgs e)
        {
            MessageBox.Show("Msg");
        }

        private void ButtonFileClick(object sender, EventArgs e)
        {
            string path = string.Empty;
            using (var dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                path = dlg.FileName;
            }
            ExecuteFilePathCore(path);
        }

        private void ExecuteFilePathCore(string path)
        {
            //本当はもっと難しい処理
            Text = path;
        }

        private void ButtonFolderClick(object sender, EventArgs e)
        {
            string path = string.Empty;
            using (var dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                path = dlg.SelectedPath;
            }
            ExecuteFilePathCore(path);
        }

        private void ExecuteFolderPathCore(string path)
        {
            //本当はもっと難しい処理
            Text = path;
        }
    }
}

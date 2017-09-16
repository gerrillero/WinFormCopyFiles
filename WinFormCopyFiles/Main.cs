using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormCopyFiles
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            txbFrom.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            txbTo.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }

        private void txbFrom_Click(object sender, EventArgs e)
        {
            //ChooseFolder(sender as TextBox);
        }

        private void txbTo_Click(object sender, EventArgs e)
        {
            //ChooseFolder(sender as TextBox);
        }


        private void ChooseFolder(Button sender)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                String path = folderBrowserDialog1.SelectedPath;
                if (sender.Name == btnFromDialog.Name)
                    txbFrom.Text = path;
                else if (sender.Name == btnToDialog.Name)
                    txbTo.Text = path;

            }
        }

        //private void ChooseFolder(TextBox sender)
        //{
        //    DialogResult result = folderBrowserDialog1.ShowDialog();
        //    if (result == DialogResult.OK)
        //    {
        //        String path = folderBrowserDialog1.SelectedPath;
        //        sender.Text = path;
        //    }
        //}

        private void btnCopy_Click(object sender, EventArgs e)
        {
            String origPath = txbFrom.Text;
            String desPath = txbTo.Text;

            DateTime modifiedDate = dtpModified.Value.Date + dtpModifiedTime.Value.TimeOfDay;

            if (String.IsNullOrEmpty(origPath))
                errorProvider1.SetError(txbFrom, "Choose the directory to cope files");
                //MessageBox.Show("Choose the from directory");
            else if (String.IsNullOrEmpty(desPath))
                errorProvider1.SetError(txbTo, "Choose the directory to cope files");
                //MessageBox.Show("Choose the directory to cope files");
            else if (modifiedDate == null)
                errorProvider1.SetError(dtpModified, "Choose the modified date");
                //MessageBox.Show("Choose the modified date");
            else
            {
                FilesHelper.CopyDirectorySpecific(origPath, desPath, true, modifiedDate);

                DirectoryInfo dir = new DirectoryInfo(desPath);
                FilesHelper.DeleteFoldersIfEmpty(dir);
                MessageBox.Show("Completed!");
            }
        }

        private void btnFromDialog_Click(object sender, EventArgs e)
        {
            ChooseFolder(sender as Button);
        }

        private void btnToDialog_Click(object sender, EventArgs e)
        {
            ChooseFolder(sender as Button);
        }
    }
}

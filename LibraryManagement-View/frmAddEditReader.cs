using LibraryManagement_Controller;
using LibraryManagement_Model;
using MetroFramework.Controls;
using System.Linq;
using System.Windows.Forms;

namespace LibraryManagement_View
{
    public partial class frmAddEditReader : MetroFramework.Forms.MetroForm
    {
        ReaderController _controller;
        bool IsNew;

        public frmAddEditReader(Reader obj)
        {
            InitializeComponent();
            _controller = new ReaderController();

            if (obj == null)
            {
                readerBindingSource.DataSource = new Reader();
                IsNew = true;
            }
            else
            {
                readerBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void frmAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if ((Controls.OfType<MetroTextBox>().Any(t => string.IsNullOrEmpty(t.Text))))
                {
                    MessageBox.Show("Please enter all required data.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Cancel = true;
                    return;
                }
                if (IsNew)
                    _controller.Insert(readerBindingSource.Current as Reader);
                else
                    _controller.Update(readerBindingSource.Current as Reader);
            }
        }
    }
}

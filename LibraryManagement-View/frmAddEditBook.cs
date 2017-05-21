using LibraryManagement_Model;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement_Controller;
using MetroFramework.Controls;

namespace LibraryManagement_View
{
    public partial class frmAddEditBook : MetroFramework.Forms.MetroForm
    {
        BookController _controller;
        bool IsNew;

        public frmAddEditBook(Book obj)
        {
            InitializeComponent();
            _controller = new BookController();

            if (obj == null)
            {
                bookBindingSource.DataSource = new Book();
                IsNew = true;
                metroCheckBox1.Visible = false;
            }
            else
            {
                bookBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void frmAddBook_FormClosing(object sender, FormClosingEventArgs e)
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
                    _controller.Insert(bookBindingSource.Current as Book);
                else
                    _controller.Update(bookBindingSource.Current as Book);
            }
        }
    }
}

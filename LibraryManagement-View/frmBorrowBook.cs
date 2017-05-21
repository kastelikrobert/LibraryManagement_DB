using LibraryManagement_Controller;
using LibraryManagement_Model;
using System;
using System.Windows.Forms;

namespace LibraryManagement_View
{
    public partial class frmBorrowBook : MetroFramework.Forms.MetroForm
    {
        BookController _controller;
        int readerid;

        public frmBorrowBook(Loan obj, Reader rdr)
        {
            InitializeComponent();
            _controller = new BookController();
            readerBindingSource.DataSource = rdr;
            readerid = rdr.idReader;
        }

        private void frmBorrowBook_Load(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = _controller.GetAll();
        }

        private void frmBorrowBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
                _controller.Update(bookBindingSource.Current as Book);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (_controller.IsAvailable(bookBindingSource.Current as Book))
            {
                using (frmConfirmBorrow frm = new frmConfirmBorrow(bookBindingSource.Current as Book, readerid))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        _controller.ChangeAvailability(bookBindingSource.Current as Book);
                        bookBindingSource.DataSource = _controller.GetAll();
                    }
                }
            }
            else
            {
                MessageBox.Show("Book is not available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
            {
                if (metroComboBox1.SelectedItem.ToString() == "On Loan")
                    bookBindingSource.DataSource = _controller.SearchBook(txtSearch.Text, false);
                if (metroComboBox1.SelectedItem.ToString() == "Available")
                    bookBindingSource.DataSource = _controller.SearchBook(txtSearch.Text, true);
                if (metroComboBox1.SelectedItem.ToString() == "All")
                    bookBindingSource.DataSource = _controller.SearchBook(txtSearch.Text, null);
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }
    }
}

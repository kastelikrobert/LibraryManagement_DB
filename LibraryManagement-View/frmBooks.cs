using System;
using System.Windows.Forms;
using LibraryManagement_Controller;
using LibraryManagement_Model;
using LibraryManagement;

namespace LibraryManagement_View
{
    public partial class frmBooks : MetroFramework.Forms.MetroForm
    {
        BookController _controller;

        public frmBooks()
        {
            InitializeComponent();
            _controller = new BookController();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedItem = "All";
            bookBindingSource.DataSource = _controller.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditBook frm = new frmAddEditBook(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    bookBindingSource.DataSource = _controller.GetAll();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Current == null)
                return;

            using (frmAddEditBook frm = new frmAddEditBook(bookBindingSource.Current as Book))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    bookBindingSource.DataSource = _controller.GetAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bookBindingSource.Current == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _controller.Delete(bookBindingSource.Current as Book);
                bookBindingSource.RemoveCurrent();
            }
        }

        private void txtSearch_textChange(object sender, EventArgs e)
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
            txtSearch_textChange(sender, e);
        }

        private void btnLoanDetails_Click(object sender, EventArgs e)
        {
            using (frmLoanDetails frm = new frmLoanDetails(bookBindingSource.Current as Book))
            {
                Hide();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    Show();
                    Activate();
                }
            }
        }

        private void btnReaders_Click(object sender, EventArgs e)
        {
            frmReaders frm = new frmReaders();
            frm.Visible = true;
            this.Hide();
        }
    }
}

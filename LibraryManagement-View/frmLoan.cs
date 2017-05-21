using LibraryManagement_Controller;
using LibraryManagement_Model;
using System;
using System.Windows.Forms;

namespace LibraryManagement_View
{
    public partial class frmLoan : MetroFramework.Forms.MetroForm
    {
        LoanController _controller;

        public frmLoan(Reader obj)
        {
            InitializeComponent();
            _controller = new LoanController();

            if (obj == null)
            {
                readerBindingSource.DataSource = new Reader();
            }
            else
            {
                readerBindingSource.DataSource = obj;
            }
        }

        private void frmLoan_Load(object sender, EventArgs e)
        {
            loanBindingSource.DataSource = _controller.GetByReaders(readerBindingSource.DataSource as Reader);
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (loanBindingSource.Current != null)
            {
                using (frmReturn frm = new frmReturn(loanBindingSource.Current as Loan, readerBindingSource.DataSource as Reader))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                        _controller.BookReturned(loanBindingSource.Current as Loan);
                    loanBindingSource.DataSource = _controller.GetByReaders(readerBindingSource.DataSource as Reader);
                }
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox1.SelectedItem.ToString() == "On Loan")
                loanBindingSource.DataSource = _controller.ShowBooksOnLoan(readerBindingSource.DataSource as Reader);
            if (metroComboBox1.SelectedItem.ToString() == "Returned")
                loanBindingSource.DataSource = _controller.ShowReturnedBooks(readerBindingSource.DataSource as Reader);
            if (metroComboBox1.SelectedItem.ToString() == "All Results")
                loanBindingSource.DataSource = _controller.GetByReaders(readerBindingSource.DataSource as Reader);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            using (frmBorrowBook frm = new frmBorrowBook(loanBindingSource.Current as Loan, readerBindingSource.DataSource as Reader))
            {
                this.Hide();
                if (frm.ShowDialog() == DialogResult.OK)
                    loanBindingSource.DataSource = _controller.GetByReaders(readerBindingSource.DataSource as Reader);
            }
            this.Show();
            this.Activate();
        }
    }
}
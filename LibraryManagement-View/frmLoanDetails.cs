using LibraryManagement_Controller;
using LibraryManagement_Model;
using System;

namespace LibraryManagement
{
    public partial class frmLoanDetails : MetroFramework.Forms.MetroForm
    {
        LoanController _controller;

        public frmLoanDetails(Book bk)
        {
            InitializeComponent();
            _controller = new LoanController();
            bookBindingSource.DataSource = bk;

        }

        private void frmLoanDetails_Load(object sender, EventArgs e)
        {
            loanBindingSource.DataSource = _controller.GetByBooks(bookBindingSource.Current as Book);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (loanBindingSource.Current != null)
            {
                frmShowOwner frm = new frmShowOwner(loanBindingSource.Current as Loan);
                frm.Visible = true;
            }
        }
    }
}

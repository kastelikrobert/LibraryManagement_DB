using LibraryManagement_Controller;
using LibraryManagement_Model;
using System;
using System.Windows.Forms;

namespace LibraryManagement_View
{
    public partial class frmConfirmBorrow : MetroFramework.Forms.MetroForm
    {
        LoanController _controller;
        int bookid;
        int readerid;

        public frmConfirmBorrow(Book book, int idreader)
        {
            InitializeComponent();
            _controller = new LoanController();
            bookBindingSource.DataSource = book;
            bookid = book.idBook;
            readerid = idreader;
        }

        private void ConfirmBorrow_Load(object sender, EventArgs e)
        {
            this.bookTableAdapter.Fill(this.dbLibraryDataSet1.Book);
        }

        private void frmConfirmBorrow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult==DialogResult.OK)
            {
                Loan loan = new Loan();
                loan.fkBook = bookid;
                loan.fkReader = readerid;
                loan.dateOut = System.DateTime.Now;

                _controller.Insert(loan);
                _controller.Update(loan);

            }
        }
    }
}

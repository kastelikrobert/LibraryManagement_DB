using LibraryManagement_Controller;
using LibraryManagement_Model;
using System;

namespace LibraryManagement_View
{
    public partial class frmReturn : MetroFramework.Forms.MetroForm
    {
        BookController _controller;
        int readerid;
        int? bookfk;
        int? readerfk;
        DateTime? returnDate;

        public frmReturn(Loan obj, Reader rdr)
        {
            InitializeComponent();
            _controller = new BookController();

            readerfk = obj.fkReader;
            bookfk = obj.fkBook;
            readerid = rdr.idReader;
            returnDate = obj.dateReturn;
        }

        private void frmReturn_Load(object sender, EventArgs e)
        {
            this.loanTableAdapter.Fill(this.dbLibraryDataSet2.Loan);
            bookBindingSource.DataSource = _controller.GetAll();

            bookBindingSource.DataSource = _controller.GetById(bookfk);

            if (returnDate != null)
            {
                btnConfirm.Visible = false;
                labelReturnDate.Visible = true;
                labelReturnDate2.Visible = true;
                Text = "Loan Details";
            }
       }

       private void btnConfirm_Click(object sender, EventArgs e)
       {
           _controller.ChangeAvailability(bookBindingSource.Current as Book);
       }
        
    }
}

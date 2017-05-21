using LibraryManagement_Controller;
using LibraryManagement_Model;
using System;

namespace LibraryManagement
{
    public partial class frmShowOwner : MetroFramework.Forms.MetroForm
    { 
        ReaderController _controller;
        int? bookfk;
        int? readerfk;

        public frmShowOwner(Loan loan)
        {
            InitializeComponent();
            _controller = new ReaderController();

            bookfk = loan.fkBook;
            readerfk = loan.fkReader;
        }

        private void frmShowOwner_Load(object sender, EventArgs e)
        {
            readerBindingSource.DataSource = _controller.GetAll();
            readerBindingSource.DataSource = _controller.GetById(readerfk);
        }
    }
}
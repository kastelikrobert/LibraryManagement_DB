using LibraryManagement_Controller;
using LibraryManagement_Model;
using System;
using System.Windows.Forms;

namespace LibraryManagement_View
{
    public partial class frmReaders : MetroFramework.Forms.MetroForm
    {
        ReaderController _controller;

        public frmReaders()
        {
            InitializeComponent();
            _controller = new ReaderController();
        }

        public void frmReaders_Load(object sender, EventArgs e)
        {
            readerBindingSource.DataSource = _controller.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditReader frm = new frmAddEditReader(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    readerBindingSource.DataSource = _controller.GetAll();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (readerBindingSource.Current == null)
                return;

            using (frmAddEditReader frm = new frmAddEditReader(readerBindingSource.Current as Reader))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    readerBindingSource.DataSource = _controller.GetAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (readerBindingSource.Current == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _controller.Delete(readerBindingSource.Current as Reader);
                readerBindingSource.RemoveCurrent();
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            frmBooks frm = new frmBooks();
            frm.Visible = true;
            this.Hide();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            using (frmLoan frm = new frmLoan(readerBindingSource.Current as Reader))
            {
                Hide();
                if (frm.ShowDialog() == DialogResult.Cancel)
                {
                    Show();
                    Activate();
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != null)
            {
                readerBindingSource.DataSource = _controller.SearchReader(txtSearch.Text);
            }
        }
    }
}

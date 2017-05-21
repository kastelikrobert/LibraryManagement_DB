namespace LibraryManagement
{
    partial class frmLoanDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDetails = new MetroFramework.Controls.MetroTile();
            this.grdBooks = new MetroFramework.Controls.MetroGrid();
            this.idLoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkReaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLibraryDataSet2 = new LibraryManagement_View.dbLibraryDataSet2();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbLibraryDataSet1 = new LibraryManagement_View.dbLibraryDataSet1();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bookTableAdapter = new LibraryManagement_View.dbLibraryDataSet1TableAdapters.BookTableAdapter();
            this.loanTableAdapter = new LibraryManagement_View.dbLibraryDataSet2TableAdapters.LoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.ActiveControl = null;
            this.btnDetails.Location = new System.Drawing.Point(23, 383);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(80, 80);
            this.btnDetails.Style = MetroFramework.MetroColorStyle.Black;
            this.btnDetails.TabIndex = 19;
            this.btnDetails.Text = "Loan\r\nDetails";
            this.btnDetails.UseSelectable = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // grdBooks
            // 
            this.grdBooks.AllowUserToAddRows = false;
            this.grdBooks.AllowUserToDeleteRows = false;
            this.grdBooks.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.grdBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBooks.AutoGenerateColumns = false;
            this.grdBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLoanDataGridViewTextBoxColumn,
            this.fkReaderDataGridViewTextBoxColumn,
            this.fkBookDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.dateReturnDataGridViewTextBoxColumn});
            this.grdBooks.DataSource = this.loanBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBooks.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdBooks.EnableHeadersVisualStyles = false;
            this.grdBooks.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdBooks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdBooks.Location = new System.Drawing.Point(324, 60);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.grdBooks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.grdBooks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.grdBooks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBooks.Size = new System.Drawing.Size(516, 403);
            this.grdBooks.Style = MetroFramework.MetroColorStyle.Black;
            this.grdBooks.TabIndex = 17;
            // 
            // idLoanDataGridViewTextBoxColumn
            // 
            this.idLoanDataGridViewTextBoxColumn.DataPropertyName = "idLoan";
            this.idLoanDataGridViewTextBoxColumn.HeaderText = "Loan ID";
            this.idLoanDataGridViewTextBoxColumn.Name = "idLoanDataGridViewTextBoxColumn";
            this.idLoanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fkReaderDataGridViewTextBoxColumn
            // 
            this.fkReaderDataGridViewTextBoxColumn.DataPropertyName = "fkReader";
            this.fkReaderDataGridViewTextBoxColumn.HeaderText = "Reader ID";
            this.fkReaderDataGridViewTextBoxColumn.Name = "fkReaderDataGridViewTextBoxColumn";
            // 
            // fkBookDataGridViewTextBoxColumn
            // 
            this.fkBookDataGridViewTextBoxColumn.DataPropertyName = "fkBook";
            this.fkBookDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.fkBookDataGridViewTextBoxColumn.Name = "fkBookDataGridViewTextBoxColumn";
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "dateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "Loan Date";
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            // 
            // dateReturnDataGridViewTextBoxColumn
            // 
            this.dateReturnDataGridViewTextBoxColumn.DataPropertyName = "dateReturn";
            this.dateReturnDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.dateReturnDataGridViewTextBoxColumn.Name = "dateReturnDataGridViewTextBoxColumn";
            // 
            // loanBindingSource
            // 
            this.loanBindingSource.DataMember = "Loan";
            this.loanBindingSource.DataSource = this.dbLibraryDataSet2;
            // 
            // dbLibraryDataSet2
            // 
            this.dbLibraryDataSet2.DataSetName = "dbLibraryDataSet2";
            this.dbLibraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(23, 213);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(54, 25);
            this.metroLabel8.TabIndex = 29;
            this.metroLabel8.Text = "ISBN:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(23, 188);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 25);
            this.metroLabel7.TabIndex = 30;
            this.metroLabel7.Text = "Title:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(23, 138);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(34, 25);
            this.metroLabel11.TabIndex = 31;
            this.metroLabel11.Text = "ID:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(23, 163);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 25);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Author:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "ISBN", true));
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(171, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "ISBN";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.dbLibraryDataSet1;
            // 
            // dbLibraryDataSet1
            // 
            this.dbLibraryDataSet1.DataSetName = "dbLibraryDataSet1";
            this.dbLibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(171, 188);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 25);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Title";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "idBook", true));
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(171, 138);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(28, 25);
            this.metroLabel12.TabIndex = 25;
            this.metroLabel12.Text = "ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(171, 163);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 25);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Author";
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // loanTableAdapter
            // 
            this.loanTableAdapter.ClearBeforeFill = true;
            // 
            // frmLoanDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 489);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.grdBooks);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoanDetails";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Book Loan Details";
            this.Load += new System.EventHandler(this.frmLoanDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnDetails;
        private MetroFramework.Controls.MetroGrid grdBooks;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private LibraryManagement_View.dbLibraryDataSet1 dbLibraryDataSet1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryManagement_View.dbLibraryDataSet1TableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryManagement_View.dbLibraryDataSet2 dbLibraryDataSet2;
        private System.Windows.Forms.BindingSource loanBindingSource;
        private LibraryManagement_View.dbLibraryDataSet2TableAdapters.LoanTableAdapter loanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLoanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkReaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReturnDataGridViewTextBoxColumn;
    }
}
using System;
using System.Collections.Generic;

namespace LibraryManagement_Model
{
    public partial class Loan
    {
        public int idLoan { get; set; }
        public int? fkReader { get; set; }
        public int? fkBook { get; set; }
        public DateTime? dateOut { get; set; }
        public DateTime? dateReturn { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Reader Reader { get; set; }
    }
}

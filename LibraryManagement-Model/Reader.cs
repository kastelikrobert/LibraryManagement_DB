using System.Collections.Generic;

namespace LibraryManagement_Model
{

    public partial class Reader
    {
        public Reader()
        {
            this.Loan = new HashSet<Loan>();
        }
    
        public int idReader { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    
        public virtual ICollection<Loan> Loan { get; set; }
    }
}

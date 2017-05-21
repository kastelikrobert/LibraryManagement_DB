using System.Collections.Generic;

namespace LibraryManagement_Model
{
    public partial class Book
    {
        public Book()
        {
            this.Loan = new HashSet<Loan>();
        }
    
        public int idBook { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public bool isAvailable { get; set; }
    
        public virtual ICollection<Loan> Loan { get; set; }
    }
}

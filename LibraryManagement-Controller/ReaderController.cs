using System.Collections.Generic;
using System.Linq;
using LibraryManagement_Model;

namespace LibraryManagement_Controller
{
    public class ReaderController
    {
        public IEnumerable<Reader> SearchReader(string txtSearch)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                txtSearch = txtSearch.ToLower();
                if (txtSearch != "")
                {
                    var query = from items in db.Reader
                                where items.FirstName.ToLower().Contains(txtSearch)
                                || items.LastName.ToLower().Contains(txtSearch)
                                || items.Email.ToLower().Contains(txtSearch)
                                || items.Adress.ToLower().Contains(txtSearch)
                                || items.Phone.ToLower().Contains(txtSearch)
                                select items;

                    return query.ToList();
                }
                else
                {
                    return db.Reader.ToList();
                }
            }
        }

        public void Delete(Reader obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                foreach (var loan in db.Loan.Where(x => x.fkReader == obj.idReader))
                {
                    db.Loan.Attach(loan);
                    db.Loan.Remove(loan);

                    foreach (var book in db.Book.Where(x => x.idBook == loan.fkBook))
                    {
                        book.isAvailable = true;
                    }
                };

                db.Reader.Attach(obj);
                db.Reader.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Reader> GetAll()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                return db.Reader.ToList();
            }
        }

        public Reader GetById(int? id)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                return db.Reader.Find(id);
            }
        }

        public Reader Insert(Reader obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Reader.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Reader obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Reader.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

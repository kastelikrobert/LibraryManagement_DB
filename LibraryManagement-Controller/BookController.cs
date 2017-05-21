using System.Collections.Generic;
using System.Linq;
using LibraryManagement_Model;

namespace LibraryManagement_Controller
{
    public class BookController
    {
        public bool IsAvailable(Book obj)
        {
            return obj.isAvailable;
        }

        public void ChangeAvailability(Book obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                obj.isAvailable = !(obj.isAvailable);
                db.Book.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public IEnumerable<Book> SearchBook(string txtSearch, bool? availability)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                txtSearch = txtSearch.ToLower();

                if (availability != null)
                {
                    var searchAvailable = from items in db.Book
                                where (items.isAvailable == availability)
                                && (items.Author.ToLower().Contains(txtSearch)
                                || items.Title.ToLower().Contains(txtSearch)
                                || items.ISBN.ToLower().Contains(txtSearch))
                                select items;

                    return searchAvailable.ToList();
                }
                else
                {
                    var search = from items in db.Book
                                where items.Author.ToLower().Contains(txtSearch)
                                || items.Title.ToLower().Contains(txtSearch)
                                || items.ISBN.ToLower().Contains(txtSearch)
                                select items;

                    return search.ToList();
                }
            }
        }

        public void Delete(Book obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                foreach (var item in db.Loan.Where(x => x.fkBook == obj.idBook))
                {
                    db.Loan.Attach(item);
                    db.Loan.Remove(item);
                };

                db.Book.Attach(obj);
                db.Book.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Book> GetAll()
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                return db.Book.ToList();
            }
        }

        public Book GetById(int? id)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                return db.Book.Find(id);
            }
        }

        public int GetID(Book obj)
        {
                return obj.idBook;
        }


        public Book Insert(Book obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                obj.isAvailable = true;
                db.Book.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Book obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Book.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}


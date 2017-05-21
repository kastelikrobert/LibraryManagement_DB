using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagement_Model;

namespace LibraryManagement_Controller
{
    public class LoanController
    {
        public IEnumerable<Loan> ShowBooksOnLoan(Reader obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var query = from items in db.Loan
                            where (items.dateReturn==null)
                            && (items.fkReader == obj.idReader)
                            select items;
                return query.ToList();
            }
        }

        public IEnumerable<Loan> ShowReturnedBooks(Reader obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var query = from items in db.Loan
                            where (items.dateReturn!=null)
                            && (items.fkReader == obj.idReader)
                            select items;
                return query.ToList();
            }
        }

        public void BookReturned(Loan obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                obj.dateReturn = DateTime.Now;
                db.Loan.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(Loan obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Loan.Attach(obj);
                db.Loan.Remove(obj);
                db.SaveChanges();
            }
        }

        public List<Loan> GetByReaders(Reader obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var query = from items in db.Loan
                            where (items.fkReader==obj.idReader)
                            select items;

                return query.ToList();
            }
        }

        public List<Loan> GetByBooks(Book obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var query = from items in db.Loan
                            where (items.fkBook == obj.idBook)
                            select items;

                return query.ToList();
            }
        }

        public Loan GetById(int id)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                return db.Loan.Find(id);
            }
        }

        public Loan Insert(Loan obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Loan.Add(obj);
                db.SaveChanges();
                return obj;
            }
        }

        public void Update(Loan obj)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                db.Loan.Attach(obj);
                db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}

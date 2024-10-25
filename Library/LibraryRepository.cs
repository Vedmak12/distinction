using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class LibraryRepository
    {
        private List<Book> _books;
        private List<Member> _members;
        private List<Loan> _loans;

        public LibraryRepository()
        {
            _books = new List<Book>();
            _members = new List<Member>();
            _loans = new List<Loan>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        public List<Book> GetAllBooks()
        {
            return _books;
        }

        public bool LoanBook(int bookId, int memberId)
        {
            var book = _books.FirstOrDefault(b => b.Id == bookId && b.IsAvailable);
            var member = _members.FirstOrDefault(m => m.Id == memberId);

            if (book != null && member != null)
            {
                book.IsAvailable = false;
                _loans.Add(new Loan { BookId = bookId, MemberId = memberId });
                return true;
            }

            return false;
        }
    }
}

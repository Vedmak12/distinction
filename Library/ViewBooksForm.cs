using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Library
{
    public partial class ViewBooksForm : Form
    {
        private LibraryRepository _libraryRepository;

        public ViewBooksForm(LibraryRepository libraryRepository)
        {
            InitializeComponent();
            _libraryRepository = libraryRepository;
            LoadBooks();
        }

        private void LoadBooks()
        {
            listBoxBooks.Items.Clear();
            List<Book> books = _libraryRepository.GetAllBooks();
            foreach (var book in books)
            {
                listBoxBooks.Items.Add(book.DisplayInfo());
            }
        }
    }
}

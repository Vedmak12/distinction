using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBookForm : Form
    {
        private LibraryRepository _libraryRepository;

        public AddBookForm(LibraryRepository libraryRepository)
        {
            InitializeComponent();
            _libraryRepository = libraryRepository;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var book = new Book
            {
                Id = int.Parse(textBoxId.Text),
                Title = textBoxTitle.Text,
                Author = textBoxAuthor.Text,
                IsAvailable = true
            };

            _libraryRepository.AddBook(book);
            MessageBox.Show("Book added successfully.");
            this.Close();
        }
    }
}

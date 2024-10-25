using System;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        private LibraryRepository _libraryRepository;

        public Form1()
        {
            InitializeComponent();
            _libraryRepository = new LibraryRepository();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            var addBookForm = new AddBookForm(_libraryRepository);
            addBookForm.ShowDialog();
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            var addMemberForm = new AddMemberForm(_libraryRepository);
            addMemberForm.ShowDialog();
        }

        private void buttonViewBooks_Click(object sender, EventArgs e)
        {
            var viewBooksForm = new ViewBooksForm(_libraryRepository);
            viewBooksForm.ShowDialog();
        }

        private void buttonLoanBook_Click(object sender, EventArgs e)
        {
            var loanForm = new LoanBookForm(_libraryRepository);
            loanForm.ShowDialog();
        }
    }
}

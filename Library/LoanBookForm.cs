using System;
using System.Windows.Forms;

namespace Library
{
    public partial class LoanBookForm : Form
    {
        private LibraryRepository _libraryRepository;

        public LoanBookForm(LibraryRepository libraryRepository)
        {
            InitializeComponent();
            _libraryRepository = libraryRepository;
        }

        private void buttonLoan_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(textBoxBookId.Text);
            int memberId = int.Parse(textBoxMemberId.Text);

            var loanSuccess = _libraryRepository.LoanBook(bookId, memberId);
            if (loanSuccess)
            {
                MessageBox.Show("Book loaned successfully.");
            }
            else
            {
                MessageBox.Show("Book loaning failed. Please check if the book is available or if the member exists.");
            }
            this.Close();
        }
    }
}

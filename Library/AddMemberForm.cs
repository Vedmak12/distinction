using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddMemberForm : Form
    {
        private LibraryRepository _libraryRepository;

        public AddMemberForm(LibraryRepository libraryRepository)
        {
            InitializeComponent();
            _libraryRepository = libraryRepository;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var member = new Member
            {
                Id = int.Parse(textBoxMemberId.Text),
                Name = textBoxMemberName.Text
            };

            _libraryRepository.AddMember(member);
            MessageBox.Show("Member added successfully.");
            this.Close();
        }
    }
}

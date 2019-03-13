using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library.Classes;

namespace Library.Forms
{
    public partial class Return : Form
    {
        public static List<string> userBorrowed;

        public static Lib userLibrary;

        public Return()
        {
            InitializeComponent();
        }

        private void UpdateLibrary()
        {
            userBorrowed = Interface.borrowers.Borrowers
                .Where(borrower => borrower.Name == Login.userName).Select(borrower => borrower.Book).ToList();
            userLibrary = new Lib(Interface.library.Books.Where(book => userBorrowed.Contains(book.Name)).ToList());

            BookList.Items.Clear();
            var result = userLibrary.Books;
            if (NameCheck.Checked)
                result = result.FindAll(b => b.Name.CaseInsensitiveContains(BookName.Text));
            if (AuthorCheck.Checked)
                result = result.FindAll(b => b.Author.CaseInsensitiveContains(AuthorName.Text));
            if (GenreCheck.Checked)
                result = result.FindAll(g => g.Genre.Contains(GenreName.SelectedItem.ToString()));
            if (TypeCheck.Checked)
                result = result.FindAll(b => b.Genre.Contains(TypeName.SelectedItem.ToString()));
            BookList.Items.AddRange(result.Select(b => b.Name).ToArray());
        }

        private void Return_Load(object sender, EventArgs e)
        {
            UpdateLibrary();
            var genres = new HashSet<string>();
            foreach (var item in userLibrary.Books.SelectMany(b => b.Genre))
                genres.Add(item);
            GenreName.Items.AddRange(genres.ToArray());
        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            var selectedBook = userLibrary.Books.FirstOrDefault(b => b.Name == BookList.SelectedItem.ToString());
            Interface.borrowers.Borrowers.Remove(
                Interface.borrowers.Borrowers.SingleOrDefault(b => b.Book == selectedBook.Name));
            Manager.JsonUpdate(@"./Data/history.json", Interface.borrowers);
            UpdateLibrary();
            MessageBox.Show("Book was returned.", "Book return", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Interface.UpdateLibrary(Login.newForm);
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReturnBook.Enabled = true;
        }
    }
}
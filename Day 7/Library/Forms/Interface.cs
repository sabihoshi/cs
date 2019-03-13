using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library.Classes;
using Newtonsoft.Json;

namespace Library.Forms
{
    public partial class Interface : Form
    {
        public static Lib library = JsonConvert.DeserializeObject<Lib>(Manager.ReadFile(@"./Data/books.json"));
        public static Bor borrowers = JsonConvert.DeserializeObject<Bor>(Manager.ReadFile(@"./Data/history.json"));

        public static Book selectedBook;

        public Interface()
        {
            InitializeComponent();
        }

        public static void UpdateLibrary(Interface @interface)
        {
            @interface.BookList.Items.Clear();
            var result = library.Books;
            if (@interface.NameCheck.Checked)
                result = result.FindAll(b => b.Name.CaseInsensitiveContains(@interface.BookName.Text));
            if (@interface.AuthorCheck.Checked)
                result = result.FindAll(b => b.Author.CaseInsensitiveContains(@interface.AuthorName.Text));
            if (@interface.GenreCheck.Checked)
                result = result.FindAll(g => g.Genre.Contains(@interface.GenreName.SelectedItem.ToString()));
            if (@interface.TypeCheck.Checked)
                result = result.FindAll(b => b.Genre.Contains(@interface.TypeName.SelectedItem.ToString()));

            var userBorrowed = borrowers.Borrowers
                .Where(borrower => borrower.Name == Login.userName).Select(borrower => borrower.Book).ToList();

            @interface.BookList.Items.AddRange(
                result
                    .Where(b => !userBorrowed.Contains(b.Name))
                    .Select(b => b.Name).ToArray());
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            var control = sender as Control;
            switch (control.Name)
            {
                case "BookName":
                    NameCheck.Checked = true;
                    break;

                case "AuthorName":
                    AuthorCheck.Checked = true;
                    break;

                case "GenreName":
                    GenreCheck.Checked = true;
                    break;

                case "TypeName":
                    TypeCheck.Checked = true;
                    break;
            }

            UpdateLibrary(this);
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            var genres = new HashSet<string>();
            foreach (var item in library.Books.SelectMany(b => b.Genre))
                genres.Add(item);
            GenreName.Items.AddRange(genres.ToArray());
            UpdateLibrary(this);
        }

        private void ReadBook_Click(object sender, EventArgs e)
        {
            selectedBook = library.Books.FirstOrDefault(b => b.Name == BookList.SelectedItem.ToString());
            var newForm = new Borrow();
            newForm.Show();
            UpdateLibrary(this);
        }

        private void returnABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newForm = new Return();
            newForm.Show();
        }

        private void BookList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadBook.Enabled = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Program.newForm.Show();
        }
    }
}
using Library.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        public Books books = JsonConvert.DeserializeObject<Books>(Manager.ReadFile(@"../../Data/books.json"));

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

                case "IdInt":
                    IsbnCheck.Checked = true;
                    break;

                default:
                    break;
            }

            void UpdateBooks(List<Book> genre)
            {
                var result = genre;
                if (NameCheck.Checked)
                    result = genre.FindAll(b => b.Name.CaseInsensitiveContains(BookName.Text));
                if (AuthorCheck.Checked)
                    result = genre.FindAll(b => b.Author.CaseInsensitiveContains(AuthorName.Text));
                if (TypeCheck.Checked)
                    result = genre.FindAll(b => b.Type.CaseInsensitiveContains(TypeName.SelectedItem.ToString()));
                if (IsbnCheck.Checked)
                    result = genre.FindAll(b => b.ISBN == IdInt.Value);
                BookList.Items.AddRange(result.Select(b => b.Name).ToArray());
            }

            BookList.Items.Clear();
            string name = GenreName.Text;
            if (name == "Romance" || name == "")
                UpdateBooks(books.Romance);
            if (name == "Horror" || name == "")
                UpdateBooks(books.Horror);
        }
    }
}
using System;
using System.Windows.Forms;
using Library.Classes;

namespace Library.Forms
{
	public partial class Borrow : Form
	{
		public Book book = Interface.selectedBook;

		public Borrow()
		{
			InitializeComponent();
		}

		private void Borrow_Load(object sender, EventArgs e)
		{
			BookName.Text = book.Name;
			BookAuthor.Text = book.Author;
			BookGenre.Text = string.Join(", ", book.Genre);
			BookType.Text = book.Type;
		}

		private void BorrowBook_Click(object sender, EventArgs e)
		{
			DateTime expiry = DateTime.Parse(DateTimePicker.Value.ToString());
			Interface.borrowers.Borrowers.Add(new Borrower(book.Name, Login.userName,
				DateTime.Now.ToString(), expiry.ToString()));
			MessageBox.Show(@"Succesfully borrowed item", @"Borrow item", MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			Manager.JsonUpdate(@"./Data/history.json", Interface.borrowers);
			Interface.UpdateLibrary(Login.newForm);
			Hide();
		}
	}
}
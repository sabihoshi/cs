using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Shapes;
using System.IO;
using Path = System.IO.Path;

namespace DatabaseProject
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly SqlConnection connection =
            new SqlConnection(
                $@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ciit\Source\Repos\loliprotector\cs\DatabaseProject\Employees.mdf;Integrated Security=True;Connect Timeout=30");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InsertData(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText =
                    $"INSERT INTO [Users] (FirstName,LastName,UserName,PassWord) VALUES('{UserName.Text}','{LastName.Text}','{UserName.Text}','{PassWord.Text}')";
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Added");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void UpdateDatabase(object sender, RoutedEventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM [Users]";
                command.ExecuteNonQuery();
                DataTable dtbl = new DataTable();
                SqlDataAdapter dtadpt = new SqlDataAdapter(command);
                dtadpt.Fill(dtbl);
                DataGrid.DataContext = dtbl.DefaultView;
                connection.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
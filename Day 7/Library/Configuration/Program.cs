using System;
using System.Windows.Forms;
using Library.Forms;

namespace Library
{
	public static class Program
	{
		public static Login newForm;

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			newForm = new Login();
			Application.Run(newForm);
		}
	}
}
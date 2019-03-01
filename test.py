public partial class Form1 : Form
{
	BackgroundWorker worker = new BackgroundWorker();
	public Form1()
	{
		InitializeComponent();
		worker.DoWork += new DoWorkEventHandler(worker_DoWork);
	}
	private void worker_DoWork(object sender, DoWorkEventArgs e)
	{
		BackgroundWorker bkgWorker = (BackgroundWorker)sender;
		for (int i = 0; i < 1000000; i++)
		{
			output.Text += q;
		}
	}
	private void Form1_Load(object sender, EventArgs e)
	{
		this.worker.RunWorkerAsync();
	}
}
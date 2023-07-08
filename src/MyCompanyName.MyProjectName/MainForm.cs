namespace MyCompanyName.MyProjectName
{
    public partial class MainForm : Form
    {
        private readonly HelloWorldService _helloWorldService;
        public MainForm()
        {
            InitializeComponent();
            _helloWorldService = MyProjectApp.GetService<HelloWorldService>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(_helloWorldService.SayHello());
        }
    }
}
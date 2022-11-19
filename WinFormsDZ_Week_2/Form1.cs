namespace WinFormsDZ_Week_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dialog = new FolderBrowserDialog() { Description="Выберите путь." })
            {
                if(dialog.ShowDialog()==DialogResult.OK)
                {
                    
                }
            }
        }
    }
}
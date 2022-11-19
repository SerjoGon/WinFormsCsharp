using System.Net;

namespace FileExplorerWF
{
    public partial class FormFileExplorer : Form
    {
        readonly string filepath = "F:";
        public FormFileExplorer()
        {
            InitializeComponent();
        }
        private void FormFileExplorer_Load(object sender,EventArgs e)
        {
            textboxfilePath.Text = filepath;
            
        }
    }
}
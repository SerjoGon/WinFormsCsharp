using System.Runtime.InteropServices;
using System.Text;

namespace Class19_10_22_WinFormsStart
{
    public partial class Form1 : Form
    {
        Mp3Player _mp3Player;
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_Open_Click(object sender, EventArgs e)
        {
            OFD.Filter = "mp3file|*.mp3";
            if(OFD.ShowDialog() == DialogResult.OK)
            {
                string path = OFD.FileName;
            }
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            _mp3Player.Play();
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            _mp3Player.Stop();
        }
    }
    class Mp3Player
    {
        public bool Repeat { get; set; }
        [DllImport("winmm.dll")]
       private static extern long mciSendString(
           string lpstrCommand,
           StringBuilder lpstrReturnString,
           int uReturnLength,
           IntPtr hwndCallback);
        public Mp3Player(string path)
        {
            const string FORMAT = @"open ""{0}"" type mpegvideo alias MediaFile ";
            string command = String.Format(FORMAT, path);
            mciSendString(command, new StringBuilder(), 0, IntPtr.Zero);
        }
        public void Play()
        {
            string command = "play MediaFile";
            mciSendString(command, new StringBuilder(), 0, IntPtr.Zero);
        }
        public void Stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, new StringBuilder(), 0, IntPtr.Zero);
        }
    }
}
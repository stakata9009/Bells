using WMPLib;

namespace Bells
{
    public partial class Form1 : Form
    {
        //We declare the player and selectedFile here so that we may have access to them from everywhere else in the program
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string selectedFile;
        int selectedHour;
        int selectedMinute;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.ShowDialog();
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create create = new Create();
            create.ShowDialog();
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.ShowDialog();
            this.Close();
        }
    }
}
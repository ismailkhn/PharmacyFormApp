namespace Pharmacyyyyyyyy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void eyePassBttn_Click(object sender, EventArgs e)
        {
            if (passBox.PasswordChar == '*')
            {
                hidePassBttn.BringToFront();
                passBox.PasswordChar = '\0';
            }
        }

        private void hidePassBttn_Click(object sender, EventArgs e)
        {
            if (passBox.PasswordChar == '\0')
            {
                eyePassBttn.BringToFront();
                passBox.PasswordChar = '*';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usname = usnameBox.Text;
            string pass = passBox.Text;

            if (!string.IsNullOrWhiteSpace(usname) && !string.IsNullOrWhiteSpace(pass))
            {

                WorkerPanell wp = new WorkerPanell();
                wp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and password cannot be empty!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
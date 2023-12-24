namespace myContact
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userTb.Text == "admin" && passwordTb.Text == "admin")
            {
   
                Contacts contactForm = new Contacts();

  
                contactForm.Show();

     
                this.Hide();
            }
            else
            {
               
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
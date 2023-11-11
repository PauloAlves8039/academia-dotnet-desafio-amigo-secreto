namespace Academia.DotNet.AmigoSecreto.App
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void Form_AmigoSecreto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Sobre formSobre = new Form_Sobre();
            formSobre.Show();
        }

        private void Timer_Menu_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Data.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel_Hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}

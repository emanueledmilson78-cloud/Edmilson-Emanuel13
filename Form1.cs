namespace exe1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {

                e.SuppressKeyPress = true;

                int hora = DateTime.Now.Hour;
                string nome = txtNome.Text.Trim();

                if (string.IsNullOrWhiteSpace(nome))
                {
                    MessageBox.Show("Digite o seu nome!!!");
                    return;
                }

                if (hora >= 6 && hora < 12)
                {
                    MessageBox.Show("Bom dia, " + nome);
                }else if (hora >= 12 && hora < 18)
                {
                    MessageBox.Show("Boa tarde, " + nome);
                }
                else
                {
                    MessageBox.Show("Boa noite, " + nome);
                }

            }
        }
    }
}

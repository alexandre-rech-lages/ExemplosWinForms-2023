namespace Exemplos.WinApp
{
    public partial class FormExemplo : Form
    {
        public FormExemplo()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string descricaoAtividade = txtNome.Text;

            Atividade atividade = new Atividade(descricaoAtividade);

            listAtividades.Items.Add(atividade);

            txtNome.Text = "";
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Atividade atividade = (Atividade)listAtividades.SelectedItem;

            listAtividades.Items.Remove(atividade);
        }
    }
}
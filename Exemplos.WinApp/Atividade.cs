namespace Exemplos.WinApp
{
    public class Atividade
    {
        public static int contador;
        public int id;
        public string descricao;

        public Atividade(string descricao)
        {
            contador++;

            id = contador;
            this.descricao = descricao;
        }

        public override string ToString()
        {
            return "Id: " + id + " - Descrição: " + descricao;
        }
    }
}

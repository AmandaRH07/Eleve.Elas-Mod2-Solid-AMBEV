namespace Solid
{
    public class Biblioteca
    {
        private List<Livro> livros;
      
        private Dictionary<string, RegistroEmprestimo> registrosEmprestimo;

        public Biblioteca()
        {
            this.livros = new List<Livro>();
            this.registrosEmprestimo = new Dictionary<string, RegistroEmprestimo>();
        }

        // Métodos relacionados ao armazenamento em banco de dados
        public void SalvarDadosBiblioteca()
        {
            // Código para salvar dados da biblioteca no banco de dados
        }

        public void CarregarDadosBiblioteca()
        {
            // Código para carregar dados da biblioteca do banco de dados
        }
    }
}

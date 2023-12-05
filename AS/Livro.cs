public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }

    // Construtor que recebe id, título e autor, e inicializa a DescricaoInterna
    public Livro(int id, string titulo, string autor, string descricao) : base(id, titulo) // Chama o construtor da classe base e passa os parâmetros id e titulo
    {
        this.Autor = autor; //Referencia este autor e atribue o valor recebido pelo parâmetro autor

        this.DescricaoInterna = descricao; //Referencia a descrição interna e atribue o valor recebido pelo parâmetro descricao
    }

    public void ExibirDescricaoInterna() // Método que exibe a descrição interna do livro, pode ser usado na descrição individual de cada livro.
    {
        Console.WriteLine(DescricaoInterna);
    }

}

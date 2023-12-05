public abstract class ItemBiblioteca // Classe abstrata que não pode ser instanciada, mas pode ser herdada
{
    public int Id { get; set; } // Propriedade Id
    public string Titulo { get; set; } // Propriedade Titulo
    protected string DescricaoInterna = "A leitura é um hábito que deve ser cultivado por todos."; // Propriedade DescricaoInterna, que é uma propriedade protegida, ou seja, só pode ser acessada por classes que herdam desta classe.
    
    public ItemBiblioteca (int id, string titulo) // Construtor que recebe id e título
    {
        Id = id;
        Titulo = titulo;
    }
    
}
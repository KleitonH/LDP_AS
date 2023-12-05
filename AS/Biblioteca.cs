public class Biblioteca
{
    private List<ItemBiblioteca> colecao; //Cria uma lista protegida de bliblioteca para criação da coleção.

    public Biblioteca() //Cria um construtor para a classe Biblioteca.
    {
        colecao = new List<ItemBiblioteca>();
    }

    public void AdicionarItem(ItemBiblioteca item) //Cria um método para adicionar itens na coleção.
    {
        colecao.Add(item); //Adiciona o item na coleção.
    }
    public void RemoverItem(int id) //Cria um método para remover itens da coleção.
    {
        ItemBiblioteca item = BuscarItemPorId(id);
        if (item != null)
        {
            colecao.Remove(item);
        }
    }

    // Busca um item na coleção com base no título
    public ItemBiblioteca BuscarItemPorTitulo(string titulo)
    
    {
        return colecao.Find(item => item.Titulo == titulo);
    }

    public ItemBiblioteca BuscarItemPorTitulo(string titulo, string autor)
    
    {
        return colecao.Find(item => item.Titulo == titulo && (item is Livro livro && livro.Autor == autor));
    }


    // Busca um item na coleção com base no ID
    public ItemBiblioteca BuscarItemPorId(int id)
    {
        return colecao.Find(item => item.Id == id);
    }

    public ItemBiblioteca BuscarItemPorId(int id, string autor)
    {
        return colecao.Find(item => item.Id == id && (item is Livro livro && livro.Autor == autor));
    }

    
}
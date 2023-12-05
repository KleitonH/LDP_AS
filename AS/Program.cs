using System;

class Program
{
    static void Main()
    {
        // Criando instâncias
        Biblioteca biblioteca = new Biblioteca();
        Livro livro1 = new Livro (1, "Aventuras de Sherlock Holmes", "Arthur Conan Doyle", "Livro de suspense policial");
        Livro livro2 = new Livro (2, "Caninos Brancos", "Jack London", "Livro de romance e ficção-aventura");
        Livro livro3 = new Livro (3, "Soldier: Leal até o fim", "Sam Angus", "Livro de ficção histórica e novela de guerra");
        // Adicionando livros à biblioteca
        biblioteca.AdicionarItem(livro1);
        biblioteca.AdicionarItem(livro2);
        biblioteca.AdicionarItem(livro3);
        // ...

        // Buscando e um livro da biblioteca
        Livro livroEncontrado = biblioteca.BuscarItemPorTitulo("Aventuras de Sherlock Holmes") as Livro; // Teste 1 de busca do primeiro livro da biblioteca
        if (livroEncontrado != null) // Verifica se o retorno da busca é nulo, caso seja, o livro não foi encontrado, caso seja diferente de nulo, o livro foi encontrado.
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado.Titulo}, este livro foi escrito por {livroEncontrado.Autor}."); //Utiliza interpolacao de strings para exibir o titulo e o autor do livro encontrado
            livroEncontrado.ExibirDescricaoInterna();
        }
        else
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }

        Livro livroEncontrado2 = biblioteca.BuscarItemPorId(2) as Livro; //Teste 2 de busca do segundo livro da biblioteca
        if (livroEncontrado2 != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado2.Titulo}, este livro foi escrito por {livroEncontrado2.Autor}.");
            livroEncontrado2.ExibirDescricaoInterna();
        }
        else
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }

        Livro livroEncontrado3 = biblioteca.BuscarItemPorTitulo("Soldier: Leal até o fim", "Sam Angus") as Livro; //Teste 3 de busca do terceiro livro da biblioteca
        if (livroEncontrado3 != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado3.Titulo}, este livro foi escrito por {livroEncontrado3.Autor}.");
            livroEncontrado3.ExibirDescricaoInterna();
        }
        else
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }

        biblioteca.RemoverItem(2); //Remove o segundo livro da biblioteca
         Livro livroEncontrado4 = biblioteca.BuscarItemPorTitulo("Caninos Brancos") as Livro; //Teste 4 de busca do segundo livro da biblioteca
        if (livroEncontrado4 != null)
        {
            Console.WriteLine($"Livro encontrado: {livroEncontrado4.Titulo}, este livro foi escrito por {livroEncontrado4.Autor}.");
            livroEncontrado4.ExibirDescricaoInterna();
        }
        else
        {
            Console.WriteLine("Livro não encontrado na biblioteca.");
        }

    }
}

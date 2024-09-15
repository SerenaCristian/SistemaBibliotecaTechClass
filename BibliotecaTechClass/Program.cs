using BibliotecaTechClass.SistemaBiblioteca;
using BibliotecaTechClass;

class Program
{
    static void Main(string[] args)
    {
        Biblioteca biblioteca = new Biblioteca();

        Livro livro = new Livro("O Senhor dos Anéis", 1954);
        Revista revista = new Revista("National Geographic", 2020);
        DVD dvd = new DVD("Inception", 2010);

        biblioteca.EmprestarItem(livro);
        biblioteca.EmprestarItem(revista);
        biblioteca.EmprestarItem(dvd);

        Console.WriteLine();

        biblioteca.ListarItensEmprestados();
        
        Console.WriteLine("\nDevolvendo itens:");
        biblioteca.DevolverItem(livro, 3);  
        biblioteca.DevolverItem(revista, 0); 
        biblioteca.DevolverItem(dvd, 5);  
    }
}


using System;

namespace SistemaBiblioteca
{
    public abstract class ItemBiblioteca
    {
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public bool Emprestado { get; private set; }

        public ItemBiblioteca(string titulo, int ano)
        {
            Titulo = titulo;
            Ano = ano;
            Emprestado = false;
        }

        public virtual void Emprestar()
        {
            if (!Emprestado)
            {
                Emprestado = true;
                Console.WriteLine($"{Titulo} foi emprestado.");
            }
            else
            {
                Console.WriteLine($"{Titulo} já está emprestado.");
            }
        }

        public virtual void Devolver()
        {
            if (Emprestado)
            {
                Emprestado = false;
                Console.WriteLine($"{Titulo} foi devolvido.");
            }
            else
            {
                Console.WriteLine($"{Titulo} não está emprestado.");
            }
        }

        public abstract double CalcularMulta(int diasAtraso);
    }
}

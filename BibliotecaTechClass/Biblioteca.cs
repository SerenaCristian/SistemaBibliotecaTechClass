using SistemaBiblioteca;
using System;


namespace BibliotecaTechClass
{
    public class Biblioteca
    {
        private List<ItemBiblioteca> itensEmprestados = new List<ItemBiblioteca>();

        public void EmprestarItem(ItemBiblioteca item)
        {
            item.Emprestar();
            itensEmprestados.Add(item);
        }

        public void DevolverItem(ItemBiblioteca item, int diasAtraso)
        {
            item.Devolver();
            double multa = item.CalcularMulta(diasAtraso);

            if (diasAtraso > 0)
            {
                Console.WriteLine($"Multa de R${multa:0.00} por {diasAtraso} dias de atraso.");
            }
            else
            {
                Console.WriteLine("Devolvido dentro do prazo.");
            }

            itensEmprestados.Remove(item);
        }

        public void ListarItensEmprestados()
        {
            Console.WriteLine("Itens emprestados:");
            foreach (var item in itensEmprestados)
            {
                Console.WriteLine($"{item.Titulo} ({item.Ano})");
            }
        }
    }
}


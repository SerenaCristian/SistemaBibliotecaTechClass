using SistemaBiblioteca;
using System;


namespace BibliotecaTechClass
{
    namespace SistemaBiblioteca
    {
        public class Livro : ItemBiblioteca
        {
            private const double TaxaMulta = 2.0; 

            public Livro(string titulo, int ano) : base(titulo, ano) { }

            public override double CalcularMulta(int diasAtraso)
            {
                return diasAtraso * TaxaMulta;
            }
        }



    }

}

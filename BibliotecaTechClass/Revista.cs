using SistemaBiblioteca;
using System;


namespace BibliotecaTechClass
{
    public class Revista : ItemBiblioteca
    {
        private const double TaxaMulta = 1.0; 

        public Revista(string titulo, int ano) : base(titulo, ano) { }

        public override double CalcularMulta(int diasAtraso)
        {
            return diasAtraso * TaxaMulta;
        }
    }

}

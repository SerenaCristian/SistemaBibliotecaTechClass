using SistemaBiblioteca;
using System;


namespace BibliotecaTechClass
{
    public class DVD : ItemBiblioteca
    {
        private const double TaxaMulta = 5.0;

        public DVD(string titulo, int ano) : base(titulo, ano) { }

        public override double CalcularMulta(int diasAtraso)
        {
            return diasAtraso * TaxaMulta;
        }
    }
}

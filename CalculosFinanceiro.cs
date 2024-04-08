using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFinanceira
{
    public static class CalculosFinanceiro
    {


        public static double CalcularMontante(double taxa, double capital, double tempo)
        {
            taxa = taxa / 100;
            return capital * (1 + taxa * tempo);
        }
        public static double CalcularCapital(double taxa, double montante, double tempo)
        {
            taxa = taxa / 100;
            return montante / (1 + taxa * tempo);
        }
        public static double CalcularTaxa(double capital, double montante, double tempo)
        {
            return (montante - capital) / (capital * tempo);
        }
        public static double CalcularTempo(double montante, double capital, double taxa)
        {
            taxa = taxa / 100;
            return (montante - capital) / (capital * taxa);
        }
        public static double CalcularJuros(double capital, double montante)
        {
            return montante - capital;
        }         
    }
}


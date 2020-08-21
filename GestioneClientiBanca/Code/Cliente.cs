using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneClientiBanca.Code
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public int NumeroConto { get; set; }
        public string Valuta { get; set; }

        public string GetCSVFormat()
        {
            return $"{Nome},{Cognome}," +
                   $"{DataNascita.ToShortDateString()}," +
                   $"{NumeroConto.ToString()}," +
                   $"{Valuta}";
        }

    }
}

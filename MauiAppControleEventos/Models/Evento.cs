using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppControleEventos.Models
{
    internal class Evento
    {
        public string Nome { get; set; }
        public string LocalEvento { get; set; }
        public DateTimeOffset DataCheckIn { get; set; }
        public DateTimeOffset DataCheckOut { get; set; }
        public int QntParticipantes { get; set; }
        public  double  ValorParticipante { get; set; }

        public int Estadia
        {
            get => DataCheckOut.Subtract(DataCheckIn).Days;
        }

        public double ValorTotal
        {
            get
            {
                
                double valor_inteira = QntParticipantes * ValorParticipante;
                double valor_meia = (ValorParticipante / 2) * QntParticipantes;
                double total = valor_inteira;
                return total;
            }
        }
    }
    
}

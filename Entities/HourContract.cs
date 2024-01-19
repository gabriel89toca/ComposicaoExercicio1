using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoExercicio1.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public Double  ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() { }
        public HourContract(DateTime date, Double valuePerHour, int hour) { 
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hour;
        }

        public Double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}

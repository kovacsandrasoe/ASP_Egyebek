using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Egyebek.Models
{
    public class TodoDay
    {
        [Key]
        public int TodoDayId { get; set; }

        public DateTime Date { get; set;}

        [NotMapped]
        public double AllHours { get; set; }

        public virtual List<Todo> Todos { get; set; }

        public TodoDay()
        {
            Todos = new List<Todo>();
        }
    }
}

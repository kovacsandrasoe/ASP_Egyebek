using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Egyebek.Models
{
    public class Todo
    {
        [Key]
        public int TodoID { get; set; }

        public string Name { get; set; }

        public double Hours { get; set; }

    }
}

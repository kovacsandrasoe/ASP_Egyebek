using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Egyebek.Models
{
    public class TodoPersonConnector
    {
        [Key]
        public int ConnId { get; set; }

        public int TodoId { get; set; }

        public int PersonId { get; set; }
    }
}

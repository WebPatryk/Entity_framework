using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Entity_framework.Models
{
    public class Games
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Date)] //we need Date only
        public DateTime ReleaseDate { get; set; }
        public int Rate { get; set; }
        public decimal Price { get; set; }
    }
}



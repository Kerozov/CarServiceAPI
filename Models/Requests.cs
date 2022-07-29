using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarService.Models
{
    public class Requests
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public DateTime Date { get; set; } = DateTime.Now;

        public List<Cars> Cars { get;set; }

        [StringLength(300, MinimumLength = 5)]
        public string Description { get; set; }
    }
}

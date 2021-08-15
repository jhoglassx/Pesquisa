using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.Models
{
    [Table("ConvenioList")]
    public class ConvenioList
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("ConvenioNome")]
        [Display(Name = "Convenio", Description = "")]
        public string ConvenioNome { get; set; }
    }
}

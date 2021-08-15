using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.Models
{
    [Table("FaixaSalario")]
    public class FaixaSalario
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("FaixaSalarial")]
        [Display(Name = "Faixas de Salario", Description = "")]
        public string FaixaSalarial { get; set; }
    }
}

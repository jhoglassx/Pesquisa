using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.Models
{
    [Table("FaixaIdade")]
    public class FaixaIdade
    {

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("FaixaIdade")]
        [Display(Name = "Faixas de Idade", Description = "")]
        public string FaixadeIdade { get; set; }

    }
}

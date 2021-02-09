using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name ="Descricao")]

        public string Descricao { get; set; }
        [Range(1, 10, ErrorMessage ="Valor fora da faixa")]

        public int Quantidade { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}

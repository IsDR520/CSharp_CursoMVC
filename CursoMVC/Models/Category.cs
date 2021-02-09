using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Descricao")]
        [Required(ErrorMessage ="O campo descricao é obrigatorio")]

        public string Descricao { get; set; }

        public List<Product> Products { get; set; }
    }
}

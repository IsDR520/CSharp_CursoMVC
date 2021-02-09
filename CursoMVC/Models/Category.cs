﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public List<Product> Products { get; set; }
    }
}

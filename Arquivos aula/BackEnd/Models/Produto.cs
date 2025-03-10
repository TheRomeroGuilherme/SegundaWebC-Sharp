using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Models
{
    public class Produto
    {
       public int Id_produto { get; set; } 
       public String? Name { get; set; }
       public int Quantidade { get; set; }
       public DateTime Criado_Em_ { get; set; } = DateTime.Now;

    }
}
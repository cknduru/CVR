using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CVR.Models
{
    public class ModelBase
    {
        [Key]
        public int ID { get; set; }
    }
}

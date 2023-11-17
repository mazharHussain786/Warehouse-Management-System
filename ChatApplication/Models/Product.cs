using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Models
{
    public class Product
    {

        [Key]
        [Column("PId")]
        public int PId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public int  price { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Invesco.Entities
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Descrption { get; set; }

        public string Price { get; set; }

        public List<OrderModel> Orders { get; set; }
    }
}

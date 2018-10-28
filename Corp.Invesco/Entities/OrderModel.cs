using Corp.Invesco.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Invesco.Entities
{
    public class OrderModel
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public Enums.OrderStatus Status { get; set; }

        public List<ProductModel> Products { get; set; }
    }
}

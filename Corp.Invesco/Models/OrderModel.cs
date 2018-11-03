using Corp.Invesco.Helpers;
using System;
using System.Collections.Generic;

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


// R language code
//> s<- list(Id = 0, OrderDate = "2018/10/29", Status = 0)
//> class(s) <- "OrderModel"

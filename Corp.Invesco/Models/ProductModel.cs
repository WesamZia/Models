using System.Collections.Generic;

namespace Corp.Invesco.Entities
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Code { get; set; }

        public string Descrption { get; set; }

        public decimal Price { get; set; }

        public List<OrderModel> Orders { get; set; }
    }
}


// R language code
//> s<- list(Id = 0, Code = "code", Descrption = "ProductDescrption", Price = "100.0000")
//> class(s) <- "ProductModel"

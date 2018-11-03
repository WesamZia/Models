using System.Collections.Generic;

namespace Corp.Invesco.Entities
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public List<AddressModel> Addresses { get; set; }

        public List<OrderModel> Orders { get; set; }

    }
}


// R language code
//> s<- list(Id = 0, FullName = "FullName", FirstName = "FirstName")
//> class(s) <- "CustomerModel"
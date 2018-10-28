namespace Corp.Invesco.Entities
{
    public class AddressModel
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string PostalCode { get; set; }

        public string City { get; set; }

        public string PhoneNumber { get; set; }

        public CustomerModel Customer {get; set;}
    }
}
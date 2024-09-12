namespace UserManagement.Domain.Models
{
    public class Address
    {
        public int Id { get; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public int UserId { get; set; }
    }
}

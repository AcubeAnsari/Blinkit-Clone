using System.ComponentModel.DataAnnotations;

namespace Temp.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string StoreName { get; set; }

        public string StoreAddress { get; set; }

        [MaxLength(100)]
        public string StoreCity { get; set; }

        [MaxLength(100)]
        public string StoreState { get; set; }

        [MaxLength(100)]
        public string StoreCountry { get; set; }

        [MaxLength(10)]
        public string StorePincode { get; set; }

        [Phone]
        public string StorePhoneNumber { get; set; }

        [Phone]
        public string StoreWhatsAppNumber { get; set; }

        [MaxLength(100)]
        public string StoreLocation { get; set; }

        [Url]
        public string StoreGoogleMapsLink { get; set; }
    }
}

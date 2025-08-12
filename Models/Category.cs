using System.Runtime.InteropServices.Marshalling;

namespace Temp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int ShortOrder { get; set; }


        public virtual ICollection<Product>Products { get; set; }
    }
}

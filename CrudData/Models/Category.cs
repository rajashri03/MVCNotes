using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudData.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}

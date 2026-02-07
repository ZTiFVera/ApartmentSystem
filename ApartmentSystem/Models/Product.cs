using System.ComponentModel.DataAnnotations;

namespace ApartmentSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage= "Product name is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Product name must be between 2 and 100 characters")]
        [Display(Name = "Product Name")]
        public    string ProductName { get; set; }= string.Empty;    

        [Required(ErrorMessage = "Product type is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Product type must be between 2 and 50 characters")]
        [Display(Name = "Product Type")]
        
        public string ProductType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 500 characters")]
        [Display(Name = "Description")]

        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        [Display(Name = "Quantity")]
        public     int Quantity { get; set; }

        [Required(ErrorMessage = "Size is required")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Size must be between 1 and 20 characters")]
        [Display(Name = "Size")]
        public string Size { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Price must be a non-negative value")]
        [Display(Name = "Price")]
        public    int price { get; set; } 
     
        
        


    }
}

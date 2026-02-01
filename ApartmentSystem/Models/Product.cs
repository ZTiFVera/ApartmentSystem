namespace ApartmentSystem.Models
{
    public class Product
    {

        public int ProductId { get; set; } 
        public    string ProductName { get; set; }= string.Empty;    

        public string ProductType { get; set; } = string.Empty;
        public     int Quantity { get; set; }
        public string Size { get; set; } = string.Empty;
        public    int price { get; set; } 
     
        
        


    }
}

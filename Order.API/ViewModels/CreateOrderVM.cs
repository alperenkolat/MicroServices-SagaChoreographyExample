namespace Order.API.ViewModels;

public class CreateOrderVM
{
    public string ProductId { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }

}
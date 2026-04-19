using System.ComponentModel.DataAnnotations;

public class Stock
{
    public int Id { get; set; }
    public string Item { get; set; }
    public int Quantity { get; set; }
    public double AverageRating { get; set; }
    public int Served { get; set; }
    public DateTime Date { get; set; }
    public int Rating { get; set;}
}
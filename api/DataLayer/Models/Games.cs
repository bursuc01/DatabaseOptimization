using System.ComponentModel.DataAnnotations;

public class Games
{
    [Key]
    public int AppId { get; set; }
    public string? Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public bool Win { get; set; }
    public bool Mac { get; set; }
    public bool Linux { get; set; }
    public string? Rating { get; set; }
    public int PositiveRatio { get; set; }
    public int UserReviews { get; set; }
    public decimal PriceFinal { get; set; }
    public decimal PriceOriginal { get; set; }
    public int Discount { get; set; }
    public bool SteamDeck { get; set; }

}
namespace NilesBakery.Models
{
  public class Bread
  {
    public int BreadAmount { get; set; }

    public Bread(int amount)
    {
      BreadAmount = amount;
    }
  }
}
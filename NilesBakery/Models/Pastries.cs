namespace NilesBakery.Models
{
  public class Pastries
  {
    public int PastryAmount {get; set; }
    public Pastries (int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }

    public int Price()
    {
      int price = 0;
      int pastryAmount = PastryAmount;

      if (pastryAmount >= 3)
      {
        int pastryThrees = pastryAmount / 3;
        price += 5 * pastryThrees;
        pastryAmount -= (pastryThrees * 3);
      }

      price += (2 * pastryAmount);

      return price;
    }
  }
}
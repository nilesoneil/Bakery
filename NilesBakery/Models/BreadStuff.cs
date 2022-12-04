namespace NilesBakery.Models
{
  public class Bread
  {
    public int BreadAmount { get; set; }

    public Bread(int amount)
    {
      BreadAmount = amount;
    }

    public int Price()
    {
      int price = 0;
      int loaves = BreadAmount;

      if (loaves >= 3)
      {
        int loafAmount = loaves / 3;
        price += 10 * loafAmount;
        loaves -= (loafAmount * 3);
      }

      price += (5 * loaves);

      return price;
    }
  }
}
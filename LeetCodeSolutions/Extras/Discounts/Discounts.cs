namespace Extras.Test_2
{
    public class Discounts
    {
        public static int findLowestPrice(List<List<string>> products, List<List<string>> discounts)
        {
            int total = 0;

            Dictionary<string, List<List<string>>> discountLookup = discounts
                .GroupBy(d => d[0])
                .ToDictionary(g => g.Key, g => g.ToList());

            foreach (List<string> product in products)
            {
                int originalPrice = int.Parse(product[0]);
                int minDiscountedPrice = originalPrice;

                for (int i = 1; i < product.Count; i++)
                {
                    if (product[i] != null && discountLookup.TryGetValue(product[i], out List<List<string>> possiblediscounts))
                    {
                        foreach (List<string> discount in possiblediscounts)
                        {
                            int currentDiscountedPrice = originalPrice;

                            switch (discount[1])
                            {
                                case "0":
                                    currentDiscountedPrice = int.Parse(discount[2]);
                                    break;
                                case "1":
                                    currentDiscountedPrice = Convert.ToInt32(Math.Floor(originalPrice - originalPrice * decimal.Parse(discount[2]) / 100));
                                    break;
                                case "2":
                                    currentDiscountedPrice = Convert.ToInt32(originalPrice - decimal.Parse(discount[2]));
                                    break;
                            }

                            minDiscountedPrice = Math.Min(minDiscountedPrice, currentDiscountedPrice);
                        }
                    }
                }

                total += minDiscountedPrice;
            }

            return total;


        }
        public static int findLowestPriceOrg(List<List<string>> products, List<List<string>> discounts)
        {
            int total = 0;

            foreach (List<string> product in products)
            {
                int originalPrice = int.Parse(product[0]);

                int minDiscountedPrice = originalPrice;

                for (int i = 1; i < product.Count; i++)
                {
                    List<List<string>>? possiblediscounts = discounts.Where(d => d[0] == product[i]).ToList();
                    foreach (List<string> discount in possiblediscounts)
                    {
                        int currentDiscountedPrice = originalPrice;
                        if (discount != null)
                        {
                            switch (discount[1])
                            {
                                case "0":
                                    currentDiscountedPrice = Convert.ToInt32(discount[2]);
                                    break;
                                case "1":
                                    currentDiscountedPrice = Convert.ToInt32(Math.Floor(originalPrice - originalPrice * decimal.Parse(discount[2]) / 100));
                                    break;
                                case "2":
                                    currentDiscountedPrice = Convert.ToInt32(originalPrice - decimal.Parse(discount[2]));
                                    break;
                                default:
                                    break;
                            }
                        }

                        minDiscountedPrice = Math.Min(minDiscountedPrice, currentDiscountedPrice);
                    }
                }

                total += minDiscountedPrice;
            }

            return total;
        }
    }
}

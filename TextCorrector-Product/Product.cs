namespace TextCorrector_Product
{
    internal class Product
    {
        public string BrandName;
        public string Model;
        public int Price;
        public int Cost;
        public int Count;
        public string Id;
        public int Income;
        public Product(string brandName, string model, int price, int cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;
            if (Count < 0)
            {
                Count = 0;
            }
            Id = BrandName.Substring(0, 2) + Model.Substring(0, 2);
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name of the brand: {BrandName},Model: {Model},Price: {Price}, Cost: {Cost}, Count: {Count}, Id: {Id}");
        }
        public void Sale()
        {
            if (Count > 0)
            {
                Count--;
                Income = Income + Price - Cost;
                Console.WriteLine($"Item is sold, total income is: {Income} and items left: {Count}");
            }
            else
            {
                Console.WriteLine("Sorry! This product already sold");
            }
        }
    }
}

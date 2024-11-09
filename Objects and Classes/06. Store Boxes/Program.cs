using System.Globalization;

namespace Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Item> list = new List<Item>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] items = input.Split();
                string serialNumber = items[0];
                string itemName = items[1];
                int itemQuantity = int.Parse(items[2]);
                decimal itemPrice = decimal.Parse(items[3],CultureInfo.InvariantCulture);

                Item item = new Item
                    (serialNumber,
                    itemName,
                    itemQuantity,
                    itemPrice);

                list.Add(item);
            }

            List<Item> list2 = list.OrderByDescending(i => i.BoxPrice).ToList();

            foreach (Item item in list2)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.ItemName} - ${item.ItemPrice:F2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.BoxPrice:F2}");
            }
        }
    }

    class Item
    {
        public string SerialNumber { get; set; }
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal BoxPrice
        {
            get
            {
                return ItemQuantity * ItemPrice;
            }
        }
        public Item(string serialNumber,
            string itemName,
            int itemQuantity,
            decimal itemPrice)
        {
            SerialNumber = serialNumber;
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;
        }
    }
}
string greeting = @"Welcome to Thrown for a Loop
Your one-stop shop for used sporting equipment!";

List<Product> products = new()
{
    new Product()
    {
        Name = "Football",
        Price = 15.00M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2 
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12.99M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2012,
        Condition = 2.4
    },
    new Product()
    {
        Name = "Boomerang",
        Price = 10.25M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2015,
        Condition = 5.0
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 5.50M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2022,
        Condition = 4.8
    },
    new Product()
    {
        Name = "Golf Putter",
        Price = 35.99M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2013,
        Condition = 3.1

    },
    new Product()
    {
        Name = "Baseball Bat",
        Price = 22.75M,
        Sold = false,
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2012,
        Condition = 4.5
    }
};

Console.WriteLine(greeting);
Console.WriteLine();

decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: ${totalValue}\n");

Console.WriteLine("Products: ");
for (int i = 0; i < products.Count; i++)
{
    Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Product chosenProduct = null;

while (chosenProduct == null)
{
    Console.WriteLine("Please enter a product number: ");
    try
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];
    }
    catch (FormatException)
    {
        Console.WriteLine("Please type only integers!");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Please choose an existing item only!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine("Do Better!");
    }
}
DateTime now = DateTime.Now;

TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old.
The products condition is {chosenProduct.Condition}
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");

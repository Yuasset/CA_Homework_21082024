using CA_Homework_21082024;

List<Food> food = new List<Food>();
List<Clothes> clothes = new List<Clothes>();
List<Electronic> electronic = new List<Electronic>();

Clothes clothes1 = new Clothes();
clothes1.Name = "T-Şort";
clothes1.Price = 50;
clothes1.Brand = "Nike";
clothes1.Color = "Mavi";

Food food1 = new Food();
food1.Name = "Süt";
food1.Price = 5;
food1.Dimension = "1 LT";
food1.ExpirationDate = new DateTime(2024, 8, 30);

Electronic electronic1 = new Electronic();
electronic1.Name = "Laptop";
electronic1.Price = 5000;
electronic1.Brand = "Apple";
electronic1.Modal = "Macbook Pro";

clothes.Add(clothes1);
food.Add(food1);
electronic.Add(electronic1);

foreach (Clothes item in clothes)
{
    Console.WriteLine($"Ad: {item.Name}, Marka: {item.Brand}, Renk: {item.Color}, Fiyat: {item.Price} TL, İndirimli Fiyat: {item.Discount()} TL, KDV: {item.PriceKDV} TL");
}

foreach (Food item in food)
{
    Console.WriteLine($"Ad: {item.Name}, Boyut: {item.Dimension}, Son Kullanma Tarihi: {item.ExpirationDate}, Fiyat: {item.Price} TL, KDV: {item.PriceKDV} TL");
}

foreach (Electronic item in electronic)
{
    Console.WriteLine($"Ad: {item.Name}, Marka: {item.Brand}, Model: {item.Modal}, Fiyat: {item.Price} TL, İndirimli Fiyat: {item.Discount()} TL, KDV: {item.PriceKDV} TL");
}
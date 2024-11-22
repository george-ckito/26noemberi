using _26noemberi;

Console.WriteLine("creating object");
Console.Write("name: ");
string name = Console.ReadLine();
Console.Write("age: ");
int age = int.Parse(Console.ReadLine());
Console.Write("breed: ");
string breed = Console.ReadLine();
Console.Write("sex: ");
string sex = Console.ReadLine();
if (!new string[2] { "male", "female" }.Contains(sex))
{
    Console.WriteLine("wrong input, male or female");
    return;
}
Cat cat = new Cat(name, breed, (uint) age, sex);
Console.WriteLine("\ncreated");
Console.Write("enter grams: ");
int grams = int.Parse(Console.ReadLine());
cat.Eat(grams);
Console.Write("\nenter meow count: ");
int count = int.Parse(Console.ReadLine());
cat.Meow(count);

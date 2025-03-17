Console.WriteLine("надобно ввести 1 число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("и второе тоже надобно");
int  b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"a & b = {a & b}");
Console.WriteLine($"a | b = {a | b}");
Console.WriteLine($"a ^ b = {a ^ b}");

Console.WriteLine($"b << 2 = {b << 2}");

Console.WriteLine($"a >> 2 = {a >> 2}");
int[] mas = new int[7]
{ 3600, 2100, 1000, 1450, 2390, 9100, 420};
Console.WriteLine("Введите сумму,которую необходимо представить в количестве купюр n номинала.");

int n = Convert.ToInt32(Console.ReadLine());

foreach (int x in mas) Console.WriteLine($"{n / x} Купюры номиналом {x}");







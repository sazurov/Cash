int[] mas = new int[7] 
{ 3600, 2100, 1000, 1450, 2390, 9100, 420};

Console.WriteLine("Введите сумму,которую необходимо представить в количестве купюр n номинала.");

int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 1; i++)
{
   foreach (int x in mas) Console.WriteLine($"{n/x} Купюры номиналом {x}");
}








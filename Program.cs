int[] mas = new int[7] 
{ 3600, 2100, 1000, 1450, 2390, 9100, 420};

Console.WriteLine("Введите сумму,которую необходимо представить в количестве купюр n номинала.");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n{n / mas[0]} Купюры номиналом {mas[0]}");

Console.WriteLine($"\n{n / mas[1]} Купюры номиналом {mas[1]}");

Console.WriteLine($"\n{n / mas[2]} Купюры номиналом {mas[2]}");

Console.WriteLine($"\n{n / mas[3]} Купюры номиналом {mas[3]}");

Console.WriteLine($"\n{n / mas[4]} Купюры номиналом {mas[4]}");

Console.WriteLine($"\n{n / mas[5]} Купюры номиналом {mas[5]}");

Console.WriteLine($"\n{n / mas[6]} Купюры номиналом {mas[6]}");








using ConsoleApp3;

Console.WriteLine("Billetera 1");
Billetera billetera1 = new Billetera(billete10: 2, billete20: 3, billete50: 1, billete100: 6, billete200: 7, billete500: 2, billete1000: 9);
Console.WriteLine($"Total billetera1: {billetera1.Total()}");

Console.WriteLine("Billetera 2");
Billetera billetera2 = new Billetera(billete10: 1, billete20: 4, billete50: 3, billete100: 1, billete200: 5, billete500: 10, billete1000: 3);
Console.WriteLine($"Total billetera2: {billetera2.Total()}");

Console.WriteLine("Billetera 3");

Billetera billetera3 = billetera1.CombinarBilleteras(billetera2);
Console.WriteLine($"Total billetera3: {billetera3.Total()}");

Console.WriteLine($"Luego de combinar Billetera 1: {billetera1.Total()}");

Console.WriteLine($"Luego de combinar Billetera 2: {billetera2.Total()}");

﻿Circulo circ1 = new Circulo();
//Console.WriteLine(circ1);
Circulo circ2 = new Circulo(2.4, 5, 3);
//Console.WriteLine(circ2);
CirculoColorido circ3 = new CirculoColorido();
//Console.WriteLine(circ3);
CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
//Console.WriteLine(circ4);

Console.WriteLine("---------------------------");
Console.WriteLine($"Circulo 1: {circ1}");
Console.WriteLine($"CentroX: {circ1.CentroX} | CentroY {circ1.CentroY} | Raio: {circ1.Raio}");
Console.WriteLine("---------------------------");
Console.WriteLine($"Circulo 2: {circ2}");
Console.WriteLine($"CentroX: {circ2.CentroX} | CentroY {circ2.CentroY} | Raio: {circ2.Raio}");
Console.WriteLine("---------------------------");
Console.WriteLine($"Circulo 3: {circ3}");
Console.WriteLine($"CentroX: {circ3.CentroX} | CentroY {circ3.CentroY} | Raio: {circ3.Raio} | Cor: {circ3.Cor}");
Console.WriteLine("---------------------------");
Console.WriteLine($"Circulo 4: {circ4}");
Console.WriteLine($"CentroX: {circ4.CentroX} | CentroY {circ4.CentroY} | Raio: {circ4.Raio} | Cor: {circ4.Cor}");
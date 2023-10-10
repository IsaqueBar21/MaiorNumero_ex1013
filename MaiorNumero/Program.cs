using System.Globalization;

string[] valores1 = Console.ReadLine().Split(' ');
double x1 = double.Parse(valores1[0]);
double y1 = double.Parse(valores1[1]);

string[] valores2 = Console.ReadLine().Split(' ');
double x2  = double.Parse(valores2[0]);
double y2 = double.Parse(valores2[1]);

double x = x1 - x2;
double y = y1 - y2;

double distancia = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
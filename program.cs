using v25;

Console.WriteLine("masukkan bilangan 1 : ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("masukkan bilangan 2 : ");
double b = Convert.ToDouble(Console.ReadLine());

Kalkulator kal = new Kalkulator(a,b);

Console.Write("masukkan pilihan (+, -, *, /) : ");
char op = Convert.ToChar(Console.ReadLine());

Console.Write($"{a} {op} {b} = ");
Console.WriteLine( kal.hitung(op) );

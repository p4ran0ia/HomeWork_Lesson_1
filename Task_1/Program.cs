Console.WriteLine("Input numbers: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    Console.WriteLine(a + " max " +  b + " min");
}
if(a < b)
{
    Console.WriteLine(b + " max " +  a + " min");
}
if(a == b)
{
    Console.WriteLine("the numbers are equal");
}



// Bài Toán Giai Thừa, tìm số từ 1 đến n
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Nhập n: ");
        double n = Convert.ToDouble(Console.ReadLine());
        double S = 1;
        double i = 1;


        while (i <= Convert.ToDouble(n))

        {
            S = S * i;
            i = i + 1;
            
            
        }
        
        Console.WriteLine($"Giai thừa của {n} là: {S}");
    }

}







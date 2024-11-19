namespace RectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter width: ");
            float width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            float height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
}

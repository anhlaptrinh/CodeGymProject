namespace CodeGymOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan
            {
                Speed = Fan.FAST, 
                Radius = 10,      
                Color = "yellow", 
                On = true         
            };

            // Tạo đối tượng Fan 2
            Fan fan2 = new Fan
            {
                Speed = Fan.MEDIUM, 
                Radius = 5,        
                Color = "blue",    
                On = false         
            };

            
            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}

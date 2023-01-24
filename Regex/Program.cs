namespace Regex_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the choise\n1 First Name");
            int choise = Convert.ToInt32(Console.ReadLine());
            Regex1 regex1=new Regex1();
            switch(choise)
            {
                case 1:
                    regex1.FirstName();
                    break;
                case 2:
                    regex1.LastName();
                    break;
                default:
                    Console.WriteLine("Enter Valid choise");
                    break;

            }
            
        }
    }
}
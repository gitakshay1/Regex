namespace Regex_Programs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the choise\n1 First Name\n2 Last Name\n3 Email ID\n4 Phone Numbern\n5 Password");
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
                case 3:
                    regex1.EmailId();
                    break;
                case 4:
                    regex1.PhoneNumber();
                    break;
                case 5:
                    regex1.Password();
                    break;
                default:
                    Console.WriteLine("Enter Valid choise");
                    break;

            }
            
        }
    }
}
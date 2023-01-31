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
                    regex1.FirstName("Akshay");
                    break;
                case 2:
                    regex1.LastName("Patil");
                    break;
                case 3:

                    regex1.EmailId("abc@yahoo.com");
                    regex1.EmailId("abc-100@yahoo.com");
                    regex1.EmailId("abc.100@yahoo.com");
                    regex1.EmailId("abc111@abc.com");
                    regex1.EmailId("abc-100@abc.net");
                    regex1.EmailId("abc.100@abc.com.au");
                    regex1.EmailId("abc@1.com");
                    regex1.EmailId("abc@gmail.com.com");
                    regex1.EmailId("abc+100@gmail.com");
                    break;
                case 4:
                    regex1.PhoneNumber("8953882239");
                    break;
                case 5:
                    regex1.Password("A@cnsi9");
                    break;
                default:
                    Console.WriteLine("Enter Valid choise");
                    break;

            }
            
        }
    }
}
using System;

namespace ValidateLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string user, password;
            string userValid = "admin";
            string passwordkValid = "admin";
            int count = 0;
            Console.Write("Kiem tra ten dang nhap va mat khau:\n");
            Console.Write("Gia tri mac dinh la: admin va admin\n");
            Console.Write("---------------------------------\n");
            do
            {
                Console.Write("Ten dang nhap: ");
                user = Console.ReadLine();

                Console.Write("Mat khau: ");
                password = Console.ReadLine();

                count++;
            } while ((user != userValid || password != passwordkValid) && count != 3);
            if (count == 3)
                Console.WriteLine("Dang nhap sai qua 3 lan,Moi ban thu lai trong giay lat!");
            else
                Console.WriteLine("Chuc mung ban da dang nhap thanh cong!");
            Console.ReadKey();
        }
    }
}

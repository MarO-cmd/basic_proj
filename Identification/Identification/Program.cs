using System;

namespace Identification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter Your Id : ");
                    string id = Console.ReadLine();
                    Id_analysis id1 = new Id_analysis(id);
                    id1.Display();
                }
            }
            catch (Wrong_Id ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}

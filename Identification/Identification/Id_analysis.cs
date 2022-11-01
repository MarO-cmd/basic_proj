using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identification
{
    internal class Wrong_Id : Exception
    {
        public override string Message
        {
            get
            {
                return "InCorrect Id!";
            }
        }
    }
    internal class Id_analysis
    {
        
        string id;
        string year;
        string month;
        string day;
        string government;
        int registration;
        int gender;
        int check;
        public Id_analysis()
        {
            Console.WriteLine("****** Analysis The Id ******");
            Id = "UnKnown!";
        }
        public Id_analysis(string id) 
        {
            Console.WriteLine("****** Analysis The Id ******");
            Id = id;
        }
        public string Id
        {
            get { return id; }
            set
            {
                if (value.Length == 14)
                    id = value;
                else throw new Wrong_Id();
                   
            }
        }
        void birth_date()
        {
            int first_3digit = int.Parse(id.Substring(0, 3));
            int Year = (first_3digit / 100) + 17;
            year = $"{Year.ToString()}{id.Substring(1, 2)}";
            month = id.Substring(3, 2);
            day = id.Substring(5, 2);
            string birth_date = $"{day}/{month}/{year}";
            Console.WriteLine($"Your Birth Date Is: {birth_date}");
        }
        void Government()
        {
            string govern = id.Substring(7, 2);
            switch (govern)
            {
                case "01":
                    government = "Cairo";
                    break;
                case "02":
                    government = "Alexandria";
                    break;
                case "03":
                    government = "Bor Said";
                    break;
                case "04":
                    government = "Suez";
                    break;
                case "11":
                    government = "Damietta";
                    break;
                case "12":
                    government = "Dakahlia";
                    break;
                case "13":
                    government = "El Sharkia";
                    break;
                case "14":
                    government = "Qalyubia";
                    break;
                case "15":
                    government = "Kafr El Sheikh";
                    break;
                case "16":
                    government = "Gharbia";
                    break;
                case "17":
                    government = "Menofia";
                    break;
                case "18":
                    government = "El Beheira";
                    break;
                case "19":
                    government = "El Ismailia";
                    break;
                case "21":
                    government = "Giza";
                    break;
                case "22":
                    government = "Beni Suef";
                    break;
                case "23":
                    government = "El Fayoum";
                    break;
                case "24":
                    government = "El Minya";
                    break;
                case "25":
                    government = "Assuit";
                    break;
                case "26":
                    government = "Sohag";
                    break;
                case "27":
                    government = "Qena";
                    break;
                case "28":
                    government = "Aswan";
                    break;
                case "29":
                    government = "Luxor";
                    break;
                case "31":
                    government = "Al Bahr Al Ahmar";
                    break;
                case "32":
                    government = "El Wadi El Gedid";
                    break;
                case "33":
                    government = "Matrouh";
                    break;
                case "34":
                    government = "Shamal Sinai";
                    break;
                case "35":
                    government = "Ganoub Sinai";
                    break;
                case "88":
                    government = "Out Of Egypt";
                    break;
                default:
                    government = "UnKnown!";
                    break;
            }
            Console.WriteLine($"You Are From {government} Government");
        }
        void Nth()
        {
            registration = int.Parse(id.Substring(9, 3));
            Console.WriteLine($"You Are Number {registration} In Computer Registration Among Children On Your Birthday");
        }
        void Gender()
        {
            gender = int.Parse(id.Substring(12, 1));
            if (gender % 2 == 0)
                Console.WriteLine("Your Gender Is Female");
            else
                Console.WriteLine("Your Gender Is Male");
        }
        void Check()
        {
            check = int.Parse(id.Substring(13, 1));
            Console.WriteLine($"The Last Number Of Your Id : {check} Used To Detect If Your Identification Is Fake Or Not");
        }
        public void Display()
        {
            birth_date();
            Government();
            Gender();
            Nth();
            Check();
        }
    
    
    
    }
}

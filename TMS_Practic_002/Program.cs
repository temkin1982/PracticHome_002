namespace TMS_Practic_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ввести номер месяца для получения пары года: ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("зима ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("весна ");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("лето ");
                    break;  
                case 9:
                case 10:    
                case 11:
                    Console.WriteLine("осень  ");
                    break;
                default:
                    Console.WriteLine("неправильно введен номер месяца! ");
                    break;
            }Console.WriteLine("------------------------------------------");
           
            if(month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("зима ");
            }
            else if (month == 3 || month == 4 || month == 5)  
            {
                Console.WriteLine("весна ");
            }
            else if(month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("лето ");
            }
            else if(month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("осень ");
            }
            else
            {
                Console.WriteLine("неправильно введен номер месяца! ");
            }
            Console.WriteLine("-----------------------------");
            
            Console.Write("ввести любое число: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0 )
            {
                Console.WriteLine($"четное число {num} ");
            }
            else
            {
                Console.WriteLine($"не четное число {num} ");
            }
            Console.WriteLine("--------------------------------------");

            Console.Write("вести температуры на улице: ");
            int t = int.Parse(Console.ReadLine());
            if (t > -6) Console.WriteLine("тепло ");
            if (-5 >= t && t > -20) Console.WriteLine("нормально ");
            if (-20 >= t) 
            {
                Console.WriteLine("холодно ");
            }
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("ввести номер для цвета радуги от 1-7 : ");
            int rainbow = int.Parse(Console.ReadLine());

            switch (rainbow)
            {
                case 1:
                    Console.WriteLine("красный ");
                    break;  
                case 2:
                    Console.WriteLine("оранжевый ");
                    break;
                case 3:
                    Console.WriteLine("жёлтый ");
                    break;  
                case 4:
                    Console.WriteLine("зелёный ");
                    break;
                case 5:
                    Console.WriteLine("голубой ");
                    break;
                case 6:
                    Console.WriteLine("синий ");
                    break;  
                case 7:
                    Console.WriteLine("фиолетовый ");
                    break;

            }
            Console.WriteLine("______________________________");

        }
        

        
        
    }
}
using mo4ur.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace mo4ur
{
    public class Program
    {
        public static void Menu()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("|          МЕНЮ          |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("|01|Салати               |");
            Console.WriteLine("|02|Студени предястия    |");
            Console.WriteLine("|03|Топли предястия      |");
            Console.WriteLine("|04|Бургери и Сандвичи   |");
            Console.WriteLine("|05|Риба и Морски Дарове |");
            Console.WriteLine("|06|Основни ястия        |");
            Console.WriteLine("|07|Паста                |");
            Console.WriteLine("|08|Пици                 |");
            Console.WriteLine("|09|Скара                |");
            Console.WriteLine("|10|Гарнитури            |");
            Console.WriteLine("|11|Хляб                 |");
            Console.WriteLine("|12|Сосове               |");
            Console.WriteLine("|13|Десерти              |");
            Console.WriteLine("|14|Напитки              |");
            Console.WriteLine("|15|Сметката             |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("За да си изберете, Вие цифра натиснете!");
        }
        public static List<Mo4ur> Choice()
        {
            List<Mo4ur> slavi = new List<Mo4ur>();
            while (true)
            {
                Console.Clear();
                Menu();
                Console.Write("Направете своя избор: ");
                string izbor = Console.ReadLine();
                string path = "" ;
                if (izbor == "1") path = "Салати.txt";
                else if (izbor == "2") path = "Студени предястия.txt";
                else if (izbor == "3") path = "Топли предястия.txt";
                else if (izbor == "4") path = "Бургери и Сандвичи.txt";
                else if (izbor == "5") path = "Риба и Морски Дарове.txt";
                else if (izbor == "6") path = "Основни ястия.txt";
                else if (izbor == "7") path = "Паста.txt";
                else if (izbor == "8") path = "Пици.txt";
                else if (izbor == "9") path = "Скара.txt";
                else if (izbor == "10") path = "Гарнитури.txt";
                else if (izbor == "11") path = "Хляб.txt";
                else if (izbor == "12") path = "Сосове.txt";
                else if (izbor == "13") path = "Десерти.txt";
                
                else if (izbor == "14") path = "Напитки.txt";
                else if (izbor == "15") 
                {
                    goto End;
                }

                else
                {
                    Console.Clear();
                    continue;
                }
                Console.Clear();
                StreamReader stream = new StreamReader(path);
                List<string> list = new List<string>();
                string line = stream.ReadLine();
                while(line!=null)
                {
                    list.Add(line);
                    line = stream.ReadLine();
                }
                stream.Close();
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }
                string temp = null;
                while (true)
                {
                    Console.WriteLine("За да си изберете, Вие цифра натиснете!");
                    Console.Write("Направете своя избор: ");
                    string izbor2 = Console.ReadLine();
                    try
                    {
                        temp = list[int.Parse(izbor2)+2];
                        if (temp.Contains(" ")) break;
                        Console.WriteLine("Въведете валиден избор!");
                        continue;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Въведете валиден избор!");
                        continue;
                    }
                }
                string[] split = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                slavi.Add(new Mo4ur(split[1], decimal.Parse(split[2]), int.Parse(split[4])));
            }
        End:
            return slavi;
        }
        
        static void Main(string[] args)
        {
            List<Mo4ur> list = new();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Добре дошли в ресторант \"Moчур\"!");
            Console.Write("Въведете име и фамилия, на които да се води резервацията (на английски): ");
            string ime = Console.ReadLine();
            while (true)
            {
                while(ime=="Slavi Temelkov")
                {
                    Console.WriteLine("Съжеляваме, но нашият ресторант не предлага маса за повече от петима души.");
                    Console.Clear();
                    Console.WriteLine("Добре дошли в ресторант \"Moчур\"!");
                    Console.Write("Въведете име и фамилия, на които да се води резервацията (на английски): ");
                    ime = Console.ReadLine();
                }
                if (Regex.IsMatch(ime, @"\A[A-Z][a-z]+ [A-Z][a-z]+\z"))
                {
                    Console.WriteLine("Валидно име: " + ime);
                    break;
                }
                else
                {
                    Console.WriteLine(ime + " има грешка.");
                    Console.Write("Опитай пак: ");
                    ime = Console.ReadLine();

                }
            }
            Console.Write("За колко човека искате да бъде резервацията (1-5): ");
            string ResNum = Console.ReadLine();
            while (true)
            {

                if (Regex.IsMatch(ResNum, @"\A[1-5]\z"))
                {
                    Console.WriteLine("Валидно число: " + ResNum);
                    break;
                }
                else
                {
                    Console.WriteLine(ResNum + " има грешка.");
                    Console.Write("Опитай пак: ");
                    ResNum = Console.ReadLine();

                }
            }
            Console.Write("За кога искате да запазите регистрацията: ");
            Console.WriteLine("Можете да резервирате ден, който е рамките на следващият един месец.");
            Console.Write("Въведете месец: ");
            string mesec = Console.ReadLine();
            Console.Write("Въведете ден: ");
            string den = Console.ReadLine();
            while (true)
            {
                if((mesec=="August" || mesec =="august"|| mesec == "AUGUST")&&(int.Parse(den)>=1|| int.Parse(den) <=15))
                    {
                    Console.WriteLine($"Валидна информация.");break;
                }
                else if ((mesec == "July" || mesec == "july" || mesec == "JULY") && (int.Parse(den) >= 15 || int.Parse(den) <= 31))
                    {
                    Console.WriteLine($"Валидна информация."); break;
                }
                
                
                else
                {
                    Console.WriteLine("Грешно въведена дата или месец.");
                    Console.Write("Опитай пак: ");
                    mesec = Console.ReadLine();
                    den = Console.ReadLine();

                }
            }
            Console.Clear();
            if (ResNum == "1")
            {
                Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за един човек.");
            }
            else if (ResNum == "2")
            {
                Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за двама души.");
            }
            else if (ResNum == "3")
            {
                Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за трима души.");
            }
            else if (ResNum == "4")
            {
                Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за четирима души.");
            }
            else
            {
                Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за петима души.");
            }
            Console.Write("Искате ли да Ви покажем менюто си? Отговор (на английски): ");
            string VhMenu = Console.ReadLine();
            while (true)
            {

                if (Regex.IsMatch(VhMenu, @"\A(yes|yeah|yep|y|true|t|1|Yes|Yeah|Yep|Y|True|T|YES|YEAH|YEP|TRUE)\z"))
                {
                    Console.WriteLine("Валиден отговор: " + VhMenu);
                    Console.Clear();
                    List<Mo4ur> slavi = Choice();
                    Console.Clear();
                    Console.WriteLine("НЕЩАТА, КОИТО СИ ИЗБРАХТЕ СА: ");
                    decimal br = 0;
                    foreach (Mo4ur slavche in slavi)
                    {
                        Console.WriteLine($"|{slavche}|");
                        br += slavche.Price;
                    }
                    Console.WriteLine($"Общата Ви сума е: {br} лв.");

                    string outputPath = "Изход.txt";
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {
                        writer.WriteLine($"Резервация на: {ime}");
                        writer.WriteLine($"Брой души: {ResNum}");
                        writer.WriteLine($"Вашата резервация е за месец {mesec}, ден {den}.");
                        writer.WriteLine();
                        writer.WriteLine("НЕЩАТА, КОИТО СИ ИЗБРАХТЕ СА:");
                        foreach (Mo4ur slavche in slavi)
                        {
                            writer.WriteLine($"|{slavche}|");
                        }
                        writer.WriteLine($"Общата Ви сума е: {br} лв.");
                        writer.WriteLine("Вие бяхте обслужен/а от виртуален сервитьор Калоян Иванов.");
                    }

                    Console.WriteLine("Информацията е записана във файл " + outputPath);
                    Console.WriteLine("Вие бяхте обслужен/а от виртуален сервитьор Калоян Иванов.");
                    break;
                }
                else if (Regex.IsMatch(VhMenu, @"\A(no|nope|n|false|f|0|No|Nope|N|False|F|NO|NOPE|FALSE)\z"))
                {
                    Console.WriteLine("Валиден отговор: " + VhMenu);
                    Console.Clear();
                    Console.WriteLine("Довиждане,");
                    Console.WriteLine("Заповядайте отново!");
                    break;
                }
                else
                {
                    Console.WriteLine(VhMenu + " има грешка. Не сте отговорил с yes or no.");
                    Console.Write("Опитай пак: ");
                    VhMenu = Console.ReadLine();

                }
            }
        }
    }
}

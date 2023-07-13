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
            Console.WriteLine("|15|Изход                |");
            Console.WriteLine("--------------------------");
            Console.WriteLine("За да си изберете, Вие цифра натиснете!");
        }

        //public static bool checkInput(string text, string pattern)
        //{
        //    if (Regex.IsMatch(text, pattern))
        //    {
        //        string[] nos = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //        Console.WriteLine("Валидно число: " + text);
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine(text + " има грешка.");
        //        Console.Write("Опитай пак: ");
        //        return false;

        //    }
        //}

        public static Mo4ur Choice(string izbor)
        {
            while (true)
            {
                izbor = Console.ReadLine();
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
                else if (izbor == "15") path = "Изход.txt";
                else continue;
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
                while (true)
                {
                    string izbor2 = Console.ReadLine();
                    try
                    {
                        string temp = list[int.Parse(izbor2)];
                        using (StreamWriter writer = new StreamWriter("Изход.txt"))
                        {
                            writer.WriteLine("Hello, World!");
                        }
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
        //public static Mo4ur JohnCena(int johnCena)
        //{
        //    StreamReader streamReader;
        //    string[] strings = { "Салати", "Студени предястия", "Топли предястия", "Бургери и Сандвичи", "Риба и Морски Дарове",
        //        "Основни ястия", "Паста", "Пици", "Скара", "Гарнитури", "Хляб", "Сосове", "Десерти", "Напитки" , "Изход"};
        //    streamReader = new StreamReader($"{strings[johnCena - 1]}.txt");
        //    Console.WriteLine(streamReader.ReadToEnd());
        //    streamReader.Close();
        //    streamReader = new StreamReader($"{strings[johnCena - 1]}.txt");
        //    string izbor = Console.ReadLine();
            //while (true)
            //{

            //    if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-9]\z)|(\A[2][0-9]\z)|(\A[3][0-1]\z)"))
            //    {
            //        Console.WriteLine("Валидно число: " + izbor);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(izbor + " има грешка.");
            //        Console.Write("Опитай пак: ");
            //        izbor = Console.ReadLine();

            //    }
        //    }
        //    int br = -2;
        //    Mo4ur goshko = null;
        //    while (true)
        //    {
        //        try
        //        {
        //            streamReader = new StreamReader($"{strings[johnCena - 1]}.txt");
        //            string zapis = streamReader.ReadLine();

        //            Console.WriteLine(zapis);

        //            if (br == int.Parse(izbor))
        //            {

        //                if (johnCena == 1)
        //                {
        //                    while (true)
        //                    {
        //                        //string regex = @"(\A[1-9]\z)|(\A[1][0-9]\z)|(\A[2][0-9]\z)|(\A[3][0-1]\z)";
        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-9]\z)|(\A[2][0-9]\z)|(\A[3][0-1]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Salati(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }

        //                else if (johnCena == 2)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-8]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new SP(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 3)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-8]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new TP(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 4)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-1]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new BuGi(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 5)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-1]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Riba(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 6)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-9]\z)|(\A[2][0-1]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Osn(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 7)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-1]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Pasta(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 8)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-9]\z)|(\A[3][0]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Pizza(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 9)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-7]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Skara(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 10)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-3]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Garni(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 11)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-6]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Hlqb(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 12)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-4]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Sos(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 13)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-7]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Desert(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }

        //                }
        //                else if (johnCena == 14)
        //                {
        //                    while (true)
        //                    {

        //                        if (Regex.IsMatch(izbor, @"(\A[1-9]\z)|(\A[1][0-9]\z)|(\A[2][0-2]\z)"))
        //                        {
        //                            string[] nos = zapis.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        //                            Console.WriteLine("Валидно число: " + izbor);
        //                            goshko = new Nap(nos[1], decimal.Parse(nos[2]), int.Parse(nos[4]));
        //                            break;
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine(izbor + " има грешка.");
        //                            Console.Write("Опитай пак: ");
        //                            izbor = Console.ReadLine();

        //                        }
        //                    }
        //                }

        //                break;
        //            }
        //            br++;
        //            streamReader.Close();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Error happened");
        //            Console.WriteLine(e.Message);
        //        }
                
        //    }
        //    streamReader.Close();
        //    return goshko;
        //}
        static void Main(string[] args)
        {
            List<Mo4ur> list = new();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Добре дошли в ресторант \"Moчур\"!");
            //Console.Write("Въведете име и фамилия, на които да се води резервацията (на английски): ");
            //string ime = Console.ReadLine();
            //bool isvalidname = false;
            //while (!isvalidname)
            //{
            //    if (ime == "Slavi Temelkov")
            //    {
            //        Console.WriteLine("Съжеляваме, но нашият ресторант не предлага маса за повече от петима души.");
            //        Console.Write("Опитай пак: ");
            //        ime = Console.ReadLine();
            //    }
            //    if (Regex.IsMatch(ime, @"\A[A-Z][a-z]+ [A-Z][a-z]+\z"))
            //    {
            //        isvalidname = true;
            //        Console.WriteLine("Валидно име: " + ime);
            //    }
            //    else
            //    {
            //        Console.WriteLine(ime + " има грешка.");
            //        Console.Write("Опитай пак: ");
            //        ime = Console.ReadLine();

            //    }
            //}
            //Console.Write("За колко човека искате да бъде резервацията (1-5): ");
            //string ResNum = Console.ReadLine();
            //while (true)
            //{

            //    if (Regex.IsMatch(ResNum, @"\A[1-5]\z"))
            //    {
            //        Console.WriteLine("Валидно число: " + ResNum);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine(ResNum + " има грешка.");
            //        Console.Write("Опитай пак: ");
            //        ResNum = Console.ReadLine();

            //    }
            //}
            //if (ResNum == "1")
            //{
            //    Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за един човек.");
            //}
            //else if (ResNum == "2")
            //{
            //    Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за двама души.");
            //}
            //else if (ResNum == "3")
            //{
            //    Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за трима души.");
            //}
            //else if (ResNum == "4")
            //{
            //    Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за четирима души.");
            //}
            //else
            //{
            //    Console.WriteLine($"Вашата резервация е на името на {ime} и ще е за петима души.");
            //}
            Console.Write("Искате ли да Ви покажем менюто си? Отговор (на английски): ");
            string VhMenu = Console.ReadLine();
            while (true)
            {

                if (Regex.IsMatch(VhMenu, @"\A(yes|yeah|yep|y|true|t|1|Yes|Yeah|Yep|Y|True|T|YES|YEAH|YEP|TRUE)\z"))
                {
                    Console.WriteLine("Валиден отговор: " + VhMenu);
                    Console.Clear();
                    Menu();
                    string IChislo = Console.ReadLine();

                    Choice(IChislo);
                    //while (true)
                    //{

                    //    if (Regex.IsMatch(IChislo, @"(\A[1-9]\z)|(\A[1][0-5]\z)"))
                    //    {
                    //        Console.WriteLine("Валидно число: " + IChislo);
                    //        Console.Clear();
                    //        list.Add(JohnCena(int.Parse(IChislo)));
                    //        if (IChislo == "15")
                    //        {
                    //            Console.WriteLine(list);
                    //            break;
                    //        }
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine(IChislo + " има грешка.");
                    //        Console.Write("Опитай пак: ");
                    //        IChislo = Console.ReadLine();

                    //    }
                    //}
                }
                else if (Regex.IsMatch(VhMenu, @"\A(no|nope|n|false|f|0|No|Nope|N|False|F|NO|NOPE|FALSE)\z"))
                {
                    Console.WriteLine("Валиден отговор: " + VhMenu);
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

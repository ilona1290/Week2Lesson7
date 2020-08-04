using System;

namespace SecondHomework
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void Ex1(int a, int b)
        {
            if (a == b)
                Console.WriteLine($"{a} i {b} są równe.");
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe.");
            }
        }

        public void Ex2()
        {
            int a;
            Console.Write("Podaj liczbę całkowitą, a sprawdzę czy jest ona parzysta, czy nieparzysta: ");
            Int32.TryParse(Console.ReadLine(), out a);
            if (a % 2 == 0)
                Console.WriteLine($"{a} jest liczbą parzystą.");
            else
            {
                Console.WriteLine($"{a} jest liczbą nieparzystą");
            }
        }

        public void Ex3()
        {
            int a;
            Console.Write("Podaj liczbę całkowitą, a sprawdzę czy jest ona dodatnia, czy ujemna: ");
            Int32.TryParse(Console.ReadLine(), out a);
            if (a > 0)
                Console.WriteLine($"{a} jest liczbą dodatnią.");
            else if (a == 0)
                Console.WriteLine($"Liczba jest zerem.");
            else
            {
                Console.WriteLine($"{a} jest liczbą ujemną.");
            }
        }

        public void Ex4()
        {
            int year;
            Console.Write("Podaj rok, a sprawdzę czy jest on przestępny, czy nie: ");
            Int32.TryParse(Console.ReadLine(), out year);
            if (year % 4 == 0)
                Console.WriteLine($"{year} jest rokiem przestępnym.");
            else
                Console.WriteLine($"{year} nie jest rokiem przestępnym.");
        }

        public void Ex5()
        {
            int age;
            Console.Write("Podaj swój wiek, a powiem Ci, czy możesz się ubiegać o stanowisko  posła, premiera, sentarora, prezydenta. ");
            Int32.TryParse(Console.ReadLine(), out age);
            if (age < 21)
                Console.WriteLine("Nie możesz ubiegać się o żadne stanowisko");
            else if (age < 30)
                Console.WriteLine("Możesz ubiegać się o stanowisko posła i premiera.");
            else if (age < 35)
                Console.WriteLine("Możesz ubiegać się o stanowisko posła, premiera i senatora.");
            else
            {
                Console.WriteLine("Możesz ubiegać się o stanowisko posła, premiera, senatora i prezydenta.");
            }
        }

        public void Ex6()
        {
            int height;
            Console.Write("Podaj swój wzrost w cm, a powiem Ci, kategorię wzrostu do której należysz. ");
            Int32.TryParse(Console.ReadLine(), out height);
            if (height < 100)
                Console.WriteLine("Jesteś karłem.");
            else if (height < 150)
                Console.WriteLine("Jesteś krasnoludem.");
            else if (height < 180)
                Console.WriteLine("Jesteś niski.");
            else if (height < 200)
                Console.WriteLine("Jesteś wysoki.");
            else
                Console.WriteLine("Jesteś wielkoludem.");
        }

        public void Ex7()
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Podaj trzy liczby, a powiem Ci, która jest największa.");
            Console.Write("Pierwsza liczba: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Druga liczba: ");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.Write("Trzecia liczba: ");
            Int32.TryParse(Console.ReadLine(), out c);

            if (a < b)
            {
                if (b < c)
                    Console.WriteLine($"{c} jest największa z podanych.");
                else
                    Console.WriteLine($"{b} jest największa z podanych.");
            }
            else if (a < c)
            {
                if (b > c)
                    Console.WriteLine($"{b} jest największa z podanych.");
                else
                    Console.WriteLine($"{c} jest największa z podanych.");
            }
            else
                Console.WriteLine($"{a} jest największa z podanych.");
        }

        public void Ex8()
        {
            int maths;
            int physics;
            int chemistry;
            Console.WriteLine("Podaj swoje wyniki z matury z matmy, fizyki i chemii, a powiem czy jesteś dopuszczony do rektutacji.");
            Console.Write("Wynik z matmy: ");
            Int32.TryParse(Console.ReadLine(), out maths);
            Console.Write("Wynik z fizyki: ");
            Int32.TryParse(Console.ReadLine(), out physics);
            Console.Write("Wynik z chemii: ");
            Int32.TryParse(Console.ReadLine(), out chemistry);
            int sum = maths + physics + chemistry;

            if ((maths > 70 && physics > 45 && chemistry > 45 && sum > 180) || (maths + physics > 150) || (maths + chemistry > 150))
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            else
                Console.WriteLine("Kandydat nie dopuszczony do rekrutacji.");
        }

        public void Ex9()
        {
            int temperature;
            Console.Write("Podaj temperature, a powiem Ci, do której kryterii temperatur ona należy: ");
            Int32.TryParse(Console.ReadLine(), out temperature);

            if (temperature < 0 )
                Console.WriteLine("Cholernie piździ.");
            else if (temperature >= 0 && temperature < 10)
                Console.WriteLine("Zimno.");
            else if (temperature >= 10 && temperature < 20)
                Console.WriteLine("Chłodno.");
            else if(temperature >= 20 && temperature < 30)
                Console.WriteLine("W sam raz.");
            else if (temperature >= 30 && temperature < 40)
                Console.WriteLine("Zaczyna być słabo, bo gorąco.");
            else
                Console.WriteLine("A weź wyprowadzam się na alaskę.");
        }

        public void Ex10()
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Podaj 3 długości boków, a powiem Ci czy da się z nich zbudować trójkąt.");
            Console.Write("Pierwszy bok: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Drugi bok: ");
            Int32.TryParse(Console.ReadLine(), out b);
            Console.Write("Trzeci bok: ");
            Int32.TryParse(Console.ReadLine(), out c);

            if ((a > b + c) || (b > a + c) || (c > a + b))
                Console.WriteLine("Można zbudować trójkąt.");
            else
                Console.WriteLine("Nie można zbudować trójkąta.");
        }

        public void Ex11()
        {
            int note;
            Console.Write("Podaj ocenę od 1 do 6, a zwrócę jej nazwę: ");
            int.TryParse(Console.ReadLine(), out note);
            switch (note)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
            }
        }

        public void Ex12()
        {
            int day;
            Console.Write("Podaj numer tygodnia, a zwrócę Ci jego nazwę: ");
            Int32.TryParse(Console.ReadLine(), out day);
            switch(day)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
            }
        }

        public void Ex13()
        {
            int a;
            int b;
            int chosenOption;
            Console.WriteLine("Witaj w prostym kalkulatorze.");
            Console.Write("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out a);
            Console.Write("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Podaj numer operacji do wykonania.");
            Console.WriteLine(" 1. Dodawanie \r\n 2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");
            Int32.TryParse(Console.ReadLine(), out chosenOption);
            switch (chosenOption)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to: {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to: {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Twój wynik to: {a * b}");
                    break;
                case 4:
                    if (b != 0)
                        Console.WriteLine($"Twój wynik to: {a / b}");
                    else
                        Console.WriteLine("Nie dzielimy przez 0.");
                    break;
            }

        }
    }
}

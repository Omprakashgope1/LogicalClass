using System.Diagnostics;

namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool wantToKnow = true;
            while (wantToKnow) 
            {
                Console.WriteLine("Mention the sequence of operation you want to perform : ");
                int val = Convert.ToInt32(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        Name nm = new Name();
                        nm.GetNames();
                        break;
                    case 2:
                        Square sq = new Square();
                        sq.GetSquare();
                        break;
                    case 3:
                        Place pl = new Place();
                        pl.GetPlaces();
                        break;
                    case 4:
                        TenTimes tenT = new TenTimes();
                        tenT.FindVal();
                        break;
                    case 5:
                        FullName fullT = new FullName();
                        fullT.ConcatName();
                        break;
                    case 6:
                        PrintRandom pr = new PrintRandom();
                        pr.Average();
                        break;
                    case 7:
                        Circle cr = new Circle();
                        cr.AreaPerimeter();
                        break;
                    case 8:
                        NextDate nd = new NextDate();
                        nd.findNexTDate();
                        break;
                    case 9:
                        Time tm = new Time();
                        tm.executionTime();
                        break;
                    case 10:
                        ConvertVal cv = new ConvertVal();
                        cv.ConvertTheVal();
                        break;
                    case 11:
                        CheckString cs = new CheckString();
                        cs.checkingTheString();
                        break;
                    default:
                        Console.WriteLine("Wrong input provided");
                        break;
                }  
                Console.WriteLine("Want to know run other operations (Y/N)");
                String response = Console.ReadLine().ToUpper();
                if(response != "Y")
                {
                    wantToKnow = false;
                }
            }
        }
    }
    class Name
    {
        public void GetNames()
        {
            Console.WriteLine("Ram");
            Console.WriteLine("Ankit");
            Console.WriteLine("Shekhar");
            Console.WriteLine("Shrawan");
            Console.WriteLine("Chandan");
        }

    }
    class Square
    {
        double num1;
        double num2;
        public void GetSquare()
        {
            Console.WriteLine("Write the first number");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write the second number");
            num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 * num1 + num2 * num2;
            double diff = Math.Abs(num1 * num1 - num2 * num2);
            Console.WriteLine("The sum of square of given two numbers is : " + sum);
            Console.WriteLine("The difference of given two numbers is :" + diff);
            Console.ReadKey();

        }
    }
    class Place
    {
        String name;
        public void GetPlaces()
        {
            Console.WriteLine("Write the name of the place you want to visit");
            String place = Console.ReadLine();
            Console.WriteLine("The place you want to visit in upper case : " + place.ToUpper());
            Console.WriteLine("The place you want to visit in lower case : " + place.ToLower());
        }

    }
    class TenTimes
    {
        public void FindVal()
        {
            Console.WriteLine("Please enter the value");
            String val = Console.ReadLine();
            double num = Convert.ToDouble(val);
            num *= 10;
            String ans = Convert.ToString(num);
            Console.WriteLine(ans + " is 10 times of the value of " + val);
        }
    }
    class FullName
    {
        String name;
        int count;
        public void ConcatName()
        {
            count = 0;
            Console.WriteLine("Write your first name");
            String firstName = Console.ReadLine();
            Console.WriteLine("Write your Middle name");
            String middleName = Console.ReadLine();
            Console.WriteLine("Write your last name");
            String lastName = Console.ReadLine();
            if (firstName != "")
            {
                count++;
                name = name + firstName;
            }
            if (middleName != "")
            {
                count++;
                name = name + " " + middleName;
            }
            if (lastName != "")
            {
                count++;
                name = name + " " + lastName;
            }
            Console.WriteLine("You have " + count + " variables in your name and your full name is " + name);
        }
    }
    class PrintRandom
    {
        public void Average()
        {
            Random rn = new Random();
            int val1 = rn.Next(10, 51);
            int val2 = rn.Next(10, 51);
            int val3 = rn.Next(10, 51);
            int val4 = rn.Next(10, 51);
            int val5 = rn.Next(10, 51);
            Console.WriteLine("The random values are " + val1 + "," + val2 + "," + val3 + "," + val4 + "," + val5);
            double av = (val1 + val2 + val3 + val4 + val5) / 5.0;
            Console.WriteLine("The average of the numbers is " + av);
        }
    }
    class Circle
    {
        double area;
        double perimeter;
        public void AreaPerimeter()
        {
            Console.WriteLine("Please write the diameter of the circle");
            double radius = Convert.ToDouble(Console.ReadLine()) / 2;
            area = Math.PI * radius * radius;
            perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The area and perimeter of the circle are " + area + " and " + perimeter);
        }
    }
    class Time
    {
        public void executionTime()
        {
            Console.WriteLine("Mention the sequence of operation you want to find the time of execution :");
            int val = Convert.ToInt32(Console.ReadLine());
            Stopwatch sw = Stopwatch.StartNew();
            switch (val)
            {
                case 1:
                    Name nm = new Name();
                    nm.GetNames();
                    break;
                case 2:
                    Square sq = new Square();
                    sq.GetSquare();
                    break;
                case 3:
                    Place pl = new Place();
                    pl.GetPlaces();
                    break;
                case 4:
                    TenTimes tenT = new TenTimes();
                    tenT.FindVal();
                    break;
                case 5:
                    FullName fullT = new FullName();
                    fullT.ConcatName();
                    break;
                case 6:
                    PrintRandom pr = new PrintRandom();
                    pr.Average();
                    break;
                case 7:
                    Circle cr = new Circle();
                    cr.AreaPerimeter();
                    break;
                default:
                    Console.WriteLine("Wrong input provided");
                    break;

            }
            sw.Stop();
            Console.WriteLine("the time of execution of the specific program is : " + sw.ElapsedMilliseconds);
        }
    }
    class ConvertVal
    {
        String ans;
        public void ConvertTheVal()
        {
            Console.WriteLine("Please enter the val :");
            int val = Convert.ToInt32((Console.ReadLine()));
            if (val % 3 == 0) ans = ans + "Pling";
            if (val % 5 == 0) ans = ans + "Plang";
            if (val % 7 == 0) ans = ans + "Plong";
            Console.WriteLine("Above value string conversion is : " + ans);
        }
    }
    class CheckString
    {
        int count;
        public void checkingTheString()
        {
            count = 0;
            Console.WriteLine("Intput the string : ");
            String val = Console.ReadLine();
            bool[] check = new bool[3];
            for(int i = 0;i < val.Length;i++)
            {
                if (val[i] == 'a' && check[0] == false)
                {
                    check[0] = true;
                    count++;
                }
                else if (val[i] == 'e' && check[1] == false)
                {
                    check[1] = true;
                    count++;
                }
                else if (val[i] == 'p' && check[2] == false)
                {
                    check[2] = true;
                    count++;
                }
                if(count == 3) break;
            }
            if(count == 3)
            {
                Console.WriteLine("All Present");
            }
            else if(count > 0)
            {
                Console.WriteLine("One or more present");
            }
        }
    }
    class NextDate
    {
        public void findNexTDate()
        {
            Console.WriteLine("Please enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            if(month > 12)
            {
                Console.WriteLine("Please write valid date");
                return;
            }
            Console.WriteLine("Please enter the day : ");
            int day = Convert.ToInt32(Console.ReadLine());
            if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if(day > 31)
                {
                    Console.WriteLine("Please input valid date");
                    return;
                }
                else if(day == 31)
                {
                    day = 1;
                    month = (month + 1);
                    if(month == 13)
                    {
                        month = 1;
                        year++;
                    }
                }
                else
                {
                    day++;
                }
            }
            else if(month == 2)
            {
                if(day > 29)
                {
                    Console.WriteLine("Please input valid date");
                    return;
                }
                if(year % 4 == 0)
                {
                    if (day == 29)
                    {
                        day = 1;
                        month = (month + 1);
                    }
                    else
                    {
                        day++;
                    }
                }
                else
                {
                    if (day == 28)
                    {
                        day = 1;
                        month = (month + 1);
                    }
                    else
                    {
                        day++;
                    }
                }
            }
            else
            {
                if (day == 30)
                {
                    day = 1;
                    month = (month + 1);
                }
                else
                {
                    day++;
                }
            }
            String ans = day + "/" + month + "/" + year;
            Console.WriteLine("The next day of given day is " +ans);
        }
    }
}

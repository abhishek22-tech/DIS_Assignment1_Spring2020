using System;

namespace Assignment1_Spring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            Console.WriteLine(UsfTime(s));

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            int n4 = 7;
            Stones(n4);


        }


        private static void PrintPattern(int n)
        {
            try
            {
                if(n != 0)  //* Below code will work only if number is not 0 *//
                {
                    for (int i = n; i > 0; i--) //* This loop will print the numbers in a line *//
                    {
                        Console.Write(i);
                    }
                    n--;
                    Console.WriteLine(); //* This is taking the numbers to next line *//
                    if (n != 0)
                    {
                        PrintPattern(n); //* Recursive Function *//
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }


        private static void PrintSeries(int n2)
        {
            try
            {
                int sum = 0;        //* Inititalizing sum to 0 *//
                for (int i = 1; i <= n2; i++)      //* Loop from 1 to entered number to add *//
                {
                    sum = sum + i;      //* Adding the numbers *//
                    Console.WriteLine(" " + sum);     //* Printing the sum *//

                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }


        public static string UsfTime(string s)
        {
            try
            {
                Console.Write("Input the time which is to be transformed in HR:MIN:SEC(AM/PM):");
                string input = s;
                DateTime Earthtime = Convert.ToDateTime(input);
                Console.WriteLine("Entered time is :" + Earthtime.ToLongTimeString());
                int InputedHour = Earthtime.Hour;
                if (InputedHour.ToString("tt") == "AM" || InputedHour.ToString("tt") == "Am" || InputedHour.ToString("tt") == "am")
                {
                    InputedHour = InputedHour + 0;
                }
                else if (InputedHour.ToString("tt") == "PM" || InputedHour.ToString("tt") == "Pm" || InputedHour.ToString("tt") == "pm")
                {
                    InputedHour = InputedHour + 12;
                }
                int Secofhr = InputedHour * 60 * 60;
                int Inputedmin = Earthtime.Minute;
                int Secofmin = Inputedmin * 60;
                int Secofsec = Earthtime.Second;
                int TotalSec = Secofhr + Secofmin + Secofsec;
                //Console.WriteLine("Total seconds of enetered time are:" + TotalSec);
                double USFSec = TotalSec / 45;
                //Console.WriteLine(USFSec);
                double USFMin = USFSec / 60;
                //Console.WriteLine(USFMin);
                decimal USFMIN = Convert.ToDecimal(USFMin);
                decimal USFHour = decimal.Truncate(USFMIN);
                String HOUR = Convert.ToString(USFHour);
                Console.WriteLine("The hours of USF World ARE:" + USFHour);
                decimal USFMIN1 = USFMIN - Math.Truncate(USFMIN);
                //Console.WriteLine(USFMIN1);
                decimal USFMINS = USFMIN1 * 60;
                //Console.WriteLine(USFMINS);
                decimal USFMINSFINAL = decimal.Truncate(USFMINS);
                String MIN = Convert.ToString(USFMINSFINAL);
                Console.WriteLine(USFMINSFINAL);
                decimal USFSEC = USFMINS - Math.Truncate(USFMINS);
                //Console.WriteLine(USFSEC);
                decimal USFSEC1 = USFSEC * 45;
                //Console.WriteLine(USFSEC1);
                decimal USFSECFINAL = decimal.Truncate(USFSEC1);
                String SECONDS = Convert.ToString(USFSECFINAL);
                Console.WriteLine(USFSECFINAL);
                Console.WriteLine(HOUR + ':' + MIN + ':' + SECONDS);
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                int count = 0;

                for (int i = 1; i <= n3; i++)
                {

                    if (count == k)

                    {

                        count = 0;

                        Console.WriteLine();

                    }

                    if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)

                    {

                        Console.Write("USF ");

                    }

                    else if (i % 5 == 0 && i % 7 == 0)

                    {

                        Console.Write("SF ");

                    }

                    else if (i % 3 == 0 && i % 5 == 0)

                    {

                        Console.Write("US ");

                    }

                    else if (i % 3 == 0 && i % 7 == 0)

                    {

                        Console.Write("UF ");

                    }

                    else if (i % 7 == 0)

                    {

                        Console.Write("F ");

                    }

                    else if (i % 5 == 0)

                    {

                        Console.Write("S ");

                    }

                    else if (i % 3 == 0)

                    {

                        Console.Write("U ");

                    }

                    else

                    {

                        Console.Write(i + " ");

                    }

                    count = count + 1;

                }



            }
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }



        static bool IsPalindrome(string value)

        {

            int min = 0;

            int max = value.Length - 1;

            while (true)

            {

                if (min > max)

                {

                    return true;

                }

                char a = value[min];

                char b = value[max];

                if (char.ToLower(a) != char.ToLower(b))

                {

                    return false;

                }

                min++;

                max--;

            }

        }

        public static void PalindromePairs(string[] words)
        {
            try
            {
                int length = words.Length;


                for (int i = 0; i < length; i++)

                {

                    for (int j = 0; j < length; j++)

                    {

                        string combine = words[i] + words[j];

                        bool Palindrome = IsPalindrome(combine);

                        if (Palindrome == true)

                        {

                            Console.WriteLine("output array index - [{0},{1}]", i, j);

                            Console.WriteLine("\n");

                        }

                    }


                }
            }
            catch
            {

                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }


        public static void fun(int final)
        {
            if (final == 0)
            {
                return;
            }
            Console.WriteLine("1 ");
            Console.WriteLine((final - 1) % 4);
            fun(final - 4);
        }

        public static void Stones(int n4)
        {
            try
            {
                if (n4 % 4 == 0)
                {
                    Console.WriteLine("false");
                }
                else
                {
                    int mod = n4 % 4;
                    Console.WriteLine(mod);
                    n4 = n4 - mod;
                    fun(n4);
                }
                return;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }


    }
}

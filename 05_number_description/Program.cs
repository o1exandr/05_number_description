/*
 5. Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, 
 например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».
 */


using System;

namespace _05_number_description
{
    class Program
    {
        static void Description(int number)
        {
            Console.Write($"{number} - ");
            switch (number / 100)
            {
                case 1:
                    Console.Write("one hundred ");
                    break;
                case 2:
                    Console.Write("two hundreds ");
                    break;
                case 3:
                    Console.Write("three hundreds ");
                    break;
                case 4:
                    Console.Write("four hundreds ");
                    break;
                case 5:
                    Console.Write("five hundreds ");
                    break;
                case 6:
                    Console.Write("six hundreds ");
                    break;
                case 7:
                    Console.Write("seven hundreds ");
                    break;
                case 8:
                    Console.Write("eight hundreds ");
                    break;
                case 9:
                    Console.Write("nine hundreds ");
                    break;
                default:
                    break;

            }

            switch ((number / 10) % 10)
            {
                case 1:
                    switch (number % 10)
                    {
                        case 0:
                            Console.Write("ten ");
                            break;
                        case 1:
                            Console.Write("eleven ");
                            break;
                        case 2:
                            Console.Write("twelve ");
                            break;
                        case 3:
                            Console.Write("thirteen ");
                            break;
                        case 4:
                            Console.Write("fourteen ");
                            break;
                        case 5:
                            Console.Write("fifteen ");
                            break;
                        case 6:
                            Console.Write("sixteen ");
                            break;
                        case 7:
                            Console.Write("seventeen ");
                            break;
                        case 8:
                            Console.Write("eighteen ");
                            break;
                        case 9:
                            Console.Write("nineteen ");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
                default:
                    break;

            }

            if ((number / 10) % 10 != 1)
            switch (number % 10)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
                default:
                    break;
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Description(100);
            Description(128);
            Description(256);
            Description(512);
            Description(705);
            Description(814);
            Description(910);
        }
    }
}

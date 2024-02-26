using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_GaidukovAlexey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите градусы Цельсия: ");
            bool celsiusParced = double.TryParse(Console.ReadLine(), out double degreesCelsius);
            if (!celsiusParced)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены некорректные данные.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                BaseConverter converter = new BaseConverter();
                converter.Convert(degreesCelsius);
            }
            Console.ReadKey();
        }
    }

    class BaseConverter
    {
        public void Convert(double degreesCelsius)
        {

            switch (ConvertModChoose())
            {
                case "1":
                    ConvertToKelvin(degreesCelsius);
                break;

                case "2":
                    ConvertToFahrenheit(degreesCelsius);
                break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введена некорректная команда.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        string ConvertModChoose()
        {
            Console.WriteLine("Для конвертации градусов Цельсия в Кельвины нажмите [ 1 ]\nДля конвертации градусов Цельсия в Фаренгейты нажмите [ 2 ]");
            string converterMod = Console.ReadLine();
            return converterMod;
        }
        void ConvertToKelvin(double degreesCelsius)
        {
            double degreesKelvin = degreesCelsius + 273.15;
            Console.WriteLine($"Градусы Цельсия: {degreesCelsius} -> Градусы Кельвина: {degreesKelvin}.");
        }

        void ConvertToFahrenheit(double degreesCelsius)
        {
            double degreesFahrenheit = degreesCelsius*1.8 + 32;
            Console.WriteLine($"Градусы Цельсия: {degreesCelsius} -> Градусы Фаренгейта: {degreesFahrenheit}.");
        }
    }
}

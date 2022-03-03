using System;
using ClassLibrary;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Library SetArray = new Library();
            Book Book1 = new Book();
            Book1.nameBook = "Война и мир";
            Book1.nameLibrary = "Российская национальная библиотека";
            Book1.numberOfPages = 1225;
            SetArray.bookArray[0] = Book1;

            Book Book2 = new Book();
            Book2.nameBook = "Люди на болоте";
            Book2.nameLibrary = "Беларусская национальная библиотека";
            Book2.numberOfPages = 635;
            SetArray.bookArray[1] = Book2;

            Book Book3 = new Book();
            Book3.nameBook = "Преступление и наказание";
            Book3.nameLibrary = "Библиотека Российской академии наук";
            Book3.numberOfPages = 1521;
            SetArray.bookArray[2] = Book3;

            Book Book4 = new Book(); 
            Book4.nameBook = "Бесы";
            Book4.nameLibrary = "Библиотека Йельского университета";
            Book4.numberOfPages = 1436;
            SetArray.bookArray[3] = Book4;


            Console.Write("Выберите одну из 4х книг, введите номер: ");

            int number = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine(SetArray.InfoFromNumber(number));


            Console.Write("Введите имя книги: ");

            string name = Console.ReadLine();

            Console.WriteLine(SetArray.InfoAboutBook(name));

            Console.WriteLine(SetArray.bookArray.FatBook());

            /////// Сортировка ПУЗЫРЬКОМ/////////
            Console.WriteLine("Before Buble Sort");
            int[] ArrayForBuble = { 12, 56, 45, 75, 1, 25, 36, 25, 96, 78, 93, 85, 321, 659, 455 };
            foreach (var item in ArrayForBuble)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            ArrayForBuble.BubleSort();
            Console.WriteLine("After Sort");
            foreach (var item in ArrayForBuble)
            {
                Console.Write($"{item} ");
            }
            
         


        }
    }
}

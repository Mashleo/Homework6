using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class Library
    {
        Book[] BookArray = new Book[4];
        public Book[] bookArray
        {
            get {
                return BookArray;
            }
            set {
                BookArray = value;
            }
        }
         public string InfoFromNumber(int i)
        {
           var result = BookArray[i].nameBook;

            return result;           
        }
        public string InfoAboutBook(string k)
        { var result = string.Empty;
            for (int i = 0; i < BookArray.Length; i++)
            {
                if (BookArray[i].nameBook == k) {
                    result = $"Название: {BookArray[i].nameBook}, Где храниться: {BookArray[i].nameLibrary}, Страниц:{BookArray[i].numberOfPages}";
                    break;
                } else if ( i == BookArray.Length-1 && BookArray[i].nameBook != k) 
                {
                    result = " В нашей базе таких книг нет";
                }
            }
            return result;
        }
       

    }
    public static class ExtensionMethod 
    {
        public static string FatBook(this Book[] array) 
        {
            var result= string.Empty;
            var temp = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                
                if (array[temp].numberOfPages < array[i + 1].numberOfPages)
                {
                    temp = i + 1;
                }
                

            }
            result = $"Смамая толстая книга это -  {array[temp].nameBook}";
            return result;
        }

    }
    public static class Buble
    {
        public static int[] BubleSort(this int[] array) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] >array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                    }

                }

            }
            return array;
        }
    }
}

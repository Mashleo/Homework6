using System;

namespace ClassLibrary
{
    public class Book
    {
        string NameBook;
        public string nameBook 
        {
            get
            {
                return NameBook;
            }
            set
            {
                NameBook = value;
            }
                
        }

        string NameLibrary;
        public string nameLibrary
        {
            get
            {
                return NameLibrary;
            }
            set
            {
                NameLibrary = value;
            }

        }


        int NumberOfPages;
        public int numberOfPages
        {
            get
            {
                return NumberOfPages;
            }
            set
            {
                NumberOfPages = value;
            }

        }

       
        



    }
}

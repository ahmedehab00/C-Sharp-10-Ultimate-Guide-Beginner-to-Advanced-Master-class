using System;


namespace Assigenment_1_Library_
{
    interface ILonable
    {
        int Loanperiod { get; set; }
        string Borrower { get; set; }

        void Borrow();
        void Return();
       
    
    }
    interface Iprintable
    {
        void Print();
    }
    class Book : ILonable, Iprintable
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Ispan { get; set; }
        public int Loanperiod { get; set; } = 21;
        public string Borrower { get; set; }

        public void Borrow()

        {

            Console.WriteLine("For How Many Days you want to borrow this book?");

            int period = int.Parse(Console.ReadLine());

            if (period > 21)

            {

                Console.WriteLine("You can't borrow a book for more than 21 days");

            }

            else

            {

                Loanperiod = period;

                Console.WriteLine($"You have borrowed this book for {Loanperiod} days");

            }

        }
        public void Return()

        {

            Console.WriteLine("You have returned this book succesfully");

            Loanperiod = 0;

        }
        public void Print ()
        {
            Console.WriteLine(Author);
            Console.WriteLine(Title);
            Console.WriteLine(Ispan);
           

        }




    }

    class DVD : ILonable, Iprintable
    {
        public string Director { get; set; }
        public string Title { get; set; }
        public int LengthInMinutes { get; set; }
        public int Loanperiod { get; set; } = 7;
        public string Borrower { get; set; }

        public void Borrow()
        {
            Console.WriteLine("For How Many Days you want to borrow this book?");
            int peroid = int.Parse(Console.ReadLine()); 
            if(Loanperiod > 7)
            {
                Console.WriteLine("you can not borrow DVD for more than 7 days ");
            }
            else
            {
                Loanperiod= peroid;
                Console.WriteLine($"You have borrow this dvd for {Loanperiod} dayes");
            }


        }
        public void Return()
        {
            Console.WriteLine("you have returned this dvd succesfully");

            Loanperiod=0;
        }
        public void Print()
        {
            Console.WriteLine(Director);
            Console.WriteLine(Title);
            Console.WriteLine(LengthInMinutes);
        }



    }

    class CD : ILonable, Iprintable
    {
        public string Arrist { get; set; }
        public string Title { get; set; }
        public int NumberOftracks { get; set; }
        public string Borrower { get; set;}
        public int Loanperiod { get; set; } = 14;

        public void Borrow()
        {
            Console.WriteLine("For How Many Days you want to borrow this CD?");
            int peroid=int.Parse(Console.ReadLine());   
            if(Loanperiod > 14)
            {
                Console.WriteLine("You can not borrow this CD for more than 14 days");
            }
            else
            {
                Loanperiod = peroid;

                Console.WriteLine($"You have borrow this CD for {Loanperiod} dayes");
                
            }

        }
        public void Return()
        {
            Console.WriteLine("you have returned this dvd succesfully");

            Loanperiod = 0;
        }

        public void Print()
        {
            Console.WriteLine(Arrist);
            Console.WriteLine(Title);
            Console.WriteLine(NumberOftracks);
        }
    }
















    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();


            book.Author = "Ahmed Ehab";
            book.Title = "Opreating System";
            book.Ispan = "377892279230";
            book.Borrower = "mohamed salah";
            
            book.Print();
            Console.WriteLine("***********************************");

            DVD dvd = new DVD();

            
            dvd.Director = "Saed";
            dvd.Title = "The Shawshank Redemption";
            dvd.Borrower = "saad";

            dvd.Print();
            Console.WriteLine("***********************************");


            CD cd = new CD();


            cd.Arrist = "alaa";
            cd.Title = "Abbey Road";
            cd.Borrower = "Ahmed";
            
            cd.Print();

            Console.ReadKey();
        }
    }
}

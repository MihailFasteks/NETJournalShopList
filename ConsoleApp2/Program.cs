using System;
using System.Threading;
public class Journal
{
    private string title { get; set; }
    private string description { get; set; }
    private int year { get; set; }
    private string phoneNumber { get; set; }
    private string email { get; set; }
    private int empCount { get; set; }
    public Journal()
    {
        this.title = "";
        this.description = "";
        this.year = 0; 
        this.phoneNumber = "";
        this.email = ""; 
        this.empCount = 0;
    }
    public Journal(string tit, string desc, int y, string pn, string em, int ec)
    {
        this.title = tit;
        this.description = desc; 
        this.year = y;
        this.phoneNumber = pn; 
        this.email = em;
        this.empCount = ec;
    }
    public static Journal operator +(Journal op1, Journal op2)
    {
        Journal result = new()
        {
            empCount = op1.empCount + op2.empCount
        };
        return result;
    }
    public static Journal operator -(Journal op1, Journal op2)
    {
        Journal result = new()
        {
            empCount = op1.empCount - op2.empCount
        }; return result;
    }
    public static Journal operator -(Journal op1, int op2)
    {
        Journal result = new()
        {
            empCount = op1.empCount - op2
        }; return result;
    }    // Перегрузка бинарного оператора "+" для суммирования объекта и int-значения.
    public static Journal operator +(Journal opl, int op2)
    {
        Journal result = new()
        {
            empCount = opl.empCount + op2
        };
        return result;
    }
    // Перегрузка бинарного оператора "+" для варианта int-значение + объект".
    public static Journal operator +(int opl, Journal op2)
    {
        Journal result = new()
        {
            empCount = op2.empCount + opl
        };
        return result;
    }
    // Перегрузка оператора "<".
    public static bool operator <(Journal op1, Journal op2)
    {
        if (op1.empCount < op2.empCount)
            return true;
        else
            return false;
    }
    public static bool operator >(Journal op1, Journal op2)
    {
        if (op1.empCount > op2.empCount) return true;
        else return false;
    }
    public static bool operator ==(Journal op1, Journal op2)
    {
        if (op1.empCount == op2.empCount)
            return true;
        else
            return false;
    }
    public static bool operator !=(Journal op1, Journal op2)
    {
        if (op1.empCount != op2.empCount)
            return true;
        else
            return false;
    }
    public void displayData()
    {
        Console.WriteLine(this.title);
        Console.WriteLine(this.description);
        Console.WriteLine(this.year);
        Console.WriteLine(this.phoneNumber);
        Console.WriteLine(this.email); 
        Console.WriteLine(this.empCount);
    }
    public void inputData(string tit, string desc, int y, string pn, string em, int ec)
    {
        this.title = tit;
        this.description = desc;
        this.year = y;
        this.phoneNumber = pn;
        this.email = em;
        this.empCount = ec;
    }
}
public class Shop
{
    private string name { get; set; }
    private string adress { get; set; }
    private string description { get; set; }
    private string phoneNumber { get; set; }
    private string email { get; set; }
    private double storeArea { get; set; }

    public Shop()
    {
        this.name = "";
        this.description = "";
        this.adress = "";
        this.phoneNumber = "";
        this.email = "";
        this.storeArea = 0;
    }
    public Shop(string nm, string desc, string ad, string pn, string em, double sa)
    {
        this.name = nm;
        this.description = desc; 
        this.adress = ad;
        this.phoneNumber = pn; 
        this.email = em;
        this.storeArea = sa;
    }
    public static Shop operator +(Shop op1, Shop op2)
    {
        Shop result = new()
        {
            storeArea = op1.storeArea + op2.storeArea
        }; return result;
    }
    public static Shop operator -(Shop op1, Shop op2)
    {
        Shop result = new()
        {
            storeArea = op1.storeArea - op2.storeArea
        }; return result;
    }
    public static Shop operator -(Shop op1, int op2)
    {
        Shop result = new()
        {
            storeArea = op1.storeArea - op2
        }; return result;
    }    // Перегрузка бинарного оператора "+" для суммирования объекта и int-значения.
    public static Shop operator +(Shop opl, int op2)
    {
        Shop result = new()
        {
            storeArea = opl.storeArea + op2
        };
        return result;
    }
    // Перегрузка бинарного оператора "+" для варианта int-значение + объект".
    public static Shop operator +(int opl, Shop op2)
    {
        Shop result = new()
        {
            storeArea = op2.storeArea + opl
        };
        return result;
    }
    // Перегрузка оператора "<".
    public static bool operator <(Shop op1, Shop op2)
    {
        if (op1.storeArea < op2.storeArea)
            return true;
        else
            return false;
    }
    public static bool operator >(Shop op1, Shop op2)
    {
        if (op1.storeArea > op2.storeArea) return true;
        else return false;
    }
    public static bool operator ==(Shop op1, Shop op2)
    {
        if (op1.storeArea == op2.storeArea)
            return true;
        else
            return false;
    }
    public static bool operator !=(Shop op1, Shop op2)
    {
        if (op1.storeArea != op2.storeArea)
            return true;
        else
            return false;
    }
    public void displayData()
    {
        Console.WriteLine(this.name); 
        Console.WriteLine(this.description);
        Console.WriteLine(this.adress); 
        Console.WriteLine(this.phoneNumber);
        Console.WriteLine(this.email); 
        Console.WriteLine(this.storeArea);
    }
    public void inputData(string tit, string desc, string ad, string pn, string em, double sa)
    {
        this.name = tit;
        this.description = desc; 
        this.adress = ad;
        this.phoneNumber = pn;
        this.email = em;
        this.storeArea = sa;
    }
}
public class Book
{
    private string Name { get; set; }
    private string Author { get; set; }
    public Book()
    {
        this.Name = "";
        this.Author = "";
    }
    public Book(string n, string a)
    {
        this.Name = n;
        this.Author = a;
    }

    public override string ToString()
    {
        return $"{Name} by {Author}";
    }
    public static bool operator ==(Book a, Book b)
    {
        return a.Name==b.Name && a.Author==b.Author;
    }
    public static bool operator !=(Book a, Book b)
    {
        return a.Name != b.Name && a.Author != b.Author;
    }
}
public class BookList
{
    private Book[] books;
    private int count;

    public BookList(int size)
    {
        books = new Book[size];
        count = 0;
    }
    public int Count
    {
        get { return count; }
    }
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < count)
                return books[index].ToString();
            return "Wrong index";
        }
    }
    public void Add(Book book)
    {
        if (count == books.Length)
        {
            Book[] newBooks = new Book[books.Length + 1];
            for (int i = 0; i < books.Length; i++)
            {
                newBooks[i] = books[i];
            }
            books = newBooks;
        }
        books[count] = book;
        count++;
    }
    public bool Remove(Book book)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i] == book)
            {
                for (int j = i; j < count - 1; j++)
                {
                    books[j] = books[j + 1];
                }
                count--;

                if (count > 0 && count < books.Length-1)
                {
                    Book[] newBooks = new Book[books.Length - 1];
                    for (int k=0; k < count; k++)
                    {
                        newBooks[k] = books[k];
                    }
                    books = newBooks;
                }
                return true;
            }
        }
        return false;
    }
    public bool Contains(Book book)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i] == book)
            {
                return true;
            }
        }
        return false;
    }
    public void PrintList()
    {
        if (count == 0)
        {
            Console.WriteLine("List is empty");
        }
        else
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Journal j1 = new Journal("Vogue", "Fashion journal", 1995, "+380673456567", "vogue123@gmail.com", 123); j1.displayData();
        Journal j2 = new Journal("Zara", "Fashion journal", 2000, "+380673456567", "zara123@gmail.com", 173); j2.displayData();
        Journal j3 = j1 + j2;
        j3.displayData();
        Journal j4 = j2 - j1; j4.displayData();
        Journal j5 = j3 + 10;
        j5.displayData();
        Journal j6 = j3 - 10; j6.displayData();
        if (j1 > j2)
        {
            Console.WriteLine("Hello!");
        }
        else
        {
            Console.WriteLine("Bye!");
        }
        if (j3 < j4)
        {
            Console.WriteLine("Hello!");
        }
        else
        {
            Console.WriteLine("Bye!");
        }
        if (j4 == j5)
        {
            Console.WriteLine("Hello!");
        }
        if (j4 != j5)
        {
            Console.WriteLine("Bye!");
        }

        Journal j7 = new Journal();
        j7.inputData("1111", "11111", 1111, "+11111111", "111111@gmail.com", 17113);
        j7.displayData();

        Shop sh1= new Shop();
        j7.inputData("1111", "11111", 1111, "+11111111", "111111@gmail.com", 17113);

        BookList bookList = new BookList(1);

        bookList.Add(new Book("1111", "11111"));
        bookList.Add(new Book("1222", "22222"));

        bookList.PrintList();

        bookList.Remove(new Book("1111", "11111"));
        bookList.PrintList();



    }
}
using T2210A_CSharp.demo2;
using System.Collections.Generic;
using T2210A_CSharp.assignment1;
using T2210A_CSharp.demo3;
using T2210A_CSharp.assignment2;
using T2210A_CSharp.demo4;
using T2210A_CSharp.assignment3;

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount ba = new BankAccount(500000);
        ba.Deposit(200000);
        ba.Withdraw(150000);
    }

    public static void Main6(string[] args)
    {
        VoidStringDelegate vsd = new VoidStringDelegate(DemoDelegate.Goodbye);
        // DemoDelegate.Goodbye("Hello world");
        vsd("Hello world");

        VoidStringDelegate vsd1 = new VoidStringDelegate(new DemoDelegate().SayHello);
        vsd1("Hello world 1");

        var t2 = new DemoDelegate();
        t2.SayHello("Hello");
        DemoDelegate.Goodbye("Goodbye");

        VoidStringDelegate vsd2 = new VoidStringDelegate(new DemoDelegate().SayHello);
        vsd2 += DemoDelegate.Goodbye;
        vsd2 += DemoDelegate.Goodbye;

        vsd2("T2210A");

        DisplayMessage("Hello world 2", DemoDelegate.Goodbye);

        VoidStringDelegate vsd3 = delegate (string s)  // anonymous method
        {
            Console.WriteLine(s);
        };
        VoidStringDelegate vsd4 = s => Console.WriteLine(s); // lambda expression

        vsd3("ABC");
        vsd4("XYZ");
    }

    static void DisplayMessage(string message, VoidStringDelegate callback)
    {
        callback(message);
    }

    public static void Main5(string[] args)
    { 
        PhoneBook phoneBooks = new PhoneBook();

        phoneBooks.InsertPhone("Phu Tam", "0987654321");
        phoneBooks.InsertPhone("Tran Thuy", "123456789");
        phoneBooks.InsertPhone("John", "1234567890");
        phoneBooks.InsertPhone("Mary", "0987654321");
        phoneBooks.InsertPhone("John", "1111111111");
        phoneBooks.RemovePhone("Mary");
        phoneBooks.UpdatePhone("John", "2222222222");
        phoneBooks.SearchPhone("Phu Tam");
        phoneBooks.Sort();
    }

    public static void Main4(string[] args)
    {
        Teacher t = new Teacher();
        t.Tels.Add("0987654321");
        t.Tels.Add("123456789");
        Console.WriteLine(t.Tels[0]);

        t[0] = "0101010101"; // == t.Tels[0] = "0101010101"
        Console.WriteLine(t[0]);

        Console.WriteLine(t[1]);

    }

    public static void Main3(string[] args)
    {
        VietNamCustomer vn1 = new VietNamCustomer();
        vn1.CustomerID = 1;
        vn1.CustomerName = "Tam";
        //vn1.ExportDate = ;
        vn1.CustomerType = "Sinh Hoat";
        vn1.PowerConsumption = 66;
        double total1 = vn1.Total();

        Console.WriteLine(total1);

        ForeignerCustomer fc1 = new ForeignerCustomer();
        fc1.CustomerID = 1;
        fc1.CustomerName = "Tam";
        //fc1.ExportDate = ;
        fc1.CustomerCountry = "USA";
        fc1.PowerConsumption = 66;
        double total2 = fc1.Total();

        Console.WriteLine(total2);

        List<VietNamCustomer> ListVietNamCustomers = new List<VietNamCustomer>();
        ListVietNamCustomers.Add(vn1);

        List<ForeignerCustomer> ListForeignerCustomers = new List<ForeignerCustomer>();
        ListForeignerCustomers.Add(fc1);
    }
    public static void Main2(string[] args)
    {
        Student s = new Student();
        s.Name = "Tam";
        s.Eat();
        s.Eat("aaa");

        List<Student> listStudents = new List<Student>();
        listStudents.Add(s);
    }
    public static void Main1(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello world");
    }
}
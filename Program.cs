using T2210A_CSharp.demo2;
using System.Collections.Generic;
using T2210A_CSharp.assignment1;
using T2210A_CSharp.assignment2;
using T2210A_CSharp.demo3;
using T2210A_CSharp.demo4;
using T2210A_CSharp.assignment3;
using T2210A_CSharp.demo5;
using T2210A_CSharp.assignment4;

public class Program
{
    static void Main(string[] args)
    {
        StudentManagement sm = new StudentManagement();
        sm.Start();
    }

public static void Main9(string[] args)
    {
        DemoNumber dm = new DemoNumber() { x = 0, y = 0};
        //
        // Thread1
        new Thread(delegate ()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (dm)
                {
                    dm.ChangeData();
                    dm.PrintData();
                }
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }).Start();

        // Thread2
        new Thread(delegate ()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (dm)
                {
                    dm.ChangeData();
                    dm.PrintData();
                }
                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }).Start();
    }

    public static void Main10(string[] args)
    {
        Thread t = new Thread(RunThread);
        t.Start("Sub t");

        Thread t2 = new Thread(
            delegate ()
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("Sub t2 i = " + i);
                    try
                    {
                        Thread.Sleep(1000);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
            }
        );
        t2.IsBackground = true;
        t2.Start();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Main i = " + i);
            try
            {
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    private static void RunThread(object o)
    {
        string s = o as string;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(s + "= " + i);
            try
            {
                Thread.Sleep(1000);
            } catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }

    public static void Main8(string[] args)
    {
        try
        {
            int x = 10;
            int y = 0;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            if (y < 5)
            {
                throw new Exception("Phải chia 5 mới tiết kiệm");
            }
            int z = x / y;
            Console.WriteLine("z = " + z);
        }
        catch (ArithmeticException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(1);
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(2);
        }
        finally
        {

        }
    }

    public static void Main7(string[] args)
    {
        BankAccount PhuTam = new BankAccount();
        Console.WriteLine("Phu Tam's balance: " + PhuTam);
        PhuTam.Deposit(1000000000);
        PhuTam.Withdraw(150000000);

        BankAccount TranThuy = new BankAccount(500000000);
        Console.WriteLine("\nTran Thuy's balance: " + TranThuy);
        TranThuy.Deposit(2000000000);
        TranThuy.Withdraw(150000000);
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
        //T2210A_CSharp.assignment2.Student s = new T2210A_CSharp.assignment2.Student();
        //s.Name = "Tam";
        //s.Eat();
        //s.Eat("aaa");

        //List<T2210A_CSharp.assignment4.Student> listStudents = new List<T2210A_CSharp.assignment4.Student>();
        //listStudents.Add(s);
    }
    public static void Main1(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello world");
    }
}
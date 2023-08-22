using CSharpfundamentals;
using System.Collections;
using System.Diagnostics;

internal class Program : Program4
{
    String firstName;

    //If not constructor is declare it has the default constuctor.
    public Program(String firstName)
    {
        this.firstName = firstName;

    }
    public void getName()
    {
        Console.WriteLine("My name is " + this.firstName);
    }
    public void getData()
    {
        Console.WriteLine("I am inside the method");
    }
    private static void Main(string[] args)
    {
        
        Debug.WriteLine("Hola panitas!!");
        Console.WriteLine("Fifa is easy");

        int age = 26;
        Console.WriteLine("Age   : " + age);

        String name = "Jose";
        Console.WriteLine("Name : " +  name);
        Console.WriteLine($"His name is {name}");

        var year = DateTime.Now.Year;
        //Dynamic variables can change its typr.
        Console.WriteLine(year);

        Program p = new Program("Davidcito");
        p.getData();
        p.SetData();
        p.getName();
        String match = ("Jose");

        String[] a = {"Jose", "James", "Falcao", "David Ospina", "Cuadrado", "Yepes", "Jose" };
        for(int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
            if (a[i] == match)
            {
                Console.WriteLine("Match found");
            }
            else
            {
                Console.WriteLine("No matches found");
            }
        }
        //ArrayList
        //with sort you can sort them.
        ArrayList myArray = new ArrayList();
        myArray.Add("Eren Yeager");
        myArray.Add("Levi");
        myArray.Add("Armin Arlert");
        myArray.Add("Mikasa Ackerman");

        foreach(String item in myArray)
        {
            Console.WriteLine(item);

            Console.WriteLine(myArray.Contains("Levi"));
        }

    }
} 
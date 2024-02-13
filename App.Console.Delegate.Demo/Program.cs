internal class Program
{
    public delegate void SampleDelegate();
    public delegate void SampleDelegate2(string name);

    public delegate T Add<T>(T param1, T param2); // Generic delegate

    private static void Main(string[] args)
    {

        Add<int> sum = Sum; // Generic delegate
        Console.WriteLine(sum.Invoke(200, 200));

        Add<string> concat = Concat; // Generic delegate
        Console.WriteLine(concat("Aijaz" , "Ali"));

        //SampleDelegate2 del2 = A.MethodA;
        //InvokeDelegate(del2);

        //del2 = B.MethodB;
        //InvokeDelegate(del2);

        //del2 = (string name) => Console.WriteLine($"This is a lambda expression: {name}");
        //InvokeDelegate(del2);

        //SampleDelegate2 del2 = A.MethodA;
        //del2("inside MethodA");


        //del2 = B.MethodB;
        //del2("inside MethodB");


        //del2 = (string name) => Console.WriteLine($"This is a lambda expression: {name}");
        //del2("Anonymous func");


        //var sampleDelegate = new SampleDelegate(M1);

        //SampleDelegate sampleDelegate = M1;

        //sampleDelegate.Invoke();

        //SampleDelegate sampleDelegate = () => Console.WriteLine("Inside lambda anonymous method");

        //sampleDelegate();

    }


    static int Sum(int val1, int val2) => val1 + val2;
    static string Concat(string s1, string s2) => $"{s1} {s2} Abro";


    static void InvokeDelegate(SampleDelegate2 del2) // pass delegate as a function/method parameter.
    {
        del2("Inside InvokeDelegate()");
    }

    class A
    {
        public static void MethodA(string name)
        {
            Console.WriteLine($"This is MethodA: {name}");
        }
    }

    class B
    {
        public static void MethodB(string name)
        {
            Console.WriteLine($"This is MethodB: {name}");
        }
    }

    static void M1()
    {
        Console.WriteLine("Inside M1()");
    }

    static void M2()
    {
        Console.WriteLine("Inside M2()");
    }
}


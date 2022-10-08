namespace Second
{
    public class Program
    {
        static void Main(string[] args)
        {
            Barcelona bar = new Barcelona();
            ManchesterCity mc = new ManchesterCity();
            Juventus juv = new Juventus();
            A a = new A(bar, mc, juv);
            bar.WriteInfo();
        }

    }
}

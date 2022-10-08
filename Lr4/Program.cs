using System.Diagnostics;
namespace First
{
    public class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("раз два три");
            Write<string> first = new Write<string>();
            first.Show("test");
        }

    }
}
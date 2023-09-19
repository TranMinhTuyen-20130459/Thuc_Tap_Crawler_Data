using System.Text;
using Tuan_1.Test;

namespace Tuan_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Function_Tester.Download_And_Save_Web_CheckIp();
            Console.ReadKey();
        }
    }
}
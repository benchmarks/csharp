using BenchmarkDotNet.Running;
using System.Reflection;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            if (0 == args.Length)

                BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).RunAllJoined();
            else
                BenchmarkSwitcher.FromAssembly(typeof(Program).GetTypeInfo().Assembly).Run(args);
        }
    }
}

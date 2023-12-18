
namespace MyCompiler
{
    class Program
    {
        static void Main(string[] args)
        {

            var objects = new[] { "Pen", "Pencil", "Scale", "Box" };

            var store = from obj in objects select obj.Contains('a');
            Console.WriteLine(string.Join (",", store));

        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_test_app.test_folder
{
    internal class TestClass
    {
        public string test = "2";

        public void HelloWorld() => Console.WriteLine("HelloWorld!");
        public void HelloMoscow() => Console.WriteLine("HelloMoscow!");

        public void Thanksgiving(string give) { Console.WriteLine(give); }
        public void Thanksgiving(int give) { Console.WriteLine(give); }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_test_app.new_test_folder
{
    internal class NewTestClass
    {
        public string test = "2";

        public string ReturnHW() => "hello world";
        public string ReturnM() => "HelloMoscow!";

        public void Thanksgiving(string give) { Console.WriteLine(give); }
        public void Thanksgiving(int give) { Console.WriteLine(give); }
    }
}

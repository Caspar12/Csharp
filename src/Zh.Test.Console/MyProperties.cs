using System;
using System.Collections.Generic;
using System.Text;

namespace Zh.Test.Console
{
    public class MyProperties
    {
        public string s { get; set; }
        public Dictionary<string, object> configs { get; set; }


        public void Test(string a1, int b2) { }
        public void Test(int a1, string b2) { }
    }
}

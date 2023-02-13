using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Enhance
{
    [Binding]
    public class Test
    {
        private int a;
        private int b;

    
        internal int Add(int a, int b)
        {
            return a + b;
        }

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            a = p0;
        }

    }
}

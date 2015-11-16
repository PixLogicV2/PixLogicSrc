using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PixLogic.Test
{
    [TestFixture]
    public class ClassTest
    {

        [Test]
        public void quickTest()
        {
            int result = 2;
            result += 3;
            Assert.AreEqual(5, result);
        }
    }
}

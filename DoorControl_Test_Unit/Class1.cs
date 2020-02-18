using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoorControl_Test_Unit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void Test_OneEqualsOne_True()
        {
            Assert.That(0, Is.EqualTo(1));
        }
    }
}

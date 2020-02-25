using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DoorControl;
using NSubstitute;

namespace DoorControl_Test_Unit
{
    [TestFixture]
    public class DoorControlUnitTest
    {
        [SetUp]
        public void Setup()
        {
            DoorControl.DoorControl uut = new DoorControl.DoorControl();
            uut.UserValidation = Substitute.For<IUserValidation>();
            uut.Alarm = Substitute.For<IAlarm>();
            uut.Door = Substitute.For<IDoor>();
            uut.EntryNotification = Substitute.For<IEntryNotification>();
        }

        [Test]
        public void Test_OneEqualsOne_True()
        {
            
        }

        [Test]
        public void DoorOpen_DoorOpenedCalled_DoorCloseCalledinDoor


    }
}

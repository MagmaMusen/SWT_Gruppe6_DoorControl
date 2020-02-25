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

        private DoorControl.DoorControl uut;
        private IAlarm testAlarm;
        private IDoor testDoor;
        private IUserValidation testUserValidation;
        private IEntryNotification testEntryNotification;


        [SetUp]
        public void Setup()
        {
            uut = new DoorControl.DoorControl();

            //Test properties init
            testAlarm = Substitute.For<IAlarm>();
            testDoor = Substitute.For<IDoor>();
            testUserValidation = Substitute.For<IUserValidation>();
            testEntryNotification = Substitute.For<IEntryNotification>();

            //Property injection
            uut.Alarm = testAlarm;
            uut.Door = testDoor;
            uut.UserValidation = testUserValidation;
            uut.EntryNotification = testEntryNotification;
        }

        [Test]
        public void Test_OneEqualsOne_True()
        {
            
        }

        [Test]
        public void RequestEntry_InvalidID_NotifyEntryDeniedCalled()
        {

        }
    }
}

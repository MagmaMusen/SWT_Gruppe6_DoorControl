﻿using System;
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
        public void RequestEntry_InvalidID_NotifyEntryDeniedCalled()
        {
            string ID = "";
            testUserValidation.ValidateEntryRequest(ID).Returns(false);
            uut.RequestEntry(ID);
            testEntryNotification.Received(1).NotifyEntryDenied();
        }

        [Test]
        public void RequestEntry_ValidID_NotifyEntryGrantedCalled()
        {
            string ID = "";
            testUserValidation.ValidateEntryRequest(ID).Returns(true);
            uut.RequestEntry(ID);
            testEntryNotification.Received(1).NotifyEntryGranted();
        }

        [Test]
        public void RequestEntry_ValidID_OpenCalled()
        {
            string ID = "";
            testUserValidation.ValidateEntryRequest(ID).Returns(true);
            uut.RequestEntry(ID);
            testDoor.Received(1).Open();
        }


        [Test]
        public void DoorOpen_DoorOpenCalled_DoorCloseCalledInDoor()
        {
            uut.DoorOpen();
            testDoor.Received(1).Close();
        }

        [Test]
        public void DoorOpened_RaiseAlarmCalled()
        {
            uut.DoorOpened();
            testAlarm.Received(1).RaiseAlarm();
        }

        [Test]
        public void DoorOpened_DoorCloseCalled()
        {
            uut.DoorOpened();
            testDoor.Received(1).Close();
        }

        [Test]
        public void DoorClosed_()
        {
            uut.DoorClosed();
            Assert.That(true);
        }
    }
}

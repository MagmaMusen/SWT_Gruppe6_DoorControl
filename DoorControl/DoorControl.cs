using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl
{
    public class DoorControl
    {
        public DoorControl()
        {
            Alarm = null;
            Door = null;
            EntryNotification = null;
            UserValidation = null;
        }

        public void RequestEntry(string ID)
        {
            if (UserValidation.ValidateEntryRequest(ID) == true)
            {
                EntryNotification.NotifyEntryGranted();
                Door.Open();
            }
            else
                EntryNotification.NotifyEntryDenied();
        }

        public void DoorOpen()
        {
            Door.Close();
            Console.WriteLine("Door open - Wishing to close door");
        }

        public void DoorClosed()
        {
            Console.WriteLine("Door closed - Waiting for user");
        }

        public void DoorOpened()
        {
            Console.WriteLine("Door breached - Raise alarm and close door");
            Alarm.RaiseAlarm();
            Door.Close();
        }



        #region Properties
        public IAlarm Alarm
        { get; set; }

        public IDoor Door
        { get; set; }

        public IEntryNotification EntryNotification
        { get; set; }

        public IUserValidation UserValidation
        { get; set; }
        #endregion

    }
}

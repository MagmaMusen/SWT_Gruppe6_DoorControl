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

        }

        public void DoorOpen()
        {

        }

        public void DoorClosed()
        {

        }

        public void DoorOpened()
        {

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

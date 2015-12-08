using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning7_Alarmclock
{
    public class AlarmClock
    {
        int seconds, alarmSeconds;    //default 0
        bool alarmOn;                 //default false

        public void SetTime(int hours, int minutes)
        {
            seconds = (hours * 3600 + minutes * 60);
        }
        public int GetTime()
        {
            //throw new NotImplementedException();        //skriver såhär när vi vet att metoden inte är färdig. Tas bort sen
            return seconds; 
        }
        public void SetAlarm(int hours, int minutes)
        {
            alarmSeconds = (hours * 3600 + minutes * 60);
        }
        public void TurnAlarmOnOff(bool alarmOn)
        {
            this.alarmOn = alarmOn;
        }
    }
}

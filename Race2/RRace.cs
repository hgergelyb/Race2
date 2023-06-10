using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Race
{
 
    public class LapTime
    {
        private long LTime; // time in millisec for comparison
        public long lTime 
        { 
            get { return LTime; }
        } 

        private int iMin;
        private int iSec;
        private int iMillisec;

        public LapTime(int sec, int millisec)// Constructor 1
        {
            this.iSec = sec;
            this.iMillisec = millisec;
            this.iMin = 0;
            this.LTime = sec * 1000 + millisec;
        }

        public LapTime(int min, int sec, int millisec)  // Constructor 2
        {
            this.iSec = sec;
            this.iMillisec = millisec;
            this.iMin = min;

            this.LTime = min * 60000 + sec * 1000 + millisec;
        }
        public string LapTimeToString()
        { /// Time to string in 0:00:000 format
            return (iMin == 0 ? "" : iMin + ":") + FillUpZeros(Convert.ToString(iSec)) + ":" + FillUpZeros(Convert.ToString(iMillisec), 3);
        }
        public string FillUpZeros(string str, int z = 2) {
            switch(z)
            {
                case 2:
                    if(str.Length == 1 ) 
                        str = "0" + str;
                    break;
                case 3:
                    if (str.Length == 1)
                        str = "00" + str;
                    else if (str.Length == 2)
                        str = "0" + str;
                    break;
                default:
                    break;
            }
            return str;
        }
    }

    public class Laps
    {
        public int iUserId;
        public string sUserName;
        public int iLapNumber;
        public LapTime iLapTime;

        public Laps(int uid, string un, int lnum, LapTime lp)
        {
            this.iUserId = uid;
            this.sUserName = un;
            this.iLapNumber = lnum;
            this.iLapTime = lp;
        }
    }


    public class RRace
    {
        private string sName;
        private decimal dDistance;
        private decimal dCostPerPerson;
        private decimal dEstCostPerLap;
        private long lBestTime = 0;
        private string sBestUser;

        private List<Laps> lLaps;

        private int iUserCount = 0; // Counted in GetLapRecords

        public RRace(string name, decimal dist, decimal cpp, decimal ecpl)
        {
            sName = name;
            dDistance = dist;
            dCostPerPerson = cpp;
            dEstCostPerLap = ecpl;
            lLaps = new List<Laps>();

        }

        

        public void ModifyRace(string name, decimal dist, decimal cpp, decimal ecpl)
        {
            sName = name;
            dDistance = dist;
            dCostPerPerson = cpp;
            dEstCostPerLap = ecpl;
        }

        public void AddLaps(Laps l)
        {
            lLaps.Add(l);
        }

        public List<UsersBestLap> GetLapRecords()
        {
          //  List<UsersBestLap> ubl = new List<UsersBestLap>();
            UsersBestLaps ubls = new UsersBestLaps();

            foreach (Laps l in lLaps)
            {
                int userid = l.iUserId;
                int iId = -1;
                
                iId = ubls.GetUserId(userid);
                if (iId == -1) // no record
                {
                    ubls.addBestLap(new UsersBestLap(l.iUserId, l.sUserName, l.iLapTime.lTime));
                }
                else if (ubls.blaps[iId].lTime > l.iLapTime.lTime)
                {
                    ubls.ChangeTime(iId, l.iLapTime.lTime);
                    ubls.AddTimeToAvg(iId, l.iLapTime.lTime);

                }
                else
                {
                    ubls.AddTimeToAvg(iId, l.iLapTime.lTime);
                }
            }

            // The best lap time for each of the racers
 
            iUserCount = 0;
            foreach (UsersBestLap b in ubls.blaps)
            {
                b.lTAvg = b.lTSum / b.iLaps;
                b.sAvgTime = b.TimeToStr(b.lTAvg);
                b.sBestTime = b.TimeToStr(b.lTime);
                iUserCount++;
            }
 
            return ubls.blaps;
        }

        private int GetUsersInt()
        {// placeholder
            throw new NotImplementedException();
        }

        public long getBestLapTime()
        {
            return lBestTime;
        }
        public void setBestLapTime(long bestTime, string name) 
        {
            lBestTime = bestTime;
            sBestUser = name;
        }
        public string GetBestUser()
        {
            return sBestUser;
        }


        public decimal GetMoneyMade()
        {
            // How much money has been made (total of racers * cost per person)

            return Convert.ToDecimal(iUserCount) * dCostPerPerson;
        }

        public decimal GetPetrolCost()
        {
            // How much was the cost in petrol? (Estimated cost of petrol per lap * lap total)
            return dEstCostPerLap * lLaps.Count();
         }

        public decimal GetProfit()
        {
            // Did the business make any profit? (Cost per person * number of people – total cost of petrol)
            return GetMoneyMade() - GetPetrolCost();
        }   

        public string AllToString()
        { //for testing, bug hunting
            string sOut = "";
            sOut += sName + Environment.NewLine + Convert.ToString(dCostPerPerson) + Environment.NewLine + Convert.ToString(dEstCostPerLap)+ Environment.NewLine+ Environment.NewLine;

            foreach (Laps l in lLaps)
            {
                sOut += l.sUserName + " : " + l.iLapNumber + " : " + l.iLapTime.LapTimeToString();
                sOut += Environment.NewLine;

                sOut += Environment.NewLine;
            }
            //MessageBox.Show(sOut);
            return sOut;

        }

        public void SaveAllToFile()
        {
            string sFilename = "../"+sName+"_race.txt";
            string sOut = sName+ ";"+ Convert.ToString(dDistance) + ";" + Convert.ToString(dCostPerPerson) + ";" + Convert.ToString(dEstCostPerLap);

            using (StreamWriter writer = new StreamWriter(sFilename))
            {
                writer.WriteLine(sOut);

                foreach (Laps l in lLaps)
                {
                    //                sOut += l.sUserName + " : " + l.iLapNumber + " : " + Convert.ToString(l.iLapTime.lTime);
                    sOut = l.sUserName + ";" + l.iLapNumber + ";" + l.iLapTime.lTime;
                    writer.WriteLine(sOut);
                }
            }

        }
    }
}

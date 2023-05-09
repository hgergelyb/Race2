﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    public class UsersBestLap  // it needs to be a class to be able to be used in a DataBaseView
    { 
        public int iUserId { get; set; }
        public string sUserName { get; set; }
        public long lTime { get; set; } //best time in long
        public long lTSum { get; set; } // total time for average
        public int iLaps { get; set; }  
        public long lTAvg { get; set; } // lTAvg = lTSum / iLaps
        public string sBestTime { get; set; } // best time in string
        public string sAvgTime { get; set; } // Avg time in string

        public UsersBestLap(int uid, string uname, long time)
        {
            this.iUserId = uid;
            this.sUserName = uname;
            this.lTime = time;
            this.lTSum = time;
            this.iLaps = 1;
            this.lTAvg = 0;
        }
        public string FillUpZeros(string str, int z = 2)
        {
            switch (z)
            {
                case 2:
                    if (str.Length == 1)
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
        public string TimeToStr(long time)
        {
            long tmp = 0;
            long iMin = time / 60000;
            tmp = time % 60000;
            long iSec = tmp / 1000;
            tmp = tmp % 1000;
            long iMillisec = tmp;

            return (iMin == 0 ? "" : iMin + ":") + FillUpZeros(Convert.ToString(iSec)) + ":" + FillUpZeros(Convert.ToString(iMillisec), 3);

        }
    }

    public class UsersBestLaps // a List of class UsersBestLap 
    {                           // every user has a row
        public List<UsersBestLap> blaps = new List<UsersBestLap>();

        public void addBestLap(UsersBestLap ubl)
        {
            blaps.Add(ubl);
        }

        public int GetUserId(int userId) 
        {
            int i = 0;
            foreach (UsersBestLap a in blaps)
            {
                if (a.iUserId == userId)
                    return i;
                i++;
            }
            return -1;
        }

        public void ChangeTime(int id, long t)
        {
            UsersBestLap tmp;
            tmp = blaps[id];
            tmp.lTime = t;
            blaps[id] = tmp;
        }

        public void AddTimeToAvg(int id, long t)
        {
            UsersBestLap tmp;
            tmp = blaps[id];
            tmp.lTSum += t;
            tmp.iLaps++;
            blaps[id] = tmp;
        }
    }

}

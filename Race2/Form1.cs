using Race;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Race2
{
    public partial class Form1 : Form
    {

        public List<User> lUsers = new List<User>();
        private int index = 0; // for CheckedListBox to track the selected index
        RRace myRace;

        public Form1()
        {
            InitializeComponent();
            lUsers.Add(new User("User 1", 22));
            lUsers.Add(new User("User 2", 24));
            foreach (User user in lUsers)
            {
                listBox1.Items.Add(user.GetName() + " (" + user.GetAge() + ")");
                clbLapsUser.Items.Add(user.GetName() + " (" + user.GetAge() + ")");
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            int iTmp = Convert.ToInt32(tbxUserAge.Text);
            lUsers.Add(new User(tbxUserName.Text, iTmp));
            listBox1.Items.Add(tbxUserName.Text + " (" + tbxUserAge.Text + ")");
            clbLapsUser.Items.Add(tbxUserName.Text + " (" + tbxUserAge.Text + ")");
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            // Add new race
            //public Race(string name, int dist, int cpp, int ecpl)

            myRace = new RRace(tbxRaceName.Text, numRaceDistance.Value, numCostPerPerson.Value, numEstCostPerLaps.Value);
            lblRaceName.Text = tbxRaceName.Text;
            //pnlLaps.Visible = true;
            pnlLaps.Enabled = true;
            //    pnlRaceBasic.Enabled = false; //probably it is not necessary
            numLapNumber.Maximum = numRaceDistance.Value;
            //MessageBox.Show(Convert.ToString(numCostPerPerson.Value));
       //  ??? sajat maga   button1.Visible = false;
       //   ??? modositas?  button3.Visible = true;

        }

        private void btnAddLap_Click(object sender, EventArgs e)
        {
            // Add new lap
            LapTime myLapTime;

            if (numLapTimeMin.Value > 0)
            {
                myLapTime = new LapTime(Convert.ToInt16(numLapTimeMin.Value), Convert.ToInt16(numLapTimeSec.Value), Convert.ToInt16(numLapTimeMilli.Value));
            }
            else
            {
                myLapTime = new LapTime(Convert.ToInt16(numLapTimeSec.Value), Convert.ToInt16(numLapTimeMilli.Value));
            }

            Laps myLap = new Laps(index, (string)clbLapsUser.Items[index], Convert.ToInt16(numLapNumber.Value), myLapTime);
            myRace.AddLaps(myLap);
            textBox1.AppendText(myLap.iLapNumber + "   " + myLap.iLapTime.LapTimeToString() + "   " + myLap.sUserName + Environment.NewLine);

            /*
                        //textBox1.Text = myRace.AllToString();
                        textBox1.AppendText(myRace.AllToString());
                        textBox1.AppendText(Environment.NewLine);


                        sOut += myLap.sUserName + " : " + myLap.iLapNumber + " : " + myLap.iLapTime.LapTimeToString();
                        sOut += Environment.NewLine;

                        sOut += Environment.NewLine;
            */

            /****** Best Lap Time / User *******/
            long lRaceBestLapTime = myRace.getBestLapTime();

            if (lRaceBestLapTime == 0)
            {
                myRace.setBestLapTime(myLapTime.lTime, myLap.sUserName);
                lblBestLap.Text = myLapTime.LapTimeToString() + "   " + myLap.sUserName;
            }
            else if (lRaceBestLapTime > myLapTime.lTime)
            {
                myRace.setBestLapTime(myLapTime.lTime, myLap.sUserName);
                lblBestLap.Text = myLapTime.LapTimeToString() + "   " + myLap.sUserName;

                // make a note about the new record
            }




            //           MessageBox.Show("Name: "+(string)clbLapsUser.Items[clbLapsUser.SelectedIndex]);

        }

        private void clbLapsUser_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (index == -1)
                return;
            else if (index == e.Index)
                e.NewValue = CheckState.Checked;
            else
            {
                var oldIndex = index;
                index = -1;
                clbLapsUser.SetItemChecked(oldIndex, false);
                index = e.Index;
            }

        }

        private void btnSummarise_Click(object sender, EventArgs e)
        {
            pnlSum.Enabled = true;
            //   pnlLaps.Enabled = false; // probably it is not necessary

        }

        private void btnSummarise2_Click(object sender, EventArgs e)
        {
            //textBox1.AppendText(myLap.iLapNumber + "   " + myLap.iLapTime.LapTimeToString() + "   " + myLap.sUserName + Environment.NewLine);
            //           tbxBestTimes.Clear();
            //    tbxBestTimes.AppendText(myRace.GetLapRecords());

            List<UsersBestLap> tmpBestLaps = new List<UsersBestLap>();
            /*
            tmpBestLaps.Add(new UsersBestLap(0, "FFFFFFFF", 123456));
            tmpBestLaps.Add(new UsersBestLap(1, "gsdf gsdfgsd", 123456));
            tmpBestLaps.Add(new UsersBestLap(2, "ASDF", 123456));
            tmpBestLaps.Add(new UsersBestLap(3, "poiuytre", 123456));

            //    

            foreach (UsersBestLap usp in tmpBestLaps)
            {
                MessageBox.Show(usp.sUserName);
            }
            */
            //   tmpBestLaps.Add()
            tmpBestLaps = myRace.GetLapRecords();
            dgvBestLaps.DataSource = tmpBestLaps;
            dgvBestLaps.Columns["iUserId"].Visible = false;

            /*
               public int iUserId { get; set; }
        public string sUserName { get; set; }
        public long lTime { get; set; }
        public long lTSum { get; set; }
        public int iLaps { get; set; }
        public long lTAvg { get; set; }
        public string sBestTime { get; set; }
        public string sAvgTime { get; set; }*/


            dgvBestLaps.Columns["lTAvg"].Visible = false;
            dgvBestLaps.Columns["lTSum"].Visible = false;
            dgvBestLaps.Columns["lTime"].Visible = false;

            dgvBestLaps.Columns["sBestTime"].HeaderText = "Best Time";
            dgvBestLaps.Columns["sAvgTime"].HeaderText = "Average Time";
            dgvBestLaps.Columns["sUserName"].HeaderText = "Racer";
            dgvBestLaps.Columns["iLaps"].HeaderText = "Laps";



            lblPetrolCost.Text = "Petrol cost: £" + Convert.ToString(myRace.GetPetrolCost());
            lblProfit.Text = "Profit: £" + Convert.ToString(myRace.GetProfit());
            lblMoneyMade.Text = "Money made: £" + Convert.ToString(myRace.GetMoneyMade());
            lblBestUser.Text = "The best lap time: " + myRace.GetBestUser();
            // lblBestLapTime.Text = myRace.getBestLapTime();



            //tbxBestTimes.AppendText(Convert.ToString(unum));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
/*
            string json = JsonConvert.SerializeObject(myRace.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"_"+ tbxRaceName.Text + ".txt", json);
*/
        }
    }
}

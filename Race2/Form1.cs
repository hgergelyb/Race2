using Race;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        const int MINUSERNAME = 3;

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
            if(tbxUserName.Text.Length < MINUSERNAME)
            {
                MessageBox.Show("User name must be at least "+ MINUSERNAME+" characters.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int iTmp = Convert.ToInt32(numUserAge.Value);
                lUsers.Add(new User(tbxUserName.Text, iTmp));
                listBox1.Items.Add(tbxUserName.Text + " (" + iTmp + ")");
                clbLapsUser.Items.Add(tbxUserName.Text + " (" + iTmp + ")");
            }
        }

        private void btnNewRace_Click(object sender, EventArgs e)
        {
            // Add new race
            if (tbxRaceName.Text.Length < MINUSERNAME)
            {
                MessageBox.Show("Race name cannot be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                myRace = new RRace(tbxRaceName.Text, numRaceDistance.Value, numCostPerPerson.Value, numEstCostPerLaps.Value);
                lblRaceName.Text = tbxRaceName.Text;
                //pnlLaps.Visible = true;
                pnlLaps.Enabled = true;
                //    pnlRaceBasic.Enabled = false; //probably it is not necessary
                numLapNumber.Maximum = numRaceDistance.Value;
                btnNewRace.Visible = false;
                btnModifyRace.Visible = true;
            }
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
            // Add the lap to the race
            myRace.AddLaps(myLap);

            // Show the lap in the list 
            // for delete laps in a future update the textbox must be swapped 
            textBox1.AppendText(myLap.iLapNumber + "   " + myLap.iLapTime.LapTimeToString() + "   " + myLap.sUserName + Environment.NewLine);

            /****** Best Lap Time / User *******/
            long lRaceBestLapTime = myRace.getBestLapTime();

            if (lRaceBestLapTime == 0)
            { // the first record
                myRace.setBestLapTime(myLapTime.lTime, myLap.sUserName);
                lblBestLap.Text = myLapTime.LapTimeToString() + "   " + myLap.sUserName;
            }
            else if (lRaceBestLapTime > myLapTime.lTime)
            {
                myRace.setBestLapTime(myLapTime.lTime, myLap.sUserName);
                lblBestLap.Text = myLapTime.LapTimeToString() + "   " + myLap.sUserName;

                // make a note about the new record
            }

        }

        private void clbLapsUser_ItemCheck(object sender, ItemCheckEventArgs e)
        {// checked list box
            // only one item can be selected
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
        {// button in the Laps panel
            //after we finish with laps it makes the Summarise panel visible and do the summarise
            pnlSum.Enabled = true;
            btnSummarise2_Click(sender, e);
        }

        private void btnSummarise2_Click(object sender, EventArgs e)
        { // 
            List<UsersBestLap> tmpBestLaps = new List<UsersBestLap>();

            tmpBestLaps = myRace.GetLapRecords();
            dgvBestLaps.DataSource = tmpBestLaps;
            dgvBestLaps.Columns["iUserId"].Visible = false;

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
            myRace.SaveAllToFile();
            MessageBox.Show("The data of this race saved into '" + tbxRaceName.Text + "_race.txt'");
        }

        private void btnModifyRace_Click(object sender, EventArgs e)
        {
            myRace.ModifyRace(tbxRaceName.Text, numRaceDistance.Value, numCostPerPerson.Value, numEstCostPerLaps.Value);
            lblRaceName.Text = tbxRaceName.Text;
            numLapNumber.Maximum = numRaceDistance.Value;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
/*            myRace = null;
            tbxRaceName.Text = "";
            textBox1.Text = "";
            pnlLaps.Enabled = false;
            pnlSum.Enabled = false;
            btnNewRace.Visible = true;
            btnModifyRace.Visible = false;
*/
        }

        private void tbxUserName_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;
            txt.Text = txt.Text.Trim();
            txt.Text = Regex.Replace(txt.Text, @"\s+", " ");

            //  txt.SelectionStart = txt.Text.Length;
            //  txt.SelectionLength = 0;
        }
    }
}

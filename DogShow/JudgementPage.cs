using PetaPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogShow
{
    public partial class JudgementPage : Form
    {
        //List<DogBreed> nameList = new List<DogBreed>();
        //PullSqlData pull = new PullSqlData();
        //int dogID;
        public JudgementPage()
        {
            InitializeComponent();
        }
        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);
        //    nameList = pull.GetDogBreed();
        //    for (int i = 0; i < nameList.Count; i++)
        //    {
        //        DogBreed dog = nameList.ElementAt(i);
        //        competitorsBox.Items.Add(dog.DogName);

        //    }

        //}

        private void selectDogBtn_Click(object sender, EventArgs e)
        {
            //string dogName = competitorsBox.Text;
            //dogID = pull.DogIdNum(dogName);
            //sizePointTxt.Enabled = true;
            //eyePointTxt.Enabled = true;
            //furColorPointTxt.Enabled = true;
            //furLengthPointTxt.Enabled = true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //int sizeScore = Int32.Parse(sizePointTxt.Text);
            //int eyeScore = Int32.Parse(eyePointTxt.Text);
            //int furColorScore = Int32.Parse(furColorPointTxt.Text);
            //int furLengthScore = Int32.Parse(furLengthPointTxt.Text);
            //int totalScore = (furLengthScore + furColorScore + eyeScore + sizeScore);
            //totalPointsLbl.Text = totalScore.ToString();
            //int eventId = Int32.Parse(eventNumTxt.Text);
            //pull.InsertScores(totalScore, sizeScore, eyeScore, furColorScore, furLengthScore, dogID);
            //int locationID = Int32.Parse(locationIdTxt.Text);
            //pull.InsertEvent(locationID, eventId);

        }
    }

}

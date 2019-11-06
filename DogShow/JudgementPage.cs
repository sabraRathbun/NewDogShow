using Common_DogShow;
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
using Service_DogShow;

namespace DogShow
{
    public partial class JudgementPage : Form
    {
        List<DogBreed> nameList = new List<DogBreed>();
        List<string> lastNames = new List<string>();
        int breedIndex;
        Judgement judge = new Judgement();
        int dogID;
        int eventNum;
        int locationID;
        public JudgementPage()
        {
            InitializeComponent();
            foreach (string className in Classes.GetNames(typeof(Classes)))
            {
                classGroupComboBox.Items.Add(className);
            }
        }

        private void selectDogBtn_Click(object sender, EventArgs e)
        {
            eventNum = Int32.Parse(eventNumTxt.Text);
            locationID = Int32.Parse(locationIdTxt.Text);
            string dogIdOne = dogView.SelectedItems[0].Tag.ToString();
            dogID = Int32.Parse(dogIdOne);
            sizePointTxt.Enabled = true;
            eyePointTxt.Enabled = true;
            furColorPointTxt.Enabled = true;
            furLengthPointTxt.Enabled = true;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int sizeScore = Int32.Parse(sizePointTxt.Text);
            int eyeScore = Int32.Parse(eyePointTxt.Text);
            int furColorScore = Int32.Parse(furColorPointTxt.Text);
            int furLengthScore = Int32.Parse(furLengthPointTxt.Text);
            int totalScore = (furLengthScore + furColorScore + eyeScore + sizeScore);
            totalPointsLbl.Text = totalScore.ToString();
            int eventNum = Int32.Parse(eventNumTxt.Text);
            judge.InsertScores(totalScore, sizeScore, eyeScore, furColorScore, furLengthScore, dogID);
            int locationID = Int32.Parse(locationIdTxt.Text);
            judge.InsertEvent(locationID, eventNum, dogID);

        }

        private void breedGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            breedIndex = classGroupComboBox.SelectedIndex;
            judge.SelectDoggo(dogView, breedIndex);
        }
    }

}

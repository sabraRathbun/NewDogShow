using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_DogShow;
using Service_DogShow;

namespace DogShow
{
    public partial class CompetitionForm : Form
    {
        Competition comp = new Competition();
        List<string> dogList = new List<string>();
        List<string> selectedDoggos = new List<string>();
        string[] selectedDogs = new string[3];
        string dogOne;
        string dogTwo;
        string dogThree;
        //string first;
        //string second;
        //string third;
        //string dogOneLastName;
        //string dogTwoLastName;
        //string dogThreeLastName;
        int dogOneID;
        int dogTwoID;
        int dogThreeID;
        int scoreIDOne;
        int scoreIDTwo;
        int scoreIDThree;
        int breedIndex;


        public CompetitionForm()
        {

            InitializeComponent();
            foreach (string className in Classes.GetNames(typeof(Classes)))
            {
                classGroupComboBox.Items.Add(className);
            }  
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            comp.GetSelectedDoggos(dogListView);
            //dogOne = Dog1Box.SelectedItem.ToString();
            //dogTwo = dog2Box.SelectedItem.ToString();
            //dogThree = dog3Box.SelectedItem.ToString();
            //dogOneLastName = dog1LastName.SelectedItem.ToString();
            //dogTwoLastName = dog2LastName.SelectedItem.ToString();
            //dogThreeLastName = dog3LastName.SelectedItem.ToString();
            //dogOneID = comp.GetDogID(dogOne, dogOneLastName);
            //dogTwoID = comp.GetDogID(dogTwo, dogTwoLastName);
            //dogThreeID = comp.GetDogID(dogThree, dogThreeLastName);
            //scoreIDOne = comp.GetScoreID(dogOneID);
            //scoreIDTwo = comp.GetScoreID(dogTwoID);
            //scoreIDThree = comp.GetScoreID(dogThreeID);
            //dogList = comp.DogPlacements(breedGroupBox, scoreIDOne, scoreIDTwo, scoreIDThree);
            //first = dogList.ElementAt(0);
            //second = dogList.ElementAt(1);
            //third = dogList.ElementAt(2);
            //firstLbl.Text = first;
            //secondLbl.Text = second;
            //thirdLbl.Text = third;
        }

        private void SaveComp_Click(object sender, EventArgs e)
        {
            comp.OrderDogIds(breedIndex, dogOneID, dogTwoID, dogThreeID);
            comp.InsertDoggo();
        }

        private void classGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            breedIndex = classGroupComboBox.SelectedIndex;
            comp.SelectDoggo(dogListView, breedIndex);

        }

        private void selectDogTwoBtn_Click(object sender, EventArgs e)
        {

        }

        private void selectDogThreeBtn_Click(object sender, EventArgs e)
        {

        }

        private void dogListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

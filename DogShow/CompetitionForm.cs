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
        string dogOne;
        string dogTwo;
        string dogThree;
        string first;
        string second;
        string third;
        

        public CompetitionForm()
        {

            InitializeComponent();
            foreach (string className in Classes.GetNames(typeof(Classes)))
            {
                breedGroupBox.Items.Add(className);
            }  
        }

        private void selectBreedBtn_Click(object sender, EventArgs e)
        {
            int breedIndex = breedGroupBox.SelectedIndex;
            if (breedIndex < 0)
            {
                return;
            }
            comp.SelectDoggo(Dog1Box, dog2Box, dog3Box, breedIndex);
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            dogOne = Dog1Box.SelectedItem.ToString();
            dogTwo = dog2Box.SelectedItem.ToString();
            dogThree = dog3Box.SelectedItem.ToString();
            dogList = comp.DogPlacements(breedGroupBox, dogOne, dogTwo, dogThree);
            first = dogList.ElementAt(0);
            second = dogList.ElementAt(1);
            third = dogList.ElementAt(2);
            firstLbl.Text = first;
            secondLbl.Text = second;
            thirdLbl.Text = third;

        }

        private void saveComp_Click(object sender, EventArgs e)
        {
            comp.GetEventID(first, second, third);
            comp.GetDogID(first, second, third);
            comp.GetScoreID(first, second, third);
            comp.InsertDoggo();
        }
    }
}

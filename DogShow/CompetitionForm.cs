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
    public partial class CompetitionForm : Form
    {
        List<string> dogList = new List<string>();
        PullSqlData pull = new PullSqlData();
        string dogOne;
        string dogTwo;
        string dogThree;
        string first;
        string second;
        string third;
        int competitionIDOne;
        int competitionIDTwo;
        int competitionIDThree;
        int eventIDOne;
        int eventIDTwo;
        int eventIDThree;
        int DogIDOne;
        int DogIDTwo;
        int DogIDThree;
        int scoreIDOne;
        int scoreIDTwo;
        int scoreIDThree;

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

            var dogs = pull.RegisteredDogsInClass(breedIndex);
            Dog1Box.Items.Clear();
            foreach (string dog in dogs)
            {
                Dog1Box.Items.Add(dog);
                dog2Box.Items.Add(dog);
                dog3Box.Items.Add(dog);
            }  
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            dogOne = Dog1Box.SelectedItem.ToString();
            dogTwo = dog2Box.SelectedItem.ToString();
            dogThree = dog3Box.SelectedItem.ToString();
            DogPlacements();
            firstLbl.Text = first;
            secondLbl.Text = second;
            thirdLbl.Text = third;
            firstLbl.Visible = true;
            secondLbl.Visible = true;
            thirdLbl.Visible = true;


        }
        private void DogPlacements()
        {
            dogList = pull.OrderDogs(breedGroupBox.SelectedIndex, dogTwo, dogThree, dogOne);
            first = dogList.ElementAt(0);
            second = dogList.ElementAt(1);
            third = dogList.ElementAt(2);
        }

        private void saveComp_Click(object sender, EventArgs e)
        {
            GetEventID();
            GetDogID();
            GetScoreID();
            pull.InsertCompetition(eventIDOne, 1, DogIDOne, scoreIDOne);
            pull.InsertCompetition(eventIDTwo, 2, DogIDTwo, scoreIDTwo);
            pull.InsertCompetition(eventIDThree, 3, DogIDThree, scoreIDThree);
        }
        private void GetEventID()
        {
            eventIDOne = pull.EventID(first);
            eventIDTwo = pull.EventID(second);
            eventIDThree = pull.EventID(third);
        }
        private void GetDogID()
        {
            DogIDOne = pull.DogIdNum(first);
            DogIDTwo = pull.DogIdNum(second);
            DogIDThree = pull.DogIdNum(third);
        }
        private void GetScoreID()
        {
            scoreIDOne = pull.ScoreID(first);
            scoreIDTwo = pull.ScoreID(second);
            scoreIDThree = pull.ScoreID(third);
        }
    }
    
}

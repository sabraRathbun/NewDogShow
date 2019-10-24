using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess_DogShow;

namespace Service_DogShow
{
    public class Competition 
    {
        List<string> dogList = new List<string>();
        PullSqlData pull = new PullSqlData();
        int eventIDOne;
        int eventIDTwo;
        int eventIDThree;
        int DogIDOne;
        int DogIDTwo;
        int DogIDThree;
        int scoreIDOne;
        int scoreIDTwo;
        int scoreIDThree;


        public void SelectDoggo(ListBox one, ListBox two, ListBox three, int breedIndex)
        {
            var dogs = pull.RegisteredDogsInClass(breedIndex);
            one.Items.Clear();
            foreach (string dog in dogs)
            {
                one.Items.Add(dog);
                two.Items.Add(dog);
                three.Items.Add(dog);
            }
        }

        public List<string> DogPlacements(ListBox breedGroup, string dogOne, string dogTwo, string dogThree)
        {
            dogList = pull.OrderDogs(breedGroup.SelectedIndex, dogTwo, dogThree, dogOne);
            
            return dogList;
        }
        public void GetEventID(string first, string second, string third)
        {
            eventIDOne = pull.EventID(first);
            eventIDTwo = pull.EventID(second);
            eventIDThree = pull.EventID(third);
        }
        public void GetDogID(string first, string second, string third)
        {
            DogIDOne = pull.DogIdNum(first);
            DogIDTwo = pull.DogIdNum(second);
            DogIDThree = pull.DogIdNum(third);
        }
        public void GetScoreID(string first, string second, string third)
        {
            scoreIDOne = pull.ScoreID(first);
            scoreIDTwo = pull.ScoreID(second);
            scoreIDThree = pull.ScoreID(third);
        }
        public void InsertDoggo()
        {
            pull.InsertCompetition(eventIDOne, 1, DogIDOne, scoreIDOne);
            pull.InsertCompetition(eventIDTwo, 2, DogIDTwo, scoreIDTwo);
            pull.InsertCompetition(eventIDThree, 3, DogIDThree, scoreIDThree);
        }

    }
}


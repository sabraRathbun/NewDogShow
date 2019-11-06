using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_DogShow;
using DataAccess_DogShow;

namespace Service_DogShow
{
    public class Competition 
    {
        List<Dog> dogList = new List<Dog>();
        PullSqlData pull = new PullSqlData();
        List<int> orderedDogs = new List<int>();
        List<string> orderedDogsNames = new List<string>();
        int eventIDOne;
        int eventIDTwo;
        int eventIDThree;
        int tempDogOneID;
        int tempDogTwoID;
        int tempDogThreeID;
        int DogIDOne;
        int DogIDTwo;
        int DogIDThree;
        int scoreIDOne;
        int scoreIDTwo;
        int scoreIDThree;


        public void SelectDoggo(ListView dogView, int breedIndex, int eventNum, int locationID)
        {
            dogList.Clear();
            dogView.Items.Clear();
            var dogs = pull.GetDogsForCompetition(breedIndex, eventNum, locationID);
            dogList = dogs;
            for (int i = 0; i < dogList.Count; i++)
            {
                Dog dog = dogList.ElementAt(i);
                ListViewItem item = new ListViewItem();
                item.Text = dog.DogName;
                item.SubItems.Add(dog.DogLastName);
                item.SubItems.Add(dog.description);
                item.Tag = dog.DogId;
                dogView.Items.Add(item);   
            }
           
        }
        public List<string> GetSelectedDoggos(ListView dogView, int breedIndex, int eventNum, int locationId)
        {
            string dogOneID = dogView.SelectedItems[0].Tag.ToString();
            string dogTwoID = dogView.SelectedItems[1].Tag.ToString();
            string dogThreeID = dogView.SelectedItems[2].Tag.ToString();
            tempDogOneID = Convert.ToInt32(dogOneID);
            tempDogTwoID = Convert.ToInt32(dogTwoID);
            tempDogThreeID = Convert.ToInt32(dogThreeID);
            OrderDogIds(breedIndex, tempDogOneID, tempDogTwoID, tempDogThreeID, eventNum, locationId);
            return orderedDogsNames;
            
            
        }
        public List<string> DogPlacements(int breedIndex, int scoreIDOne, int scoreIDTwo, int scoreIDThree)
        {
            orderedDogsNames = pull.OrderDogs(breedIndex, scoreIDOne, scoreIDTwo, scoreIDThree);
            return orderedDogsNames;
        }

        public void GetEventID(int first, int second, int third)
        {
            eventIDOne = pull.EventID(first);
            eventIDTwo = pull.EventID(second);
            eventIDThree = pull.EventID(third);
        }
        public int GetScoreID(int dogId)
        {
            int scoreID = pull.ScoreID(dogId);
            return scoreID;

        }
        public void OrderDogIds(int classId, int idOne, int idTwo, int idThree, int eventNum, int locationId)
        {
            orderedDogs = pull.OrderDogIds(classId, idOne, idTwo, idThree, eventNum, locationId);
            DogIDOne = orderedDogs.ElementAt(0);
            DogIDTwo = orderedDogs.ElementAt(1);
            DogIDThree = orderedDogs.ElementAt(2);
            GetEventID(DogIDOne, DogIDTwo, DogIDThree);
            scoreIDOne = GetScoreID(DogIDOne);
            scoreIDTwo = GetScoreID(DogIDTwo);
            scoreIDThree = GetScoreID(DogIDThree);
            orderedDogsNames = DogPlacements(classId, scoreIDOne, scoreIDTwo, scoreIDThree);
        }

        public void InsertDoggo()
        {
            pull.InsertCompetition(eventIDOne, 1, DogIDOne, scoreIDOne);
            pull.InsertCompetition(eventIDTwo, 2, DogIDTwo, scoreIDTwo);
            pull.InsertCompetition(eventIDThree, 3, DogIDThree, scoreIDThree);
        }
    }
}


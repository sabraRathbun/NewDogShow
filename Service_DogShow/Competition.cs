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
        List<string> dummy = new List<string>();
        int eventIDOne;
        int eventIDTwo;
        int eventIDThree;
        int DogIDOne;
        int DogIDTwo;
        int DogIDThree;
        int scoreIDOne;
        int scoreIDTwo;
        int scoreIDThree;

        public List<Dog> GetDoggos(int breedIndex)
        {
            var dogs = pull.GetDogsForCompetition(breedIndex);
            dogList = dogs;
            return dogList;
        }
        public void SelectDoggo(ListView dogView, int breedIndex)
        {
            dogList.Clear();
            dogView.Items.Clear();
            var dogs = pull.GetDogsForCompetition(breedIndex);
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
        public void GetSelectedDoggos(ListView dogView)
        {
            string dogOne = dogView.SelectedItems[0].Text;
            string dogTwo = dogView.SelectedItems[1].Text;
            string dogThree = dogView.SelectedItems[2].Text;
        }
        public List<string> DogPlacements(ListBox breedGroup, int scoreIDOne, int scoreIDTwo, int scoreIDThree)
        {
            dummy = pull.OrderDogs(breedGroup.SelectedIndex, scoreIDOne, scoreIDTwo, scoreIDThree);
            return dummy;
        }

        public void GetEventID(int first, int second, int third)
        {
            eventIDOne = pull.EventID(first);
            eventIDTwo = pull.EventID(second);
            eventIDThree = pull.EventID(third);
        }
        public int GetDogID(string first, string firstLastName)
        {
           int DogID = pull.DogId(first, firstLastName);
            return DogID;
           
        }
        public int GetScoreID(int dogId)
        {
            int scoreID = pull.ScoreID(dogId);
            return scoreID;

        }
        public void OrderDogIds(int classId, int idOne, int idTwo, int idThree)
        {
            //dogIds = pull.OrderDogIds(classId, idOne, idTwo, idThree);
            //DogIDOne = dogIds.ElementAt(0);
            //DogIDTwo = dogIds.ElementAt(1);
            //DogIDThree = dogIds.ElementAt(2);
            //GetEventID(DogIDOne, DogIDTwo, DogIDThree);
            //scoreIDOne = GetScoreID(DogIDOne);
            //scoreIDTwo = GetScoreID(DogIDTwo);
            //scoreIDThree = GetScoreID(DogIDThree);
        }

        public void InsertDoggo()
        {
            pull.InsertCompetition(eventIDOne, 1, DogIDOne, scoreIDOne);
            pull.InsertCompetition(eventIDTwo, 2, DogIDTwo, scoreIDTwo);
            pull.InsertCompetition(eventIDThree, 3, DogIDThree, scoreIDThree);
        }
    }
}


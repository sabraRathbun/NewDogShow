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
        List<string> dogLastNames = new List<string>();
        List<int> dogIds = new List<int>();
        PullSqlData pull = new PullSqlData();
        string[] dogLast = new string[10000];
        int eventIDOne;
        int eventIDTwo;
        int eventIDThree;
        int DogIDOne;
        int DogIDTwo;
        int DogIDThree;
        int scoreIDOne;
        int scoreIDTwo;
        int scoreIDThree;


        public void SelectDoggo(ListView dogView, ColumnHeader lastNameColumn, int breedIndex)
        {
            var dogs = pull.RegisteredDogsInClass(breedIndex);
            dogView.Items.Clear();
            foreach (string dog in dogs)
            {
                dogList.Add(dog);
                dogView.Items.Add(dog);

            }
    
            var lastNames = pull.RegisteredDogsLastName(breedIndex);

            foreach (string last in lastNames)
            {
                dogLastNames.Add(last);
            }
            
        }

        public List<string> DogPlacements(ListBox breedGroup, int scoreIDOne, int scoreIDTwo, int scoreIDThree)
        {
            dogList = pull.OrderDogs(breedGroup.SelectedIndex, scoreIDOne, scoreIDTwo, scoreIDThree); 
            return dogList;
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
            dogIds = pull.OrderDogIds(classId, idOne, idTwo, idThree);
            DogIDOne = dogIds.ElementAt(0);
            DogIDTwo = dogIds.ElementAt(1);
            DogIDThree = dogIds.ElementAt(2);
            GetEventID(DogIDOne, DogIDTwo, DogIDThree);
            scoreIDOne = GetScoreID(DogIDOne);
            scoreIDTwo = GetScoreID(DogIDTwo);
            scoreIDThree = GetScoreID(DogIDThree);
        }

        public void InsertDoggo()
        {
            pull.InsertCompetition(eventIDOne, 1, DogIDOne, scoreIDOne);
            pull.InsertCompetition(eventIDTwo, 2, DogIDTwo, scoreIDTwo);
            pull.InsertCompetition(eventIDThree, 3, DogIDThree, scoreIDThree);
        }
    }
}


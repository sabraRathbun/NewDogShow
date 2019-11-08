using Common_DogShow;
using DataAccess_DogShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service_DogShow
{
    public class Judgement
    {
        public List<DogBreed> firstNameList = new List<DogBreed>();
        public List<Dog> dogList = new List<Dog>();
        public List<string> lastNames = new List<string>();
        PullSqlData pull = new PullSqlData();


        public void InsertScores(int total, int size, int eye, int furColor, int furLength, int dogID)
        {
            pull.InsertScores(total, size, eye, furColor, furLength, dogID);
        }
        public void InsertEvent(int locationID, int EventID, int dogID, string time)
        {
            pull.InsertEvent(locationID, EventID, dogID, time);
        }
        public void SelectDoggo(ListView dogView, int breedIndex)
        {
            dogList.Clear();
            dogView.Items.Clear();
            var dogs = pull.GetDogsForJudgement(breedIndex);
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
    }
}

using Common_DogShow;
using DataAccess_DogShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_DogShow
{
    public class Judgement
    {
        public List<DogBreed> nameList = new List<DogBreed>();
        PullSqlData pull = new PullSqlData();
        int dogId;
        
        public List<DogBreed> GetDogBreedList()
        {
            nameList = pull.GetDogBreed();
            return nameList;
        }
        public int GetDogID(string name)
        {
            dogId = pull.DogIdNum(name);
            return dogId;
        }
        public void InsertScores(int total, int size, int eye, int furColor, int furLength, int dogID)
        {
            pull.InsertScores(total, size, eye, furColor, furLength, dogID);
        }
        public void InsertEvent(int locationID, int EventID)
        {
            pull.InsertEvent(locationID, EventID);
        }
    }
}

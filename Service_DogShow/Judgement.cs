﻿using Common_DogShow;
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
        public List<DogBreed> firstNameList = new List<DogBreed>();
        public List<string> lastNames = new List<string>();

        PullSqlData pull = new PullSqlData();
        int dogId;
        
        public List<DogBreed> GetDogBreedList()
        {
            firstNameList = pull.GetDogBreed();
            return firstNameList;
        }
        public List<string> GetLastNames()
        {
            lastNames = pull.GetDogLastName();
            return lastNames;
           
        }
        public int GetDogID(string name, string lastName)
        {
            dogId = pull.DogId(name, lastName);
            return dogId;
        }
        public void InsertScores(int total, int size, int eye, int furColor, int furLength, int dogID)
        {
            pull.InsertScores(total, size, eye, furColor, furLength, dogID);
        }
        public void InsertEvent(int locationID, int EventID, int dogID)
        {
            pull.InsertEvent(locationID, EventID, dogID);
        }
    }
}

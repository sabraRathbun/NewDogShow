using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess_DogShow;
using DogShow;
namespace Service_DogShow
{
    class Competition : CompetitionForm
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

        public void selectBreedBtn_Click(object sender, EventArgs e)
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
        public void saveComp_Click(object sender, EventArgs e)
        {
            Console.WriteLine("do the thing");
        }


    }
}


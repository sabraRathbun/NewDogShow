using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_DogShow;
using DataAccess_DogShow;
using static Common_DogShow.BreedGroups;

namespace Service_DogShow
{
    public class DogInfo
    {
        List<string> DogBreeds = new List<string>();
        PullSqlData pull = new PullSqlData();
        int BreedId;

        public void GetDogBreeds(int BreedIndex, ListBox BreedBox, Button ChooseBreedBtn)
        {
            var DogBreeds = pull.BreedNames((Classes)BreedIndex);
            BreedBox.Items.Clear();
            foreach (string breed in DogBreeds)
            {
                BreedBox.Items.Add(breed);
            }
            ChooseBreedBtn.Enabled = true;
        }
        public int GetBreedId(string dogName)
        {
            BreedId = pull.BreedNum(dogName);
            return BreedId;
        }
        public void InsertDog(int breedId, string name, string lastName, string gender)
        {
            pull.InsertDoggo(breedId, name, lastName, gender);
        }
    }
}

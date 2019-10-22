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
    public partial class CurrentlyRegistered : Form
    {
        //List<DogBreed> DogList = new List<DogBreed>();
        //PullSqlData pull = new PullSqlData();
        //int currentIndex;
        public CurrentlyRegistered()
        {
            InitializeComponent();
        }

        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);
        //    DogList = pull.GetDogBreed();
        //    if (DogList.Any())
        //    {
        //        currentIndex = 1;
        //        DogBreed firstDog = DogList.First();
        //        dogNameLbl.Text = firstDog.DogName;
        //        dogBreedLbl.Text = firstDog.Description;
        //        dogGenderLbl.Text = firstDog.DogGender;
        //        dogClassLbl.Text = Enum.GetName(typeof(Classes), firstDog.ClassId);
        //    }
        //    else
        //    {
        //        forwardBtn.Enabled = false;
        //        backBtn.Enabled = false;
        //    }
        //}
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            //currentIndex += 1;
            //if (currentIndex > DogList.Count - 1)
            //{
            //    forwardBtn.Enabled = false;

            //}
            //else
            //{
            //    backBtn.Enabled = true;
            //    DogBreed newDog = DogList.ElementAt(currentIndex);
            //    dogNameLbl.Text = newDog.DogName;
            //    dogBreedLbl.Text = newDog.Description;
            //    dogGenderLbl.Text = newDog.DogGender;
            //    dogClassLbl.Text = Enum.GetName(typeof(Classes), newDog.ClassId);
            //}

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //currentIndex -= 1;
            //if (currentIndex < 0)
            //{
            //    backBtn.Enabled = false;
            //    currentIndex += 1;
            //}
            //else
            //{
            //    forwardBtn.Enabled = true;
            //    DogBreed newDog = DogList.ElementAt(currentIndex);
            //    dogNameLbl.Text = newDog.DogName;
            //    dogBreedLbl.Text = newDog.Description;
            //    dogGenderLbl.Text = newDog.DogGender;
            //    dogClassLbl.Text = Enum.GetName(typeof(Classes), newDog.ClassId);
            //}

        }
    }
}

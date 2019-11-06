using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common_DogShow;
using Service_DogShow;

namespace DogShow
{
    public partial class CompetitionForm : Form
    {
        Competition comp = new Competition();
        List<string> dogList = new List<string>();
        string first;
        string second;
        string third;
        int breedIndex;
        int eventNum;
        int locationID;

        public CompetitionForm()
        {

            InitializeComponent();
            foreach (string className in Classes.GetNames(typeof(Classes)))
            {
                classGroupComboBox.Items.Add(className);
            }  
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            dogList = comp.GetSelectedDoggos(dogListView, breedIndex, eventNum, locationID);
            first = dogList.ElementAt(0);
            second = dogList.ElementAt(1);
            third = dogList.ElementAt(2);
            firstLbl.Text = first;
            secondLbl.Text = second;
            thirdLbl.Text = third;
        }

        private void SaveComp_Click(object sender, EventArgs e)
        {
            comp.InsertDoggo();
        }

        private void classGroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventNum = Int32.Parse(EventNumTxt.Text);
            locationID = Int32.Parse(LocationIDTxt.Text);
            breedIndex = classGroupComboBox.SelectedIndex;
            comp.SelectDoggo(dogListView, breedIndex, eventNum, locationID);

        }

    }
}

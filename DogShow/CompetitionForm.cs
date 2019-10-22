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
    public partial class CompetitionForm : Form
    {
        //List<string> dogList = new List<string>();
        //PullSqlData pull = new PullSqlData();
        //string dogOne;
        //string dogTwo;
        //string dogThree;
        //string first;
        //string second;
        //string third;
        //int competitionIDOne;
        //int competitionIDTwo;
        //int competitionIDThree;
        //int eventIDOne;
        //int eventIDTwo;
        //int eventIDThree;
        //int DogIDOne;
        //int DogIDTwo;
        //int DogIDThree;
        //int scoreIDOne;
        //int scoreIDTwo;
        //int scoreIDThree;

        public CompetitionForm()
        {

            InitializeComponent();
            foreach (string className in Classes.GetNames(typeof(Classes)))
            {
                breedGroupBox.Items.Add(className);
            }  
        }
        



    }
}

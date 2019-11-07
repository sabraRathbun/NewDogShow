﻿using Service_DogShow;
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
    public partial class PastCompetitions : Form
    {
        int breedIndex;
        int eventNum;
        int locationID;
        List<string> PastDoggos = new List<string>();
        PastComp pastComp = new PastComp();
        public PastCompetitions()
        {
            InitializeComponent();
            foreach (string className in Classes.GetNames(typeof(Classes)))
            {
                ClassGroupComboBox.Items.Add(className);
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            eventNum = Convert.ToInt32(EventNumTxt.Text);
            locationID = Convert.ToInt32(LocationNumTxt.Text);
            PastDoggos = pastComp.OrderedDoggos(breedIndex, eventNum, locationID);
            FirstLbl.Text = PastDoggos[0];
            SecondLbl.Text = PastDoggos[1];
            ThirdLbl.Text = PastDoggos[2];
            PastDoggos.Clear();
            
        }

        private void BreedGroupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            breedIndex = ClassGroupComboBox.SelectedIndex;
        }
    }
}

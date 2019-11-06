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
    public partial class StartupForm : Form
    {

        public StartupForm()
        {
            InitializeComponent();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            DogInfoForm dogInfo = new DogInfoForm();
            dogInfo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JudgeLogin login = new JudgeLogin();
            login.ShowDialog();
        }

       

        private void dogListBtn_Click(object sender, EventArgs e)
        {
            CurrentlyRegistered current = new CurrentlyRegistered();
            current.ShowDialog();
        }

        private void competitionBtn_Click(object sender, EventArgs e)
        {
            CompetitionForm comp = new CompetitionForm();
            comp.ShowDialog();
        }

        private void pastCompBtn_Click(object sender, EventArgs e)
        {
            PastCompetitions pastComp = new PastCompetitions();
            pastComp.ShowDialog();
        }
    }
}

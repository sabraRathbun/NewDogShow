using Service_DogShow;
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

    public enum Classes
    {
        Terriers,
        Sporting,
        Hounds,
        NonSporting,
        Working,
        Herding,
        Toy,
        Miscellaneous
    }
    public partial class DogInfoForm : Form
    {
        DogInfo info = new DogInfo();
        public String firstName = "";
        public String gender = "";
        public int breedID;
        private Image outline = Properties.Resources.pawOutlineNew;
        private Image filledIn = Properties.Resources.bluePaw;



        public DogInfoForm()
        {
            InitializeComponent();
            foreach (string className in Classes.GetNames(typeof(Classes)))
            {
                BreedGroupBox.Items.Add(className);
            }
        }


        private void ViewBtn_Click(object sender, EventArgs e)
        {
            int breedIndex = BreedGroupBox.SelectedIndex;
            if (breedIndex < 0)
            {
                return;
            }

            info.GetDogBreeds(breedIndex, BreedBox, ChooseBreedBtn);
           
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            SizePanel.Enabled = false;
            FurLengthPanel.Enabled = false;
            EyeColorPanel.Enabled = false;
            FurPanel.Enabled = false;
            FirstNameTxt.Text = "";
            genderPanel.Enabled = false;
            ViewBtn.Enabled = true;
        }

        private void ChooseBreedBtn_Click(object sender, EventArgs e)
        {
            SizePanel.Enabled = true;
            FurLengthPanel.Enabled = true;
            EyeColorPanel.Enabled = true;
            FurPanel.Enabled = true;
            genderPanel.Enabled = true;
            ViewBtn.Enabled = false;
            SaveBtn.Enabled = true;
            string dogBreed = BreedBox.SelectedItem.ToString();

            breedID = info.GetBreedId(dogBreed);


        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            firstName = FirstNameTxt.Text;
            if (femRad.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Male";
            }

            info.InsertDog(breedID, firstName, gender);

        }

        private void BreedBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseBreedBtn.Visible = true;
        }

        private void femPicBox_Click(object sender, EventArgs e)
        {
            if (femRad.Checked != true)
            {
                femRad.Checked = true;
                maleRad.Checked = false;
                femPicBox.Image = filledIn;
                malePicBox.Image = outline;
            }
            else
            {
                femRad.Checked = false;
                femPicBox.Image = outline;
                maleRad.Image = filledIn;
            }

        }

        private void malePicBox_Click(object sender, EventArgs e)
        {
            if (maleRad.Checked != true)
            {
                maleRad.Checked = true;
                femRad.Checked = false;
                malePicBox.Image = filledIn;
                femPicBox.Image = outline;
            }
            else
            {
                maleRad.Checked = false;
                femRad.Checked = true;
                malePicBox.Image = outline;
                femPicBox.Image = filledIn;
            }
        }

        private void shortPicBox_Click(object sender, EventArgs e)
        {
            if (shortRad.Checked != true)
            {
                shortRad.Checked = true;
                longRad.Checked = false;
                shortPicBox.Image = filledIn;
                longPicBox.Image = outline;
            }
            else
            {
                shortRad.Checked = false;
                longRad.Checked = true;
                shortPicBox.Image = outline;
                longPicBox.Image = filledIn;
            }
        }

        private void longPicBox_Click(object sender, EventArgs e)
        {
            if (longRad.Checked != true)
            {
                longRad.Checked = true;
                shortRad.Checked = false;
                longPicBox.Image = filledIn;
                shortPicBox.Image = outline;
            }
            else
            {
                longRad.Checked = false;
                shortRad.Checked = true;
                longPicBox.Image = outline;
                shortPicBox.Image = filledIn;
            }
        }

        private void brownEyePicBox_Click(object sender, EventArgs e)
        {
            if (brownEyeRad.Checked != true)
            {
                brownEyeRad.Checked = true;
                brownEyePicBox.Image = filledIn;
                blueEyePicBox.Image = outline;
                hazelPicBox.Image = outline;
                multiEyePicBox.Image = outline;
            }
            else
            {
                brownEyeRad.Checked = false;
                brownEyePicBox.Image = outline;

            }
        }

        private void hazelPicBox_Click(object sender, EventArgs e)
        {
            if (hazelEyeRad.Checked != true)
            {
                hazelEyeRad.Checked = true;
                hazelPicBox.Image = filledIn;
                blueEyePicBox.Image = outline;
                brownEyePicBox.Image = outline;
                multiEyePicBox.Image = outline;
            }
            else
            {
                hazelEyeRad.Checked = false;
                hazelPicBox.Image = outline;

            }
        }

        private void blueEyePicBox_Click(object sender, EventArgs e)
        {
            if (blueEyeRad.Checked != true)
            {
                blueEyeRad.Checked = true;
                blueEyePicBox.Image = filledIn;
                brownEyePicBox.Image = outline;
                hazelPicBox.Image = outline;
                multiEyePicBox.Image = outline;
            }
            else
            {
                blueEyeRad.Checked = false;
                blueEyePicBox.Image = outline;

            }
        }

        private void multiEyePicBox_Click(object sender, EventArgs e)
        {
            if (multiEyeRad.Checked != true)
            {
                multiEyePicBox.Image = filledIn;
                blueEyePicBox.Image = outline;
                hazelPicBox.Image = outline;
                brownEyePicBox.Image = outline;
            }
            else
            {
                multiEyeRad.Checked = false;
                multiEyePicBox.Image = outline;

            }
        }

        private void toyPicBox_Click(object sender, EventArgs e)
        {
            if (toyRad.Checked != true)
            {
                toyRad.Checked = true;
                toyPicBox.Image = filledIn;
                smallPicBox.Image = outline;
                medPicBox.Image = outline;
                largePicBox.Image = outline;
                xtraLargePicBox.Image = outline;
            }
            else
            {
                toyRad.Checked = false;
                toyPicBox.Image = outline;

            }
        }

        private void smallPicBox_Click(object sender, EventArgs e)
        {
            if (smallRad.Checked != true)
            {
                smallRad.Checked = true;
                smallPicBox.Image = filledIn;
                toyPicBox.Image = outline;
                medPicBox.Image = outline;
                largePicBox.Image = outline;
                xtraLargePicBox.Image = outline;
            }
            else
            {
                smallRad.Checked = false;
                smallPicBox.Image = outline;

            }
        }

        private void medPicBox_Click(object sender, EventArgs e)
        {
            if (mediumRad.Checked != true)
            {
                mediumRad.Checked = true;
                medPicBox.Image = filledIn;
                smallPicBox.Image = outline;
                toyPicBox.Image = outline;
                largePicBox.Image = outline;
                xtraLargePicBox.Image = outline;
            }
            else
            {
                mediumRad.Checked = false;
                medPicBox.Image = outline;

            }
        }

        private void largePicBox_Click(object sender, EventArgs e)
        {
            if (largeRad.Checked != true)
            {
                largeRad.Checked = true;
                largePicBox.Image = filledIn;
                smallPicBox.Image = outline;
                medPicBox.Image = outline;
                toyPicBox.Image = outline;
                xtraLargePicBox.Image = outline;
            }
            else
            {
                largeRad.Checked = false;
                largePicBox.Image = outline;

            }
        }

        private void xtraLargePicBox_Click(object sender, EventArgs e)
        {
            if (extraLargeRad.Checked != true)
            {
                extraLargeRad.Checked = true;
                xtraLargePicBox.Image = filledIn;
                smallPicBox.Image = outline;
                medPicBox.Image = outline;
                largePicBox.Image = outline;
                toyPicBox.Image = outline;
            }
            else
            {
                extraLargeRad.Checked = false;
                xtraLargePicBox.Image = outline;

            }
        }

        private void brownFurPicBox_Click(object sender, EventArgs e)
        {
            if (brownFurRad.Checked != true)
            {
                brownFurRad.Checked = true;
                brownFurPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                tanPicBox.Image = outline;
                redPicBox.Image = outline;
                yellowPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                brownFurRad.Checked = false;
                brownFurPicBox.Image = outline;

            }
        }

        private void whiteFurPicBox_Click(object sender, EventArgs e)
        {
            if (whiteFurRad.Checked != true)
            {
                whiteFurRad.Checked = true;
                whiteFurPicBox.Image = filledIn;
                brownFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                tanPicBox.Image = outline;
                redPicBox.Image = outline;
                yellowPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                whiteFurRad.Checked = false;
                whiteFurPicBox.Image = outline;

            }
        }

        private void blackPicBox_Click(object sender, EventArgs e)
        {
            if (blackFurRad.Checked != true)
            {
                blackFurRad.Checked = true;
                blackPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                brownFurPicBox.Image = outline;
                tanPicBox.Image = outline;
                redPicBox.Image = outline;
                yellowPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                blackFurRad.Checked = false;
                blackPicBox.Image = outline;

            }
        }

        private void tanPicBox_Click(object sender, EventArgs e)
        {
            if (tanFurRad.Checked != true)
            {
                tanFurRad.Checked = true;
                tanPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                brownFurPicBox.Image = outline;
                redPicBox.Image = outline;
                yellowPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                tanFurRad.Checked = false;
                tanPicBox.Image = outline;

            }
        }

        private void redPicBox_Click(object sender, EventArgs e)
        {
            if (redFurRad.Checked != true)
            {
                redFurRad.Checked = true;
                redPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                brownFurPicBox.Image = outline;
                tanPicBox.Image = outline;
                yellowPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                tanFurRad.Checked = false;
                tanPicBox.Image = outline;

            }
        }

        private void yellowPicBox_Click(object sender, EventArgs e)
        {
            if (yellowFurRad.Checked != true)
            {
                yellowFurRad.Checked = true;
                yellowPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                tanPicBox.Image = outline;
                redPicBox.Image = outline;
                brownFurPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                yellowFurRad.Checked = false;
                yellowPicBox.Image = outline;

            }
        }

        private void blueFurPicBox_Click(object sender, EventArgs e)
        {
            if (blueFurRad.Checked != true)
            {
                blueFurRad.Checked = true;
                blueFurPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                tanPicBox.Image = outline;
                redPicBox.Image = outline;
                yellowPicBox.Image = outline;
                brownFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                blueFurRad.Checked = false;
                blueFurPicBox.Image = outline;

            }
        }

        private void multiFurPicBox_Click(object sender, EventArgs e)
        {
            if (multiFurRad.Checked != true)
            {
                multiFurRad.Checked = true;
                multiFurPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                tanPicBox.Image = outline;
                redPicBox.Image = outline;
                yellowPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                brownFurPicBox.Image = outline;
                goldPicBox.Image = outline;
            }
            else
            {
                multiFurRad.Checked = false;
                multiFurPicBox.Image = outline;

            }
        }

        private void goldPicBox_Click(object sender, EventArgs e)
        {
            if (goldFurRad.Checked != true)
            {
                goldFurRad.Checked = true;
                goldPicBox.Image = filledIn;
                whiteFurPicBox.Image = outline;
                blackPicBox.Image = outline;
                tanPicBox.Image = outline;
                redPicBox.Image = outline;
                yellowPicBox.Image = outline;
                blueFurPicBox.Image = outline;
                multiFurPicBox.Image = outline;
                brownFurPicBox.Image = outline;
            }
            else
            {
                goldFurRad.Checked = false;
                goldPicBox.Image = outline;

            }
        }


    }
}

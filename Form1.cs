using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyGunShotGame
{
    public partial class Form1 : Form
    {

        GunLogic GLogic = new GunLogic();


        public Form1()
        {

            InitializeComponent();

        }

        private void Load_Click_1(object sender, EventArgs e)
        {
            //below code for loading bullet
            //Spin.Enabled = true;
            //Load.Enabled = false;
            pictureBox1.Image = MyGunShotGame.Resource1.load2;
            SoundPlayer sp = new SoundPlayer(MyGunShotGame.Resource1.load);
            sp.Play();
            GLogic.LoadLogic();
        }

        private void Spin_Click_1(object sender, EventArgs e)
        {


            pictureBox1.Image = MyGunShotGame.Resource1.spin;  // code for setting the image
            // adding sound from resources
            SoundPlayer sp = new SoundPlayer(MyGunShotGame.Resource1.spinchamber);
            sp.Play();


            GLogic.SpinLogic();
            Fire.Enabled = true;
            FireAway.Enabled = true;

        }



        private void Fire_Click_1(object sender, EventArgs e)
        {

            //below code for picturebox from resources
            pictureBox1.Image = MyGunShotGame.Resource1.shoot3;
            SoundPlayer sp = new SoundPlayer(MyGunShotGame.Resource1.shoot);
            sp.Play();


            int chances = GLogic.SpinLogic();
            if (chances == 0)
            {
                //code for message box
                MessageBox.Show("You win"); // after winning all buttons will disable
                Fire.Enabled = false;
                FireAway.Enabled = false;
                Spin.Enabled = false;
                Load.Enabled = false;

                MessageBox.Show(" Do you want to play again?");
                Application.Restart(); //once finished u can play again

            }

        }



        private void FireAway_Click_1(object sender, EventArgs e)
        {
            ////below code for picturebox from resources
            pictureBox1.Image = MyGunShotGame.Resource1.shoot3;
            SoundPlayer sp = new SoundPlayer(MyGunShotGame.Resource1.shoot);
            sp.Play();


            int chances = GLogic.ShootingAway();

            if (chances == 0)
            {
                //all buttons will be disabled
                Fire.Enabled = false;
                FireAway.Enabled = false;
                Spin.Enabled = false;
                Load.Enabled = false;

                MessageBox.Show("No chances left, you are dead, do you want to play again?");
                Application.Restart();//once finished u can play again
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MyGunShotGame
{
    public class GunLogic
    {
		//shoot logic
		public int FAChances = 2; //fire away chances 
		public int Bullet = 0;
		public int Fire = 4;
            


            public void LoadLogic()

            {
                Bullet = 6;
            }

            public int SpinLogic()

            {
                //spining the chmaber
                Random rand = new Random();
                Bullet = rand.Next(1, 7);
                return Bullet;
            }

            public int FireLogic()
            {


                if (Bullet == 1)
                {
                    //code for message box
                    MessageBox.Show("You are dead , do you want to play again?!");
                    Application.Restart(); //how we play again using the code
                }
                else if (Fire > 1)
                {
                    //code for message box
                    MessageBox.Show("keep it up ");
                    Bullet--;
                    Fire--;
                }
                else
                {
                    Bullet--;
                    Fire--;
                }



                return Fire;
            }

            public int ShootingAway()
            {

                if (Bullet == 1)
                {
                    //code for message box
                    MessageBox.Show("You survived, do you want to play again?");
                    Application.Restart();
                }
                else if (FAChances > 1)
                {
                    //code for message box
                    MessageBox.Show("Keep it up");
                    Bullet--;
                    FAChances--;
                }
                else
                {
                    Bullet--;
                    FAChances--;
                }

                //return the bullet code
                return FAChances;

            }
        
        internal void SpinChamber()
        {
            throw new NotImplementedException();
        }
    }
}




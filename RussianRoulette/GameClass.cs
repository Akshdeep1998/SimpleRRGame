using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoulette
{
    public class GameClass
    {
        public int Bullet;
        int points = 0;

        public void LoadLogic() //loading the gun
        {
            Bullet = 6;
        }
        
        public int SpinLogic()//spinning th echambers of gun
        {
            Random rand = new Random();
            Bullet = rand.Next(1, 7); //setting a range
            return Bullet; 
        }

        int chances = 4; // chances to shoot on head
        int ChancesAway = 2; //chances to shoot away

        public int ShootLogic()
        {            
            if (Bullet == 1)
            {
                // the user is dead!
                MessageBox.Show("You are dead and you scored zero points! do you want to play again?","Game Over!");
                Application.Restart();
            }
            else
            {
                chances--;
                Bullet--;
                //if chances of shooting at your head is zero, tell him you survived unless tell him keep playing
                if (chances == 0 && ChancesAway == 2)
                {
                    points = 10;
                    MessageBox.Show("You win!!! Congrats! You got " + points + " points! Do you want to play again?", "Game Over!");
                    Application.Restart();
                }
                else if(chances == 0 && ChancesAway == 1)
                {
                    points = 5;
                    MessageBox.Show("You win!!! Congrats! You got " + points + " points! Do you want to play again?", "Game Over!");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Try your luck.. Fingers crossed");
                }
            }
            return chances;

        }

        public int ShootAwayLogic()
        {
            if (Bullet == 1 && ChancesAway == 2)
            {
                //tell the user you died!
                points = 10;
                MessageBox.Show("You survive! You got " + points + " points");
                Application.Restart();
                
            }
            else if(Bullet == 1 && ChancesAway == 1)
            {
                MessageBox.Show("You survive! You got " + points + " points");
                points = 5;
            }
            else
            {                
                ChancesAway--;
                Bullet--;
                //if chances are zero tell him you are dead else tell him keep playing
                if(ChancesAway == 0)
                {
                    MessageBox.Show("You have lost all chances of survival, you scored "+points + " points do you want to play again?","Game Over");
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("All the best!! Last chance to try your luck");
                }
            }
            
            return ChancesAway;
        }

    }
}

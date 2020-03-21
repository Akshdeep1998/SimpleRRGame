using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;//this is used to implement media in the game


namespace RussianRoulette// this is the name given to the project(game)
{
    public partial class PlayGameForm : Form
    {   //defining the class 
        GameClass logic = new GameClass();

        public PlayGameForm()
        {
            InitializeComponent();
        }
        //Load button
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            LoadImg.Image = RussianRoulette.Resource1.load;//to display image in the form
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.LoadSound);
            sp.Play();//sound effect to the load button and its source is mentioned
            Spin.Enabled = true;// it is to disable the spin button unless the gun is loaded
            logic.LoadLogic();//calling the load function to act here
        }
        //spin the chambers
        private void Spin_Click(object sender, EventArgs e)
        {
            LoadBtn.Enabled = false;// load button is disablesd after the player has once loaded the bullet
            LoadImg.Image = RussianRoulette.Resource1.frontpage;
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.SpinSound);
            sp.Play();
            Fire.Enabled = true;// fire is disabled until the chamber is spinned
            ShootAway.Enabled = true;//shootaway is disabled until the chamber is spinned
            logic.SpinLogic();//calling the spin function to act
            //MessageBox.Show("Bullet Position" , (logic.Bullet).ToString());
        }
        //Fire on head
        private void Fire_Click(object sender, EventArgs e)
        {
            //Spin.Enabled = false;
            LoadImg.Image = RussianRoulette.Resource1.ShootHead;
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.FireSound);
            sp.Play();
            logic.ShootLogic();//calling the shoot logic to work
        }
        //ShootAway
        private void ShootAway_Click(object sender, EventArgs e)
        {
            Spin.Enabled = false;
            LoadImg.Image = RussianRoulette.Resource1.fire;
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.FireSound);
            sp.Play();
            logic.ShootAwayLogic();//calling the shootaway logic to act
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }

}

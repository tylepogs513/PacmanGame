using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PacmanGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create brushes, pens, fonts, and initialize graphics 
            Graphics g = this.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 5);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Franklin Gothic Medium", 50, FontStyle.Bold);
            Font drawFont2 = new Font("Franklin Gothic Medium", 20, FontStyle.Bold);
            Font drawFont3 = new Font("Franklin Gothic Medium", 100, FontStyle.Bold);
            Font drawFont4 = new Font("Franklin Gothic Medium", 30, FontStyle.Bold);
            SoundPlayer chompPlayer = new SoundPlayer(Properties.Resources.pacman_munch);
            SoundPlayer beginPlayer = new SoundPlayer(Properties.Resources.pacman_beginning);
            SoundPlayer deathPlayer = new SoundPlayer(Properties.Resources.pacman_death);
            SoundPlayer interPlayer = new SoundPlayer(Properties.Resources.pacman_intermission);
            SoundPlayer levelPlayer = new SoundPlayer(Properties.Resources.pacman_change);
            SoundPlayer startPlayer = new SoundPlayer(Properties.Resources.pacman_extrapac);

            //when the button gets pushed hide load screen
            playButton.Visible = false;
            coins.Visible = false;
            pacman.Visible = false;
            g.Clear(Color.Black);

            g.DrawString("Level 1", drawFont3, redBrush, 200, 150);
            Thread.Sleep(1125);
            g.Clear(Color.Black);

            g.DrawString("Ready", drawFont3, redBrush, 200, 150);
            beginPlayer.Play();
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("3", drawFont3, whiteBrush, 300, 150);
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("2", drawFont3, whiteBrush, 300, 150);
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("1", drawFont3, whiteBrush, 300, 150);
            Thread.Sleep(1125);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:0", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 130, 87, 15, 15);
            g.FillEllipse(yellowBrush, 230, 87, 15, 15);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 50, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 50, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 130, 87, 15, 15);
            g.FillEllipse(yellowBrush, 230, 87, 15, 15);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 75, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 75, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 130, 87, 15, 15);
            g.FillEllipse(yellowBrush, 230, 87, 15, 15);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 100, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 100, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 230, 87, 15, 15);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 125, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 125, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 230, 87, 15, 15);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 150, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 150, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 230, 87, 15, 15);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 175, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 175, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 230, 87, 15, 15);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 200, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 200, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 225, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 225, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 330, 87, 15, 15);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 250, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 250, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 275, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 275, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 300, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 300, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 325, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 325, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 430, 87, 15, 15);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 350, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 350, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 375, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 375, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 400, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 400, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 50, 75, 75, 30, 360);
            g.DrawPie(blackPen, 418, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 50, 75, 75, 120, 290);
            g.DrawPie(blackPen, 418, 50, 75, 75, 120, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 75, 75, 75, 120, 360);
            g.DrawPie(blackPen, 418, 75, 75, 75, 90, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 157, 15, 15);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 100, 75, 75, 120, 290);
            g.DrawPie(blackPen, 418, 100, 75, 75, 120, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:50", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 125, 75, 75, 120, 360);
            g.DrawPie(blackPen, 418, 125, 75, 75, 90, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:50", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 227, 15, 15);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 150, 75, 75, 120, 290);
            g.DrawPie(blackPen, 418, 150, 75, 75, 120, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 175, 75, 75, 120, 360);
            g.DrawPie(blackPen, 418, 175, 75, 75, 90, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 200, 75, 75, 120, 290);
            g.DrawPie(blackPen, 418, 200, 75, 75, 120, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 225, 75, 75, 120, 360);
            g.DrawPie(blackPen, 418, 225, 75, 75, 90, 360);
            Thread.Sleep(300);
        
            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, whiteBrush, 50, 250);
            g.FillEllipse(yellowBrush, 455, 310, 15, 15);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 250, 75, 75, 120, 290);
            g.DrawPie(blackPen, 418, 250, 75, 75, 120, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:70", drawFont2, whiteBrush, 50, 250);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 275, 75, 75, 120, 360);
            g.DrawPie(blackPen, 418, 275, 75, 75, 90, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:70", drawFont2, whiteBrush, 50, 250);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(blackPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 300, 75, 75, 120, 290);
            g.DrawPie(blackPen, 418, 300, 75, 75, 120, 290);

            g.Clear(Color.Black);
            g.DrawString("Level", drawFont3, whiteBrush, 200, 100);
            g.DrawString("Complete", drawFont3, whiteBrush, 100, 200);
            startPlayer.Play();
            Thread.Sleep(2000);
            g.Clear(Color.Black);

            g.DrawString("Level 2", drawFont3, redBrush, 200, 150);
            levelPlayer.Play();
            Thread.Sleep(2300);

            g.Clear(Color.Black);

            g.DrawString("Ready", drawFont3, redBrush, 200, 150);
            beginPlayer.Play();
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("3", drawFont3, whiteBrush, 300, 150);
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("2", drawFont3, whiteBrush, 300, 150);
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("1", drawFont3, whiteBrush, 300, 150);
            Thread.Sleep(1125);

            g.Clear(Color.Black);
            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:70", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 115, 87, 15, 15);
            g.FillEllipse(yellowBrush, 200, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 50, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 50, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:80", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 200, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 75, 50, 75, 75, 0, 360);
            g.DrawPie(blackPen, 75, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:80", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 200, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 100, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 100, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:80", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 200, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 125, 50, 75, 75, 0, 360);
            g.DrawPie(blackPen, 125, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);
            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:80", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 200, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 150, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 150, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:90", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 175, 50, 75, 75, 0, 360);
            g.DrawPie(blackPen, 175, 50, 75, 75, 0, 360);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:90", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 200, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 200, 50, 75, 75, 30, 290);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:100", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 87, 15, 15);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 225, 50, 75, 75, 0, 360);
            g.DrawPie(blackPen, 225, 50, 75, 75, 0, 360);
            g.FillPie(redBrush, 50, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 50, 68, 75, 40);
            g.FillPie(redBrush, 50, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 75, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 100, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 60, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 85, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 69, 66, 16, 23);
            g.FillEllipse(blackBrush, 94, 66, 16, 23);
            Thread.Sleep(300);

            g.Clear(Color.Black);
            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:100", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 250, 50, 75, 75, 30, 290);
            g.DrawPie(blackPen, 250, 50, 75, 75, 30, 290);
            g.FillPie(redBrush, 75, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 75, 68, 75, 40);
            g.FillPie(redBrush, 75, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 100, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 125, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 85, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 110, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 94, 66, 16, 23);
            g.FillEllipse(blackBrush, 119, 66, 16, 23);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:100", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 255, 50, 75, 75, 90, 360);
            g.DrawPie(blackPen, 255, 50, 75, 75, 90, 360);
            g.FillPie(redBrush, 100, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 100, 68, 75, 40);
            g.FillPie(redBrush, 100, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 125, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 150, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 110, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 135, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 119, 66, 16, 23);
            g.FillEllipse(blackBrush, 144, 66, 16, 23);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:100", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 255, 75, 75, 75, 120, 290);
            g.DrawPie(blackPen, 255, 75, 75, 75, 120, 290);
            g.FillPie(redBrush, 125, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 125, 68, 75, 40);
            g.FillPie(redBrush, 125, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 150, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 175, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 135, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 160, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 144, 66, 16, 23);
            g.FillEllipse(blackBrush, 169, 66, 16, 23);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:100", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 255, 100, 75, 75, 90, 360);
            g.DrawPie(blackPen, 255, 100, 75, 75, 90, 360);
            g.FillPie(redBrush, 150, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 150, 68, 75, 40);
            g.FillPie(redBrush, 150, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 175, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 200, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 160, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 185, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 169, 66, 16, 23);
            g.FillEllipse(blackBrush, 194, 66, 16, 23);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:100", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 172, 15, 15);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 255, 125, 75, 75, 120, 290);
            g.DrawPie(blackPen, 255, 125, 75, 75, 120, 290);
            g.FillPie(redBrush, 175, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 175, 68, 75, 40);
            g.FillPie(redBrush, 175, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 200, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 225, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 185, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 210, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 194, 66, 16, 23);
            g.FillEllipse(blackBrush, 219, 66, 16, 23);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:110", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 255, 150, 75, 75, 90, 360);
            g.DrawPie(blackPen, 255, 150, 75, 75, 90, 360);
            g.FillPie(redBrush, 200, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 200, 68, 75, 40);
            g.FillPie(redBrush, 200, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 225, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 250, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 210, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 235, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 219, 66, 16, 23);
            g.FillEllipse(blackBrush, 244, 66, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:110", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 285, 257, 15, 15);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 255, 175, 75, 75, 120, 290);
            g.DrawPie(blackPen, 255, 175, 75, 75, 120, 290);
            g.FillPie(redBrush, 225, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 225, 68, 75, 40);
            g.FillPie(redBrush, 225, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 250, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 275, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 235, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 260, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 244, 66, 16, 23);
            g.FillEllipse(blackBrush, 269, 66, 16, 23);
            Thread.Sleep(300);

            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:120", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 255, 200, 75, 75, 90, 360);
            g.DrawPie(blackPen, 255, 200, 75, 75, 90, 360);
            g.FillPie(redBrush, 255, 50, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 68, 75, 40);
            g.FillPie(redBrush, 255, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 93, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 93, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 65, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 65, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 66, 16, 23);
            g.FillEllipse(blackBrush, 299, 66, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:120", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 255, 225, 75, 75, 120, 290);
            g.DrawPie(blackPen, 255, 225, 75, 75, 120, 290);
            g.FillPie(redBrush, 255, 75, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 93, 75, 40);
            g.FillPie(redBrush, 255, 118, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 118, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 118, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 90, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 90, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 91, 16, 23);
            g.FillEllipse(blackBrush, 299, 91, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:120", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 255, 250, 75, 75, 90, 360);
            g.DrawPie(blackPen, 255, 250, 75, 75, 90, 360);
            g.FillPie(redBrush, 255, 100, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 118, 75, 40);
            g.FillPie(redBrush, 255, 143, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 143, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 143, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 115, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 115, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 116, 16, 23);
            g.FillEllipse(blackBrush, 299, 116, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:120", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 280, 255, 75, 75, 30, 290);
            g.DrawPie(blackPen, 280, 255, 75, 75, 30, 290);
            g.FillPie(redBrush, 255, 125, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 143, 75, 40);
            g.FillPie(redBrush, 255, 168, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 168, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 168, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 140, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 140, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 141, 16, 23);
            g.FillEllipse(blackBrush, 299, 141, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:130", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 347, 280, 15, 15);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 305, 255, 75, 75, 0, 360);
            g.DrawPie(blackPen, 305, 255, 75, 75, 0, 360);
            g.FillPie(redBrush, 255, 150, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 168, 75, 40);
            g.FillPie(redBrush, 255, 193, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 193, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 193, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 165, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 165, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 166, 16, 23);
            g.FillEllipse(blackBrush, 299, 166, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:130", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 330, 255, 75, 75, 30, 290);
            g.DrawPie(blackPen, 330, 255, 75, 75, 30, 290);
            g.FillPie(redBrush, 255, 175, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 193, 75, 40);
            g.FillPie(redBrush, 255, 218, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 218, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 218, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 190, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 190, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 191, 16, 23);
            g.FillEllipse(blackBrush, 299, 191, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:130", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 355, 255, 75, 75, 0, 360);
            g.DrawPie(blackPen, 355, 255, 75, 75, 0, 360);
            g.FillPie(redBrush, 255, 200, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 218, 75, 40);
            g.FillPie(redBrush, 255, 243, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 243, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 243, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 215, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 215, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 216, 16, 23);
            g.FillEllipse(blackBrush, 299, 216, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:130", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 380, 255, 75, 75, 30, 290);
            g.DrawPie(blackPen, 380, 255, 75, 75, 30, 290);
            g.FillPie(redBrush, 255, 225, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 243, 75, 40);
            g.FillPie(redBrush, 255, 268, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 268, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 268, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 240, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 240, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 241, 16, 23);
            g.FillEllipse(blackBrush, 299, 241, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:140", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 405, 255, 75, 75, 0, 360);
            g.DrawPie(blackPen, 405, 255, 75, 75, 0, 360);
            g.FillPie(redBrush, 255, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 255, 273, 75, 40);
            g.FillPie(redBrush, 255, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 280, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 265, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 290, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 274, 271, 16, 23);
            g.FillEllipse(blackBrush, 299, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:140", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 432, 280, 15, 15);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 430, 255, 75, 75, 30, 290);
            g.DrawPie(blackPen, 430, 255, 75, 75, 30, 290);
            g.FillPie(redBrush, 280, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 280, 273, 75, 40);
            g.FillPie(redBrush, 280, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 305, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 330, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 290, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 315, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 299, 271, 16, 23);
            g.FillEllipse(blackBrush, 324, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:140", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();
            //pacman
            g.FillPie(yellowBrush, 455, 255, 75, 75, 0, 360);
            g.DrawPie(blackPen, 455, 255, 75, 75, 0, 360);
            g.FillPie(redBrush, 305, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 305, 273, 75, 40);
            g.FillPie(redBrush, 305, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 330, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 355, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 315, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 340, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 324, 271, 16, 23);
            g.FillEllipse(blackBrush, 349, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:140", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 460, 230, 75, 75, 300, 290);
            g.DrawPie(blackPen, 460, 230, 75, 75, 300, 290);
            g.FillPie(redBrush, 330, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 330, 273, 75, 40);
            g.FillPie(redBrush, 330, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 355, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 380, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 340, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 365, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 349, 271, 16, 23);
            g.FillEllipse(blackBrush, 374, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:150", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 480, 243, 15, 15);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 460, 205, 75, 75, 300, 360);
            g.DrawPie(blackPen, 460, 205, 75, 75, 270, 360);
            g.FillPie(redBrush, 355, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 355, 273, 75, 40);
            g.FillPie(redBrush, 355, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 380, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 405, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 365, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 390, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 374, 271, 16, 23);
            g.FillEllipse(blackBrush, 399, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:150", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 460, 180, 75, 75, 300, 290);
            g.DrawPie(blackPen, 460, 180, 75, 75, 300, 290);
            g.FillPie(redBrush, 380, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 380, 273, 75, 40);
            g.FillPie(redBrush, 380, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 405, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 430, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 390, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 415, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 399, 271, 16, 23);
            g.FillEllipse(blackBrush, 424, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:160", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 460, 155, 75, 75, 300, 360);
            g.DrawPie(blackPen, 460, 155, 75, 75, 270, 360);
            g.FillPie(redBrush, 405, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 405, 273, 75, 40);
            g.FillPie(redBrush, 405, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 430, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 455, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 415, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 440, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 424, 271, 16, 23);
            g.FillEllipse(blackBrush, 449, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:160", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 460, 130, 75, 75, 300, 290);
            g.DrawPie(blackPen, 460, 130, 75, 75, 300, 290);
            g.FillPie(redBrush, 430, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 430, 273, 75, 40);
            g.FillPie(redBrush, 430, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 455, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 480, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 440, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 465, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 449, 271, 16, 23);
            g.FillEllipse(blackBrush, 474, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:160", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 480, 158, 15, 15);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 460, 105, 75, 75, 300, 360);
            g.DrawPie(blackPen, 460, 105, 75, 75, 270, 360);
            g.FillPie(redBrush, 460, 255, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 273, 75, 40);
            g.FillPie(redBrush, 460, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 298, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 298, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 270, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 270, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 271, 16, 23);
            g.FillEllipse(blackBrush, 504, 271, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:160", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 492, 85, 15, 15);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 460, 80, 75, 75, 300, 290);
            g.DrawPie(blackPen, 460, 80, 75, 75, 300, 290);
            g.FillPie(redBrush, 460, 230, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 248, 75, 40);
            g.FillPie(redBrush, 460, 273, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 273, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 273, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 245, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 245, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 246, 16, 23);
            g.FillEllipse(blackBrush, 504, 246, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:170", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 460, 55, 75, 75, 300, 360);
            g.DrawPie(blackPen, 460, 55, 75, 75, 270, 360);
            g.FillPie(redBrush, 460, 205, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 223, 75, 40);
            g.FillPie(redBrush, 460, 248, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 248, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 248, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 220, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 220, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 221, 16, 23);
            g.FillEllipse(blackBrush, 504, 221, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:170", drawFont2, whiteBrush, 50, 200);
            g.FillEllipse(yellowBrush, 577, 85, 15, 15);

            //pacman
            g.FillPie(yellowBrush, 485, 55, 75, 75, 30, 290);
            g.DrawPie(blackPen, 485, 55, 75, 75, 30, 290);
            g.FillPie(redBrush, 460, 180, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 198, 75, 40);
            g.FillPie(redBrush, 460, 223, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 223, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 223, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 195, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 195, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 196, 16, 23);
            g.FillEllipse(blackBrush, 504, 196, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:180", drawFont2, whiteBrush, 50, 200);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 510, 55, 75, 75, 0, 360);
            g.DrawPie(blackPen, 510, 55, 75, 75, 0, 360);
            g.FillPie(redBrush, 460, 155, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 173, 75, 40);
            g.FillPie(redBrush, 460, 198, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 198, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 198, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 170, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 170, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 171, 16, 23);
            g.FillEllipse(blackBrush, 504, 171, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:180", drawFont2, whiteBrush, 50, 200);

            //pacman
            g.FillPie(yellowBrush, 535, 55, 75, 75, 30, 290);
            g.DrawPie(blackPen, 535, 55, 75, 75, 30, 290);
            g.FillPie(redBrush, 460, 130, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 148, 75, 40);
            g.FillPie(redBrush, 460, 173, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 173, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 173, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 145, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 145, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 146, 16, 23);
            g.FillEllipse(blackBrush, 504, 146, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:180", drawFont2, whiteBrush, 50, 200);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 560, 55, 75, 75, 0, 360);
            g.DrawPie(blackPen, 560, 55, 75, 75, 0, 360);
            g.FillPie(redBrush, 460, 105, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 123, 75, 40);
            g.FillPie(redBrush, 460, 148, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 148, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 148, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 120, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 120, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 121, 16, 23);
            g.FillEllipse(blackBrush, 504, 121, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:180", drawFont2, whiteBrush, 50, 200);

            //pacman
            g.FillPie(yellowBrush, 585, 55, 75, 75, 30, 290);
            g.DrawPie(blackPen, 585, 55, 75, 75, 30, 290);
            g.FillPie(redBrush, 460, 80, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 98, 75, 40);
            g.FillPie(redBrush, 460, 123, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 123, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 123, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 95, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 95, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 96, 16, 23);
            g.FillEllipse(blackBrush, 504, 96, 16, 23);
            Thread.Sleep(300);
            g.Clear(Color.Black);

            //walls
            g.FillRectangle(blueBrush, 40, 40, 300, 5);
            g.FillRectangle(blueBrush, 40, 135, 205, 5);
            g.FillRectangle(blueBrush, 340, 40, 5, 200);
            g.FillRectangle(blueBrush, 240, 135, 5, 200);
            g.FillRectangle(blueBrush, 340, 240, 110, 5);
            g.FillRectangle(blueBrush, 240, 335, 300, 5);
            g.FillRectangle(blueBrush, 450, 45, 5, 200);
            g.FillRectangle(blueBrush, 540, 140, 5, 200);
            g.FillRectangle(blueBrush, 450, 45, 240, 5);
            g.FillRectangle(blueBrush, 540, 140, 145, 5);
            g.DrawString("Pacman", drawFont4, yellowBrush, 50, 150);
            g.DrawString("Score:180", drawFont2, whiteBrush, 50, 200);
            chompPlayer.Play();

            //pacman
            g.FillPie(yellowBrush, 610, 55, 75, 75, 0, 360);
            g.DrawPie(blackPen, 610, 55, 75, 75, 0, 360);
            g.FillPie(redBrush, 460, 55, 75, 40, 0, 360);
            g.FillRectangle(redBrush, 460, 73, 75, 40);
            g.FillPie(redBrush, 460, 98, 25, 25, 0, 180);
            g.FillPie(redBrush, 485, 98, 25, 25, 0, 180);
            g.FillPie(redBrush, 510, 98, 25, 25, 0, 180);
            g.FillPie(whiteBrush, 470, 70, 25, 25, 0, 360);
            g.FillPie(whiteBrush, 495, 70, 25, 25, 0, 360);
            g.FillEllipse(blackBrush, 479, 71, 16, 23);
            g.FillEllipse(blackBrush, 504, 71, 16, 23);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            interPlayer.Play();
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, blackBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, blackBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, blackBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            
            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, blackBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, yellowBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //End Screen
            g.DrawString("Thanks", drawFont3, yellowBrush, 170, 50);
            g.DrawString("For", drawFont3, yellowBrush, 275, 150);
            g.DrawString("Playing!", drawFont3, yellowBrush, 150, 250);
            deathPlayer.Play();
            Thread.Sleep(1800);

            g.Clear(Color.Black);
            Thread.Sleep(200);

            playButton.Visible = true;
            coins.Visible = true;
            pacman.Visible = true;
        }
    }
}

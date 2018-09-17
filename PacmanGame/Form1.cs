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
            Pen drawPen = new Pen(Color.Black, 5);
            Pen drawPen1 = new Pen(Color.Yellow, 10);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Font drawFont = new Font("Franklin Gothic Medium", 50, FontStyle.Bold);
            Font drawFont2 = new Font("Franklin Gothic Medium", 20, FontStyle.Bold);
            Font drawFont3 = new Font("Franklin Gothic Medium", 100, FontStyle.Bold);
            Font drawFont4 = new Font("Franklin Gothic Medium", 30, FontStyle.Bold);
            SoundPlayer chompPlayer = new SoundPlayer(Properties.Resources.pacman_chomp);
            SoundPlayer beginPlayer = new SoundPlayer(Properties.Resources.pacman_beginning);
            SoundPlayer deathPlayer = new SoundPlayer(Properties.Resources.pacman_death);
            SoundPlayer interPlayer = new SoundPlayer(Properties.Resources.pacman_intermission);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 50, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 50, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 75, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 75, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 100, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 100, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 125, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 125, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 150, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 150, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 175, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 175, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 200, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 200, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 225, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 225, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 250, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 250, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 275, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 275, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 300, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 300, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 325, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 325, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 350, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 350, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 375, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 375, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 400, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 400, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 418, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 50, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 50, 75, 75, 120, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 75, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 75, 75, 75, 90, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 100, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 100, 75, 75, 120, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 125, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 125, 75, 75, 90, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 150, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 150, 75, 75, 120, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 175, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 175, 75, 75, 90, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 200, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 200, 75, 75, 120, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 225, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 225, 75, 75, 90, 360);
            Thread.Sleep(350);
        
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
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 250, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 250, 75, 75, 120, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:70", drawFont2, whiteBrush, 50, 250);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);
            chompPlayer.Play();

            //draw pacman
            g.FillPie(yellowBrush, 418, 275, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 275, 75, 75, 90, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(blueBrush, 40, 40, 460, 5);
            g.FillRectangle(blueBrush, 40, 135, 365, 5);
            g.FillRectangle(blueBrush, 500, 40, 5, 345);
            g.FillRectangle(blueBrush, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, yellowBrush, 50, 150);
            g.DrawString("Score:70", drawFont2, whiteBrush, 50, 250);
            g.FillPie(yellowBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(yellowBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, whiteBrush, 510, 20);

            //draw pacman
            g.FillPie(yellowBrush, 418, 300, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 300, 75, 75, 120, 290);

            g.Clear(Color.Black);
            g.DrawString("Level", drawFont3, whiteBrush, 200, 100);
            g.DrawString("Complete", drawFont3, whiteBrush, 100, 200);
            interPlayer.Play();
            Thread.Sleep(6000);
            g.Clear(Color.Black);

            g.DrawString("Level 2", drawFont3, redBrush, 200, 150);
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
            g.DrawPie(drawPen, 50, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 75, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 100, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 125, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 150, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 175, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 200, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 225, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 250, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 255, 50, 75, 75, 90, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 255, 75, 75, 75, 120, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 255, 100, 75, 75, 90, 360);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 255, 125, 75, 75, 120, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 255, 150, 75, 75, 90, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 255, 175, 75, 75, 120, 290);
            Thread.Sleep(350);

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
            g.DrawPie(drawPen, 255, 200, 75, 75, 90, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 255, 225, 75, 75, 120, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 255, 250, 75, 75, 90, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 280, 255, 75, 75, 30, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 305, 255, 75, 75, 0, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 330, 255, 75, 75, 30, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 355, 255, 75, 75, 0, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 380, 255, 75, 75, 30, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 405, 255, 75, 75, 0, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 430, 255, 75, 75, 30, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 455, 255, 75, 75, 0, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 230, 75, 75, 300, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 205, 75, 75, 270, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 180, 75, 75, 300, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 155, 75, 75, 270, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 130, 75, 75, 300, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 105, 75, 75, 270, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 80, 75, 75, 300, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 460, 55, 75, 75, 270, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 485, 55, 75, 75, 30, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 510, 55, 75, 75, 0, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 535, 55, 75, 75, 30, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 560, 55, 75, 75, 0, 360);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 585, 55, 75, 75, 30, 290);
            Thread.Sleep(350);
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
            g.DrawPie(drawPen, 610, 55, 75, 75, 0, 360);

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

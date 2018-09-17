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
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            SolidBrush drawBrush1 = new SolidBrush(Color.Blue);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);
            SolidBrush drawBrush3 = new SolidBrush(Color.Red);
            SolidBrush drawBrush4 = new SolidBrush(Color.White);
            Font drawFont = new Font("Franklin Gothic Medium", 50, FontStyle.Bold);
            Font drawFont2 = new Font("Franklin Gothic Medium", 20, FontStyle.Bold);
            Font drawFont3 = new Font("Franklin Gothic Medium", 100, FontStyle.Bold);
            SoundPlayer player = new SoundPlayer(Properties.Resources.pacman_chomp);
            SoundPlayer player1 = new SoundPlayer(Properties.Resources.pacman_beginning);
            SoundPlayer player2 = new SoundPlayer(Properties.Resources.pacman_death);
            SoundPlayer player3 = new SoundPlayer(Properties.Resources.pacman_intermission);

            //when the button gets pushed hide load screen
            playButton.Visible = false;
            coins.Visible = false;
            pacman.Visible = false;
            g.Clear(Color.Black);

            g.DrawString("Ready", drawFont3, drawBrush3, 200, 150);
            player1.Play();
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("3", drawFont3, drawBrush4, 300, 150);
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("2", drawFont3, drawBrush4, 300, 150);
            Thread.Sleep(1125);
            g.Clear(Color.Black);
            g.DrawString("1", drawFont3, drawBrush4, 300, 150);
            Thread.Sleep(1125);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:0", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 130, 87, 15, 15);
            g.FillEllipse(drawBrush, 230, 87, 15, 15);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 50, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 50, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 130, 87, 15, 15);
            g.FillEllipse(drawBrush, 230, 87, 15, 15);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 75, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 75, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 130, 87, 15, 15);
            g.FillEllipse(drawBrush, 230, 87, 15, 15);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 100, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 100, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 230, 87, 15, 15);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 125, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 125, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:10", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 230, 87, 15, 15);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 150, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 150, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 230, 87, 15, 15);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 175, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 175, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 230, 87, 15, 15);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 200, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 200, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 225, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 225, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:20", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 330, 87, 15, 15);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 250, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 250, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 275, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 275, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 300, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 300, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 325, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 325, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:30", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 430, 87, 15, 15);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 350, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 350, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 375, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 375, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 400, 50, 75, 75, 30, 290);
            g.DrawPie(drawPen, 400, 50, 75, 75, 30, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 418, 50, 75, 75, 30, 360);
            g.DrawPie(drawPen, 418, 50, 75, 75, 0, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 418, 50, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 50, 75, 75, 120, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 418, 75, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 75, 75, 75, 90, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:40", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 157, 15, 15);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 418, 100, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 100, 75, 75, 120, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:50", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 418, 125, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 125, 75, 75, 90, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:50", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 227, 15, 15);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 418, 150, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 150, 75, 75, 120, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 418, 175, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 175, 75, 75, 90, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 418, 200, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 200, 75, 75, 120, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 418, 225, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 225, 75, 75, 90, 360);
            Thread.Sleep(350);
        
            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:60", drawFont2, drawBrush4, 50, 250);
            g.FillEllipse(drawBrush, 455, 310, 15, 15);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 418, 250, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 250, 75, 75, 120, 290);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:70", drawFont2, drawBrush4, 50, 250);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);
            player.Play();

            //draw pacman
            g.FillPie(drawBrush, 418, 275, 75, 75, 120, 360);
            g.DrawPie(drawPen, 418, 275, 75, 75, 90, 360);
            Thread.Sleep(350);

            g.Clear(Color.Black);

            //draw walls, pac-dots and score
            g.FillRectangle(drawBrush1, 40, 40, 460, 5);
            g.FillRectangle(drawBrush1, 40, 135, 365, 5);
            g.FillRectangle(drawBrush1, 500, 40, 5, 345);
            g.FillRectangle(drawBrush1, 405, 135, 5, 250);
            g.DrawString("Pacman", drawFont, drawBrush, 50, 150);
            g.DrawString("Score:70", drawFont2, drawBrush4, 50, 250);
            g.FillPie(drawBrush, 510, 50, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 50, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 100, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 100, 40, 40, 30, 290);
            g.FillPie(drawBrush, 510, 150, 40, 40, 30, 290);
            g.DrawPie(drawPen, 510, 150, 40, 40, 30, 290);
            g.DrawString("Lives", drawFont2, drawBrush4, 510, 20);

            //draw pacman
            g.FillPie(drawBrush, 418, 300, 75, 75, 120, 290);
            g.DrawPie(drawPen, 418, 300, 75, 75, 120, 290);
            
            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            player3.Play();
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush2, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush2, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush2, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);
            
            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Yellow);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush2, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //winner screen
            g.DrawString("YOU WIN!", drawFont3, drawBrush, 100, 150);
            Thread.Sleep(500);

            g.Clear(Color.Black);

            //End Screen
            g.DrawString("Thanks", drawFont3, drawBrush, 170, 50);
            g.DrawString("For", drawFont3, drawBrush, 275, 150);
            g.DrawString("Playing!", drawFont3, drawBrush, 150, 250);
            player2.Play();
            Thread.Sleep(1800);

            g.Clear(Color.Black);
            Thread.Sleep(200);

            playButton.Visible = true;
            coins.Visible = true;
            pacman.Visible = true;
        }
    }
}

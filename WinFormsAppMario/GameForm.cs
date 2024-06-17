using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppMario
{
    public partial class GameForm : Form
    {
        private Game game;

        public GameForm()
        {
            InitializeComponent();

            game = new Game(pictureBox_Canvas.Width, pictureBox_Canvas.Height);
        }

        private void pictureBox_Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Loop(g);
        }

        private void timer_Game_Tick(object sender, EventArgs e)
        {
            pictureBox_Canvas.Invalidate();
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            //Chceme pohyb
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                game.PlayerInstance.MoveRight();     
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                game.PlayerInstance.MoveLeft();          
            }
            else if(e.KeyCode == Keys.Space || e.KeyCode == Keys.Up)
            {
                game.PlayerInstance.Jump();
            }


        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            //Pohyb vypneme
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                game.PlayerInstance.StopMovement();
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                game.PlayerInstance.StopMovement();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMario
{
    public class Player : GameObject
    {
        private SoundPlayer soundPlayer;

        public uint Score { get; set; } = 0;

        public double SpeedX { get; set; }
        public double SpeedY { get; set; }

        public double Acceleration { get; set; } = 0.5;
        public double JumpSize { get; set; } = 10;

        public double FloorY { get; set; } = 285;

        public bool IsJumping { get; set; } = true;

        public int Width { get; set; } = 60;
        public int Height { get; set; } = 60;

        public Player()
        {
            soundPlayer = new SoundPlayer(Resources.yahoo);
        }

        public void Update()
        {
            //Posouvání po ose X
            PositionX += SpeedX;

            //Posouvání po ose Y
            SpeedY += Acceleration;
            PositionY += SpeedY;

            if (PositionY >= FloorY)
            {
                PositionY = FloorY;
                SpeedY = 0;
                IsJumping = false;
            }
        }

        public void Jump()
        {
            if (!IsJumping)
            {
                SpeedY = -JumpSize;
                IsJumping = true;
            }

            soundPlayer.Play();            
        }

        public void MoveLeft()
        {
            SpeedX = -10;
        }

        public void MoveRight()
        {
            SpeedX = 10;
        }

        public void StopMovement()
        {
            SpeedX = 0;
        }

        public override void Draw(Graphics g)
        {
            Image image = Resources.MarioRight;

            if (SpeedX < 0)
            {
                image = Resources.MarioLeft;
            }

            g.DrawImage(image, (float)this.PositionX, (float)this.PositionY, Width, Height);

        }
    }
}

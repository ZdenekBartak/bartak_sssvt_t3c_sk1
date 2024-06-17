using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMario
{
    public class Coin : GameObject
    {
        public int Width { get; set; } = 25;
        public int Height { get; set; } = 25;
        public override void Draw(Graphics g)
        {
            g.DrawImage(Resources.Coin, (float)this.PositionX, (float)this.PositionY, Width, Height);
        }
    }
}

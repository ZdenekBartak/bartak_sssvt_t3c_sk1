using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMario
{
    public class Background : GameObject
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Resources.Background, (float)this.PositionX, (float)this.PositionY, (float)this.Width, (float)this.Height);
        }
    }
}

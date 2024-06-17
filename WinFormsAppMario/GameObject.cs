using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMario
{
    public abstract class GameObject
    {
        public double PositionX { get; set; }
        public double PositionY { get; set; }

        public abstract void Draw(Graphics g);
    }
}

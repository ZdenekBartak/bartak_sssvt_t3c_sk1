using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMario
{
    public class Scoreboard : GameObject
    {
        public Scoreboard(Player player)
        {
            Player = player;
        }

        public Player Player { get; }

        public override void Draw(Graphics g)
        {
            g.DrawString($"Skóre: {Player.Score}", SystemFonts.DefaultFont, Brushes.Black, 10, 10);
        }
    }
}

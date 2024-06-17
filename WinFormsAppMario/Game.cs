using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppMario
{
    public class Game
    {
        public Player PlayerInstance { get; set; }
        public Background BackgroundInstance { get; set; }
        public Scoreboard ScoreboardInstance { get; set; }

        public List<Coin> CoinsList { get; set; }

        public Game(double worldWidth, double worldHeight)
        {
            //Vytváříme hráče
            PlayerInstance = new Player();
            PlayerInstance.PositionX = worldWidth / 2;
            PlayerInstance.PositionY = worldHeight / 2;

            //Vytvoření pozadí
            BackgroundInstance = new Background();
            BackgroundInstance.PositionX = 0;
            BackgroundInstance.PositionY = 0;
            BackgroundInstance.Width = worldWidth;
            BackgroundInstance.Height = worldHeight;

            //Scoreboard
            ScoreboardInstance = new Scoreboard(PlayerInstance);

            //Vytvoření mincí
            CoinsList = new List<Coin>();

            Coin coin1 = new Coin();
            coin1.PositionX = 200;
            coin1.PositionY = 50;
            CoinsList.Add(coin1);

            Coin coin2 = new Coin();
            coin2.PositionX = 100;
            coin2.PositionY = 200;
            CoinsList.Add(coin2);
        }

        public void Loop(Graphics g)
        {
            //1. Aktualizovat entity - Update
            Update();
            //2. Kolize
            CheckCollision();
            //3. Vykreslit entity - Draw
            Draw(g);
        }

        public void Update()
        {
            PlayerInstance.Update();
        }

        public void CheckCollision()
        {
            foreach (Coin coin in CoinsList)
            {
                //Zjistit kolizi
                bool collision = PlayerInstance.PositionX < coin.PositionX + coin.Width &&
                    PlayerInstance.PositionX + PlayerInstance.Width > coin.PositionX &&
                     PlayerInstance.PositionY < coin.PositionY + coin.Height &&
                    PlayerInstance.PositionY + PlayerInstance.Height > coin.PositionY;
                if (collision)
                {
                    //Přičíst skóre
                    PlayerInstance.Score++;
                }
            }
        }

        public void Draw(Graphics g)
        {
            BackgroundInstance.Draw(g);
            PlayerInstance.Draw(g);

            foreach (Coin coin in CoinsList)
            {
                coin.Draw(g);
            }

            ScoreboardInstance.Draw(g);
        }
    }
}

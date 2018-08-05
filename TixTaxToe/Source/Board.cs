using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TixTaxToe.Source
{
    class Board
    {
        Rectangle[,] Grid = new Rectangle[3, 3];


        public Board()
        {


        }
        public void CreateBoard()
        {
            for (int y = 0; y < Grid.GetLength(1); y++)
            {
                for (int x = 0; x < Grid.GetLength(0); x++)
                {
                    Grid[x, y] = new Rectangle(100 + (64 * x), 100 + (64 * y), 64, 64);

                }

            }


        }

    }
}

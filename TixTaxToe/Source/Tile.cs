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
    class Tile
    {
        public Rectangle Border;
        const int SIZE = 64;
        public Team PTeam = Team.BLANK;
        public Texture2D Image { get; set; }


        public Tile()
        {


        }
    }
    public enum Team
    {
        X,O,BLANK

    }



}

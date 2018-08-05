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
    static class Image
    {

        public static Texture2D XBlock;
        public static Texture2D OBlock;
        public static Texture2D BlankBlock;

        public static SpriteFont Font;



        public static void SetTextures(Game g)
        {
            XBlock = g.Content.Load<Texture2D>("XSprite");
            OBlock = g.Content.Load<Texture2D>("OSprite");
            BlankBlock = g.Content.Load<Texture2D>("BlankSprite");

            Font = g.Content.Load<SpriteFont>("theFont");
        }




    }
}

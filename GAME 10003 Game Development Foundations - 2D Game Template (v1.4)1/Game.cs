// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Drawing");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);
           
            //draw sun

            Color orange = new Color(255, 165, 0);
            Draw.FillColor = orange;
            Draw.Ellipse(-300, 300, 900, 900);

            // draw mercury
            Draw.FillColor = Color.Gray;
            Draw.Ellipse(200, 300, 30, 30);

            //draw venus
            Color paleOrange = new Color(255, 179, 138);
            Draw.FillColor = paleOrange;
            Draw.Ellipse(300, 300, 70, 70);

            //draw earth
            Draw.FillColor = Color.Blue;
            Draw.Ellipse(400, 300, 80, 80);

            //draw mars 
            Color redOrange = new Color(255, 116, 0);
            Draw.FillColor = redOrange;
            Draw.Ellipse(500, 300, 40, 40);

            //draw jupiter
            Color paleYellow = new Color(255, 227, 192);
            Draw.FillColor = paleYellow;
            Draw.Ellipse(700, 300, 300, 300);
        }
    }

}

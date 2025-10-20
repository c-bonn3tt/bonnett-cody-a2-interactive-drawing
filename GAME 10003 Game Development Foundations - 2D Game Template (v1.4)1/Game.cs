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
        float cursorPositionX = Input.GetMouseX();
        float cursorPositionY = Input.GetMouseY();
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Drawing");
            Window.SetSize(800, 600);
            Window.TargetFPS = 60;
        }

        void DrawSun(float x, float y)
        {
            Color orange = new Color(255, 165, 0);
            Draw.FillColor = orange;
            Draw.Ellipse(x, y, 900, 900);
        }
        
        void DrawMercury(float x, float y)
        {
            Draw.FillColor = Color.Gray;
            Draw.Ellipse(x, y, 30, 30);
        }

        void DrawVenus(float x, float y)
        {
            Color paleOrange = new Color(255, 179, 138);
            Draw.FillColor = paleOrange;
            Draw.Ellipse(x, y, 70, 70);
        }

        void DrawEarth(float x, float y)
        {
            Draw.FillColor = Color.Blue;
            Draw.Ellipse(x, y, 80, 80);
        }

        void DrawMars(float x, float y)
        {
            Color redOrange = new Color(255, 116, 0);
            Draw.FillColor = redOrange;
            Draw.Ellipse(x, y, 40, 40);
        }
        void DrawJupiter(float x, float y)
        {
            Color paleYellow = new Color(255, 227, 192);
            Draw.FillColor = paleYellow;
            Draw.Ellipse(x, y, 300, 300);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            //draw sun
            DrawSun(-300, 300);

            // draw mercury
            DrawMercury(200, 300);

            //draw venus
            DrawVenus(300, 300);

            //draw earth
            DrawEarth(400, 300);

            //draw mars 
            DrawMars(500, 300);

            //draw jupiter
            DrawJupiter(700, 300);


            // Position Tracking
            // Input.GetMouseX()
            float[] bounds = {0, 100, 250, 350, 450, 600, 800 };

            //not getting cursor position data and comparing with bounds, cant figure it out
            do
            {
                //DrawSun(Input.GetMouseX(), Input.GetMouseY());
                Draw.FillColor = Color.Green;
                Draw.LineColor = Color.Black;
                Draw.Circle(Input.GetMouseX(), Input.GetMouseY(), 25);
            }
            while (cursorPositionX > bounds[0] && cursorPositionX < bounds[6]);
        }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShapesInheritanceExample
{
    public partial class Form1 : Form
    {
        ArrayList shapes = new ArrayList();
        
                public Form1()
        {
            InitializeComponent();

            //add a few shapes
            shapes.Add(new Circle(Color.Purple, 10, 100, 100)); //create a red circle at (10,100) of radius 100
            shapes.Add(new Circle(Color.Chartreuse, 100, 10, 50)); //apparently it's green
            shapes.Add(new Rectangle(Color.Blue, 150, 150, 50, 100));
            shapes.Add(new Square(Color.Green, 175, 50, 75));
            shapes.Add(new Circle(Color.Red, 10, 100, 100));


            //add some random shapes
            Random rand = new Random(77887);
            for (int i=0; i<150; i++)
            {
                int x = rand.Next(Size.Width);
                int y = rand.Next(Size.Height);
                int size = rand.Next(250);

                int red = rand.Next(255);
                int green = rand.Next(255);
                int blue = rand.Next(255);

                Color newColour = Color.FromArgb(128, red, green, blue); //128 is semi transparent

                int shape = rand.Next(4);

                switch(shape)
                {
                    case 0 :
                        shapes.Add(new Circle(newColour, x, y, size));
                        break;
                    case 1:
                        shapes.Add(new Square(newColour, x, y, size));
                        break;
                    case 2:
                        shapes.Add(new Rectangle(newColour, x, y, size, size/2));
                        break;
                   /* case 4: could add another shape
                        shapes.Add(new Triangle(newColour, x, y, size));
                        break;*/


                }
            }
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("paint called");
            Graphics g = e.Graphics;
         

            for (int i = 0; i<shapes.Count; i++)
            {
                Shape s;
                s =  (Shape) shapes[i];
                s.draw(g);
                Console.WriteLine(s.ToString());

            }
        }
    }
}



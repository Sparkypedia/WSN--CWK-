using Gtk;
using System;
using System.Drawing;

namespace GtkSharpTutorial {

 
 
        public class frame
        {

                static void delete_event (object obj,DeleteEventArgs args)
                {
                Application.Quit();
                }
 
                public static void Main( string[] args)
                {
 
                        /* Initialise GTK */
                        Application.Init();
                        /* Create a new window */
                        Window window = new Window ("Drawing Attempt");
                        window.DeleteEvent += delete_event;
 
                        window.SetSizeRequest(800, 800);
                        window.BorderWidth= 10;
 
                        /* Create a Frame */
                        Frame frame = new Frame("MyFrame");
                        window.Add(frame);
 
                        /* Set & Align frame's label */
                        frame.Label = "My Framed Box";
						frame.LabelXalign = ((float)0.5);
						frame.LabelYalign = ((float)0.5);
						frame.ShadowType = (ShadowType.Out);
 
                        frame.Show();
                        window.ShowAll();
                        Application.Run();
 
                }
 
        }
 
}
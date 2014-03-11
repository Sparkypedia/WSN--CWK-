using Gtk;
using System;
using System.Drawing;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		SetDefaultSize(800,600);
		AlexsBox.SetSizeRequest(500,500);
		Draw ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	public void Draw()
     {
		AlexsBox_lbl.Text = ("Room");
		AlexsBox.Move(AlexsBox_lbl,230,5);
		//ScaleImage.Pixbuf.ScaleSimple(10,10, Gdk.InterpType.Nearest);
		//AlexsBox.

		AlexsBox.Move(Mote1_img, 0, 100);
		AlexsBox.Move(Mote2_img, 400, 100);
		AlexsBox.Move(Mote3_img, 230, 400);
     }
	
}
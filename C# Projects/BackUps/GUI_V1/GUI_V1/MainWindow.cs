using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		int a,b,c;
		a=Convert.ToInt32(Entry1.text);
		b=Convert.ToInt32(Entry2.text);
		c=a+b;
		Label1.text=c;
	}

}

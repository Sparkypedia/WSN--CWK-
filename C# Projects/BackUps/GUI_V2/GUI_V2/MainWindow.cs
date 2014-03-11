using System;
using Gtk;
using Microsoft.CSharp;


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

	//This calculates the size of the test area
	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		Decimal a, b, c;
		if (TALength_txtbox.Text == "") 
		{} 
		else if (TAWidth_txtbox.Text == "") 
		{}
		else
		{
			a = Convert.ToDecimal (TALength_txtbox.Text);
			b = Convert.ToDecimal (TAWidth_txtbox.Text);
			c = a * b;
			TotArea_lbl.Text = c.ToString ();
		}
	}	

	//This resets all txtbox's & labels
	protected void OnResetBtnClicked (object sender, EventArgs e)
	{
		TALength_txtbox.Text="";
		TAWidth_txtbox.Text="";
		TotArea_lbl.Text="";
	}	

	protected void OnBeginClicked (object sender, EventArgs e)
	{
		TotArea_lbl.Text="1";
		label2.Xalign=200;
		label2.Yalign=100;
	}

	
}

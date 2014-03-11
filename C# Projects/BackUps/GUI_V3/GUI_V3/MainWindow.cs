using System;
using System.IO;
using System.IO.Ports;
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

	//Resets all labels and text boxes
	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		TotArea_lbl.Text = "";
		mote1_lbl.Text = "";
		mote2_lbl.Text = "";
		mote3_lbl.Text = "";
		ALength_txtbox.Text = "";
		AWidth_txtbox.Text = "";
		M1X_txtbox.Text = "";
		M1Y_txtbox.Text = "";
		M2X_txtbox.Text = "";
		M2Y_txtbox.Text = "";
		M3X_txtbox.Text = "";
		M3Y_txtbox.Text = "";
		Status_lbl.Text = "Waiting...";
	}	

	//Calculates total area and sets mote coordinates
	protected void OnConfigureBtnActivated (object sender, EventArgs e)
	{
		if (AWidth_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter an area width";
		}
		else if (ALength_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter an area length";
		}
		else if (M1X_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter the X coordinate for mote No.1 ";
		}
		else if (M1Y_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter the Y coordinate for mote No.1 ";
		}
		else if (M2X_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter the X coordinate for mote No.2 ";
		}
		else if (M2Y_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter the Y coordinate for mote No.2 ";
		}
		else if (M3X_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter the X coordinate for mote No.3 ";
		}
		else if (M3Y_txtbox.Text == "")
		{
			Status_lbl.Text = "Please enter the Y coordinate for mote No.3 ";
		}
		else
		{
		Decimal a, b, c;
		string d;
		
		//Calculate total Area
		a = Convert.ToDecimal (AWidth_txtbox.Text);
		b = Convert.ToDecimal (ALength_txtbox.Text);
		c = a * b;
		TotArea_lbl.Text = c.ToString ();

		//Calcualte mote No.1 coordinates
		a = Convert.ToDecimal (M1X_txtbox.Text);
		b = Convert.ToDecimal (M1Y_txtbox.Text);
		d = a.ToString() + "," + b.ToString();
		mote1_lbl.Text = d;

		//Calcualte mote No.2 coordinates
		a = Convert.ToDecimal (M2X_txtbox.Text);
		b = Convert.ToDecimal (M2Y_txtbox.Text);		
		d = a.ToString() + "," + b.ToString();
		mote2_lbl.Text = d;
		
		//Calcualte mote No.3 coordinates
		a = Convert.ToDecimal (M3X_txtbox.Text);
		b = Convert.ToDecimal (M3Y_txtbox.Text);
		d = a.ToString() + "," + b.ToString();
		mote3_lbl.Text = d;
		}
}
	protected void OnMediaStopAction1Activated (object sender, EventArgs e)
	{
		throw new System.NotImplementedException ();
	}

	protected void OnMediaPlayActionActivated (object sender, EventArgs e)
	{
		throw new System.NotImplementedException ();
	}



}
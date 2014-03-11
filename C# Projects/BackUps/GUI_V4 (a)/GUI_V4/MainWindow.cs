using System;
using System.IO.Ports;
using Gtk;
using System.Timers;

public partial class MainWindow: Gtk.Window
{	
	//Setting up Timers & Serial Port
	private SerialPort listen = new SerialPort("/dev/ttyUSB0",115200);
	private static System.Timers.Timer aTimer = new System.Timers.Timer();

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	//Configuration Button
	protected void OnPropertiesActionActivated (object sender, EventArgs e)
	{
		if (Awidth_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter an area width";
		}
		else if (Alength_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter an area length";
		}
		else if (M1X_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter the X coordinate for mote No.1 ";
		}
		else if (M1Y_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter the Y coordinate for mote No.1 ";
		}
		else if (M2X_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter the X coordinate for mote No.2 ";
		}
		else if (M2Y_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter the Y coordinate for mote No.2 ";
		}
		else if (M3X_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter the X coordinate for mote No.3 ";
		}
		else if (M3Y_txtbx.Text == "")
		{
			Status_lbl.Text = "Please enter the Y coordinate for mote No.3 ";
		}
		else
		{
		Decimal a, b, c;
		string d;
		
		//Calculate total Area
		a = Convert.ToDecimal (Awidth_txtbx.Text);
		b = Convert.ToDecimal (Alength_txtbx.Text);
		c = a * b;
		TotalArea_lbl.Text = (c.ToString() + "cm");

		//Calcualte mote No.1 coordinates
		a = Convert.ToDecimal (M1X_txtbx.Text);
		b = Convert.ToDecimal (M1Y_txtbx.Text);
		d = a.ToString() + "," + b.ToString();
		M1Co_lbl.Text = d;

		//Calcualte mote No.2 coordinates
		a = Convert.ToDecimal (M2X_txtbx.Text);
		b = Convert.ToDecimal (M2Y_txtbx.Text);		
		d = a.ToString() + "," + b.ToString();
		M2Co_lbl.Text = d;
		
		//Calcualte mote No.3 coordinates
		a = Convert.ToDecimal (M3X_txtbx.Text);
		b = Convert.ToDecimal (M3Y_txtbx.Text);
		d = a.ToString() + "," + b.ToString();
		M3Co_lbl.Text = d;
		}
	}	

	//Reset Button
	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		Status_lbl.Text = ("Waiting...");
		data_lbl.Text = ("Waiting for data...");
		TotalArea_lbl.Text = ("....cm");
		M1Co_lbl.Text = ("--,--");
		M2Co_lbl.Text = ("--,--");
		M3Co_lbl.Text = ("--,--");
		Alength_txtbx.Text = ("");
		Awidth_txtbx.Text = ("");
		M1X_txtbx.Text = ("");
		M1Y_txtbx.Text = ("");
		M2X_txtbx.Text = ("");
		M2Y_txtbx.Text = ("");
		M3X_txtbx.Text = ("");
		M2Y_txtbx.Text = ("");
	}	

	//Run Button
	protected void OnMediaPlayActionActivated (object sender, EventArgs e)
	{
	}	

	//Stop Button
	protected void OnMediaStopActionActivated (object sender, EventArgs e)
	{
		if (aTimer.Enabled == true) 
		{
			aTimer.Enabled = false;
			listen.Close();
		}
		Status_lbl.Text = ("Port Closed");
	}

	//Test Button
	protected void OnDialogQuestionActionActivated (object sender, EventArgs e)
	{
		aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
		aTimer.Interval = 1000;
    	aTimer.Enabled=true; 
	}

	public void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			String a = data_lbl.Text;

      		//listen.PortName = "/dev/ttyUSB0";
       		// listen.BaudRate = 115200;
       		// listen.Parity = ;
       		// listen.DataBits = ;
       		// listen.StopBits = ;
       		// listen.Handshake = 

     		if (listen != null)
     			{
        			 if (listen.IsOpen)
         				{
               				listen.Close();
            	 		}
      			}
				
      		listen.Open();
			Status_lbl.Text = ("Port Open");
			data_lbl.Text = (a + "\n" + listen.ReadByte());
 		}

}

using System;
using System.IO.Ports;
using Gtk;
using System.Timers;
using System.Collections;

public partial class MainWindow: Gtk.Window
{	

	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
		//Starts Clock Timer
		AnimationDisplay.Move(M1_img, 250, 50);
		AnimationDisplay.Move(M2_img, 250, 250);
		AnimationDisplay.Move(M3_img, 250, 450);
		AnimationDisplay.Move(ZeroZero_lbl, 0, 0);
	
		ClockTimer.Elapsed += new ElapsedEventHandler(OnClockTimerEvent);
		ClockTimer.Interval = 1000;
    	ClockTimer.Enabled=true;
	}

	//Configuration Button
	protected void OnPropertiesActionActivated (object sender, EventArgs e)
	{
		if (LW_txtbx.Text == "")
		{
			Status_lbl.Text = "Please Enter The Length & Width";
		}
		else if (M1XY_txtbx.Text == "")
		{
			Status_lbl.Text = "Please Enter The Coordinates For Mote No.1 ";
		}
		else if (M2XY_txtbx.Text == "")
		{
			Status_lbl.Text = "Please Enter The Coordinates For Mote No.2 ";
		}
		else if (M3XY_txtbx.Text == "")
		{
			Status_lbl.Text = "Please Enter The Coordinates For Mote No.3 ";
		}
		else
		{
		string areaA, CoordinatesA;
		string[] areaB, CoordinatesB, CoordinatesC, CoordinatesD;
		
		//Calculate total Area
		areaA = LW_txtbx.Text.ToString();
		areaB = areaA.Split(',');
		area_width = Convert.ToInt16 (areaB[0]);
		area_length = Convert.ToInt16 (areaB[1]);
		TotalArea_lbl.Text= ((area_width * area_length).ToString() + "cm");

		//Calcualte mote No.1 coordinates
		CoordinatesA = M1XY_txtbx.Text.ToString();
		CoordinatesB = CoordinatesA.Split(',');
		M1X = Convert.ToInt16 (CoordinatesB[0]);
		M1Y = Convert.ToInt16 (CoordinatesB[1]);

		//Calcualte mote No.2 coordinates
		CoordinatesA = M2XY_txtbx.Text.ToString();
		CoordinatesC = CoordinatesA.Split(',');
		M2X = Convert.ToInt16 (CoordinatesC[0]);
		M2Y = Convert.ToInt16 (CoordinatesC[1]);
		
		//Calcualte mote No.3 coordinates
		CoordinatesA = M3XY_txtbx.Text.ToString();
		CoordinatesD = CoordinatesA.Split(',');
		M3X = Convert.ToInt16 (CoordinatesD[0]);
		M3Y = Convert.ToInt16 (CoordinatesD[1]);

		ConfigAnimation();
		}
	}	

	//Reset Button
	protected void OnRefreshActionActivated (object sender, EventArgs e)
	{
		Status_lbl.Text = ("Waiting...");
		data_lbl.Text = ("Waiting for data...");
		TotalArea_lbl.Text = (".......cm");
		LW_txtbx.Text = ("");
		M1XY_txtbx.Text = ("");
		M2XY_txtbx.Text = ("");
		M3XY_txtbx.Text = ("");
		buffersize_lbl.Text = ("##");
		bytestoread_lbl.Text = ("##");
		Sim_txtbx.Text = ("");
	}	

	//Run Button
	/// Opens the serial port, starts the serial timer setting the interval to 1 sec
	protected void OnMediaPlayActionActivated (object sender, EventArgs e)
	{
				  /* ArrayList Buf = new ArrayList ();
				 int NoBytes = 0;
				 listen.PortName = "/dev/ttyUSB0";
				 listen.BaudRate = 115200;
				 listen.Parity = ;
				 listen.DataBits = ;
				 listen.StopBits = ;
				 listen.Handshake = */

		if (listen != null) 
			{
				if (listen.IsOpen) 
						{
							listen.Close ();
						}
			}
		listen.Open ();
		Status_lbl.Text = ("Port Open");
		SerialTimer.Elapsed += new ElapsedEventHandler(OnSerialTimerEvent);
		SerialTimer.Interval = 10;
    	SerialTimer.Enabled=true; 
	}	

	///Stop Button
	protected void OnMediaStopActionActivated (object sender, EventArgs e)
	{
		if (SerialTimer.Enabled == true) 
		{
			SerialTimer.Enabled = false;
			listen.Close();
		}
		Status_lbl.Text = ("Port Closed");
	}

	//Simulate Input Button
	protected void OnSimBtnActivated (object sender, EventArgs e)
	{
			
	}

}

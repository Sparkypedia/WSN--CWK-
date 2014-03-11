using System;
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

	//Configuration Button
	protected void OnPropertiesActionActivated (object sender, EventArgs e)
	{
		data_lbl.Text = ("Configured");
	}	

	//Play Button
	protected void OnMediaPlayActionActivated (object sender, EventArgs e)
	{
		Serial(null);
	}


	public static void Serial(string[] args)
   	{
      	SerialPort listen = new SerialPort("/dev/ttyUSB0", 115200);

     	if (listen != null)
     		{
        		 if (listen.IsOpen)
         			{
              		 	listen.Close();
						Console.WriteLine("Resetting Port");
            		}
      		 }
				
      	listen.Open();
		Console.WriteLine("Opening Port");

      	while(true)
      		{      
         		Console.WriteLine(listen.ReadLine());
      		}
 	}

}
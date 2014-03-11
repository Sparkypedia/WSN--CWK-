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


	protected void OnButton1Clicked (object sender, EventArgs e)
	{
		Serial();
	}

	public static void Serial()
   		{
      		SerialPort listen = new SerialPort();

        listen.PortName = "/dev/ttyUSB0";
        listen.BaudRate = 115200;
       // listen.Parity = ;
       // listen.DataBits = ;
       // listen.StopBits = ;
       // listen.Handshake = ;

			Console.WriteLine("Connected to /dev/tty/USB0 with a baud rate of 115200");


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
         		Console.WriteLine(listen.ReadByte());
      		}
 		}


	
}

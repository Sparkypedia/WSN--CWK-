using System;
using System.IO.Ports;
using Gtk;
using System.Timers;


public partial class MainWindow: Gtk.Window
{	
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

	public void OnTimedEvent(object source, ElapsedEventArgs e)
 {
		 string a = label2.Text;

		//label2.Text = (a + "\n" + "Hello World");

		//SerialPort listen = new SerialPort();

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
					//Console.WriteLine("Resetting Port");
            	 }
      			 }
				
      		listen.Open();
			//Console.WriteLine("Opening Port");
			label2.Text = (a + "\n" + listen.ReadByte());
 }

	//Runbutton
	protected void OnTogglebutton1Clicked (object sender, EventArgs e)
	{
	aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
	aTimer.Interval = 1000;
    aTimer.Enabled=true; 
	}

	//Stop Button
		protected void OnStopBtnClicked (object sender, EventArgs e)
	{
		aTimer.Enabled=false;
	}

	public static void Serial()
   		{
      		SerialPort listen = new SerialPort();

       // listen.PortName = "/dev/ttyUSB0";
       // listen.BaudRate = 115200;
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

	protected void OnResetBtnClicked (object sender, EventArgs e)
	{
		label2.Text =  "---";
	}
	
}










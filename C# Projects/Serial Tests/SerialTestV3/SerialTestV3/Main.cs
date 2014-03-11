using System;
using System.IO.Ports;
using Gtk;

namespace SerialTestV3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}

/*	class SerialClass
	{
		public static void Serial()
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

*/
}

/*
 * using System;
using System.IO.Ports;

namespace serial_test
{
	class MainClass
	{
		public static void Main()
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
}
 * 
 * 
 * 
 * 
 * 
 * /
using System;
using System.IO.Ports;

class PortDataReceived
{


    public static void Main()
	{
			SerialPort listen = new SerialPort("/dev/ttyUSB0",115200);
		 if (listen != null)
     			 {
        			 if (listen.IsOpen)
         		 {
               		listen.Close();
					//Console.WriteLine("Resetting Port");
            	 }
      			 }
				
      		listen.Open();
listen.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        Console.WriteLine("Waiting");
    }

    private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
    {
        
        Console.WriteLine(listen.ReadByte());

    }
}
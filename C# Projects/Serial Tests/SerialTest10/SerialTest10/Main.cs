using System;
using System.IO.Ports;

class PortDataReceived
{
    public static void Main()
    {
        SerialPort listen = new SerialPort("/dev/ttyUSB0",115200);

        listen.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

        listen.Open();

        Console.WriteLine("Press any key to continue...");
        Console.WriteLine();
        Console.ReadKey();
        listen.Close();
    }

    private static void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
    {
        SerialPort sp = (SerialPort)sender;
        string indata = sp.ReadExisting();
        Console.WriteLine("Data Received:");
        Console.Write(indata);
    }
}
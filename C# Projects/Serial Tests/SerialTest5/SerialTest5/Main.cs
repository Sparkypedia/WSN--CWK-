using System;
using System.IO.Ports;

public class PortChat
{
    static SerialPort _serialPort;

    public static void Main()
    {

        _serialPort = new SerialPort();

       // Allow the user to set the appropriate properties.
        _serialPort.PortName = "/dev/ttyUSB0";
        _serialPort.BaudRate = 115200;
       // _serialPort.Parity = SetPortParity(_serialPort.Parity);
       // _serialPort.DataBits = SetPortDataBits(_serialPort.DataBits);
       // _serialPort.StopBits = SetPortStopBits(_serialPort.StopBits);
       // _serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

		if (_serialPort != null)
			{
				if (_serialPort.IsOpen)
					{
						_serialPort.Close();
						Console.WriteLine("Resetting Port");
					}
			}

		_serialPort.Open();
		Console.WriteLine("Opening Port");

		while(true)
			{
				Console.WriteLine(_serialPort.ReadByte());
			}
	}
}

 
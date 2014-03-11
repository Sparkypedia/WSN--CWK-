using System;
using System.IO.Ports;
using Gtk;
using System.Timers;
using System.Collections;

public partial class MainWindow: Gtk.Window
	{
		public Boolean BusyWarning = false;

		//public ArrayList ByteBuffer = new ArrayList();

		/// <summary>
		/// Take a reading from serial port....
		public void OnSerialTimerEvent (object source, ElapsedEventArgs e)
	{

				 	

		//To stop the system making lots of seperate threads the BusyWarning allows an action to be aborted if the previous action has not yet finished
		if (BusyWarning == true) {
			//Do Nothing.....
		} else {

			BusyWarning = true;
			String a = data_lbl.Text;
			String signal = "";
			buffersize_lbl.Text = (listen.ReadBufferSize.ToString ());
			bytestoread_lbl.Text = (listen.BytesToRead.ToString ());

			//NoBytes = (listen.BytesToRead);
			//bytestoread_lbl.Text = NoBytes.ToString(); 

			/*	foreach ( in Buf) 
									{

									}
									listen.Read (Buff, 10, 10);
									BuffLength = (Buff.Length);
									NoBytesinSingnal_lbl.Text = BuffLength.ToString();  */

			/*	while (i < BuffLength) 
									{
										a = data_lbl.Text;
										data_lbl.Text = (a + "\n" + Buff[i] + " ");
										i = (i + 1);
									}
							//listen.Read(byte[] buffer, 0, 12);  */

			//Grab 11 bytes from the serial port buffer and put them into an int[]
			//We need to ensure that the byte packet starts with 00 255

			int testcondition = 0;
			//int errorcondition = 0;
			int[] ByteBuffer = new int[12];
			for (int i = 0; i < ByteBuffer.Length; i++)
			{
				if (testcondition == 0) {
					int ByteTest1 = listen.ReadByte ();
					int ByteTest2 = listen.ReadByte ();
					int ByteTest3 = listen.ReadByte ();
									
					if (ByteTest1 == 00 & ByteTest2 == 255 & ByteTest3 == 255) {
						testcondition = 1;
						ByteBuffer [i] = ByteTest1;
						i = (i + 1);
						ByteBuffer [i] = ByteTest2;
						i = (i + 1);
						ByteBuffer [i] = ByteTest3;

											
					} else {
						//errorcondition = 1;
						//break;
						i = (i - 1);
					}
							
				}
				if (testcondition == 1) {
					ByteBuffer [i] = listen.ReadByte ();
				}
			}

//						if (errorcondition == 1)
//							{
//								BusyWarning = false;
//							}
//						else
//							{

			// convert each element in the int[] into a 2 figure hex represenation 
			// then place each hex value into a " " seperated string "signal" 
			foreach (int i in ByteBuffer) {
				int dec = i;
				string hex = dec.ToString ("X2");
				signal = (signal + hex + " ");
			}
			data_lbl.Text = (a + "\n" + signal);
			BusyWarning = false;
		}
	}

						/* now to check that the signal starts with 00 ff...
							string[] SignalCheck = signal.Split (' ');

							if (SignalCheck [1] == "00" & SignalCheck [2] == "ff") 
							{
								data_lbl.Text = (a + "\n" + signal);
							} 
							else 
							{
								data_lbl.Text = (SignalCheck[1] + " " + SignalCheck[2]);
							}
					*/

						/*		
							if (h1 == "00") 
								{
									if (a == "Waiting for data...")
										{
											data_lbl.Text = ("Packet: " + b1 + " " + b2 + b3 + " " + b4 + " " + b5 + " " + b6 + " " + b7 + " " + b8 + " " + b9 + " " + b10 + " " + b11 + " " + b12);
										} 
									else 
										{
									data_lbl.Text = (a + "\n" + "Packet: " + b1 + " " + b2 + b3 + " " + b4 + " " + b5 + " " + b6 + " " + b7 + " " + b8 + " " + b9 + " " + b10 + " " + b11 + " " + b12);
										}  
								} 
							else 
								{
									data_lbl.Text = (a + "\n" + "Packet Ignored");
								} */
						//listen.DiscardInBuffer = true;
						//listen.DiscardOutBuffer = true;
						//.ReadExisting
						//.ReadByte
						//.ReadLine  
							
		/*	private void DataReceivedHandler (object sender, SerialDataReceivedEventArgs e)
			{
			string a = data_lbl.Text;
			SerialPort sp = (SerialPort)sender;
			string indata = sp.ReadExisting ();
			data_lbl.Text = (a + "\n" + indata);
			}  */
   			

		/// <summary>
		/// Update clock readout

		public void OnClockTimerEvent (object source, ElapsedEventArgs e)
			{
				Time_lbl.Text = DateTime.Now.ToString("h:mm:ss tt");
			}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
			{
				Application.Quit ();
				a.RetVal = true;
			}
}

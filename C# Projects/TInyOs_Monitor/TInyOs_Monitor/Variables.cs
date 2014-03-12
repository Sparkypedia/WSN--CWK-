using System;
using System.IO.Ports;
using Gtk;
using System.Timers;
using System.Collections;

public partial class MainWindow: Gtk.Window
	{

	//Setting up Timers & Serial Port
	private SerialPort listen = new SerialPort("/dev/ttyUSB0",115200);
	private static System.Timers.Timer SerialTimer = new System.Timers.Timer();
	private static System.Timers.Timer ClockTimer = new System.Timers.Timer();

	//Position Buffers
	Int16 area_width, area_length, M1X, M1Y, M2X, M2Y, M3X, M3Y;
	Int32 area_width_75, area_length_75, M1X_75, M1Y_75, M2X_75, M2Y_75, M3X_75, M3Y_75;

	//Percentage Dimension Reduction
	int percentage = 75;
		
	}

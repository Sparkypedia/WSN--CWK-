using System;
using System.IO.Ports;
using Gtk;
using System.Timers;
using System.Collections;

public partial class MainWindow: Gtk.Window
	{

		public void ConfigAnimation ()
		{
			/* Animation Window Limitations
			 ****************************** 
			 * Real dimensions = 600x600
			 * however dish images = 100x100
			 * 
			 * Hence:	Dish X limits = 0 & 500
			 * 			Dish Y limits = 0 & 500
			 * 
			*/

			if (area_width + area_length + M1X + M1Y + M2X + M2Y + M3X + M3Y != 0) 	
			{
				//Scale dimensions down to 75% of oringal and ensure they do not go over/under thresholds
				decimal buf;

				buf = ((area_width/100)*percentage);
				area_width_75 = Convert.ToInt32(buf);
				buf = ((area_length/100)*percentage);
				area_length_75 = Convert.ToInt32(buf);

				buf = ((M1X/100)*percentage);
				M1X_75 = Convert.ToInt32(buf);
				buf = ((M1Y/100)*percentage);
				M1Y_75 = Convert.ToInt32(buf);
				if (M1X_75 <= 30){M1X_75 = 30;}
				if (M1X_75 >= 500){M1X_75 = 500;}
				if (M1Y_75 <= 30){M1Y_75 = 30;}
				if (M1Y_75 >= 500){M1Y_75 = 500;}

				buf = ((M2X/100)*percentage);
				M2X_75 = Convert.ToInt32(buf);
				buf = ((M2Y/100)*percentage);
				M2Y_75 = Convert.ToInt32(buf);
				if (M2X_75 <= 30){M2X_75 = 30;}
				if (M2X_75 >= 500){M2X_75 = 500;}
				if (M2Y_75 <= 30){M2Y_75 = 30;}
				if (M2Y_75 >= 500){M2Y_75 = 500;}

				buf = ((M3X/100)*percentage);
				M3X_75 = Convert.ToInt32(buf);
				buf = ((M3Y/100)*percentage);
				M3Y_75 = Convert.ToInt32(buf);
				if (M3X_75 <= 30){M3X_75 = 30;}
				if (M3X_75 >= 500){M3X_75 = 500;}
				if (M3Y_75 <= 30){M3Y_75 = 30;}
				if (M3Y_75 >= 500){M3Y_75 = 500;}

			
				AnimationDisplay.Move(M1_img, M1X_75, M1Y_75);
				AnimationDisplay.Move(M2_img, M2X_75, M2Y_75);
				AnimationDisplay.Move(M3_img, M3X_75, M3Y_75);
				//data_lbl.Text = ("Width: " + area_width_75 + " Length: " + area_length_75 + " M1X: " + M1X_75 + " M1Y: " + M1Y_75 + " M2X: " + M2X_75 + " M2Y: " + M2Y_75 + " M3X: " + M3X_75 + " M3Y: " + M3Y_75);
				Status_lbl.Text = ("Updated");


			}
			else
			{
				Status_lbl.Text = ("You need to enter dimensions");
			}
		}
		
	}
	
using System;
using System.IO.Ports;

class MainClass
{  
   public static void Main(string[] args)
   {
      SerialPort sport = new SerialPort("/dev/ttyUSB0", 9600);

      if (sport != null)
      {
         if (sport.IsOpen)
            {
               sport.Close();
            }
      }

      Console.WriteLine("Serial Test");

      sport.Open();

      while(true)
      {      
         Console.WriteLine(sport.ReadLine());
      }
   }

}
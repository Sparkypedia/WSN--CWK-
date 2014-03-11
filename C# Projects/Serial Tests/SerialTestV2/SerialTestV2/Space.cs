
/*public static void Serial(string[] args)
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
 	}*/


/*public class TreeView
{
	public static void Main ()
	{
		Gtk.Application.Init ();
		new TreeView ();
		Gtk.Application.Run ();
	}
 
	public TreeView ()
	{
		// Create a Window
		Gtk.Window window = new Gtk.Window ("TinyOs Monitor");
		window.SetSizeRequest (500,200);
 
		// Create our TreeView
		Gtk.TreeView tree = new Gtk.TreeView ();
 
		// Add our tree to the window
		window.Add (tree);

 
		// Create a column for the Cycles
		Gtk.TreeViewColumn CycleColumn = new Gtk.TreeViewColumn ();
		CycleColumn.Title = "Cycle"; 
		// Create the text cell that will display the Cycles
		Gtk.CellRendererText CycleCell = new Gtk.CellRendererText ();
		// Add the cell to the column
		CycleColumn.PackStart (CycleCell, true);

 
		// Create a column for the Packets
		Gtk.TreeViewColumn PacketColumn = new Gtk.TreeViewColumn ();
		PacketColumn.Title = "Packet";
		// Create the text cell that will display the Packets
		Gtk.CellRendererText PacketCell = new Gtk.CellRendererText ();
		// Add the cell to the column
		PacketColumn.PackStart (PacketCell, true);
 
		// Add the columns to the TreeView
		tree.AppendColumn (CycleColumn);
		tree.AppendColumn (PacketColumn);
		// Tell the Cell Renderers which items in the model to display
		CycleColumn.AddAttribute (CycleCell, "text", 0);
		PacketColumn.AddAttribute (PacketCell, "text", 1);
 
		// Create a model that will hold two strings - Artist Name and Song Title
		Gtk.ListStore PacketList = new Gtk.ListStore (typeof (string), typeof (string));
 
		// Add some data to the store
		PacketList.AppendValues ("1", "1011");
 
		// Assign the model to the TreeView
		tree.Model = PacketList;
 
		// Show the window and everything on it
		window.ShowAll ();
	}
}

*/
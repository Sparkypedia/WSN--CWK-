/*using System;

namespace SerialTestV2
{
	public class Treeviewclass
	{
		public Treeviewclass ()

		{

		Gtk.treeview tree = MainWindow.
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
		AppendColumn (CycleColumn);
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
		}
	}
}

*/
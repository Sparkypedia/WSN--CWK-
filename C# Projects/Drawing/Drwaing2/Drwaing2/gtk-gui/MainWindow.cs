
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Fixed AlexsBox;
	private global::Gtk.Label AlexsBox_lbl;
	private global::Gtk.Image Mote1_img;
	private global::Gtk.Image Mote3_img;
	private global::Gtk.Image Mote2_img;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Statusbar statusbar1;
	private global::Gtk.Label label8;
	private global::Gtk.Label status_lbl;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		this.Resizable = false;
		this.AllowGrow = false;
		this.DefaultWidth = 500;
		this.DefaultHeight = 500;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.AlexsBox = new global::Gtk.Fixed ();
		this.AlexsBox.WidthRequest = 500;
		this.AlexsBox.HeightRequest = 500;
		this.AlexsBox.Name = "AlexsBox";
		this.AlexsBox.HasWindow = false;
		// Container child AlexsBox.Gtk.Fixed+FixedChild
		this.AlexsBox_lbl = new global::Gtk.Label ();
		this.AlexsBox_lbl.Name = "AlexsBox_lbl";
		this.AlexsBox_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Title");
		this.AlexsBox.Add (this.AlexsBox_lbl);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.AlexsBox [this.AlexsBox_lbl]));
		w1.X = 197;
		w1.Y = 54;
		// Container child AlexsBox.Gtk.Fixed+FixedChild
		this.Mote1_img = new global::Gtk.Image ();
		this.Mote1_img.Name = "Mote1_img";
		this.Mote1_img.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Drwaing2.antenna_parabolasmaller.png");
		this.AlexsBox.Add (this.Mote1_img);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.AlexsBox [this.Mote1_img]));
		w2.X = 33;
		w2.Y = 340;
		// Container child AlexsBox.Gtk.Fixed+FixedChild
		this.Mote3_img = new global::Gtk.Image ();
		this.Mote3_img.Name = "Mote3_img";
		this.Mote3_img.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Drwaing2.antenna_parabolasmaller.png");
		this.AlexsBox.Add (this.Mote3_img);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.AlexsBox [this.Mote3_img]));
		w3.X = 327;
		w3.Y = 309;
		// Container child AlexsBox.Gtk.Fixed+FixedChild
		this.Mote2_img = new global::Gtk.Image ();
		this.Mote2_img.Name = "Mote2_img";
		this.Mote2_img.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("Drwaing2.antenna_parabolasmaller.png");
		this.AlexsBox.Add (this.Mote2_img);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.AlexsBox [this.Mote2_img]));
		w4.X = 156;
		w4.Y = 239;
		this.hbox3.Add (this.AlexsBox);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.AlexsBox]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		this.hbox3.Add (this.vbox2);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox2]));
		w6.Position = 1;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Status:");
		this.statusbar1.Add (this.label8);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.label8]));
		w8.Position = 1;
		w8.Expand = false;
		w8.Fill = false;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.status_lbl = new global::Gtk.Label ();
		this.status_lbl.Name = "status_lbl";
		this.status_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Waiting...");
		this.statusbar1.Add (this.status_lbl);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.status_lbl]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w10.Position = 1;
		w10.Expand = false;
		w10.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
	}
}

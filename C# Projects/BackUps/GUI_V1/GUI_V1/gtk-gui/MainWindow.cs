
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed Container1;
	private global::Gtk.Entry entry1;
	private global::Gtk.Entry entry2;
	private global::Gtk.Button button1;
	private global::Gtk.Label label1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.Container1 = new global::Gtk.Fixed ();
		this.Container1.Name = "Container1";
		this.Container1.HasWindow = false;
		// Container child Container1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry ();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '•';
		this.Container1.Add (this.entry1);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.Container1 [this.entry1]));
		w1.X = 42;
		w1.Y = 147;
		// Container child Container1.Gtk.Fixed+FixedChild
		this.entry2 = new global::Gtk.Entry ();
		this.entry2.CanFocus = true;
		this.entry2.Name = "entry2";
		this.entry2.IsEditable = true;
		this.entry2.InvisibleChar = '•';
		this.Container1.Add (this.entry2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.Container1 [this.entry2]));
		w2.X = 265;
		w2.Y = 144;
		// Container child Container1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("GtkButton");
		this.Container1.Add (this.button1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.Container1 [this.button1]));
		w3.X = 495;
		w3.Y = 145;
		// Container child Container1.Gtk.Fixed+FixedChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.Container1.Add (this.label1);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.Container1 [this.label1]));
		w4.X = 252;
		w4.Y = 231;
		this.Add (this.Container1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 700;
		this.DefaultHeight = 539;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button1.Clicked += new global::System.EventHandler (this.OnButton1Clicked);
	}
}
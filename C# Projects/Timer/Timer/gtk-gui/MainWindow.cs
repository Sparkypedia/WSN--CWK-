
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.HBox hbox1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.Label label2;
	private global::Gtk.VBox vbox1;
	private global::Gtk.VBox vbox2;
	private global::Gtk.ToggleButton Run_btn;
	private global::Gtk.Button Stop_btn;
	private global::Gtk.Button reset_btn;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(18));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
		w1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString (".....");
		this.label2.Wrap = true;
		w1.Add (this.label2);
		this.GtkScrolledWindow.Add (w1);
		this.hbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow]));
		w4.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.Run_btn = new global::Gtk.ToggleButton ();
		this.Run_btn.CanFocus = true;
		this.Run_btn.Name = "Run_btn";
		this.Run_btn.UseUnderline = true;
		this.Run_btn.Label = global::Mono.Unix.Catalog.GetString ("Run");
		this.vbox2.Add (this.Run_btn);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.Run_btn]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.Stop_btn = new global::Gtk.Button ();
		this.Stop_btn.CanFocus = true;
		this.Stop_btn.Name = "Stop_btn";
		this.Stop_btn.UseUnderline = true;
		this.Stop_btn.Label = global::Mono.Unix.Catalog.GetString ("Stop");
		this.vbox2.Add (this.Stop_btn);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.Stop_btn]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.reset_btn = new global::Gtk.Button ();
		this.reset_btn.CanFocus = true;
		this.reset_btn.Name = "reset_btn";
		this.reset_btn.UseUnderline = true;
		this.reset_btn.Label = global::Mono.Unix.Catalog.GetString ("Reset");
		this.vbox2.Add (this.reset_btn);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.reset_btn]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
		w8.Position = 0;
		w8.Expand = false;
		w8.Fill = false;
		this.hbox1.Add (this.vbox1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		this.Add (this.hbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 152;
		this.DefaultHeight = 480;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.Run_btn.Clicked += new global::System.EventHandler (this.OnTogglebutton1Clicked);
		this.Stop_btn.Clicked += new global::System.EventHandler (this.OnStopBtnClicked);
		this.reset_btn.Clicked += new global::System.EventHandler (this.OnResetBtnClicked);
	}
}
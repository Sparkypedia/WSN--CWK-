
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action refreshAction;
	private global::Gtk.Action propertiesAction;
	private global::Gtk.Action mediaPlayAction;
	private global::Gtk.Action mediaStopAction;
	private global::Gtk.Action FileAction1;
	private global::Gtk.Action refreshAction1;
	private global::Gtk.Action propertiesAction1;
	private global::Gtk.Action mediaPlayAction1;
	private global::Gtk.Action mediaStopAction1;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label label9;
	private global::Gtk.Label TotArea_lbl;
	private global::Gtk.Label label11;
	private global::Gtk.Label mote1_lbl;
	private global::Gtk.Label label13;
	private global::Gtk.Label mote2_lbl;
	private global::Gtk.Label label15;
	private global::Gtk.Label mote3_lbl;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Label label1;
	private global::Gtk.Entry ALength_txtbox;
	private global::Gtk.Label label2;
	private global::Gtk.Entry M1X_txtbox;
	private global::Gtk.Label label3;
	private global::Gtk.Entry M2X_txtbox;
	private global::Gtk.Label label4;
	private global::Gtk.Entry M3X_txtbox;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Label label5;
	private global::Gtk.Entry AWidth_txtbox;
	private global::Gtk.Label label6;
	private global::Gtk.Entry M1Y_txtbox;
	private global::Gtk.Label label7;
	private global::Gtk.Entry M2Y_txtbox;
	private global::Gtk.Label label8;
	private global::Gtk.Entry M3Y_txtbox;
	private global::Gtk.Frame frame1;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.Label GtkLabel2;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.Entry terminal_txtbox;
	private global::Gtk.Statusbar statusbar1;
	private global::Gtk.Label lbl;
	private global::Gtk.Label Status_lbl;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.refreshAction = new global::Gtk.Action ("refreshAction", global::Mono.Unix.Catalog.GetString ("Reset"), null, "gtk-refresh");
		this.refreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Reset");
		w1.Add (this.refreshAction, null);
		this.propertiesAction = new global::Gtk.Action ("propertiesAction", global::Mono.Unix.Catalog.GetString ("Config"), null, "gtk-properties");
		this.propertiesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Config");
		w1.Add (this.propertiesAction, null);
		this.mediaPlayAction = new global::Gtk.Action ("mediaPlayAction", global::Mono.Unix.Catalog.GetString ("Run"), null, "gtk-media-play");
		this.mediaPlayAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Run");
		w1.Add (this.mediaPlayAction, null);
		this.mediaStopAction = new global::Gtk.Action ("mediaStopAction", global::Mono.Unix.Catalog.GetString ("Stop"), null, "gtk-media-stop");
		this.mediaStopAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Stop");
		w1.Add (this.mediaStopAction, null);
		this.FileAction1 = new global::Gtk.Action ("FileAction1", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction1, null);
		this.refreshAction1 = new global::Gtk.Action ("refreshAction1", global::Mono.Unix.Catalog.GetString ("Reset"), null, "gtk-refresh");
		this.refreshAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Reset");
		w1.Add (this.refreshAction1, null);
		this.propertiesAction1 = new global::Gtk.Action ("propertiesAction1", global::Mono.Unix.Catalog.GetString ("Config"), null, "gtk-properties");
		this.propertiesAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Config");
		w1.Add (this.propertiesAction1, null);
		this.mediaPlayAction1 = new global::Gtk.Action ("mediaPlayAction1", global::Mono.Unix.Catalog.GetString ("Run"), null, "gtk-media-play");
		this.mediaPlayAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Run");
		w1.Add (this.mediaPlayAction1, null);
		this.mediaStopAction1 = new global::Gtk.Action ("mediaStopAction1", global::Mono.Unix.Catalog.GetString ("Stop"), null, "gtk-media-stop");
		this.mediaStopAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Stop");
		w1.Add (this.mediaStopAction1, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(6));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		this.vbox1.BorderWidth = ((uint)(3));
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction1' action='FileAction1'><menuitem name='refreshAction1' action='refreshAction1'/><menuitem name='propertiesAction1' action='propertiesAction1'/><menuitem name='mediaPlayAction1' action='mediaPlayAction1'/><menuitem name='mediaStopAction1' action='mediaStopAction1'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='refreshAction' action='refreshAction'/><toolitem name='propertiesAction' action='propertiesAction'/><toolitem name='mediaPlayAction' action='mediaPlayAction'/><toolitem name='mediaStopAction1' action='mediaStopAction1'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox1.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("                                                       Total Area = ");
		this.hbox3.Add (this.label9);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label9]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.TotArea_lbl = new global::Gtk.Label ();
		this.TotArea_lbl.Name = "TotArea_lbl";
		this.TotArea_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("---- cm");
		this.hbox3.Add (this.TotArea_lbl);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.TotArea_lbl]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label11 = new global::Gtk.Label ();
		this.label11.Name = "label11";
		this.label11.LabelProp = global::Mono.Unix.Catalog.GetString ("                                                       X,Y Coordinates for Mote  No.1: ");
		this.hbox3.Add (this.label11);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label11]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.mote1_lbl = new global::Gtk.Label ();
		this.mote1_lbl.Name = "mote1_lbl";
		this.mote1_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("-,-");
		this.hbox3.Add (this.mote1_lbl);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.mote1_lbl]));
		w7.Position = 3;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label13 = new global::Gtk.Label ();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("                                  X,Y Coordinates for Mote  No.2: ");
		this.hbox3.Add (this.label13);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label13]));
		w8.Position = 4;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.mote2_lbl = new global::Gtk.Label ();
		this.mote2_lbl.Name = "mote2_lbl";
		this.mote2_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("-,-");
		this.hbox3.Add (this.mote2_lbl);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.mote2_lbl]));
		w9.Position = 5;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.label15 = new global::Gtk.Label ();
		this.label15.Name = "label15";
		this.label15.LabelProp = global::Mono.Unix.Catalog.GetString ("                                         X,Y Coordinates for Mote  No.3 ");
		this.hbox3.Add (this.label15);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label15]));
		w10.Position = 6;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.mote3_lbl = new global::Gtk.Label ();
		this.mote3_lbl.Name = "mote3_lbl";
		this.mote3_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("-,-");
		this.hbox3.Add (this.mote3_lbl);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.mote3_lbl]));
		w11.Position = 7;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Area Length:");
		this.hbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.ALength_txtbox = new global::Gtk.Entry ();
		this.ALength_txtbox.CanFocus = true;
		this.ALength_txtbox.Name = "ALength_txtbox";
		this.ALength_txtbox.IsEditable = true;
		this.ALength_txtbox.InvisibleChar = '•';
		this.hbox1.Add (this.ALength_txtbox);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.ALength_txtbox]));
		w14.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 1 - X:");
		this.hbox1.Add (this.label2);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label2]));
		w15.Position = 2;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.M1X_txtbox = new global::Gtk.Entry ();
		this.M1X_txtbox.CanFocus = true;
		this.M1X_txtbox.Name = "M1X_txtbox";
		this.M1X_txtbox.IsEditable = true;
		this.M1X_txtbox.InvisibleChar = '•';
		this.hbox1.Add (this.M1X_txtbox);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.M1X_txtbox]));
		w16.Position = 3;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 2 - X:");
		this.hbox1.Add (this.label3);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label3]));
		w17.Position = 4;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.M2X_txtbox = new global::Gtk.Entry ();
		this.M2X_txtbox.CanFocus = true;
		this.M2X_txtbox.Name = "M2X_txtbox";
		this.M2X_txtbox.IsEditable = true;
		this.M2X_txtbox.InvisibleChar = '•';
		this.hbox1.Add (this.M2X_txtbox);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.M2X_txtbox]));
		w18.Position = 5;
		// Container child hbox1.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 3 - X:");
		this.hbox1.Add (this.label4);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label4]));
		w19.Position = 6;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.M3X_txtbox = new global::Gtk.Entry ();
		this.M3X_txtbox.CanFocus = true;
		this.M3X_txtbox.Name = "M3X_txtbox";
		this.M3X_txtbox.IsEditable = true;
		this.M3X_txtbox.InvisibleChar = '•';
		this.hbox1.Add (this.M3X_txtbox);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.M3X_txtbox]));
		w20.Position = 7;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w21.Position = 3;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Area Width:  ");
		this.hbox2.Add (this.label5);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label5]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.AWidth_txtbox = new global::Gtk.Entry ();
		this.AWidth_txtbox.CanFocus = true;
		this.AWidth_txtbox.Name = "AWidth_txtbox";
		this.AWidth_txtbox.IsEditable = true;
		this.AWidth_txtbox.InvisibleChar = '•';
		this.hbox2.Add (this.AWidth_txtbox);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.AWidth_txtbox]));
		w23.Position = 1;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 1 - Y:");
		this.hbox2.Add (this.label6);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label6]));
		w24.Position = 2;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.M1Y_txtbox = new global::Gtk.Entry ();
		this.M1Y_txtbox.CanFocus = true;
		this.M1Y_txtbox.Name = "M1Y_txtbox";
		this.M1Y_txtbox.IsEditable = true;
		this.M1Y_txtbox.InvisibleChar = '•';
		this.hbox2.Add (this.M1Y_txtbox);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.M1Y_txtbox]));
		w25.Position = 3;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 2 - Y:");
		this.hbox2.Add (this.label7);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label7]));
		w26.Position = 4;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.M2Y_txtbox = new global::Gtk.Entry ();
		this.M2Y_txtbox.CanFocus = true;
		this.M2Y_txtbox.Name = "M2Y_txtbox";
		this.M2Y_txtbox.IsEditable = true;
		this.M2Y_txtbox.InvisibleChar = '•';
		this.hbox2.Add (this.M2Y_txtbox);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.M2Y_txtbox]));
		w27.Position = 5;
		// Container child hbox2.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 3 - Y:");
		this.hbox2.Add (this.label8);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label8]));
		w28.Position = 6;
		w28.Expand = false;
		w28.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.M3Y_txtbox = new global::Gtk.Entry ();
		this.M3Y_txtbox.CanFocus = true;
		this.M3Y_txtbox.Name = "M3Y_txtbox";
		this.M3Y_txtbox.IsEditable = true;
		this.M3Y_txtbox.InvisibleChar = '•';
		this.hbox2.Add (this.M3Y_txtbox);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.M3Y_txtbox]));
		w29.Position = 7;
		this.vbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox2]));
		w30.Position = 4;
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel2 = new global::Gtk.Label ();
		this.GtkLabel2.Name = "GtkLabel2";
		this.GtkLabel2.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel2;
		this.vbox1.Add (this.frame1);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frame1]));
		w32.Position = 5;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w33 = new global::Gtk.Viewport ();
		w33.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.terminal_txtbox = new global::Gtk.Entry ();
		this.terminal_txtbox.CanFocus = true;
		this.terminal_txtbox.Name = "terminal_txtbox";
		this.terminal_txtbox.IsEditable = true;
		this.terminal_txtbox.InvisibleChar = '•';
		w33.Add (this.terminal_txtbox);
		this.GtkScrolledWindow.Add (w33);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
		w36.Position = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.lbl = new global::Gtk.Label ();
		this.lbl.Name = "lbl";
		this.lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Status:");
		this.statusbar1.Add (this.lbl);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.lbl]));
		w37.Position = 1;
		w37.Expand = false;
		w37.Fill = false;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.Status_lbl = new global::Gtk.Label ();
		this.Status_lbl.Name = "Status_lbl";
		this.Status_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Waiting...");
		this.statusbar1.Add (this.Status_lbl);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.Status_lbl]));
		w38.Position = 2;
		w38.Expand = false;
		w38.Fill = false;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w39.Position = 7;
		w39.Expand = false;
		w39.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 1444;
		this.DefaultHeight = 667;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.refreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
	}
}


// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action ActionsAction;
	private global::Gtk.Action propertiesAction;
	private global::Gtk.Action refreshAction;
	private global::Gtk.Action mediaPlayAction;
	private global::Gtk.Action mediaStopAction;
	private global::Gtk.Action dialogQuestionAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.HBox hbox3;
	private global::Gtk.Label TotAreaTag_lbl;
	private global::Gtk.Label TotalArea_lbl;
	private global::Gtk.Label M1CoTag_lbl;
	private global::Gtk.Label M1Co_lbl;
	private global::Gtk.Label M2CoTag_lbl1;
	private global::Gtk.Label M2Co_lbl;
	private global::Gtk.Label M3CoTag_lbl;
	private global::Gtk.Label M3Co_lbl;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label Altag_lbl;
	private global::Gtk.Entry Alength_txtbx;
	private global::Gtk.Label M1xTag_lbl;
	private global::Gtk.Entry M1X_txtbx;
	private global::Gtk.Label M2CoTag_lbl;
	private global::Gtk.Entry M2X_txtbx;
	private global::Gtk.Label M3XTag_lbl;
	private global::Gtk.Entry M3X_txtbx;
	private global::Gtk.HBox hbox7;
	private global::Gtk.Label Awtag_lbl;
	private global::Gtk.Entry Awidth_txtbx;
	private global::Gtk.Label M1YTag_lbl;
	private global::Gtk.Entry M1Y_txtbx;
	private global::Gtk.Label M2YTag_lbl;
	private global::Gtk.Entry M2Y_txtbx;
	private global::Gtk.Label M3YTag_lbl;
	private global::Gtk.Entry M3Y_txtbx;
	private global::Gtk.HBox hbox6;
	private global::Gtk.HBox hbox5;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.Label data_lbl;
	private global::Gtk.Statusbar statusbar1;
	private global::Gtk.Label label2;
	private global::Gtk.Label Status_lbl;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.ActionsAction = new global::Gtk.Action ("ActionsAction", global::Mono.Unix.Catalog.GetString ("Actions"), null, null);
		this.ActionsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Actions");
		w1.Add (this.ActionsAction, null);
		this.propertiesAction = new global::Gtk.Action ("propertiesAction", global::Mono.Unix.Catalog.GetString ("Configure"), null, "gtk-properties");
		this.propertiesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Configure");
		w1.Add (this.propertiesAction, null);
		this.refreshAction = new global::Gtk.Action ("refreshAction", global::Mono.Unix.Catalog.GetString ("Reset"), null, "gtk-refresh");
		this.refreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Reset");
		w1.Add (this.refreshAction, null);
		this.mediaPlayAction = new global::Gtk.Action ("mediaPlayAction", global::Mono.Unix.Catalog.GetString ("Run"), null, "gtk-media-play");
		this.mediaPlayAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Run");
		w1.Add (this.mediaPlayAction, null);
		this.mediaStopAction = new global::Gtk.Action ("mediaStopAction", global::Mono.Unix.Catalog.GetString ("Stop"), null, "gtk-media-stop");
		this.mediaStopAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Stop");
		w1.Add (this.mediaStopAction, null);
		this.dialogQuestionAction = new global::Gtk.Action ("dialogQuestionAction", global::Mono.Unix.Catalog.GetString ("Test"), null, "gtk-dialog-question");
		this.dialogQuestionAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Test");
		w1.Add (this.dialogQuestionAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(9));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='ActionsAction' action='ActionsAction'><menuitem name='propertiesAction' action='propertiesAction'/><menuitem name='refreshAction' action='refreshAction'/><menuitem name='mediaPlayAction' action='mediaPlayAction'/><menuitem name='mediaStopAction' action='mediaStopAction'/><separator/><menuitem name='dialogQuestionAction' action='dialogQuestionAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='propertiesAction' action='propertiesAction'/><toolitem name='refreshAction' action='refreshAction'/><toolitem name='mediaPlayAction' action='mediaPlayAction'/><toolitem name='mediaStopAction' action='mediaStopAction'/><separator/><toolitem name='dialogQuestionAction' action='dialogQuestionAction'/></toolbar></ui>");
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
		this.hbox3.Spacing = 10;
		this.hbox3.BorderWidth = ((uint)(3));
		// Container child hbox3.Gtk.Box+BoxChild
		this.TotAreaTag_lbl = new global::Gtk.Label ();
		this.TotAreaTag_lbl.Name = "TotAreaTag_lbl";
		this.TotAreaTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("                                 Total Area");
		this.hbox3.Add (this.TotAreaTag_lbl);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.TotAreaTag_lbl]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.TotalArea_lbl = new global::Gtk.Label ();
		this.TotalArea_lbl.Name = "TotalArea_lbl";
		this.TotalArea_lbl.LabelProp = global::Mono.Unix.Catalog.GetString (".......cm");
		this.hbox3.Add (this.TotalArea_lbl);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.TotalArea_lbl]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.M1CoTag_lbl = new global::Gtk.Label ();
		this.M1CoTag_lbl.Name = "M1CoTag_lbl";
		this.M1CoTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("                                 X,Y Coordinates for Mote No.1");
		this.hbox3.Add (this.M1CoTag_lbl);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.M1CoTag_lbl]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.M1Co_lbl = new global::Gtk.Label ();
		this.M1Co_lbl.Name = "M1Co_lbl";
		this.M1Co_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("--,--");
		this.hbox3.Add (this.M1Co_lbl);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.M1Co_lbl]));
		w7.Position = 3;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.M2CoTag_lbl1 = new global::Gtk.Label ();
		this.M2CoTag_lbl1.Name = "M2CoTag_lbl1";
		this.M2CoTag_lbl1.LabelProp = global::Mono.Unix.Catalog.GetString ("                                                X,Y Coordinates for Mote No.2");
		this.hbox3.Add (this.M2CoTag_lbl1);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.M2CoTag_lbl1]));
		w8.Position = 4;
		w8.Expand = false;
		w8.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.M2Co_lbl = new global::Gtk.Label ();
		this.M2Co_lbl.Name = "M2Co_lbl";
		this.M2Co_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("--,--");
		this.hbox3.Add (this.M2Co_lbl);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.M2Co_lbl]));
		w9.Position = 5;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.M3CoTag_lbl = new global::Gtk.Label ();
		this.M3CoTag_lbl.Name = "M3CoTag_lbl";
		this.M3CoTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("                                        X,Y Coordinates for Mote No.3");
		this.hbox3.Add (this.M3CoTag_lbl);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.M3CoTag_lbl]));
		w10.Position = 6;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.M3Co_lbl = new global::Gtk.Label ();
		this.M3Co_lbl.Name = "M3Co_lbl";
		this.M3Co_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("--,--");
		this.hbox3.Add (this.M3Co_lbl);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.M3Co_lbl]));
		w11.Position = 7;
		w11.Expand = false;
		w11.Fill = false;
		this.vbox1.Add (this.hbox3);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.Altag_lbl = new global::Gtk.Label ();
		this.Altag_lbl.Name = "Altag_lbl";
		this.Altag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Length");
		this.hbox4.Add (this.Altag_lbl);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.Altag_lbl]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.Alength_txtbx = new global::Gtk.Entry ();
		this.Alength_txtbx.CanFocus = true;
		this.Alength_txtbx.Name = "Alength_txtbx";
		this.Alength_txtbx.IsEditable = true;
		this.Alength_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.Alength_txtbx);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.Alength_txtbx]));
		w14.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M1xTag_lbl = new global::Gtk.Label ();
		this.M1xTag_lbl.Name = "M1xTag_lbl";
		this.M1xTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 1, X Coordinate");
		this.hbox4.Add (this.M1xTag_lbl);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M1xTag_lbl]));
		w15.Position = 2;
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M1X_txtbx = new global::Gtk.Entry ();
		this.M1X_txtbx.CanFocus = true;
		this.M1X_txtbx.Name = "M1X_txtbx";
		this.M1X_txtbx.IsEditable = true;
		this.M1X_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.M1X_txtbx);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M1X_txtbx]));
		w16.Position = 3;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M2CoTag_lbl = new global::Gtk.Label ();
		this.M2CoTag_lbl.Name = "M2CoTag_lbl";
		this.M2CoTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 2, X Coordinate");
		this.hbox4.Add (this.M2CoTag_lbl);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M2CoTag_lbl]));
		w17.Position = 4;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M2X_txtbx = new global::Gtk.Entry ();
		this.M2X_txtbx.CanFocus = true;
		this.M2X_txtbx.Name = "M2X_txtbx";
		this.M2X_txtbx.IsEditable = true;
		this.M2X_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.M2X_txtbx);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M2X_txtbx]));
		w18.Position = 5;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M3XTag_lbl = new global::Gtk.Label ();
		this.M3XTag_lbl.Name = "M3XTag_lbl";
		this.M3XTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 3, X Coordinate");
		this.hbox4.Add (this.M3XTag_lbl);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M3XTag_lbl]));
		w19.Position = 6;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M3X_txtbx = new global::Gtk.Entry ();
		this.M3X_txtbx.CanFocus = true;
		this.M3X_txtbx.Name = "M3X_txtbx";
		this.M3X_txtbx.IsEditable = true;
		this.M3X_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.M3X_txtbx);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M3X_txtbx]));
		w20.Position = 7;
		this.vbox1.Add (this.hbox4);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
		w21.Position = 3;
		w21.Expand = false;
		w21.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox ();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.Awtag_lbl = new global::Gtk.Label ();
		this.Awtag_lbl.Name = "Awtag_lbl";
		this.Awtag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Width  ");
		this.hbox7.Add (this.Awtag_lbl);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.Awtag_lbl]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.Awidth_txtbx = new global::Gtk.Entry ();
		this.Awidth_txtbx.CanFocus = true;
		this.Awidth_txtbx.Name = "Awidth_txtbx";
		this.Awidth_txtbx.IsEditable = true;
		this.Awidth_txtbx.InvisibleChar = '•';
		this.hbox7.Add (this.Awidth_txtbx);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.Awidth_txtbx]));
		w23.Position = 1;
		// Container child hbox7.Gtk.Box+BoxChild
		this.M1YTag_lbl = new global::Gtk.Label ();
		this.M1YTag_lbl.Name = "M1YTag_lbl";
		this.M1YTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 1, Y Coordinate");
		this.hbox7.Add (this.M1YTag_lbl);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.M1YTag_lbl]));
		w24.Position = 2;
		w24.Expand = false;
		w24.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.M1Y_txtbx = new global::Gtk.Entry ();
		this.M1Y_txtbx.CanFocus = true;
		this.M1Y_txtbx.Name = "M1Y_txtbx";
		this.M1Y_txtbx.IsEditable = true;
		this.M1Y_txtbx.InvisibleChar = '•';
		this.hbox7.Add (this.M1Y_txtbx);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.M1Y_txtbx]));
		w25.Position = 3;
		// Container child hbox7.Gtk.Box+BoxChild
		this.M2YTag_lbl = new global::Gtk.Label ();
		this.M2YTag_lbl.Name = "M2YTag_lbl";
		this.M2YTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 2, Y Coordinate");
		this.hbox7.Add (this.M2YTag_lbl);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.M2YTag_lbl]));
		w26.Position = 4;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.M2Y_txtbx = new global::Gtk.Entry ();
		this.M2Y_txtbx.CanFocus = true;
		this.M2Y_txtbx.Name = "M2Y_txtbx";
		this.M2Y_txtbx.IsEditable = true;
		this.M2Y_txtbx.InvisibleChar = '•';
		this.hbox7.Add (this.M2Y_txtbx);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.M2Y_txtbx]));
		w27.Position = 5;
		// Container child hbox7.Gtk.Box+BoxChild
		this.M3YTag_lbl = new global::Gtk.Label ();
		this.M3YTag_lbl.Name = "M3YTag_lbl";
		this.M3YTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote 3, Y Coordinate");
		this.hbox7.Add (this.M3YTag_lbl);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.M3YTag_lbl]));
		w28.Position = 6;
		w28.Expand = false;
		w28.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.M3Y_txtbx = new global::Gtk.Entry ();
		this.M3Y_txtbx.CanFocus = true;
		this.M3Y_txtbx.Name = "M3Y_txtbx";
		this.M3Y_txtbx.IsEditable = true;
		this.M3Y_txtbx.InvisibleChar = '•';
		this.hbox7.Add (this.M3Y_txtbx);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox7 [this.M3Y_txtbx]));
		w29.Position = 7;
		this.vbox1.Add (this.hbox7);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox7]));
		w30.Position = 4;
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox ();
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		this.vbox1.Add (this.hbox6);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox6]));
		w31.Position = 5;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w32 = new global::Gtk.Viewport ();
		w32.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.data_lbl = new global::Gtk.Label ();
		this.data_lbl.Name = "data_lbl";
		this.data_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Waiting for data...");
		this.data_lbl.Wrap = true;
		w32.Add (this.data_lbl);
		this.GtkScrolledWindow.Add (w32);
		this.hbox5.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.GtkScrolledWindow]));
		w35.Position = 0;
		this.vbox1.Add (this.hbox5);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
		w36.Position = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Status:");
		this.statusbar1.Add (this.label2);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.label2]));
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
		this.DefaultWidth = 1426;
		this.DefaultHeight = 758;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.propertiesAction.Activated += new global::System.EventHandler (this.OnPropertiesActionActivated);
		this.refreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
		this.mediaPlayAction.Activated += new global::System.EventHandler (this.OnMediaPlayActionActivated);
		this.mediaStopAction.Activated += new global::System.EventHandler (this.OnMediaStopActionActivated);
		this.dialogQuestionAction.Activated += new global::System.EventHandler (this.OnDialogQuestionActionActivated);
	}
}
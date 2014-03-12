
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
	private global::Gtk.HBox hbox11;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.Label label1;
	private global::Gtk.Label Time_lbl;
	private global::Gtk.HBox hbox4;
	private global::Gtk.Label LWtag_lbl;
	private global::Gtk.Entry LW_txtbx;
	private global::Gtk.Label M1xyTag_lbl;
	private global::Gtk.Entry M1XY_txtbx;
	private global::Gtk.Label M2xyTag_lbl;
	private global::Gtk.Entry M2XY_txtbx;
	private global::Gtk.Label M3xyTag_lbl;
	private global::Gtk.Entry M3XY_txtbx;
	private global::Gtk.HBox hbox5;
	private global::Gtk.ScrolledWindow DataWindow;
	private global::Gtk.Label data_lbl;
	private global::Gtk.Fixed AnimationDisplay;
	private global::Gtk.Image M3_img;
	private global::Gtk.Image M1_img;
	private global::Gtk.Image M2_img;
	private global::Gtk.HBox hbox12;
	private global::Gtk.Label label2;
	private global::Gtk.Label Status_lbl;
	private global::Gtk.Label label6;
	private global::Gtk.Label label3;
	private global::Gtk.Label buffersize_lbl;
	private global::Gtk.Label label7;
	private global::Gtk.Label label5;
	private global::Gtk.Label bytestoread_lbl;
	private global::Gtk.Label label8;
	private global::Gtk.Label TotAreaTag_lbl;
	private global::Gtk.Label TotalArea_lbl;
	private global::Gtk.Label label9;
	private global::Gtk.Button Sim_btn;
	private global::Gtk.Label SimTag_lbl;
	private global::Gtk.Entry Sim_txtbx;
	
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
		this.Resizable = false;
		this.AllowGrow = false;
		this.DefaultWidth = 1000;
		this.DefaultHeight = 800;
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
		this.hbox11 = new global::Gtk.HBox ();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name='toolbar1'><toolitem name='propertiesAction' action='propertiesAction'/><toolitem name='refreshAction' action='refreshAction'/><toolitem name='mediaPlayAction' action='mediaPlayAction'/><toolitem name='mediaStopAction' action='mediaStopAction'/><separator/><toolitem name='dialogQuestionAction' action='dialogQuestionAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.hbox11.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.toolbar1]));
		w3.Position = 0;
		// Container child hbox11.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Time:");
		this.label1.Justify = ((global::Gtk.Justification)(1));
		this.hbox11.Add (this.label1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.Time_lbl = new global::Gtk.Label ();
		this.Time_lbl.Name = "Time_lbl";
		this.Time_lbl.Xalign = 1F;
		this.Time_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("#####");
		this.hbox11.Add (this.Time_lbl);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.Time_lbl]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox1.Add (this.hbox11);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox11]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.LWtag_lbl = new global::Gtk.Label ();
		this.LWtag_lbl.Name = "LWtag_lbl";
		this.LWtag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Length, Width");
		this.hbox4.Add (this.LWtag_lbl);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.LWtag_lbl]));
		w7.Position = 0;
		w7.Expand = false;
		w7.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.LW_txtbx = new global::Gtk.Entry ();
		this.LW_txtbx.WidthRequest = 100;
		this.LW_txtbx.CanFocus = true;
		this.LW_txtbx.Name = "LW_txtbx";
		this.LW_txtbx.IsEditable = true;
		this.LW_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.LW_txtbx);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.LW_txtbx]));
		w8.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M1xyTag_lbl = new global::Gtk.Label ();
		this.M1xyTag_lbl.Name = "M1xyTag_lbl";
		this.M1xyTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote No.1 X,Y");
		this.hbox4.Add (this.M1xyTag_lbl);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M1xyTag_lbl]));
		w9.Position = 2;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M1XY_txtbx = new global::Gtk.Entry ();
		this.M1XY_txtbx.WidthRequest = 100;
		this.M1XY_txtbx.CanFocus = true;
		this.M1XY_txtbx.Name = "M1XY_txtbx";
		this.M1XY_txtbx.IsEditable = true;
		this.M1XY_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.M1XY_txtbx);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M1XY_txtbx]));
		w10.Position = 3;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M2xyTag_lbl = new global::Gtk.Label ();
		this.M2xyTag_lbl.Name = "M2xyTag_lbl";
		this.M2xyTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote No.2 X,Y");
		this.hbox4.Add (this.M2xyTag_lbl);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M2xyTag_lbl]));
		w11.Position = 4;
		w11.Expand = false;
		w11.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M2XY_txtbx = new global::Gtk.Entry ();
		this.M2XY_txtbx.WidthRequest = 100;
		this.M2XY_txtbx.CanFocus = true;
		this.M2XY_txtbx.Name = "M2XY_txtbx";
		this.M2XY_txtbx.IsEditable = true;
		this.M2XY_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.M2XY_txtbx);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M2XY_txtbx]));
		w12.Position = 5;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M3xyTag_lbl = new global::Gtk.Label ();
		this.M3xyTag_lbl.Name = "M3xyTag_lbl";
		this.M3xyTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Mote No.3 X,Y");
		this.hbox4.Add (this.M3xyTag_lbl);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M3xyTag_lbl]));
		w13.Position = 6;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox4.Gtk.Box+BoxChild
		this.M3XY_txtbx = new global::Gtk.Entry ();
		this.M3XY_txtbx.WidthRequest = 100;
		this.M3XY_txtbx.CanFocus = true;
		this.M3XY_txtbx.Name = "M3XY_txtbx";
		this.M3XY_txtbx.IsEditable = true;
		this.M3XY_txtbx.InvisibleChar = '•';
		this.hbox4.Add (this.M3XY_txtbx);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.M3XY_txtbx]));
		w14.Position = 7;
		this.vbox1.Add (this.hbox4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox4]));
		w15.Position = 2;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox ();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.DataWindow = new global::Gtk.ScrolledWindow ();
		this.DataWindow.WidthRequest = 300;
		this.DataWindow.HeightRequest = 500;
		this.DataWindow.Name = "DataWindow";
		this.DataWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child DataWindow.Gtk.Container+ContainerChild
		global::Gtk.Viewport w16 = new global::Gtk.Viewport ();
		w16.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child GtkViewport.Gtk.Container+ContainerChild
		this.data_lbl = new global::Gtk.Label ();
		this.data_lbl.Name = "data_lbl";
		this.data_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Waiting for data...");
		this.data_lbl.Wrap = true;
		w16.Add (this.data_lbl);
		this.DataWindow.Add (w16);
		this.hbox5.Add (this.DataWindow);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.DataWindow]));
		w19.Position = 0;
		// Container child hbox5.Gtk.Box+BoxChild
		this.AnimationDisplay = new global::Gtk.Fixed ();
		this.AnimationDisplay.WidthRequest = 600;
		this.AnimationDisplay.HeightRequest = 600;
		this.AnimationDisplay.Name = "AnimationDisplay";
		this.AnimationDisplay.HasWindow = false;
		// Container child AnimationDisplay.Gtk.Fixed+FixedChild
		this.M3_img = new global::Gtk.Image ();
		this.M3_img.Name = "M3_img";
		this.M3_img.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("TInyOs_Monitor.antenna_parabolasmaller.png");
		this.AnimationDisplay.Add (this.M3_img);
		global::Gtk.Fixed.FixedChild w20 = ((global::Gtk.Fixed.FixedChild)(this.AnimationDisplay [this.M3_img]));
		w20.X = 430;
		w20.Y = 456;
		// Container child AnimationDisplay.Gtk.Fixed+FixedChild
		this.M1_img = new global::Gtk.Image ();
		this.M1_img.Name = "M1_img";
		this.M1_img.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("TInyOs_Monitor.antenna_parabolasmaller.png");
		this.AnimationDisplay.Add (this.M1_img);
		global::Gtk.Fixed.FixedChild w21 = ((global::Gtk.Fixed.FixedChild)(this.AnimationDisplay [this.M1_img]));
		w21.X = 117;
		w21.Y = 371;
		// Container child AnimationDisplay.Gtk.Fixed+FixedChild
		this.M2_img = new global::Gtk.Image ();
		this.M2_img.Name = "M2_img";
		this.M2_img.Pixbuf = global::Gdk.Pixbuf.LoadFromResource ("TInyOs_Monitor.antenna_parabolasmaller.png");
		this.AnimationDisplay.Add (this.M2_img);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.AnimationDisplay [this.M2_img]));
		w22.X = 311;
		w22.Y = 354;
		this.hbox5.Add (this.AnimationDisplay);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.AnimationDisplay]));
		w23.Position = 1;
		w23.Expand = false;
		w23.Fill = false;
		this.vbox1.Add (this.hbox5);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox5]));
		w24.Position = 3;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox12 = new global::Gtk.HBox ();
		this.hbox12.Name = "hbox12";
		this.hbox12.Spacing = 6;
		// Container child hbox12.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 1F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Status:");
		this.label2.Justify = ((global::Gtk.Justification)(1));
		this.hbox12.Add (this.label2);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label2]));
		w25.Position = 0;
		w25.Expand = false;
		w25.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.Status_lbl = new global::Gtk.Label ();
		this.Status_lbl.Name = "Status_lbl";
		this.Status_lbl.Xalign = 1F;
		this.Status_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Waiting...");
		this.hbox12.Add (this.Status_lbl);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.Status_lbl]));
		w26.Position = 1;
		w26.Expand = false;
		w26.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.hbox12.Add (this.label6);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label6]));
		w27.Position = 2;
		w27.Expand = false;
		w27.Fill = false;
		w27.Padding = ((uint)(30));
		// Container child hbox12.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Buffer Size:");
		this.label3.Justify = ((global::Gtk.Justification)(1));
		this.hbox12.Add (this.label3);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label3]));
		w28.Position = 3;
		w28.Expand = false;
		w28.Fill = false;
		w28.Padding = ((uint)(1));
		// Container child hbox12.Gtk.Box+BoxChild
		this.buffersize_lbl = new global::Gtk.Label ();
		this.buffersize_lbl.Name = "buffersize_lbl";
		this.buffersize_lbl.Xpad = 10;
		this.buffersize_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("##");
		this.hbox12.Add (this.buffersize_lbl);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.buffersize_lbl]));
		w29.Position = 4;
		w29.Expand = false;
		w29.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.hbox12.Add (this.label7);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label7]));
		w30.Position = 5;
		w30.Expand = false;
		w30.Fill = false;
		w30.Padding = ((uint)(30));
		// Container child hbox12.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.Xpad = 10;
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Bytes to Read:");
		this.label5.Justify = ((global::Gtk.Justification)(1));
		this.hbox12.Add (this.label5);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label5]));
		w31.Position = 6;
		w31.Expand = false;
		w31.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.bytestoread_lbl = new global::Gtk.Label ();
		this.bytestoread_lbl.Name = "bytestoread_lbl";
		this.bytestoread_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("##");
		this.hbox12.Add (this.bytestoread_lbl);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.bytestoread_lbl]));
		w32.Position = 7;
		w32.Expand = false;
		w32.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.hbox12.Add (this.label8);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label8]));
		w33.Position = 8;
		w33.Expand = false;
		w33.Fill = false;
		w33.Padding = ((uint)(30));
		// Container child hbox12.Gtk.Box+BoxChild
		this.TotAreaTag_lbl = new global::Gtk.Label ();
		this.TotAreaTag_lbl.Name = "TotAreaTag_lbl";
		this.TotAreaTag_lbl.Xalign = 1F;
		this.TotAreaTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Total Area:");
		this.hbox12.Add (this.TotAreaTag_lbl);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.TotAreaTag_lbl]));
		w34.Position = 9;
		w34.Expand = false;
		w34.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.TotalArea_lbl = new global::Gtk.Label ();
		this.TotalArea_lbl.Name = "TotalArea_lbl";
		this.TotalArea_lbl.Xalign = 0F;
		this.TotalArea_lbl.LabelProp = global::Mono.Unix.Catalog.GetString (".......cm");
		this.hbox12.Add (this.TotalArea_lbl);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.TotalArea_lbl]));
		w35.Position = 10;
		w35.Expand = false;
		w35.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.hbox12.Add (this.label9);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.label9]));
		w36.Position = 11;
		w36.Expand = false;
		w36.Fill = false;
		w36.Padding = ((uint)(30));
		// Container child hbox12.Gtk.Box+BoxChild
		this.Sim_btn = new global::Gtk.Button ();
		this.Sim_btn.CanFocus = true;
		this.Sim_btn.Name = "Sim_btn";
		this.Sim_btn.UseUnderline = true;
		this.Sim_btn.Label = global::Mono.Unix.Catalog.GetString ("Simulate Input");
		this.hbox12.Add (this.Sim_btn);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.Sim_btn]));
		w37.Position = 12;
		w37.Expand = false;
		w37.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.SimTag_lbl = new global::Gtk.Label ();
		this.SimTag_lbl.Name = "SimTag_lbl";
		this.SimTag_lbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Person's X,Y:");
		this.hbox12.Add (this.SimTag_lbl);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.SimTag_lbl]));
		w38.Position = 13;
		w38.Expand = false;
		w38.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.Sim_txtbx = new global::Gtk.Entry ();
		this.Sim_txtbx.WidthRequest = 100;
		this.Sim_txtbx.CanFocus = true;
		this.Sim_txtbx.Name = "Sim_txtbx";
		this.Sim_txtbx.IsEditable = true;
		this.Sim_txtbx.InvisibleChar = '•';
		this.hbox12.Add (this.Sim_txtbx);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.Sim_txtbx]));
		w39.Position = 14;
		this.vbox1.Add (this.hbox12);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox12]));
		w40.Position = 4;
		w40.Expand = false;
		w40.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.propertiesAction.Activated += new global::System.EventHandler (this.OnPropertiesActionActivated);
		this.refreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
		this.mediaPlayAction.Activated += new global::System.EventHandler (this.OnMediaPlayActionActivated);
		this.mediaStopAction.Activated += new global::System.EventHandler (this.OnMediaStopActionActivated);
		this.dialogQuestionAction.Activated += new global::System.EventHandler (this.OnDialogQuestionActionActivated);
	}
}

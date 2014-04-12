
// This file has been generated by the GUI designer. Do not modify.
namespace TroposphirLauncher
{
	public partial class MainWindow
	{
		private global::Gtk.Table table2;
		private global::Gtk.Button btnPlay;
		private global::Gtk.Button btnSettings;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView updateTextView;
		private global::Gtk.Label label2;
		private global::Gtk.ProgressBar progressBar;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TroposphirLauncher.MainWindow
			this.WidthRequest = 400;
			this.HeightRequest = 300;
			this.Name = "TroposphirLauncher.MainWindow";
			this.Title = "Troposphir Launcher";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			// Container child TroposphirLauncher.MainWindow.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(4)), ((uint)(4)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(3));
			this.table2.ColumnSpacing = ((uint)(3));
			this.table2.BorderWidth = ((uint)(3));
			// Container child table2.Gtk.Table+TableChild
			this.btnPlay = new global::Gtk.Button ();
			global::Gtk.Tooltips w1 = new Gtk.Tooltips ();
			w1.SetTip (this.btnPlay, "Launch the game", "Launch the game");
			this.btnPlay.WidthRequest = 100;
			this.btnPlay.HeightRequest = 25;
			this.btnPlay.CanFocus = true;
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.UseUnderline = true;
			this.btnPlay.Label = "Play";
			this.table2.Add (this.btnPlay);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.btnPlay]));
			w2.TopAttach = ((uint)(3));
			w2.BottomAttach = ((uint)(4));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.btnSettings = new global::Gtk.Button ();
			w1.SetTip (this.btnSettings, "Preferences", "Preferences");
			this.btnSettings.WidthRequest = 25;
			this.btnSettings.HeightRequest = 25;
			this.btnSettings.CanFocus = true;
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.UseUnderline = true;
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Menu);
			this.btnSettings.Image = w3;
			this.table2.Add (this.btnSettings);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.btnSettings]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(3));
			w4.RightAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.updateTextView = new global::Gtk.TextView ();
			this.updateTextView.CanFocus = true;
			this.updateTextView.Name = "updateTextView";
			this.updateTextView.Editable = false;
			this.updateTextView.CursorVisible = false;
			this.updateTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow.Add (this.updateTextView);
			this.table2.Add (this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.GtkScrolledWindow]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(3));
			w6.RightAttach = ((uint)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = "Update news:";
			this.table2.Add (this.label2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.label2]));
			w7.RightAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.progressBar = new global::Gtk.ProgressBar ();
			w1.SetTip (this.progressBar, "Update progress", "Update progress");
			this.progressBar.HeightRequest = 25;
			this.progressBar.Name = "progressBar";
			this.progressBar.Text = "";
			this.progressBar.PulseStep = 1D;
			this.table2.Add (this.progressBar);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2 [this.progressBar]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(3));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.btnSettings.Clicked += new global::System.EventHandler (this.OpenSettingsWindow);
			this.btnPlay.Clicked += new global::System.EventHandler (this.LaunchGame);
		}
	}
}

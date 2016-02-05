using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace FormsExample
{
	class ContentPageExample : ContentPage
	{
		private StackLayout st;
		private Grid grid; 

		public ContentPageExample()
		{
			Label lbl = new Label {
				Text = "Output"
			};

			grid = new Grid {
				BackgroundColor = Color.Aqua,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
//				VerticalOptions=LayoutOptions.FillAndExpand,
				RowDefinitions = {
					new RowDefinition{ Height = GridLength.Auto },
					new RowDefinition{ Height = GridLength.Auto },
					new RowDefinition{ Height = GridLength.Auto },
					new RowDefinition{ Height = GridLength.Auto },
					new RowDefinition{ Height = GridLength.Auto }
				},
				ColumnDefinitions = {
					new ColumnDefinition{ Width = GridLength.Auto },
					new ColumnDefinition{ Width = GridLength.Auto },
					new ColumnDefinition{ Width = GridLength.Auto }
				}
			};

			grid.Children.Add (new Label{Text="A"},0,0);
			grid.Children.Add (new Label{Text="A"},0,1);
			grid.Children.Add (new Label{Text="A"},0,2);
			grid.Children.Add (new Label{Text="A"},0,3);
//			grid.Children.Add (new Button{Text="A",VerticalOptions=LayoutOptions.End,HorizontalOptions=LayoutOptions.End},0,4);

			grid.Children.Add (new Label{Text="A"},1,0);
			grid.Children.Add (new Label{Text="A"},1,1);
			grid.Children.Add (new Label{Text="A"},1,2);
			grid.Children.Add (new Label{Text="A"},1,3);
			grid.Children.Add (new Label{Text="A"},1,4);

			grid.Children.Add (new Label{Text="A"},2,0);
			grid.Children.Add (new Label{Text="A"},2,1);
			grid.Children.Add (new Label{Text="A"},2,2);
			grid.Children.Add (new Label{Text="A"},2,3);
			grid.Children.Add (new Label{Text="A"},2,4);

			st = new StackLayout {
				BackgroundColor = Color.Red,
				HeightRequest = 140,
				Children = {
					grid
				},
				Padding = 0

			};
			Button btn = new Button {
				Text="Testing Button",
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.EndAndExpand
			};
//			btn.Clicked += (sender, e) => {this.st.Padding = this.st.Padding==0?10:0;};
			btn.Clicked += new EventHandler (tapG);
			ContentView cv = new ContentView {
				BackgroundColor=Color.Gray,
				Content = new Label
				{
					Text = "This is ContentView",
					FontSize = 20,
					FontAttributes = FontAttributes.Bold,
					TextColor = Color.White
				},
			};

			Frame frm = new Frame {
				Content = new Label{ Text = "This is A Frame", FontSize = 40 },
				OutlineColor = Color.Red,
				HasShadow = true

			};
			Picker pkr = new Picker{ Title = "Option" };
			pkr.Items.Add ("1");
			pkr.Items.Add ("2");
			pkr.Items.Add ("3");
			pkr.Items.Add ("4");

			DatePicker dp = new DatePicker {
				Format = "D"
			};
			TimePicker timePicker = new TimePicker {
				Format = "T"
			};
			timePicker.PropertyChanged += (sender, e) =>
			{
				if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
				{
					lbl.Text = timePicker.Time.ToString();
				}
			};

			StackLayout stackLayout = new StackLayout {
				Children = {
					lbl,
					st,
					cv,
					frm,
					pkr,
					dp,
					timePicker,
					btn,
				},
				BackgroundColor=Color.Blue,
				Padding=30,
//				Orientation = StackOrientation.Horizontal
//				HorizontalOptions=LayoutOptions.Center,
//				VerticalOptions=LayoutOptions.Center
			};

            ScrollView scrollView = new ScrollView{
	            //BackgroundColor = Color.White,
	            VerticalOptions = LayoutOptions.FillAndExpand,
				Content = stackLayout
            }; 

            //this.BackgroundColor = Color.Black; //White

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);
			//Final content
            this.Content = scrollView; 
			//sds
		}

		void tapG(object sender,EventArgs e)
		{
			st.Padding=(st.Padding==0?10:0);
			DisplayAlert ("Toast", "Hellow there", "OK","Cancel");
		}
	}
}


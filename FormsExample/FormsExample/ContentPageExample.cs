using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace FormsExample
{
	class ContentPageExample : ContentPage
	{
		public ContentPageExample()
		{
			Grid grid = new Grid {
				BackgroundColor = Color.Aqua,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
//				VerticalOptions=LayoutOptions.FillAndExpand,
				RowDefinitions={new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto}},
				ColumnDefinitions={new ColumnDefinition{Width=GridLength.Auto},new ColumnDefinition{Width=GridLength.Auto},new ColumnDefinition{Width=GridLength.Auto}}
			};

			Grid grid1 = new Grid {
				BackgroundColor = Color.Aqua,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions=LayoutOptions.Center,
				//				VerticalOptions=LayoutOptions.FillAndExpand,
				RowDefinitions={new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto},new RowDefinition{Height=GridLength.Auto}},
				ColumnDefinitions={new ColumnDefinition{Width=GridLength.Auto},new ColumnDefinition{Width=GridLength.Auto},new ColumnDefinition{Width=GridLength.Auto}}
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

			StackLayout stackLayout = new StackLayout {
				Children = {
					new StackLayout{
						BackgroundColor=Color.Red,
						//						HeightRequest=140,
						Children={
							grid,
						}

					},
					new StackLayout{
						BackgroundColor=Color.Red,
						//						HeightRequest=140,
						Children={
							grid,
						}
					}
				},
				BackgroundColor=Color.Blue,
				Padding=10,
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

	}
} 


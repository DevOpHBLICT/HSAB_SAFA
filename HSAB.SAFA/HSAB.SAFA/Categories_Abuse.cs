
using System;
using System.Collections.Generic;
using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{






    public class Categories_Abuse : ContentPage
    {
    


        public class GetFrontPage
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }

        public void Physical_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Physical Abuse";
            var tg = new d("3", "Physical Abuse", "#953735");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Domestic_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Domestic Abuse";
            var tg = new d("4", "Domestic Abuse", "#d99694");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Sexual_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Sexual Abuse";
            var tg = new d("5", "Sexual Abuse", "#e6b9b8"); ;
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }


        public void Psychological_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Psychological Abuse";
            var tg = new d("6", "Psychological Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Financial_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Financial or Material Abuse";
            var tg = new d("7", "Financial or Material Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Modern_Slavery_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Modern Slavery";
            var tg = new d("8", "Modern Slavery", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Discriminatory_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Discriminatory Abuse";
            var tg = new d("9", "Discriminatory Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Organisational_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Organisational Abuse";
            var tg = new d("10", "Organisational Abuse", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Neglect_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Neglect and acts of omission";
            var tg = new d("11", "Neglect and acts of omission", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }

        public void Self_Neglect_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Self Neglect";
            var tg = new d("12", "Self Neglect", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }




        public Categories_Abuse()
        {


            App.app_title = "Categories of Abuse";
            Title = "Categories of Abuse";
            BackgroundColor = Color.White;

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.White;

            title = new Label
            {
                Text = "HSAB Safeguarding Adults from Abuse (SAFA)",
                XAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(30),
                BackgroundColor = Color.White
            };

            title.TextColor = Color.FromHex("#953735");

         
            var data = new List<GetFrontPage>  {

            new GetFrontPage("Physical abuse", "down.png"),
                new GetFrontPage("Domestic abuse", "down.png"),
                   new GetFrontPage("Sexual abuse", "down.png"),
                   new GetFrontPage("Psychological abuse", "down.png"),
                      new GetFrontPage("Modern Slavery", "down.png"),
               new GetFrontPage("Discriminatory abuse", "down.png"),
                 new GetFrontPage("Organisational abuse", "down.png"),
                 new GetFrontPage("Neglect and acts of omission", "down.png"),
                      new GetFrontPage("Self Neglect", "down.png"),

            };



            Button Physical_Abuse = new RoundedCornersButton {TextColor=Color.White, BackgroundColor = Color.FromHex("#953735"), BorderWidth = 2, Text = "Physical", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Domestic_Abuse = new RoundedCornersButton {TextColor= Color.FromHex("#953735"), BackgroundColor = Color.FromHex("#d99694"), BorderWidth = 2, Text = "Domestic", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Sexual_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("#953735"), BackgroundColor = Color.FromHex("#e6b9b8"), BorderWidth = 2, Text = "Sexual", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Psychological_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("#953735"), BackgroundColor = Color.FromHex("#bfbfbf"), BorderWidth = 2, Text = "Psychological", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Financial_Abuse = new RoundedCornersButton { TextColor = Color.White, BackgroundColor = Color.FromHex("#953735"), BorderWidth = 2, Text = "Financial/Material", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Modern_Slavery = new RoundedCornersButton { TextColor = Color.FromHex("#953735"), BackgroundColor = Color.FromHex("#d99694"), BorderWidth = 2, Text = "Modern Slavery", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Discriminatory_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("#953735"), BackgroundColor = Color.FromHex("#e6b9b8"), BorderWidth = 2, Text = "Discriminatory", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Organisational_Abuse = new RoundedCornersButton { TextColor = Color.FromHex("#953735"), BackgroundColor = Color.FromHex("#bfbfbf"), BorderWidth = 2, Text = "Organisational", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Neglect_Abuse = new RoundedCornersButton {TextColor=Color.White, BackgroundColor = Color.FromHex("#953735"), BorderWidth = 2, Text = "Neglect and acts of omission", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
            Button Self_Neglect = new RoundedCornersButton { TextColor = Color.FromHex("#953735"), BackgroundColor = Color.FromHex("#d99694"), BorderWidth = 2, Text = "Self-neglect", HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };

            var grid = new Grid
            {
                Padding = 10,
                RowSpacing = 5
            };

    


            if (Device.OS == TargetPlatform.Windows)
            {
                Physical_Abuse.HeightRequest = 90;
                Domestic_Abuse.HeightRequest = 90;
                Sexual_Abuse.HeightRequest = 90;
                Psychological_Abuse.HeightRequest = 90;
                Financial_Abuse.HeightRequest = 90;
                Modern_Slavery.HeightRequest = 90;
                Discriminatory_Abuse.HeightRequest = 90;
                Organisational_Abuse.HeightRequest = 90;
                Neglect_Abuse.HeightRequest = 90;
                Self_Neglect.HeightRequest = 90;

            }


            Physical_Abuse.Clicked += Physical_Abuse_Clicked;
            Domestic_Abuse.Clicked += Domestic_Abuse_Clicked;
            Sexual_Abuse.Clicked += Sexual_Abuse_Clicked;
            Psychological_Abuse.Clicked += Psychological_Abuse_Clicked;
            Financial_Abuse.Clicked += Financial_Abuse_Clicked;
            Modern_Slavery.Clicked += Modern_Slavery_Clicked;
            Discriminatory_Abuse.Clicked += Discriminatory_Abuse_Clicked;
            Organisational_Abuse.Clicked += Organisational_Abuse_Clicked;
            Neglect_Abuse.Clicked += Neglect_Abuse_Clicked;
            Self_Neglect.Clicked += Self_Neglect_Abuse_Clicked;


            
            


            var logo = new StackLayout
            {
                Padding = new Thickness(2,2, 2,2),
                Orientation = StackOrientation.Horizontal,

                Children = {
          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.CenterAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                          HeightRequest=25,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "HSAB.png" )
            }
                }

            };
            var i = new Image
            {

                //     BackgroundColor =Color.White,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 70,
                //   WidthRequest=90,
                //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                Source = ImageSource.FromFile("Page1.png")
            };
            var k = new StackLayout
            {
                Padding = 5,
                //  BackgroundColor = Color.White,
                Children = {
                   i,
                   
                         Physical_Abuse,
            Domestic_Abuse,
            Sexual_Abuse,
            Psychological_Abuse,
            Financial_Abuse,
            Modern_Slavery,
            Discriminatory_Abuse,
            Organisational_Abuse,
            Neglect_Abuse,
            Self_Neglect,
            logo

                }
            };

            Content = k;


                   }
    }
}
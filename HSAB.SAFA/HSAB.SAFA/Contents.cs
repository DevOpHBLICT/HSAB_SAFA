﻿
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{






    public class Contents : ContentPage
    {
        private ListView _pharmacylist;





        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }




        public void Recognizing_Abuse_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Safeguarding Adults from Abuse (SAFA)";
            var tg = new d("14", "safeguarding Adults from Abuse (SAFA)", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Reporting_Concerns_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Reporting a Concern";
            var tg = new d("17", "Reporting a concern", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }
        public void Making_Safeguarding_Personal_Clicked(object sender, EventArgs args)
        {
            App.app_title = "Making Safeguarding Personal";
              var tg = new d("21", "Making safeguarding personal", "#bfbfbf");
          // var tg= new LocalHtmlBaseUrl { Title = "BaseUrl" };
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

        }



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


        public class VC : ViewCell
        {
            public VC()
            { }
        }

        public Contents()
        {

            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Hertfordshire Primary Care", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };



            var t = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "", Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };
            var u = new Label { Text = "", FontSize = 10 };

            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";

            App.app_title = "HSAB SAFA Prompts";
            Title = "HSAB SAFA Prompts";
            BackgroundColor = Color.FromHex("FCDED4");
            
         
            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.White;




            var data = new List<GetFrontPage>  {

            new GetFrontPage("Definition of an Adult at Risk", "Flag1.png"),
                new GetFrontPage("What is Safeguarding?", "Flag2.png"),
                   new GetFrontPage("Categories of Abuse", "Flag3.png"),
               new GetFrontPage("Recognising Abuse", "Flag4.png"),
                 new GetFrontPage("Reporting a Concern", "Flag5.png"),
                 new GetFrontPage("Making Safeguarding Personal", "Flag6.png"),

            };
           
            _pharmacylist = new ListView
            {

                SeparatorColor = Color.FromHex("#ddd"),
            };
            _pharmacylist.ItemsSource = data;
            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("a50100"));
            _pharmacylist.HasUnevenRows = true;

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
                              
            _pharmacylist.ItemTemplate = cell;
               _pharmacylist.RowHeight = 60;
               

           
            var a = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HorizontalOptions = LayoutOptions.CenterAndExpand

                //  Padding = new Thickness (5, 5, 5, 5), 
            };
            if (Device.OS == TargetPlatform.Windows)
            {

                //  Padding = new Thickness (5, 5, 5, 5), 
                a.Children.Add(s);
                a.Children.Add(t);
                a.Children.Add(u);
                NavigationPage.SetHasNavigationBar(this, false);
            }
            else
            {
                a.Children.Add(t);
                a.Children.Add(u);


            }


            


            var logo = new StackLayout
            {
                Padding = new Thickness(2, 2, 2, 2),
                Orientation = StackOrientation.Horizontal,

                Children = {
          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.CenterAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                          HeightRequest=40,
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
                HeightRequest = 150,
                //   WidthRequest=90,
                //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                Source = ImageSource.FromFile("ab1.png")
            };
            var k = new StackLayout
            {
                Padding = 2,
                //  BackgroundColor = Color.White,
                Children = {
                   i, _pharmacylist,logo

                }
            };

            Content = k;






            _pharmacylist.ItemSelected += (sender, e) =>
            {


                if (e.SelectedItem == null) return;
                var user = (GetFrontPage)e.SelectedItem;
                if (user.Name == "Definition of an Adult at Risk")
                {
                    App.app_title = "Definition of an Adult at Risk";
                    var tg = new definition("1", "Definition of an Adult at Risk", "#953735");
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "What is Safeguarding?")
                {
                    App.app_title = "What is Safeguarding?";
                    var tg = new What_Is_Safeguarding(App.app_title);
               
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));

                }
                if (user.Name == "Categories of Abuse")
                {
                    App.app_title = "Categories of Abuse";
                    var tg = new Categories_Abuse();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Recognising Abuse")
                {
                    App.app_title = "Recognising Abuse";
                    var tg = new Recognising_Abuse();
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }


                if (user.Name == "Reporting a Concern")
                {
                    App.app_title = "Reporting a concern";
                    var tg = new d("17", "Reporting a concern", "#bfbfbf");
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }
                if (user.Name == "Making Safeguarding Personal")
                {
                    App.app_title = "Making Safeguarding Personal";
                    var tg = new Making_Safeguarding_Better();

                    Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
                }



                if (e.SelectedItem == null) return; // don't do anything if we just de-selected the row
                                                    // do something with e.SelectedItem
                ((ListView)sender).SelectedItem = null; // de-select the row

            };
        }
    }
}
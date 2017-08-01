
using System;
using System.Collections.Generic;



using System.Text;
using System.IO;
using Xamarin.Forms;
using System.Linq;

namespace HSAB.SAFA
{




    public class definition : ContentPage
    {

        Button home;
        Button back;

        private string sp;
        private string t;
        private string yesnext;
        private string nonext;
        String _BGColor;





        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new d(yesnext, t, _BGColor);
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }

        void BackButtonClicked(object sender, EventArgs e)
        {
            back.IsEnabled = false;

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }
        void HomeButtonClicked(object sender, EventArgs e)
        {

            var page = Navigation.NavigationStack.First();
            while (page.Navigation.NavigationStack.Count > 1)
            { page.Navigation.PopAsync(); }




        }




        public definition(string startpage, String Titles, String BGColor)
        {
            Title = "Definition of an adult at risk";
            Label l = new Label { Text = "\r\n According to The Care Act (2014), an adult at risk is a person who:" };
            Image logo = 
          new Image {
                                
                           //     BackgroundColor =Color.White,
                                  VerticalOptions = LayoutOptions.CenterAndExpand,
                           HorizontalOptions = LayoutOptions.CenterAndExpand,
                           HeightRequest=30,
                        //   WidthRequest=90,
                   //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
                            Source =ImageSource.FromFile( "down.png" )
            
                
            };

            Image logo2 =
          new Image
          {

              //     BackgroundColor =Color.White,
              VerticalOptions = LayoutOptions.CenterAndExpand,
              HorizontalOptions = LayoutOptions.CenterAndExpand,
              //   WidthRequest=90,
              HeightRequest =30,
              //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
              Source = ImageSource.FromFile("down.jpg")


          };
            Image P1 =
       new Image
       {

              //     BackgroundColor =Color.White,
              VerticalOptions = LayoutOptions.CenterAndExpand,
           HorizontalOptions = LayoutOptions.CenterAndExpand,
              //   WidthRequest=90,
              HeightRequest = 90,
              //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
              Source = ImageSource.FromFile("p1.png")


       };
            Image P2 =
                  new Image
                  {

           //     BackgroundColor =Color.White,
           VerticalOptions = LayoutOptions.CenterAndExpand,
                      HorizontalOptions = LayoutOptions.CenterAndExpand,
           //   WidthRequest=90,
           HeightRequest = 90,
           //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
           Source = ImageSource.FromFile("p2.png")


                  };

            Image P3 =
      new Image
      {

           //     BackgroundColor =Color.White,
           VerticalOptions = LayoutOptions.CenterAndExpand,
          HorizontalOptions = LayoutOptions.CenterAndExpand,
           //   WidthRequest=90,
           HeightRequest = 90,
           //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
           Source = ImageSource.FromFile("p3.png")


      };


            ContentView s = new ContentView {
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),
                BackgroundColor = Color.FromHex("c0504d"),
                Content =

                    new Label
                    {
                        FontFamily = "Calibri",
                        FontSize = 20,

                        TextColor = Color.White,
                        Text = "Has care and support needs, whether or not the Local Authority e.g. Hertfordshire County Council (HCC) is meeting any of those needs And;" }
            };

            ContentView t = new ContentView
            {
                BackgroundColor = Color.FromHex("953735"),
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),

                Content =
                new Label
                {
                    FontFamily="Calibri",
                    FontSize= 20,
                    TextColor = Color.White,
                    Text = "Is experiencing, or at risk of, abuse or neglect; And"
                }
            };
            ContentView u = new ContentView
            {
                BackgroundColor = Color.FromHex("632523"),
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),

                Content =
               new Label
               {
                   FontFamily = "Calibri",
                   FontSize = 20,

                   TextColor = Color.White,
                   Text = "As a result of those care and support needs is unable to protect themselves from abuse or neglect or the risk of it. "
               }
            };

            Content = new StackLayout{
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),

                Children = { l,P1,logo, P2,logo2, P3} };

        }
    }
}

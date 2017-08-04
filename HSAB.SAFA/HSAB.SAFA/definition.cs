
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
            Title = "Definition";
            Label l = new Label { Text = "\r\n According to The Care Act (2014), an adult at risk is a person who:" };
            Image logo =
          new Image
          {

              //     BackgroundColor =Color.White,
              VerticalOptions = LayoutOptions.CenterAndExpand,
              HorizontalOptions = LayoutOptions.CenterAndExpand,
              HeightRequest = 30,
              //   WidthRequest=90,
              //               Aspect = Aspect.AspectFit,//.AspectFit//.Fill  
              Source = ImageSource.FromFile("down.png")


          };

            Image logo2 =
          new Image
          {

              //     BackgroundColor =Color.White,
              VerticalOptions = LayoutOptions.CenterAndExpand,
              HorizontalOptions = LayoutOptions.CenterAndExpand,
              //   WidthRequest=90,
              HeightRequest = 30,
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

            

            ContentView t = new ContentView
            {
                BackgroundColor = Color.FromHex("953735"),
                Padding = new Thickness(15, Device.OnPlatform(15, 0, 0), 15, 15),

                Content =
                new Label
                {
                    FontFamily = "Calibri",
                    FontSize = 20,
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

            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();

          


            htmlSource.Html = @"<html> 
 <head> 
<style>
*{
color:#878787;
}
.box {

  border: 2px solid #7d2732;
     border-radius: 5px;
margin-top:5px;
padding:5px;5px;5px;5px;
}

textblock
{
padding:5px;5px;5px;5px;
}
#id
{
color:#923b3d !important;
}
b{
color:#923b3d !important;
}
pre{overflow:auto; max-width:100%}
h2{
color:#923b3d;
}
.down-arrow1 {
   margin-left:20%;
	width: 0; 
  height: 0; 
  border-left: 20px solid transparent;
  border-right: 20px solid transparent;
  
  border-top: 20px solid #923b3d;
}
.down-arrow2 {
   margin-left:50%;
	width: 0; 
  height: 0; 
  border-left: 20px solid transparent;
  border-right: 20px solid transparent;
  
  border-top: 20px solid #923b3d;
}
</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body> 
<p><h2 id='bb'>Definition of an adult at risk</h2>
<img src='P.png' height='90px'/>
<p>According to The Care Act (2014), an adult at risk is a person who:  
 
<p>Has care and support needs, whether or not the Local Authority e.g. Hertfordshire County Council (HCC) is meeting any of those needs <b>And</b>;
<hr/>
<p>Is experiencing, or at risk of, abuse or neglect; <b>And;</b>
<hr/>
<p>As a result of those care and support needs is unable to protect themselves from abuse or neglect or the risk of it. </div>
<hr/>


  </body>
</html>";








                htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
                browser.Source = htmlSource;



                Content=   browser ;
            }
        }
    }


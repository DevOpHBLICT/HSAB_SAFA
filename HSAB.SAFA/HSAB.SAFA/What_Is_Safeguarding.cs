
using System;
using System.Collections.Generic;

using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{


    

    

    public class What_Is_Safeguarding : ContentPage
    {
     

       


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }

 

        public What_Is_Safeguarding(String Titles)
        {


            App.app_title = Titles;
            Title = Titles;
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
                Text = "What Is Safeguarding",
                XAlign = TextAlignment.Center,
                 Font = Font.SystemFontOfSize(30),
                    BackgroundColor=Color.White
                };

                title.TextColor = Color.FromHex("#953735");

            //  var pharm = database.GetContents();

            //  BackgroundImage = "people.jpg";


            Button Physical_Abuse = new RoundedCornersButton { Text = "protecting an adult's right to live in safety, free from abuse and neglect.", BackgroundColor = Color.Transparent, BorderColor = Color.FromHex("#7D4D68"), BorderWidth = 5, TextColor = Color.FromHex("#7D4D68"), VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand,HeightRequest=200, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };





                    Button Domestic_Abuse = new RoundedCornersButton { Text = "Stop abuse or neglect where possible.", BackgroundColor = Color.Transparent, BorderColor = Color.FromHex("0d3893"), BorderWidth = 5, TextColor = Color.FromHex("0d3893"), VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand, HeightRequest = 200, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };




                 Button Sexual_Abuse = new RoundedCornersButton { Text = "Prevent harm and reduce the risk of abuse or neglect in a way that supports them in making choices and having control about how they want to live.", BackgroundColor = Color.Transparent, BorderWidth = 5, BorderColor = Color.FromHex("#C0504D"), TextColor = Color.FromHex("#C0504D"), HeightRequest = 200, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };



                   Button Psychological_Abuse = new RoundedCornersButton { Text = "Raise public awareness to enable communities as a whole, together with professionals, help to prevent, identify and respond to abuse and neglect.", BackgroundColor = Color.Transparent, BorderColor = Color.FromHex("#9BBB59"), BorderWidth = 5, TextColor = Color.FromHex("#9BBB59"), HeightRequest = 200, HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)) };
           
             
            var grid = new Grid
            { 
             
            };

            Label l = new Label { Text = "Safeguarding means:" };
          ;
            grid.Children.Add(Physical_Abuse, 0, 1); // Left, First element 
            grid.Children.Add(Domestic_Abuse, 1, 1); // Right, First element 
            grid.Children.Add(Sexual_Abuse, 0, 2); // Left, Second element 
            grid.Children.Add(Psychological_Abuse, 1, 2); // Right, Second element 
          


            if (Device.OS == TargetPlatform.Windows)
            {
               Physical_Abuse.HeightRequest = 90;
               Domestic_Abuse.HeightRequest = 90;
               Sexual_Abuse.HeightRequest = 90;
                Psychological_Abuse.HeightRequest = 90;
                     }
            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
            browser.HeightRequest = 400;
            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;




            htmlSource.Html = @"<html> 
 <head> 
<style>

#id
{
color:#923b3d !important;
}
b{
color:#923b3d !important;
}

html, body { height: 80%; padding: 0; margin: 0; }
*{
color:#878787;
}
body
{
margin:20px;
}
}
</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body>
<img src='P.png' height='100px'/>
<p><h2><b id ='bb'>Safeguarding means:</b></h2></p>
<p><b id='bb'>Protecting </b> an adult's right to live in safety, free from abuse and neglect.</div>

<p><b id='bb'>Stop abuse</b> or neglect where possible.</div>

<p><b id='bb'>Prevent</b> harm and reduce the risk of abuse or neglect in a way that supports them in making choices and having control about how they want to live.</div>

<p><b id='bb'>Raise</b> public awareness to enable communities as a whole, together with professionals, help to prevent, identify and respond to abuse and neglect.</div>

  </body>
</html>";




            Content = browser;

        }
    }
}
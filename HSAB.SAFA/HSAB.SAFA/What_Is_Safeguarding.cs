﻿
using System;
using System.Collections.Generic;

using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{


    

    

    public class What_Is_Safeguarding : ContentPage
    {

        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Categories_Abuse();
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }




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


          

            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
            browser.HeightRequest = 420;
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
color:#595959;

font-family:'HelveticaNeue-Light','Helvetica','Arial';
}
body
{
margin:5px;
}

</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body>
<div align='center'>
<img src='v1.png' height='80px' />
</div>
<p><h2><b id ='bb'>Safeguarding means:</b></h2></p>
<p><b id='bb'>Protecting </b> an adult's right to live in safety, free from abuse and neglect.</div>

<p><b id='bb'>Stop abuse</b> or neglect where possible.</div>

<p><b id='bb'>Prevent</b> harm and reduce the risk of abuse or neglect in a way that supports them in making choices and having control about how they want to live.</div>

<p><b id='bb'>Raise</b> public awareness to enable communities as a whole, together with professionals, help to prevent, identify and respond to abuse and neglect.</div>

  </body>
</html>";

            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)), Text = "Categories of Abuse", IsVisible = true, Image = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White };
            yes.Clicked += OnyesButtonClicked;
            yes.HeightRequest = 70;

            var x = new StackLayout
            {

                Padding = new Thickness(3, 3, 3, 3),
                Children = {
                    browser,   
                    yes,
                }
            };


            Content = new ScrollView { Content = x };


         
        } 
    }
}
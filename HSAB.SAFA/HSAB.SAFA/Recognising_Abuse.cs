﻿
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{

    //asdfasdf




    public class Recognising_Abuse : ContentPage
    {
      

        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Recognising_Abuse2();
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
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



        public Recognising_Abuse()
        {

         
            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";

            App.app_title = "Recognising Abuse";
            Title = "Recognising Abuse";
            BackgroundColor = Color.White;

        
            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.White;

            


          
            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
            browser.HeightRequest = 600;
       



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
font-family:'HelveticaNeue-Light','Helvetica','Arial';
color:#595959;
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

<h2><b id ='bb'>Risk</b></h2>Risk is not in itself a safeguarding issue, as not all risks will result in a negative impact on the individual.
<h2><b id='bb'>Abuse</b></h2>May be an isolated incident or multiple, affecting one or more people.
<h2><b id='bb'>Harm</b></h2> Should be taken to include not only ill treatment but also the impairment of, or avoidable deterioration in, physical or mental health and the impairment of physical, intellectual, emotional, social or behavioural development.</div>


  </body>
</html>";




            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;

            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)), Text = "Next", IsVisible = true, Image = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White };
            yes.Clicked += OnyesButtonClicked;
            yes.HeightRequest = 70;
             Content = new StackLayout
            {
                Padding=5,
                Children = {  browser,yes}
            };

            
          }
    }
}
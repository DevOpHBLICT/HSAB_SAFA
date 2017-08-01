
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{






    public class Making_Safeguarding_Better : ContentPage
    {
        private ListView listView;
        private ListView _pharmacylist;


        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Making_Safeguarding_Better();
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }




        
        public class GetFrontPage2
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage2(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }



        public Making_Safeguarding_Better()
        {

            var s = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "Hertfordshire Primary Care", TextColor = Color.FromHex("1760ae"), Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };



            var t = new Label { HorizontalTextAlignment = Xamarin.Forms.TextAlignment.Center, Text = "", Font = Font.SystemFontOfSize(20, FontAttributes.Bold) };
            var u = new Label { Text = "", FontSize = 10 };

            //    var u = new Label { Text = "Antibiotics Guidelines" , TextColor = Color.FromHex("1760ae"), FontSize = 10 };
            //   Title = "Contents";

            App.app_title = "Personal Safeguarding";
            Title = "Personal Safeguarding";
            BackgroundColor = Color.White;

            Label title = null;

            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.White;




            var data = new List<GetFrontPage2>  {

            new GetFrontPage2("Making safeguarding personal is a shift in culture and professional practice.", "Arrow1.png"),
            new GetFrontPage2("It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety.", "Arrow2.png"),
            new GetFrontPage2("It is about empowering the adult at risk to ensure that their wishes/desired outcomes are considered as part of the safeguarding process.", "Arrow3.png"),
            new GetFrontPage2("It is about seeing people as experts in their own lives and working alongside them.", "Arrow25.png"),
            new GetFrontPage2("The alerter must note the person’s wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority.", "Arrow4.png"),
  
            };

            _pharmacylist = new ListView
            {

                SeparatorColor = Color.FromHex("#ddd"),
            };
            _pharmacylist.ItemsSource = data;
            var cell = new DataTemplate(typeof(ImageCell));
            cell.SetValue(TextCell.TextColorProperty, Color.FromHex("1760ae"));
            //  cell.SetValue(TextCell.TextProperty, );

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");
            _pharmacylist.ItemTemplate = cell;
            // _pharmacylist.ItemTemplate = new DataTemplate(typeof(ImageCell));
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.TextProperty, "Name");
            // _pharmacylist.ItemTemplate.SetBinding(ImageCell.ImageSourceProperty, "Image");
            // _pharmacylist.SetValue(TextCell.TextColorProperty, Color.White);
            //  _pharmacylist.HeightRequest = 500;
            _pharmacylist.RowHeight = 130;
            _pharmacylist.HasUnevenRows = true;
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

            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
            /*
htmlSource.Html = @"<html> 
 <head> 
 <link rel=""stylesheet"" href=""default.css""> 
 </head> 
 <body> 
 <h1>Xamarin.Forms</h1> 
 <p>The CSS and image are loaded from local files!</p> 
 <img src='XamarinLogo.png'/> 
 <p><a href=""local.html"">next page</a></p> 
 </body> 
 </html>";
            */

            htmlSource.Html = @"<html> 
 <head> 
 <link rel=""stylesheet"" href=""default.css""> 
 </head> 
 <body> 
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div><td><td> Making safeguarding personal is a shift in culture and professional practice. </td></tr> 
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td>It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety.  </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div><td><td>It is about empowering the adult at risk to ensure that their wishes/ desired outcomes are considered as part of the safeguarding process. </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td>The alerter must note the person's wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority.  </td></tr></table>

 </ body> 
 </html>";


            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
          browser.Source = htmlSource;



            Content = browser;


/*
var ss =@"<p><img style = 'float: left; margin: 5px 15px 15px 0px;' src = '~/Arrow1.png' /> Making safeguarding personal is a shift in culture and professional practice. </ p >";
 ss=ss+"<p><img style = 'float: left; margin: 5px 15px 15px 0px;' src = '~/Arrow2.png' />It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety. ";
   ss=ss+"<p><img style = 'float: left; margin: 5px 15px 15px 0px;' src = '~/Arrow3.png' />It is about empowering the adult at risk to ensure that their wishes/ desired outcomes are considered as part of the safeguarding process.</ p >";
 ss=ss+"<p><img style = 'float: left; margin: 5px 15px 15px 0px;' src = '~/Arrow4.png' />The alerter must note the person's wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority. </ p >";
 */
         //   var web = new WebView();
         //   var html = new HtmlWebViewSource
         //   {
         //       Html = ss
         //   };


         //   web.Source = html;
           // Content = web;


        }
    }
}
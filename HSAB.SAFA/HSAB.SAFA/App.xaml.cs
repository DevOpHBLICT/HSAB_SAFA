using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HSAB.SAFA
{



	public partial class App : Application
	{

        public static String app_title { get; set; }

        public static NavigationPage NavPage { get; set; }

        public App ()
		{
			InitializeComponent();

            NavPage = new NavigationPage(new Contents());
            if (Device.OS != TargetPlatform.Windows)
            {
                

                NavPage.BarBackgroundColor = Color.FromHex("923b3d");
                NavPage.BarTextColor = Color.White;
                NavPage.ToolbarItems.Add(new ToolbarItem
                {

                    //  Text = "Home",
                    //    Icon ="back.png",
                    Icon = "home.png",
                    //    Command = new Command(() => nav.PushAsync(new Contents(database))),
                    Command = new Command(() => App.NavPage.PopToRootAsync())
                });
                App.NavPage.ToolbarItems.Add(new ToolbarItem
                {

                    //  Text = "Home",
                    //    Icon ="back.png",
                    Icon = "info2.png",
                    //    Command = new Command(() => nav.PushAsync(new Contents(database))),
                    Command = new Command(() =>

                    
                       App.NavPage.PushAsync(new info_2(app_title))
                )
                });

            }
            MainPage = NavPage;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

using System;
using System.Collections.Generic;


using System.Text;
using Xamarin.Forms;
namespace HSAB.SAFA


{



    public class info_2 : CarouselPage
    {
        string s = "";
        string a = "";
        string b = "";
        string c = "";
        string d = "";
        string e = "";

       
        void BackButtonClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }

        public info_2(String info)
        {
            BackgroundColor = Color.White;



            Title = info;
         
            
            // Label title = null;
            Button home = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "home", TextColor = Color.Black };
            home.IsVisible = false;
            if (Device.OS == TargetPlatform.Windows)
            {
                   Button back = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Image = "back" };
                Button next = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "next", TextColor = Color.Black };
                back.Image = (FileImageSource)ImageSource.FromFile("back.png");
                back.HorizontalOptions = LayoutOptions.End;
                back.VerticalOptions = LayoutOptions.End;
                back.BackgroundColor = Color.Transparent;

                back.Clicked += BackButtonClicked;
                home.IsVisible = true;
                BackgroundColor = Color.White;
                NavigationPage.SetHasNavigationBar(this, false);
                //   this.TranslationY = -40;
            }

            Label LItalic = new Label
            {
             //    HorizontalTextAlignment = TextAlignment.Center,

            };

            var fs = new FormattedString();
        
            fs.Spans.Add(new Span { ForegroundColor = Color.Black, FontSize = 14, FontAttributes = FontAttributes.Italic, Text = "'The requirement for continuous / complete supervision and control cannot and should not be interpreted as requiring 24 hour monitoring and/or that the person is to be physically accompanied over a continuous 24 hour period. In other words, if the individual is subject to such monitoring or such degree of accompaniment, then the necessary degree of continuity or completeness will be satisfied. But it is capable of being satisfied even if the supervision and control is 'lighter touch'" });
            



            Label title2 = new Label
            {
                Text = "Additional information",
                HorizontalTextAlignment = TextAlignment.Center,
                Font = Font.SystemFontOfSize(14)

            };
            title2.TextColor = Color.FromHex("#953735");
            Label l1 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l1.TextColor = Color.Black;
            l1.IsEnabled = true;

            Label l2 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l2.TextColor = Color.Black;
            l2.IsEnabled = true;

            Label l3 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l3.TextColor = Color.Black;
            l3.IsEnabled = true;

            Label l4 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l4.TextColor = Color.Black;
            l4.IsEnabled = true;
            Label l5 = new Label
            {
                InputTransparent = true,
                HorizontalTextAlignment = TextAlignment.Start,
                Font = Font.SystemFontOfSize(14)

            };
            l5.TextColor = Color.Black;
            l5.IsEnabled = true;
            if (info == "HSAB SAFA Prompts")
            {
               
                a = "Copyright HSAB and HBL ICT Services \r\n\r\n The following staff developed this app: \r\n\r\n Tracy Cooper \r\n Jane Newcombe \r\n Neil Wallace \r\n Michael Lamb \r\n Caroline Raut \r\n\r\n The responsible officers for this app are: \r\n Caroline.Aitken@hertfordshire.gov.uk or Loraine.Waterworh@hertfordshire.gov.uk";
                l1.Text = a;
            }

            if (info == "Definition of an Adult at Risk")
            {


                a = "Implemented in April 2015 and the biggest change to social care policy in the last 30 years.Safeguarding duties apply to an adult who:";
                a = a + "• Has needs for care and support(whether or not the local authority is meeting any of those needs";
                a = a + "• Is experiencing, or at risk of, abuse or neglect; and";
                a = a + "• As a result of the those care and support needs is unable to protect themselves from the risk of, or the experience of abuse or neglect";
                a = a + "‘The local authority must make(or cause to be made) whatever enquiries it thinks necessary to enable it to decide whether any action should be taken in the adult’s case (whether under this Part or otherwise)";
                a = a + "and, if so, what and by whom.’ (Care Act 2014: Section 42)";
                a = a + "Six key principles underpin all adult safeguarding work";
                a = a + "Empowerment: People being supported and encouraged to make their own decisions and give informed consent.";
                a = a + "Prevention: It is better to take action before harm occurs.";
                a = a + "Proportionality: The least intrusive response appropriate to the risk presented.";
                a = a + "Protection: Support and representation for those in greatest need.";
                a = a + "Partnership: Local solutions through services working with their communities.Communities have a part to play in preventing, detecting and reporting neglect and abuse.";
                a = a + "Accountability: Accountability and transparency in delivering safeguarding.";
                a = a + "If a Safeguarding enquiry is not pursued by the relevant agency, there may be an individual case review for the person to reassess the care package and support, to ensure it is appropriate and meeting the individual’s needs.";
                a = a + "Hertfordshire Safeguarding Adults Board(HSAB)";
                a = a + "Under the Care Act 2014 there is a legal obligation to have a local Safeguarding Adults Board.This is a multi - agency partnership where all agencies in Hertfordshire with a responsibility to safeguard adults at risk meet to coordinate activity and promote wellbeing.";
                a = a + "The HSAB are central to the development interagency policies, scrutinise safeguarding work of the individual agencies and challenge current practices.";
                a = a + "The HSAB can also commission Safeguarding Adult Reviews(SARs) which look in detail into cases where there has been a death or serious harm to an adult at risk and scrutinise how individual agencies dealt with the risks and concerns.From this the HSAB can make recommendations to change in practice and procedures in the organisations involved.";






                l1.Text = a;
//                l2.Text = b;
//                l3.Text = c;
  //              l4.Text = d;
               

            }
            if (info == "What is Safeguarding?")
            {
                a = "Incidents of abuse may be one-off or multiple, and affect one person or more.Professionals and others should look beyond single incidents or individuals to identify patterns of harm.Repeated instances of poor care may be an indication of more serious problems e.g.organisational abuse. It is therefore important to share this information appropriately.";
                a = a + "In 2013, the Home Office made changes to the definition of Domestic Abuse to include:";
                a = a + "·       Incidents of controlling, coercive or threatening behaviour, violence or abuse by someone who is or has been an intimate partner or family member (regardless of gender or sexuality) ";
                a = a + "·       Domestic abuse also includes honour based violence, Female Genital Mutilation and forced marriage.";
                a = a + "·       Local Domestic abuse resources and helplines: www.HertsSunflower.org";
                a = a + "Tel: 08 088 088 088 or offer to refer to Independent Domestic Violence Advisor.";
                a = a + "Sexual exploitation could be considered under Sexual abuse or Modern Slavery.";
                a = a + "Potential indicators of Financial Abuse include:";
                a = a + "·       Change in living conditions";
                a = a + "·       Lack of heating, clothing or food";
                a = a + "·       Inability to pay bills/ unexplained  shortage of money";
                a = a + "·       Unexplained withdrawals form an account";
                a = a + "·       Unexplained loss/ misplacement of financial documents";
                a = a + "·       The recent addition of authorised signers on a client or donor’s signature card";
                a = a + "·       Sudden or unexplained changes in a will or other financial documents";
               
                l1.Text = a;
                l2.Text = b;
                l3.Text = c;
                

            }
            if (info == "Recognising abuse")
            {
                a = a + "Recognising abuse";
                a = a + "Anyone can witness or become aware of information suggesting that abuse and neglect is occurring.The adult may say or do things that hint that all is not well.Regardless of how the safeguarding concern is identified, everyone should understand what to do and where to go locally to get help and advice.";
                a = a + "Professionals should:";
                a = a + "·       Know about the different types of abuse and neglect and their signs";
                a = a + "·       Support the adult to keep safe";
                a = a + "·       Knowing who to tell about suspected abuse or neglect";
                a = a + "·       Support adults to think and weigh up the risks and benefits of different options when exercising choice and control";


                l1.Text = a;

            }

            //  

            if (info == "Reporting a Concern")
            {

                a = "   Reporting a concern";

                a = a + "1.Is there an immediate risk? Consider if the Police need to be called or the person removed to a place of safety. Do you need to inform your line manager?";

                a = a + "2.Call the relevant agency and follow up with a concern form";

                a = a + "3.Discuss concern with person.Record their wishes on the concern form but you have a duty to report even if they say NO.";

                a = a + "4.Describe the circumstances of the suspected or actual abuse and what actions you have taken to try to protect the person. ";

                a = a + "5.Discuss with the Safeguarding lead for your organisation or line manager if you are in any doubt";

                a = a + "6.Email or fax the concern form to the relevant agency";


               s = "\u2022The Deprivation of Liberty Safeguards (DOLS)provides legal protection for people who are, or may become, deprived of their liberty(as described in Article 5 of the European Convention on Human Rights ECHR) in a hospital or care home.\r\n";
                s = s + "\u2022DOLS legislation applies to people aged 18 years or over.\r\n";
                s = s + "DOLS does not apply to a person detained under the Mental Health Act\r\n";
                s = s + "\u2022The person’s capacity must be assessed in relation to the decision about accommodation in a care home or hospital for the purpose of providing care or treatment.\r\n\r\n";
                s = s + "\u2022The Best Interests Assessor(BIA) must satisfy themselves that person has a valid need to be detained in the proposed care setting, that it is in the persons best interests to be detained in that setting and determine whether any harm could arise if the DOLS is not authorised or if there are any less restrictive care options which could avoid DOLS.\r\n\r\n";
                s = s + "\u2022With regards specifically to the continuous supervision and control element of the acid test, please note the Law Society guidance as follows: ";
            
                    
                    l1.Text = s;
                LItalic.FormattedText = fs;

                
            }
          

            var S = new StackLayout
            {
                Spacing = 5,
                HorizontalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Children =
                        {            
                            home,
                   
                        }
            };


            

            var first_page = new ContentPage
            {
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {

                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {
                //        new Label { Text = info,
        //                TextColor = Color.FromHex("#953735"),
        //    XAlign = TextAlignment.Center,
        //        Font = Font.SystemFontOfSize(18)},
                new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                 l1,LItalic
                },
                    }
                }
            };

            var second_page = new ContentPage
            {

                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {

                new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                    l2 ,

                    }
                    }
                }
            };
            var third_page = new ContentPage
            {

                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {
                new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                    l3,


                    }
                    }
                }
            };
            var forth_page = new ContentPage
            {

                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Padding = new Thickness(5, 5, 5, 5),
                        Children = {
                    new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(14)
                 },
                    l4,


                    }
                    }
                }
            };

            var fifth_page = new ContentPage
            {
                Padding = new Thickness(5, 5, 5, 5),
                Content = new ScrollView
                {
                    Content = new StackLayout
                    {
                        Children = {
                 new Label
                 {
                  Text = "Additional information",
                  TextColor = Color.FromHex("#953735"),
                  XAlign = TextAlignment.Center,
                  Font = Font.SystemFontOfSize(16)
                 },
                    l5 ,



                    }
                    }
                }
            };

            if (info == "Assessing Capacity Prompts")
            {
                Children.Add(first_page);
               Children.Add(second_page);
              Children.Add(third_page);
               Children.Add(forth_page);
          
            }
            if (info == "Best Interests Decision")
            {
                Children.Add(first_page);
                Children.Add(second_page);
                Children.Add(third_page);
              
               
            }

            if ((info == "Recognising abuse" ) || (info == "Definition of an Adult at Risk") || (info == "What is Safeguarding?") || (info == "HSAB SAFA Prompts") || (info == "Reporting a Concern") || (info == "Categories of Abuse")) 
            {
                //comment
                Children.Add(first_page);
            }



        }
     

}
    
    
}






using Foundation;
using HSAB.SAFA.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency (typeof (BaseUrl_iOS))]
namespace HSAB.SAFA.iOS
{
    public class BaseUrl_iOS : IBaseUrl
    {
        public string Get()
        {
            return NSBundle.MainBundle.BundlePath; // to load resources in the iOS app itself
        }
    }
}
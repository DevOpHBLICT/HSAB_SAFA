using System; 
 using Xamarin.Forms; 
 using HSAB.SAFA.Android; 
 
 
 [assembly: Dependency(typeof(BaseUrl_Android))] 
 namespace HSAB.SAFA.Android
 { 
 	public class BaseUrl_Android : IBaseUrl  
 	{ 
 		public string Get()
 		{ 
 			return "file:///android_asset/";  		} 
 	} 
 }

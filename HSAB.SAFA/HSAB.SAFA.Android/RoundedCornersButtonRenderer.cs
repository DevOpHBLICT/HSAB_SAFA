using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using HSAB.SAFA;
using HSAB.SAFA.Droid;

[assembly: ExportRenderer(typeof(RoundedCornersButton),typeof(RoundedCornersButtonRenderer))]
namespace HSAB.SAFA.Droid
{
    public class RoundedCornersButtonRenderer : ButtonRenderer
    {
        public override void OnDrawForeground(Canvas canvas)
        {
            base.OnDrawForeground(canvas);
        }
    }
}

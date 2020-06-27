using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CFCAulas.Controls;
using CFCAulas.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(LabelRendererDriod))]
namespace CFCAulas.Droid
{
    class LabelRendererDriod : LabelRenderer
    {
        public LabelRendererDriod(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var view = (CustomLabel)Element;
            if (view == null) return;
            // creating gradient drawable for the curved background  
            Control.JustificationMode = Android.Text.JustificationMode.InterWord;
         
        }

    }
}

//[assembly: ExportRenderer(typeof(CustomLabel), typeof(CurvedLabelRenderer))]  
//namespace XYZApp.iOS
//{
//    public class CurvedLabelRenderer : LabelRenderer
//    {
//        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
//        {
//            base.OnElementChanged(e);
//            if (e.NewElement != null)
//            {
//                var _xfViewReference = (CustomLabel)Element;
//                this.Layer.CornerRadius = (float)_xfViewReference.CurvedCornerRadius;
//                this.Layer.BackgroundColor = _xfViewReference.CurvedBackgroundColor.ToCGColor();
//            }
//        }
//    }
//}
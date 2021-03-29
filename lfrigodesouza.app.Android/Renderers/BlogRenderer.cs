using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using lfrigodesouza.app.Droid.Renderers;
using lfrigodesouza.app.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BlogViewer), typeof(BlogViewerRenderer))]
namespace lfrigodesouza.app.Droid.Renderers
{
    class BlogViewerRenderer : WebViewRenderer
    {
        public BlogViewerRenderer(Context context): base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                // Open this line to activate the workaround
                Control.Settings.SetSupportMultipleWindows(false);
                Control.Settings.SafeBrowsingEnabled = false;
            }
        }
    }
}
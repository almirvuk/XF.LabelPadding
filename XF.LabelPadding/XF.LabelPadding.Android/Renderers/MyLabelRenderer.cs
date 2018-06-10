using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF.LabelPadding.Droid.Renderers;

[assembly: ExportRenderer(typeof(Label), typeof(MyLabelRenderer))]
namespace XF.LabelPadding.Droid.Renderers
{
    public class MyLabelRenderer : LabelRenderer
    {
        public MyLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            /*
             * This is the main part of this renderers
             * using this method we will
             * not include font padding for 
             * our Label controls. */
            Control?.SetIncludeFontPadding(false);
        }
    }
}
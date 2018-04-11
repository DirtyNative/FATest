using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FATestApp.Source.UI.CustomViews.Labels;
using FATestApp.UWP.Source.UI.Renderer.Labels;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

//[assembly: ExportRenderer(typeof(FontAwesomeLabel), typeof(FontAwesomeLabelRenderer))]
namespace FATestApp.UWP.Source.UI.Renderer.Labels
{
    public class FontAwesomeLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var label = Control;
            string font = "Assets/Fonts/fontawesome-webfont.ttf#FontAwesome";
            label.FontFamily = new Windows.UI.Xaml.Media.FontFamily(font);
        }
    }
}

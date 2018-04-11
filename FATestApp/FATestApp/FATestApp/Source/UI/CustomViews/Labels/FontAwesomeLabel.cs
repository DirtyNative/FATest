using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FATestApp.Source.UI.CustomViews.Labels
{
    public class FontAwesomeLabel : Label
    {
        public FontAwesomeLabel()
        {
            /*
            switch (Device.RuntimePlatform)
            {
                case Device.UWP:
                    FontFamily = "/Assets/Fonts/fontawesome-webfont.ttf#FontAwesome";
                    break;
                case null:
                    break;
            }
            */

            FontFamily = "ms-appx:///FATestApp/Assets/Fonts/fontawesome-webfont.ttf#FontAwesome";

            //FontFamily = Device.OnPlatform(null, "FontAwesome", "/Assets/Fonts/fontawesome-webfont.ttf#FontAwesome");
        }
    }
}

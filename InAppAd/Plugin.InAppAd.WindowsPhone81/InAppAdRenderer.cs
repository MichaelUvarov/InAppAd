using Microsoft.Advertising.WinRT.UI;
using Plugin.InAppAd;
using Plugin.InAppAd.Abstractions;
using Windows.UI.Xaml;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;

[assembly: ExportRenderer(typeof(InAppAdView), typeof(InAppAdRenderer))]
namespace Plugin.InAppAd
{
  public class InAppAdRenderer : ViewRenderer<View, FrameworkElement>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
                return;
            
            if (e.OldElement != null)
                return;
            
            var adMobElement = e.NewElement as InAppAdView;

            if (adMobElement == null)
                return;

            var adControl = new AdControl();

            adControl.ApplicationId = adMobElement.MicrosoftAppId;
            adControl.AdUnitId = adMobElement.AdUnitId;
            
            adControl.Width = adMobElement.MicrosoftWidth;
            adControl.Height = adMobElement.MicrosoftHeight;

            SetNativeControl(adControl);            
        }
    }
}
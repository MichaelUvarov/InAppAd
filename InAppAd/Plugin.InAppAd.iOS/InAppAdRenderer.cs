using CoreGraphics;
using Google.MobileAds;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Plugin.InAppAd;
using Plugin.InAppAd.Abstractions;

[assembly: ExportRenderer(typeof(InAppAdView), typeof(InAppAdRenderer))]
namespace Plugin.InAppAd
{
    public class InAppAdRenderer : ViewRenderer
    {
        private bool viewOnScreen;

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

            var adView = new BannerView(size: AdSizeCons.Banner, origin: new CGPoint(-10, 0))
            {
                AdUnitID = adMobElement.AdUnitId,
                RootViewController = UIApplication.SharedApplication.Windows[0].RootViewController
            };

            adView.AdReceived += (sender, args) =>
            {
                if (!viewOnScreen) AddSubview(adView);
                viewOnScreen = true;
            };

            adView.LoadRequest(Request.GetDefaultRequest());
            SetNativeControl(adView);
        }
    }
}
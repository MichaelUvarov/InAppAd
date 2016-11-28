using Xamarin.Forms;

using GoogleAds;
using Xamarin.Forms.Platform.WinPhone;
using Plugin.InAppAd.Abstractions;
using Plugin.InAppAd;

[assembly: ExportRenderer(typeof(InAppAdView), typeof(InAppAdRenderer))]
namespace Plugin.InAppAd
{
    public class InAppAdRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
                return;

            var adMobElement = Element as InAppAdView;

            if (adMobElement == null)
                return;

            var bannerAd = new AdView
            {
                Format = AdFormats.Banner,
                AdUnitID = adMobElement.AdUnitId,
            };

            var adRequest = new AdRequest();

            bannerAd.LoadAd(adRequest);

            Children.Add(bannerAd);            
        }
    }
}
using Xamarin.Forms;
using Plugin.InAppAd;
using Plugin.InAppAd.Abstractions;
using Xamarin.Forms.Platform.Android;
using Android.Gms.Ads;

[assembly: ExportRenderer(typeof(InAppAdView), typeof(InAppAdRenderer))]
namespace Plugin.InAppAd
{
    public class InAppAdRenderer : ViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<View> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
                return;

            var adMobElement = Element as InAppAdView;

            if (adMobElement == null)
                return;

            var ad = new AdView(Forms.Context);
            ad.AdSize = AdSize.Banner;
            ad.AdUnitId = adMobElement.AdUnitId;

            var requestbuilder = new AdRequest.Builder();
            ad.LoadAd(requestbuilder.Build());

            SetNativeControl(ad);
        }
    }
}
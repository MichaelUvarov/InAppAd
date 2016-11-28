using Xamarin.Forms;

namespace Plugin.InAppAd.Abstractions
{
    /// <summary>
    /// This control for advertising in mobile apps
    /// </summary>
    public class InAppAdView : View
    {
        public InAppAdView() { }
        
        public static readonly BindableProperty AdUnitIdProperty =
            BindableProperty.Create<InAppAdView, string>(p => p.AdUnitId, "");
        public static readonly BindableProperty MicrosoftWidthProperty =
            BindableProperty.Create<InAppAdView, int>(p => p.MicrosoftWidth, 0);
        public static readonly BindableProperty MicrosoftHeightProperty =
            BindableProperty.Create<InAppAdView, int>(p => p.MicrosoftHeight, 0);
        public static readonly BindableProperty MicrosoftAppIdProperty =
            BindableProperty.Create<InAppAdView, string>(p => p.MicrosoftAppId, "");

        /// <summary>
        /// The ID of the AdMob ad to display
        /// This is the string Id from your Google Play account
        /// AdUnitId example : ca-app-pub-5796681800623607/8623940979
        /// </summary>
        public string AdUnitId { get; set; }

        /// <summary>
        /// Microsoft Ad banner width
        /// https://msdn.microsoft.com/en-us/windows/uwp/monetize/supported-ad-sizes-for-banner-ads
        /// </summary>
        public int MicrosoftWidth { get; set; }

        /// <summary>
        /// Microsoft Ad banner height
        /// https://msdn.microsoft.com/en-us/windows/uwp/monetize/supported-ad-sizes-for-banner-ads
        /// </summary>
        public int MicrosoftHeight { get; set; }

        /// <summary>
        /// The ID of the Microsoft ad to display
        /// This is the string Id from 
        /// https://msdn.microsoft.com/en-us/windows/uwp/monetize/install-the-microsoft-advertising-libraries
        /// </summary>
        public string MicrosoftAppId { get; set; }
    }
}

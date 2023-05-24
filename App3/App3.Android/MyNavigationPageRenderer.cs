using Android.Content;
using App3;
using App3.Droid;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(MyNavigationPageRenderer))]
namespace App3.Droid
{
    public class MyNavigationPageRenderer : NavigationRenderer
    {
        public MyNavigationPageRenderer(Context context) : base(context)
        {
        }

        protected override Task<bool> OnPushAsync(Page view, bool animated)
        {
            var result = base.OnPushAsync(view, animated);
            UpdatePadding();
            return result;
        }

        protected override Task<bool> OnPopViewAsync(Page page, bool animated)
        {
            var result = base.OnPopViewAsync(page, animated);
            UpdatePadding();
            return result;
        }

        protected override Task<bool> OnPopToRootAsync(Page page, bool animated)
        {
            var result = base.OnPopToRootAsync(page, animated);
            UpdatePadding();
            return result;
        }

        private void UpdatePadding()
        {
            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            if (toolbar != null)
            {
                toolbar.SetPadding(0, 0, 0, 0);
            }
        }
    }
}

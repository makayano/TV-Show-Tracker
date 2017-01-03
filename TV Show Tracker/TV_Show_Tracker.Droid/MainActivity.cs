using System;
using System.Collections.Generic;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TV_Show_Tracker.Droid.Data;

namespace TV_Show_Tracker.Droid
{
    [Activity(Label = "TV_Show_Tracker", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            TVMazeRESTService api = new TVMazeRESTService();
            OnAppearing(api);
            LoadApplication(new App());
        }
        protected async void OnAppearing(TVMazeRESTService api)
        {
            List<string> result = await api.RefreshDataAsync();
            foreach(var a in result)
            {
                Console.WriteLine(a);
            }
        }
    }
}


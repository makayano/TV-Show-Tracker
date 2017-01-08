using System;
using System.Collections.Generic;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TV_Show_Tracker.Droid.Data;
using TV_Show_Tracker.Droid.Model;

//TODO: now that we have successfully received and stored json object, need to provide front end where user can search
// for the show they would like to add to their list of TV shows they want to track. 
// update model to include list of tvshows that have been added by the user. look into various ways of storing
// the data persistently and figure out what data we want to be stored persistently (only showID, all info about show, etc)
// once we have our list of tv show ID's, we send another api call to receive all info about the show. the next episode
// href will contain information about the next episode, including when the airdate will be. 

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
            List<RootObject> result = await api.RefreshDataAsync();
            foreach(var a in result)
            {
                System.Diagnostics.Debug.WriteLine(a);
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace TV_Show_Tracker.Droid
{
    [Activity(Label = "MasterDetail")]
    public class MasterDetail : MasterDetailPage
    {
        MasterDetail masterPage;
        public MasterDetail()
        {

        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}
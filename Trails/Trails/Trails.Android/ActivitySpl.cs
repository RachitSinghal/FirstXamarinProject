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

namespace Trails.Droid
{
    [Activity(Label = "ActivitySpl",
        Theme = "@style/Theme.Splash",
        MainLauncher = true,
        NoHistory = true)]
    public class ActivitySpl : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            // Create your application here
        }
    }
}
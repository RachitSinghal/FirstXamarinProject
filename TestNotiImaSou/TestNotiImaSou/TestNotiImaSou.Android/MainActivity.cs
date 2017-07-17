using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Android.Media;

namespace TestNotiImaSou.Droid
{
    [Activity(Label = "TestNotiImaSou", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        MediaPlayer player;
        protected override void OnCreate(Bundle bundle)
        {

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            // Instantiate the builder and set notification elements:
            Notification.Builder builder = new Notification.Builder(this)
            .SetContentTitle("Sample Notification")
            .SetContentText("Hello World! This is my first notification!")
            .SetDefaults(NotificationDefaults.Sound)
            .SetSmallIcon(Resource.Drawable.download);


            // Build the notification:
            Notification notification = builder.Build();

            // Get the notification manager:
            NotificationManager notificationManager =
                GetSystemService(Context.NotificationService) as NotificationManager;

            // Publish the notification:
            const int notificationId = 0;
            notificationManager.Notify(notificationId, notification);

            player = MediaPlayer.Create(this, Resource.Raw.sample);
            player.Start();
        }
    }
}


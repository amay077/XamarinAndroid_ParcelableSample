using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HelloXamarinAndroid
{
    [Activity (Label = "HelloXamarinAndroid", MainLauncher = true)]
    public class Activity1 : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.myButton);
			
            button.Click += (sender, e) => 
            {
                var card = new Card("amay", "987-654-3321");

                // Goto NextActivity
                var intent = new Intent(this, typeof(NextActivity));
                intent.PutExtra("card", card); // intent に Card を詰める

                this.StartActivity(intent);
            };
        }
    }
}



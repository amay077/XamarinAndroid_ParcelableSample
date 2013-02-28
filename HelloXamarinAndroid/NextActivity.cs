
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

namespace HelloXamarinAndroid
{
    [Activity (Label = "NextActivity")]			
    public class NextActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here

            var card = this.Intent.GetParcelableExtra("card") as Card;

            // Show toast
            Toast.MakeText(this, 
                String.Format("name:{0}, phone:{1}", card.Name, card.Phone), 
                ToastLength.Long).Show();
        }
    }
}


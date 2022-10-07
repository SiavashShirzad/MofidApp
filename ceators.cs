using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MOFIDAPP
{
    [Activity(Label = "ceators")]
    public class ceators : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.creators);
            var back = FindViewById<Button>(Resource.Id.button1);      
            back.Click += delegate { StartActivity(typeof(info)); };
            var ref1 = FindViewById<TextView>(Resource.Id.textView5);
            var ref2 = FindViewById<TextView>(Resource.Id.textView1);
            ref1.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "siavash_shirzad_1996@yahoo.com");
            ref1.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref1.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref2.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "fatemehicho@yahoo.com");
            ref2.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref2.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            // Create your application here
        }
    }
}
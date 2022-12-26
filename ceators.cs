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
            var ref3 = FindViewById<TextView>(Resource.Id.textView7);
            var ref4 = FindViewById<TextView>(Resource.Id.textView2);
            var ref5 = FindViewById<TextView>(Resource.Id.textView3);
            var ref6 = FindViewById<TextView>(Resource.Id.textView4);
            ref1.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "siavash_shirzad_1996@yahoo.com");
            ref1.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref1.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref2.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "fatemehicho@yahoo.com");
            ref2.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref2.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref3.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "Drsayyari40@gmail.com");
            ref3.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref3.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref4.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "Dr.Masoudkhorshidi@gmail.com");
            ref4.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref4.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref5.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "Beheshteholang@gmail.com");
            ref5.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref5.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref6.TextFormatted = Android.Text.Html.FromHtml(" Email: " + "amir1981hosseini@gmail.com");
            ref6.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref6.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            
        }
    }
}
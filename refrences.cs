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
    [Activity(Label = "refrences")]
    public class refrences : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.refrences);
            var ref1 = FindViewById<TextView>(Resource.Id.textView2);
            var back = FindViewById<Button>(Resource.Id.button1);
            back.Click += delegate { StartActivity(typeof(info)); };
            var ref2 = FindViewById<TextView>(Resource.Id.textView3);
            var ref3 = FindViewById<TextView>(Resource.Id.textView4);
            var ref4 = FindViewById<TextView>(Resource.Id.textView5);
            ref1.TextFormatted = Android.Text.Html.FromHtml(" 0-5 years old growth refrence: " + "https://www.who.int/toolkits/child-growth-standards");
            ref1.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref1.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref2.TextFormatted = Android.Text.Html.FromHtml(" 5-19 years old growth refrence: " + "https://www.who.int/toolkits/growth-reference-data-for-5to19-years");
            ref2.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref2.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref3.TextFormatted = Android.Text.Html.FromHtml(" Pediatrics blood pressure refrence: " + "https://www.nhlbi.nih.gov/files/docs/guidelines/child_tbl.pdf");
            ref3.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref3.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
            ref4.TextFormatted = Android.Text.Html.FromHtml(" 10 - 20 years old Weight refrence : " + "https://www.cdc.gov/growthcharts/zscore.htm");
            ref4.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
            ref4.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;
          
        }
    }
}
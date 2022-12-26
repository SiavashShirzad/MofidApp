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
using Android.Graphics;

namespace MOFIDAPP
{
    [Activity(Label = "MOFID")]
    public class info : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.info);
            var error = FindViewById<Button>(Resource.Id.button3);
            var back = FindViewById<Button>(Resource.Id.back); 
            var refrence = FindViewById<Button>(Resource.Id.button1);
            var creators = FindViewById<Button>(Resource.Id.button4);
            creators.Click += delegate { StartActivity(typeof(ceators)); };
            back.Click += delegate { StartActivity(typeof(MainActivity)); };
                error.Click += delegate { StartActivity(typeof(error)); };
                refrence.Click += delegate { StartActivity(typeof(refrences)); };
            var LAN = Application.Context.GetSharedPreferences("language", Android.Content.FileCreationMode.Private);
            if(LAN.GetInt("lang", 0) == 0)
            {
                error.Text = "گزارش خطا";
                back.Text = "بازگشت";
                refrence.Text = "منابع";
                creators.Text = "سازندگان";
            }
            if(LAN.GetInt("lang", 0) == 1)
            {
                error.Text = "Report error";
                back.Text = "back";
                refrence.Text = "Refrences";
                creators.Text = "Creators";
            }
            
        }
    }
}
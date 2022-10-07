//created by siavash shirzadeh
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
    [Activity(Label = "error")]
    public class error : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.error);
            var Mail = FindViewById<TextView>(Resource.Id.textView2);
            var Main = FindViewById<TextView>(Resource.Id.textView1);
            var sub = FindViewById<TextView>(Resource.Id.textView3);
            var EText = FindViewById<EditText>(Resource.Id.editText1);
            var Send = FindViewById<Button>(Resource.Id.Cal);
            var back = FindViewById<Button>(Resource.Id.back);
            var LAN = Application.Context.GetSharedPreferences("language", Android.Content.FileCreationMode.Private);
            if(LAN.GetInt("lang",0) == 0)
            {
                EText.Hint = "این قسمت را پر کنید";
                Send.Text = "ارسال";
                back.Text = "بازگشت";
                Main.Text = ".لطفا خطای رخ داده را با ذکر محل و اعداد وارد شده وارد نمایید و دکمه ی ارسال را فشار دهید . با تشکر";

            }
            else
            {
                EText.Hint = "please Fill here";
                Send.Text = "send";
                back.Text = "back";
                Main.Text = "Please fill the blank with details of error you have faced including entered numbers. thank you.";
            }
            back.Click += delegate { StartActivity(typeof(info)); };
            Send.Click += (s, e) =>
            {
                Intent email = new Intent(Intent.ActionSend);
                email.PutExtra(Intent.ExtraEmail, new string[] { Mail.Text.ToString() });
                email.PutExtra(Intent.ExtraSubject,   sub.Text.ToString() );
                email.PutExtra(Intent.ExtraText ,   EText.Text.ToString());
                email.SetType("message/rfc822");
                StartActivity(Intent.CreateChooser(email, "Send Email Via"));

            };
            // Create your application here
        }
    }
}
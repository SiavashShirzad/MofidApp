//created by siavash shirzadeh
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using System.Timers;
using Xamarin.Essentials;

namespace MOFIDAPP
{
    [Activity(MainLauncher = true, NoHistory = true, Label = "MOFID", Icon = "@drawable/TheLogo")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Screen);
           
            Timer timer = new Timer();
            timer.Interval = 2000; 
            timer.AutoReset = false; 
            timer.Elapsed += (object sender, ElapsedEventArgs e) =>
            {
                StartActivity(typeof(MainActivity));
            };
            timer.Start();
        }
    };
    [Activity(Label = "MOFID")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);            
            SetContentView(Resource.Layout.activity_main);
            var page1 = FindViewById<Button>(Resource.Id.button1);
            var page2 = FindViewById<Button>(Resource.Id.button2);
            var page3 = FindViewById<Button>(Resource.Id.button3);
            var lang = FindViewById<Button>(Resource.Id.button4);            
            var LAN = Application.Context.GetSharedPreferences("language", Android.Content.FileCreationMode.Private);
            var LanEdit = LAN.Edit();

           if(LAN.GetInt("lang", 0) == 0)
            {
                page1.Text = "شاخص های رشد";
                page2.Text = "فشار خون";
                page3.Text = "راهنما";
                lang.Text = "ENGLISH";
            }
            if (LAN.GetInt("lang", 0) == 1)
            {
                page1.Text = "Growth standards";
                page2.Text = "Blood pressure";
                page3.Text = "Info";
                lang.Text = "فارسی";
            }
            lang.Click += delegate
            {
                if (LAN.GetInt("lang", 0) == 0)
                {
                    LanEdit.Clear();
                    LanEdit.PutInt("lang", 1);
                    page1.Text = "Growth standards";
                    page2.Text = "Blood pressure";
                    page3.Text = "Info";
                    lang.Text = "فارسی";
                    LanEdit.Commit();
                }
                else
                {
                    LanEdit.Clear();
                    LanEdit.PutInt("lang", 0);
                    page1.Text = "شاخص های رشد";
                    page2.Text = "فشار خون";
                    page3.Text = "راهنما";
                    lang.Text = "ENGLISH";
                    LanEdit.Commit();
                }
            };
            
            page1.Click += delegate { StartActivity(typeof(pediometry1));            }; 
            page2.Click += delegate { StartActivity(typeof(pediometry2));  };
            page3.Click += delegate { StartActivity(typeof(info)); };
           
        

        }
      
    }
}
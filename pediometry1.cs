using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace MOFIDAPP
{
    [Activity(Label = "Growth standards")]
    public class pediometry1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.pediometry1);
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            var back = FindViewById<Button>(Resource.Id.back);
            var aYear = FindViewById<EditText>(Resource.Id.editText5);
            var aMonth = FindViewById<EditText>(Resource.Id.editText4);
            var aDay = FindViewById<EditText>(Resource.Id.editText3);
            var aWeight = FindViewById<EditText>(Resource.Id.editText2);
            var aHeight = FindViewById<EditText>(Resource.Id.editText1);
            var Result = FindViewById<TextView>(Resource.Id.textView1);
            var ResultL = FindViewById<TextView>(Resource.Id.textView2);
            var ResultBMI = FindViewById<TextView>(Resource.Id.textView3);
            var ResultWL = FindViewById<TextView>(Resource.Id.textView4);
            var Cal = FindViewById<Button>(Resource.Id.button1);
            var Gender = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            var Lay = FindViewById<LinearLayout>(Resource.Id.Lay);
            var aHC = FindViewById<EditText>(Resource.Id.editText6);
            var ResultHC = FindViewById<TextView>(Resource.Id.ResultHC);
            var age = FindViewById<Button>(Resource.Id.button2);
            var AgeText = FindViewById<TextView>(Resource.Id.textView6);
            var BirthDate = FindViewById<TextView>(Resource.Id.textView5);
            var ageLay = FindViewById<LinearLayout>(Resource.Id.linearLayout4);
            var aYear1 = FindViewById<EditText>(Resource.Id.editText10);
            var aMonth1 = FindViewById<EditText>(Resource.Id.editText11);
            var aDay1 = FindViewById<EditText>(Resource.Id.editText12);
            var LAN = Application.Context.GetSharedPreferences("language", Android.Content.FileCreationMode.Private);
            int flang = LAN.GetInt("lang", 0);
            string pointA;
            string pointL;
            string pointHC;



            string Perc(double ZZ)
            {
                if (ZZ < -2.326)
                {
                    return "under 1st percentile";
                }
                else if (ZZ >= -2.326 && ZZ < -2.054)
                {
                    return "1st Percentile";
                }
                else if (ZZ >= -2.054 && ZZ < -1.881)
                {
                    return "2nd Percentile";
                }
                else if (ZZ >= -1.881 && ZZ < -1.751)
                {
                    return "3rd Percentile";
                }
                else if (ZZ >= -1.751 && ZZ < -1.645)
                {
                    return "4th Percentile";
                }
                else if (ZZ >= -1.645 && ZZ < -1.555)
                {
                    return "5th Percentile";
                }
                else if (ZZ >= -1.555 && ZZ < -1.476)
                {
                    return "6th Percentile";
                }

                else if (ZZ >= -1.476 && ZZ < -1.405)
                {
                    return "7th Percentile";
                }
                else if (ZZ >= -1.405 && ZZ < -1.341)
                {
                    return "8th Percentile";
                }
                else if (ZZ >= -1.341 && ZZ < -1.282)
                {
                    return "9th Percentile";
                }
                else if (ZZ >= -1.282 && ZZ < -1.227)
                {
                    return "10th Percentile";
                }
                else if (ZZ >= -1.227 && ZZ < -1.175)
                {
                    return "11th Percentile";
                }
                else if (ZZ >= -1.175 && ZZ < -1.126)
                {
                    return "12th Percentile";
                }
                else if (ZZ >= -1.126 && ZZ < -1.08)
                {
                    return "13th Percentile";
                }
                else if (ZZ >= -1.08 && ZZ < -1.036)
                {
                    return "14th Percentile";
                }
                else if (ZZ >= -1.036 && ZZ < -0.994)
                {
                    return "15th Percentile";
                }
                else if (ZZ >= -0.994 && ZZ < -0.954)
                {
                    return "16th Percentile";
                }

                else if (ZZ >= -0.954 && ZZ < -0.915)
                {
                    return "17th Percentile";
                }
                else if (ZZ >= -0.915 && ZZ < -0.878)
                {
                    return "18th Percentile";
                }
                else if (ZZ >= -0.878 && ZZ < -0.842)
                {
                    return "19th Percentile";
                }
                else if (ZZ >= -0.842 && ZZ < -0.806)
                {
                    return "20th Percentile";
                }
                else if (ZZ >= -0.806 && ZZ < -0.772)
                {
                    return "21st Percentile";
                }

                else if (ZZ >= -0.772 && ZZ < -0.739)
                {
                    return "22nd Percentile";
                }
                else if (ZZ >= -0.739 && ZZ < -0.706)
                {
                    return "23rd Percentile";
                }

                else if (ZZ >= -0.706 && ZZ < -0.674)
                {
                    return "24th Percentile";
                }
                else if (ZZ >= -0.674 && ZZ < -0.643)
                {
                    return "25th Percentile";
                }
                else if (ZZ >= -0.643 && ZZ < -0.613)
                {
                    return "26th Percentile";
                }
                else if (ZZ >= -0.613 && ZZ < -0.583)
                {
                    return "27th Percentile";
                }
                else if (ZZ >= -0.583 && ZZ < -0.553)
                {
                    return "28th Percentile";
                }
                else if (ZZ >= -0.553 && ZZ < -0.524)
                {
                    return "29th Percentile";
                }
                else if (ZZ >= -0.524 && ZZ < -0.496)
                {
                    return "30th Percentile";
                }
                else if (ZZ >= -0.496 && ZZ < -0.468)
                {
                    return "31st Percentile";
                }

                else if (ZZ >= -0.468 && ZZ < -0.44)
                {
                    return "32nd Percentile";
                }

                else if (ZZ >= -0.44 && ZZ < -0.412)
                {
                    return "33rd Percentile";
                }
                else if (ZZ >= -0.412 && ZZ < -0.385)
                {
                    return "34th Percentile";
                }
                else if (ZZ >= -0.385 && ZZ < -0.358)
                {
                    return "35th Percentile";
                }

                else if (ZZ >= -0.358 && ZZ < -0.332)
                {
                    return "36th Percentile";
                }
                else if (ZZ >= -0.332 && ZZ < -0.305)
                {
                    return "37th Percentile";
                }

                else if (ZZ >= -0.305 && ZZ < -0.279)
                {
                    return "38th Percentile";
                }

                else if (ZZ >= -0.279 && ZZ < -0.253)
                {
                    return "39th Percentile";
                }
                else if (ZZ >= -0.253 && ZZ < -0.228)
                {
                    return "40th Percentile";
                }
                else if (ZZ >= -0.228 && ZZ < -0.202)
                {
                    return "41st Percentile";
                }
                else if (ZZ >= -0.202 && ZZ < -0.176)
                {
                    return "42nd Percentile";
                }
                else if (ZZ >= -0.176 && ZZ < -0.151)
                {
                    return "43rd Percentile";
                }
                else if (ZZ >= -0.151 && ZZ < -0.126)
                {
                    return "44th Percentile";
                }
                else if (ZZ >= -0.126 && ZZ < -0.1)
                {
                    return "45th Percentile";
                }
                else if (ZZ >= -0.1 && ZZ < -0.075)
                {
                    return "46th Percentile";
                }
                else if (ZZ >= -0.075 && ZZ < -0.05)
                {
                    return "47th Percentile";
                }
                else if (ZZ >= -0.05 && ZZ < -0.025)
                {
                    return "48th Percentile";
                }
                else if (ZZ >= -0.025 && ZZ < 0)
                {
                    return "49th Percentile";
                }
                else if (ZZ >= 0 && ZZ < 0.025)
                {
                    return "50th Percentile";
                }
                else if (ZZ >= 0.025 && ZZ < 0.05)
                {
                    return "51st Percentile";
                }
                else if (ZZ >= 0.05 && ZZ < 0.075)
                {
                    return "52nd Percentile";
                }
                else if (ZZ >= 0.075 && ZZ < 0.1)
                {
                    return "53rd Percentile";
                }
                else if (ZZ >= 0.1 && ZZ < 0.126)
                {
                    return "54th Percentile";
                }
                else if (ZZ >= 0.126 && ZZ < 0.151)
                {
                    return "55th Percentile";
                }
                else if (ZZ >= 0.151 && ZZ < 0.176)
                {
                    return "56th Percentile";
                }
                else if (ZZ >= 0.176 && ZZ < 0.202)
                {
                    return "57th Percentile";
                }
                else if (ZZ >= 0.202 && ZZ < 0.228)
                {
                    return "58th Percentile";
                }
                else if (ZZ >= 0.228 && ZZ < 0.253)
                {
                    return "59th Percentile";
                }
                else if (ZZ >= 0.253 && ZZ < 0.279)
                {
                    return "60th Percentile";
                }
                else if (ZZ >= 0.279 && ZZ < 0.305)
                {
                    return "61st Percentile";
                }
                else if (ZZ >= 0.305 && ZZ < 0.332)
                {
                    return "62nd Percentile";
                }
                else if (ZZ >= 0.332 && ZZ < 0.358)
                {
                    return "63rd Percentile";
                }
                else if (ZZ >= 0.358 && ZZ < 0.385)
                {
                    return "64th Percentile";
                }
                else if (ZZ >= 0.385 && ZZ < 0.412)
                {
                    return "65th Percentile";
                }
                else if (ZZ >= 0.412 && ZZ < 0.44)
                {
                    return "66th Percentile";
                }
                else if (ZZ >= 0.44 && ZZ < 0.468)
                {
                    return "67th Percentile";
                }
                else if (ZZ >= 0.468 && ZZ < 0.496)
                {
                    return "68th Percentile";
                }
                else if (ZZ >= 0.496 && ZZ < 0.524)
                {
                    return "69th Percentile";
                }
                else if (ZZ >= 0.524 && ZZ < 0.553)
                {
                    return "70th Percentile";
                }
                else if (ZZ >= 0.553 && ZZ < 0.583)
                {
                    return "71st Percentile";
                }
                else if (ZZ >= 0.583 && ZZ < 0.613)
                {
                    return "72nd Percentile";
                }
                else if (ZZ >= 0.613 && ZZ < 0.643)
                {
                    return "73rd Percentile";
                }
                else if (ZZ >= 0.643 && ZZ < 0.674)
                {
                    return "74th Percentile";
                }
                else if (ZZ >= 0.674 && ZZ < 0.706)
                {
                    return "75th Percentile";
                }
                else if (ZZ >= 0.706 && ZZ < 0.739)
                {
                    return "76th Percentile";
                }
                else if (ZZ >= 0.739 && ZZ < 0.772)
                {
                    return "77th Percentile";
                }
                else if (ZZ >= 0.772 && ZZ < 0.806)
                {
                    return "78th Percentile";
                }
                else if (ZZ >= 0.806 && ZZ < 0.842)
                {
                    return "79th Percentile";
                }
                else if (ZZ >= 0.842 && ZZ < 0.878)
                {
                    return "80th Percentile";
                }
                else if (ZZ >= 0.878 && ZZ < 0.915)
                {
                    return "81st Percentile";
                }
                else if (ZZ >= 0.915 && ZZ < 0.954)
                {
                    return "82nd Percentile";
                }
                else if (ZZ >= 0.954 && ZZ < 0.994)
                {
                    return "83rd Percentile";
                }
                else if (ZZ >= 0.994 && ZZ < 1.036)
                {
                    return "84th Percentile";
                }
                else if (ZZ >= 1.036 && ZZ < 1.08)
                {
                    return "85th Percentile";
                }
                else if (ZZ >= 1.08 && ZZ < 1.126)
                {
                    return "86th Percentile";
                }

                else if (ZZ >= 1.126 && ZZ < 1.175)
                {
                    return "87th Percentile";
                }
                else if (ZZ >= 1.175 && ZZ < 1.227)
                {
                    return "88th Percentile";
                }
                else if (ZZ >= 1.227 && ZZ < 1.282)
                {
                    return "89th Percentile";
                }
                else if (ZZ >= 1.282 && ZZ < 1.341)
                {
                    return "90th Percentile";
                }
                else if (ZZ >= 1.341 && ZZ < 1.405)
                {
                    return "91st Percentile";
                }
                else if (ZZ >= 1.405 && ZZ < 1.476)
                {
                    return "92nd Percentile";
                }
                else if (ZZ >= 1.476 && ZZ < 1.555)
                {
                    return "93rd Percentile";
                }
                else if (ZZ >= 1.555 && ZZ < 1.645)
                {
                    return "94th Percentile";
                }
                else if (ZZ >= 1.645 && ZZ < 1.751)
                {
                    return "95th Percentile";
                }
                else if (ZZ >= 1.751 && ZZ < 1.881)
                {
                    return "96th Percentile";
                }
                else if (ZZ >= 1.881 && ZZ < 2.054)
                {
                    return "97th Percentile";
                }
                else if (ZZ >= 2.054 && ZZ < 2.326)
                {
                    return "98th Percentile";
                }
                else if (ZZ >= 2.326 && ZZ < 2.33)
                {
                    return "99th Percentile";
                }
                else if (ZZ >= 2.33)
                {
                    return "over 99th Percentile";
                }
                else
                {
                    return "percentile not availbale";
                }


            }

            if (LAN.GetInt("lang", 0) == 0)
            {
                aHC.Hint = "دور سر(cm)";
                aHeight.Hint = "قد(cm)";
                aWeight.Hint = "وزن(kg)";
                BirthDate.Text = "تاریخ تولد : ";
                AgeText.Text = "تاریخ امروز : ";
                Gender.TextOn = "پسر";
                Gender.TextOff = "دختر";
                Gender.Text = "دختر";
                age.Text = "سن به عدد";
                Cal.Text = "محاسبه";
                back.Text = "صفحه ی اصلی";
                pointA = "لطفا سن را به درستی وارد کنید";
                
                pointHC = "لطفا دور سر را به درستی وارد کنید";
                pointL = "لطفا قد/طول را به درستی وارد کنید";
                age.Click += (p, l) =>
                {

                    if (age.Text == "سن به عدد")
                    {
                        aYear.Text = "";
                        aYear1.Text = "";
                        aMonth.Text = "";
                        aMonth1.Text = "";
                        aDay.Text = "";
                        aDay1.Text = "";
                        age.Text = "سن به تاریخ";
                        aYear.Hint = "سال";
                        aMonth.Hint = "ماه";
                        aDay.Hint = "روز";
                        AgeText.Text = "سن :";
                        ageLay.Visibility = ViewStates.Invisible;
                    }
                    else
                    {
                        aYear.Text = "";
                        aYear1.Text = "";
                        aMonth.Text = "";
                        aMonth1.Text = "";
                        aDay.Text = "";
                        aDay1.Text = "";
                        ageLay.Visibility = ViewStates.Visible;
                        AgeText.Text = "تاریخ امروز :";
                        aYear.Hint = "YYYY";
                        aMonth.Hint = "MM";
                        aDay.Hint = "DD";
                        age.Text = "سن به عدد";
                    }
                };
            }
            else
            {
                aHC.Hint = "Head circumference(cm)";
                aHeight.Hint = "Height(cm)";
                aWeight.Hint = "Weight(kg)";
                BirthDate.Text = "Birth date";
                AgeText.Text = "Today's date";
                Gender.TextOn = "Male";
                Gender.Text = "Female";
                Gender.TextOff = "Female";
                age.Text = "Age by number";
                Cal.Text = "Calculate";
                back.Text = "Main page";
                pointA = "Please enter age properly";
                
                pointL = "Please enter Height/lenght properly";
                pointHC = "Please enter head circumference properly";
                age.Click += (p, l) =>
                {

                    if (age.Text == "Age by number")
                    {
                        aYear.Text = "";
                        aYear1.Text = "";
                        aMonth.Text = "";
                        aMonth1.Text = "";
                        aDay.Text = "";
                        aDay1.Text = "";
                        age.Text = "Age by date";
                        aYear.Hint = "Year";
                        aMonth.Hint = "Month";
                        aDay.Hint = "Day";
                        AgeText.Text = ": Age";
                        ageLay.Visibility = ViewStates.Invisible;
                    }
                    else
                    {
                        aYear.Text = "";
                        aYear1.Text = "";
                        aMonth.Text = "";
                        aMonth1.Text = "";
                        aDay.Text = "";
                        aDay1.Text = "";
                        ageLay.Visibility = ViewStates.Visible;
                        AgeText.Text = "Today's date";
                        aYear.Hint = "YYYY";
                        aMonth.Hint = "MM";
                        aDay.Hint = "DD";
                        age.Text = "Age by number";
                    }
                };
            }


            back.Click += delegate { StartActivity(typeof(MainActivity)); };
            Cal.Click += (b, g) =>
            {
                if (Gender.Checked)
                {
                    Lay.SetBackgroundColor(Color.LightSkyBlue);
                }
                else
                {
                    Lay.SetBackgroundColor(Color.LightPink);
                }

                double HC = 0;
                double MeanHC = 0;
                double SDHC = 0;
                int year = 0;
                int month = 0;
                int day = 0;
                double Weight = 0;
                double Height = 0;
                double MeanW = 0;
                double SDW = 0;
                double ZW = 0;
                double ZL = 0;
                double ZBMI;
                double MeanL = 0;
                double SDL = 0;
                double MeanBMI = 0;
                double SDBMI = 0;
                double MeanWL = 0;
                double SDWL = 0;
                int year1 = 0;
                int month1 = 0;
                int day1 = 0;



                if (aHC.Text != "")
                {
                    HC = Convert.ToDouble(aHC.Text);
                }
                if (aYear.Text != "")
                {
                    year = Convert.ToInt32(aYear.Text);
                }
                if (aMonth.Text != "")
                {
                    month = Convert.ToInt32(aMonth.Text);

                }
                if (aDay.Text != "")
                {
                    day = Convert.ToInt32(aDay.Text);
                }
                if (aYear1.Text != "")
                {
                    year1 = Convert.ToInt32(aYear1.Text);
                }
                if (aMonth1.Text != "")
                {
                    month1 = Convert.ToInt32(aMonth1.Text);

                }
                if (aDay1.Text != "")
                {
                    day1 = Convert.ToInt32(aDay1.Text);
                }
                if (aWeight.Text != "")
                {

                    Weight = Convert.ToDouble(aWeight.Text);
                }
                if (aHeight.Text != "")
                {
                    Height = Convert.ToDouble(aHeight.Text);
                }
                double BMI = Weight / ((Height / 100) * (Height / 100));
                int Num = 0;
                // year >>99 , 
                if (age.Text == "سن به تاریخ")
                {
                    Num = 360 * year + day + 30 * month;
                }
                else
                {
                    Num = 360 * (year - year1) + 30 * (month - month1) + (day - day1);
                }



                if (Gender.Checked)
                {
                    //Headcircumference /age
                    if (Num >= 0 && Num < 7)
                    {
                        MeanHC = 34.46;
                        SDHC = 1.27;

                    }
                    if (Num >= 7 && Num < 14)
                    {
                        MeanHC = 35.16;
                        SDHC = 1.22;
                    }
                    if (Num >= 14 && Num < 22)
                    {
                        MeanHC = 35.84;
                        SDHC = 1.16;
                    }
                    if (Num >= 22 && Num < 30)
                    {
                        MeanHC = 36.52;
                        SDHC = 1.16;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanHC = 37.2759;
                        SDHC = 1.1679;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanHC = 39.1285;
                        SDHC = 1.1727;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanHC = 40.5135;
                        SDHC = 1.1822;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanHC = 41.6317;
                        SDHC = 1.194;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanHC = 42.5576;
                        SDHC = 1.2074;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanHC = 43.3306;
                        SDHC = 1.2206;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanHC = 43.9803;
                        SDHC = 1.2332;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanHC = 44.53;
                        SDHC = 1.2451;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanHC = 44.9998;
                        SDHC = 1.2564;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanHC = 45.4051;
                        SDHC = 1.2668;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanHC = 45.7573;
                        SDHC = 1.2762;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanHC = 46.0661;
                        SDHC = 1.2848;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanHC = 46.3395;
                        SDHC = 1.2924;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanHC = 46.5844;
                        SDHC = 1.3002;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanHC = 46.806;
                        SDHC = 1.3068;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanHC = 47.0088;
                        SDHC = 1.3139;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanHC = 47.1962;
                        SDHC = 1.3201;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanHC = 47.3711;
                        SDHC = 1.3264;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanHC = 47.5357;
                        SDHC = 1.3324;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanHC = 47.6919;
                        SDHC = 1.3382;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanHC = 47.8408;
                        SDHC = 1.3443;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanHC = 47.9833;
                        SDHC = 1.3498;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanHC = 48.1201;
                        SDHC = 1.3555;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanHC = 48.2515;
                        SDHC = 1.3612;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanHC = 48.3777;
                        SDHC = 1.3667;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanHC = 48.4989;
                        SDHC = 1.3725;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanHC = 48.6151;
                        SDHC = 1.3778;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanHC = 48.7264;
                        SDHC = 1.3829;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanHC = 48.8331;
                        SDHC = 1.3878;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanHC = 48.9351;
                        SDHC = 1.3932;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanHC = 49.0327;
                        SDHC = 1.3979;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanHC = 49.126;
                        SDHC = 1.4026;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanHC = 49.2153;
                        SDHC = 1.4071;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanHC = 49.3007;
                        SDHC = 1.4115;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanHC = 49.3826;
                        SDHC = 1.4158;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanHC = 49.4612;
                        SDHC = 1.42;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanHC = 49.5367;
                        SDHC = 1.4242;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanHC = 49.6093;
                        SDHC = 1.4278;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanHC = 49.6791;
                        SDHC = 1.4318;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanHC = 49.7465;
                        SDHC = 1.4357;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanHC = 49.8116;
                        SDHC = 1.4391;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanHC = 49.8745;
                        SDHC = 1.4429;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanHC = 49.9354;
                        SDHC = 1.4461;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanHC = 49.9942;
                        SDHC = 1.4493;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanHC = 50.0512;
                        SDHC = 1.453;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanHC = 50.1064;
                        SDHC = 1.4561;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanHC = 50.1598;
                        SDHC = 1.4592;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanHC = 50.2115;
                        SDHC = 1.4622;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanHC = 50.2617;
                        SDHC = 1.4651;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanHC = 50.3105;
                        SDHC = 1.4681;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanHC = 50.3578;
                        SDHC = 1.471;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanHC = 50.4039;
                        SDHC = 1.4738;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanHC = 50.4488;
                        SDHC = 1.4766;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanHC = 50.4926;
                        SDHC = 1.4789;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanHC = 50.5354;
                        SDHC = 1.4817;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanHC = 50.5772;
                        SDHC = 1.4844;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanHC = 50.6183;
                        SDHC = 1.4872;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanHC = 50.6587;
                        SDHC = 1.4894;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanHC = 50.6984;
                        SDHC = 1.4921;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanHC = 50.7375;
                        SDHC = 1.4947;
                    }
                    //weight/lenght male
                    if (Height < 720)
                    {
                        if (Height >= 45 && Height < 45.5)
                        {
                            MeanWL = 2.441;
                            SDWL = 0.259;
                        }
                        if (Height >= 45 && Height < 45.5)
                        {
                            MeanWL = 2.5244;
                            SDWL = 0.2756;
                        }
                        if (Height >= 46 && Height < 46.5)
                        {
                            MeanWL = 2.6077;
                            SDWL = 0.2923;
                        }
                        if (Height >= 46 && Height < 46.5)
                        {
                            MeanWL = 2.6913;
                            SDWL = 0.3087;
                        }
                        if (Height >= 47 && Height < 47.5)
                        {
                            MeanWL = 2.7755;
                            SDWL = 0.2245;
                        }
                        if (Height >= 47 && Height < 47.5)
                        {
                            MeanWL = 2.8609;
                            SDWL = 0.2391;
                        }
                        if (Height >= 48 && Height < 48.5)
                        {
                            MeanWL = 2.948;
                            SDWL = 0.252;
                        }
                        if (Height >= 48 && Height < 48.5)
                        {
                            MeanWL = 3.0377;
                            SDWL = 0.2623;
                        }
                        if (Height >= 49 && Height < 49.5)
                        {
                            MeanWL = 3.1308;
                            SDWL = 0.2692;
                        }
                        if (Height >= 49 && Height < 49.5)
                        {
                            MeanWL = 3.2276;
                            SDWL = 0.2724;
                        }
                        if (Height >= 50 && Height < 50.5)
                        {
                            MeanWL = 3.3278;
                            SDWL = 0.2722;
                        }
                        if (Height >= 50 && Height < 50.5)
                        {
                            MeanWL = 3.4311;
                            SDWL = 0.3689;
                        }
                        if (Height >= 51 && Height < 51.5)
                        {
                            MeanWL = 3.5376;
                            SDWL = 0.3624;
                        }
                        if (Height >= 51 && Height < 51.5)
                        {
                            MeanWL = 3.6477;
                            SDWL = 0.3523;
                        }
                        if (Height >= 52 && Height < 52.5)
                        {
                            MeanWL = 3.762;
                            SDWL = 0.338;
                        }
                        if (Height >= 52 && Height < 52.5)
                        {
                            MeanWL = 3.8814;
                            SDWL = 0.3186;
                        }
                        if (Height >= 53 && Height < 53.5)
                        {
                            MeanWL = 4.006;
                            SDWL = 0.394;
                        }
                        if (Height >= 53 && Height < 53.5)
                        {
                            MeanWL = 4.1354;
                            SDWL = 0.3646;
                        }
                        if (Height >= 54 && Height < 54.5)
                        {
                            MeanWL = 4.2693;
                            SDWL = 0.4307;
                        }
                        if (Height >= 54 && Height < 54.5)
                        {
                            MeanWL = 4.4066;
                            SDWL = 0.3934;
                        }
                        if (Height >= 55 && Height < 55.5)
                        {
                            MeanWL = 4.5467;
                            SDWL = 0.4533;
                        }
                        if (Height >= 55 && Height < 55.5)
                        {
                            MeanWL = 4.6892;
                            SDWL = 0.4108;
                        }
                        if (Height >= 56 && Height < 56.5)
                        {
                            MeanWL = 4.8338;
                            SDWL = 0.4662;
                        }
                        if (Height >= 56 && Height < 56.5)
                        {
                            MeanWL = 4.9796;
                            SDWL = 0.4204;
                        }
                        if (Height >= 57 && Height < 57.5)
                        {
                            MeanWL = 5.1259;
                            SDWL = 0.4741;
                        }
                        if (Height >= 57 && Height < 57.5)
                        {
                            MeanWL = 5.2721;
                            SDWL = 0.4279;
                        }
                        if (Height >= 58 && Height < 58.5)
                        {
                            MeanWL = 5.418;
                            SDWL = 0.482;
                        }
                        if (Height >= 58 && Height < 58.5)
                        {
                            MeanWL = 5.5632;
                            SDWL = 0.5368;
                        }
                        if (Height >= 59 && Height < 59.5)
                        {
                            MeanWL = 5.7074;
                            SDWL = 0.4926;
                        }
                        if (Height >= 59 && Height < 59.5)
                        {
                            MeanWL = 5.8501;
                            SDWL = 0.5499;
                        }
                        if (Height >= 60 && Height < 60.5)
                        {
                            MeanWL = 5.9907;
                            SDWL = 0.5093;
                        }
                        if (Height >= 60 && Height < 60.5)
                        {
                            MeanWL = 6.1284;
                            SDWL = 0.5716;
                        }
                        if (Height >= 61 && Height < 61.5)
                        {
                            MeanWL = 6.2632;
                            SDWL = 0.5368;
                        }
                        if (Height >= 61 && Height < 61.5)
                        {
                            MeanWL = 6.3954;
                            SDWL = 0.6046;
                        }
                        if (Height >= 62 && Height < 62.5)
                        {
                            MeanWL = 6.5251;
                            SDWL = 0.5749;
                        }
                        if (Height >= 62 && Height < 62.5)
                        {
                            MeanWL = 6.6527;
                            SDWL = 0.5473;
                        }
                        if (Height >= 63 && Height < 63.5)
                        {
                            MeanWL = 6.7786;
                            SDWL = 0.6214;
                        }
                        if (Height >= 63 && Height < 63.5)
                        {
                            MeanWL = 6.9028;
                            SDWL = 0.5972;
                        }
                        if (Height >= 64 && Height < 64.5)
                        {
                            MeanWL = 7.0255;
                            SDWL = 0.5745;
                        }
                        if (Height >= 64 && Height < 64.5)
                        {
                            MeanWL = 7.1467;
                            SDWL = 0.6533;
                        }
                        if (Height >= 65 && Height < 65.5)
                        {
                            MeanWL = 7.2666;
                            SDWL = 0.6334;
                        }
                        if (Height >= 65 && Height < 65.5)
                        {
                            MeanWL = 7.3854;
                            SDWL = 0.6146;
                        }
                        if (Height >= 66 && Height < 66.5)
                        {
                            MeanWL = 7.5034;
                            SDWL = 0.6966;
                        }
                        if (Height >= 66 && Height < 66.5)
                        {
                            MeanWL = 7.6206;
                            SDWL = 0.6794;
                        }
                        if (Height >= 67 && Height < 67.5)
                        {
                            MeanWL = 7.737;
                            SDWL = 0.663;
                        }
                        if (Height >= 67 && Height < 67.5)
                        {
                            MeanWL = 7.8526;
                            SDWL = 0.6474;
                        }
                        if (Height >= 68 && Height < 68.5)
                        {
                            MeanWL = 7.9674;
                            SDWL = 0.7326;
                        }
                        if (Height >= 68 && Height < 68.5)
                        {
                            MeanWL = 8.0816;
                            SDWL = 0.7184;
                        }
                        if (Height >= 69 && Height < 69.5)
                        {
                            MeanWL = 8.1955;
                            SDWL = 0.7045;
                        }
                        if (Height >= 69 && Height < 69.5)
                        {
                            MeanWL = 8.3092;
                            SDWL = 0.6908;
                        }
                        if (Height >= 70 && Height < 70.5)
                        {
                            MeanWL = 8.4227;
                            SDWL = 0.7773;
                        }
                        if (Height >= 70 && Height < 70.5)
                        {
                            MeanWL = 8.5358;
                            SDWL = 0.7642;
                        }
                        if (Height >= 71 && Height < 71.5)
                        {
                            MeanWL = 8.648;
                            SDWL = 0.752;
                        }
                        if (Height >= 71 && Height < 71.5)
                        {
                            MeanWL = 8.7594;
                            SDWL = 0.7406;
                        }
                        if (Height >= 72 && Height < 72.5)
                        {
                            MeanWL = 8.8697;
                            SDWL = 0.7303;
                        }
                        if (Height >= 72 && Height < 72.5)
                        {
                            MeanWL = 8.9788;
                            SDWL = 0.8212;
                        }
                        if (Height >= 73 && Height < 73.5)
                        {
                            MeanWL = 9.0865;
                            SDWL = 0.8135;
                        }
                        if (Height >= 73 && Height < 73.5)
                        {
                            MeanWL = 9.1927;
                            SDWL = 0.8073;
                        }
                        if (Height >= 74 && Height < 74.5)
                        {
                            MeanWL = 9.2974;
                            SDWL = 0.8026;
                        }
                        if (Height >= 74 && Height < 74.5)
                        {
                            MeanWL = 9.401;
                            SDWL = 0.799;
                        }
                        if (Height >= 75 && Height < 75.5)
                        {
                            MeanWL = 9.5032;
                            SDWL = 0.7968;
                        }
                        if (Height >= 75 && Height < 75.5)
                        {
                            MeanWL = 9.6041;
                            SDWL = 0.7959;
                        }
                        if (Height >= 76 && Height < 76.5)
                        {
                            MeanWL = 9.7033;
                            SDWL = 0.8967;
                        }
                        if (Height >= 76 && Height < 76.5)
                        {
                            MeanWL = 9.8007;
                            SDWL = 0.8993;
                        }
                        if (Height >= 77 && Height < 77.5)
                        {
                            MeanWL = 9.8963;
                            SDWL = 0.9037;
                        }
                        if (Height >= 77 && Height < 77.5)
                        {
                            MeanWL = 9.9902;
                            SDWL = 0.9098;
                        }
                        if (Height >= 78 && Height < 78.5)
                        {
                            MeanWL = 10.0827;
                            SDWL = 0.9173;
                        }
                        if (Height >= 78 && Height < 78.5)
                        {
                            MeanWL = 10.1741;
                            SDWL = 0.9259;
                        }
                        if (Height >= 79 && Height < 79.5)
                        {
                            MeanWL = 10.2649;
                            SDWL = 0.9351;
                        }
                        if (Height >= 79 && Height < 79.5)
                        {
                            MeanWL = 10.3558;
                            SDWL = 0.9442;
                        }
                        if (Height >= 80 && Height < 80.5)
                        {
                            MeanWL = 10.4475;
                            SDWL = 0.9525;
                        }
                        if (Height >= 80 && Height < 80.5)
                        {
                            MeanWL = 10.5405;
                            SDWL = 0.9595;
                        }
                        if (Height >= 81 && Height < 81.5)
                        {
                            MeanWL = 10.6352;
                            SDWL = 0.9648;
                        }
                        if (Height >= 81 && Height < 81.5)
                        {
                            MeanWL = 10.7322;
                            SDWL = 0.9678;
                        }
                        if (Height >= 82 && Height < 82.5)
                        {
                            MeanWL = 10.8321;
                            SDWL = 0.9679;
                        }
                        if (Height >= 82 && Height < 82.5)
                        {
                            MeanWL = 10.935;
                            SDWL = 0.965;
                        }
                        if (Height >= 83 && Height < 83.5)
                        {
                            MeanWL = 11.0415;
                            SDWL = 0.9585;
                        }
                        if (Height >= 83 && Height < 83.5)
                        {
                            MeanWL = 11.1516;
                            SDWL = 0.9484;
                        }
                        if (Height >= 84 && Height < 84.5)
                        {
                            MeanWL = 11.2651;
                            SDWL = 0.9349;
                        }
                        if (Height >= 84 && Height < 84.5)
                        {
                            MeanWL = 11.3817;
                            SDWL = 1.0183;
                        }
                        if (Height >= 85 && Height < 85.5)
                        {
                            MeanWL = 11.5007;
                            SDWL = 0.9993;
                        }
                        if (Height >= 85 && Height < 85.5)
                        {
                            MeanWL = 11.6218;
                            SDWL = 0.9782;
                        }
                        if (Height >= 86 && Height < 86.5)
                        {
                            MeanWL = 11.7444;
                            SDWL = 1.0556;
                        }
                        if (Height >= 86 && Height < 86.5)
                        {
                            MeanWL = 11.8678;
                            SDWL = 1.0322;
                        }
                        if (Height >= 87 && Height < 87.5)
                        {
                            MeanWL = 11.9916;
                            SDWL = 1.0084;
                        }
                        if (Height >= 87 && Height < 87.5)
                        {
                            MeanWL = 12.1152;
                            SDWL = 1.0848;
                        }
                        if (Height >= 88 && Height < 88.5)
                        {
                            MeanWL = 12.2382;
                            SDWL = 1.0618;
                        }
                        if (Height >= 88 && Height < 88.5)
                        {
                            MeanWL = 12.3603;
                            SDWL = 1.0397;
                        }
                        if (Height >= 89 && Height < 89.5)
                        {
                            MeanWL = 12.4815;
                            SDWL = 1.0185;
                        }
                        if (Height >= 89 && Height < 89.5)
                        {
                            MeanWL = 12.6017;
                            SDWL = 1.0983;
                        }
                        if (Height >= 90 && Height < 90.5)
                        {
                            MeanWL = 12.7209;
                            SDWL = 1.0791;
                        }
                        if (Height >= 90 && Height < 90.5)
                        {
                            MeanWL = 12.8392;
                            SDWL = 1.0608;
                        }
                        if (Height >= 91 && Height < 91.5)
                        {
                            MeanWL = 12.9569;
                            SDWL = 1.1431;
                        }
                        if (Height >= 91 && Height < 91.5)
                        {
                            MeanWL = 13.0742;
                            SDWL = 1.1258;
                        }
                        if (Height >= 92 && Height < 92.5)
                        {
                            MeanWL = 13.191;
                            SDWL = 1.109;
                        }
                        if (Height >= 92 && Height < 92.5)
                        {
                            MeanWL = 13.3075;
                            SDWL = 1.0925;
                        }
                        if (Height >= 93 && Height < 93.5)
                        {
                            MeanWL = 13.4239;
                            SDWL = 1.1761;
                        }
                        if (Height >= 93 && Height < 93.5)
                        {
                            MeanWL = 13.5404;
                            SDWL = 1.1596;
                        }
                        if (Height >= 94 && Height < 94.5)
                        {
                            MeanWL = 13.6572;
                            SDWL = 1.1428;
                        }
                        if (Height >= 94 && Height < 94.5)
                        {
                            MeanWL = 13.7746;
                            SDWL = 1.1254;
                        }
                        if (Height >= 95 && Height < 95.5)
                        {
                            MeanWL = 13.8928;
                            SDWL = 1.2072;
                        }
                        if (Height >= 95 && Height < 95.5)
                        {
                            MeanWL = 14.012;
                            SDWL = 1.188;
                        }
                        if (Height >= 96 && Height < 96.5)
                        {
                            MeanWL = 14.1325;
                            SDWL = 1.1675;
                        }
                        if (Height >= 96 && Height < 96.5)
                        {
                            MeanWL = 14.2544;
                            SDWL = 1.2456;
                        }
                        if (Height >= 97 && Height < 97.5)
                        {
                            MeanWL = 14.3782;
                            SDWL = 1.2218;
                        }
                        if (Height >= 97 && Height < 97.5)
                        {
                            MeanWL = 14.5038;
                            SDWL = 1.1962;
                        }
                        if (Height >= 98 && Height < 98.5)
                        {
                            MeanWL = 14.6316;
                            SDWL = 1.2684;
                        }
                        if (Height >= 98 && Height < 98.5)
                        {
                            MeanWL = 14.7614;
                            SDWL = 1.2386;
                        }
                        if (Height >= 99 && Height < 99.5)
                        {
                            MeanWL = 14.8934;
                            SDWL = 1.3066;
                        }
                        if (Height >= 99 && Height < 99.5)
                        {
                            MeanWL = 15.0275;
                            SDWL = 1.2725;
                        }
                        if (Height >= 100 && Height < 100.5)
                        {
                            MeanWL = 15.1637;
                            SDWL = 1.3363;
                        }
                        if (Height >= 100 && Height < 100.5)
                        {
                            MeanWL = 15.3018;
                            SDWL = 1.2982;
                        }
                        if (Height >= 101 && Height < 101.5)
                        {
                            MeanWL = 15.4419;
                            SDWL = 1.3581;
                        }
                        if (Height >= 101 && Height < 101.5)
                        {
                            MeanWL = 15.5838;
                            SDWL = 1.3162;
                        }
                        if (Height >= 102 && Height < 102.5)
                        {
                            MeanWL = 15.7276;
                            SDWL = 1.3724;
                        }
                        if (Height >= 102 && Height < 102.5)
                        {
                            MeanWL = 15.8732;
                            SDWL = 1.4268;
                        }
                        if (Height >= 103 && Height < 103.5)
                        {
                            MeanWL = 16.0206;
                            SDWL = 1.3794;
                        }
                        if (Height >= 103 && Height < 103.5)
                        {
                            MeanWL = 16.1697;
                            SDWL = 1.4303;
                        }
                        if (Height >= 104 && Height < 104.5)
                        {
                            MeanWL = 16.3204;
                            SDWL = 1.4796;
                        }
                        if (Height >= 104 && Height < 104.5)
                        {
                            MeanWL = 16.4728;
                            SDWL = 1.4272;
                        }
                        if (Height >= 105 && Height < 105.5)
                        {
                            MeanWL = 16.6268;
                            SDWL = 1.4732;
                        }
                        if (Height >= 105 && Height < 105.5)
                        {
                            MeanWL = 16.7826;
                            SDWL = 1.5174;
                        }
                        if (Height >= 106 && Height < 106.5)
                        {
                            MeanWL = 16.9401;
                            SDWL = 1.5599;
                        }
                        if (Height >= 106 && Height < 106.5)
                        {
                            MeanWL = 17.0995;
                            SDWL = 1.5005;
                        }
                        if (Height >= 107 && Height < 107.5)
                        {
                            MeanWL = 17.2607;
                            SDWL = 1.5393;
                        }
                        if (Height >= 107 && Height < 107.5)
                        {
                            MeanWL = 17.4237;
                            SDWL = 1.5763;
                        }
                        if (Height >= 108 && Height < 108.5)
                        {
                            MeanWL = 17.5885;
                            SDWL = 1.6115;
                        }
                        if (Height >= 108 && Height < 108.5)
                        {
                            MeanWL = 17.7553;
                            SDWL = 1.6447;
                        }
                        if (Height >= 109 && Height < 109.5)
                        {
                            MeanWL = 17.9242;
                            SDWL = 1.6758;
                        }
                        if (Height >= 109 && Height < 109.5)
                        {
                            MeanWL = 18.0954;
                            SDWL = 1.7046;
                        }
                        if (Height >= 110 && Height < 110.5)
                        {
                            MeanWL = 18.2689;
                            SDWL = 1.7311;
                        }
                    }

                    if (Height >= 720 && Height < 1830)
                    {

                        if (Height >= 65 && Height < 65.5)
                        {
                            MeanWL = 7.4327;
                            SDWL = 0.6673;
                        }
                        if (Height >= 65 && Height < 65.5)
                        {
                            MeanWL = 7.5504;
                            SDWL = 0.6496;
                        }
                        if (Height >= 66 && Height < 66.5)
                        {
                            MeanWL = 7.6673;
                            SDWL = 0.6327;
                        }
                        if (Height >= 66 && Height < 66.5)
                        {
                            MeanWL = 7.7834;
                            SDWL = 0.7166;
                        }
                        if (Height >= 67 && Height < 67.5)
                        {
                            MeanWL = 7.8986;
                            SDWL = 0.7014;
                        }
                        if (Height >= 67 && Height < 67.5)
                        {
                            MeanWL = 8.0132;
                            SDWL = 0.6868;
                        }
                        if (Height >= 68 && Height < 68.5)
                        {
                            MeanWL = 8.1272;
                            SDWL = 0.6728;
                        }
                        if (Height >= 68 && Height < 68.5)
                        {
                            MeanWL = 8.241;
                            SDWL = 0.759;
                        }
                        if (Height >= 69 && Height < 69.5)
                        {
                            MeanWL = 8.3547;
                            SDWL = 0.7453;
                        }
                        if (Height >= 69 && Height < 69.5)
                        {
                            MeanWL = 8.468;
                            SDWL = 0.732;
                        }
                        if (Height >= 70 && Height < 70.5)
                        {
                            MeanWL = 8.5808;
                            SDWL = 0.7192;
                        }
                        if (Height >= 70 && Height < 70.5)
                        {
                            MeanWL = 8.6927;
                            SDWL = 0.8073;
                        }
                        if (Height >= 71 && Height < 71.5)
                        {
                            MeanWL = 8.8036;
                            SDWL = 0.7964;
                        }
                        if (Height >= 71 && Height < 71.5)
                        {
                            MeanWL = 8.9135;
                            SDWL = 0.7865;
                        }
                        if (Height >= 72 && Height < 72.5)
                        {
                            MeanWL = 9.0221;
                            SDWL = 0.7779;
                        }
                        if (Height >= 72 && Height < 72.5)
                        {
                            MeanWL = 9.1292;
                            SDWL = 0.7708;
                        }
                        if (Height >= 73 && Height < 73.5)
                        {
                            MeanWL = 9.2347;
                            SDWL = 0.7653;
                        }
                        if (Height >= 73 && Height < 73.5)
                        {
                            MeanWL = 9.339;
                            SDWL = 0.861;
                        }
                        if (Height >= 74 && Height < 74.5)
                        {
                            MeanWL = 9.442;
                            SDWL = 0.858;
                        }
                        if (Height >= 74 && Height < 74.5)
                        {
                            MeanWL = 9.5438;
                            SDWL = 0.8562;
                        }
                        if (Height >= 75 && Height < 75.5)
                        {
                            MeanWL = 9.644;
                            SDWL = 0.856;
                        }
                        if (Height >= 75 && Height < 75.5)
                        {
                            MeanWL = 9.7425;
                            SDWL = 0.8575;
                        }
                        if (Height >= 76 && Height < 76.5)
                        {
                            MeanWL = 9.8392;
                            SDWL = 0.8608;
                        }
                        if (Height >= 76 && Height < 76.5)
                        {
                            MeanWL = 9.9341;
                            SDWL = 0.8659;
                        }
                        if (Height >= 77 && Height < 77.5)
                        {
                            MeanWL = 10.0274;
                            SDWL = 0.8726;
                        }
                        if (Height >= 77 && Height < 77.5)
                        {
                            MeanWL = 10.1194;
                            SDWL = 0.8806;
                        }
                        if (Height >= 78 && Height < 78.5)
                        {
                            MeanWL = 10.2105;
                            SDWL = 0.8895;
                        }
                        if (Height >= 78 && Height < 78.5)
                        {
                            MeanWL = 10.3012;
                            SDWL = 0.8988;
                        }
                        if (Height >= 79 && Height < 79.5)
                        {
                            MeanWL = 10.3923;
                            SDWL = 0.9077;
                        }
                        if (Height >= 79 && Height < 79.5)
                        {
                            MeanWL = 10.4845;
                            SDWL = 0.9155;
                        }
                        if (Height >= 80 && Height < 80.5)
                        {
                            MeanWL = 10.5781;
                            SDWL = 0.9219;
                        }
                        if (Height >= 80 && Height < 80.5)
                        {
                            MeanWL = 10.6737;
                            SDWL = 0.9263;
                        }
                        if (Height >= 81 && Height < 81.5)
                        {
                            MeanWL = 10.7718;
                            SDWL = 0.9282;
                        }
                        if (Height >= 81 && Height < 81.5)
                        {
                            MeanWL = 10.8728;
                            SDWL = 0.9272;
                        }
                        if (Height >= 82 && Height < 82.5)
                        {
                            MeanWL = 10.9772;
                            SDWL = 0.9228;
                        }
                        if (Height >= 82 && Height < 82.5)
                        {
                            MeanWL = 11.0851;
                            SDWL = 1.0149;
                        }
                        if (Height >= 83 && Height < 83.5)
                        {
                            MeanWL = 11.1966;
                            SDWL = 1.0034;
                        }
                        if (Height >= 83 && Height < 83.5)
                        {
                            MeanWL = 11.3114;
                            SDWL = 0.9886;
                        }
                        if (Height >= 84 && Height < 84.5)
                        {
                            MeanWL = 11.429;
                            SDWL = 0.971;
                        }
                        if (Height >= 84 && Height < 84.5)
                        {
                            MeanWL = 11.549;
                            SDWL = 0.951;
                        }
                        if (Height >= 85 && Height < 85.5)
                        {
                            MeanWL = 11.6707;
                            SDWL = 1.0293;
                        }
                        if (Height >= 85 && Height < 85.5)
                        {
                            MeanWL = 11.7937;
                            SDWL = 1.0063;
                        }
                        if (Height >= 86 && Height < 86.5)
                        {
                            MeanWL = 11.9173;
                            SDWL = 0.9827;
                        }
                        if (Height >= 86 && Height < 86.5)
                        {
                            MeanWL = 12.0411;
                            SDWL = 1.0589;
                        }
                        if (Height >= 87 && Height < 87.5)
                        {
                            MeanWL = 12.1645;
                            SDWL = 1.0355;
                        }
                        if (Height >= 87 && Height < 87.5)
                        {
                            MeanWL = 12.2871;
                            SDWL = 1.0129;
                        }
                        if (Height >= 88 && Height < 88.5)
                        {
                            MeanWL = 12.4089;
                            SDWL = 1.0911;
                        }
                        if (Height >= 88 && Height < 88.5)
                        {
                            MeanWL = 12.5298;
                            SDWL = 1.0702;
                        }
                        if (Height >= 89 && Height < 89.5)
                        {
                            MeanWL = 12.6495;
                            SDWL = 1.0505;
                        }
                        if (Height >= 89 && Height < 89.5)
                        {
                            MeanWL = 12.7683;
                            SDWL = 1.1317;
                        }
                        if (Height >= 90 && Height < 90.5)
                        {
                            MeanWL = 12.8864;
                            SDWL = 1.1136;
                        }
                        if (Height >= 90 && Height < 90.5)
                        {
                            MeanWL = 13.0038;
                            SDWL = 1.0962;
                        }
                        if (Height >= 91 && Height < 91.5)
                        {
                            MeanWL = 13.1209;
                            SDWL = 1.0791;
                        }
                        if (Height >= 91 && Height < 91.5)
                        {
                            MeanWL = 13.2376;
                            SDWL = 1.1624;
                        }
                        if (Height >= 92 && Height < 92.5)
                        {
                            MeanWL = 13.3541;
                            SDWL = 1.1459;
                        }
                        if (Height >= 92 && Height < 92.5)
                        {
                            MeanWL = 13.4705;
                            SDWL = 1.1295;
                        }
                        if (Height >= 93 && Height < 93.5)
                        {
                            MeanWL = 13.587;
                            SDWL = 1.113;
                        }
                        if (Height >= 93 && Height < 93.5)
                        {
                            MeanWL = 13.7041;
                            SDWL = 1.1959;
                        }
                        if (Height >= 94 && Height < 94.5)
                        {
                            MeanWL = 13.8217;
                            SDWL = 1.1783;
                        }
                        if (Height >= 94 && Height < 94.5)
                        {
                            MeanWL = 13.9403;
                            SDWL = 1.1597;
                        }
                        if (Height >= 95 && Height < 95.5)
                        {
                            MeanWL = 14.06;
                            SDWL = 1.24;
                        }
                        if (Height >= 95 && Height < 95.5)
                        {
                            MeanWL = 14.1811;
                            SDWL = 1.2189;
                        }
                        if (Height >= 96 && Height < 96.5)
                        {
                            MeanWL = 14.3037;
                            SDWL = 1.1963;
                        }
                        if (Height >= 96 && Height < 96.5)
                        {
                            MeanWL = 14.4282;
                            SDWL = 1.2718;
                        }
                        if (Height >= 97 && Height < 97.5)
                        {
                            MeanWL = 14.5547;
                            SDWL = 1.2453;
                        }
                        if (Height >= 97 && Height < 97.5)
                        {
                            MeanWL = 14.6832;
                            SDWL = 1.2168;
                        }
                        if (Height >= 98 && Height < 98.5)
                        {
                            MeanWL = 14.814;
                            SDWL = 1.286;
                        }
                        if (Height >= 98 && Height < 98.5)
                        {
                            MeanWL = 14.9468;
                            SDWL = 1.2532;
                        }
                        if (Height >= 99 && Height < 99.5)
                        {
                            MeanWL = 15.0818;
                            SDWL = 1.3182;
                        }
                        if (Height >= 99 && Height < 99.5)
                        {
                            MeanWL = 15.2187;
                            SDWL = 1.2813;
                        }
                        if (Height >= 100 && Height < 100.5)
                        {
                            MeanWL = 15.3576;
                            SDWL = 1.3424;
                        }
                        if (Height >= 100 && Height < 100.5)
                        {
                            MeanWL = 15.4985;
                            SDWL = 1.4015;
                        }
                        if (Height >= 101 && Height < 101.5)
                        {
                            MeanWL = 15.6412;
                            SDWL = 1.3588;
                        }
                        if (Height >= 101 && Height < 101.5)
                        {
                            MeanWL = 15.7857;
                            SDWL = 1.4143;
                        }
                        if (Height >= 102 && Height < 102.5)
                        {
                            MeanWL = 15.932;
                            SDWL = 1.368;
                        }
                        if (Height >= 102 && Height < 102.5)
                        {
                            MeanWL = 16.0801;
                            SDWL = 1.4199;
                        }
                        if (Height >= 103 && Height < 103.5)
                        {
                            MeanWL = 16.2298;
                            SDWL = 1.4702;
                        }
                        if (Height >= 103 && Height < 103.5)
                        {
                            MeanWL = 16.3812;
                            SDWL = 1.4188;
                        }
                        if (Height >= 104 && Height < 104.5)
                        {
                            MeanWL = 16.5342;
                            SDWL = 1.4658;
                        }
                        if (Height >= 104 && Height < 104.5)
                        {
                            MeanWL = 16.6889;
                            SDWL = 1.5111;
                        }
                        if (Height >= 105 && Height < 105.5)
                        {
                            MeanWL = 16.8454;
                            SDWL = 1.5546;
                        }
                        if (Height >= 105 && Height < 105.5)
                        {
                            MeanWL = 17.0036;
                            SDWL = 1.4964;
                        }
                        if (Height >= 106 && Height < 106.5)
                        {
                            MeanWL = 17.1637;
                            SDWL = 1.5363;
                        }
                        if (Height >= 106 && Height < 106.5)
                        {
                            MeanWL = 17.3256;
                            SDWL = 1.5744;
                        }
                        if (Height >= 107 && Height < 107.5)
                        {
                            MeanWL = 17.4894;
                            SDWL = 1.6106;
                        }
                        if (Height >= 107 && Height < 107.5)
                        {
                            MeanWL = 17.655;
                            SDWL = 1.645;
                        }
                        if (Height >= 108 && Height < 108.5)
                        {
                            MeanWL = 17.8226;
                            SDWL = 1.6774;
                        }
                        if (Height >= 108 && Height < 108.5)
                        {
                            MeanWL = 17.9924;
                            SDWL = 1.7076;
                        }
                        if (Height >= 109 && Height < 109.5)
                        {
                            MeanWL = 18.1645;
                            SDWL = 1.6355;
                        }
                        if (Height >= 109 && Height < 109.5)
                        {
                            MeanWL = 18.339;
                            SDWL = 1.661;
                        }
                        if (Height >= 110 && Height < 110.5)
                        {
                            MeanWL = 18.5158;
                            SDWL = 1.6842;
                        }
                        if (Height >= 110 && Height < 110.5)
                        {
                            MeanWL = 18.6948;
                            SDWL = 1.7052;
                        }
                        if (Height >= 111 && Height < 111.5)
                        {
                            MeanWL = 18.8759;
                            SDWL = 1.8241;
                        }
                        if (Height >= 111 && Height < 111.5)
                        {
                            MeanWL = 19.059;
                            SDWL = 1.841;
                        }
                        if (Height >= 112 && Height < 112.5)
                        {
                            MeanWL = 19.2439;
                            SDWL = 1.8561;
                        }
                        if (Height >= 112 && Height < 112.5)
                        {
                            MeanWL = 19.4304;
                            SDWL = 1.8696;
                        }
                        if (Height >= 113 && Height < 113.5)
                        {
                            MeanWL = 19.6185;
                            SDWL = 1.8815;
                        }
                        if (Height >= 113 && Height < 113.5)
                        {
                            MeanWL = 19.8081;
                            SDWL = 1.8919;
                        }
                        if (Height >= 114 && Height < 114.5)
                        {
                            MeanWL = 19.999;
                            SDWL = 1.901;
                        }
                        if (Height >= 114 && Height < 114.5)
                        {
                            MeanWL = 20.1912;
                            SDWL = 1.9088;
                        }
                        if (Height >= 115 && Height < 115.5)
                        {
                            MeanWL = 20.3846;
                            SDWL = 2.0154;
                        }
                        if (Height >= 115 && Height < 115.5)
                        {
                            MeanWL = 20.5789;
                            SDWL = 2.0211;
                        }
                        if (Height >= 116 && Height < 116.5)
                        {
                            MeanWL = 20.7741;
                            SDWL = 2.0259;
                        }
                        if (Height >= 116 && Height < 116.5)
                        {
                            MeanWL = 20.97;
                            SDWL = 2.03;
                        }
                        if (Height >= 117 && Height < 117.5)
                        {
                            MeanWL = 21.1666;
                            SDWL = 2.1334;
                        }
                        if (Height >= 117 && Height < 117.5)
                        {
                            MeanWL = 21.3636;
                            SDWL = 2.1364;
                        }
                        if (Height >= 118 && Height < 118.5)
                        {
                            MeanWL = 21.5611;
                            SDWL = 2.1389;
                        }
                        if (Height >= 118 && Height < 118.5)
                        {
                            MeanWL = 21.7588;
                            SDWL = 2.1412;
                        }
                        if (Height >= 119 && Height < 119.5)
                        {
                            MeanWL = 21.9568;
                            SDWL = 2.1432;
                        }
                        if (Height >= 119 && Height < 119.5)
                        {
                            MeanWL = 22.1549;
                            SDWL = 2.2451;
                        }
                        if (Height >= 120 && Height < 120.5)
                        {
                            MeanWL = 22.353;
                            SDWL = 2.247;
                        }
                    }

                    // weight for age boys
                    if (Num >= 0 && Num < 7)
                    {
                        MeanW = 3.34;
                        SDW = 0.6;

                    }
                    if (Num >= 7 && Num < 14)
                    {
                        MeanW = 3.48;
                        SDW = 0.5;
                    }
                    if (Num >= 14 && Num < 22)
                    {
                        MeanW = 3.75;
                        SDW = 0.5;
                    }
                    if (Num >= 22 && Num < 30)
                    {
                        MeanW = 4.06;
                        SDW = 0.6;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanW = 4.4709;
                        SDW = 0.6291;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanW = 5.5675;
                        SDW = 0.7325;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanW = 6.3762;
                        SDW = 0.8238;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanW = 7.0023;
                        SDW = 0.7977;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanW = 7.5105;
                        SDW = 0.8895;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanW = 7.934;
                        SDW = 0.866;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanW = 8.297;
                        SDW = 0.903;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanW = 8.6151;
                        SDW = 0.9849;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanW = 8.9014;
                        SDW = 0.9986;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanW = 9.1649;
                        SDW = 1.0351;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanW = 9.4122;
                        SDW = 1.0878;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanW = 9.6479;
                        SDW = 1.1521;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanW = 9.8749;
                        SDW = 1.1251;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanW = 10.0953;
                        SDW = 1.2047;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanW = 10.3108;
                        SDW = 1.1892;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanW = 10.5228;
                        SDW = 1.1772;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanW = 10.7319;
                        SDW = 1.2681;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanW = 10.9385;
                        SDW = 1.2615;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanW = 11.143;
                        SDW = 1.357;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanW = 11.3462;
                        SDW = 1.3538;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanW = 11.5486;
                        SDW = 1.3514;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanW = 11.7504;
                        SDW = 1.4496;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanW = 11.9514;
                        SDW = 1.4486;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanW = 12.1515;
                        SDW = 1.4485;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanW = 12.3502;
                        SDW = 1.5498;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanW = 12.5466;
                        SDW = 1.5534;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanW = 12.7401;
                        SDW = 1.5599;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanW = 12.9303;
                        SDW = 1.5697;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanW = 13.1169;
                        SDW = 1.6831;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanW = 13.3;
                        SDW = 1.7;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanW = 13.4798;
                        SDW = 1.7202;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanW = 13.6567;
                        SDW = 1.7433;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanW = 13.8309;
                        SDW = 1.7691;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanW = 14.0031;
                        SDW = 1.7969;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanW = 14.1736;
                        SDW = 1.8264;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanW = 14.3429;
                        SDW = 1.8571;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanW = 14.5113;
                        SDW = 1.8887;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanW = 14.6791;
                        SDW = 1.9209;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanW = 14.8466;
                        SDW = 1.9534;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanW = 15.014;
                        SDW = 1.986;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanW = 15.1813;
                        SDW = 2.0187;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanW = 15.3486;
                        SDW = 2.0514;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanW = 15.5158;
                        SDW = 2.0842;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanW = 15.6828;
                        SDW = 2.1172;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanW = 15.8497;
                        SDW = 2.1503;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanW = 16.0163;
                        SDW = 2.1837;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanW = 16.1827;
                        SDW = 2.2173;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanW = 16.3489;
                        SDW = 2.2511;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanW = 16.515;
                        SDW = 2.285;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanW = 16.6811;
                        SDW = 2.3189;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanW = 16.8471;
                        SDW = 2.3529;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanW = 17.0132;
                        SDW = 2.3868;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanW = 17.1792;
                        SDW = 2.4208;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanW = 17.3452;
                        SDW = 2.4548;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanW = 17.5111;
                        SDW = 2.4889;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanW = 17.6768;
                        SDW = 2.5232;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanW = 17.8422;
                        SDW = 2.5578;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanW = 18.0073;
                        SDW = 2.5927;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanW = 18.1722;
                        SDW = 2.6278;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanW = 18.3366;
                        SDW = 2.6634;
                    }
                    if (Num >= 1830 && Num < 1860)
                    {
                        MeanW = 18.505700;
                        SDW = 2.603300;
                    }
                    if (Num >= 1860 && Num < 1890)
                    {
                        MeanW = 18.680200;
                        SDW = 2.638800;
                    }
                    if (Num >= 1890 && Num < 1920)
                    {
                        MeanW = 18.856300;
                        SDW = 2.673700;
                    }
                    if (Num >= 1920 && Num < 1950)
                    {
                        MeanW = 19.034000;
                        SDW = 2.710000;
                    }
                    if (Num >= 1950 && Num < 1980)
                    {
                        MeanW = 19.213200;
                        SDW = 2.745800;
                    }
                    if (Num >= 1980 && Num < 2010)
                    {
                        MeanW = 19.394000;
                        SDW = 2.782000;
                    }
                    if (Num >= 2010 && Num < 2040)
                    {
                        MeanW = 19.576500;
                        SDW = 2.818500;
                    }
                    if (Num >= 2040 && Num < 2070)
                    {
                        MeanW = 19.760700;
                        SDW = 2.854300;
                    }
                    if (Num >= 2070 && Num < 2100)
                    {
                        MeanW = 19.946800;
                        SDW = 2.892200;
                    }
                    if (Num >= 2100 && Num < 2130)
                    {
                        MeanW = 20.134400;
                        SDW = 2.928600;
                    }
                    if (Num >= 2130 && Num < 2160)
                    {
                        MeanW = 20.323500;
                        SDW = 2.966500;
                    }
                    if (Num >= 2160 && Num < 2190)
                    {
                        MeanW = 20.513700;
                        SDW = 3.003300;
                    }
                    if (Num >= 2190 && Num < 2220)
                    {
                        MeanW = 20.705200;
                        SDW = 3.041800;
                    }
                    if (Num >= 2220 && Num < 2250)
                    {
                        MeanW = 20.897900;
                        SDW = 3.080100;
                    }
                    if (Num >= 2250 && Num < 2280)
                    {
                        MeanW = 21.091800;
                        SDW = 3.118200;
                    }
                    if (Num >= 2280 && Num < 2310)
                    {
                        MeanW = 21.287000;
                        SDW = 3.158000;
                    }
                    if (Num >= 2310 && Num < 2340)
                    {
                        MeanW = 21.483300;
                        SDW = 3.196700;
                    }
                    if (Num >= 2340 && Num < 2370)
                    {
                        MeanW = 21.681000;
                        SDW = 3.237000;
                    }
                    if (Num >= 2370 && Num < 2400)
                    {
                        MeanW = 21.879900;
                        SDW = 3.278100;
                    }
                    if (Num >= 2400 && Num < 2430)
                    {
                        MeanW = 22.080000;
                        SDW = 3.319000;
                    }
                    if (Num >= 2430 && Num < 2460)
                    {
                        MeanW = 22.281300;
                        SDW = 3.360700;
                    }
                    if (Num >= 2460 && Num < 2490)
                    {
                        MeanW = 22.483700;
                        SDW = 3.403300;
                    }
                    if (Num >= 2490 && Num < 2520)
                    {
                        MeanW = 22.687200;
                        SDW = 3.446800;
                    }
                    if (Num >= 2520 && Num < 2550)
                    {
                        MeanW = 22.891500;
                        SDW = 3.490500;
                    }
                    if (Num >= 2550 && Num < 2580)
                    {
                        MeanW = 23.096800;
                        SDW = 3.535200;
                    }
                    if (Num >= 2580 && Num < 2610)
                    {
                        MeanW = 23.302900;
                        SDW = 3.582100;
                    }
                    if (Num >= 2610 && Num < 2640)
                    {
                        MeanW = 23.510100;
                        SDW = 3.627900;
                    }
                    if (Num >= 2640 && Num < 2670)
                    {
                        MeanW = 23.718200;
                        SDW = 3.675800;
                    }
                    if (Num >= 2670 && Num < 2700)
                    {
                        MeanW = 23.927200;
                        SDW = 3.724800;
                    }
                    if (Num >= 2700 && Num < 2730)
                    {
                        MeanW = 24.137100;
                        SDW = 3.773900;
                    }
                    if (Num >= 2730 && Num < 2760)
                    {
                        MeanW = 24.347900;
                        SDW = 3.824100;
                    }
                    if (Num >= 2760 && Num < 2790)
                    {
                        MeanW = 24.559500;
                        SDW = 3.876500;
                    }
                    if (Num >= 2790 && Num < 2820)
                    {
                        MeanW = 24.772200;
                        SDW = 3.928800;
                    }
                    if (Num >= 2820 && Num < 2850)
                    {
                        MeanW = 24.985800;
                        SDW = 3.983200;
                    }
                    if (Num >= 2850 && Num < 2880)
                    {
                        MeanW = 25.200500;
                        SDW = 4.038500;
                    }
                    if (Num >= 2880 && Num < 2910)
                    {
                        MeanW = 25.416300;
                        SDW = 4.095700;
                    }
                    if (Num >= 2910 && Num < 2940)
                    {
                        MeanW = 25.633200;
                        SDW = 4.153800;
                    }
                    if (Num >= 2940 && Num < 2970)
                    {
                        MeanW = 25.851300;
                        SDW = 4.212700;
                    }
                    if (Num >= 2970 && Num < 3000)
                    {
                        MeanW = 26.070600;
                        SDW = 4.273400;
                    }
                    if (Num >= 3000 && Num < 3030)
                    {
                        MeanW = 26.291100;
                        SDW = 4.335900;
                    }
                    if (Num >= 3030 && Num < 3060)
                    {
                        MeanW = 26.512800;
                        SDW = 4.399200;
                    }
                    if (Num >= 3060 && Num < 3090)
                    {
                        MeanW = 26.735800;
                        SDW = 4.463200;
                    }
                    if (Num >= 3090 && Num < 3120)
                    {
                        MeanW = 26.960200;
                        SDW = 4.529800;
                    }
                    if (Num >= 3120 && Num < 3150)
                    {
                        MeanW = 27.186100;
                        SDW = 4.597900;
                    }
                    if (Num >= 3150 && Num < 3180)
                    {
                        MeanW = 27.413700;
                        SDW = 4.666300;
                    }
                    if (Num >= 3180 && Num < 3210)
                    {
                        MeanW = 27.643200;
                        SDW = 4.737800;
                    }
                    if (Num >= 3210 && Num < 3240)
                    {
                        MeanW = 27.875000;
                        SDW = 4.810000;
                    }
                    if (Num >= 3240 && Num < 3270)
                    {
                        MeanW = 28.109200;
                        SDW = 4.883800;
                    }
                    if (Num >= 3270 && Num < 3300)
                    {
                        MeanW = 28.345900;
                        SDW = 4.959100;
                    }
                    if (Num >= 3300 && Num < 3330)
                    {
                        MeanW = 28.585400;
                        SDW = 5.035600;
                    }
                    if (Num >= 3330 && Num < 3360)
                    {
                        MeanW = 28.827700;
                        SDW = 5.113300;
                    }
                    if (Num >= 3360 && Num < 3390)
                    {
                        MeanW = 29.073100;
                        SDW = 5.192900;
                    }
                    if (Num >= 3390 && Num < 3420)
                    {
                        MeanW = 29.321700;
                        SDW = 5.273300;
                    }
                    if (Num >= 3420 && Num < 3450)
                    {
                        MeanW = 29.573600;
                        SDW = 5.355400;
                    }
                    if (Num >= 3450 && Num < 3480)
                    {
                        MeanW = 29.828900;
                        SDW = 5.439100;
                    }
                    if (Num >= 3480 && Num < 3510)
                    {
                        MeanW = 30.087700;
                        SDW = 5.524300;
                    }
                    if (Num >= 3510 && Num < 3540)
                    {
                        MeanW = 30.350100;
                        SDW = 5.609900;
                    }
                    if (Num >= 3540 && Num < 3570)
                    {
                        MeanW = 30.616000;
                        SDW = 5.697000;
                    }
                    if (Num >= 3570 && Num < 3600)
                    {
                        MeanW = 30.885400;
                        SDW = 5.785600;
                    }
                    if (Num >= 3600 && Num < 3630)
                    {
                        MeanW = 31.158600;
                        SDW = 5.876400;
                    }
                    if (Num >= 3630 && Num < 3645)
                    {
                        MeanW = 32.2419;
                        SDW = 7.21973;
                    }
                    if (Num >= 3645 && Num < 3660)
                    {
                        MeanW = 32.3969;
                        SDW = 7.27366;
                    }
                    if (Num >= 3660 && Num < 3675)
                    {
                        MeanW = 32.5529;
                        SDW = 7.32777;
                    }
                    if (Num >= 3675 && Num < 3690)
                    {
                        MeanW = 32.7099;
                        SDW = 7.38204;
                    }
                    if (Num >= 3690 && Num < 3705)
                    {
                        MeanW = 32.868;
                        SDW = 7.43646;
                    }
                    if (Num >= 3705 && Num < 3720)
                    {
                        MeanW = 33.027;
                        SDW = 7.49102;
                    }
                    if (Num >= 3720 && Num < 3735)
                    {
                        MeanW = 33.1872;
                        SDW = 7.54571;
                    }
                    if (Num >= 3735 && Num < 3750)
                    {
                        MeanW = 33.3484;
                        SDW = 7.60052;
                    }
                    if (Num >= 3750 && Num < 3765)
                    {
                        MeanW = 33.5106;
                        SDW = 7.65543;
                    }
                    if (Num >= 3765 && Num < 3780)
                    {
                        MeanW = 33.6739;
                        SDW = 7.71045;
                    }
                    if (Num >= 3780 && Num < 3795)
                    {
                        MeanW = 33.8382;
                        SDW = 7.76554;
                    }
                    if (Num >= 3795 && Num < 3810)
                    {
                        MeanW = 34.0036;
                        SDW = 7.82071;
                    }
                    if (Num >= 3810 && Num < 3825)
                    {
                        MeanW = 34.1701;
                        SDW = 7.87593;
                    }
                    if (Num >= 3825 && Num < 3840)
                    {
                        MeanW = 34.3377;
                        SDW = 7.9312;
                    }
                    if (Num >= 3840 && Num < 3855)
                    {
                        MeanW = 34.5063;
                        SDW = 7.9865;
                    }
                    if (Num >= 3855 && Num < 3870)
                    {
                        MeanW = 34.676;
                        SDW = 8.04183;
                    }
                    if (Num >= 3870 && Num < 3885)
                    {
                        MeanW = 34.8468;
                        SDW = 8.09716;
                    }
                    if (Num >= 3885 && Num < 3900)
                    {
                        MeanW = 35.0186;
                        SDW = 8.15249;
                    }
                    if (Num >= 3900 && Num < 3915)
                    {
                        MeanW = 35.1916;
                        SDW = 8.20781;
                    }
                    if (Num >= 3915 && Num < 3930)
                    {
                        MeanW = 35.3656;
                        SDW = 8.26309;
                    }
                    if (Num >= 3930 && Num < 3945)
                    {
                        MeanW = 35.5407;
                        SDW = 8.31833;
                    }
                    if (Num >= 3945 && Num < 3960)
                    {
                        MeanW = 35.7169;
                        SDW = 8.37351;
                    }
                    if (Num >= 3960 && Num < 3975)
                    {
                        MeanW = 35.8942;
                        SDW = 8.42862;
                    }
                    if (Num >= 3975 && Num < 3990)
                    {
                        MeanW = 36.0726;
                        SDW = 8.48365;
                    }
                    if (Num >= 3990 && Num < 4005)
                    {
                        MeanW = 36.2521;
                        SDW = 8.53858;
                    }
                    if (Num >= 4005 && Num < 4020)
                    {
                        MeanW = 36.4327;
                        SDW = 8.59341;
                    }
                    if (Num >= 4020 && Num < 4035)
                    {
                        MeanW = 36.6143;
                        SDW = 8.64811;
                    }
                    if (Num >= 4035 && Num < 4050)
                    {
                        MeanW = 36.797;
                        SDW = 8.70267;
                    }
                    if (Num >= 4050 && Num < 4065)
                    {
                        MeanW = 36.9809;
                        SDW = 8.75709;
                    }
                    if (Num >= 4065 && Num < 4080)
                    {
                        MeanW = 37.1658;
                        SDW = 8.81134;
                    }
                    if (Num >= 4080 && Num < 4095)
                    {
                        MeanW = 37.3518;
                        SDW = 8.86542;
                    }
                    if (Num >= 4095 && Num < 4110)
                    {
                        MeanW = 37.5388;
                        SDW = 8.9193;
                    }
                    if (Num >= 4110 && Num < 4125)
                    {
                        MeanW = 37.7269;
                        SDW = 8.97299;
                    }
                    if (Num >= 4125 && Num < 4140)
                    {
                        MeanW = 37.9162;
                        SDW = 9.02646;
                    }
                    if (Num >= 4140 && Num < 4155)
                    {
                        MeanW = 38.1064;
                        SDW = 9.07971;
                    }
                    if (Num >= 4155 && Num < 4170)
                    {
                        MeanW = 38.2978;
                        SDW = 9.13272;
                    }
                    if (Num >= 4170 && Num < 4185)
                    {
                        MeanW = 38.4902;
                        SDW = 9.18547;
                    }
                    if (Num >= 4185 && Num < 4200)
                    {
                        MeanW = 38.6836;
                        SDW = 9.23796;
                    }
                    if (Num >= 4200 && Num < 4215)
                    {
                        MeanW = 38.8781;
                        SDW = 9.29018;
                    }
                    if (Num >= 4215 && Num < 4230)
                    {
                        MeanW = 39.0736;
                        SDW = 9.3421;
                    }
                    if (Num >= 4230 && Num < 4245)
                    {
                        MeanW = 39.2702;
                        SDW = 9.39373;
                    }
                    if (Num >= 4245 && Num < 4260)
                    {
                        MeanW = 39.4678;
                        SDW = 9.44504;
                    }
                    if (Num >= 4260 && Num < 4275)
                    {
                        MeanW = 39.6664;
                        SDW = 9.49603;
                    }
                    if (Num >= 4275 && Num < 4290)
                    {
                        MeanW = 39.866;
                        SDW = 9.54668;
                    }
                    if (Num >= 4290 && Num < 4305)
                    {
                        MeanW = 40.0667;
                        SDW = 9.59699;
                    }
                    if (Num >= 4305 && Num < 4320)
                    {
                        MeanW = 40.2683;
                        SDW = 9.64695;
                    }
                    if (Num >= 4320 && Num < 4335)
                    {
                        MeanW = 40.4709;
                        SDW = 9.69653;
                    }
                    if (Num >= 4335 && Num < 4350)
                    {
                        MeanW = 40.6744;
                        SDW = 9.74574;
                    }
                    if (Num >= 4350 && Num < 4365)
                    {
                        MeanW = 40.879;
                        SDW = 9.79456;
                    }
                    if (Num >= 4365 && Num < 4380)
                    {
                        MeanW = 41.0844;
                        SDW = 9.84299;
                    }
                    if (Num >= 4380 && Num < 4395)
                    {
                        MeanW = 41.2908;
                        SDW = 9.89101;
                    }
                    if (Num >= 4395 && Num < 4410)
                    {
                        MeanW = 41.4982;
                        SDW = 9.93862;
                    }
                    if (Num >= 4410 && Num < 4425)
                    {
                        MeanW = 41.7064;
                        SDW = 9.9858;
                    }
                    if (Num >= 4425 && Num < 4440)
                    {
                        MeanW = 41.9155;
                        SDW = 10.0326;
                    }
                    if (Num >= 4440 && Num < 4455)
                    {
                        MeanW = 42.1256;
                        SDW = 10.0789;
                    }
                    if (Num >= 4455 && Num < 4470)
                    {
                        MeanW = 42.3364;
                        SDW = 10.1247;
                    }
                    if (Num >= 4470 && Num < 4485)
                    {
                        MeanW = 42.5482;
                        SDW = 10.1701;
                    }
                    if (Num >= 4485 && Num < 4500)
                    {
                        MeanW = 42.7607;
                        SDW = 10.2151;
                    }
                    if (Num >= 4500 && Num < 4515)
                    {
                        MeanW = 42.9741;
                        SDW = 10.2596;
                    }
                    if (Num >= 4515 && Num < 4530)
                    {
                        MeanW = 43.1883;
                        SDW = 10.3036;
                    }
                    if (Num >= 4530 && Num < 4545)
                    {
                        MeanW = 43.4032;
                        SDW = 10.3471;
                    }
                    if (Num >= 4545 && Num < 4560)
                    {
                        MeanW = 43.619;
                        SDW = 10.3901;
                    }
                    if (Num >= 4560 && Num < 4575)
                    {
                        MeanW = 43.8354;
                        SDW = 10.4327;
                    }
                    if (Num >= 4575 && Num < 4590)
                    {
                        MeanW = 44.0526;
                        SDW = 10.4747;
                    }
                    if (Num >= 4590 && Num < 4605)
                    {
                        MeanW = 44.2705;
                        SDW = 10.5163;
                    }
                    if (Num >= 4605 && Num < 4620)
                    {
                        MeanW = 44.489;
                        SDW = 10.5573;
                    }
                    if (Num >= 4620 && Num < 4635)
                    {
                        MeanW = 44.7082;
                        SDW = 10.5978;
                    }
                    if (Num >= 4635 && Num < 4650)
                    {
                        MeanW = 44.9281;
                        SDW = 10.6379;
                    }
                    if (Num >= 4650 && Num < 4665)
                    {
                        MeanW = 45.1486;
                        SDW = 10.6774;
                    }
                    if (Num >= 4665 && Num < 4680)
                    {
                        MeanW = 45.3696;
                        SDW = 10.7164;
                    }
                    if (Num >= 4680 && Num < 4695)
                    {
                        MeanW = 45.5912;
                        SDW = 10.7548;
                    }
                    if (Num >= 4695 && Num < 4710)
                    {
                        MeanW = 45.8134;
                        SDW = 10.7928;
                    }
                    if (Num >= 4710 && Num < 4725)
                    {
                        MeanW = 46.036;
                        SDW = 10.8302;
                    }
                    if (Num >= 4725 && Num < 4740)
                    {
                        MeanW = 46.2592;
                        SDW = 10.8672;
                    }
                    if (Num >= 4740 && Num < 4755)
                    {
                        MeanW = 46.4828;
                        SDW = 10.9036;
                    }
                    if (Num >= 4755 && Num < 4770)
                    {
                        MeanW = 46.7068;
                        SDW = 10.9394;
                    }
                    if (Num >= 4770 && Num < 4785)
                    {
                        MeanW = 46.9312;
                        SDW = 10.9748;
                    }
                    if (Num >= 4785 && Num < 4800)
                    {
                        MeanW = 47.1561;
                        SDW = 11.0096;
                    }
                    if (Num >= 4800 && Num < 4815)
                    {
                        MeanW = 47.3812;
                        SDW = 11.0439;
                    }
                    if (Num >= 4815 && Num < 4830)
                    {
                        MeanW = 47.6067;
                        SDW = 11.0777;
                    }
                    if (Num >= 4830 && Num < 4845)
                    {
                        MeanW = 47.8325;
                        SDW = 11.111;
                    }
                    if (Num >= 4845 && Num < 4860)
                    {
                        MeanW = 48.0585;
                        SDW = 11.1438;
                    }
                    if (Num >= 4860 && Num < 4875)
                    {
                        MeanW = 48.2847;
                        SDW = 11.1761;
                    }
                    if (Num >= 4875 && Num < 4890)
                    {
                        MeanW = 48.5111;
                        SDW = 11.2078;
                    }
                    if (Num >= 4890 && Num < 4905)
                    {
                        MeanW = 48.7377;
                        SDW = 11.2391;
                    }
                    if (Num >= 4905 && Num < 4920)
                    {
                        MeanW = 48.9644;
                        SDW = 11.2698;
                    }
                    if (Num >= 4920 && Num < 4935)
                    {
                        MeanW = 49.1912;
                        SDW = 11.3001;
                    }
                    if (Num >= 4935 && Num < 4950)
                    {
                        MeanW = 49.4181;
                        SDW = 11.3299;
                    }
                    if (Num >= 4950 && Num < 4965)
                    {
                        MeanW = 49.645;
                        SDW = 11.3592;
                    }
                    if (Num >= 4965 && Num < 4980)
                    {
                        MeanW = 49.8719;
                        SDW = 11.388;
                    }
                    if (Num >= 4980 && Num < 4995)
                    {
                        MeanW = 50.0987;
                        SDW = 11.4164;
                    }
                    if (Num >= 4995 && Num < 5010)
                    {
                        MeanW = 50.3255;
                        SDW = 11.4442;
                    }
                    if (Num >= 5010 && Num < 5025)
                    {
                        MeanW = 50.5521;
                        SDW = 11.4717;
                    }
                    if (Num >= 5025 && Num < 5040)
                    {
                        MeanW = 50.7786;
                        SDW = 11.4987;
                    }
                    if (Num >= 5040 && Num < 5055)
                    {
                        MeanW = 51.0049;
                        SDW = 11.5252;
                    }
                    if (Num >= 5055 && Num < 5070)
                    {
                        MeanW = 51.231;
                        SDW = 11.5513;
                    }
                    if (Num >= 5070 && Num < 5085)
                    {
                        MeanW = 51.4568;
                        SDW = 11.577;
                    }
                    if (Num >= 5085 && Num < 5100)
                    {
                        MeanW = 51.6823;
                        SDW = 11.6022;
                    }
                    if (Num >= 5100 && Num < 5115)
                    {
                        MeanW = 51.9075;
                        SDW = 11.627;
                    }
                    if (Num >= 5115 && Num < 5130)
                    {
                        MeanW = 52.1323;
                        SDW = 11.6514;
                    }
                    if (Num >= 5130 && Num < 5145)
                    {
                        MeanW = 52.3567;
                        SDW = 11.6755;
                    }
                    if (Num >= 5145 && Num < 5160)
                    {
                        MeanW = 52.5806;
                        SDW = 11.6991;
                    }
                    if (Num >= 5160 && Num < 5175)
                    {
                        MeanW = 52.804;
                        SDW = 11.7224;
                    }
                    if (Num >= 5175 && Num < 5190)
                    {
                        MeanW = 53.027;
                        SDW = 11.7453;
                    }
                    if (Num >= 5190 && Num < 5205)
                    {
                        MeanW = 53.2493;
                        SDW = 11.7678;
                    }
                    if (Num >= 5205 && Num < 5220)
                    {
                        MeanW = 53.4711;
                        SDW = 11.79;
                    }
                    if (Num >= 5220 && Num < 5235)
                    {
                        MeanW = 53.6922;
                        SDW = 11.8118;
                    }
                    if (Num >= 5235 && Num < 5250)
                    {
                        MeanW = 53.9126;
                        SDW = 11.8333;
                    }
                    if (Num >= 5250 && Num < 5265)
                    {
                        MeanW = 54.1323;
                        SDW = 11.8545;
                    }
                    if (Num >= 5265 && Num < 5280)
                    {
                        MeanW = 54.3513;
                        SDW = 11.8753;
                    }
                    if (Num >= 5280 && Num < 5295)
                    {
                        MeanW = 54.5694;
                        SDW = 11.8959;
                    }
                    if (Num >= 5295 && Num < 5310)
                    {
                        MeanW = 54.7868;
                        SDW = 11.9161;
                    }
                    if (Num >= 5310 && Num < 5325)
                    {
                        MeanW = 55.0032;
                        SDW = 11.9361;
                    }
                    if (Num >= 5325 && Num < 5340)
                    {
                        MeanW = 55.2188;
                        SDW = 11.9558;
                    }
                    if (Num >= 5340 && Num < 5355)
                    {
                        MeanW = 55.4334;
                        SDW = 11.9752;
                    }
                    if (Num >= 5355 && Num < 5370)
                    {
                        MeanW = 55.647;
                        SDW = 11.9944;
                    }
                    if (Num >= 5370 && Num < 5385)
                    {
                        MeanW = 55.8596;
                        SDW = 12.0133;
                    }
                    if (Num >= 5385 && Num < 5400)
                    {
                        MeanW = 56.0712;
                        SDW = 12.032;
                    }
                    if (Num >= 5400 && Num < 5415)
                    {
                        MeanW = 56.2816;
                        SDW = 12.0505;
                    }
                    if (Num >= 5415 && Num < 5430)
                    {
                        MeanW = 56.491;
                        SDW = 12.0687;
                    }
                    if (Num >= 5430 && Num < 5445)
                    {
                        MeanW = 56.6991;
                        SDW = 12.0867;
                    }
                    if (Num >= 5445 && Num < 5460)
                    {
                        MeanW = 56.9061;
                        SDW = 12.1045;
                    }
                    if (Num >= 5460 && Num < 5475)
                    {
                        MeanW = 57.1119;
                        SDW = 12.1222;
                    }
                    if (Num >= 5475 && Num < 5490)
                    {
                        MeanW = 57.3163;
                        SDW = 12.1396;
                    }
                    if (Num >= 5490 && Num < 5505)
                    {
                        MeanW = 57.5195;
                        SDW = 12.1569;
                    }
                    if (Num >= 5505 && Num < 5520)
                    {
                        MeanW = 57.7214;
                        SDW = 12.174;
                    }
                    if (Num >= 5520 && Num < 5535)
                    {
                        MeanW = 57.9219;
                        SDW = 12.1909;
                    }
                    if (Num >= 5535 && Num < 5550)
                    {
                        MeanW = 58.121;
                        SDW = 12.2077;
                    }
                    if (Num >= 5550 && Num < 5565)
                    {
                        MeanW = 58.3187;
                        SDW = 12.2243;
                    }
                    if (Num >= 5565 && Num < 5580)
                    {
                        MeanW = 58.5149;
                        SDW = 12.2408;
                    }
                    if (Num >= 5580 && Num < 5595)
                    {
                        MeanW = 58.7097;
                        SDW = 12.2572;
                    }
                    if (Num >= 5595 && Num < 5610)
                    {
                        MeanW = 58.9029;
                        SDW = 12.2734;
                    }
                    if (Num >= 5610 && Num < 5625)
                    {
                        MeanW = 59.0946;
                        SDW = 12.2895;
                    }
                    if (Num >= 5625 && Num < 5640)
                    {
                        MeanW = 59.2848;
                        SDW = 12.3056;
                    }
                    if (Num >= 5640 && Num < 5655)
                    {
                        MeanW = 59.4734;
                        SDW = 12.3215;
                    }
                    if (Num >= 5655 && Num < 5670)
                    {
                        MeanW = 59.6603;
                        SDW = 12.3373;
                    }
                    if (Num >= 5670 && Num < 5685)
                    {
                        MeanW = 59.8456;
                        SDW = 12.353;
                    }
                    if (Num >= 5685 && Num < 5700)
                    {
                        MeanW = 60.0293;
                        SDW = 12.3686;
                    }
                    if (Num >= 5700 && Num < 5715)
                    {
                        MeanW = 60.2113;
                        SDW = 12.3842;
                    }
                    if (Num >= 5715 && Num < 5730)
                    {
                        MeanW = 60.3916;
                        SDW = 12.3997;
                    }
                    if (Num >= 5730 && Num < 5745)
                    {
                        MeanW = 60.5702;
                        SDW = 12.4151;
                    }
                    if (Num >= 5745 && Num < 5760)
                    {
                        MeanW = 60.747;
                        SDW = 12.4304;
                    }
                    if (Num >= 5760 && Num < 5775)
                    {
                        MeanW = 60.9221;
                        SDW = 12.4456;
                    }
                    if (Num >= 5775 && Num < 5790)
                    {
                        MeanW = 61.0954;
                        SDW = 12.4608;
                    }
                    if (Num >= 5790 && Num < 5805)
                    {
                        MeanW = 61.2669;
                        SDW = 12.476;
                    }
                    if (Num >= 5805 && Num < 5820)
                    {
                        MeanW = 61.4366;
                        SDW = 12.491;
                    }
                    if (Num >= 5820 && Num < 5835)
                    {
                        MeanW = 61.6045;
                        SDW = 12.506;
                    }
                    if (Num >= 5835 && Num < 5850)
                    {
                        MeanW = 61.7706;
                        SDW = 12.521;
                    }
                    if (Num >= 5850 && Num < 5865)
                    {
                        MeanW = 61.9348;
                        SDW = 12.5359;
                    }
                    if (Num >= 5865 && Num < 5880)
                    {
                        MeanW = 62.0972;
                        SDW = 12.5508;
                    }
                    if (Num >= 5880 && Num < 5895)
                    {
                        MeanW = 62.2577;
                        SDW = 12.5656;
                    }
                    if (Num >= 5895 && Num < 5910)
                    {
                        MeanW = 62.4164;
                        SDW = 12.5803;
                    }
                    if (Num >= 5910 && Num < 5925)
                    {
                        MeanW = 62.5732;
                        SDW = 12.595;
                    }
                    if (Num >= 5925 && Num < 5940)
                    {
                        MeanW = 62.7281;
                        SDW = 12.6097;
                    }
                    if (Num >= 5940 && Num < 5955)
                    {
                        MeanW = 62.8811;
                        SDW = 12.6243;
                    }
                    if (Num >= 5955 && Num < 5970)
                    {
                        MeanW = 63.0323;
                        SDW = 12.6388;
                    }
                    if (Num >= 5970 && Num < 5985)
                    {
                        MeanW = 63.1815;
                        SDW = 12.6533;
                    }
                    if (Num >= 5985 && Num < 6000)
                    {
                        MeanW = 63.3289;
                        SDW = 12.6677;
                    }
                    if (Num >= 6000 && Num < 6015)
                    {
                        MeanW = 63.4744;
                        SDW = 12.6821;
                    }
                    if (Num >= 6015 && Num < 6030)
                    {
                        MeanW = 63.618;
                        SDW = 12.6964;
                    }
                    if (Num >= 6030 && Num < 6045)
                    {
                        MeanW = 63.7597;
                        SDW = 12.7107;
                    }
                    if (Num >= 6045 && Num < 6060)
                    {
                        MeanW = 63.8996;
                        SDW = 12.7249;
                    }
                    if (Num >= 6060 && Num < 6075)
                    {
                        MeanW = 64.0376;
                        SDW = 12.739;
                    }
                    if (Num >= 6075 && Num < 6090)
                    {
                        MeanW = 64.1737;
                        SDW = 12.753;
                    }
                    if (Num >= 6090 && Num < 6105)
                    {
                        MeanW = 64.3079;
                        SDW = 12.767;
                    }
                    if (Num >= 6105 && Num < 6120)
                    {
                        MeanW = 64.4403;
                        SDW = 12.7809;
                    }
                    if (Num >= 6120 && Num < 6135)
                    {
                        MeanW = 64.5709;
                        SDW = 12.7947;
                    }
                    if (Num >= 6135 && Num < 6150)
                    {
                        MeanW = 64.6996;
                        SDW = 12.8084;
                    }
                    if (Num >= 6150 && Num < 6165)
                    {
                        MeanW = 64.8265;
                        SDW = 12.822;
                    }
                    if (Num >= 6165 && Num < 6180)
                    {
                        MeanW = 64.9516;
                        SDW = 12.8354;
                    }
                    if (Num >= 6180 && Num < 6195)
                    {
                        MeanW = 65.075;
                        SDW = 12.8488;
                    }
                    if (Num >= 6195 && Num < 6210)
                    {
                        MeanW = 65.1965;
                        SDW = 12.8621;
                    }
                    if (Num >= 6210 && Num < 6225)
                    {
                        MeanW = 65.3163;
                        SDW = 12.8752;
                    }
                    if (Num >= 6225 && Num < 6240)
                    {
                        MeanW = 65.4344;
                        SDW = 12.8882;
                    }
                    if (Num >= 6240 && Num < 6255)
                    {
                        MeanW = 65.5507;
                        SDW = 12.9011;
                    }
                    if (Num >= 6255 && Num < 6270)
                    {
                        MeanW = 65.6654;
                        SDW = 12.9138;
                    }
                    if (Num >= 6270 && Num < 6285)
                    {
                        MeanW = 65.7784;
                        SDW = 12.9263;
                    }
                    if (Num >= 6285 && Num < 6300)
                    {
                        MeanW = 65.8897;
                        SDW = 12.9387;
                    }
                    if (Num >= 6300 && Num < 6315)
                    {
                        MeanW = 65.9994;
                        SDW = 12.9509;
                    }
                    if (Num >= 6315 && Num < 6330)
                    {
                        MeanW = 66.1075;
                        SDW = 12.9629;
                    }
                    if (Num >= 6330 && Num < 6345)
                    {
                        MeanW = 66.214;
                        SDW = 12.9748;
                    }
                    if (Num >= 6345 && Num < 6360)
                    {
                        MeanW = 66.319;
                        SDW = 12.9864;
                    }
                    if (Num >= 6360 && Num < 6375)
                    {
                        MeanW = 66.4224;
                        SDW = 12.9978;
                    }
                    if (Num >= 6375 && Num < 6390)
                    {
                        MeanW = 66.5244;
                        SDW = 13.009;
                    }
                    if (Num >= 6390 && Num < 6405)
                    {
                        MeanW = 66.6249;
                        SDW = 13.02;
                    }
                    if (Num >= 6405 && Num < 6420)
                    {
                        MeanW = 66.7239;
                        SDW = 13.0308;
                    }
                    if (Num >= 6420 && Num < 6435)
                    {
                        MeanW = 66.8216;
                        SDW = 13.0413;
                    }
                    if (Num >= 6435 && Num < 6450)
                    {
                        MeanW = 66.9178;
                        SDW = 13.0515;
                    }
                    if (Num >= 6450 && Num < 6465)
                    {
                        MeanW = 67.0128;
                        SDW = 13.0615;
                    }
                    if (Num >= 6465 && Num < 6480)
                    {
                        MeanW = 67.1064;
                        SDW = 13.0712;
                    }
                    if (Num >= 6480 && Num < 6495)
                    {
                        MeanW = 67.1988;
                        SDW = 13.0806;
                    }
                    if (Num >= 6495 && Num < 6510)
                    {
                        MeanW = 67.2899;
                        SDW = 13.0898;
                    }
                    if (Num >= 6510 && Num < 6525)
                    {
                        MeanW = 67.3799;
                        SDW = 13.0986;
                    }
                    if (Num >= 6525 && Num < 6540)
                    {
                        MeanW = 67.4686;
                        SDW = 13.1072;
                    }
                    if (Num >= 6540 && Num < 6555)
                    {
                        MeanW = 67.5563;
                        SDW = 13.1155;
                    }
                    if (Num >= 6555 && Num < 6570)
                    {
                        MeanW = 67.6428;
                        SDW = 13.1234;
                    }
                    if (Num >= 6570 && Num < 6585)
                    {
                        MeanW = 67.7283;
                        SDW = 13.1311;
                    }
                    if (Num >= 6585 && Num < 6600)
                    {
                        MeanW = 67.8128;
                        SDW = 13.1384;
                    }
                    if (Num >= 6600 && Num < 6615)
                    {
                        MeanW = 67.8962;
                        SDW = 13.1455;
                    }
                    if (Num >= 6615 && Num < 6630)
                    {
                        MeanW = 67.9788;
                        SDW = 13.1522;
                    }
                    if (Num >= 6630 && Num < 6645)
                    {
                        MeanW = 68.0604;
                        SDW = 13.1586;
                    }
                    if (Num >= 6645 && Num < 6660)
                    {
                        MeanW = 68.1411;
                        SDW = 13.1647;
                    }
                    if (Num >= 6660 && Num < 6675)
                    {
                        MeanW = 68.221;
                        SDW = 13.1705;
                    }
                    if (Num >= 6675 && Num < 6690)
                    {
                        MeanW = 68.3;
                        SDW = 13.176;
                    }
                    if (Num >= 6690 && Num < 6705)
                    {
                        MeanW = 68.3783;
                        SDW = 13.1812;
                    }
                    if (Num >= 6705 && Num < 6720)
                    {
                        MeanW = 68.4558;
                        SDW = 13.1862;
                    }
                    if (Num >= 6720 && Num < 6735)
                    {
                        MeanW = 68.5326;
                        SDW = 13.1908;
                    }
                    if (Num >= 6735 && Num < 6750)
                    {
                        MeanW = 68.6087;
                        SDW = 13.1953;
                    }
                    if (Num >= 6750 && Num < 6765)
                    {
                        MeanW = 68.6841;
                        SDW = 13.1995;
                    }
                    if (Num >= 6765 && Num < 6780)
                    {
                        MeanW = 68.7589;
                        SDW = 13.2035;
                    }
                    if (Num >= 6780 && Num < 6795)
                    {
                        MeanW = 68.833;
                        SDW = 13.2073;
                    }
                    if (Num >= 6795 && Num < 6810)
                    {
                        MeanW = 68.9065;
                        SDW = 13.2109;
                    }
                    if (Num >= 6810 && Num < 6825)
                    {
                        MeanW = 68.9794;
                        SDW = 13.2144;
                    }
                    if (Num >= 6825 && Num < 6840)
                    {
                        MeanW = 69.0518;
                        SDW = 13.2179;
                    }
                    if (Num >= 6840 && Num < 6855)
                    {
                        MeanW = 69.1235;
                        SDW = 13.2212;
                    }
                    if (Num >= 6855 && Num < 6870)
                    {
                        MeanW = 69.1947;
                        SDW = 13.2246;
                    }
                    if (Num >= 6870 && Num < 6885)
                    {
                        MeanW = 69.2653;
                        SDW = 13.228;
                    }
                    if (Num >= 6885 && Num < 6900)
                    {
                        MeanW = 69.3353;
                        SDW = 13.2315;
                    }
                    if (Num >= 6900 && Num < 6915)
                    {
                        MeanW = 69.4047;
                        SDW = 13.2351;
                    }
                    if (Num >= 6915 && Num < 6930)
                    {
                        MeanW = 69.4735;
                        SDW = 13.2389;
                    }
                    if (Num >= 6930 && Num < 6945)
                    {
                        MeanW = 69.5417;
                        SDW = 13.243;
                    }
                    if (Num >= 6945 && Num < 6960)
                    {
                        MeanW = 69.6093;
                        SDW = 13.2474;
                    }
                    if (Num >= 6960 && Num < 6975)
                    {
                        MeanW = 69.6761;
                        SDW = 13.2523;
                    }
                    if (Num >= 6975 && Num < 6990)
                    {
                        MeanW = 69.7423;
                        SDW = 13.2577;
                    }
                    if (Num >= 6990 && Num < 7005)
                    {
                        MeanW = 69.8077;
                        SDW = 13.2636;
                    }
                    if (Num >= 7005 && Num < 7020)
                    {
                        MeanW = 69.8722;
                        SDW = 13.2703;
                    }
                    if (Num >= 7020 && Num < 7035)
                    {
                        MeanW = 69.9359;
                        SDW = 13.2778;
                    }
                    if (Num >= 7035 && Num < 7050)
                    {
                        MeanW = 69.9987;
                        SDW = 13.2862;
                    }
                    if (Num >= 7050 && Num < 7065)
                    {
                        MeanW = 70.0604;
                        SDW = 13.2956;
                    }
                    if (Num >= 7065 && Num < 7080)
                    {
                        MeanW = 70.121;
                        SDW = 13.3062;
                    }
                    if (Num >= 7080 && Num < 7095)
                    {
                        MeanW = 70.1805;
                        SDW = 13.3182;
                    }
                    if (Num >= 7095 && Num < 7110)
                    {
                        MeanW = 70.2386;
                        SDW = 13.3315;
                    }
                    if (Num >= 7110 && Num < 7125)
                    {
                        MeanW = 70.2953;
                        SDW = 13.3465;
                    }
                    if (Num >= 7125 && Num < 7140)
                    {
                        MeanW = 70.3504;
                        SDW = 13.3633;
                    }
                    if (Num >= 7140 && Num < 7155)
                    {
                        MeanW = 70.4039;
                        SDW = 13.3821;
                    }
                    if (Num >= 7155 && Num < 7170)
                    {
                        MeanW = 70.4555;
                        SDW = 13.403;
                    }
                    if (Num >= 7170 && Num < 7185)
                    {
                        MeanW = 70.5051;
                        SDW = 13.4263;
                    }
                    if (Num >= 7185 && Num < 7200)
                    {
                        MeanW = 70.5525;
                        SDW = 13.4521;
                    }
                    if (Num >= 7200 && Num < 7215)
                    {
                        MeanW = 70.5976;
                        SDW = 13.4807;
                    }
                    if (Num >= 7215 && Num < 7230)
                    {
                        MeanW = 70.6402;
                        SDW = 13.5124;
                    }

                    //male lenght/height / age

                    if (Num >= 0 && Num < 7)
                    {
                        MeanL = 49.88;
                        SDL = 1.89;

                    }
                    if (Num >= 7 && Num < 14)
                    {
                        MeanL = 51.11;
                        SDL = 1.90;
                    }
                    if (Num >= 14 && Num < 22)
                    {
                        MeanL = 52.34;
                        SDL = 1.91;
                    }
                    if (Num >= 22 && Num < 30)
                    {
                        MeanL = 53.39;
                        SDL = 1.92;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanL = 54.7244;
                        SDL = 1.9465;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanL = 58.4249;
                        SDL = 2.0005;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanL = 61.4292;
                        SDL = 2.0444;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanL = 63.886;
                        SDL = 2.0808;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanL = 65.9026;
                        SDL = 2.1115;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanL = 67.6236;
                        SDL = 2.1403;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanL = 69.1645;
                        SDL = 2.1711;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanL = 70.5994;
                        SDL = 2.2055;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanL = 71.9687;
                        SDL = 2.2433;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanL = 73.2812;
                        SDL = 2.2849;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanL = 74.5388;
                        SDL = 2.3293;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanL = 75.7488;
                        SDL = 2.3762;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanL = 76.9186;
                        SDL = 2.426;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanL = 78.0497;
                        SDL = 2.4773;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanL = 79.1458;
                        SDL = 2.5303;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanL = 80.2113;
                        SDL = 2.5844;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanL = 81.2487;
                        SDL = 2.6406;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanL = 82.2587;
                        SDL = 2.6973;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanL = 83.2418;
                        SDL = 2.7553;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanL = 84.1996;
                        SDL = 2.814;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanL = 85.1348;
                        SDL = 2.8742;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanL = 86.0477;
                        SDL = 2.9342;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanL = 86.941;
                        SDL = 2.9951;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanL = 87.1161;
                        SDL = 3.0551;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanL = 87.972;
                        SDL = 3.116;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanL = 88.8065;
                        SDL = 3.1757;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanL = 89.6197;
                        SDL = 3.2353;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanL = 90.412;
                        SDL = 3.2928;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanL = 91.1828;
                        SDL = 3.3501;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanL = 91.9327;
                        SDL = 3.4052;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanL = 92.6631;
                        SDL = 3.4591;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanL = 93.3753;
                        SDL = 3.5118;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanL = 94.0711;
                        SDL = 3.5625;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanL = 94.7532;
                        SDL = 3.612;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanL = 95.4236;
                        SDL = 3.6604;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanL = 96.0835;
                        SDL = 3.7069;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanL = 96.7337;
                        SDL = 3.7523;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanL = 97.3749;
                        SDL = 3.7976;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanL = 98.0073;
                        SDL = 3.8409;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanL = 98.631;
                        SDL = 3.8831;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanL = 99.2459;
                        SDL = 3.9242;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanL = 99.8515;
                        SDL = 3.9651;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanL = 100.448;
                        SDL = 4.0039;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanL = 101.037;
                        SDL = 4.0435;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanL = 101.619;
                        SDL = 4.081;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanL = 102.193;
                        SDL = 4.1194;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanL = 102.763;
                        SDL = 4.1567;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanL = 103.327;
                        SDL = 4.1941;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanL = 103.889;
                        SDL = 4.2314;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanL = 104.447;
                        SDL = 4.2677;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanL = 105.004;
                        SDL = 4.3052;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanL = 105.56;
                        SDL = 4.3417;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanL = 106.114;
                        SDL = 4.3783;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanL = 106.667;
                        SDL = 4.4149;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanL = 107.219;
                        SDL = 4.4517;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanL = 107.77;
                        SDL = 4.4886;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanL = 108.32;
                        SDL = 4.5245;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanL = 108.869;
                        SDL = 4.5616;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanL = 109.417;
                        SDL = 4.5977;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanL = 109.964;
                        SDL = 4.6339;
                    }
                    if (Num >= 1830 && Num < 1860)
                    {
                        MeanL = 110.264700;
                        SDL = 4.591400;
                    }
                    if (Num >= 1860 && Num < 1890)
                    {
                        MeanL = 110.800600;
                        SDL = 4.622600;
                    }
                    if (Num >= 1890 && Num < 1920)
                    {
                        MeanL = 111.333800;
                        SDL = 4.653800;
                    }
                    if (Num >= 1920 && Num < 1950)
                    {
                        MeanL = 111.863600;
                        SDL = 4.683700;
                    }
                    if (Num >= 1950 && Num < 1980)
                    {
                        MeanL = 112.389500;
                        SDL = 4.714700;
                    }
                    if (Num >= 1980 && Num < 2010)
                    {
                        MeanL = 112.911000;
                        SDL = 4.745600;
                    }
                    if (Num >= 2010 && Num < 2040)
                    {
                        MeanL = 113.428000;
                        SDL = 4.776500;
                    }
                    if (Num >= 2040 && Num < 2070)
                    {
                        MeanL = 113.941000;
                        SDL = 4.806000;
                    }
                    if (Num >= 2070 && Num < 2100)
                    {
                        MeanL = 114.450000;
                        SDL = 4.836700;
                    }
                    if (Num >= 2100 && Num < 2130)
                    {
                        MeanL = 114.954700;
                        SDL = 4.867200;
                    }
                    if (Num >= 2130 && Num < 2160)
                    {
                        MeanL = 115.454900;
                        SDL = 4.896400;
                    }
                    if (Num >= 2160 && Num < 2190)
                    {
                        MeanL = 115.950900;
                        SDL = 4.926800;
                    }
                    if (Num >= 2190 && Num < 2220)
                    {
                        MeanL = 116.443200;
                        SDL = 4.957000;
                    }
                    if (Num >= 2220 && Num < 2250)
                    {
                        MeanL = 116.932500;
                        SDL = 4.986000;
                    }
                    if (Num >= 2250 && Num < 2280)
                    {
                        MeanL = 117.419600;
                        SDL = 5.016200;
                    }
                    if (Num >= 2280 && Num < 2310)
                    {
                        MeanL = 117.904600;
                        SDL = 5.046300;
                    }
                    if (Num >= 2310 && Num < 2340)
                    {
                        MeanL = 118.388000;
                        SDL = 5.075300;
                    }
                    if (Num >= 2340 && Num < 2370)
                    {
                        MeanL = 118.870000;
                        SDL = 5.105500;
                    }
                    if (Num >= 2370 && Num < 2400)
                    {
                        MeanL = 119.350800;
                        SDL = 5.135700;
                    }
                    if (Num >= 2400 && Num < 2430)
                    {
                        MeanL = 119.830300;
                        SDL = 5.165900;
                    }
                    if (Num >= 2430 && Num < 2460)
                    {
                        MeanL = 120.308500;
                        SDL = 5.194900;
                    }
                    if (Num >= 2460 && Num < 2490)
                    {
                        MeanL = 120.785300;
                        SDL = 5.225200;
                    }
                    if (Num >= 2490 && Num < 2520)
                    {
                        MeanL = 121.260400;
                        SDL = 5.255400;
                    }
                    if (Num >= 2520 && Num < 2550)
                    {
                        MeanL = 121.733800;
                        SDL = 5.285700;
                    }
                    if (Num >= 2550 && Num < 2580)
                    {
                        MeanL = 122.205300;
                        SDL = 5.315900;
                    }
                    if (Num >= 2580 && Num < 2610)
                    {
                        MeanL = 122.675000;
                        SDL = 5.346200;
                    }
                    if (Num >= 2610 && Num < 2640)
                    {
                        MeanL = 123.142900;
                        SDL = 5.376400;
                    }
                    if (Num >= 2640 && Num < 2670)
                    {
                        MeanL = 123.609200;
                        SDL = 5.406700;
                    }
                    if (Num >= 2670 && Num < 2700)
                    {
                        MeanL = 124.073600;
                        SDL = 5.436900;
                    }
                    if (Num >= 2700 && Num < 2730)
                    {
                        MeanL = 124.536100;
                        SDL = 5.467100;
                    }
                    if (Num >= 2730 && Num < 2760)
                    {
                        MeanL = 124.996400;
                        SDL = 5.497300;
                    }
                    if (Num >= 2760 && Num < 2790)
                    {
                        MeanL = 125.454500;
                        SDL = 5.527500;
                    }
                    if (Num >= 2790 && Num < 2820)
                    {
                        MeanL = 125.910400;
                        SDL = 5.557700;
                    }
                    if (Num >= 2820 && Num < 2850)
                    {
                        MeanL = 126.364000;
                        SDL = 5.587800;
                    }
                    if (Num >= 2850 && Num < 2880)
                    {
                        MeanL = 126.815600;
                        SDL = 5.617900;
                    }
                    if (Num >= 2880 && Num < 2910)
                    {
                        MeanL = 127.265100;
                        SDL = 5.648000;
                    }
                    if (Num >= 2910 && Num < 2940)
                    {
                        MeanL = 127.712900;
                        SDL = 5.678100;
                    }
                    if (Num >= 2940 && Num < 2970)
                    {
                        MeanL = 128.159000;
                        SDL = 5.708200;
                    }
                    if (Num >= 2970 && Num < 3000)
                    {
                        MeanL = 128.603400;
                        SDL = 5.738300;
                    }
                    if (Num >= 3000 && Num < 3030)
                    {
                        MeanL = 129.046600;
                        SDL = 5.768400;
                    }
                    if (Num >= 3030 && Num < 3060)
                    {
                        MeanL = 129.488700;
                        SDL = 5.798500;
                    }
                    if (Num >= 3060 && Num < 3090)
                    {
                        MeanL = 129.930000;
                        SDL = 5.830000;
                    }
                    if (Num >= 3090 && Num < 3120)
                    {
                        MeanL = 130.370500;
                        SDL = 5.860200;
                    }
                    if (Num >= 3120 && Num < 3150)
                    {
                        MeanL = 130.810300;
                        SDL = 5.890400;
                    }
                    if (Num >= 3150 && Num < 3180)
                    {
                        MeanL = 131.249500;
                        SDL = 5.920700;
                    }
                    if (Num >= 3180 && Num < 3210)
                    {
                        MeanL = 131.688400;
                        SDL = 5.951000;
                    }
                    if (Num >= 3210 && Num < 3240)
                    {
                        MeanL = 132.126900;
                        SDL = 5.981400;
                    }
                    if (Num >= 3240 && Num < 3270)
                    {
                        MeanL = 132.565200;
                        SDL = 6.011800;
                    }
                    if (Num >= 3270 && Num < 3300)
                    {
                        MeanL = 133.003100;
                        SDL = 6.042300;
                    }
                    if (Num >= 3300 && Num < 3330)
                    {
                        MeanL = 133.440400;
                        SDL = 6.072900;
                    }
                    if (Num >= 3330 && Num < 3360)
                    {
                        MeanL = 133.877000;
                        SDL = 6.103500;
                    }
                    if (Num >= 3360 && Num < 3390)
                    {
                        MeanL = 134.313000;
                        SDL = 6.132700;
                    }
                    if (Num >= 3390 && Num < 3420)
                    {
                        MeanL = 134.748300;
                        SDL = 6.163400;
                    }
                    if (Num >= 3420 && Num < 3450)
                    {
                        MeanL = 135.182900;
                        SDL = 6.194100;
                    }
                    if (Num >= 3450 && Num < 3480)
                    {
                        MeanL = 135.616800;
                        SDL = 6.223500;
                    }
                    if (Num >= 3480 && Num < 3510)
                    {
                        MeanL = 136.050100;
                        SDL = 6.254200;
                    }
                    if (Num >= 3510 && Num < 3540)
                    {
                        MeanL = 136.482900;
                        SDL = 6.283700;
                    }
                    if (Num >= 3540 && Num < 3570)
                    {
                        MeanL = 136.915300;
                        SDL = 6.314500;
                    }
                    if (Num >= 3570 && Num < 3600)
                    {
                        MeanL = 137.347400;
                        SDL = 6.344100;
                    }
                    if (Num >= 3600 && Num < 3630)
                    {
                        MeanL = 137.779500;
                        SDL = 6.373700;
                    }
                    if (Num >= 3630 && Num < 3660)
                    {
                        MeanL = 138.211900;
                        SDL = 6.403400;
                    }
                    if (Num >= 3660 && Num < 3690)
                    {
                        MeanL = 138.645200;
                        SDL = 6.433100;
                    }
                    if (Num >= 3690 && Num < 3720)
                    {
                        MeanL = 139.079700;
                        SDL = 6.463000;
                    }
                    if (Num >= 3720 && Num < 3750)
                    {
                        MeanL = 139.515800;
                        SDL = 6.493100;
                    }
                    if (Num >= 3750 && Num < 3780)
                    {
                        MeanL = 139.954000;
                        SDL = 6.523300;
                    }
                    if (Num >= 3780 && Num < 3810)
                    {
                        MeanL = 140.394800;
                        SDL = 6.552200;
                    }
                    if (Num >= 3810 && Num < 3840)
                    {
                        MeanL = 140.838700;
                        SDL = 6.582800;
                    }
                    if (Num >= 3840 && Num < 3870)
                    {
                        MeanL = 141.285900;
                        SDL = 6.612200;
                    }
                    if (Num >= 3870 && Num < 3900)
                    {
                        MeanL = 141.736800;
                        SDL = 6.641800;
                    }
                    if (Num >= 3900 && Num < 3930)
                    {
                        MeanL = 142.191600;
                        SDL = 6.671600;
                    }
                    if (Num >= 3930 && Num < 3960)
                    {
                        MeanL = 142.650100;
                        SDL = 6.701700;
                    }
                    if (Num >= 3960 && Num < 3990)
                    {
                        MeanL = 143.112600;
                        SDL = 6.730600;
                    }
                    if (Num >= 3990 && Num < 4020)
                    {
                        MeanL = 143.579500;
                        SDL = 6.761200;
                    }
                    if (Num >= 4020 && Num < 4050)
                    {
                        MeanL = 144.051100;
                        SDL = 6.790600;
                    }
                    if (Num >= 4050 && Num < 4080)
                    {
                        MeanL = 144.527600;
                        SDL = 6.820300;
                    }
                    if (Num >= 4080 && Num < 4110)
                    {
                        MeanL = 145.009300;
                        SDL = 6.848800;
                    }
                    if (Num >= 4110 && Num < 4140)
                    {
                        MeanL = 145.496400;
                        SDL = 6.879100;
                    }
                    if (Num >= 4140 && Num < 4170)
                    {
                        MeanL = 145.989100;
                        SDL = 6.908200;
                    }
                    if (Num >= 4170 && Num < 4200)
                    {
                        MeanL = 146.487800;
                        SDL = 6.937700;
                    }
                    if (Num >= 4200 && Num < 4230)
                    {
                        MeanL = 146.992700;
                        SDL = 6.967500;
                    }
                    if (Num >= 4230 && Num < 4260)
                    {
                        MeanL = 147.504100;
                        SDL = 6.997600;
                    }
                    if (Num >= 4260 && Num < 4290)
                    {
                        MeanL = 148.022400;
                        SDL = 7.026600;
                    }
                    if (Num >= 4290 && Num < 4320)
                    {
                        MeanL = 148.547800;
                        SDL = 7.056000;
                    }
                    if (Num >= 4320 && Num < 4350)
                    {
                        MeanL = 149.080700;
                        SDL = 7.085800;
                    }
                    if (Num >= 4350 && Num < 4380)
                    {
                        MeanL = 149.621200;
                        SDL = 7.114500;
                    }
                    if (Num >= 4380 && Num < 4410)
                    {
                        MeanL = 150.169400;
                        SDL = 7.145100;
                    }
                    if (Num >= 4410 && Num < 4440)
                    {
                        MeanL = 150.725600;
                        SDL = 7.173000;
                    }
                    if (Num >= 4440 && Num < 4470)
                    {
                        MeanL = 151.289900;
                        SDL = 7.202900;
                    }
                    if (Num >= 4470 && Num < 4500)
                    {
                        MeanL = 151.862300;
                        SDL = 7.231700;
                    }
                    if (Num >= 4500 && Num < 4530)
                    {
                        MeanL = 152.442500;
                        SDL = 7.260800;
                    }
                    if (Num >= 4530 && Num < 4560)
                    {
                        MeanL = 153.029800;
                        SDL = 7.288800;
                    }
                    if (Num >= 4560 && Num < 4590)
                    {
                        MeanL = 153.623400;
                        SDL = 7.318600;
                    }
                    if (Num >= 4590 && Num < 4620)
                    {
                        MeanL = 154.222300;
                        SDL = 7.345600;
                    }
                    if (Num >= 4620 && Num < 4650)
                    {
                        MeanL = 154.825800;
                        SDL = 7.374400;
                    }
                    if (Num >= 4650 && Num < 4680)
                    {
                        MeanL = 155.432900;
                        SDL = 7.401700;
                    }
                    if (Num >= 4680 && Num < 4710)
                    {
                        MeanL = 156.042600;
                        SDL = 7.427600;
                    }
                    if (Num >= 4710 && Num < 4740)
                    {
                        MeanL = 156.653900;
                        SDL = 7.453600;
                    }
                    if (Num >= 4740 && Num < 4770)
                    {
                        MeanL = 157.266000;
                        SDL = 7.479600;
                    }
                    if (Num >= 4770 && Num < 4800)
                    {
                        MeanL = 157.877500;
                        SDL = 7.505500;
                    }
                    if (Num >= 4800 && Num < 4830)
                    {
                        MeanL = 158.487100;
                        SDL = 7.529700;
                    }
                    if (Num >= 4830 && Num < 4860)
                    {
                        MeanL = 159.093700;
                        SDL = 7.552200;
                    }
                    if (Num >= 4860 && Num < 4890)
                    {
                        MeanL = 159.696200;
                        SDL = 7.576000;
                    }
                    if (Num >= 4890 && Num < 4920)
                    {
                        MeanL = 160.293900;
                        SDL = 7.597900;
                    }
                    if (Num >= 4920 && Num < 4950)
                    {
                        MeanL = 160.886100;
                        SDL = 7.618000;
                    }
                    if (Num >= 4950 && Num < 4980)
                    {
                        MeanL = 161.472000;
                        SDL = 7.637600;
                    }
                    if (Num >= 4980 && Num < 5010)
                    {
                        MeanL = 162.050500;
                        SDL = 7.656900;
                    }
                    if (Num >= 5010 && Num < 5040)
                    {
                        MeanL = 162.620700;
                        SDL = 7.675700;
                    }
                    if (Num >= 5040 && Num < 5070)
                    {
                        MeanL = 163.181600;
                        SDL = 7.692400;
                    }
                    if (Num >= 5070 && Num < 5100)
                    {
                        MeanL = 163.732100;
                        SDL = 7.706900;
                    }
                    if (Num >= 5100 && Num < 5130)
                    {
                        MeanL = 164.271700;
                        SDL = 7.722400;
                    }
                    if (Num >= 5130 && Num < 5160)
                    {
                        MeanL = 164.799400;
                        SDL = 7.735700;
                    }
                    if (Num >= 5160 && Num < 5190)
                    {
                        MeanL = 165.314500;
                        SDL = 7.748300;
                    }
                    if (Num >= 5190 && Num < 5220)
                    {
                        MeanL = 165.816500;
                        SDL = 7.758600;
                    }
                    if (Num >= 5220 && Num < 5250)
                    {
                        MeanL = 166.305000;
                        SDL = 7.768100;
                    }
                    if (Num >= 5250 && Num < 5280)
                    {
                        MeanL = 166.779900;
                        SDL = 7.776900;
                    }
                    if (Num >= 5280 && Num < 5310)
                    {
                        MeanL = 167.241500;
                        SDL = 7.785100;
                    }
                    if (Num >= 5310 && Num < 5340)
                    {
                        MeanL = 167.689900;
                        SDL = 7.790900;
                    }
                    if (Num >= 5340 && Num < 5370)
                    {
                        MeanL = 168.125500;
                        SDL = 7.796000;
                    }
                    if (Num >= 5370 && Num < 5400)
                    {
                        MeanL = 168.548200;
                        SDL = 7.800400;
                    }
                    if (Num >= 5400 && Num < 5430)
                    {
                        MeanL = 168.958000;
                        SDL = 7.804200;
                    }
                    if (Num >= 5430 && Num < 5460)
                    {
                        MeanL = 169.354900;
                        SDL = 7.805600;
                    }
                    if (Num >= 5460 && Num < 5490)
                    {
                        MeanL = 169.738900;
                        SDL = 7.806300;
                    }
                    if (Num >= 5490 && Num < 5520)
                    {
                        MeanL = 170.109900;
                        SDL = 7.806300;
                    }
                    if (Num >= 5520 && Num < 5550)
                    {
                        MeanL = 170.468000;
                        SDL = 7.805700;
                    }
                    if (Num >= 5550 && Num < 5580)
                    {
                        MeanL = 170.813600;
                        SDL = 7.804500;
                    }
                    if (Num >= 5580 && Num < 5610)
                    {
                        MeanL = 171.146800;
                        SDL = 7.802600;
                    }
                    if (Num >= 5610 && Num < 5640)
                    {
                        MeanL = 171.468000;
                        SDL = 7.798400;
                    }
                    if (Num >= 5640 && Num < 5670)
                    {
                        MeanL = 171.777300;
                        SDL = 7.795300;
                    }
                    if (Num >= 5670 && Num < 5700)
                    {
                        MeanL = 172.074800;
                        SDL = 7.789800;
                    }
                    if (Num >= 5700 && Num < 5730)
                    {
                        MeanL = 172.360600;
                        SDL = 7.783800;
                    }
                    if (Num >= 5730 && Num < 5760)
                    {
                        MeanL = 172.634500;
                        SDL = 7.778900;
                    }
                    if (Num >= 5760 && Num < 5790)
                    {
                        MeanL = 172.896700;
                        SDL = 7.771700;
                    }
                    if (Num >= 5790 && Num < 5820)
                    {
                        MeanL = 173.147000;
                        SDL = 7.763900;
                    }
                    if (Num >= 5820 && Num < 5850)
                    {
                        MeanL = 173.385600;
                        SDL = 7.755500;
                    }
                    if (Num >= 5850 && Num < 5880)
                    {
                        MeanL = 173.612600;
                        SDL = 7.746600;
                    }
                    if (Num >= 5880 && Num < 5910)
                    {
                        MeanL = 173.828000;
                        SDL = 7.737100;
                    }
                    if (Num >= 5910 && Num < 5940)
                    {
                        MeanL = 174.032100;
                        SDL = 7.727000;
                    }
                    if (Num >= 5940 && Num < 5970)
                    {
                        MeanL = 174.225100;
                        SDL = 7.716400;
                    }
                    if (Num >= 5970 && Num < 6000)
                    {
                        MeanL = 174.407100;
                        SDL = 7.705300;
                    }
                    if (Num >= 6000 && Num < 6030)
                    {
                        MeanL = 174.578400;
                        SDL = 7.693700;
                    }
                    if (Num >= 6030 && Num < 6060)
                    {
                        MeanL = 174.739200;
                        SDL = 7.681500;
                    }
                    if (Num >= 6060 && Num < 6090)
                    {
                        MeanL = 174.889600;
                        SDL = 7.668900;
                    }
                    if (Num >= 6090 && Num < 6120)
                    {
                        MeanL = 175.030100;
                        SDL = 7.657600;
                    }
                    if (Num >= 6120 && Num < 6150)
                    {
                        MeanL = 175.160900;
                        SDL = 7.644000;
                    }
                    if (Num >= 6150 && Num < 6180)
                    {
                        MeanL = 175.282400;
                        SDL = 7.630000;
                    }
                    if (Num >= 6180 && Num < 6210)
                    {
                        MeanL = 175.395100;
                        SDL = 7.617400;
                    }
                    if (Num >= 6210 && Num < 6240)
                    {
                        MeanL = 175.499500;
                        SDL = 7.602600;
                    }
                    if (Num >= 6240 && Num < 6270)
                    {
                        MeanL = 175.595900;
                        SDL = 7.589300;
                    }
                    if (Num >= 6270 && Num < 6300)
                    {
                        MeanL = 175.685000;
                        SDL = 7.573800;
                    }
                    if (Num >= 6300 && Num < 6330)
                    {
                        MeanL = 175.767200;
                        SDL = 7.559700;
                    }
                    if (Num >= 6330 && Num < 6360)
                    {
                        MeanL = 175.843200;
                        SDL = 7.545400;
                    }
                    if (Num >= 6360 && Num < 6390)
                    {
                        MeanL = 175.913300;
                        SDL = 7.530800;
                    }
                    if (Num >= 6390 && Num < 6420)
                    {
                        MeanL = 175.978100;
                        SDL = 7.516000;
                    }
                    if (Num >= 6420 && Num < 6450)
                    {
                        MeanL = 176.038000;
                        SDL = 7.501000;
                    }
                    if (Num >= 6450 && Num < 6480)
                    {
                        MeanL = 176.093500;
                        SDL = 7.485700;
                    }
                    if (Num >= 6480 && Num < 6510)
                    {
                        MeanL = 176.144900;
                        SDL = 7.470300;
                    }
                    if (Num >= 6510 && Num < 6540)
                    {
                        MeanL = 176.192500;
                        SDL = 7.456500;
                    }
                    if (Num >= 6540 && Num < 6570)
                    {
                        MeanL = 176.236800;
                        SDL = 7.440700;
                    }
                    if (Num >= 6570 && Num < 6600)
                    {
                        MeanL = 176.277900;
                        SDL = 7.426600;
                    }
                    if (Num >= 6600 && Num < 6630)
                    {
                        MeanL = 176.316200;
                        SDL = 7.412300;
                    }
                    if (Num >= 6630 && Num < 6660)
                    {
                        MeanL = 176.351800;
                        SDL = 7.398000;
                    }
                    if (Num >= 6660 && Num < 6690)
                    {
                        MeanL = 176.385100;
                        SDL = 7.381700;
                    }
                    if (Num >= 6690 && Num < 6720)
                    {
                        MeanL = 176.416200;
                        SDL = 7.368900;
                    }
                    if (Num >= 6720 && Num < 6750)
                    {
                        MeanL = 176.445300;
                        SDL = 7.354200;
                    }
                    if (Num >= 6750 && Num < 6780)
                    {
                        MeanL = 176.472400;
                        SDL = 7.339500;
                    }
                    if (Num >= 6780 && Num < 6810)
                    {
                        MeanL = 176.497600;
                        SDL = 7.324700;
                    }
                    if (Num >= 6810 && Num < 6840)
                    {
                        MeanL = 176.521100;
                        SDL = 7.311500;
                    }
                    if (Num >= 6840 && Num < 6870)
                    {
                        MeanL = 176.543200;
                        SDL = 7.298300;
                    }

                    // male BMI/age
                    if (Num >= 0 && Num < 7)
                    {
                        MeanBMI = 13.40;
                        SDBMI = 1.4;

                    }
                    if (Num >= 7 && Num < 14)
                    {
                        MeanBMI = 13.34;
                        SDBMI = 1.4;
                    }
                    if (Num >= 14 && Num < 22)
                    {
                        MeanBMI = 13.63;
                        SDBMI = 1.4;
                    }
                    if (Num >= 22 && Num < 30)
                    {
                        MeanBMI = 14.22;
                        SDBMI = 1.4;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanBMI = 14.9441;
                        SDBMI = 1.3559;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanBMI = 16.3195;
                        SDBMI = 1.4805;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanBMI = 16.8987;
                        SDBMI = 1.5013;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanBMI = 17.1579;
                        SDBMI = 1.5421;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanBMI = 17.2919;
                        SDBMI = 1.5081;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanBMI = 17.3422;
                        SDBMI = 1.4578;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanBMI = 17.3288;
                        SDBMI = 1.4712;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanBMI = 17.2647;
                        SDBMI = 1.4353;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanBMI = 17.1662;
                        SDBMI = 1.4338;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanBMI = 17.0488;
                        SDBMI = 1.4512;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanBMI = 16.9239;
                        SDBMI = 1.4761;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanBMI = 16.7981;
                        SDBMI = 1.4019;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanBMI = 16.6743;
                        SDBMI = 1.4257;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanBMI = 16.5548;
                        SDBMI = 1.4452;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanBMI = 16.4409;
                        SDBMI = 1.3591;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanBMI = 16.3335;
                        SDBMI = 1.3665;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanBMI = 16.2329;
                        SDBMI = 1.3671;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanBMI = 16.1392;
                        SDBMI = 1.3608;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanBMI = 16.0528;
                        SDBMI = 1.3472;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanBMI = 15.9743;
                        SDBMI = 1.3257;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanBMI = 15.9039;
                        SDBMI = 1.2961;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanBMI = 15.8412;
                        SDBMI = 1.3588;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanBMI = 15.7852;
                        SDBMI = 1.3148;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanBMI = 16.0189;
                        SDBMI = 1.2811;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanBMI = 15.98;
                        SDBMI = 1.32;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanBMI = 15.9414;
                        SDBMI = 1.3586;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanBMI = 15.9036;
                        SDBMI = 1.2964;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanBMI = 15.8667;
                        SDBMI = 1.3333;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanBMI = 15.8306;
                        SDBMI = 1.2694;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanBMI = 15.7953;
                        SDBMI = 1.3047;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanBMI = 15.7606;
                        SDBMI = 1.3394;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanBMI = 15.7267;
                        SDBMI = 1.2733;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanBMI = 15.6934;
                        SDBMI = 1.3066;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanBMI = 15.661;
                        SDBMI = 1.339;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanBMI = 15.6294;
                        SDBMI = 1.2706;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanBMI = 15.5988;
                        SDBMI = 1.3012;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanBMI = 15.5693;
                        SDBMI = 1.3307;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanBMI = 15.541;
                        SDBMI = 1.259;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanBMI = 15.514;
                        SDBMI = 1.286;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanBMI = 15.4885;
                        SDBMI = 1.3115;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanBMI = 15.4645;
                        SDBMI = 1.3355;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanBMI = 15.442;
                        SDBMI = 1.358;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanBMI = 15.421;
                        SDBMI = 1.279;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanBMI = 15.4013;
                        SDBMI = 1.2987;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanBMI = 15.3827;
                        SDBMI = 1.3173;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanBMI = 15.3652;
                        SDBMI = 1.3348;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanBMI = 15.3485;
                        SDBMI = 1.3515;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanBMI = 15.3326;
                        SDBMI = 1.3674;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanBMI = 15.3174;
                        SDBMI = 1.3826;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanBMI = 15.3029;
                        SDBMI = 1.3971;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanBMI = 15.2891;
                        SDBMI = 1.3109;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanBMI = 15.2759;
                        SDBMI = 1.3241;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanBMI = 15.2633;
                        SDBMI = 1.3367;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanBMI = 15.2514;
                        SDBMI = 1.3486;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanBMI = 15.24;
                        SDBMI = 1.36;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanBMI = 15.2291;
                        SDBMI = 1.3709;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanBMI = 15.2188;
                        SDBMI = 1.3812;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanBMI = 15.2091;
                        SDBMI = 1.3909;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanBMI = 15.2;
                        SDBMI = 1.4;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanBMI = 15.1916;
                        SDBMI = 1.4084;
                    }
                    if (Num >= 1830 && Num < 1860)
                    {
                        MeanBMI = 15.264100;
                        SDBMI = 1.380900;
                    }
                    if (Num >= 1860 && Num < 1890)
                    {
                        MeanBMI = 15.261600;
                        SDBMI = 1.386400;
                    }
                    if (Num >= 1890 && Num < 1920)
                    {
                        MeanBMI = 15.260400;
                        SDBMI = 1.392600;
                    }
                    if (Num >= 1920 && Num < 1950)
                    {
                        MeanBMI = 15.260500;
                        SDBMI = 1.398500;
                    }
                    if (Num >= 1950 && Num < 1980)
                    {
                        MeanBMI = 15.261900;
                        SDBMI = 1.405100;
                    }
                    if (Num >= 1980 && Num < 2010)
                    {
                        MeanBMI = 15.264500;
                        SDBMI = 1.411500;
                    }
                    if (Num >= 2010 && Num < 2040)
                    {
                        MeanBMI = 15.268400;
                        SDBMI = 1.417600;
                    }
                    if (Num >= 2040 && Num < 2070)
                    {
                        MeanBMI = 15.273700;
                        SDBMI = 1.425300;
                    }
                    if (Num >= 2070 && Num < 2100)
                    {
                        MeanBMI = 15.280100;
                        SDBMI = 1.431900;
                    }
                    if (Num >= 2100 && Num < 2130)
                    {
                        MeanBMI = 15.287700;
                        SDBMI = 1.439300;
                    }
                    if (Num >= 2130 && Num < 2160)
                    {
                        MeanBMI = 15.296500;
                        SDBMI = 1.446500;
                    }
                    if (Num >= 2160 && Num < 2190)
                    {
                        MeanBMI = 15.306200;
                        SDBMI = 1.454800;
                    }
                    if (Num >= 2190 && Num < 2220)
                    {
                        MeanBMI = 15.316900;
                        SDBMI = 1.463100;
                    }
                    if (Num >= 2220 && Num < 2250)
                    {
                        MeanBMI = 15.328500;
                        SDBMI = 1.470500;
                    }
                    if (Num >= 2250 && Num < 2280)
                    {
                        MeanBMI = 15.340800;
                        SDBMI = 1.479200;
                    }
                    if (Num >= 2280 && Num < 2310)
                    {
                        MeanBMI = 15.354000;
                        SDBMI = 1.488000;
                    }
                    if (Num >= 2310 && Num < 2340)
                    {
                        MeanBMI = 15.367900;
                        SDBMI = 1.496100;
                    }
                    if (Num >= 2340 && Num < 2370)
                    {
                        MeanBMI = 15.382500;
                        SDBMI = 1.505500;
                    }
                    if (Num >= 2370 && Num < 2400)
                    {
                        MeanBMI = 15.397800;
                        SDBMI = 1.515200;
                    }
                    if (Num >= 2400 && Num < 2430)
                    {
                        MeanBMI = 15.413700;
                        SDBMI = 1.524300;
                    }
                    if (Num >= 2430 && Num < 2460)
                    {
                        MeanBMI = 15.430200;
                        SDBMI = 1.533800;
                    }
                    if (Num >= 2460 && Num < 2490)
                    {
                        MeanBMI = 15.447300;
                        SDBMI = 1.543700;
                    }
                    if (Num >= 2490 && Num < 2520)
                    {
                        MeanBMI = 15.465000;
                        SDBMI = 1.554000;
                    }
                    if (Num >= 2520 && Num < 2550)
                    {
                        MeanBMI = 15.483200;
                        SDBMI = 1.563800;
                    }
                    if (Num >= 2550 && Num < 2580)
                    {
                        MeanBMI = 15.501900;
                        SDBMI = 1.574100;
                    }
                    if (Num >= 2580 && Num < 2610)
                    {
                        MeanBMI = 15.521000;
                        SDBMI = 1.585000;
                    }
                    if (Num >= 2610 && Num < 2640)
                    {
                        MeanBMI = 15.540700;
                        SDBMI = 1.595300;
                    }
                    if (Num >= 2640 && Num < 2670)
                    {
                        MeanBMI = 15.560800;
                        SDBMI = 1.606200;
                    }
                    if (Num >= 2670 && Num < 2700)
                    {
                        MeanBMI = 15.581400;
                        SDBMI = 1.617600;
                    }
                    if (Num >= 2700 && Num < 2730)
                    {
                        MeanBMI = 15.602300;
                        SDBMI = 1.628700;
                    }
                    if (Num >= 2730 && Num < 2760)
                    {
                        MeanBMI = 15.623700;
                        SDBMI = 1.640300;
                    }
                    if (Num >= 2760 && Num < 2790)
                    {
                        MeanBMI = 15.645500;
                        SDBMI = 1.651500;
                    }
                    if (Num >= 2790 && Num < 2820)
                    {
                        MeanBMI = 15.667700;
                        SDBMI = 1.663300;
                    }
                    if (Num >= 2820 && Num < 2850)
                    {
                        MeanBMI = 15.690300;
                        SDBMI = 1.675700;
                    }
                    if (Num >= 2850 && Num < 2880)
                    {
                        MeanBMI = 15.713300;
                        SDBMI = 1.687700;
                    }
                    if (Num >= 2880 && Num < 2910)
                    {
                        MeanBMI = 15.736800;
                        SDBMI = 1.700200;
                    }
                    if (Num >= 2910 && Num < 2940)
                    {
                        MeanBMI = 15.760600;
                        SDBMI = 1.712400;
                    }
                    if (Num >= 2940 && Num < 2970)
                    {
                        MeanBMI = 15.784800;
                        SDBMI = 1.725200;
                    }
                    if (Num >= 2970 && Num < 3000)
                    {
                        MeanBMI = 15.809400;
                        SDBMI = 1.738600;
                    }
                    if (Num >= 3000 && Num < 3030)
                    {
                        MeanBMI = 15.834400;
                        SDBMI = 1.751600;
                    }
                    if (Num >= 3030 && Num < 3060)
                    {
                        MeanBMI = 15.859700;
                        SDBMI = 1.764300;
                    }
                    if (Num >= 3060 && Num < 3090)
                    {
                        MeanBMI = 15.885500;
                        SDBMI = 1.777500;
                    }
                    if (Num >= 3090 && Num < 3120)
                    {
                        MeanBMI = 15.911600;
                        SDBMI = 1.790400;
                    }
                    if (Num >= 3120 && Num < 3150)
                    {
                        MeanBMI = 15.938100;
                        SDBMI = 1.803900;
                    }
                    if (Num >= 3150 && Num < 3180)
                    {
                        MeanBMI = 15.965100;
                        SDBMI = 1.817900;
                    }
                    if (Num >= 3180 && Num < 3210)
                    {
                        MeanBMI = 15.992500;
                        SDBMI = 1.831500;
                    }
                    if (Num >= 3210 && Num < 3240)
                    {
                        MeanBMI = 16.020500;
                        SDBMI = 1.845500;
                    }
                    if (Num >= 3240 && Num < 3270)
                    {
                        MeanBMI = 16.049000;
                        SDBMI = 1.859000;
                    }
                    if (Num >= 3270 && Num < 3300)
                    {
                        MeanBMI = 16.078100;
                        SDBMI = 1.873900;
                    }
                    if (Num >= 3300 && Num < 3330)
                    {
                        MeanBMI = 16.107800;
                        SDBMI = 1.888200;
                    }
                    if (Num >= 3330 && Num < 3360)
                    {
                        MeanBMI = 16.138100;
                        SDBMI = 1.901900;
                    }
                    if (Num >= 3360 && Num < 3390)
                    {
                        MeanBMI = 16.169200;
                        SDBMI = 1.916800;
                    }
                    if (Num >= 3390 && Num < 3420)
                    {
                        MeanBMI = 16.200900;
                        SDBMI = 1.931100;
                    }
                    if (Num >= 3420 && Num < 3450)
                    {
                        MeanBMI = 16.233300;
                        SDBMI = 1.945700;
                    }
                    if (Num >= 3450 && Num < 3480)
                    {
                        MeanBMI = 16.266500;
                        SDBMI = 1.960500;
                    }
                    if (Num >= 3480 && Num < 3510)
                    {
                        MeanBMI = 16.300400;
                        SDBMI = 1.975600;
                    }
                    if (Num >= 3510 && Num < 3540)
                    {
                        MeanBMI = 16.335100;
                        SDBMI = 1.990900;
                    }
                    if (Num >= 3540 && Num < 3570)
                    {
                        MeanBMI = 16.370400;
                        SDBMI = 2.005600;
                    }
                    if (Num >= 3570 && Num < 3600)
                    {
                        MeanBMI = 16.406500;
                        SDBMI = 2.021500;
                    }
                    if (Num >= 3600 && Num < 3630)
                    {
                        MeanBMI = 16.443300;
                        SDBMI = 2.036700;
                    }
                    if (Num >= 3630 && Num < 3660)
                    {
                        MeanBMI = 16.480700;
                        SDBMI = 2.051300;
                    }
                    if (Num >= 3660 && Num < 3690)
                    {
                        MeanBMI = 16.518900;
                        SDBMI = 2.067100;
                    }
                    if (Num >= 3690 && Num < 3720)
                    {
                        MeanBMI = 16.557800;
                        SDBMI = 2.082200;
                    }
                    if (Num >= 3720 && Num < 3750)
                    {
                        MeanBMI = 16.597400;
                        SDBMI = 2.098600;
                    }
                    if (Num >= 3750 && Num < 3780)
                    {
                        MeanBMI = 16.637600;
                        SDBMI = 2.113400;
                    }
                    if (Num >= 3780 && Num < 3810)
                    {
                        MeanBMI = 16.678600;
                        SDBMI = 2.129400;
                    }
                    if (Num >= 3810 && Num < 3840)
                    {
                        MeanBMI = 16.720300;
                        SDBMI = 2.144700;
                    }
                    if (Num >= 3840 && Num < 3870)
                    {
                        MeanBMI = 16.762800;
                        SDBMI = 2.160200;
                    }
                    if (Num >= 3870 && Num < 3900)
                    {
                        MeanBMI = 16.805900;
                        SDBMI = 2.176100;
                    }
                    if (Num >= 3900 && Num < 3930)
                    {
                        MeanBMI = 16.849700;
                        SDBMI = 2.192300;
                    }
                    if (Num >= 3930 && Num < 3960)
                    {
                        MeanBMI = 16.894100;
                        SDBMI = 2.207900;
                    }
                    if (Num >= 3960 && Num < 3990)
                    {
                        MeanBMI = 16.939200;
                        SDBMI = 2.223800;
                    }
                    if (Num >= 3990 && Num < 4020)
                    {
                        MeanBMI = 16.985000;
                        SDBMI = 2.239000;
                    }
                    if (Num >= 4020 && Num < 4050)
                    {
                        MeanBMI = 17.031400;
                        SDBMI = 2.255600;
                    }
                    if (Num >= 4050 && Num < 4080)
                    {
                        MeanBMI = 17.078400;
                        SDBMI = 2.270600;
                    }
                    if (Num >= 4080 && Num < 4110)
                    {
                        MeanBMI = 17.126200;
                        SDBMI = 2.286800;
                    }
                    if (Num >= 4110 && Num < 4140)
                    {
                        MeanBMI = 17.174600;
                        SDBMI = 2.302400;
                    }
                    if (Num >= 4140 && Num < 4170)
                    {
                        MeanBMI = 17.223600;
                        SDBMI = 2.318400;
                    }
                    if (Num >= 4170 && Num < 4200)
                    {
                        MeanBMI = 17.273400;
                        SDBMI = 2.333600;
                    }
                    if (Num >= 4200 && Num < 4230)
                    {
                        MeanBMI = 17.324000;
                        SDBMI = 2.350000;
                    }
                    if (Num >= 4230 && Num < 4260)
                    {
                        MeanBMI = 17.375200;
                        SDBMI = 2.365800;
                    }
                    if (Num >= 4260 && Num < 4290)
                    {
                        MeanBMI = 17.427200;
                        SDBMI = 2.380800;
                    }
                    if (Num >= 4290 && Num < 4320)
                    {
                        MeanBMI = 17.479900;
                        SDBMI = 2.397100;
                    }
                    if (Num >= 4320 && Num < 4350)
                    {
                        MeanBMI = 17.533400;
                        SDBMI = 2.412600;
                    }
                    if (Num >= 4350 && Num < 4380)
                    {
                        MeanBMI = 17.587700;
                        SDBMI = 2.427300;
                    }
                    if (Num >= 4380 && Num < 4410)
                    {
                        MeanBMI = 17.642700;
                        SDBMI = 2.443300;
                    }
                    if (Num >= 4410 && Num < 4440)
                    {
                        MeanBMI = 17.698500;
                        SDBMI = 2.458500;
                    }
                    if (Num >= 4440 && Num < 4470)
                    {
                        MeanBMI = 17.755100;
                        SDBMI = 2.473900;
                    }
                    if (Num >= 4470 && Num < 4500)
                    {
                        MeanBMI = 17.812400;
                        SDBMI = 2.489600;
                    }
                    if (Num >= 4500 && Num < 4530)
                    {
                        MeanBMI = 17.870400;
                        SDBMI = 2.504600;
                    }
                    if (Num >= 4530 && Num < 4560)
                    {
                        MeanBMI = 17.929200;
                        SDBMI = 2.519800;
                    }
                    if (Num >= 4560 && Num < 4590)
                    {
                        MeanBMI = 17.988700;
                        SDBMI = 2.535300;
                    }
                    if (Num >= 4590 && Num < 4620)
                    {
                        MeanBMI = 18.048800;
                        SDBMI = 2.550200;
                    }
                    if (Num >= 4620 && Num < 4650)
                    {
                        MeanBMI = 18.109600;
                        SDBMI = 2.565400;
                    }
                    if (Num >= 4650 && Num < 4680)
                    {
                        MeanBMI = 18.171000;
                        SDBMI = 2.580000;
                    }
                    if (Num >= 4680 && Num < 4710)
                    {
                        MeanBMI = 18.233000;
                        SDBMI = 2.596000;
                    }
                    if (Num >= 4710 && Num < 4740)
                    {
                        MeanBMI = 18.295500;
                        SDBMI = 2.610500;
                    }
                    if (Num >= 4740 && Num < 4770)
                    {
                        MeanBMI = 18.358600;
                        SDBMI = 2.625400;
                    }
                    if (Num >= 4770 && Num < 4800)
                    {
                        MeanBMI = 18.422100;
                        SDBMI = 2.639900;
                    }
                    if (Num >= 4800 && Num < 4830)
                    {
                        MeanBMI = 18.486000;
                        SDBMI = 2.654000;
                    }
                    if (Num >= 4830 && Num < 4860)
                    {
                        MeanBMI = 18.550200;
                        SDBMI = 2.668800;
                    }
                    if (Num >= 4860 && Num < 4890)
                    {
                        MeanBMI = 18.614800;
                        SDBMI = 2.683200;
                    }
                    if (Num >= 4890 && Num < 4920)
                    {
                        MeanBMI = 18.679500;
                        SDBMI = 2.696500;
                    }
                    if (Num >= 4920 && Num < 4950)
                    {
                        MeanBMI = 18.744500;
                        SDBMI = 2.710500;
                    }
                    if (Num >= 4950 && Num < 4980)
                    {
                        MeanBMI = 18.809500;
                        SDBMI = 2.724500;
                    }
                    if (Num >= 4980 && Num < 5010)
                    {
                        MeanBMI = 18.874600;
                        SDBMI = 2.738400;
                    }
                    if (Num >= 5010 && Num < 5040)
                    {
                        MeanBMI = 18.939800;
                        SDBMI = 2.751200;
                    }
                    if (Num >= 5040 && Num < 5070)
                    {
                        MeanBMI = 19.005000;
                        SDBMI = 2.765000;
                    }
                    if (Num >= 5070 && Num < 5100)
                    {
                        MeanBMI = 19.070100;
                        SDBMI = 2.777900;
                    }
                    if (Num >= 5100 && Num < 5130)
                    {
                        MeanBMI = 19.135100;
                        SDBMI = 2.790900;
                    }
                    if (Num >= 5130 && Num < 5160)
                    {
                        MeanBMI = 19.200000;
                        SDBMI = 2.804000;
                    }
                    if (Num >= 5160 && Num < 5190)
                    {
                        MeanBMI = 19.264800;
                        SDBMI = 2.816200;
                    }
                    if (Num >= 5190 && Num < 5220)
                    {
                        MeanBMI = 19.329400;
                        SDBMI = 2.828600;
                    }
                    if (Num >= 5220 && Num < 5250)
                    {
                        MeanBMI = 19.393700;
                        SDBMI = 2.841300;
                    }
                    if (Num >= 5250 && Num < 5280)
                    {
                        MeanBMI = 19.457800;
                        SDBMI = 2.853200;
                    }
                    if (Num >= 5280 && Num < 5310)
                    {
                        MeanBMI = 19.521700;
                        SDBMI = 2.865300;
                    }
                    if (Num >= 5310 && Num < 5340)
                    {
                        MeanBMI = 19.585300;
                        SDBMI = 2.876700;
                    }
                    if (Num >= 5340 && Num < 5370)
                    {
                        MeanBMI = 19.648600;
                        SDBMI = 2.888400;
                    }
                    if (Num >= 5370 && Num < 5400)
                    {
                        MeanBMI = 19.711700;
                        SDBMI = 2.899300;
                    }
                    if (Num >= 5400 && Num < 5430)
                    {
                        MeanBMI = 19.774400;
                        SDBMI = 2.910600;
                    }
                    if (Num >= 5430 && Num < 5460)
                    {
                        MeanBMI = 19.836700;
                        SDBMI = 2.921300;
                    }
                    if (Num >= 5460 && Num < 5490)
                    {
                        MeanBMI = 19.898700;
                        SDBMI = 2.932300;
                    }
                    if (Num >= 5490 && Num < 5520)
                    {
                        MeanBMI = 19.960300;
                        SDBMI = 2.942700;
                    }
                    if (Num >= 5520 && Num < 5550)
                    {
                        MeanBMI = 20.021500;
                        SDBMI = 2.953500;
                    }
                    if (Num >= 5550 && Num < 5580)
                    {
                        MeanBMI = 20.082300;
                        SDBMI = 2.963700;
                    }
                    if (Num >= 5580 && Num < 5610)
                    {
                        MeanBMI = 20.142700;
                        SDBMI = 2.973300;
                    }
                    if (Num >= 5610 && Num < 5640)
                    {
                        MeanBMI = 20.202600;
                        SDBMI = 2.983400;
                    }
                    if (Num >= 5640 && Num < 5670)
                    {
                        MeanBMI = 20.262100;
                        SDBMI = 2.992900;
                    }
                    if (Num >= 5670 && Num < 5700)
                    {
                        MeanBMI = 20.321100;
                        SDBMI = 3.002900;
                    }
                    if (Num >= 5700 && Num < 5730)
                    {
                        MeanBMI = 20.379600;
                        SDBMI = 3.011400;
                    }
                    if (Num >= 5730 && Num < 5760)
                    {
                        MeanBMI = 20.437600;
                        SDBMI = 3.021400;
                    }
                    if (Num >= 5760 && Num < 5790)
                    {
                        MeanBMI = 20.495100;
                        SDBMI = 3.029900;
                    }
                    if (Num >= 5790 && Num < 5820)
                    {
                        MeanBMI = 20.552100;
                        SDBMI = 3.038900;
                    }
                    if (Num >= 5820 && Num < 5850)
                    {
                        MeanBMI = 20.608500;
                        SDBMI = 3.047500;
                    }
                    if (Num >= 5850 && Num < 5880)
                    {
                        MeanBMI = 20.664400;
                        SDBMI = 3.056600;
                    }
                    if (Num >= 5880 && Num < 5910)
                    {
                        MeanBMI = 20.719700;
                        SDBMI = 3.065300;
                    }
                    if (Num >= 5910 && Num < 5940)
                    {
                        MeanBMI = 20.774500;
                        SDBMI = 3.072500;
                    }
                    if (Num >= 5940 && Num < 5970)
                    {
                        MeanBMI = 20.828700;
                        SDBMI = 3.081300;
                    }
                    if (Num >= 5970 && Num < 6000)
                    {
                        MeanBMI = 20.882400;
                        SDBMI = 3.089600;
                    }
                    if (Num >= 6000 && Num < 6030)
                    {
                        MeanBMI = 20.935500;
                        SDBMI = 3.096500;
                    }
                    if (Num >= 6030 && Num < 6060)
                    {
                        MeanBMI = 20.988100;
                        SDBMI = 3.104900;
                    }
                    if (Num >= 6060 && Num < 6090)
                    {
                        MeanBMI = 21.040000;
                        SDBMI = 3.112000;
                    }
                    if (Num >= 6090 && Num < 6120)
                    {
                        MeanBMI = 21.091400;
                        SDBMI = 3.119600;
                    }
                    if (Num >= 6120 && Num < 6150)
                    {
                        MeanBMI = 21.142300;
                        SDBMI = 3.126700;
                    }
                    if (Num >= 6150 && Num < 6180)
                    {
                        MeanBMI = 21.192500;
                        SDBMI = 3.134500;
                    }
                    if (Num >= 6180 && Num < 6210)
                    {
                        MeanBMI = 21.242300;
                        SDBMI = 3.140700;
                    }
                    if (Num >= 6210 && Num < 6240)
                    {
                        MeanBMI = 21.291400;
                        SDBMI = 3.147600;
                    }
                    if (Num >= 6240 && Num < 6270)
                    {
                        MeanBMI = 21.340000;
                        SDBMI = 3.154000;
                    }
                    if (Num >= 6270 && Num < 6300)
                    {
                        MeanBMI = 21.388000;
                        SDBMI = 3.161000;
                    }
                    if (Num >= 6300 && Num < 6330)
                    {
                        MeanBMI = 21.435400;
                        SDBMI = 3.167600;
                    }
                    if (Num >= 6330 && Num < 6360)
                    {
                        MeanBMI = 21.482200;
                        SDBMI = 3.173800;
                    }
                    if (Num >= 6360 && Num < 6390)
                    {
                        MeanBMI = 21.528500;
                        SDBMI = 3.179500;
                    }
                    if (Num >= 6390 && Num < 6420)
                    {
                        MeanBMI = 21.574200;
                        SDBMI = 3.185800;
                    }
                    if (Num >= 6420 && Num < 6450)
                    {
                        MeanBMI = 21.619300;
                        SDBMI = 3.191700;
                    }
                    if (Num >= 6450 && Num < 6480)
                    {
                        MeanBMI = 21.663800;
                        SDBMI = 3.197200;
                    }
                    if (Num >= 6480 && Num < 6510)
                    {
                        MeanBMI = 21.707700;
                        SDBMI = 3.203300;
                    }
                    if (Num >= 6510 && Num < 6540)
                    {
                        MeanBMI = 21.751000;
                        SDBMI = 3.208000;
                    }
                    if (Num >= 6540 && Num < 6570)
                    {
                        MeanBMI = 21.793700;
                        SDBMI = 3.214300;
                    }
                    if (Num >= 6570 && Num < 6600)
                    {
                        MeanBMI = 21.835800;
                        SDBMI = 3.219200;
                    }
                    if (Num >= 6600 && Num < 6630)
                    {
                        MeanBMI = 21.877300;
                        SDBMI = 3.224700;
                    }
                    if (Num >= 6630 && Num < 6660)
                    {
                        MeanBMI = 21.918200;
                        SDBMI = 3.228800;
                    }
                    if (Num >= 6660 && Num < 6690)
                    {
                        MeanBMI = 21.958500;
                        SDBMI = 3.234500;
                    }
                    if (Num >= 6690 && Num < 6720)
                    {
                        MeanBMI = 21.998200;
                        SDBMI = 3.238800;
                    }
                    if (Num >= 6720 && Num < 6750)
                    {
                        MeanBMI = 22.037400;
                        SDBMI = 3.243600;
                    }
                    if (Num >= 6750 && Num < 6780)
                    {
                        MeanBMI = 22.076000;
                        SDBMI = 3.248000;
                    }
                    if (Num >= 6780 && Num < 6810)
                    {
                        MeanBMI = 22.114000;
                        SDBMI = 3.252000;
                    }
                    if (Num >= 6810 && Num < 6840)
                    {
                        MeanBMI = 22.151400;
                        SDBMI = 3.256600;
                    }
                    if (Num >= 6840 && Num < 6870)
                    {
                        MeanBMI = 22.188300;
                        SDBMI = 3.260700;
                    }





                }

                else

                {
                    // female head circumference
                    if (Num >= 0 && Num < 7)
                    {
                        MeanHC = 33.87;
                        SDHC = 1.18;

                    }
                    else if (Num >= 7 && Num < 14)
                    {
                        MeanHC = 34.55;
                        SDHC = 1.16;
                    }
                    else if (Num >= 14 && Num < 22)
                    {
                        MeanHC = 35.22;
                        SDHC = 1.14;
                    }
                    else if (Num >= 22 && Num < 30)
                    {
                        MeanHC = 35.84;
                        SDHC = 1.15;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanHC = 36.5463;
                        SDHC = 1.1731;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanHC = 38.2521;
                        SDHC = 1.2118;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanHC = 39.5328;
                        SDHC = 1.2413;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanHC = 40.5817;
                        SDHC = 1.2657;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanHC = 41.459;
                        SDHC = 1.2861;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanHC = 42.1995;
                        SDHC = 1.3027;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanHC = 42.829;
                        SDHC = 1.317;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanHC = 43.3671;
                        SDHC = 1.3283;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanHC = 43.83;
                        SDHC = 1.3381;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanHC = 44.2319;
                        SDHC = 1.3464;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanHC = 44.5844;
                        SDHC = 1.3531;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanHC = 44.8965;
                        SDHC = 1.359;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanHC = 45.1752;
                        SDHC = 1.3638;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanHC = 45.4265;
                        SDHC = 1.3683;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanHC = 45.6551;
                        SDHC = 1.3724;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanHC = 45.865;
                        SDHC = 1.3755;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanHC = 46.0598;
                        SDHC = 1.3786;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanHC = 46.2424;
                        SDHC = 1.3813;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanHC = 46.4152;
                        SDHC = 1.3841;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanHC = 46.5801;
                        SDHC = 1.3867;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanHC = 46.7384;
                        SDHC = 1.3891;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanHC = 46.8913;
                        SDHC = 1.3913;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanHC = 47.0391;
                        SDHC = 1.3933;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanHC = 47.1822;
                        SDHC = 1.3952;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanHC = 47.3204;
                        SDHC = 1.3974;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanHC = 47.4536;
                        SDHC = 1.3994;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanHC = 47.5817;
                        SDHC = 1.4013;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanHC = 47.7045;
                        SDHC = 1.403;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanHC = 47.8219;
                        SDHC = 1.4045;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanHC = 47.934;
                        SDHC = 1.4059;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanHC = 48.041;
                        SDHC = 1.4071;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanHC = 48.1432;
                        SDHC = 1.4087;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanHC = 48.2408;
                        SDHC = 1.4096;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanHC = 48.3343;
                        SDHC = 1.4109;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanHC = 48.4239;
                        SDHC = 1.4116;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanHC = 48.5099;
                        SDHC = 1.4126;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanHC = 48.5926;
                        SDHC = 1.4136;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanHC = 48.6722;
                        SDHC = 1.4144;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanHC = 48.7489;
                        SDHC = 1.4152;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanHC = 48.8228;
                        SDHC = 1.4159;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanHC = 48.8941;
                        SDHC = 1.4165;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanHC = 48.9629;
                        SDHC = 1.417;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanHC = 49.0294;
                        SDHC = 1.4174;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanHC = 49.0937;
                        SDHC = 1.4178;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanHC = 49.156;
                        SDHC = 1.4186;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanHC = 49.2164;
                        SDHC = 1.4189;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanHC = 49.2751;
                        SDHC = 1.4191;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanHC = 49.3321;
                        SDHC = 1.4198;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanHC = 49.3877;
                        SDHC = 1.4199;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanHC = 49.4419;
                        SDHC = 1.4205;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanHC = 49.4947;
                        SDHC = 1.4205;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanHC = 49.5464;
                        SDHC = 1.421;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanHC = 49.5969;
                        SDHC = 1.421;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanHC = 49.6464;
                        SDHC = 1.4214;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanHC = 49.6947;
                        SDHC = 1.4218;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanHC = 49.7421;
                        SDHC = 1.4221;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanHC = 49.7885;
                        SDHC = 1.422;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanHC = 49.8341;
                        SDHC = 1.4223;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanHC = 49.8789;
                        SDHC = 1.4226;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanHC = 49.9229;
                        SDHC = 1.4228;
                    }


                    //subject is female weight for age 

                    if (Num >= 0 && Num < 7)
                    {
                        MeanW = 3.23;
                        SDW = 0.5;

                    }
                    if (Num >= 7 && Num < 14)
                    {
                        MeanW = 3.33;
                        SDW = 0.5;
                    }
                    if (Num >= 14 && Num < 22)
                    {
                        MeanW = 3.56;
                        SDW = 0.6;
                    }
                    if (Num >= 22 && Num < 30)
                    {
                        MeanW = 3.83;
                        SDW = 0.6;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanW = 4.1873;
                        SDW = 0.6127;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanW = 5.1282;
                        SDW = 0.6718;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanW = 5.8458;
                        SDW = 0.7542;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanW = 6.4237;
                        SDW = 0.8763;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanW = 6.8985;
                        SDW = 0.9015;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanW = 7.297;
                        SDW = 0.903;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanW = 7.6422;
                        SDW = 0.9578;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanW = 7.9487;
                        SDW = 1.0513;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanW = 8.2254;
                        SDW = 1.0746;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanW = 8.48;
                        SDW = 1.12;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanW = 8.7192;
                        SDW = 1.1808;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanW = 8.9481;
                        SDW = 1.1519;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanW = 9.1699;
                        SDW = 1.2301;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanW = 9.387;
                        SDW = 1.213;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanW = 9.6008;
                        SDW = 1.2992;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanW = 9.8124;
                        SDW = 1.2876;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanW = 10.0226;
                        SDW = 1.3774;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanW = 10.2315;
                        SDW = 1.3685;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanW = 10.4393;
                        SDW = 1.3607;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanW = 10.6464;
                        SDW = 1.4536;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanW = 10.8534;
                        SDW = 1.4466;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanW = 11.0608;
                        SDW = 1.4392;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanW = 11.2688;
                        SDW = 1.5312;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanW = 11.4775;
                        SDW = 1.5225;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanW = 11.6864;
                        SDW = 1.6136;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanW = 11.8947;
                        SDW = 1.6053;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanW = 12.1015;
                        SDW = 1.5985;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanW = 12.3059;
                        SDW = 1.6941;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanW = 12.5073;
                        SDW = 1.6927;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanW = 12.7055;
                        SDW = 1.6945;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanW = 12.9006;
                        SDW = 1.7994;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanW = 13.093;
                        SDW = 1.807;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanW = 13.2837;
                        SDW = 1.8163;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanW = 13.4731;
                        SDW = 1.9269;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanW = 13.6618;
                        SDW = 1.9382;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanW = 13.8503;
                        SDW = 1.9497;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanW = 14.0385;
                        SDW = 1.9615;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanW = 14.2265;
                        SDW = 2.0735;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanW = 14.414;
                        SDW = 2.086;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanW = 14.601;
                        SDW = 2.099;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanW = 14.7873;
                        SDW = 2.1127;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanW = 14.9727;
                        SDW = 2.2273;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanW = 15.1573;
                        SDW = 2.2427;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanW = 15.341;
                        SDW = 2.259;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanW = 15.524;
                        SDW = 2.276;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanW = 15.7064;
                        SDW = 2.3936;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanW = 15.8882;
                        SDW = 2.4118;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanW = 16.0697;
                        SDW = 2.4303;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanW = 16.2511;
                        SDW = 2.5489;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanW = 16.4322;
                        SDW = 2.5678;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanW = 16.6133;
                        SDW = 2.5867;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanW = 16.7942;
                        SDW = 2.6058;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanW = 16.9748;
                        SDW = 2.7252;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanW = 17.1551;
                        SDW = 2.7449;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanW = 17.3347;
                        SDW = 2.7653;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanW = 17.5136;
                        SDW = 2.7864;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanW = 17.6916;
                        SDW = 2.9084;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanW = 17.8686;
                        SDW = 2.9314;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanW = 18.0445;
                        SDW = 2.9555;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanW = 18.2193;
                        SDW = 2.9807;
                    }

                    if (Num >= 1830 && Num < 1860)
                    {
                        MeanW = 18.257900;
                        SDW = 2.911100;
                    }
                    if (Num >= 1860 && Num < 1890)
                    {
                        MeanW = 18.432900;
                        SDW = 2.953100;
                    }
                    if (Num >= 1890 && Num < 1920)
                    {
                        MeanW = 18.607300;
                        SDW = 2.993700;
                    }
                    if (Num >= 1920 && Num < 1950)
                    {
                        MeanW = 18.781100;
                        SDW = 3.035900;
                    }
                    if (Num >= 1950 && Num < 1980)
                    {
                        MeanW = 18.954500;
                        SDW = 3.077500;
                    }
                    if (Num >= 1980 && Num < 2010)
                    {
                        MeanW = 19.127600;
                        SDW = 3.119400;
                    }
                    if (Num >= 2010 && Num < 2040)
                    {
                        MeanW = 19.300400;
                        SDW = 3.161600;
                    }
                    if (Num >= 2040 && Num < 2070)
                    {
                        MeanW = 19.473000;
                        SDW = 3.204000;
                    }
                    if (Num >= 2070 && Num < 2100)
                    {
                        MeanW = 19.645500;
                        SDW = 3.247500;
                    }
                    if (Num >= 2100 && Num < 2130)
                    {
                        MeanW = 19.818000;
                        SDW = 3.290000;
                    }
                    if (Num >= 2130 && Num < 2160)
                    {
                        MeanW = 19.990800;
                        SDW = 3.333200;
                    }
                    if (Num >= 2160 && Num < 2190)
                    {
                        MeanW = 20.163900;
                        SDW = 3.377100;
                    }
                    if (Num >= 2190 && Num < 2220)
                    {
                        MeanW = 20.337700;
                        SDW = 3.421300;
                    }
                    if (Num >= 2220 && Num < 2250)
                    {
                        MeanW = 20.512400;
                        SDW = 3.465600;
                    }
                    if (Num >= 2250 && Num < 2280)
                    {
                        MeanW = 20.688500;
                        SDW = 3.510500;
                    }
                    if (Num >= 2280 && Num < 2310)
                    {
                        MeanW = 20.866100;
                        SDW = 3.556900;
                    }
                    if (Num >= 2310 && Num < 2340)
                    {
                        MeanW = 21.045700;
                        SDW = 3.602300;
                    }
                    if (Num >= 2340 && Num < 2370)
                    {
                        MeanW = 21.227400;
                        SDW = 3.649600;
                    }
                    if (Num >= 2370 && Num < 2400)
                    {
                        MeanW = 21.411300;
                        SDW = 3.696700;
                    }
                    if (Num >= 2400 && Num < 2430)
                    {
                        MeanW = 21.597900;
                        SDW = 3.745100;
                    }
                    if (Num >= 2430 && Num < 2460)
                    {
                        MeanW = 21.787200;
                        SDW = 3.793800;
                    }
                    if (Num >= 2460 && Num < 2490)
                    {
                        MeanW = 21.979500;
                        SDW = 3.843500;
                    }
                    if (Num >= 2490 && Num < 2520)
                    {
                        MeanW = 22.175100;
                        SDW = 3.893900;
                    }
                    if (Num >= 2520 && Num < 2550)
                    {
                        MeanW = 22.374000;
                        SDW = 3.946000;
                    }
                    if (Num >= 2550 && Num < 2580)
                    {
                        MeanW = 22.576200;
                        SDW = 3.997800;
                    }
                    if (Num >= 2580 && Num < 2610)
                    {
                        MeanW = 22.781600;
                        SDW = 4.050400;
                    }
                    if (Num >= 2610 && Num < 2640)
                    {
                        MeanW = 22.990400;
                        SDW = 4.104600;
                    }
                    if (Num >= 2640 && Num < 2670)
                    {
                        MeanW = 23.202500;
                        SDW = 4.159500;
                    }
                    if (Num >= 2670 && Num < 2700)
                    {
                        MeanW = 23.418000;
                        SDW = 4.215000;
                    }
                    if (Num >= 2700 && Num < 2730)
                    {
                        MeanW = 23.636900;
                        SDW = 4.271100;
                    }
                    if (Num >= 2730 && Num < 2760)
                    {
                        MeanW = 23.859300;
                        SDW = 4.328700;
                    }
                    if (Num >= 2760 && Num < 2790)
                    {
                        MeanW = 24.085300;
                        SDW = 4.386700;
                    }
                    if (Num >= 2790 && Num < 2820)
                    {
                        MeanW = 24.314900;
                        SDW = 4.446100;
                    }
                    if (Num >= 2820 && Num < 2850)
                    {
                        MeanW = 24.548200;
                        SDW = 4.505800;
                    }
                    if (Num >= 2850 && Num < 2880)
                    {
                        MeanW = 24.785300;
                        SDW = 4.566700;
                    }
                    if (Num >= 2880 && Num < 2910)
                    {
                        MeanW = 25.026200;
                        SDW = 4.628800;
                    }
                    if (Num >= 2910 && Num < 2940)
                    {
                        MeanW = 25.271000;
                        SDW = 4.692000;
                    }
                    if (Num >= 2940 && Num < 2970)
                    {
                        MeanW = 25.519700;
                        SDW = 4.755300;
                    }
                    if (Num >= 2970 && Num < 3000)
                    {
                        MeanW = 25.772100;
                        SDW = 4.820900;
                    }
                    if (Num >= 3000 && Num < 3030)
                    {
                        MeanW = 26.028400;
                        SDW = 4.885600;
                    }
                    if (Num >= 3030 && Num < 3060)
                    {
                        MeanW = 26.288300;
                        SDW = 4.952700;
                    }
                    if (Num >= 3060 && Num < 3090)
                    {
                        MeanW = 26.551900;
                        SDW = 5.020100;
                    }
                    if (Num >= 3090 && Num < 3120)
                    {
                        MeanW = 26.819000;
                        SDW = 5.088000;
                    }
                    if (Num >= 3120 && Num < 3150)
                    {
                        MeanW = 27.089600;
                        SDW = 5.157400;
                    }
                    if (Num >= 3150 && Num < 3180)
                    {
                        MeanW = 27.363500;
                        SDW = 5.227500;
                    }
                    if (Num >= 3180 && Num < 3210)
                    {
                        MeanW = 27.640600;
                        SDW = 5.298400;
                    }
                    if (Num >= 3210 && Num < 3240)
                    {
                        MeanW = 27.920800;
                        SDW = 5.369200;
                    }
                    if (Num >= 3240 && Num < 3270)
                    {
                        MeanW = 28.204000;
                        SDW = 5.441000;
                    }
                    if (Num >= 3270 && Num < 3300)
                    {
                        MeanW = 28.490100;
                        SDW = 5.513900;
                    }
                    if (Num >= 3300 && Num < 3330)
                    {
                        MeanW = 28.779100;
                        SDW = 5.587900;
                    }
                    if (Num >= 3330 && Num < 3360)
                    {
                        MeanW = 29.071100;
                        SDW = 5.661900;
                    }
                    if (Num >= 3360 && Num < 3390)
                    {
                        MeanW = 29.366300;
                        SDW = 5.737700;
                    }
                    if (Num >= 3390 && Num < 3420)
                    {
                        MeanW = 29.664600;
                        SDW = 5.813400;
                    }
                    if (Num >= 3420 && Num < 3450)
                    {
                        MeanW = 29.966300;
                        SDW = 5.889700;
                    }
                    if (Num >= 3450 && Num < 3480)
                    {
                        MeanW = 30.271500;
                        SDW = 5.966500;
                    }
                    if (Num >= 3480 && Num < 3510)
                    {
                        MeanW = 30.580500;
                        SDW = 6.044500;
                    }
                    if (Num >= 3510 && Num < 3540)
                    {
                        MeanW = 30.893400;
                        SDW = 6.123600;
                    }
                    if (Num >= 3540 && Num < 3570)
                    {
                        MeanW = 31.210500;
                        SDW = 6.203500;
                    }
                    if (Num >= 3570 && Num < 3600)
                    {
                        MeanW = 31.531900;
                        SDW = 6.283100;
                    }
                    if (Num >= 3600 && Num < 3630)
                    {
                        MeanW = 31.857800;
                        SDW = 6.365200;
                    }
                    if (Num >= 3630 && Num < 3645)
                    {
                        MeanW = 33.2376;
                        SDW = 7.95575;
                    }
                    if (Num >= 3645 && Num < 3660)
                    {
                        MeanW = 33.4121;
                        SDW = 8.01096;
                    }
                    if (Num >= 3660 && Num < 3675)
                    {
                        MeanW = 33.5872;
                        SDW = 8.06615;
                    }
                    if (Num >= 3675 && Num < 3690)
                    {
                        MeanW = 33.763;
                        SDW = 8.12131;
                    }
                    if (Num >= 3690 && Num < 3705)
                    {
                        MeanW = 33.9395;
                        SDW = 8.17643;
                    }
                    if (Num >= 3705 && Num < 3720)
                    {
                        MeanW = 34.1166;
                        SDW = 8.23149;
                    }
                    if (Num >= 3720 && Num < 3735)
                    {
                        MeanW = 34.2944;
                        SDW = 8.28648;
                    }
                    if (Num >= 3735 && Num < 3750)
                    {
                        MeanW = 34.4727;
                        SDW = 8.34139;
                    }
                    if (Num >= 3750 && Num < 3765)
                    {
                        MeanW = 34.6517;
                        SDW = 8.39621;
                    }
                    if (Num >= 3765 && Num < 3780)
                    {
                        MeanW = 34.8312;
                        SDW = 8.45093;
                    }
                    if (Num >= 3780 && Num < 3795)
                    {
                        MeanW = 35.0112;
                        SDW = 8.50553;
                    }
                    if (Num >= 3795 && Num < 3810)
                    {
                        MeanW = 35.1918;
                        SDW = 8.56001;
                    }
                    if (Num >= 3810 && Num < 3825)
                    {
                        MeanW = 35.3728;
                        SDW = 8.61434;
                    }
                    if (Num >= 3825 && Num < 3840)
                    {
                        MeanW = 35.5544;
                        SDW = 8.66853;
                    }
                    if (Num >= 3840 && Num < 3855)
                    {
                        MeanW = 35.7364;
                        SDW = 8.72255;
                    }
                    if (Num >= 3855 && Num < 3870)
                    {
                        MeanW = 35.9188;
                        SDW = 8.7764;
                    }
                    if (Num >= 3870 && Num < 3885)
                    {
                        MeanW = 36.1016;
                        SDW = 8.83006;
                    }
                    if (Num >= 3885 && Num < 3900)
                    {
                        MeanW = 36.2849;
                        SDW = 8.88352;
                    }
                    if (Num >= 3900 && Num < 3915)
                    {
                        MeanW = 36.4684;
                        SDW = 8.93677;
                    }
                    if (Num >= 3915 && Num < 3930)
                    {
                        MeanW = 36.6524;
                        SDW = 8.9898;
                    }
                    if (Num >= 3930 && Num < 3945)
                    {
                        MeanW = 36.8366;
                        SDW = 9.04259;
                    }
                    if (Num >= 3945 && Num < 3960)
                    {
                        MeanW = 37.0211;
                        SDW = 9.09514;
                    }
                    if (Num >= 3960 && Num < 3975)
                    {
                        MeanW = 37.2059;
                        SDW = 9.14743;
                    }
                    if (Num >= 3975 && Num < 3990)
                    {
                        MeanW = 37.3909;
                        SDW = 9.19945;
                    }
                    if (Num >= 3990 && Num < 4005)
                    {
                        MeanW = 37.5761;
                        SDW = 9.25119;
                    }
                    if (Num >= 4005 && Num < 4020)
                    {
                        MeanW = 37.7615;
                        SDW = 9.30264;
                    }
                    if (Num >= 4020 && Num < 4035)
                    {
                        MeanW = 37.947;
                        SDW = 9.35379;
                    }
                    if (Num >= 4035 && Num < 4050)
                    {
                        MeanW = 38.1327;
                        SDW = 9.40462;
                    }
                    if (Num >= 4050 && Num < 4065)
                    {
                        MeanW = 38.3185;
                        SDW = 9.45512;
                    }
                    if (Num >= 4065 && Num < 4080)
                    {
                        MeanW = 38.5043;
                        SDW = 9.50529;
                    }
                    if (Num >= 4080 && Num < 4095)
                    {
                        MeanW = 38.6902;
                        SDW = 9.5551;
                    }
                    if (Num >= 4095 && Num < 4110)
                    {
                        MeanW = 38.8761;
                        SDW = 9.60456;
                    }
                    if (Num >= 4110 && Num < 4125)
                    {
                        MeanW = 39.0619;
                        SDW = 9.65365;
                    }
                    if (Num >= 4125 && Num < 4140)
                    {
                        MeanW = 39.2477;
                        SDW = 9.70236;
                    }
                    if (Num >= 4140 && Num < 4155)
                    {
                        MeanW = 39.4335;
                        SDW = 9.75068;
                    }
                    if (Num >= 4155 && Num < 4170)
                    {
                        MeanW = 39.6191;
                        SDW = 9.79859;
                    }
                    if (Num >= 4170 && Num < 4185)
                    {
                        MeanW = 39.8047;
                        SDW = 9.8461;
                    }
                    if (Num >= 4185 && Num < 4200)
                    {
                        MeanW = 39.99;
                        SDW = 9.89318;
                    }
                    if (Num >= 4200 && Num < 4215)
                    {
                        MeanW = 40.1752;
                        SDW = 9.93983;
                    }
                    if (Num >= 4215 && Num < 4230)
                    {
                        MeanW = 40.3601;
                        SDW = 9.98604;
                    }
                    if (Num >= 4230 && Num < 4245)
                    {
                        MeanW = 40.5448;
                        SDW = 10.0318;
                    }
                    if (Num >= 4245 && Num < 4260)
                    {
                        MeanW = 40.7292;
                        SDW = 10.0771;
                    }
                    if (Num >= 4260 && Num < 4275)
                    {
                        MeanW = 40.9133;
                        SDW = 10.1219;
                    }
                    if (Num >= 4275 && Num < 4290)
                    {
                        MeanW = 41.097;
                        SDW = 10.1663;
                    }
                    if (Num >= 4290 && Num < 4305)
                    {
                        MeanW = 41.2804;
                        SDW = 10.2101;
                    }
                    if (Num >= 4305 && Num < 4320)
                    {
                        MeanW = 41.4634;
                        SDW = 10.2535;
                    }
                    if (Num >= 4320 && Num < 4335)
                    {
                        MeanW = 41.6459;
                        SDW = 10.2963;
                    }
                    if (Num >= 4335 && Num < 4350)
                    {
                        MeanW = 41.828;
                        SDW = 10.3387;
                    }
                    if (Num >= 4350 && Num < 4365)
                    {
                        MeanW = 42.0096;
                        SDW = 10.3805;
                    }
                    if (Num >= 4365 && Num < 4380)
                    {
                        MeanW = 42.1906;
                        SDW = 10.4218;
                    }
                    if (Num >= 4380 && Num < 4395)
                    {
                        MeanW = 42.3711;
                        SDW = 10.4625;
                    }
                    if (Num >= 4395 && Num < 4410)
                    {
                        MeanW = 42.5511;
                        SDW = 10.5027;
                    }
                    if (Num >= 4410 && Num < 4425)
                    {
                        MeanW = 42.7304;
                        SDW = 10.5424;
                    }
                    if (Num >= 4425 && Num < 4440)
                    {
                        MeanW = 42.9091;
                        SDW = 10.5815;
                    }
                    if (Num >= 4440 && Num < 4455)
                    {
                        MeanW = 43.0871;
                        SDW = 10.62;
                    }
                    if (Num >= 4455 && Num < 4470)
                    {
                        MeanW = 43.2644;
                        SDW = 10.658;
                    }
                    if (Num >= 4470 && Num < 4485)
                    {
                        MeanW = 43.441;
                        SDW = 10.6954;
                    }
                    if (Num >= 4485 && Num < 4500)
                    {
                        MeanW = 43.6168;
                        SDW = 10.7321;
                    }
                    if (Num >= 4500 && Num < 4515)
                    {
                        MeanW = 43.7919;
                        SDW = 10.7683;
                    }
                    if (Num >= 4515 && Num < 4530)
                    {
                        MeanW = 43.9661;
                        SDW = 10.8039;
                    }
                    if (Num >= 4530 && Num < 4545)
                    {
                        MeanW = 44.1395;
                        SDW = 10.8389;
                    }
                    if (Num >= 4545 && Num < 4560)
                    {
                        MeanW = 44.312;
                        SDW = 10.8733;
                    }
                    if (Num >= 4560 && Num < 4575)
                    {
                        MeanW = 44.4837;
                        SDW = 10.9071;
                    }
                    if (Num >= 4575 && Num < 4590)
                    {
                        MeanW = 44.6544;
                        SDW = 10.9403;
                    }
                    if (Num >= 4590 && Num < 4605)
                    {
                        MeanW = 44.8241;
                        SDW = 10.9728;
                    }
                    if (Num >= 4605 && Num < 4620)
                    {
                        MeanW = 44.9929;
                        SDW = 11.0047;
                    }
                    if (Num >= 4620 && Num < 4635)
                    {
                        MeanW = 45.1607;
                        SDW = 11.036;
                    }
                    if (Num >= 4635 && Num < 4650)
                    {
                        MeanW = 45.3274;
                        SDW = 11.0667;
                    }
                    if (Num >= 4650 && Num < 4665)
                    {
                        MeanW = 45.4931;
                        SDW = 11.0967;
                    }
                    if (Num >= 4665 && Num < 4680)
                    {
                        MeanW = 45.6578;
                        SDW = 11.126;
                    }
                    if (Num >= 4680 && Num < 4695)
                    {
                        MeanW = 45.8213;
                        SDW = 11.1548;
                    }
                    if (Num >= 4695 && Num < 4710)
                    {
                        MeanW = 45.9837;
                        SDW = 11.1829;
                    }
                    if (Num >= 4710 && Num < 4725)
                    {
                        MeanW = 46.1449;
                        SDW = 11.2103;
                    }
                    if (Num >= 4725 && Num < 4740)
                    {
                        MeanW = 46.305;
                        SDW = 11.2371;
                    }
                    if (Num >= 4740 && Num < 4755)
                    {
                        MeanW = 46.4639;
                        SDW = 11.2633;
                    }
                    if (Num >= 4755 && Num < 4770)
                    {
                        MeanW = 46.6216;
                        SDW = 11.2888;
                    }
                    if (Num >= 4770 && Num < 4785)
                    {
                        MeanW = 46.778;
                        SDW = 11.3136;
                    }
                    if (Num >= 4785 && Num < 4800)
                    {
                        MeanW = 46.9331;
                        SDW = 11.3378;
                    }
                    if (Num >= 4800 && Num < 4815)
                    {
                        MeanW = 47.087;
                        SDW = 11.3613;
                    }
                    if (Num >= 4815 && Num < 4830)
                    {
                        MeanW = 47.2396;
                        SDW = 11.3842;
                    }
                    if (Num >= 4830 && Num < 4845)
                    {
                        MeanW = 47.3909;
                        SDW = 11.4065;
                    }
                    if (Num >= 4845 && Num < 4860)
                    {
                        MeanW = 47.5408;
                        SDW = 11.428;
                    }
                    if (Num >= 4860 && Num < 4875)
                    {
                        MeanW = 47.6894;
                        SDW = 11.449;
                    }
                    if (Num >= 4875 && Num < 4890)
                    {
                        MeanW = 47.8366;
                        SDW = 11.4693;
                    }
                    if (Num >= 4890 && Num < 4905)
                    {
                        MeanW = 47.9824;
                        SDW = 11.4889;
                    }
                    if (Num >= 4905 && Num < 4920)
                    {
                        MeanW = 48.1269;
                        SDW = 11.5079;
                    }
                    if (Num >= 4920 && Num < 4935)
                    {
                        MeanW = 48.2698;
                        SDW = 11.5262;
                    }
                    if (Num >= 4935 && Num < 4950)
                    {
                        MeanW = 48.4114;
                        SDW = 11.5439;
                    }
                    if (Num >= 4950 && Num < 4965)
                    {
                        MeanW = 48.5515;
                        SDW = 11.561;
                    }
                    if (Num >= 4965 && Num < 4980)
                    {
                        MeanW = 48.6902;
                        SDW = 11.5775;
                    }
                    if (Num >= 4980 && Num < 4995)
                    {
                        MeanW = 48.8274;
                        SDW = 11.5933;
                    }
                    if (Num >= 4995 && Num < 5010)
                    {
                        MeanW = 48.963;
                        SDW = 11.6084;
                    }
                    if (Num >= 5010 && Num < 5025)
                    {
                        MeanW = 49.0972;
                        SDW = 11.623;
                    }
                    if (Num >= 5025 && Num < 5040)
                    {
                        MeanW = 49.2299;
                        SDW = 11.6369;
                    }
                    if (Num >= 5040 && Num < 5055)
                    {
                        MeanW = 49.3611;
                        SDW = 11.6503;
                    }
                    if (Num >= 5055 && Num < 5070)
                    {
                        MeanW = 49.4908;
                        SDW = 11.663;
                    }
                    if (Num >= 5070 && Num < 5085)
                    {
                        MeanW = 49.6189;
                        SDW = 11.6751;
                    }
                    if (Num >= 5085 && Num < 5100)
                    {
                        MeanW = 49.7454;
                        SDW = 11.6866;
                    }
                    if (Num >= 5100 && Num < 5115)
                    {
                        MeanW = 49.8705;
                        SDW = 11.6975;
                    }
                    if (Num >= 5115 && Num < 5130)
                    {
                        MeanW = 49.9939;
                        SDW = 11.7079;
                    }
                    if (Num >= 5130 && Num < 5145)
                    {
                        MeanW = 50.1159;
                        SDW = 11.7177;
                    }
                    if (Num >= 5145 && Num < 5160)
                    {
                        MeanW = 50.2362;
                        SDW = 11.7269;
                    }
                    if (Num >= 5160 && Num < 5175)
                    {
                        MeanW = 50.355;
                        SDW = 11.7355;
                    }
                    if (Num >= 5175 && Num < 5190)
                    {
                        MeanW = 50.4722;
                        SDW = 11.7436;
                    }
                    if (Num >= 5190 && Num < 5205)
                    {
                        MeanW = 50.5879;
                        SDW = 11.7511;
                    }
                    if (Num >= 5205 && Num < 5220)
                    {
                        MeanW = 50.702;
                        SDW = 11.7581;
                    }
                    if (Num >= 5220 && Num < 5235)
                    {
                        MeanW = 50.8145;
                        SDW = 11.7646;
                    }
                    if (Num >= 5235 && Num < 5250)
                    {
                        MeanW = 50.9254;
                        SDW = 11.7706;
                    }
                    if (Num >= 5250 && Num < 5265)
                    {
                        MeanW = 51.0348;
                        SDW = 11.776;
                    }
                    if (Num >= 5265 && Num < 5280)
                    {
                        MeanW = 51.1426;
                        SDW = 11.781;
                    }
                    if (Num >= 5280 && Num < 5295)
                    {
                        MeanW = 51.2488;
                        SDW = 11.7854;
                    }
                    if (Num >= 5295 && Num < 5310)
                    {
                        MeanW = 51.3535;
                        SDW = 11.7894;
                    }
                    if (Num >= 5310 && Num < 5325)
                    {
                        MeanW = 51.4567;
                        SDW = 11.7929;
                    }
                    if (Num >= 5325 && Num < 5340)
                    {
                        MeanW = 51.5582;
                        SDW = 11.796;
                    }
                    if (Num >= 5340 && Num < 5355)
                    {
                        MeanW = 51.6583;
                        SDW = 11.7986;
                    }
                    if (Num >= 5355 && Num < 5370)
                    {
                        MeanW = 51.7568;
                        SDW = 11.8008;
                    }
                    if (Num >= 5370 && Num < 5385)
                    {
                        MeanW = 51.8538;
                        SDW = 11.8026;
                    }
                    if (Num >= 5385 && Num < 5400)
                    {
                        MeanW = 51.9493;
                        SDW = 11.8039;
                    }
                    if (Num >= 5400 && Num < 5415)
                    {
                        MeanW = 52.0432;
                        SDW = 11.8049;
                    }
                    if (Num >= 5415 && Num < 5430)
                    {
                        MeanW = 52.1357;
                        SDW = 11.8055;
                    }
                    if (Num >= 5430 && Num < 5445)
                    {
                        MeanW = 52.2267;
                        SDW = 11.8057;
                    }
                    if (Num >= 5445 && Num < 5460)
                    {
                        MeanW = 52.3162;
                        SDW = 11.8055;
                    }
                    if (Num >= 5460 && Num < 5475)
                    {
                        MeanW = 52.4042;
                        SDW = 11.8051;
                    }
                    if (Num >= 5475 && Num < 5490)
                    {
                        MeanW = 52.4908;
                        SDW = 11.8042;
                    }
                    if (Num >= 5490 && Num < 5505)
                    {
                        MeanW = 52.576;
                        SDW = 11.8031;
                    }
                    if (Num >= 5505 && Num < 5520)
                    {
                        MeanW = 52.6597;
                        SDW = 11.8017;
                    }
                    if (Num >= 5520 && Num < 5535)
                    {
                        MeanW = 52.742;
                        SDW = 11.8;
                    }
                    if (Num >= 5535 && Num < 5550)
                    {
                        MeanW = 52.823;
                        SDW = 11.798;
                    }
                    if (Num >= 5550 && Num < 5565)
                    {
                        MeanW = 52.9026;
                        SDW = 11.7958;
                    }
                    if (Num >= 5565 && Num < 5580)
                    {
                        MeanW = 52.9808;
                        SDW = 11.7933;
                    }
                    if (Num >= 5580 && Num < 5595)
                    {
                        MeanW = 53.0577;
                        SDW = 11.7906;
                    }
                    if (Num >= 5595 && Num < 5610)
                    {
                        MeanW = 53.1333;
                        SDW = 11.7877;
                    }
                    if (Num >= 5610 && Num < 5625)
                    {
                        MeanW = 53.2076;
                        SDW = 11.7846;
                    }
                    if (Num >= 5625 && Num < 5640)
                    {
                        MeanW = 53.2806;
                        SDW = 11.7813;
                    }
                    if (Num >= 5640 && Num < 5655)
                    {
                        MeanW = 53.3523;
                        SDW = 11.7779;
                    }
                    if (Num >= 5655 && Num < 5670)
                    {
                        MeanW = 53.4228;
                        SDW = 11.7743;
                    }
                    if (Num >= 5670 && Num < 5685)
                    {
                        MeanW = 53.4922;
                        SDW = 11.7706;
                    }
                    if (Num >= 5685 && Num < 5700)
                    {
                        MeanW = 53.5603;
                        SDW = 11.7668;
                    }
                    if (Num >= 5700 && Num < 5715)
                    {
                        MeanW = 53.6272;
                        SDW = 11.7628;
                    }
                    if (Num >= 5715 && Num < 5730)
                    {
                        MeanW = 53.6931;
                        SDW = 11.7588;
                    }
                    if (Num >= 5730 && Num < 5745)
                    {
                        MeanW = 53.7578;
                        SDW = 11.7548;
                    }
                    if (Num >= 5745 && Num < 5760)
                    {
                        MeanW = 53.8214;
                        SDW = 11.7507;
                    }
                    if (Num >= 5760 && Num < 5775)
                    {
                        MeanW = 53.8839;
                        SDW = 11.7465;
                    }
                    if (Num >= 5775 && Num < 5790)
                    {
                        MeanW = 53.9454;
                        SDW = 11.7424;
                    }
                    if (Num >= 5790 && Num < 5805)
                    {
                        MeanW = 54.0059;
                        SDW = 11.7382;
                    }
                    if (Num >= 5805 && Num < 5820)
                    {
                        MeanW = 54.0654;
                        SDW = 11.7341;
                    }
                    if (Num >= 5820 && Num < 5835)
                    {
                        MeanW = 54.124;
                        SDW = 11.73;
                    }
                    if (Num >= 5835 && Num < 5850)
                    {
                        MeanW = 54.1816;
                        SDW = 11.726;
                    }
                    if (Num >= 5850 && Num < 5865)
                    {
                        MeanW = 54.2383;
                        SDW = 11.722;
                    }
                    if (Num >= 5865 && Num < 5880)
                    {
                        MeanW = 54.2941;
                        SDW = 11.7181;
                    }
                    if (Num >= 5880 && Num < 5895)
                    {
                        MeanW = 54.3491;
                        SDW = 11.7143;
                    }
                    if (Num >= 5895 && Num < 5910)
                    {
                        MeanW = 54.4032;
                        SDW = 11.7106;
                    }
                    if (Num >= 5910 && Num < 5925)
                    {
                        MeanW = 54.4566;
                        SDW = 11.707;
                    }
                    if (Num >= 5925 && Num < 5940)
                    {
                        MeanW = 54.5092;
                        SDW = 11.7036;
                    }
                    if (Num >= 5940 && Num < 5955)
                    {
                        MeanW = 54.5611;
                        SDW = 11.7003;
                    }
                    if (Num >= 5955 && Num < 5970)
                    {
                        MeanW = 54.6122;
                        SDW = 11.6972;
                    }
                    if (Num >= 5970 && Num < 5985)
                    {
                        MeanW = 54.6627;
                        SDW = 11.6943;
                    }
                    if (Num >= 5985 && Num < 6000)
                    {
                        MeanW = 54.7126;
                        SDW = 11.6916;
                    }
                    if (Num >= 6000 && Num < 6015)
                    {
                        MeanW = 54.7618;
                        SDW = 11.6891;
                    }
                    if (Num >= 6015 && Num < 6030)
                    {
                        MeanW = 54.8104;
                        SDW = 11.6868;
                    }
                    if (Num >= 6030 && Num < 6045)
                    {
                        MeanW = 54.8585;
                        SDW = 11.6848;
                    }
                    if (Num >= 6045 && Num < 6060)
                    {
                        MeanW = 54.9061;
                        SDW = 11.683;
                    }
                    if (Num >= 6060 && Num < 6075)
                    {
                        MeanW = 54.9532;
                        SDW = 11.6814;
                    }
                    if (Num >= 6075 && Num < 6090)
                    {
                        MeanW = 54.9998;
                        SDW = 11.6802;
                    }
                    if (Num >= 6090 && Num < 6105)
                    {
                        MeanW = 55.046;
                        SDW = 11.6792;
                    }
                    if (Num >= 6105 && Num < 6120)
                    {
                        MeanW = 55.0917;
                        SDW = 11.6785;
                    }
                    if (Num >= 6120 && Num < 6135)
                    {
                        MeanW = 55.1371;
                        SDW = 11.6781;
                    }
                    if (Num >= 6135 && Num < 6150)
                    {
                        MeanW = 55.1822;
                        SDW = 11.6781;
                    }
                    if (Num >= 6150 && Num < 6165)
                    {
                        MeanW = 55.2269;
                        SDW = 11.6783;
                    }
                    if (Num >= 6165 && Num < 6180)
                    {
                        MeanW = 55.2714;
                        SDW = 11.6789;
                    }
                    if (Num >= 6180 && Num < 6195)
                    {
                        MeanW = 55.3155;
                        SDW = 11.6798;
                    }
                    if (Num >= 6195 && Num < 6210)
                    {
                        MeanW = 55.3595;
                        SDW = 11.6811;
                    }
                    if (Num >= 6210 && Num < 6225)
                    {
                        MeanW = 55.4033;
                        SDW = 11.6827;
                    }
                    if (Num >= 6225 && Num < 6240)
                    {
                        MeanW = 55.4469;
                        SDW = 11.6847;
                    }
                    if (Num >= 6240 && Num < 6255)
                    {
                        MeanW = 55.4903;
                        SDW = 11.687;
                    }
                    if (Num >= 6255 && Num < 6270)
                    {
                        MeanW = 55.5336;
                        SDW = 11.6897;
                    }
                    if (Num >= 6270 && Num < 6285)
                    {
                        MeanW = 55.5769;
                        SDW = 11.6927;
                    }
                    if (Num >= 6285 && Num < 6300)
                    {
                        MeanW = 55.62;
                        SDW = 11.6962;
                    }
                    if (Num >= 6300 && Num < 6315)
                    {
                        MeanW = 55.6631;
                        SDW = 11.7;
                    }
                    if (Num >= 6315 && Num < 6330)
                    {
                        MeanW = 55.7062;
                        SDW = 11.7042;
                    }
                    if (Num >= 6330 && Num < 6345)
                    {
                        MeanW = 55.7493;
                        SDW = 11.7088;
                    }
                    if (Num >= 6345 && Num < 6360)
                    {
                        MeanW = 55.7925;
                        SDW = 11.7137;
                    }
                    if (Num >= 6360 && Num < 6375)
                    {
                        MeanW = 55.8357;
                        SDW = 11.7191;
                    }
                    if (Num >= 6375 && Num < 6390)
                    {
                        MeanW = 55.8789;
                        SDW = 11.7248;
                    }
                    if (Num >= 6390 && Num < 6405)
                    {
                        MeanW = 55.9223;
                        SDW = 11.7309;
                    }
                    if (Num >= 6405 && Num < 6420)
                    {
                        MeanW = 55.9657;
                        SDW = 11.7374;
                    }
                    if (Num >= 6420 && Num < 6435)
                    {
                        MeanW = 56.0093;
                        SDW = 11.7442;
                    }
                    if (Num >= 6435 && Num < 6450)
                    {
                        MeanW = 56.053;
                        SDW = 11.7514;
                    }
                    if (Num >= 6450 && Num < 6465)
                    {
                        MeanW = 56.0969;
                        SDW = 11.759;
                    }
                    if (Num >= 6465 && Num < 6480)
                    {
                        MeanW = 56.141;
                        SDW = 11.7669;
                    }
                    if (Num >= 6480 && Num < 6495)
                    {
                        MeanW = 56.1853;
                        SDW = 11.7752;
                    }
                    if (Num >= 6495 && Num < 6510)
                    {
                        MeanW = 56.2297;
                        SDW = 11.7838;
                    }
                    if (Num >= 6510 && Num < 6525)
                    {
                        MeanW = 56.2744;
                        SDW = 11.7928;
                    }
                    if (Num >= 6525 && Num < 6540)
                    {
                        MeanW = 56.3192;
                        SDW = 11.8021;
                    }
                    if (Num >= 6540 && Num < 6555)
                    {
                        MeanW = 56.3643;
                        SDW = 11.8117;
                    }
                    if (Num >= 6555 && Num < 6570)
                    {
                        MeanW = 56.4096;
                        SDW = 11.8217;
                    }
                    if (Num >= 6570 && Num < 6585)
                    {
                        MeanW = 56.4552;
                        SDW = 11.8319;
                    }
                    if (Num >= 6585 && Num < 6600)
                    {
                        MeanW = 56.501;
                        SDW = 11.8424;
                    }
                    if (Num >= 6600 && Num < 6615)
                    {
                        MeanW = 56.547;
                        SDW = 11.8532;
                    }
                    if (Num >= 6615 && Num < 6630)
                    {
                        MeanW = 56.5932;
                        SDW = 11.8643;
                    }
                    if (Num >= 6630 && Num < 6645)
                    {
                        MeanW = 56.6397;
                        SDW = 11.8756;
                    }
                    if (Num >= 6645 && Num < 6660)
                    {
                        MeanW = 56.6863;
                        SDW = 11.8872;
                    }
                    if (Num >= 6660 && Num < 6675)
                    {
                        MeanW = 56.7332;
                        SDW = 11.899;
                    }
                    if (Num >= 6675 && Num < 6690)
                    {
                        MeanW = 56.7803;
                        SDW = 11.911;
                    }
                    if (Num >= 6690 && Num < 6705)
                    {
                        MeanW = 56.8275;
                        SDW = 11.9232;
                    }
                    if (Num >= 6705 && Num < 6720)
                    {
                        MeanW = 56.8749;
                        SDW = 11.9355;
                    }
                    if (Num >= 6720 && Num < 6735)
                    {
                        MeanW = 56.9224;
                        SDW = 11.9481;
                    }
                    if (Num >= 6735 && Num < 6750)
                    {
                        MeanW = 56.9701;
                        SDW = 11.9607;
                    }
                    if (Num >= 6750 && Num < 6765)
                    {
                        MeanW = 57.0178;
                        SDW = 11.9735;
                    }
                    if (Num >= 6765 && Num < 6780)
                    {
                        MeanW = 57.0656;
                        SDW = 11.9864;
                    }
                    if (Num >= 6780 && Num < 6795)
                    {
                        MeanW = 57.1135;
                        SDW = 11.9994;
                    }
                    if (Num >= 6795 && Num < 6810)
                    {
                        MeanW = 57.1613;
                        SDW = 12.0125;
                    }
                    if (Num >= 6810 && Num < 6825)
                    {
                        MeanW = 57.2091;
                        SDW = 12.0256;
                    }
                    if (Num >= 6825 && Num < 6840)
                    {
                        MeanW = 57.2568;
                        SDW = 12.0388;
                    }
                    if (Num >= 6840 && Num < 6855)
                    {
                        MeanW = 57.3044;
                        SDW = 12.052;
                    }
                    if (Num >= 6855 && Num < 6870)
                    {
                        MeanW = 57.3518;
                        SDW = 12.0652;
                    }
                    if (Num >= 6870 && Num < 6885)
                    {
                        MeanW = 57.3989;
                        SDW = 12.0783;
                    }
                    if (Num >= 6885 && Num < 6900)
                    {
                        MeanW = 57.4458;
                        SDW = 12.0914;
                    }
                    if (Num >= 6900 && Num < 6915)
                    {
                        MeanW = 57.4923;
                        SDW = 12.1045;
                    }
                    if (Num >= 6915 && Num < 6930)
                    {
                        MeanW = 57.5384;
                        SDW = 12.1174;
                    }
                    if (Num >= 6930 && Num < 6945)
                    {
                        MeanW = 57.584;
                        SDW = 12.1303;
                    }
                    if (Num >= 6945 && Num < 6960)
                    {
                        MeanW = 57.6291;
                        SDW = 12.1431;
                    }
                    if (Num >= 6960 && Num < 6975)
                    {
                        MeanW = 57.6735;
                        SDW = 12.1557;
                    }
                    if (Num >= 6975 && Num < 6990)
                    {
                        MeanW = 57.7173;
                        SDW = 12.1681;
                    }
                    if (Num >= 6990 && Num < 7005)
                    {
                        MeanW = 57.7602;
                        SDW = 12.1804;
                    }
                    if (Num >= 7005 && Num < 7020)
                    {
                        MeanW = 57.8023;
                        SDW = 12.1925;
                    }
                    if (Num >= 7020 && Num < 7035)
                    {
                        MeanW = 57.8433;
                        SDW = 12.2044;
                    }
                    if (Num >= 7035 && Num < 7050)
                    {
                        MeanW = 57.8833;
                        SDW = 12.2161;
                    }
                    if (Num >= 7050 && Num < 7065)
                    {
                        MeanW = 57.9221;
                        SDW = 12.2275;
                    }
                    if (Num >= 7065 && Num < 7080)
                    {
                        MeanW = 57.9597;
                        SDW = 12.2387;
                    }
                    if (Num >= 7080 && Num < 7095)
                    {
                        MeanW = 57.9958;
                        SDW = 12.2496;
                    }
                    if (Num >= 7095 && Num < 7110)
                    {
                        MeanW = 58.0304;
                        SDW = 12.2602;
                    }
                    if (Num >= 7110 && Num < 7125)
                    {
                        MeanW = 58.0634;
                        SDW = 12.2705;
                    }
                    if (Num >= 7125 && Num < 7140)
                    {
                        MeanW = 58.0945;
                        SDW = 12.2805;
                    }
                    if (Num >= 7140 && Num < 7155)
                    {
                        MeanW = 58.1238;
                        SDW = 12.2902;
                    }
                    if (Num >= 7155 && Num < 7170)
                    {
                        MeanW = 58.151;
                        SDW = 12.2995;
                    }
                    if (Num >= 7170 && Num < 7185)
                    {
                        MeanW = 58.1761;
                        SDW = 12.3085;
                    }
                    if (Num >= 7185 && Num < 7200)
                    {
                        MeanW = 58.1988;
                        SDW = 12.3171;
                    }
                    if (Num >= 7200 && Num < 7215)
                    {
                        MeanW = 58.219;
                        SDW = 12.3254;
                    }
                    if (Num >= 7215 && Num < 7230)
                    {
                        MeanW = 58.2365;
                        SDW = 12.3333;
                    }


                    //female lenght
                    if (Num >= 0 && Num < 7)
                    {
                        MeanL = 49.14;
                        SDL = 1.86;

                    }
                    else if (Num >= 7 && Num < 14)
                    {
                        MeanL = 50.32;
                        SDL = 1.88;
                    }
                    else if (Num >= 14 && Num < 22)
                    {
                        MeanL = 51.51;
                        SDL = 1.90;
                    }
                    else if (Num >= 22 && Num < 30)
                    {
                        MeanL = 52.46;
                        SDL = 1.92;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanL = 53.6872;
                        SDL = 1.9542;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanL = 57.0673;
                        SDL = 2.0362;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanL = 59.8029;
                        SDL = 2.1051;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanL = 62.0899;
                        SDL = 2.1645;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanL = 64.0301;
                        SDL = 2.2174;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanL = 65.7311;
                        SDL = 2.2664;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanL = 67.2873;
                        SDL = 2.3154;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanL = 68.7498;
                        SDL = 2.365;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanL = 70.1435;
                        SDL = 2.4157;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanL = 71.4818;
                        SDL = 2.4676;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanL = 72.771;
                        SDL = 2.5208;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanL = 74.015;
                        SDL = 2.575;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanL = 75.2176;
                        SDL = 2.6296;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanL = 76.3817;
                        SDL = 2.6841;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanL = 77.5099;
                        SDL = 2.7392;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanL = 78.6055;
                        SDL = 2.7944;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanL = 79.671;
                        SDL = 2.849;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanL = 80.7079;
                        SDL = 2.9039;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanL = 81.7182;
                        SDL = 2.9582;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanL = 82.7036;
                        SDL = 3.0129;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanL = 83.6654;
                        SDL = 3.0672;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanL = 84.604;
                        SDL = 3.1202;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanL = 85.5202;
                        SDL = 3.1737;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanL = 85.7153;
                        SDL = 3.2267;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanL = 86.5904;
                        SDL = 3.2783;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanL = 87.4462;
                        SDL = 3.33;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanL = 88.283;
                        SDL = 3.3812;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanL = 89.1004;
                        SDL = 3.4313;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanL = 89.8991;
                        SDL = 3.4809;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanL = 90.6797;
                        SDL = 3.5302;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanL = 91.443;
                        SDL = 3.5782;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanL = 92.1906;
                        SDL = 3.6259;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanL = 92.9239;
                        SDL = 3.6724;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanL = 93.6444;
                        SDL = 3.7186;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanL = 94.3533;
                        SDL = 3.7638;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanL = 95.0515;
                        SDL = 3.8078;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanL = 95.7399;
                        SDL = 3.8526;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanL = 96.4187;
                        SDL = 3.8963;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanL = 97.0885;
                        SDL = 3.9389;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanL = 97.7493;
                        SDL = 3.9813;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanL = 98.4015;
                        SDL = 4.0236;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanL = 99.0448;
                        SDL = 4.0658;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanL = 99.6795;
                        SDL = 4.1068;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanL = 100.306;
                        SDL = 4.1476;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanL = 100.924;
                        SDL = 4.1883;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanL = 101.534;
                        SDL = 4.2279;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanL = 102.136;
                        SDL = 4.2683;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanL = 102.731;
                        SDL = 4.3075;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanL = 103.32;
                        SDL = 4.3456;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanL = 103.902;
                        SDL = 4.3847;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanL = 104.479;
                        SDL = 4.4226;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanL = 105.049;
                        SDL = 4.4604;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanL = 105.615;
                        SDL = 4.4981;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanL = 106.175;
                        SDL = 4.5358;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanL = 106.73;
                        SDL = 4.5734;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanL = 107.279;
                        SDL = 4.6108;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanL = 107.823;
                        SDL = 4.6472;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanL = 108.361;
                        SDL = 4.6834;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanL = 108.895;
                        SDL = 4.7195;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanL = 109.423;
                        SDL = 4.7566;
                    }
                    if (Num >= 1830 && Num < 1860)
                    {
                        MeanL = 109.601600;
                        SDL = 4.773100;
                    }
                    if (Num >= 1860 && Num < 1890)
                    {
                        MeanL = 110.125800;
                        SDL = 4.805900;
                    }
                    if (Num >= 1890 && Num < 1920)
                    {
                        MeanL = 110.645100;
                        SDL = 4.838500;
                    }
                    if (Num >= 1920 && Num < 1950)
                    {
                        MeanL = 111.159600;
                        SDL = 4.871000;
                    }
                    if (Num >= 1950 && Num < 1980)
                    {
                        MeanL = 111.669600;
                        SDL = 4.902300;
                    }
                    if (Num >= 1980 && Num < 2010)
                    {
                        MeanL = 112.175300;
                        SDL = 4.934600;
                    }
                    if (Num >= 2010 && Num < 2040)
                    {
                        MeanL = 112.676700;
                        SDL = 4.965700;
                    }
                    if (Num >= 2040 && Num < 2070)
                    {
                        MeanL = 113.174000;
                        SDL = 4.996600;
                    }
                    if (Num >= 2070 && Num < 2100)
                    {
                        MeanL = 113.667200;
                        SDL = 5.027500;
                    }
                    if (Num >= 2100 && Num < 2130)
                    {
                        MeanL = 114.156500;
                        SDL = 5.058300;
                    }
                    if (Num >= 2130 && Num < 2160)
                    {
                        MeanL = 114.642100;
                        SDL = 5.089000;
                    }
                    if (Num >= 2160 && Num < 2190)
                    {
                        MeanL = 115.124400;
                        SDL = 5.119600;
                    }
                    if (Num >= 2190 && Num < 2220)
                    {
                        MeanL = 115.603900;
                        SDL = 5.149000;
                    }
                    if (Num >= 2220 && Num < 2250)
                    {
                        MeanL = 116.081200;
                        SDL = 5.178400;
                    }
                    if (Num >= 2250 && Num < 2280)
                    {
                        MeanL = 116.556800;
                        SDL = 5.208900;
                    }
                    if (Num >= 2280 && Num < 2310)
                    {
                        MeanL = 117.031100;
                        SDL = 5.237100;
                    }
                    if (Num >= 2310 && Num < 2340)
                    {
                        MeanL = 117.504400;
                        SDL = 5.266500;
                    }
                    if (Num >= 2340 && Num < 2370)
                    {
                        MeanL = 117.976900;
                        SDL = 5.296000;
                    }
                    if (Num >= 2370 && Num < 2400)
                    {
                        MeanL = 118.448900;
                        SDL = 5.324300;
                    }
                    if (Num >= 2400 && Num < 2430)
                    {
                        MeanL = 118.920800;
                        SDL = 5.353800;
                    }
                    if (Num >= 2430 && Num < 2460)
                    {
                        MeanL = 119.392600;
                        SDL = 5.382200;
                    }
                    if (Num >= 2460 && Num < 2490)
                    {
                        MeanL = 119.864800;
                        SDL = 5.410700;
                    }
                    if (Num >= 2490 && Num < 2520)
                    {
                        MeanL = 120.337400;
                        SDL = 5.439300;
                    }
                    if (Num >= 2520 && Num < 2550)
                    {
                        MeanL = 120.810500;
                        SDL = 5.466700;
                    }
                    if (Num >= 2550 && Num < 2580)
                    {
                        MeanL = 121.284300;
                        SDL = 5.495400;
                    }
                    if (Num >= 2580 && Num < 2610)
                    {
                        MeanL = 121.758700;
                        SDL = 5.523000;
                    }
                    if (Num >= 2610 && Num < 2640)
                    {
                        MeanL = 122.233800;
                        SDL = 5.551900;
                    }
                    if (Num >= 2640 && Num < 2670)
                    {
                        MeanL = 122.709800;
                        SDL = 5.579600;
                    }
                    if (Num >= 2670 && Num < 2700)
                    {
                        MeanL = 123.186800;
                        SDL = 5.606200;
                    }
                    if (Num >= 2700 && Num < 2730)
                    {
                        MeanL = 123.664600;
                        SDL = 5.634200;
                    }
                    if (Num >= 2730 && Num < 2760)
                    {
                        MeanL = 124.143500;
                        SDL = 5.662200;
                    }
                    if (Num >= 2760 && Num < 2790)
                    {
                        MeanL = 124.623400;
                        SDL = 5.689100;
                    }
                    if (Num >= 2790 && Num < 2820)
                    {
                        MeanL = 125.104500;
                        SDL = 5.716000;
                    }
                    if (Num >= 2820 && Num < 2850)
                    {
                        MeanL = 125.586900;
                        SDL = 5.743100;
                    }
                    if (Num >= 2850 && Num < 2880)
                    {
                        MeanL = 126.070600;
                        SDL = 5.770300;
                    }
                    if (Num >= 2880 && Num < 2910)
                    {
                        MeanL = 126.555800;
                        SDL = 5.797500;
                    }
                    if (Num >= 2910 && Num < 2940)
                    {
                        MeanL = 127.042400;
                        SDL = 5.824900;
                    }
                    if (Num >= 2940 && Num < 2970)
                    {
                        MeanL = 127.530400;
                        SDL = 5.851100;
                    }
                    if (Num >= 2970 && Num < 3000)
                    {
                        MeanL = 128.019900;
                        SDL = 5.877400;
                    }
                    if (Num >= 3000 && Num < 3030)
                    {
                        MeanL = 128.510900;
                        SDL = 5.903800;
                    }
                    if (Num >= 3030 && Num < 3060)
                    {
                        MeanL = 129.003500;
                        SDL = 5.930300;
                    }
                    if (Num >= 3060 && Num < 3090)
                    {
                        MeanL = 129.497500;
                        SDL = 5.956900;
                    }
                    if (Num >= 3090 && Num < 3120)
                    {
                        MeanL = 129.993200;
                        SDL = 5.982300;
                    }
                    if (Num >= 3120 && Num < 3150)
                    {
                        MeanL = 130.490400;
                        SDL = 6.007800;
                    }
                    if (Num >= 3150 && Num < 3180)
                    {
                        MeanL = 130.989100;
                        SDL = 6.034700;
                    }
                    if (Num >= 3180 && Num < 3210)
                    {
                        MeanL = 131.489500;
                        SDL = 6.059000;
                    }
                    if (Num >= 3210 && Num < 3240)
                    {
                        MeanL = 131.991200;
                        SDL = 6.084800;
                    }
                    if (Num >= 3240 && Num < 3270)
                    {
                        MeanL = 132.494400;
                        SDL = 6.110600;
                    }
                    if (Num >= 3270 && Num < 3300)
                    {
                        MeanL = 132.998900;
                        SDL = 6.135200;
                    }
                    if (Num >= 3300 && Num < 3330)
                    {
                        MeanL = 133.504600;
                        SDL = 6.159900;
                    }
                    if (Num >= 3330 && Num < 3360)
                    {
                        MeanL = 134.011800;
                        SDL = 6.184600;
                    }
                    if (Num >= 3360 && Num < 3390)
                    {
                        MeanL = 134.520200;
                        SDL = 6.209500;
                    }
                    if (Num >= 3390 && Num < 3420)
                    {
                        MeanL = 135.029900;
                        SDL = 6.233000;
                    }
                    if (Num >= 3420 && Num < 3450)
                    {
                        MeanL = 135.541000;
                        SDL = 6.257900;
                    }
                    if (Num >= 3450 && Num < 3480)
                    {
                        MeanL = 136.053300;
                        SDL = 6.281600;
                    }
                    if (Num >= 3480 && Num < 3510)
                    {
                        MeanL = 136.567000;
                        SDL = 6.303900;
                    }
                    if (Num >= 3510 && Num < 3540)
                    {
                        MeanL = 137.082100;
                        SDL = 6.327700;
                    }
                    if (Num >= 3540 && Num < 3570)
                    {
                        MeanL = 137.598700;
                        SDL = 6.351600;
                    }
                    if (Num >= 3570 && Num < 3600)
                    {
                        MeanL = 138.116700;
                        SDL = 6.374100;
                    }
                    if (Num >= 3600 && Num < 3630)
                    {
                        MeanL = 138.636300;
                        SDL = 6.396700;
                    }
                    if (Num >= 3630 && Num < 3660)
                    {
                        MeanL = 139.157500;
                        SDL = 6.417900;
                    }
                    if (Num >= 3660 && Num < 3690)
                    {
                        MeanL = 139.680300;
                        SDL = 6.440700;
                    }
                    if (Num >= 3690 && Num < 3720)
                    {
                        MeanL = 140.204900;
                        SDL = 6.462000;
                    }
                    if (Num >= 3720 && Num < 3750)
                    {
                        MeanL = 140.731300;
                        SDL = 6.483500;
                    }
                    if (Num >= 3750 && Num < 3780)
                    {
                        MeanL = 141.259400;
                        SDL = 6.505000;
                    }
                    if (Num >= 3780 && Num < 3810)
                    {
                        MeanL = 141.789200;
                        SDL = 6.526600;
                    }
                    if (Num >= 3810 && Num < 3840)
                    {
                        MeanL = 142.320600;
                        SDL = 6.546700;
                    }
                    if (Num >= 3840 && Num < 3870)
                    {
                        MeanL = 142.853400;
                        SDL = 6.567000;
                    }
                    if (Num >= 3870 && Num < 3900)
                    {
                        MeanL = 143.387400;
                        SDL = 6.587200;
                    }
                    if (Num >= 3900 && Num < 3930)
                    {
                        MeanL = 143.922200;
                        SDL = 6.607500;
                    }
                    if (Num >= 3930 && Num < 3960)
                    {
                        MeanL = 144.457500;
                        SDL = 6.627700;
                    }
                    if (Num >= 3960 && Num < 3990)
                    {
                        MeanL = 144.992900;
                        SDL = 6.646500;
                    }
                    if (Num >= 3990 && Num < 4020)
                    {
                        MeanL = 145.528000;
                        SDL = 6.665200;
                    }
                    if (Num >= 4020 && Num < 4050)
                    {
                        MeanL = 146.062200;
                        SDL = 6.683800;
                    }
                    if (Num >= 4050 && Num < 4080)
                    {
                        MeanL = 146.595100;
                        SDL = 6.700900;
                    }
                    if (Num >= 4080 && Num < 4110)
                    {
                        MeanL = 147.126200;
                        SDL = 6.719300;
                    }
                    if (Num >= 4110 && Num < 4140)
                    {
                        MeanL = 147.654800;
                        SDL = 6.736000;
                    }
                    if (Num >= 4140 && Num < 4170)
                    {
                        MeanL = 148.180400;
                        SDL = 6.752600;
                    }
                    if (Num >= 4170 && Num < 4200)
                    {
                        MeanL = 148.702300;
                        SDL = 6.768900;
                    }
                    if (Num >= 4200 && Num < 4230)
                    {
                        MeanL = 149.219700;
                        SDL = 6.783500;
                    }
                    if (Num >= 4230 && Num < 4260)
                    {
                        MeanL = 149.732200;
                        SDL = 6.799300;
                    }
                    if (Num >= 4260 && Num < 4290)
                    {
                        MeanL = 150.239000;
                        SDL = 6.813300;
                    }
                    if (Num >= 4290 && Num < 4320)
                    {
                        MeanL = 150.739400;
                        SDL = 6.827000;
                    }
                    if (Num >= 4320 && Num < 4350)
                    {
                        MeanL = 151.232700;
                        SDL = 6.840300;
                    }
                    if (Num >= 4350 && Num < 4380)
                    {
                        MeanL = 151.718200;
                        SDL = 6.851600;
                    }
                    if (Num >= 4380 && Num < 4410)
                    {
                        MeanL = 152.195100;
                        SDL = 6.864000;
                    }
                    if (Num >= 4410 && Num < 4440)
                    {
                        MeanL = 152.662800;
                        SDL = 6.874400;
                    }
                    if (Num >= 4440 && Num < 4470)
                    {
                        MeanL = 153.120600;
                        SDL = 6.885800;
                    }
                    if (Num >= 4470 && Num < 4500)
                    {
                        MeanL = 153.567800;
                        SDL = 6.895200;
                    }
                    if (Num >= 4500 && Num < 4530)
                    {
                        MeanL = 154.004100;
                        SDL = 6.904000;
                    }
                    if (Num >= 4530 && Num < 4560)
                    {
                        MeanL = 154.429000;
                        SDL = 6.912200;
                    }
                    if (Num >= 4560 && Num < 4590)
                    {
                        MeanL = 154.842300;
                        SDL = 6.918400;
                    }
                    if (Num >= 4590 && Num < 4620)
                    {
                        MeanL = 155.243700;
                        SDL = 6.925400;
                    }
                    if (Num >= 4620 && Num < 4650)
                    {
                        MeanL = 155.633000;
                        SDL = 6.931900;
                    }
                    if (Num >= 4650 && Num < 4680)
                    {
                        MeanL = 156.010100;
                        SDL = 6.936200;
                    }
                    if (Num >= 4680 && Num < 4710)
                    {
                        MeanL = 156.374800;
                        SDL = 6.941500;
                    }
                    if (Num >= 4710 && Num < 4740)
                    {
                        MeanL = 156.726900;
                        SDL = 6.944600;
                    }
                    if (Num >= 4740 && Num < 4770)
                    {
                        MeanL = 157.066600;
                        SDL = 6.947100;
                    }
                    if (Num >= 4770 && Num < 4800)
                    {
                        MeanL = 157.393600;
                        SDL = 6.948900;
                    }
                    if (Num >= 4800 && Num < 4830)
                    {
                        MeanL = 157.708200;
                        SDL = 6.951800;
                    }
                    if (Num >= 4830 && Num < 4860)
                    {
                        MeanL = 158.010200;
                        SDL = 6.952400;
                    }
                    if (Num >= 4860 && Num < 4890)
                    {
                        MeanL = 158.299700;
                        SDL = 6.952500;
                    }
                    if (Num >= 4890 && Num < 4920)
                    {
                        MeanL = 158.577100;
                        SDL = 6.952000;
                    }
                    if (Num >= 4920 && Num < 4950)
                    {
                        MeanL = 158.842500;
                        SDL = 6.950900;
                    }
                    if (Num >= 4950 && Num < 4980)
                    {
                        MeanL = 159.096100;
                        SDL = 6.950900;
                    }
                    if (Num >= 4980 && Num < 5010)
                    {
                        MeanL = 159.338200;
                        SDL = 6.948700;
                    }
                    if (Num >= 5010 && Num < 5040)
                    {
                        MeanL = 159.569100;
                        SDL = 6.946000;
                    }
                    if (Num >= 5040 && Num < 5070)
                    {
                        MeanL = 159.789000;
                        SDL = 6.942800;
                    }
                    if (Num >= 5070 && Num < 5100)
                    {
                        MeanL = 159.998300;
                        SDL = 6.939100;
                    }
                    if (Num >= 5100 && Num < 5130)
                    {
                        MeanL = 160.197100;
                        SDL = 6.936500;
                    }
                    if (Num >= 5130 && Num < 5160)
                    {
                        MeanL = 160.385700;
                        SDL = 6.931900;
                    }
                    if (Num >= 5160 && Num < 5190)
                    {
                        MeanL = 160.564300;
                        SDL = 6.926700;
                    }
                    if (Num >= 5190 && Num < 5220)
                    {
                        MeanL = 160.733200;
                        SDL = 6.922800;
                    }
                    if (Num >= 5220 && Num < 5250)
                    {
                        MeanL = 160.892700;
                        SDL = 6.916800;
                    }
                    if (Num >= 5250 && Num < 5280)
                    {
                        MeanL = 161.043000;
                        SDL = 6.912000;
                    }
                    if (Num >= 5280 && Num < 5310)
                    {
                        MeanL = 161.184500;
                        SDL = 6.905100;
                    }
                    if (Num >= 5310 && Num < 5340)
                    {
                        MeanL = 161.317600;
                        SDL = 6.899600;
                    }
                    if (Num >= 5340 && Num < 5370)
                    {
                        MeanL = 161.442500;
                        SDL = 6.893600;
                    }
                    if (Num >= 5370 && Num < 5400)
                    {
                        MeanL = 161.559600;
                        SDL = 6.887300;
                    }
                    if (Num >= 5400 && Num < 5430)
                    {
                        MeanL = 161.669200;
                        SDL = 6.879000;
                    }
                    if (Num >= 5430 && Num < 5460)
                    {
                        MeanL = 161.771700;
                        SDL = 6.872100;
                    }
                    if (Num >= 5460 && Num < 5490)
                    {
                        MeanL = 161.867300;
                        SDL = 6.864800;
                    }
                    if (Num >= 5490 && Num < 5520)
                    {
                        MeanL = 161.956400;
                        SDL = 6.858900;
                    }
                    if (Num >= 5520 && Num < 5550)
                    {
                        MeanL = 162.039300;
                        SDL = 6.851000;
                    }
                    if (Num >= 5550 && Num < 5580)
                    {
                        MeanL = 162.116400;
                        SDL = 6.842900;
                    }
                    if (Num >= 5580 && Num < 5610)
                    {
                        MeanL = 162.188000;
                        SDL = 6.834600;
                    }
                    if (Num >= 5610 && Num < 5640)
                    {
                        MeanL = 162.254200;
                        SDL = 6.827700;
                    }
                    if (Num >= 5640 && Num < 5670)
                    {
                        MeanL = 162.315400;
                        SDL = 6.818900;
                    }
                    if (Num >= 5670 && Num < 5700)
                    {
                        MeanL = 162.371900;
                        SDL = 6.811500;
                    }
                    if (Num >= 5700 && Num < 5730)
                    {
                        MeanL = 162.423900;
                        SDL = 6.803900;
                    }
                    if (Num >= 5730 && Num < 5760)
                    {
                        MeanL = 162.471700;
                        SDL = 6.794600;
                    }
                    if (Num >= 5760 && Num < 5790)
                    {
                        MeanL = 162.515600;
                        SDL = 6.786700;
                    }
                    if (Num >= 5790 && Num < 5820)
                    {
                        MeanL = 162.556000;
                        SDL = 6.778600;
                    }
                    if (Num >= 5820 && Num < 5850)
                    {
                        MeanL = 162.593300;
                        SDL = 6.770400;
                    }
                    if (Num >= 5850 && Num < 5880)
                    {
                        MeanL = 162.627600;
                        SDL = 6.762100;
                    }
                    if (Num >= 5880 && Num < 5910)
                    {
                        MeanL = 162.659400;
                        SDL = 6.753600;
                    }
                    if (Num >= 5910 && Num < 5940)
                    {
                        MeanL = 162.689000;
                        SDL = 6.746700;
                    }
                    if (Num >= 5940 && Num < 5970)
                    {
                        MeanL = 162.716500;
                        SDL = 6.738100;
                    }
                    if (Num >= 5970 && Num < 6000)
                    {
                        MeanL = 162.742500;
                        SDL = 6.731000;
                    }
                    if (Num >= 6000 && Num < 6030)
                    {
                        MeanL = 162.767000;
                        SDL = 6.722300;
                    }
                    if (Num >= 6030 && Num < 6060)
                    {
                        MeanL = 162.790400;
                        SDL = 6.715100;
                    }
                    if (Num >= 6060 && Num < 6090)
                    {
                        MeanL = 162.812600;
                        SDL = 6.706300;
                    }
                    if (Num >= 6090 && Num < 6120)
                    {
                        MeanL = 162.834000;
                        SDL = 6.699000;
                    }
                    if (Num >= 6120 && Num < 6150)
                    {
                        MeanL = 162.854500;
                        SDL = 6.691700;
                    }
                    if (Num >= 6150 && Num < 6180)
                    {
                        MeanL = 162.874300;
                        SDL = 6.684400;
                    }
                    if (Num >= 6180 && Num < 6210)
                    {
                        MeanL = 162.893500;
                        SDL = 6.677000;
                    }
                    if (Num >= 6210 && Num < 6240)
                    {
                        MeanL = 162.912000;
                        SDL = 6.669600;
                    }
                    if (Num >= 6240 && Num < 6270)
                    {
                        MeanL = 162.930000;
                        SDL = 6.662200;
                    }
                    if (Num >= 6270 && Num < 6300)
                    {
                        MeanL = 162.947600;
                        SDL = 6.654800;
                    }
                    if (Num >= 6300 && Num < 6330)
                    {
                        MeanL = 162.964900;
                        SDL = 6.649000;
                    }
                    if (Num >= 6330 && Num < 6360)
                    {
                        MeanL = 162.981700;
                        SDL = 6.641500;
                    }
                    if (Num >= 6360 && Num < 6390)
                    {
                        MeanL = 162.998300;
                        SDL = 6.635700;
                    }
                    if (Num >= 6390 && Num < 6420)
                    {
                        MeanL = 163.014400;
                        SDL = 6.628200;
                    }
                    if (Num >= 6420 && Num < 6450)
                    {
                        MeanL = 163.030000;
                        SDL = 6.622300;
                    }
                    if (Num >= 6450 && Num < 6480)
                    {
                        MeanL = 163.045100;
                        SDL = 6.616400;
                    }
                    if (Num >= 6480 && Num < 6510)
                    {
                        MeanL = 163.059500;
                        SDL = 6.608800;
                    }
                    if (Num >= 6510 && Num < 6540)
                    {
                        MeanL = 163.073300;
                        SDL = 6.602800;
                    }
                    if (Num >= 6540 && Num < 6570)
                    {
                        MeanL = 163.086200;
                        SDL = 6.596800;
                    }
                    if (Num >= 6570 && Num < 6600)
                    {
                        MeanL = 163.098200;
                        SDL = 6.590800;
                    }
                    if (Num >= 6600 && Num < 6630)
                    {
                        MeanL = 163.109200;
                        SDL = 6.584700;
                    }
                    if (Num >= 6630 && Num < 6660)
                    {
                        MeanL = 163.119200;
                        SDL = 6.580200;
                    }
                    if (Num >= 6660 && Num < 6690)
                    {
                        MeanL = 163.127900;
                        SDL = 6.574100;
                    }
                    if (Num >= 6690 && Num < 6720)
                    {
                        MeanL = 163.135500;
                        SDL = 6.567800;
                    }
                    if (Num >= 6720 && Num < 6750)
                    {
                        MeanL = 163.141800;
                        SDL = 6.563200;
                    }
                    if (Num >= 6750 && Num < 6780)
                    {
                        MeanL = 163.146900;
                        SDL = 6.556900;
                    }
                    if (Num >= 6780 && Num < 6810)
                    {
                        MeanL = 163.150800;
                        SDL = 6.552100;
                    }
                    if (Num >= 6810 && Num < 6840)
                    {
                        MeanL = 163.153400;
                        SDL = 6.545700;
                    }
                    if (Num >= 6840 && Num < 6870)
                    {
                        MeanL = 163.154800;
                        SDL = 6.540900;
                    }
                    //femaile bmi/age
                    if (Num >= 0 && Num < 7)
                    {
                        MeanBMI = 13.33;
                        SDBMI = 1.3;

                    }
                    if (Num >= 7 && Num < 14)
                    {
                        MeanBMI = 13.21;
                        SDBMI = 1.3;
                    }
                    if (Num >= 14 && Num < 22)
                    {
                        MeanBMI = 13.45;
                        SDBMI = 1.3;
                    }
                    if (Num >= 22 && Num < 30)
                    {
                        MeanBMI = 13.95;
                        SDBMI = 1.3;
                    }
                    if (Num >= 30 && Num < 60)
                    {
                        MeanBMI = 14.5679;
                        SDBMI = 1.4321;
                    }
                    if (Num >= 60 && Num < 90)
                    {
                        MeanBMI = 15.7679;
                        SDBMI = 1.5321;
                    }
                    if (Num >= 90 && Num < 120)
                    {
                        MeanBMI = 16.3574;
                        SDBMI = 1.5426;
                    }
                    if (Num >= 120 && Num < 150)
                    {
                        MeanBMI = 16.6703;
                        SDBMI = 1.6297;
                    }
                    if (Num >= 150 && Num < 180)
                    {
                        MeanBMI = 16.8386;
                        SDBMI = 1.5614;
                    }
                    if (Num >= 180 && Num < 210)
                    {
                        MeanBMI = 16.9083;
                        SDBMI = 1.5917;
                    }
                    if (Num >= 210 && Num < 240)
                    {
                        MeanBMI = 16.902;
                        SDBMI = 1.598;
                    }
                    if (Num >= 240 && Num < 270)
                    {
                        MeanBMI = 16.8404;
                        SDBMI = 1.5596;
                    }
                    if (Num >= 270 && Num < 300)
                    {
                        MeanBMI = 16.7406;
                        SDBMI = 1.5594;
                    }
                    if (Num >= 300 && Num < 330)
                    {
                        MeanBMI = 16.6184;
                        SDBMI = 1.5816;
                    }
                    if (Num >= 330 && Num < 360)
                    {
                        MeanBMI = 16.4875;
                        SDBMI = 1.5125;
                    }
                    if (Num >= 360 && Num < 390)
                    {
                        MeanBMI = 16.3568;
                        SDBMI = 1.5432;
                    }
                    if (Num >= 390 && Num < 420)
                    {
                        MeanBMI = 16.2311;
                        SDBMI = 1.4689;
                    }
                    if (Num >= 420 && Num < 450)
                    {
                        MeanBMI = 16.1128;
                        SDBMI = 1.4872;
                    }
                    if (Num >= 450 && Num < 480)
                    {
                        MeanBMI = 16.0028;
                        SDBMI = 1.4972;
                    }
                    if (Num >= 480 && Num < 510)
                    {
                        MeanBMI = 15.9017;
                        SDBMI = 1.4983;
                    }
                    if (Num >= 510 && Num < 540)
                    {
                        MeanBMI = 15.8096;
                        SDBMI = 1.4904;
                    }
                    if (Num >= 540 && Num < 570)
                    {
                        MeanBMI = 15.7263;
                        SDBMI = 1.4737;
                    }
                    if (Num >= 570 && Num < 600)
                    {
                        MeanBMI = 15.6517;
                        SDBMI = 1.4483;
                    }
                    if (Num >= 600 && Num < 630)
                    {
                        MeanBMI = 15.5855;
                        SDBMI = 1.4145;
                    }
                    if (Num >= 630 && Num < 660)
                    {
                        MeanBMI = 15.5278;
                        SDBMI = 1.4722;
                    }
                    if (Num >= 660 && Num < 690)
                    {
                        MeanBMI = 15.4787;
                        SDBMI = 1.4213;
                    }
                    if (Num >= 690 && Num < 720)
                    {
                        MeanBMI = 15.438;
                        SDBMI = 1.462;
                    }
                    if (Num >= 720 && Num < 750)
                    {
                        MeanBMI = 15.6881;
                        SDBMI = 1.4119;
                    }
                    if (Num >= 750 && Num < 780)
                    {
                        MeanBMI = 15.659;
                        SDBMI = 1.441;
                    }
                    if (Num >= 780 && Num < 810)
                    {
                        MeanBMI = 15.6308;
                        SDBMI = 1.3692;
                    }
                    if (Num >= 810 && Num < 840)
                    {
                        MeanBMI = 15.6037;
                        SDBMI = 1.3963;
                    }
                    if (Num >= 840 && Num < 870)
                    {
                        MeanBMI = 15.5777;
                        SDBMI = 1.4223;
                    }
                    if (Num >= 870 && Num < 900)
                    {
                        MeanBMI = 15.5523;
                        SDBMI = 1.4477;
                    }
                    if (Num >= 900 && Num < 930)
                    {
                        MeanBMI = 15.5276;
                        SDBMI = 1.3724;
                    }
                    if (Num >= 930 && Num < 960)
                    {
                        MeanBMI = 15.5034;
                        SDBMI = 1.3966;
                    }
                    if (Num >= 960 && Num < 990)
                    {
                        MeanBMI = 15.4798;
                        SDBMI = 1.4202;
                    }
                    if (Num >= 990 && Num < 1020)
                    {
                        MeanBMI = 15.4572;
                        SDBMI = 1.4428;
                    }
                    if (Num >= 1020 && Num < 1050)
                    {
                        MeanBMI = 15.4356;
                        SDBMI = 1.3644;
                    }
                    if (Num >= 1050 && Num < 1080)
                    {
                        MeanBMI = 15.4155;
                        SDBMI = 1.3845;
                    }
                    if (Num >= 1080 && Num < 1110)
                    {
                        MeanBMI = 15.3968;
                        SDBMI = 1.4032;
                    }
                    if (Num >= 1110 && Num < 1140)
                    {
                        MeanBMI = 15.3796;
                        SDBMI = 1.4204;
                    }
                    if (Num >= 1140 && Num < 1170)
                    {
                        MeanBMI = 15.3638;
                        SDBMI = 1.4362;
                    }
                    if (Num >= 1170 && Num < 1200)
                    {
                        MeanBMI = 15.3493;
                        SDBMI = 1.4507;
                    }
                    if (Num >= 1200 && Num < 1230)
                    {
                        MeanBMI = 15.3358;
                        SDBMI = 1.4642;
                    }
                    if (Num >= 1230 && Num < 1260)
                    {
                        MeanBMI = 15.3233;
                        SDBMI = 1.4767;
                    }
                    if (Num >= 1260 && Num < 1290)
                    {
                        MeanBMI = 15.3116;
                        SDBMI = 1.4884;
                    }
                    if (Num >= 1290 && Num < 1320)
                    {
                        MeanBMI = 15.3007;
                        SDBMI = 1.4993;
                    }
                    if (Num >= 1320 && Num < 1350)
                    {
                        MeanBMI = 15.2905;
                        SDBMI = 1.5095;
                    }
                    if (Num >= 1350 && Num < 1380)
                    {
                        MeanBMI = 15.2814;
                        SDBMI = 1.5186;
                    }
                    if (Num >= 1380 && Num < 1410)
                    {
                        MeanBMI = 15.2732;
                        SDBMI = 1.5268;
                    }
                    if (Num >= 1410 && Num < 1440)
                    {
                        MeanBMI = 15.2661;
                        SDBMI = 1.5339;
                    }
                    if (Num >= 1440 && Num < 1470)
                    {
                        MeanBMI = 15.2602;
                        SDBMI = 1.5398;
                    }
                    if (Num >= 1470 && Num < 1500)
                    {
                        MeanBMI = 15.2556;
                        SDBMI = 1.5444;
                    }
                    if (Num >= 1500 && Num < 1530)
                    {
                        MeanBMI = 15.2523;
                        SDBMI = 1.5477;
                    }
                    if (Num >= 1530 && Num < 1560)
                    {
                        MeanBMI = 15.2503;
                        SDBMI = 1.5497;
                    }
                    if (Num >= 1560 && Num < 1590)
                    {
                        MeanBMI = 15.2496;
                        SDBMI = 1.5504;
                    }
                    if (Num >= 1590 && Num < 1620)
                    {
                        MeanBMI = 15.2502;
                        SDBMI = 1.5498;
                    }
                    if (Num >= 1620 && Num < 1650)
                    {
                        MeanBMI = 15.2519;
                        SDBMI = 1.5481;
                    }
                    if (Num >= 1650 && Num < 1680)
                    {
                        MeanBMI = 15.2544;
                        SDBMI = 1.5456;
                    }
                    if (Num >= 1680 && Num < 1710)
                    {
                        MeanBMI = 15.2575;
                        SDBMI = 1.5425;
                    }
                    if (Num >= 1710 && Num < 1740)
                    {
                        MeanBMI = 15.2612;
                        SDBMI = 1.6388;
                    }
                    if (Num >= 1740 && Num < 1770)
                    {
                        MeanBMI = 15.2653;
                        SDBMI = 1.6347;
                    }
                    if (Num >= 1770 && Num < 1800)
                    {
                        MeanBMI = 15.2698;
                        SDBMI = 1.6302;
                    }
                    if (Num >= 1800 && Num < 1830)
                    {
                        MeanBMI = 15.2747;
                        SDBMI = 1.6253;
                    }
                    if (Num >= 1830 && Num < 1860)
                    {
                        MeanBMI = 15.244100;
                        SDBMI = 1.625900;
                    }
                    if (Num >= 1860 && Num < 1890)
                    {
                        MeanBMI = 15.243400;
                        SDBMI = 1.635600;
                    }
                    if (Num >= 1890 && Num < 1920)
                    {
                        MeanBMI = 15.243300;
                        SDBMI = 1.645700;
                    }
                    if (Num >= 1920 && Num < 1950)
                    {
                        MeanBMI = 15.243800;
                        SDBMI = 1.656200;
                    }
                    if (Num >= 1950 && Num < 1980)
                    {
                        MeanBMI = 15.244800;
                        SDBMI = 1.666200;
                    }
                    if (Num >= 1980 && Num < 2010)
                    {
                        MeanBMI = 15.246400;
                        SDBMI = 1.676600;
                    }
                    if (Num >= 2010 && Num < 2040)
                    {
                        MeanBMI = 15.248700;
                        SDBMI = 1.687300;
                    }
                    if (Num >= 2040 && Num < 2070)
                    {
                        MeanBMI = 15.251600;
                        SDBMI = 1.698400;
                    }
                    if (Num >= 2070 && Num < 2100)
                    {
                        MeanBMI = 15.255100;
                        SDBMI = 1.708900;
                    }
                    if (Num >= 2100 && Num < 2130)
                    {
                        MeanBMI = 15.259200;
                        SDBMI = 1.719800;
                    }
                    if (Num >= 2130 && Num < 2160)
                    {
                        MeanBMI = 15.264100;
                        SDBMI = 1.730900;
                    }
                    if (Num >= 2160 && Num < 2190)
                    {
                        MeanBMI = 15.269700;
                        SDBMI = 1.741300;
                    }
                    if (Num >= 2190 && Num < 2220)
                    {
                        MeanBMI = 15.276000;
                        SDBMI = 1.753000;
                    }
                    if (Num >= 2220 && Num < 2250)
                    {
                        MeanBMI = 15.283100;
                        SDBMI = 1.763900;
                    }
                    if (Num >= 2250 && Num < 2280)
                    {
                        MeanBMI = 15.291100;
                        SDBMI = 1.775900;
                    }
                    if (Num >= 2280 && Num < 2310)
                    {
                        MeanBMI = 15.299800;
                        SDBMI = 1.787200;
                    }
                    if (Num >= 2310 && Num < 2340)
                    {
                        MeanBMI = 15.309500;
                        SDBMI = 1.798500;
                    }
                    if (Num >= 2340 && Num < 2370)
                    {
                        MeanBMI = 15.320000;
                        SDBMI = 1.811000;
                    }
                    if (Num >= 2370 && Num < 2400)
                    {
                        MeanBMI = 15.331400;
                        SDBMI = 1.822600;
                    }
                    if (Num >= 2400 && Num < 2430)
                    {
                        MeanBMI = 15.343900;
                        SDBMI = 1.835100;
                    }
                    if (Num >= 2430 && Num < 2460)
                    {
                        MeanBMI = 15.357200;
                        SDBMI = 1.846800;
                    }
                    if (Num >= 2460 && Num < 2490)
                    {
                        MeanBMI = 15.371700;
                        SDBMI = 1.859300;
                    }
                    if (Num >= 2490 && Num < 2520)
                    {
                        MeanBMI = 15.387100;
                        SDBMI = 1.871900;
                    }
                    if (Num >= 2520 && Num < 2550)
                    {
                        MeanBMI = 15.403600;
                        SDBMI = 1.885400;
                    }
                    if (Num >= 2550 && Num < 2580)
                    {
                        MeanBMI = 15.421100;
                        SDBMI = 1.897900;
                    }
                    if (Num >= 2580 && Num < 2610)
                    {
                        MeanBMI = 15.439700;
                        SDBMI = 1.910300;
                    }
                    if (Num >= 2610 && Num < 2640)
                    {
                        MeanBMI = 15.459300;
                        SDBMI = 1.923700;
                    }
                    if (Num >= 2640 && Num < 2670)
                    {
                        MeanBMI = 15.479800;
                        SDBMI = 1.937200;
                    }
                    if (Num >= 2670 && Num < 2700)
                    {
                        MeanBMI = 15.501400;
                        SDBMI = 1.950600;
                    }
                    if (Num >= 2700 && Num < 2730)
                    {
                        MeanBMI = 15.524000;
                        SDBMI = 1.964000;
                    }
                    if (Num >= 2730 && Num < 2760)
                    {
                        MeanBMI = 15.547600;
                        SDBMI = 1.978400;
                    }
                    if (Num >= 2760 && Num < 2790)
                    {
                        MeanBMI = 15.572300;
                        SDBMI = 1.991700;
                    }
                    if (Num >= 2790 && Num < 2820)
                    {
                        MeanBMI = 15.597900;
                        SDBMI = 2.006100;
                    }
                    if (Num >= 2820 && Num < 2850)
                    {
                        MeanBMI = 15.624600;
                        SDBMI = 2.020400;
                    }
                    if (Num >= 2850 && Num < 2880)
                    {
                        MeanBMI = 15.652300;
                        SDBMI = 2.034700;
                    }
                    if (Num >= 2880 && Num < 2910)
                    {
                        MeanBMI = 15.681000;
                        SDBMI = 2.049000;
                    }
                    if (Num >= 2910 && Num < 2940)
                    {
                        MeanBMI = 15.710700;
                        SDBMI = 2.063300;
                    }
                    if (Num >= 2940 && Num < 2970)
                    {
                        MeanBMI = 15.741500;
                        SDBMI = 2.078500;
                    }
                    if (Num >= 2970 && Num < 3000)
                    {
                        MeanBMI = 15.773200;
                        SDBMI = 2.092800;
                    }
                    if (Num >= 3000 && Num < 3030)
                    {
                        MeanBMI = 15.805800;
                        SDBMI = 2.108200;
                    }
                    if (Num >= 3030 && Num < 3060)
                    {
                        MeanBMI = 15.839400;
                        SDBMI = 2.122600;
                    }
                    if (Num >= 3060 && Num < 3090)
                    {
                        MeanBMI = 15.873800;
                        SDBMI = 2.138200;
                    }
                    if (Num >= 3090 && Num < 3120)
                    {
                        MeanBMI = 15.909000;
                        SDBMI = 2.153000;
                    }
                    if (Num >= 3120 && Num < 3150)
                    {
                        MeanBMI = 15.945100;
                        SDBMI = 2.167900;
                    }
                    if (Num >= 3150 && Num < 3180)
                    {
                        MeanBMI = 15.981800;
                        SDBMI = 2.184200;
                    }
                    if (Num >= 3180 && Num < 3210)
                    {
                        MeanBMI = 16.019400;
                        SDBMI = 2.199600;
                    }
                    if (Num >= 3210 && Num < 3240)
                    {
                        MeanBMI = 16.057500;
                        SDBMI = 2.214500;
                    }
                    if (Num >= 3240 && Num < 3270)
                    {
                        MeanBMI = 16.096400;
                        SDBMI = 2.229600;
                    }
                    if (Num >= 3270 && Num < 3300)
                    {
                        MeanBMI = 16.135800;
                        SDBMI = 2.245200;
                    }
                    if (Num >= 3300 && Num < 3330)
                    {
                        MeanBMI = 16.175900;
                        SDBMI = 2.261100;
                    }
                    if (Num >= 3330 && Num < 3360)
                    {
                        MeanBMI = 16.216600;
                        SDBMI = 2.276400;
                    }
                    if (Num >= 3360 && Num < 3390)
                    {
                        MeanBMI = 16.258000;
                        SDBMI = 2.293000;
                    }
                    if (Num >= 3390 && Num < 3420)
                    {
                        MeanBMI = 16.299900;
                        SDBMI = 2.308100;
                    }
                    if (Num >= 3420 && Num < 3450)
                    {
                        MeanBMI = 16.342500;
                        SDBMI = 2.323500;
                    }
                    if (Num >= 3450 && Num < 3480)
                    {
                        MeanBMI = 16.385800;
                        SDBMI = 2.339200;
                    }
                    if (Num >= 3480 && Num < 3510)
                    {
                        MeanBMI = 16.429800;
                        SDBMI = 2.355200;
                    }
                    if (Num >= 3510 && Num < 3540)
                    {
                        MeanBMI = 16.474600;
                        SDBMI = 2.371400;
                    }
                    if (Num >= 3540 && Num < 3570)
                    {
                        MeanBMI = 16.520000;
                        SDBMI = 2.387000;
                    }
                    if (Num >= 3570 && Num < 3600)
                    {
                        MeanBMI = 16.566300;
                        SDBMI = 2.402700;
                    }
                    if (Num >= 3600 && Num < 3630)
                    {
                        MeanBMI = 16.613300;
                        SDBMI = 2.418700;
                    }
                    if (Num >= 3630 && Num < 3660)
                    {
                        MeanBMI = 16.661200;
                        SDBMI = 2.434800;
                    }
                    if (Num >= 3660 && Num < 3690)
                    {
                        MeanBMI = 16.710000;
                        SDBMI = 2.451000;
                    }
                    if (Num >= 3690 && Num < 3720)
                    {
                        MeanBMI = 16.759500;
                        SDBMI = 2.466500;
                    }
                    if (Num >= 3720 && Num < 3750)
                    {
                        MeanBMI = 16.810000;
                        SDBMI = 2.483000;
                    }
                    if (Num >= 3750 && Num < 3780)
                    {
                        MeanBMI = 16.861400;
                        SDBMI = 2.498600;
                    }
                    if (Num >= 3780 && Num < 3810)
                    {
                        MeanBMI = 16.913600;
                        SDBMI = 2.515400;
                    }
                    if (Num >= 3810 && Num < 3840)
                    {
                        MeanBMI = 16.966700;
                        SDBMI = 2.531300;
                    }
                    if (Num >= 3840 && Num < 3870)
                    {
                        MeanBMI = 17.020800;
                        SDBMI = 2.547200;
                    }
                    if (Num >= 3870 && Num < 3900)
                    {
                        MeanBMI = 17.075700;
                        SDBMI = 2.563300;
                    }
                    if (Num >= 3900 && Num < 3930)
                    {
                        MeanBMI = 17.131600;
                        SDBMI = 2.580400;
                    }
                    if (Num >= 3930 && Num < 3960)
                    {
                        MeanBMI = 17.188300;
                        SDBMI = 2.596700;
                    }
                    if (Num >= 3960 && Num < 3990)
                    {
                        MeanBMI = 17.245900;
                        SDBMI = 2.613100;
                    }
                    if (Num >= 3990 && Num < 4020)
                    {
                        MeanBMI = 17.304400;
                        SDBMI = 2.628600;
                    }
                    if (Num >= 4020 && Num < 4050)
                    {
                        MeanBMI = 17.363700;
                        SDBMI = 2.645300;
                    }
                    if (Num >= 4050 && Num < 4080)
                    {
                        MeanBMI = 17.423800;
                        SDBMI = 2.662200;
                    }
                    if (Num >= 4080 && Num < 4110)
                    {
                        MeanBMI = 17.484700;
                        SDBMI = 2.678300;
                    }
                    if (Num >= 4110 && Num < 4140)
                    {
                        MeanBMI = 17.546400;
                        SDBMI = 2.694600;
                    }
                    if (Num >= 4140 && Num < 4170)
                    {
                        MeanBMI = 17.608800;
                        SDBMI = 2.711200;
                    }
                    if (Num >= 4170 && Num < 4200)
                    {
                        MeanBMI = 17.671900;
                        SDBMI = 2.728100;
                    }
                    if (Num >= 4200 && Num < 4230)
                    {
                        MeanBMI = 17.735700;
                        SDBMI = 2.744300;
                    }
                    if (Num >= 4230 && Num < 4260)
                    {
                        MeanBMI = 17.800100;
                        SDBMI = 2.760900;
                    }
                    if (Num >= 4260 && Num < 4290)
                    {
                        MeanBMI = 17.865100;
                        SDBMI = 2.776900;
                    }
                    if (Num >= 4290 && Num < 4320)
                    {
                        MeanBMI = 17.930600;
                        SDBMI = 2.793400;
                    }
                    if (Num >= 4320 && Num < 4350)
                    {
                        MeanBMI = 17.996600;
                        SDBMI = 2.809400;
                    }
                    if (Num >= 4350 && Num < 4380)
                    {
                        MeanBMI = 18.063000;
                        SDBMI = 2.826000;
                    }
                    if (Num >= 4380 && Num < 4410)
                    {
                        MeanBMI = 18.129700;
                        SDBMI = 2.842300;
                    }
                    if (Num >= 4410 && Num < 4440)
                    {
                        MeanBMI = 18.196700;
                        SDBMI = 2.858300;
                    }
                    if (Num >= 4440 && Num < 4470)
                    {
                        MeanBMI = 18.263900;
                        SDBMI = 2.874100;
                    }
                    if (Num >= 4470 && Num < 4500)
                    {
                        MeanBMI = 18.331200;
                        SDBMI = 2.890800;
                    }
                    if (Num >= 4500 && Num < 4530)
                    {
                        MeanBMI = 18.398600;
                        SDBMI = 2.906400;
                    }
                    if (Num >= 4530 && Num < 4560)
                    {
                        MeanBMI = 18.466000;
                        SDBMI = 2.922000;
                    }
                    if (Num >= 4560 && Num < 4590)
                    {
                        MeanBMI = 18.533300;
                        SDBMI = 2.937700;
                    }
                    if (Num >= 4590 && Num < 4620)
                    {
                        MeanBMI = 18.600600;
                        SDBMI = 2.953400;
                    }
                    if (Num >= 4620 && Num < 4650)
                    {
                        MeanBMI = 18.667700;
                        SDBMI = 2.969300;
                    }
                    if (Num >= 4650 && Num < 4680)
                    {
                        MeanBMI = 18.734600;
                        SDBMI = 2.984400;
                    }
                    if (Num >= 4680 && Num < 4710)
                    {
                        MeanBMI = 18.801200;
                        SDBMI = 2.998800;
                    }
                    if (Num >= 4710 && Num < 4740)
                    {
                        MeanBMI = 18.867500;
                        SDBMI = 3.014500;
                    }
                    if (Num >= 4740 && Num < 4770)
                    {
                        MeanBMI = 18.933500;
                        SDBMI = 3.028500;
                    }
                    if (Num >= 4770 && Num < 4800)
                    {
                        MeanBMI = 18.999100;
                        SDBMI = 3.042900;
                    }
                    if (Num >= 4800 && Num < 4830)
                    {
                        MeanBMI = 19.064200;
                        SDBMI = 3.057800;
                    }
                    if (Num >= 4830 && Num < 4860)
                    {
                        MeanBMI = 19.128900;
                        SDBMI = 3.072100;
                    }
                    if (Num >= 4860 && Num < 4890)
                    {
                        MeanBMI = 19.193100;
                        SDBMI = 3.085900;
                    }
                    if (Num >= 4890 && Num < 4920)
                    {
                        MeanBMI = 19.256700;
                        SDBMI = 3.100300;
                    }
                    if (Num >= 4920 && Num < 4950)
                    {
                        MeanBMI = 19.319700;
                        SDBMI = 3.113300;
                    }
                    if (Num >= 4950 && Num < 4980)
                    {
                        MeanBMI = 19.382000;
                        SDBMI = 3.127000;
                    }
                    if (Num >= 4980 && Num < 5010)
                    {
                        MeanBMI = 19.443700;
                        SDBMI = 3.140300;
                    }
                    if (Num >= 5010 && Num < 5040)
                    {
                        MeanBMI = 19.504500;
                        SDBMI = 3.153500;
                    }
                    if (Num >= 5040 && Num < 5070)
                    {
                        MeanBMI = 19.564700;
                        SDBMI = 3.166300;
                    }
                    if (Num >= 5070 && Num < 5100)
                    {
                        MeanBMI = 19.624000;
                        SDBMI = 3.179000;
                    }
                    if (Num >= 5100 && Num < 5130)
                    {
                        MeanBMI = 19.682400;
                        SDBMI = 3.191600;
                    }
                    if (Num >= 5130 && Num < 5160)
                    {
                        MeanBMI = 19.740000;
                        SDBMI = 3.203000;
                    }
                    if (Num >= 5160 && Num < 5190)
                    {
                        MeanBMI = 19.796600;
                        SDBMI = 3.215400;
                    }
                    if (Num >= 5190 && Num < 5220)
                    {
                        MeanBMI = 19.852300;
                        SDBMI = 3.226700;
                    }
                    if (Num >= 5220 && Num < 5250)
                    {
                        MeanBMI = 19.907000;
                        SDBMI = 3.238000;
                    }
                    if (Num >= 5250 && Num < 5280)
                    {
                        MeanBMI = 19.960700;
                        SDBMI = 3.249300;
                    }
                    if (Num >= 5280 && Num < 5310)
                    {
                        MeanBMI = 20.013300;
                        SDBMI = 3.259700;
                    }
                    if (Num >= 5310 && Num < 5340)
                    {
                        MeanBMI = 20.064800;
                        SDBMI = 3.271200;
                    }
                    if (Num >= 5340 && Num < 5370)
                    {
                        MeanBMI = 20.115200;
                        SDBMI = 3.280800;
                    }
                    if (Num >= 5370 && Num < 5400)
                    {
                        MeanBMI = 20.164400;
                        SDBMI = 3.291600;
                    }
                    if (Num >= 5400 && Num < 5430)
                    {
                        MeanBMI = 20.212500;
                        SDBMI = 3.301500;
                    }
                    if (Num >= 5430 && Num < 5460)
                    {
                        MeanBMI = 20.259500;
                        SDBMI = 3.310500;
                    }
                    if (Num >= 5460 && Num < 5490)
                    {
                        MeanBMI = 20.305300;
                        SDBMI = 3.319700;
                    }
                    if (Num >= 5490 && Num < 5520)
                    {
                        MeanBMI = 20.349900;
                        SDBMI = 3.329100;
                    }
                    if (Num >= 5520 && Num < 5550)
                    {
                        MeanBMI = 20.393400;
                        SDBMI = 3.337600;
                    }
                    if (Num >= 5550 && Num < 5580)
                    {
                        MeanBMI = 20.435700;
                        SDBMI = 3.346300;
                    }
                    if (Num >= 5580 && Num < 5610)
                    {
                        MeanBMI = 20.476900;
                        SDBMI = 3.355100;
                    }
                    if (Num >= 5610 && Num < 5640)
                    {
                        MeanBMI = 20.517000;
                        SDBMI = 3.363000;
                    }
                    if (Num >= 5640 && Num < 5670)
                    {
                        MeanBMI = 20.556000;
                        SDBMI = 3.371000;
                    }
                    if (Num >= 5670 && Num < 5700)
                    {
                        MeanBMI = 20.593800;
                        SDBMI = 3.378200;
                    }
                    if (Num >= 5700 && Num < 5730)
                    {
                        MeanBMI = 20.630600;
                        SDBMI = 3.386400;
                    }
                    if (Num >= 5730 && Num < 5760)
                    {
                        MeanBMI = 20.666300;
                        SDBMI = 3.393700;
                    }
                    if (Num >= 5760 && Num < 5790)
                    {
                        MeanBMI = 20.700800;
                        SDBMI = 3.400200;
                    }
                    if (Num >= 5790 && Num < 5820)
                    {
                        MeanBMI = 20.734400;
                        SDBMI = 3.406600;
                    }
                    if (Num >= 5820 && Num < 5850)
                    {
                        MeanBMI = 20.766800;
                        SDBMI = 3.413200;
                    }
                    if (Num >= 5850 && Num < 5880)
                    {
                        MeanBMI = 20.798200;
                        SDBMI = 3.419800;
                    }
                    if (Num >= 5880 && Num < 5910)
                    {
                        MeanBMI = 20.828600;
                        SDBMI = 3.425400;
                    }
                    if (Num >= 5910 && Num < 5940)
                    {
                        MeanBMI = 20.858000;
                        SDBMI = 3.432000;
                    }
                    if (Num >= 5940 && Num < 5970)
                    {
                        MeanBMI = 20.886300;
                        SDBMI = 3.437700;
                    }
                    if (Num >= 5970 && Num < 6000)
                    {
                        MeanBMI = 20.913700;
                        SDBMI = 3.442300;
                    }
                    if (Num >= 6000 && Num < 6030)
                    {
                        MeanBMI = 20.940100;
                        SDBMI = 3.447900;
                    }
                    if (Num >= 6030 && Num < 6060)
                    {
                        MeanBMI = 20.965600;
                        SDBMI = 3.452400;
                    }
                    if (Num >= 6060 && Num < 6090)
                    {
                        MeanBMI = 20.990100;
                        SDBMI = 3.457900;
                    }
                    if (Num >= 6090 && Num < 6120)
                    {
                        MeanBMI = 21.013800;
                        SDBMI = 3.462200;
                    }
                    if (Num >= 6120 && Num < 6150)
                    {
                        MeanBMI = 21.036700;
                        SDBMI = 3.466300;
                    }
                    if (Num >= 6150 && Num < 6180)
                    {
                        MeanBMI = 21.058700;
                        SDBMI = 3.471300;
                    }
                    if (Num >= 6180 && Num < 6210)
                    {
                        MeanBMI = 21.080100;
                        SDBMI = 3.474900;
                    }
                    if (Num >= 6210 && Num < 6240)
                    {
                        MeanBMI = 21.100700;
                        SDBMI = 3.479300;
                    }
                    if (Num >= 6240 && Num < 6270)
                    {
                        MeanBMI = 21.120600;
                        SDBMI = 3.482400;
                    }
                    if (Num >= 6270 && Num < 6300)
                    {
                        MeanBMI = 21.139900;
                        SDBMI = 3.486100;
                    }
                    if (Num >= 6300 && Num < 6330)
                    {
                        MeanBMI = 21.158600;
                        SDBMI = 3.490400;
                    }
                    if (Num >= 6330 && Num < 6360)
                    {
                        MeanBMI = 21.176800;
                        SDBMI = 3.493200;
                    }
                    if (Num >= 6360 && Num < 6390)
                    {
                        MeanBMI = 21.194400;
                        SDBMI = 3.496600;
                    }
                    if (Num >= 6390 && Num < 6420)
                    {
                        MeanBMI = 21.211600;
                        SDBMI = 3.500400;
                    }
                    if (Num >= 6420 && Num < 6450)
                    {
                        MeanBMI = 21.228200;
                        SDBMI = 3.502800;
                    }
                    if (Num >= 6450 && Num < 6480)
                    {
                        MeanBMI = 21.244400;
                        SDBMI = 3.505600;
                    }
                    if (Num >= 6480 && Num < 6510)
                    {
                        MeanBMI = 21.260300;
                        SDBMI = 3.508700;
                    }
                    if (Num >= 6510 && Num < 6540)
                    {
                        MeanBMI = 21.275700;
                        SDBMI = 3.512300;
                    }
                    if (Num >= 6540 && Num < 6570)
                    {
                        MeanBMI = 21.290800;
                        SDBMI = 3.514200;
                    }
                    if (Num >= 6570 && Num < 6600)
                    {
                        MeanBMI = 21.305500;
                        SDBMI = 3.517500;
                    }
                    if (Num >= 6600 && Num < 6630)
                    {
                        MeanBMI = 21.320000;
                        SDBMI = 3.520000;
                    }
                    if (Num >= 6630 && Num < 6660)
                    {
                        MeanBMI = 21.334100;
                        SDBMI = 3.521900;
                    }
                    if (Num >= 6660 && Num < 6690)
                    {
                        MeanBMI = 21.348000;
                        SDBMI = 3.525000;
                    }
                    if (Num >= 6690 && Num < 6720)
                    {
                        MeanBMI = 21.361700;
                        SDBMI = 3.527300;
                    }
                    if (Num >= 6720 && Num < 6750)
                    {
                        MeanBMI = 21.375200;
                        SDBMI = 3.529800;
                    }
                    if (Num >= 6750 && Num < 6780)
                    {
                        MeanBMI = 21.388400;
                        SDBMI = 3.531600;
                    }
                    if (Num >= 6780 && Num < 6810)
                    {
                        MeanBMI = 21.401400;
                        SDBMI = 3.533600;
                    }
                    if (Num >= 6810 && Num < 6840)
                    {
                        MeanBMI = 21.414300;
                        SDBMI = 3.536700;
                    }
                    if (Num >= 6840 && Num < 6870)
                    {
                        MeanBMI = 21.426900;
                        SDBMI = 3.538100;
                    }
                    if (Num < 720 && Height != 0)
                    {
                        if (Height >= 45 && Height < 45.5)
                        {
                            MeanWL = 2.460700;
                            SDWL = 0.239300;
                        }
                        if (Height >= 45.5 && Height < 46)
                        {
                            MeanWL = 2.545700;
                            SDWL = 0.254300;
                        }
                        if (Height >= 46 && Height < 46.5)
                        {
                            MeanWL = 2.630600;
                            SDWL = 0.269400;
                        }
                        if (Height >= 46.5 && Height < 47)
                        {
                            MeanWL = 2.715500;
                            SDWL = 0.284500;
                        }
                        if (Height >= 47 && Height < 47.5)
                        {
                            MeanWL = 2.800700;
                            SDWL = 0.299300;
                        }
                        if (Height >= 47.5 && Height < 48)
                        {
                            MeanWL = 2.886700;
                            SDWL = 0.313300;
                        }
                        if (Height >= 48 && Height < 48.5)
                        {
                            MeanWL = 2.974100;
                            SDWL = 0.325900;
                        }
                        if (Height >= 48.5 && Height < 49)
                        {
                            MeanWL = 3.063600;
                            SDWL = 0.336400;
                        }
                        if (Height >= 49 && Height < 49.5)
                        {
                            MeanWL = 3.156000;
                            SDWL = 0.344000;
                        }
                        if (Height >= 49.5 && Height < 50)
                        {
                            MeanWL = 3.252000;
                            SDWL = 0.348000;
                        }
                        if (Height >= 50 && Height < 50.5)
                        {
                            MeanWL = 3.351800;
                            SDWL = 0.348200;
                        }
                        if (Height >= 50.5 && Height < 51)
                        {
                            MeanWL = 3.455700;
                            SDWL = 0.344300;
                        }
                        if (Height >= 51 && Height < 51.5)
                        {
                            MeanWL = 3.563600;
                            SDWL = 0.336400;
                        }
                        if (Height >= 51.5 && Height < 52)
                        {
                            MeanWL = 3.675400;
                            SDWL = 0.324600;
                        }
                        if (Height >= 52 && Height < 52.5)
                        {
                            MeanWL = 3.791100;
                            SDWL = 0.408900;
                        }
                        if (Height >= 52.5 && Height < 53)
                        {
                            MeanWL = 3.910500;
                            SDWL = 0.389500;
                        }
                        if (Height >= 53 && Height < 53.5)
                        {
                            MeanWL = 4.033200;
                            SDWL = 0.366800;
                        }
                        if (Height >= 53.5 && Height < 54)
                        {
                            MeanWL = 4.159100;
                            SDWL = 0.440900;
                        }
                        if (Height >= 54 && Height < 54.5)
                        {
                            MeanWL = 4.287500;
                            SDWL = 0.412500;
                        }
                        if (Height >= 54.5 && Height < 55)
                        {
                            MeanWL = 4.417900;
                            SDWL = 0.382100;
                        }
                        if (Height >= 55 && Height < 55.5)
                        {
                            MeanWL = 4.549800;
                            SDWL = 0.450200;
                        }
                        if (Height >= 55.5 && Height < 56)
                        {
                            MeanWL = 4.682700;
                            SDWL = 0.417300;
                        }
                        if (Height >= 56 && Height < 56.5)
                        {
                            MeanWL = 4.816200;
                            SDWL = 0.483800;
                        }
                        if (Height >= 56.5 && Height < 57)
                        {
                            MeanWL = 4.950000;
                            SDWL = 0.450000;
                        }
                        if (Height >= 57 && Height < 57.5)
                        {
                            MeanWL = 5.083700;
                            SDWL = 0.516300;
                        }
                        if (Height >= 57.5 && Height < 58)
                        {
                            MeanWL = 5.217300;
                            SDWL = 0.482700;
                        }
                        if (Height >= 58 && Height < 58.5)
                        {
                            MeanWL = 5.350700;
                            SDWL = 0.549300;
                        }
                        if (Height >= 58.5 && Height < 59)
                        {
                            MeanWL = 5.483400;
                            SDWL = 0.516600;
                        }
                        if (Height >= 59 && Height < 59.5)
                        {
                            MeanWL = 5.615100;
                            SDWL = 0.584900;
                        }
                        if (Height >= 59.5 && Height < 60)
                        {
                            MeanWL = 5.745400;
                            SDWL = 0.554600;
                        }
                        if (Height >= 60 && Height < 60.5)
                        {
                            MeanWL = 5.874200;
                            SDWL = 0.525800;
                        }
                        if (Height >= 60.5 && Height < 61)
                        {
                            MeanWL = 6.001400;
                            SDWL = 0.598600;
                        }
                        if (Height >= 61 && Height < 61.5)
                        {
                            MeanWL = 6.127000;
                            SDWL = 0.573000;
                        }
                        if (Height >= 61.5 && Height < 62)
                        {
                            MeanWL = 6.251100;
                            SDWL = 0.648900;
                        }
                        if (Height >= 62 && Height < 62.5)
                        {
                            MeanWL = 6.373800;
                            SDWL = 0.626200;
                        }
                        if (Height >= 62.5 && Height < 63)
                        {
                            MeanWL = 6.494800;
                            SDWL = 0.605200;
                        }
                        if (Height >= 63 && Height < 63.5)
                        {
                            MeanWL = 6.614400;
                            SDWL = 0.685600;
                        }
                        if (Height >= 63.5 && Height < 64)
                        {
                            MeanWL = 6.732800;
                            SDWL = 0.667200;
                        }
                        if (Height >= 64 && Height < 64.5)
                        {
                            MeanWL = 6.850100;
                            SDWL = 0.649900;
                        }
                        if (Height >= 64.5 && Height < 65)
                        {
                            MeanWL = 6.966200;
                            SDWL = 0.633800;
                        }
                        if (Height >= 65 && Height < 65.5)
                        {
                            MeanWL = 7.081200;
                            SDWL = 0.718800;
                        }
                        if (Height >= 65.5 && Height < 66)
                        {
                            MeanWL = 7.195000;
                            SDWL = 0.705000;
                        }
                        if (Height >= 66 && Height < 66.5)
                        {
                            MeanWL = 7.307600;
                            SDWL = 0.692400;
                        }
                        if (Height >= 66.5 && Height < 67)
                        {
                            MeanWL = 7.418900;
                            SDWL = 0.681100;
                        }
                        if (Height >= 67 && Height < 67.5)
                        {
                            MeanWL = 7.528800;
                            SDWL = 0.771200;
                        }
                        if (Height >= 67.5 && Height < 68)
                        {
                            MeanWL = 7.637500;
                            SDWL = 0.762500;
                        }
                        if (Height >= 68 && Height < 68.5)
                        {
                            MeanWL = 7.744800;
                            SDWL = 0.755200;
                        }
                        if (Height >= 68.5 && Height < 69)
                        {
                            MeanWL = 7.850900;
                            SDWL = 0.749100;
                        }
                        if (Height >= 69 && Height < 69.5)
                        {
                            MeanWL = 7.955900;
                            SDWL = 0.744100;
                        }
                        if (Height >= 69.5 && Height < 70)
                        {
                            MeanWL = 8.059900;
                            SDWL = 0.740100;
                        }
                        if (Height >= 70 && Height < 70.5)
                        {
                            MeanWL = 8.163000;
                            SDWL = 0.837000;
                        }
                        if (Height >= 70.5 && Height < 71)
                        {
                            MeanWL = 8.265100;
                            SDWL = 0.834900;
                        }
                        if (Height >= 71 && Height < 71.5)
                        {
                            MeanWL = 8.366600;
                            SDWL = 0.833400;
                        }
                        if (Height >= 71.5 && Height < 72)
                        {
                            MeanWL = 8.467600;
                            SDWL = 0.832400;
                        }
                        if (Height >= 72 && Height < 72.5)
                        {
                            MeanWL = 8.567900;
                            SDWL = 0.832100;
                        }
                        if (Height >= 72.5 && Height < 73)
                        {
                            MeanWL = 8.667400;
                            SDWL = 0.832600;
                        }
                        if (Height >= 73 && Height < 73.5)
                        {
                            MeanWL = 8.766100;
                            SDWL = 0.833900;
                        }
                        if (Height >= 73.5 && Height < 74)
                        {
                            MeanWL = 8.863800;
                            SDWL = 0.836200;
                        }
                        if (Height >= 74 && Height < 74.5)
                        {
                            MeanWL = 8.960100;
                            SDWL = 0.839900;
                        }
                        if (Height >= 74.5 && Height < 75)
                        {
                            MeanWL = 9.055200;
                            SDWL = 0.844800;
                        }
                        if (Height >= 75 && Height < 75.5)
                        {
                            MeanWL = 9.149000;
                            SDWL = 0.851000;
                        }
                        if (Height >= 75.5 && Height < 76)
                        {
                            MeanWL = 9.241800;
                            SDWL = 0.858200;
                        }
                        if (Height >= 76 && Height < 76.5)
                        {
                            MeanWL = 9.333700;
                            SDWL = 0.866300;
                        }
                        if (Height >= 76.5 && Height < 77)
                        {
                            MeanWL = 9.425200;
                            SDWL = 0.874800;
                        }
                        if (Height >= 77 && Height < 77.5)
                        {
                            MeanWL = 9.516600;
                            SDWL = 0.883400;
                        }
                        if (Height >= 77.5 && Height < 78)
                        {
                            MeanWL = 9.608600;
                            SDWL = 0.891400;
                        }
                        if (Height >= 78 && Height < 78.5)
                        {
                            MeanWL = 9.701500;
                            SDWL = 0.898500;
                        }
                        if (Height >= 78.5 && Height < 79)
                        {
                            MeanWL = 9.795700;
                            SDWL = 0.904300;
                        }
                        if (Height >= 79 && Height < 79.5)
                        {
                            MeanWL = 9.891500;
                            SDWL = 0.908500;
                        }
                        if (Height >= 79.5 && Height < 80)
                        {
                            MeanWL = 9.989200;
                            SDWL = 0.910800;
                        }
                        if (Height >= 80 && Height < 80.5)
                        {
                            MeanWL = 10.089100;
                            SDWL = 0.910900;
                        }
                        if (Height >= 80.5 && Height < 81)
                        {
                            MeanWL = 10.191600;
                            SDWL = 1.008400;
                        }
                        if (Height >= 81 && Height < 81.5)
                        {
                            MeanWL = 10.296500;
                            SDWL = 1.003500;
                        }
                        if (Height >= 81.5 && Height < 82)
                        {
                            MeanWL = 10.404100;
                            SDWL = 0.995900;
                        }
                        if (Height >= 82 && Height < 82.5)
                        {
                            MeanWL = 10.514000;
                            SDWL = 0.986000;
                        }
                        if (Height >= 82.5 && Height < 83)
                        {
                            MeanWL = 10.626300;
                            SDWL = 0.973700;
                        }
                        if (Height >= 83 && Height < 83.5)
                        {
                            MeanWL = 10.741000;
                            SDWL = 1.059000;
                        }
                        if (Height >= 83.5 && Height < 84)
                        {
                            MeanWL = 10.857800;
                            SDWL = 1.042200;
                        }
                        if (Height >= 84 && Height < 84.5)
                        {
                            MeanWL = 10.976700;
                            SDWL = 1.023300;
                        }
                        if (Height >= 84.5 && Height < 85)
                        {
                            MeanWL = 11.097400;
                            SDWL = 1.002600;
                        }
                        if (Height >= 85 && Height < 85.5)
                        {
                            MeanWL = 11.219800;
                            SDWL = 1.080200;
                        }
                        if (Height >= 85.5 && Height < 86)
                        {
                            MeanWL = 11.343500;
                            SDWL = 1.056500;
                        }
                        if (Height >= 86 && Height < 86.5)
                        {
                            MeanWL = 11.468400;
                            SDWL = 1.131600;
                        }
                        if (Height >= 86.5 && Height < 87)
                        {
                            MeanWL = 11.594000;
                            SDWL = 1.106000;
                        }
                        if (Height >= 87 && Height < 87.5)
                        {
                            MeanWL = 11.720100;
                            SDWL = 1.079900;
                        }
                        if (Height >= 87.5 && Height < 88)
                        {
                            MeanWL = 11.846100;
                            SDWL = 1.153900;
                        }
                        if (Height >= 88 && Height < 88.5)
                        {
                            MeanWL = 11.972000;
                            SDWL = 1.128000;
                        }
                        if (Height >= 88.5 && Height < 89)
                        {
                            MeanWL = 12.097600;
                            SDWL = 1.102400;
                        }
                        if (Height >= 89 && Height < 89.5)
                        {
                            MeanWL = 12.222900;
                            SDWL = 1.177100;
                        }
                        if (Height >= 89.5 && Height < 90)
                        {
                            MeanWL = 12.347700;
                            SDWL = 1.152300;
                        }
                        if (Height >= 90 && Height < 90.5)
                        {
                            MeanWL = 12.472300;
                            SDWL = 1.227700;
                        }
                        if (Height >= 90.5 && Height < 91)
                        {
                            MeanWL = 12.596500;
                            SDWL = 1.203500;
                        }
                        if (Height >= 91 && Height < 91.5)
                        {
                            MeanWL = 12.720500;
                            SDWL = 1.179500;
                        }
                        if (Height >= 91.5 && Height < 92)
                        {
                            MeanWL = 12.844300;
                            SDWL = 1.255700;
                        }
                        if (Height >= 92 && Height < 92.5)
                        {
                            MeanWL = 12.968100;
                            SDWL = 1.231900;
                        }
                        if (Height >= 92.5 && Height < 93)
                        {
                            MeanWL = 13.092000;
                            SDWL = 1.208000;
                        }
                        if (Height >= 93 && Height < 93.5)
                        {
                            MeanWL = 13.215800;
                            SDWL = 1.284200;
                        }
                        if (Height >= 93.5 && Height < 94)
                        {
                            MeanWL = 13.339900;
                            SDWL = 1.260100;
                        }
                        if (Height >= 94 && Height < 94.5)
                        {
                            MeanWL = 13.464300;
                            SDWL = 1.235700;
                        }
                        if (Height >= 94.5 && Height < 95)
                        {
                            MeanWL = 13.589200;
                            SDWL = 1.310800;
                        }
                        if (Height >= 95 && Height < 95.5)
                        {
                            MeanWL = 13.714600;
                            SDWL = 1.285400;
                        }
                        if (Height >= 95.5 && Height < 96)
                        {
                            MeanWL = 13.840800;
                            SDWL = 1.359200;
                        }
                        if (Height >= 96 && Height < 96.5)
                        {
                            MeanWL = 13.967600;
                            SDWL = 1.332400;
                        }
                        if (Height >= 96.5 && Height < 97)
                        {
                            MeanWL = 14.095300;
                            SDWL = 1.304700;
                        }
                        if (Height >= 97 && Height < 97.5)
                        {
                            MeanWL = 14.223900;
                            SDWL = 1.376100;
                        }
                        if (Height >= 97.5 && Height < 98)
                        {
                            MeanWL = 14.353700;
                            SDWL = 1.346300;
                        }
                        if (Height >= 98 && Height < 98.5)
                        {
                            MeanWL = 14.484800;
                            SDWL = 1.415200;
                        }
                        if (Height >= 98.5 && Height < 99)
                        {
                            MeanWL = 14.617400;
                            SDWL = 1.382600;
                        }
                        if (Height >= 99 && Height < 99.5)
                        {
                            MeanWL = 14.751900;
                            SDWL = 1.448100;
                        }
                        if (Height >= 99.5 && Height < 100)
                        {
                            MeanWL = 14.888200;
                            SDWL = 1.411800;
                        }
                        if (Height >= 100 && Height < 100.5)
                        {
                            MeanWL = 15.026700;
                            SDWL = 1.473300;
                        }
                        if (Height >= 100.5 && Height < 101)
                        {
                            MeanWL = 15.167600;
                            SDWL = 1.432400;
                        }
                        if (Height >= 101 && Height < 101.5)
                        {
                            MeanWL = 15.310800;
                            SDWL = 1.489200;
                        }
                        if (Height >= 101.5 && Height < 102)
                        {
                            MeanWL = 15.456400;
                            SDWL = 1.543600;
                        }
                        if (Height >= 102 && Height < 102.5)
                        {
                            MeanWL = 15.604600;
                            SDWL = 1.495400;
                        }
                        if (Height >= 102.5 && Height < 103)
                        {
                            MeanWL = 15.755300;
                            SDWL = 1.544700;
                        }
                        if (Height >= 103 && Height < 103.5)
                        {
                            MeanWL = 15.908700;
                            SDWL = 1.591300;
                        }
                        if (Height >= 103.5 && Height < 104)
                        {
                            MeanWL = 16.064500;
                            SDWL = 1.535500;
                        }
                        if (Height >= 104 && Height < 104.5)
                        {
                            MeanWL = 16.222900;
                            SDWL = 1.577100;
                        }
                        if (Height >= 104.5 && Height < 105)
                        {
                            MeanWL = 16.383700;
                            SDWL = 1.616300;
                        }
                        if (Height >= 105 && Height < 105.5)
                        {
                            MeanWL = 16.547000;
                            SDWL = 1.653000;
                        }
                        if (Height >= 105.5 && Height < 106)
                        {
                            MeanWL = 16.712900;
                            SDWL = 1.687100;
                        }
                        if (Height >= 106 && Height < 106.5)
                        {
                            MeanWL = 16.881400;
                            SDWL = 1.618600;
                        }
                        if (Height >= 106.5 && Height < 107)
                        {
                            MeanWL = 17.052700;
                            SDWL = 1.647300;
                        }
                        if (Height >= 107 && Height < 107.5)
                        {
                            MeanWL = 17.226900;
                            SDWL = 1.673100;
                        }
                        if (Height >= 107.5 && Height < 108)
                        {
                            MeanWL = 17.403900;
                            SDWL = 1.696100;
                        }
                        if (Height >= 108 && Height < 108.5)
                        {
                            MeanWL = 17.583900;
                            SDWL = 1.716100;
                        }
                        if (Height >= 108.5 && Height < 109)
                        {
                            MeanWL = 17.766800;
                            SDWL = 1.733200;
                        }
                        if (Height >= 109 && Height < 109.5)
                        {
                            MeanWL = 17.952600;
                            SDWL = 1.747400;
                        }
                        if (Height >= 109.5 && Height < 110)
                        {
                            MeanWL = 18.141200;
                            SDWL = 1.858800;
                        }
                        if (Height >= 110 && Height < 110.5)
                        {
                            MeanWL = 18.332400;
                            SDWL = 1.867600;
                        }


                    }
                    if (Num >= 720 && Num <= 1800 && Height != 0)
                    {
                        if (Height >= 65 && Height < 65.5)
                        {
                            MeanWL = 7.2402;
                            SDWL = 0.6598;
                        }
                        if (Height >= 65.5 && Height < 66)
                        {
                            MeanWL = 7.3523;
                            SDWL = 0.7477;
                        }
                        if (Height >= 66 && Height < 66.5)
                        {
                            MeanWL = 7.463;
                            SDWL = 0.737;
                        }
                        if (Height >= 66.5 && Height < 67)
                        {
                            MeanWL = 7.5724;
                            SDWL = 0.7276;
                        }
                        if (Height >= 67 && Height < 67.5)
                        {
                            MeanWL = 7.6806;
                            SDWL = 0.7194;
                        }
                        if (Height >= 67.5 && Height < 68)
                        {
                            MeanWL = 7.7874;
                            SDWL = 0.7126;
                        }
                        if (Height >= 68 && Height < 68.5)
                        {
                            MeanWL = 7.893;
                            SDWL = 0.807;
                        }
                        if (Height >= 68.5 && Height < 69)
                        {
                            MeanWL = 7.9976;
                            SDWL = 0.8024;
                        }
                        if (Height >= 69 && Height < 69.5)
                        {
                            MeanWL = 8.1012;
                            SDWL = 0.7988;
                        }
                        if (Height >= 69.5 && Height < 70)
                        {
                            MeanWL = 8.2039;
                            SDWL = 0.7961;
                        }
                        if (Height >= 70 && Height < 70.5)
                        {
                            MeanWL = 8.3058;
                            SDWL = 0.7942;
                        }
                        if (Height >= 70.5 && Height < 71)
                        {
                            MeanWL = 8.4071;
                            SDWL = 0.7929;
                        }
                        if (Height >= 71 && Height < 71.5)
                        {
                            MeanWL = 8.5078;
                            SDWL = 0.7922;
                        }
                        if (Height >= 71.5 && Height < 72)
                        {
                            MeanWL = 8.6078;
                            SDWL = 0.7922;
                        }
                        if (Height >= 72 && Height < 72.5)
                        {
                            MeanWL = 8.707;
                            SDWL = 0.793;
                        }
                        if (Height >= 72.5 && Height < 73)
                        {
                            MeanWL = 8.8053;
                            SDWL = 0.8947;
                        }
                        if (Height >= 73 && Height < 73.5)
                        {
                            MeanWL = 8.9025;
                            SDWL = 0.8975;
                        }
                        if (Height >= 73.5 && Height < 74)
                        {
                            MeanWL = 8.9983;
                            SDWL = 0.9017;
                        }
                        if (Height >= 74 && Height < 74.5)
                        {
                            MeanWL = 9.0928;
                            SDWL = 0.9072;
                        }
                        if (Height >= 74.5 && Height < 75)
                        {
                            MeanWL = 9.1862;
                            SDWL = 0.9138;
                        }
                        if (Height >= 75 && Height < 75.5)
                        {
                            MeanWL = 9.2786;
                            SDWL = 0.9214;
                        }
                        if (Height >= 75.5 && Height < 76)
                        {
                            MeanWL = 9.3703;
                            SDWL = 0.9297;
                        }
                        if (Height >= 76 && Height < 76.5)
                        {
                            MeanWL = 9.4617;
                            SDWL = 0.9383;
                        }
                        if (Height >= 76.5 && Height < 77)
                        {
                            MeanWL = 9.5533;
                            SDWL = 0.9467;
                        }
                        if (Height >= 77 && Height < 77.5)
                        {
                            MeanWL = 9.6456;
                            SDWL = 0.9544;
                        }
                        if (Height >= 77.5 && Height < 78)
                        {
                            MeanWL = 9.739;
                            SDWL = 0.961;
                        }
                        if (Height >= 78 && Height < 78.5)
                        {
                            MeanWL = 9.8338;
                            SDWL = 0.9662;
                        }
                        if (Height >= 78.5 && Height < 79)
                        {
                            MeanWL = 9.9303;
                            SDWL = 0.9697;
                        }
                        if (Height >= 79 && Height < 79.5)
                        {
                            MeanWL = 10.0289;
                            SDWL = 0.9711;
                        }
                        if (Height >= 79.5 && Height < 80)
                        {
                            MeanWL = 10.1298;
                            SDWL = 0.9702;
                        }
                        if (Height >= 80 && Height < 80.5)
                        {
                            MeanWL = 10.2332;
                            SDWL = 0.9668;
                        }
                        if (Height >= 80.5 && Height < 81)
                        {
                            MeanWL = 10.3393;
                            SDWL = 0.9607;
                        }
                        if (Height >= 81 && Height < 81.5)
                        {
                            MeanWL = 10.4477;
                            SDWL = 0.9523;
                        }
                        if (Height >= 81.5 && Height < 82)
                        {
                            MeanWL = 10.5586;
                            SDWL = 1.0414;
                        }
                        if (Height >= 82 && Height < 82.5)
                        {
                            MeanWL = 10.6719;
                            SDWL = 1.0281;
                        }
                        if (Height >= 82.5 && Height < 83)
                        {
                            MeanWL = 10.7874;
                            SDWL = 1.0126;
                        }
                        if (Height >= 83 && Height < 83.5)
                        {
                            MeanWL = 10.9051;
                            SDWL = 0.9949;
                        }
                        if (Height >= 83.5 && Height < 84)
                        {
                            MeanWL = 11.0248;
                            SDWL = 1.0752;
                        }
                        if (Height >= 84 && Height < 84.5)
                        {
                            MeanWL = 11.1462;
                            SDWL = 1.0538;
                        }
                        if (Height >= 84.5 && Height < 85)
                        {
                            MeanWL = 11.2691;
                            SDWL = 1.0309;
                        }
                        if (Height >= 85 && Height < 85.5)
                        {
                            MeanWL = 11.3934;
                            SDWL = 1.1066;
                        }
                        if (Height >= 85.5 && Height < 86)
                        {
                            MeanWL = 11.5186;
                            SDWL = 1.0814;
                        }
                        if (Height >= 86 && Height < 86.5)
                        {
                            MeanWL = 11.6444;
                            SDWL = 1.0556;
                        }
                        if (Height >= 86.5 && Height < 87)
                        {
                            MeanWL = 11.7705;
                            SDWL = 1.1295;
                        }
                        if (Height >= 87 && Height < 87.5)
                        {
                            MeanWL = 11.8965;
                            SDWL = 1.1035;
                        }
                        if (Height >= 87.5 && Height < 88)
                        {
                            MeanWL = 12.0223;
                            SDWL = 1.1777;
                        }
                        if (Height >= 88 && Height < 88.5)
                        {
                            MeanWL = 12.1478;
                            SDWL = 1.1522;
                        }
                        if (Height >= 88.5 && Height < 89)
                        {
                            MeanWL = 12.2729;
                            SDWL = 1.1271;
                        }
                        if (Height >= 89 && Height < 89.5)
                        {
                            MeanWL = 12.3976;
                            SDWL = 1.2024;
                        }
                        if (Height >= 89.5 && Height < 90)
                        {
                            MeanWL = 12.522;
                            SDWL = 1.178;
                        }
                        if (Height >= 90 && Height < 90.5)
                        {
                            MeanWL = 12.6461;
                            SDWL = 1.1539;
                        }
                        if (Height >= 90.5 && Height < 91)
                        {
                            MeanWL = 12.77;
                            SDWL = 1.23;
                        }
                        if (Height >= 91 && Height < 91.5)
                        {
                            MeanWL = 12.8939;
                            SDWL = 1.2061;
                        }
                        if (Height >= 91.5 && Height < 92)
                        {
                            MeanWL = 13.0177;
                            SDWL = 1.2823;
                        }
                        if (Height >= 92 && Height < 92.5)
                        {
                            MeanWL = 13.1415;
                            SDWL = 1.2585;
                        }
                        if (Height >= 92.5 && Height < 93)
                        {
                            MeanWL = 13.2654;
                            SDWL = 1.2346;
                        }
                        if (Height >= 93 && Height < 93.5)
                        {
                            MeanWL = 13.3896;
                            SDWL = 1.3104;
                        }
                        if (Height >= 93.5 && Height < 94)
                        {
                            MeanWL = 13.5142;
                            SDWL = 1.2858;
                        }
                        if (Height >= 94 && Height < 94.5)
                        {
                            MeanWL = 13.6393;
                            SDWL = 1.2607;
                        }
                        if (Height >= 94.5 && Height < 95)
                        {
                            MeanWL = 13.765;
                            SDWL = 1.335;
                        }
                        if (Height >= 95 && Height < 95.5)
                        {
                            MeanWL = 13.8914;
                            SDWL = 1.3086;
                        }
                        if (Height >= 95.5 && Height < 96)
                        {
                            MeanWL = 14.0186;
                            SDWL = 1.3814;
                        }
                        if (Height >= 96 && Height < 96.5)
                        {
                            MeanWL = 14.1466;
                            SDWL = 1.3534;
                        }
                        if (Height >= 96.5 && Height < 97)
                        {
                            MeanWL = 14.2757;
                            SDWL = 1.3243;
                        }
                        if (Height >= 97 && Height < 97.5)
                        {
                            MeanWL = 14.4059;
                            SDWL = 1.3941;
                        }
                        if (Height >= 97.5 && Height < 98)
                        {
                            MeanWL = 14.5376;
                            SDWL = 1.3624;
                        }
                        if (Height >= 98 && Height < 98.5)
                        {
                            MeanWL = 14.671;
                            SDWL = 1.429;
                        }
                        if (Height >= 98.5 && Height < 99)
                        {
                            MeanWL = 14.8062;
                            SDWL = 1.3938;
                        }
                        if (Height >= 99 && Height < 99.5)
                        {
                            MeanWL = 14.9434;
                            SDWL = 1.4566;
                        }
                        if (Height >= 99.5 && Height < 100)
                        {
                            MeanWL = 15.0828;
                            SDWL = 1.4172;
                        }
                        if (Height >= 100 && Height < 100.5)
                        {
                            MeanWL = 15.2246;
                            SDWL = 1.4754;
                        }
                        if (Height >= 100.5 && Height < 101)
                        {
                            MeanWL = 15.3687;
                            SDWL = 1.5313;
                        }
                        if (Height >= 101 && Height < 101.5)
                        {
                            MeanWL = 15.5154;
                            SDWL = 1.4846;
                        }
                        if (Height >= 101.5 && Height < 102)
                        {
                            MeanWL = 15.6646;
                            SDWL = 1.5354;
                        }
                        if (Height >= 102 && Height < 102.5)
                        {
                            MeanWL = 15.8164;
                            SDWL = 1.5836;
                        }
                        if (Height >= 102.5 && Height < 103)
                        {
                            MeanWL = 15.9707;
                            SDWL = 1.5293;
                        }
                        if (Height >= 103 && Height < 103.5)
                        {
                            MeanWL = 16.1276;
                            SDWL = 1.5724;
                        }
                        if (Height >= 103.5 && Height < 104)
                        {
                            MeanWL = 16.287;
                            SDWL = 1.613;
                        }
                        if (Height >= 104 && Height < 104.5)
                        {
                            MeanWL = 16.4488;
                            SDWL = 1.6512;
                        }
                        if (Height >= 104.5 && Height < 105)
                        {
                            MeanWL = 16.6131;
                            SDWL = 1.5869;
                        }
                        if (Height >= 105 && Height < 105.5)
                        {
                            MeanWL = 16.78;
                            SDWL = 1.62;
                        }
                        if (Height >= 105.5 && Height < 106)
                        {
                            MeanWL = 16.9496;
                            SDWL = 1.6504;
                        }
                        if (Height >= 106 && Height < 106.5)
                        {
                            MeanWL = 17.122;
                            SDWL = 1.678;
                        }
                        if (Height >= 106.5 && Height < 107)
                        {
                            MeanWL = 17.2973;
                            SDWL = 1.7027;
                        }
                        if (Height >= 107 && Height < 107.5)
                        {
                            MeanWL = 17.4755;
                            SDWL = 1.7245;
                        }
                        if (Height >= 107.5 && Height < 108)
                        {
                            MeanWL = 17.6567;
                            SDWL = 1.7433;
                        }
                        if (Height >= 108 && Height < 108.5)
                        {
                            MeanWL = 17.8407;
                            SDWL = 1.7593;
                        }
                        if (Height >= 108.5 && Height < 109)
                        {
                            MeanWL = 18.0277;
                            SDWL = 1.7723;
                        }
                        if (Height >= 109 && Height < 109.5)
                        {
                            MeanWL = 18.2174;
                            SDWL = 1.7826;
                        }
                        if (Height >= 109.5 && Height < 110)
                        {
                            MeanWL = 18.4096;
                            SDWL = 1.8904;
                        }
                        if (Height >= 110 && Height < 110.5)
                        {
                            MeanWL = 18.6043;
                            SDWL = 1.8957;
                        }
                        if (Height >= 110.5 && Height < 111)
                        {
                            MeanWL = 18.8015;
                            SDWL = 1.8985;
                        }
                        if (Height >= 111 && Height < 111.5)
                        {
                            MeanWL = 19.0009;
                            SDWL = 1.8991;
                        }
                        if (Height >= 111.5 && Height < 112)
                        {
                            MeanWL = 19.2024;
                            SDWL = 1.9976;
                        }
                        if (Height >= 112 && Height < 112.5)
                        {
                            MeanWL = 19.406;
                            SDWL = 1.994;
                        }
                        if (Height >= 112.5 && Height < 113)
                        {
                            MeanWL = 19.6116;
                            SDWL = 1.9884;
                        }
                        if (Height >= 113 && Height < 113.5)
                        {
                            MeanWL = 19.819;
                            SDWL = 1.981;
                        }
                        if (Height >= 113.5 && Height < 114)
                        {
                            MeanWL = 20.028;
                            SDWL = 2.072;
                        }
                        if (Height >= 114 && Height < 114.5)
                        {
                            MeanWL = 20.2385;
                            SDWL = 2.0615;
                        }
                        if (Height >= 114.5 && Height < 115)
                        {
                            MeanWL = 20.4502;
                            SDWL = 2.1498;
                        }
                        if (Height >= 115 && Height < 115.5)
                        {
                            MeanWL = 20.6629;
                            SDWL = 2.1371;
                        }
                        if (Height >= 115.5 && Height < 116)
                        {
                            MeanWL = 20.8766;
                            SDWL = 2.1234;
                        }
                        if (Height >= 116 && Height < 116.5)
                        {
                            MeanWL = 21.0909;
                            SDWL = 2.2091;
                        }
                        if (Height >= 116.5 && Height < 117)
                        {
                            MeanWL = 21.3059;
                            SDWL = 2.1941;
                        }
                        if (Height >= 117 && Height < 117.5)
                        {
                            MeanWL = 21.5213;
                            SDWL = 2.2787;
                        }
                        if (Height >= 117.5 && Height < 118)
                        {
                            MeanWL = 21.737;
                            SDWL = 2.263;
                        }
                        if (Height >= 118 && Height < 118.5)
                        {
                            MeanWL = 21.9529;
                            SDWL = 2.2471;
                        }
                        if (Height >= 118.5 && Height < 119)
                        {
                            MeanWL = 22.169;
                            SDWL = 2.331;
                        }
                        if (Height >= 119 && Height < 119.5)
                        {
                            MeanWL = 22.3851;
                            SDWL = 2.3149;
                        }
                        if (Height >= 119.5 && Height < 120)
                        {
                            MeanWL = 22.6012;
                            SDWL = 2.3988;
                        }
                        if (Height >= 120 && Height < 120.5)
                        {
                            MeanWL = 22.8173;
                            SDWL = 2.3827;
                        }
                    }


                }
                //Result for weight
                if (Num < 7230 && Num >= 0)
                {



                    ZW = (Weight - MeanW) / SDW;

                    if (Weight == 0 || Num < 0 || Num >= 7230)
                    {
                        Result.Text = "";

                    }
                    else if (aDay.Text == "" && aYear.Text == "" && aMonth.Text == "")
                    {
                        Result.Text = "";

                    }
                    else
                    {
                        Result.Text = "وزن برای سن" + "\n" + "Z-score = " + ZW.ToString("0.00") + "\n" + Perc(ZW);
                    }


                    //results for lenght and height
                    ZL = (Height - MeanL) / SDL;

                    if (Height == 0 || Num < 0)
                    {
                        ResultL.Text = "";

                    }

                    else if (aDay.Text == "" && aYear.Text == "" && aMonth.Text == "")
                    {
                        ResultL.Text = "";

                    }

                    else
                    {
                        if (Num >= 720)
                        {
                            ResultL.Text = "قد برای سن" + "\n" + "Z-score = " + ZL.ToString("0.00") + "\n" + Perc(ZL);
                        }
                        else
                        {

                            ResultL.Text = "طول برای سن" + "\n" + "Z-score = " + ZL.ToString("0.00") + "\n" + Perc(ZL);

                        }

                    }
                    //results for bmi
                    ZBMI = (BMI - MeanBMI) / SDBMI;
                    if (Height == 0 || Weight == 0)
                    {
                        ResultBMI.Text = "";
                    }
                    else if (aDay.Text == "" && aYear.Text == "" && aMonth.Text == "")
                    {
                        ResultBMI.Text = "BMI =" + BMI.ToString("0.00");
                    }
                    else
                    {
                        ResultBMI.Text = "BMI برای سن " + "\n" + "BMI =" + BMI.ToString("0.00") + "\n" + "Z-score = " + ZBMI.ToString("0.00") + "\n" + Perc(ZBMI); ;



                    }
                    double ZWL = (Weight - MeanWL) / SDWL;
                    if (Weight != 0 && Height != 0)
                    {
                        if (Num < 720)
                        {
                            ResultWL.Text = "وزن برای طول" + "\n" + "Z-SCORE = " + ZWL.ToString("0.00") + "\n" + Perc(ZWL);
                        }
                        else if (Num >= 720 && Num < 1830)
                        {
                            ResultWL.Text = "وزن برای قد" + "\n" + "Z-SCORE = " + ZWL.ToString("0.00") + "\n" + Perc(ZWL);
                        }
                        else
                        {
                            ResultWL.Text = "";
                        }
                    }

                    double ZHC = (HC - MeanHC) / SDHC;

                    ResultHC.Text = "دور سر برای سن " + "\n" + "Z-SCORE = " + ZHC.ToString("0.00") + "\n" + Perc(ZHC);

                    if (HC == 0 || Num >= 1830)
                    {
                        ResultHC.Text = "";
                    }
                    if (Height > 200 || Height < 0)
                    {
                        ResultL.Text = pointL;
                        ResultBMI.Text = "";
                    }
                    if (HC > 100 || HC < 0)
                    {
                        ResultHC.Text = pointHC;
                    }
                    if (Height > 200 || Height < 0 || Weight > 200 || Weight < 0)
                    {
                        ResultBMI.Text = "";
                        ResultWL.Text = "";
                    }
                    if (Height > 200 || Height < 0)
                    {
                        ResultL.Text = pointL;
                    }
                }
                else
                {
                    Result.Text = pointA;
                }


            };

            aYear.TextChanged += (sender, e) =>
                {
                    if (age.Text == "سن به تاریخ" || age.Text == "Age by date")
                    {
                        if (aYear.Text.Length == 2)
                        {
                            int y = Convert.ToInt32(aYear.Text);
                            if (y > 20)
                            {
                                aYear.SetTextColor(Color.Red);
                            }
                            else
                            {
                                aYear.SetTextColor(Color.Black);
                                aMonth.RequestFocus();
                            }

                        }

                    }
                    else if (age.Text == "Age by number")
                    {
                        if (aYear.Text.Length <= 4 && aYear.Text.Length>0)
                        {
                           int y = Convert.ToInt32(aYear.Text);
                            if (y < 2020 || y > 2100)
                            {
                                aYear.SetTextColor(Color.Red);
                            }
                            else
                            {
                                aYear.SetTextColor(Color.Black);
                                aMonth.RequestFocus();
                            }
                        }
                    }
                    else
                    {
                        if (aYear.Text.Length <= 4 && aYear.Text.Length > 0)
                        {
                           int y = Convert.ToInt32(aYear.Text);
                            if (y < 1399 || y > 1450)
                            {
                                aYear.SetTextColor(Color.Red);
                            }
                            else
                            {
                                aYear.SetTextColor(Color.Black);
                                aMonth.RequestFocus();
                            }
                        }
                    }
                };
            aMonth.TextChanged += (sender, e) =>
            {
                if (aMonth.Text.Length == 2)
                {
                    int m = Convert.ToInt32(aMonth.Text);
                    if (m > 12)
                    {
                        aMonth.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aMonth.SetTextColor(Color.Black);
                        aDay.RequestFocus();
                    }
                }
            };
            aDay.TextChanged += (sender, e) =>
            {
                if (aDay.Text.Length == 2)
                {
                    int d = Convert.ToInt32(aDay.Text);
                    if (d > 31)
                    {
                        aDay.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aDay.SetTextColor(Color.Black);


                        if (age.Text == "سن به عدد" || age.Text == "Age by number")
                        {
                            aYear1.RequestFocus();
                        }
                        else
                        {
                            aWeight.RequestFocus();
                        }
                    }
                }
            };
            aYear1.TextChanged += (sender, e) =>
            { 

         if (age.Text == "Age by number")
            {
                if (aYear1.Text.Length <= 4 && aYear1.Text.Length > 0)
                {
                    int y1 = Convert.ToInt32(aYear1.Text);
                    if (y1 < 1999 || y1 > 2100)
                    {
                        aYear1.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aYear1.SetTextColor(Color.Black);
                        aMonth1.RequestFocus();
                    }
                }
            }
            else
            {
                if (aYear1.Text.Length <= 4 && aYear1.Text.Length > 0)
                {
                    int y1 = Convert.ToInt32(aYear1.Text);
                    if (y1 < 1378 || y1 > 1450)
                    {
                        aYear1.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aYear1.SetTextColor(Color.Black);
                        aMonth1.RequestFocus();
                    }
                }
            }

        };
                aMonth1.TextChanged += (sender, e) =>
                {
                    if (aMonth1.Text.Length == 2)
                    {
                        int m1 = Convert.ToInt32(aMonth1.Text);
                        if (m1 > 12)
                        {
                            aMonth1.SetTextColor(Color.Red);
                        }
                        else
                        {
                            aMonth1.SetTextColor(Color.Black);
                            aDay1.RequestFocus();
                        }
                    }
                };
                aDay1.TextChanged += (sender, e) =>
                {
                    if (aDay1.Text.Length == 2)
                    {
                        int d1 = Convert.ToInt32(aDay1.Text);
                        if (d1 > 31)
                        {
                            aDay1.SetTextColor(Color.Red);
                        }
                        else
                        {
                            aDay1.SetTextColor(Color.Black);
                            aWeight.RequestFocus();
                        }
                    }
                };
                aWeight.TextChanged += (sender, e) =>
                {
                    if (aWeight.Text.Length <= 5 && aWeight.Text.Length > 0)
                    {
                        double w = Convert.ToDouble(aWeight.Text);
                        if (w > 150)
                        {
                            aWeight.SetTextColor(Color.Red);
                        }
                        else
                        {
                            aWeight.SetTextColor(Color.Black);
                            
                        }
                        
                    }
                };
                aHeight.TextChanged += (sender, e) =>
                {
                if (aHeight.Text.Length < 5 && aHeight.Text.Length > 0)
                { 
                            aHeight.SetTextColor(Color.Black);
                }
                };
                aHeight.TextChanged += (sender, e) =>
                {
                    if (aHeight.Text.Length <= 5 && aHeight.Text.Length > 0)
                    {
                        double h = Convert.ToDouble(aHeight.Text);
                        if (h > 250)
                        {
                            aHeight.SetTextColor(Color.Red);
                        }
                        else
                        {
                            aHeight.SetTextColor(Color.Black);
                            
                        }
                       
                    }
                };
            aHC.TextChanged += (sender, e) =>
            {
                if (aHC.Text.Length <= 4 && aHC.Text.Length > 0)
                {
                    double hc = Convert.ToDouble(aHC.Text);
                    if (hc > 100)
                    {
                        aHC.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aHC.SetTextColor(Color.Black);

                    }

                }
            };


        }
    }
}
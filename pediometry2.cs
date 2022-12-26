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
using Android.Graphics;

namespace MOFIDAPP
{
    [Activity(Label = "Blood Pressure")]
    public class pediometry2 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.pediometry2);
            var back = FindViewById<Button>(Resource.Id.back);
            back.Click += delegate { StartActivity(typeof(MainActivity)); };
            var aYear = FindViewById<EditText>(Resource.Id.editText5);
            var aMonth = FindViewById<EditText>(Resource.Id.editText4);
            var aDay = FindViewById<EditText>(Resource.Id.editText3);
            var aSBP = FindViewById<EditText>(Resource.Id.editText2);
            var aDBP = FindViewById<EditText>(Resource.Id.editText1);
            var LAN = Application.Context.GetSharedPreferences("language", Android.Content.FileCreationMode.Private);
            var aHPer = FindViewById<EditText>(Resource.Id.editText7);
            var Cal = FindViewById<Button>(Resource.Id.Cal);
            var ResultBP = FindViewById<TextView>(Resource.Id.textView1);
            var ResultHC = FindViewById<TextView>(Resource.Id.textView2);
            var ResultDBP = FindViewById<TextView>(Resource.Id.textView3);
            var BirthDate = FindViewById<TextView>(Resource.Id.textView5);
            var Gender = FindViewById<ToggleButton>(Resource.Id.toggleButton1);
            var Lay = FindViewById<LinearLayout>(Resource.Id.Lay);
            var age = FindViewById<Button>(Resource.Id.button2);
            var AgeText = FindViewById<TextView>(Resource.Id.textView6);
            var ageLay = FindViewById<LinearLayout>(Resource.Id.linearLayout4);
            var aYear1 = FindViewById<EditText>(Resource.Id.editText10);
            var aMonth1 = FindViewById<EditText>(Resource.Id.editText11);
            var aDay1 = FindViewById<EditText>(Resource.Id.editText12);
            var apoint = FindViewById<TextView>(Resource.Id.textView7);
            string PSBP="";
            string PDBP="";
            string PAge="";
            
            string point = "";
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
            if(LAN.GetInt("lang",0) == 0)
            {
                PSBP = "لطفا فشار خون سیستولیک را به درستی وارد کنید";
                PDBP = "لطفا فشار خون دیاستولیک را به درستی وارد کنید";
                PAge = "لطفا سن را به درستی وارد کنید";
                
                aHPer.Hint = "قد(cm)";
                BirthDate.Text = "تاریخ تولد";
                AgeText.Text = "تاریخ امروز";
                Gender.TextOn = "پسر";
                Gender.TextOff = "دختر";
                Gender.Text = "دختر";
                age.Text = "سن به عدد";
                Cal.Text = "محاسبه";
                back.Text = "صفحه ی اصلی";
                point = "*در صورت وارد کردن قد نتایج دقیق تر خواهد بود";
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
                PSBP = "Please enter systolic blood pressure properly";
                PDBP = "Please enter diastolic blood pressure properly";
                PAge = "Please enter age properly";
                aHPer.Hint = "Height(cm)";
                point = "*In order to more accurate results please enter height";
                BirthDate.Text = "Birth date";
                AgeText.Text = "Today's date";
                Gender.TextOn = "Male";
                Gender.Text = "Female";
                Gender.TextOff = "Female";
                age.Text = "Age by number";                
                Cal.Text = "Calculate";
                back.Text = "Main page";
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
            Cal.Click += (e, m) =>

                {
                    if (Gender.Checked)
                    {
                        Lay.SetBackgroundColor(Color.LightSkyBlue);
                    }
                    else
                    {
                        Lay.SetBackgroundColor(Color.LightPink);
                    }

                    int Year = 0;
                    int Month = 0;
                    int Day = 0;
                    double SBP = 0;
                    double DBP = 0;
                    double MeanSBP = 0;
                    double MeanDBP = 0;
                    double PerSBP = 0;
                    double PerDBP = 0;
                    
                    double Height = 0;
                    double HPer = 50;
                    double MeanL = 0;
                    double SDL = 0;
                    double ZL = 0;
                    int year1 = 0;
                    int month1 = 0;
                    int day1 = 0;
                    

                    if (aHPer.Text != "")
                    {
                        Height = Convert.ToDouble(aHPer.Text);
                    }
                    if (aYear.Text != "")
                    {
                        Year = Convert.ToInt32(aYear.Text);
                    }
                    if (aMonth.Text != "")
                    {
                        Month = Convert.ToInt32(aMonth.Text);

                    }
                    if (aDay.Text != "")
                    {
                        Day = Convert.ToInt32(aDay.Text);
                    }
                    if (aSBP.Text != "")
                    {
                        SBP = Convert.ToDouble(aSBP.Text);
                    }
                    if (aDBP.Text != "")
                    {
                        DBP = Convert.ToDouble(aDBP.Text);

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

                    int Num = 0;
                    

                    if (age.Text == "سن به تاریخ" || age.Text=="Age by date")
                    {
                        Num = 360 * Year + Day + 30 * Month;
                        
                    }
                    else
                    {
                        Num = 360 * (Year - year1) + 30 * (Month - month1) + (Day - day1);

                    }
                   

                    //height percentile
                    if (Height != 0)
                    {
                        if (Gender.Checked)
                        {
                            if (Num >= 0 && Num < 7)
                            {
                                MeanL = 49.88;
                                SDL = 1.89;

                            }
                            else if (Num >= 7 && Num < 14)
                            {
                                MeanL = 51.11;
                                SDL = 1.90;
                            }
                            else if (Num >= 14 && Num < 22)
                            {
                                MeanL = 52.34;
                                SDL = 1.91;
                            }
                            else if (Num >= 22 && Num < 30)
                            {
                                MeanL = 53.39;
                                SDL = 1.92;
                            }
                            else if (Num >= 30 && Num < 60)
                            {
                                MeanL = 54.72;
                                SDL = 1.94;
                            }
                            else if (Num >= 60 && Num < 90)
                            {
                                MeanL = 58.42;
                                SDL = 2;
                            }
                            else if (Num >= 90 && Num < 120)
                            {
                                MeanL = 61.42;
                                SDL = 2.04;
                            }
                            else if (Num >= 120 && Num < 150)
                            {
                                MeanL = 63.88;
                                SDL = 2.08;
                            }
                            else if (Num >= 150 && Num < 180)
                            {
                                MeanL = 65.9;
                                SDL = 2.11;
                            }
                            else if (Num >= 180 && Num < 210)
                            {
                                MeanL = 67.62;
                                SDL = 2.14;
                            }
                            else if (Num >= 210 && Num < 240)
                            {
                                MeanL = 69.16;
                                SDL = 2.17;
                            }
                            else if (Num >= 240 && Num < 270)
                            {
                                MeanL = 70.59;
                                SDL = 2.2;
                            }
                            else if (Num >= 270 && Num < 300)
                            {
                                MeanL = 71.96;
                                SDL = 2.24;
                            }
                            else if (Num >= 300 && Num < 330)
                            {
                                MeanL = 73.28;
                                SDL = 2.28;
                            }
                            else if (Num >= 330 && Num < 360)
                            {
                                MeanL = 74.53;
                                SDL = 2.32;
                            }
                            else if (Num >= 360 && Num < 390)
                            {
                                MeanL = 75.74;
                                SDL = 2.32;
                            }
                            else if (Num >= 390 && Num < 420)
                            {
                                MeanL = 76.91;
                                SDL = 2.42;
                            }
                            else if (Num >= 420 && Num < 450)
                            {
                                MeanL = 78.04;
                                SDL = 2.47;
                            }
                            else if (Num >= 450 && Num < 480)
                            {
                                MeanL = 79.14;
                                SDL = 2.53;
                            }
                            else if (Num >= 480 && Num < 510)
                            {
                                MeanL = 80.21;
                                SDL = 2.58;
                            }
                            else if (Num >= 510 && Num < 540)
                            {
                                MeanL = 81.24;
                                SDL = 2.64;
                            }
                            else if (Num >= 540 && Num < 570)
                            {
                                MeanL = 82.25;
                                SDL = 2.69;
                            }
                            else if (Num >= 570 && Num < 600)
                            {
                                MeanL = 83.24;
                                SDL = 2.75;
                            }
                            else if (Num >= 600 && Num < 630)
                            {
                                MeanL = 84.19;
                                SDL = 2.81;
                            }
                            else if (Num >= 630 && Num < 660)
                            {
                                MeanL = 85.13;
                                SDL = 2.87;
                            }
                            else if (Num >= 660 && Num < 690)
                            {
                                MeanL = 86.04;
                                SDL = 2.93;
                            }
                            else if (Num >= 690 && Num < 720)
                            {
                                MeanL = 86.94;
                                SDL = 2.99;
                            }
                            else if (Num >= 720 && Num < 750) //24
                            {
                                MeanL = 87.11;
                                SDL = 3.05;
                            }
                            else if (Num >= 750 && Num < 780)
                            {
                                MeanL = 87.97;
                                SDL = 3.11;
                            }
                            else if (Num >= 780 && Num < 810)
                            {
                                MeanL = 88.80;
                                SDL = 3.17;
                            }
                            else if (Num >= 810 && Num < 840)
                            {
                                MeanL = 89.61;
                                SDL = 3.23;
                            }
                            else if (Num >= 840 && Num < 870)
                            {
                                MeanL = 90.41;
                                SDL = 3.29;
                            }
                            else if (Num >= 870 && Num < 900)
                            {
                                MeanL = 91.18;
                                SDL = 3.35;
                            }
                            else if (Num >= 900 && Num < 930)
                            {
                                MeanL = 91.93;
                                SDL = 3.40;
                            }
                            else if (Num >= 930 && Num < 960)
                            {
                                MeanL = 92.66;
                                SDL = 3.45;
                            }
                            else if (Num >= 960 && Num < 990)
                            {
                                MeanL = 93.37;
                                SDL = 3.51;
                            }
                            else if (Num >= 990 && Num < 1020)
                            {
                                MeanL = 94.07;
                                SDL = 3.56;
                            }
                            else if (Num >= 1020 && Num < 1050)
                            {
                                MeanL = 94.75;
                                SDL = 3.61;
                            }
                            else if (Num >= 1050 && Num < 1080)
                            {
                                MeanL = 95.42;
                                SDL = 3.66;
                            }
                            else if (Num >= 1080 && Num < 1110)
                            {
                                MeanL = 96.08;
                                SDL = 3.7;
                            }
                            else if (Num >= 1110 && Num < 1140)
                            {
                                MeanL = 96.73;
                                SDL = 3.75;
                            }

                            else if (Num >= 1140 && Num < 1170)
                            {
                                MeanL = 97.37;
                                SDL = 3.79;
                            }
                            else if (Num >= 1170 && Num < 1200)
                            {
                                MeanL = 98;
                                SDL = 3.84;
                            }
                            else if (Num >= 1200 && Num < 1230)
                            {
                                MeanL = 98.63;
                                SDL = 3.88;
                            }
                            else if (Num >= 1230 && Num < 1260)
                            {
                                MeanL = 99.24;
                                SDL = 3.92;
                            }
                            else if (Num >= 1260 && Num < 1290)
                            {
                                MeanL = 99.85;
                                SDL = 3.96;
                            }
                            else if (Num >= 1290 && Num < 1320)
                            {
                                MeanL = 100.44;
                                SDL = 4;
                            }
                            else if (Num >= 1320 && Num < 1350)
                            {
                                MeanL = 101.03;
                                SDL = 4.04;
                            }
                            else if (Num >= 1350 && Num < 1380)
                            {
                                MeanL = 101.61;
                                SDL = 4.08;
                            }
                            else if (Num >= 1380 && Num < 1410)
                            {
                                MeanL = 102.19;
                                SDL = 4.11;
                            }
                            else if (Num >= 1410 && Num < 1440)
                            {
                                MeanL = 102.76;
                                SDL = 4.15;
                            }
                            else if (Num >= 1440 && Num < 1470)
                            {
                                MeanL = 103.32;
                                SDL = 4.19;
                            }
                            else if (Num >= 1470 && Num < 1500)
                            {
                                MeanL = 103.88;
                                SDL = 4.23;
                            }
                            else if (Num >= 1500 && Num < 1530)
                            {
                                MeanL = 104.44;
                                SDL = 4.26;
                            }
                            else if (Num >= 1530 && Num < 1560)
                            {
                                MeanL = 105;
                                SDL = 4.3;
                            }
                            else if (Num >= 1560 && Num < 1590)
                            {
                                MeanL = 105.59;
                                SDL = 4.34;
                            }
                            else if (Num >= 1590 && Num < 1620)
                            {
                                MeanL = 106.11;
                                SDL = 4.37;
                            }
                            else if (Num >= 1620 && Num < 1650)
                            {
                                MeanL = 106.66;
                                SDL = 4.41;
                            }
                            else if (Num >= 1650 && Num < 1680)
                            {
                                MeanL = 107.21;
                                SDL = 4.45;
                            }
                            else if (Num >= 1680 && Num < 1710)
                            {
                                MeanL = 107.76;
                                SDL = 4.48;
                            }
                            else if (Num >= 1710 && Num < 1740)
                            {
                                MeanL = 108.31;
                                SDL = 4.52;
                            }
                            else if (Num >= 1740 && Num < 1770)
                            {
                                MeanL = 108.86;
                                SDL = 4.56;
                            }
                            else if (Num >= 1770 && Num < 1800)
                            {
                                MeanL = 109.41;
                                SDL = 4.59;
                            }
                            else if (Num >= 1800 && Num < 1830)
                            {
                                MeanL = 109.96;
                                SDL = 4.63;
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
                        }
                        else
                        {
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
                            else if (Num >= 30 && Num < 60)
                            {
                                MeanL = 53.68;
                                SDL = 1.95;
                            }
                            else if (Num >= 60 && Num < 90)
                            {
                                MeanL = 57.06;
                                SDL = 2;
                            }
                            else if (Num >= 90 && Num < 120)
                            {
                                MeanL = 59.80;
                                SDL = 2.1;
                            }
                            else if (Num >= 120 && Num < 150)
                            {
                                MeanL = 62.08;
                                SDL = 2.16;
                            }
                            else if (Num >= 150 && Num < 180)
                            {
                                MeanL = 64.03;
                                SDL = 2.21;
                            }
                            else if (Num >= 180 && Num < 210)
                            {
                                MeanL = 65.73;
                                SDL = 2.26;
                            }
                            else if (Num >= 210 && Num < 240)
                            {
                                MeanL = 67.28;
                                SDL = 2.36;
                            }
                            else if (Num >= 240 && Num < 270)
                            {
                                MeanL = 68.74;
                                SDL = 2.36;
                            }
                            else if (Num >= 270 && Num < 300)
                            {
                                MeanL = 70.14;
                                SDL = 2.41;
                            }
                            else if (Num >= 300 && Num < 330)
                            {
                                MeanL = 71.48;
                                SDL = 2.46;
                            }
                            else if (Num >= 330 && Num < 360)
                            {
                                MeanL = 72.77;
                                SDL = 2.52;
                            }
                            else if (Num >= 360 && Num < 390)
                            {
                                MeanL = 74.01;
                                SDL = 2.57;
                            }
                            else if (Num >= 390 && Num < 420)
                            {
                                MeanL = 75.21;
                                SDL = 2.62;
                            }
                            else if (Num >= 420 && Num < 450)
                            {
                                MeanL = 76.38;
                                SDL = 2.68;
                            }
                            else if (Num >= 450 && Num < 480)
                            {
                                MeanL = 77.5;
                                SDL = 2.39;
                            }
                            else if (Num >= 480 && Num < 510)
                            {
                                MeanL = 78.6;
                                SDL = 2.79;
                            }
                            else if (Num >= 510 && Num < 540)
                            {
                                MeanL = 79.67;
                                SDL = 2.84;
                            }
                            else if (Num >= 540 && Num < 570)
                            {
                                MeanL = 80.7;
                                SDL = 2.9;
                            }
                            else if (Num >= 570 && Num < 600)
                            {
                                MeanL = 81.71;
                                SDL = 2.95;
                            }
                            else if (Num >= 600 && Num < 630)
                            {
                                MeanL = 82.7;
                                SDL = 3.01;
                            }
                            else if (Num >= 630 && Num < 660)
                            {
                                MeanL = 83.66;
                                SDL = 3.06;
                            }
                            else if (Num >= 660 && Num < 690)
                            {
                                MeanL = 84.6;
                                SDL = 3.12;
                            }
                            else if (Num >= 690 && Num < 720)
                            {
                                MeanL = 85.52;
                                SDL = 3.17;
                            }
                            else if (Num >= 720 && Num < 750)
                            {
                                MeanL = 85.71;
                                SDL = 3.22;
                            }
                            else if (Num >= 750 && Num < 780)
                            {
                                MeanL = 86.59;
                                SDL = 3.27;
                            }
                            else if (Num >= 780 && Num < 810)
                            {
                                MeanL = 87.44;
                                SDL = 3.33;
                            }
                            else if (Num >= 810 && Num < 840)
                            {
                                MeanL = 88.28;
                                SDL = 3.38;
                            }
                            else if (Num >= 840 && Num < 870)
                            {
                                MeanL = 89.1;
                                SDL = 3.43;
                            }
                            else if (Num >= 870 && Num < 900)
                            {
                                MeanL = 89.89;
                                SDL = 3.48;
                            }
                            else if (Num >= 900 && Num < 930)
                            {
                                MeanL = 90.67;
                                SDL = 3.53;
                            }
                            else if (Num >= 930 && Num < 960)
                            {
                                MeanL = 91.44;
                                SDL = 3.57;
                            }
                            else if (Num >= 960 && Num < 990)
                            {
                                MeanL = 92.19;
                                SDL = 3.62;
                            }
                            else if (Num >= 990 && Num < 1020)
                            {
                                MeanL = 92.92;
                                SDL = 3.62;
                            }
                            else if (Num >= 1020 && Num < 1050)
                            {
                                MeanL = 93.64;
                                SDL = 3.71;
                            }
                            else if (Num >= 1050 && Num < 1080)
                            {
                                MeanL = 94.35;
                                SDL = 3.76;
                            }
                            else if (Num >= 1080 && Num < 1110)
                            {
                                MeanL = 95.05;
                                SDL = 3.8;
                            }
                            else if (Num >= 1110 && Num < 1140)
                            {
                                MeanL = 95.73;
                                SDL = 3.85;
                            }
                            else if (Num >= 1140 && Num < 1170)
                            {
                                MeanL = 96.41;
                                SDL = 3.89;
                            }

                            else if (Num >= 1170 && Num < 1200)
                            {
                                MeanL = 97.08;
                                SDL = 3.93;
                            }
                            else if (Num >= 1200 && Num < 1230)
                            {
                                MeanL = 97.74;
                                SDL = 3.98;
                            }
                            else if (Num >= 1230 && Num < 1260)
                            {
                                MeanL = 98.40;
                                SDL = 4.02;
                            }
                            else if (Num >= 1260 && Num < 1290)
                            {
                                MeanL = 99.04;
                                SDL = 4.06;
                            }
                            else if (Num >= 1290 && Num < 1320)
                            {
                                MeanL = 99.67;
                                SDL = 4.1;
                            }
                            else if (Num >= 1320 && Num < 1350)
                            {
                                MeanL = 100.3;
                                SDL = 4.14;
                            }
                            else if (Num >= 1350 && Num < 1380)
                            {
                                MeanL = 100.92;
                                SDL = 4.18;
                            }
                            else if (Num >= 1380 && Num < 1410)
                            {
                                MeanL = 101.53;
                                SDL = 4.22;
                            }
                            else if (Num >= 1410 && Num < 1440)
                            {
                                MeanL = 102.13;
                                SDL = 4.26;
                            }
                            else if (Num >= 1440 && Num < 1470)
                            {
                                MeanL = 102.73;
                                SDL = 4.3;
                            }
                            else if (Num >= 1470 && Num < 1500)
                            {
                                MeanL = 103.31;
                                SDL = 4.34;
                            }
                            else if (Num >= 1500 && Num < 1530)
                            {
                                MeanL = 103.90;
                                SDL = 4.38;
                            }
                            else if (Num >= 1530 && Num < 1560)
                            {
                                MeanL = 104.47;
                                SDL = 4.42;
                            }
                            else if (Num >= 1560 && Num < 1590)
                            {
                                MeanL = 105.04;
                                SDL = 4.46;
                            }
                            else if (Num >= 1590 && Num < 1620)
                            {
                                MeanL = 105.61;
                                SDL = 4.49;
                            }
                            else if (Num >= 1620 && Num < 1650)
                            {
                                MeanL = 106.17;
                                SDL = 4.53;
                            }
                            else if (Num >= 1650 && Num < 1680)
                            {
                                MeanL = 106.72;
                                SDL = 4.57;
                            }
                            else if (Num >= 1680 && Num < 1710)
                            {
                                MeanL = 107.27;
                                SDL = 4.61;
                            }
                            else if (Num >= 1710 && Num < 1740)
                            {
                                MeanL = 107.82;
                                SDL = 4.64;
                            }
                            else if (Num >= 1740 && Num < 1770)
                            {
                                MeanL = 108.36;
                                SDL = 4.68;
                            }
                            else if (Num >= 1770 && Num < 1800)
                            {
                                MeanL = 108.89;
                                SDL = 4.71;
                            }
                            else if (Num >= 1800 && Num < 1830)
                            {
                                MeanL = 109.42;
                                SDL = 4.75;
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
                        }
                    }
                    ZL = (Height - MeanL) / SDL;
                    if (ZL < -1.645)
                    {
                        HPer = 1;
                    }
                    if (-1.645 <= ZL && ZL < -1.282)
                    {
                        HPer = 7;
                    }
                    if (-1.282 <= ZL && ZL < -0.674)
                    {
                        HPer = 20;
                    }
                    if (-0.674 <= ZL && ZL < 0.674)
                    {
                        HPer = 50;
                    }
                    if (0.674 <= ZL && ZL < 1.282)
                    {
                        HPer = 80;
                    }
                    if (1.282 <= ZL && ZL < 1.645)
                    {
                        HPer = 93;
                    }
                    if (1.645 <= ZL)
                    {
                        HPer = 99;
                    }

                        if (Gender.Checked)
                    {
                        //blood pressure male
                        if (HPer < 5)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 80;
                                PerSBP = 94;
                                MeanDBP = 34;
                                PerDBP = 49;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 84;
                                PerSBP = 97;
                                MeanDBP = 39;
                                PerDBP = 54;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 86;
                                PerSBP = 100;
                                MeanDBP = 44;
                                PerDBP = 59;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 88;
                                PerSBP = 102;
                                MeanDBP = 47;
                                PerDBP = 62;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 90;
                                PerSBP = 104;
                                MeanDBP = 50;
                                PerDBP = 65;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 91;
                                PerSBP = 105;
                                MeanDBP = 53;
                                PerDBP = 68;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 92;
                                PerSBP = 106;
                                MeanDBP = 55;
                                PerDBP = 70;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 94;
                                PerSBP = 107;
                                MeanDBP = 56;
                                PerDBP = 71;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 95;
                                PerSBP = 109;
                                MeanDBP = 57;
                                PerDBP = 72;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 97;
                                PerSBP = 111;
                                MeanDBP = 58;
                                PerDBP = 73;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 99;
                                PerSBP = 113;
                                MeanDBP = 59;
                                PerDBP = 74;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 101;
                                PerSBP = 115;
                                MeanDBP = 59;
                                PerDBP = 74;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 104;
                                PerSBP = 117;
                                MeanDBP = 60;
                                PerDBP = 75;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 106;
                                PerSBP = 120;
                                MeanDBP = 60;
                                PerDBP = 75;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 109;
                                PerSBP = 122;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 111;
                                PerSBP = 125;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 114;
                                PerSBP = 127;
                                MeanDBP = 65;
                                PerDBP = 80;

                            }
                        }
                        if (HPer >= 5 && HPer < 10)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 81;
                                PerSBP = 95;
                                MeanDBP = 35;
                                PerDBP = 50;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 85;
                                PerSBP = 99;
                                MeanDBP = 40;
                                PerDBP = 55;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 87;
                                PerSBP = 101;
                                MeanDBP = 44;
                                PerDBP = 59;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 89;
                                PerSBP = 103;
                                MeanDBP = 48;
                                PerDBP = 63;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 91;
                                PerSBP = 105;
                                MeanDBP = 51;
                                PerDBP = 66;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 92;
                                PerSBP = 106;
                                MeanDBP = 53;
                                PerDBP = 68;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 94;
                                PerSBP = 107;
                                MeanDBP = 55;
                                PerDBP = 70;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 95;
                                PerSBP = 109;
                                MeanDBP = 57;
                                PerDBP = 72;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 96;
                                PerSBP = 110;
                                MeanDBP = 58;
                                PerDBP = 73;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 98;
                                PerSBP = 112;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 59;
                                PerDBP = 74;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 102;
                                PerSBP = 116;
                                MeanDBP = 60;
                                PerDBP = 75;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 105;
                                PerSBP = 118;
                                MeanDBP = 60;
                                PerDBP = 75;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 107;
                                PerSBP = 121;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 110;
                                PerSBP = 124;
                                MeanDBP = 62;
                                PerDBP = 77;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 112;
                                PerSBP = 126;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 115;
                                PerSBP = 128;
                                MeanDBP = 66;
                                PerDBP = 80;

                            }

                        }
                        if (HPer >= 10 && HPer < 25)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 83;
                                PerSBP = 97;
                                MeanDBP = 36;
                                PerDBP = 51;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 87;
                                PerSBP = 100;
                                MeanDBP = 41;
                                PerDBP = 56;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 89;
                                PerSBP = 103;
                                MeanDBP = 45;
                                PerDBP = 60;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 91;
                                PerSBP = 105;
                                MeanDBP = 49;
                                PerDBP = 64;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 93;
                                PerSBP = 106;
                                MeanDBP = 52;
                                PerDBP = 67;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 94;
                                PerSBP = 108;
                                MeanDBP = 54;
                                PerDBP = 69;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 95;
                                PerSBP = 109;
                                MeanDBP = 56;
                                PerDBP = 71;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 97;
                                PerSBP = 110;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 98;
                                PerSBP = 112;
                                MeanDBP = 59;
                                PerDBP = 74;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 102;
                                PerSBP = 115;
                                MeanDBP = 60;
                                PerDBP = 75;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 104;
                                PerSBP = 118;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 106;
                                PerSBP = 120;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 109;
                                PerSBP = 123;
                                MeanDBP = 62;
                                PerDBP = 77;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 112;
                                PerSBP = 125;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 114;
                                PerSBP = 128;
                                MeanDBP = 64;
                                PerDBP = 79;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 116;
                                PerSBP = 130;
                                MeanDBP = 66;
                                PerDBP = 81;

                            }

                        }
                        if (HPer >= 25 && HPer < 75)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 85;
                                PerSBP = 99;
                                MeanDBP = 37;
                                PerDBP = 52;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 88;
                                PerSBP = 102;
                                MeanDBP = 42;
                                PerDBP = 57;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 91;
                                PerSBP = 105;
                                MeanDBP = 46;
                                PerDBP = 61;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 93;
                                PerSBP = 107;
                                MeanDBP = 50;
                                PerDBP = 65;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 95;
                                PerSBP = 108;
                                MeanDBP = 53;
                                PerDBP = 68;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 96;
                                PerSBP = 110;
                                MeanDBP = 55;
                                PerDBP = 70;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 97;
                                PerSBP = 111;
                                MeanDBP = 57;
                                PerDBP = 72;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 99;
                                PerSBP = 112;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 75;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 102;
                                PerSBP = 115;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 104;
                                PerSBP = 117;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 106;
                                PerSBP = 120;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 108;
                                PerSBP = 122;
                                MeanDBP = 62;
                                PerDBP = 77;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 111;
                                PerSBP = 125;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 113;
                                PerSBP = 127;
                                MeanDBP = 64;
                                PerDBP = 79;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 116;
                                PerSBP = 130;
                                MeanDBP = 65;
                                PerDBP = 80;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 118;
                                PerSBP = 132;
                                MeanDBP = 67;
                                PerDBP = 82;

                            }
                        }      
                            if (HPer >= 75 && HPer < 90)
                            {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 87;
                                PerSBP = 100;
                                MeanDBP = 38;
                                PerDBP = 53;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 90;
                                PerSBP = 104;
                                MeanDBP = 43;
                                PerDBP = 58;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 93;
                                PerSBP = 107;
                                MeanDBP = 47;
                                PerDBP = 62;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 95;
                                PerSBP = 109;
                                MeanDBP = 51;
                                PerDBP = 66;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 96;
                                PerSBP = 110;
                                MeanDBP = 54;
                                PerDBP = 69;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 98;
                                PerSBP = 111;
                                MeanDBP = 56;
                                PerDBP = 71;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 99;
                                PerSBP = 113;
                                MeanDBP = 58;
                                PerDBP = 73;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 102;
                                PerSBP = 115;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 103;
                                PerSBP = 117;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 105;
                                PerSBP = 119;
                                MeanDBP = 62;
                                PerDBP = 77;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 108;
                                PerSBP = 121;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 110;
                                PerSBP = 124;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 113;
                                PerSBP = 126;
                                MeanDBP = 64;
                                PerDBP = 79;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 115;
                                PerSBP = 129;
                                MeanDBP = 65;
                                PerDBP = 80;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 118;
                                PerSBP = 131;
                                MeanDBP = 66;
                                PerDBP = 81;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 120;
                                PerSBP = 134;
                                MeanDBP = 68;
                                PerDBP = 83;

                            }

                        }
                            if (HPer >= 90 && HPer < 95)
                            {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 88;
                                PerSBP = 102;
                                MeanDBP = 39;
                                PerDBP = 53;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 92;
                                PerSBP = 105;
                                MeanDBP = 44;
                                PerDBP = 58;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 94;
                                PerSBP = 108;
                                MeanDBP = 48;
                                PerDBP = 63;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 96;
                                PerSBP = 110;
                                MeanDBP = 51;
                                PerDBP = 66;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 98;
                                PerSBP = 111;
                                MeanDBP = 55;
                                PerDBP = 69;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 99;
                                PerSBP = 113;
                                MeanDBP = 57;
                                PerDBP = 72;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 59;
                                PerDBP = 74;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 102;
                                PerSBP = 115;
                                MeanDBP = 60;
                                PerDBP = 75;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 103;
                                PerSBP = 117;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 105;
                                PerSBP = 119;
                                MeanDBP = 62;
                                PerDBP = 77;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 107;
                                PerSBP = 120;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 109;
                                PerSBP = 123;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 111;
                                PerSBP = 125;
                                MeanDBP = 64;
                                PerDBP = 79;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 114;
                                PerSBP = 128;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 117;
                                PerSBP = 130;
                                MeanDBP = 66;
                                PerDBP = 80;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 119;
                                PerSBP = 133;
                                MeanDBP = 67;
                                PerDBP = 82;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 121;
                                PerSBP = 135;
                                MeanDBP = 69;
                                PerDBP = 84;

                            }

                        }
                            if (HPer >= 95)
                            {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 89;
                                PerSBP = 103;
                                MeanDBP = 39;
                                PerDBP = 54;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 92;
                                PerSBP = 106;
                                MeanDBP = 44;
                                PerDBP = 59;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 95;
                                PerSBP = 109;
                                MeanDBP = 48;
                                PerDBP = 63;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 97;
                                PerSBP = 111;
                                MeanDBP = 52;
                                PerDBP = 67;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 98;
                                PerSBP = 112;
                                MeanDBP = 55;
                                PerDBP = 70;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 100;
                                PerSBP = 113;
                                MeanDBP = 57;
                                PerDBP = 72;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 101;
                                PerSBP = 115;
                                MeanDBP = 59;
                                PerDBP = 74;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 102;
                                PerSBP = 116;
                                MeanDBP = 61;
                                PerDBP = 76;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 104;
                                PerSBP = 118;
                                MeanDBP = 62;
                                PerDBP = 77;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 106;
                                PerSBP = 119;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 107;
                                PerSBP = 121;
                                MeanDBP = 63;
                                PerDBP = 78;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 110;
                                PerSBP = 123;
                                MeanDBP = 64;
                                PerDBP = 79;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 112;
                                PerSBP = 126;
                                MeanDBP = 64;
                                PerDBP = 79;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 115;
                                PerSBP = 128;
                                MeanDBP = 65;
                                PerDBP = 80;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 117;
                                PerSBP = 131;
                                MeanDBP = 66;
                                PerDBP = 81;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 120;
                                PerSBP = 134;
                                MeanDBP = 67;
                                PerDBP = 82;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 122;
                                PerSBP = 136;
                                MeanDBP = 70;
                                PerDBP = 84;

                            }

                        }
                            

                        }
                    
                    
                         else

                         {
                        //female Blood pressure
                        if (HPer < 5)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 83;
                                PerSBP = 97;
                                MeanDBP = 38;
                                PerDBP = 52;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 85;
                                PerSBP = 98;
                                MeanDBP = 43;
                                PerDBP = 57;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 86;
                                PerSBP = 100;
                                MeanDBP = 47;
                                PerDBP = 61;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 88;
                                PerSBP = 101;
                                MeanDBP = 50;
                                PerDBP = 64;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 89;
                                PerSBP = 103;
                                MeanDBP = 52;
                                PerDBP = 66;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 91;
                                PerSBP = 104;
                                MeanDBP = 54;
                                PerDBP = 68;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 93;
                                PerSBP = 106;
                                MeanDBP = 55;
                                PerDBP = 69;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 95;
                                PerSBP = 108;
                                MeanDBP = 57;
                                PerDBP = 71;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 96;
                                PerSBP = 110;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 98;
                                PerSBP = 112;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 102;
                                PerSBP = 116;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 104;
                                PerSBP = 117;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 106;
                                PerSBP = 119;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 107;
                                PerSBP = 120;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 108;
                                PerSBP = 121;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 108;
                                PerSBP = 122;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }

                        }
                        if (HPer>=5 && HPer < 10)
                            {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 84;
                                PerSBP = 97;
                                MeanDBP = 39;
                                PerDBP = 53;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 85;
                                PerSBP = 99;
                                MeanDBP = 44;
                                PerDBP = 58;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 87;
                                PerSBP = 100;
                                MeanDBP = 48;
                                PerDBP = 62;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 88;
                                PerSBP = 102;
                                MeanDBP = 50;
                                PerDBP = 64;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 90;
                                PerSBP = 103;
                                MeanDBP = 53;
                                PerDBP = 67;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 92;
                                PerSBP = 105;
                                MeanDBP = 54;
                                PerDBP = 68;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 93;
                                PerSBP = 107;
                                MeanDBP = 56;
                                PerDBP = 70;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 95;
                                PerSBP = 109;
                                MeanDBP = 57;
                                PerDBP = 71;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 97;
                                PerSBP = 110;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 99;
                                PerSBP = 112;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 101;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 103;
                                PerSBP = 116;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 105;
                                PerSBP = 118;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 106;
                                PerSBP = 120;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 108;
                                PerSBP = 121;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 108;
                                PerSBP = 122;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 109;
                                PerSBP = 122;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }

                        }
                        if (HPer >= 10 && HPer < 25)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 85;
                                PerSBP = 98;
                                MeanDBP = 39;
                                PerDBP = 53;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 87;
                                PerSBP = 100;
                                MeanDBP = 44;
                                PerDBP = 58;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 88;
                                PerSBP = 102;
                                MeanDBP = 48;
                                PerDBP = 62;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 90;
                                PerSBP = 103;
                                MeanDBP = 51;
                                PerDBP = 65;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 91;
                                PerSBP = 105;
                                MeanDBP = 53;
                                PerDBP = 67;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 93;
                                PerSBP = 106;
                                MeanDBP = 55;
                                PerDBP = 69;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 95;
                                PerSBP = 108;
                                MeanDBP = 56;
                                PerDBP = 70;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 96;
                                PerSBP = 110;
                                MeanDBP = 57;
                                PerDBP = 71;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 98;
                                PerSBP = 112;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 102;
                                PerSBP = 116;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 104;
                                PerSBP = 117;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 106;
                                PerSBP = 119;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 107;
                                PerSBP = 121;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 109;
                                PerSBP = 122;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 110;
                                PerSBP = 123;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 110;
                                PerSBP = 123;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }

                        }
                        if (HPer >= 25 && HPer < 75)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 86;
                                PerSBP = 100;
                                MeanDBP = 40;
                                PerDBP = 54;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 88;
                                PerSBP = 101;
                                MeanDBP = 45;
                                PerDBP = 59;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 89;
                                PerSBP = 103;
                                MeanDBP = 49;
                                PerDBP = 63;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 91;
                                PerSBP = 104;
                                MeanDBP = 52;
                                PerDBP = 66;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 93;
                                PerSBP = 106;
                                MeanDBP = 54;
                                PerDBP = 68;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 94;
                                PerSBP = 108;
                                MeanDBP = 56;
                                PerDBP = 70;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 96;
                                PerSBP = 109;
                                MeanDBP = 57;
                                PerDBP = 71;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 98;
                                PerSBP = 111;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 100;
                                PerSBP = 113;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 102;
                                PerSBP = 115;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 103;
                                PerSBP = 117;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 105;
                                PerSBP = 119;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 107;
                                PerSBP = 121;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 109;
                                PerSBP = 122;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 110;
                                PerSBP = 123;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 111;
                                PerSBP = 124;
                                MeanDBP = 66;
                                PerDBP = 80;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 111;
                                PerSBP = 125;
                                MeanDBP = 66;
                                PerDBP = 80;

                            }

                        }
                        if (HPer >= 75 && HPer < 90)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 88;
                                PerSBP = 101;
                                MeanDBP = 41;
                                PerDBP = 55;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 89;
                                PerSBP = 103;
                                MeanDBP = 46;
                                PerDBP = 60;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 91;
                                PerSBP = 104;
                                MeanDBP = 50;
                                PerDBP = 64;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 92;
                                PerSBP = 106;
                                MeanDBP = 52;
                                PerDBP = 67;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 94;
                                PerSBP = 107;
                                MeanDBP = 55;
                                PerDBP = 69;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 96;
                                PerSBP = 109;
                                MeanDBP = 56;
                                PerDBP = 70;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 97;
                                PerSBP = 111;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 99;
                                PerSBP = 113;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 101;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 103;
                                PerSBP = 116;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 105;
                                PerSBP = 118;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 107;
                                PerSBP = 120;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 109;
                                PerSBP = 122;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 110;
                                PerSBP = 124;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 111;
                                PerSBP = 125;
                                MeanDBP = 66;
                                PerDBP = 80;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 112;
                                PerSBP = 126;
                                MeanDBP = 66;
                                PerDBP = 81;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 113;
                                PerSBP = 126;
                                MeanDBP = 67;
                                PerDBP = 81;

                            }

                        }
                        if (HPer >= 90 && HPer < 95)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 89;
                                PerSBP = 102;
                                MeanDBP = 41;
                                PerDBP = 55;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 91;
                                PerSBP = 104;
                                MeanDBP = 46;
                                PerDBP = 61;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 92;
                                PerSBP = 106;
                                MeanDBP = 50;
                                PerDBP = 64;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 94;
                                PerSBP = 107;
                                MeanDBP = 53;
                                PerDBP = 67;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 95;
                                PerSBP = 109;
                                MeanDBP = 55;
                                PerDBP = 69;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 97;
                                PerSBP = 110;
                                MeanDBP = 57;
                                PerDBP = 71;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 99;
                                PerSBP = 112;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 100;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 102;
                                PerSBP = 116;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 104;
                                PerSBP = 118;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 106;
                                PerSBP = 119;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 108;
                                PerSBP = 121;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 110;
                                PerSBP = 123;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 111;
                                PerSBP = 125;
                                MeanDBP = 66;
                                PerDBP = 80;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 113;
                                PerSBP = 126;
                                MeanDBP = 67;
                                PerDBP = 81;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 114;
                                PerSBP = 127;
                                MeanDBP = 67;
                                PerDBP = 81;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 114;
                                PerSBP = 127;
                                MeanDBP = 67;
                                PerDBP = 81;

                            }

                        }
                        if (HPer >= 95)
                        {
                            if (Num >= 360 && Num < 720)
                            {
                                MeanSBP = 90;
                                PerSBP = 103;
                                MeanDBP = 42;
                                PerDBP = 56;

                            }
                            if (Num >= 720 && Num < 1080)
                            {
                                MeanSBP = 91;
                                PerSBP = 105;
                                MeanDBP = 47;
                                PerDBP = 61;

                            }
                            if (Num >= 1080 && Num < 1440)
                            {
                                MeanSBP = 93;
                                PerSBP = 106;
                                MeanDBP = 51;
                                PerDBP = 65;

                            }
                            if (Num >= 1440 && Num < 1800)
                            {
                                MeanSBP = 94;
                                PerSBP = 108;
                                MeanDBP = 54;
                                PerDBP = 68;

                            }
                            if (Num >= 1800 && Num < 2160)
                            {
                                MeanSBP = 96;
                                PerSBP = 109;
                                MeanDBP = 56;
                                PerDBP = 70;

                            }
                            if (Num >= 2160 && Num < 2520)
                            {
                                MeanSBP = 98;
                                PerSBP = 111;
                                MeanDBP = 58;
                                PerDBP = 72;

                            }
                            if (Num >= 2520 && Num < 2880)
                            {
                                MeanSBP = 99;
                                PerSBP = 113;
                                MeanDBP = 59;
                                PerDBP = 73;

                            }
                            if (Num >= 2880 && Num < 3240)
                            {
                                MeanSBP = 101;
                                PerSBP = 114;
                                MeanDBP = 60;
                                PerDBP = 74;

                            }
                            if (Num >= 3240 && Num < 3600)
                            {
                                MeanSBP = 103;
                                PerSBP = 116;
                                MeanDBP = 61;
                                PerDBP = 75;

                            }
                            if (Num >= 3600 && Num < 3960)
                            {
                                MeanSBP = 105;
                                PerSBP = 118;
                                MeanDBP = 62;
                                PerDBP = 76;

                            }
                            if (Num >= 3960 && Num < 4320)
                            {
                                MeanSBP = 107;
                                PerSBP = 120;
                                MeanDBP = 63;
                                PerDBP = 77;

                            }
                            if (Num >= 4320 && Num < 4680)
                            {
                                MeanSBP = 109;
                                PerSBP = 122;
                                MeanDBP = 64;
                                PerDBP = 78;

                            }
                            if (Num >= 4680 && Num < 5040)
                            {
                                MeanSBP = 110;
                                PerSBP = 124;
                                MeanDBP = 65;
                                PerDBP = 79;

                            }
                            if (Num >= 5040 && Num < 5400)
                            {
                                MeanSBP = 112;
                                PerSBP = 125;
                                MeanDBP = 66;
                                PerDBP = 80;

                            }
                            if (Num >= 5400 && Num < 5760)
                            {
                                MeanSBP = 113;
                                PerSBP = 127;
                                MeanDBP = 67;
                                PerDBP = 81;

                            }
                            if (Num >= 5760 && Num < 6120)
                            {
                                MeanSBP = 114;
                                PerSBP = 128;
                                MeanDBP = 68;
                                PerDBP = 82;

                            }
                            if (Num >= 6120 && Num < 6480)
                            {
                                MeanSBP = 115;
                                PerSBP = 128;
                                MeanDBP = 68;
                                PerDBP = 82;

                            }

                        }


                    }
                  
                    //result for blood pressure
                    double SDSBP = (PerSBP - MeanSBP) / 1.28;
                    double SDDBP = (PerDBP - MeanDBP) / 1.28;
                    double ZSBP = (SBP - MeanSBP) / SDSBP;
                    double ZDBP = (DBP - MeanDBP) / SDDBP;
                    double ZFSBP = (SBP - 5 - MeanSBP) / SDSBP;
                    double ZFDBP = (DBP - 5 - MeanDBP) / SDDBP;
                    if (Num >= 0 && Num < 6480)
                    {
                        if (Height > 200 || Height <= 0)
                        {
                            apoint.Text = point;
                        }
                        else
                        {
                            apoint.Text = "";
                        }
                        if (LAN.GetInt("lang", 0) == 0)
                        {
                            if (ZSBP < 1.28)
                            {
                                ResultBP.Text = "فشار خون سیستولیک طبیعی است" + "\n" + Perc(ZSBP);
                            }
                            if (ZDBP < 1.28)
                            {
                                ResultDBP.Text = "فشار خون دیاستولیک طبیعی است " + "\n" + Perc(ZDBP);
                            }
                            if (ZSBP >= 1.28 && ZSBP < 1.645)
                            {
                                ResultBP.Text = "در ریسک پر فشاری خون سیستولیک " + "\n" + Perc(ZSBP);
                            }
                            if (ZDBP >= 1.28 && ZDBP < 1.645)
                            {
                                ResultDBP.Text = "در ریسک پر فشاری خون دیاستولیک" + "\n" + Perc(ZDBP);
                            }
                            if (ZSBP >= 1.645)
                            {
                                if (ZFSBP >= 2.326)
                                {
                                    ResultBP.Text = "مرحل ی 2 پرفشاری خون سیستولیک " + "\n" + "Over 99th percentile + 5mmhg";
                                }
                                else
                                {
                                    ResultBP.Text = "مرحله ی 1 پرفشاری خون سیستولیک " + "\n" + Perc(ZSBP);
                                }
                            }
                            if (ZDBP >= 1.645)
                            {
                                if (ZFDBP >= 2.326)
                                {
                                    ResultDBP.Text = "مرحله ی 2 پرفشاری خون دیاستولیک" + "\n" + "Over 99th percentile + 5mmhg";
                                }
                                else
                                {
                                    ResultDBP.Text = "مرحله ی 1 پرفشاری خون دیاستولیک " + "\n" + Perc(ZDBP);
                                }
                            }
                            if (SBP == 0)
                            {
                                ResultBP.Text = "";
                            }
                            if (DBP == 0)
                            {
                                ResultDBP.Text = "";
                            }


                        }
                        else
                        {

                            if (ZSBP < 1.28)
                            {
                                ResultBP.Text = "Normal systolic blood pressure" + "\n" + Perc(ZSBP);
                            }
                            if (ZDBP < 1.28)
                            {
                                ResultDBP.Text = "Normal diastolic blood pressure" + "\n" + Perc(ZDBP);
                            }
                            if (ZSBP >= 1.28 && ZSBP < 1.645)
                            {
                                ResultBP.Text = "Systolic PreHypertension" + "\n" + Perc(ZSBP);
                            }
                            if (ZDBP >= 1.28 && ZDBP < 1.645)
                            {
                                ResultDBP.Text = "Diastolic PreHypertension" + "\n" + Perc(ZDBP);
                            }
                            if (ZSBP >= 1.645)
                            {
                                if (ZFSBP >= 2.326)
                                {
                                    ResultBP.Text = "Stage 2 systolic hypertension" + "\n" + "Over 99th percentile + 5mmhg";
                                }
                                else
                                {
                                    ResultBP.Text = "Stage 1 systolic hypertension " + "\n" + Perc(ZSBP);
                                }
                            }
                            if (ZDBP >= 1.645)
                            {
                                if (ZFDBP >= 2.326)
                                {
                                    ResultDBP.Text = "Stage 2 diastolic hypertension" + "\n" + "Over 99th percentile + 5mmhg";
                                }
                                else
                                {
                                    ResultDBP.Text = "Stage 2 diastolic hypertension " + "\n" + Perc(ZDBP);
                                }
                            }
                            if (SBP == 0)
                            {
                                ResultBP.Text = "";
                            }
                            if (DBP == 0)
                            {
                                ResultDBP.Text = "";
                            }
                        }
                    if (SBP>200||SBP<0)
                        {
                            ResultBP.Text = PSBP;
                        }
                    if(DBP>200||DBP<0)
                        {
                            ResultDBP.Text = PDBP;
                        }

                    }
                    else
                    {
                        ResultBP.Text = PAge;
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
                    if (aYear.Text.Length <= 4 && aYear.Text.Length > 0)
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
                            aSBP.RequestFocus();
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
                        aSBP.RequestFocus();
                    }
                }
            };
            if (aSBP.Text.Length < 3 && aSBP.Text.Length > 0)
            {
                aSBP.SetTextColor(Color.Black);
            }
            aSBP.TextChanged += (sender, e) =>
            {
                if (aSBP.Text.Length == 3)
                {
                    double d1 = Convert.ToDouble(aSBP.Text);
                    if (d1 > 220)
                    {
                        aSBP.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aSBP.SetTextColor(Color.Black);
                        aDBP.RequestFocus();
                    }
                    
                }
            };
            if (aDBP.Text.Length < 3 && aDBP.Text.Length > 0)
            {
                aDBP.SetTextColor(Color.Black);
            }
            aDBP.TextChanged += (sender, e) =>
            {
                if (aDBP.Text.Length == 3)
                {
                    double d1 = Convert.ToDouble(aDBP.Text);
                    if (d1 > 200)
                    {
                        aDBP.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aDBP.SetTextColor(Color.Black);
                        aHPer.RequestFocus();
                    }
                   
                }
            };
            if (aHPer.Text.Length < 3 && aHPer.Text.Length > 0)
            {
                aHPer.SetTextColor(Color.Black);
            }
            aHPer.TextChanged += (sender, e) =>
            {
                if (aHPer.Text.Length == 3)
                {
                    double d1 = Convert.ToDouble(aDBP.Text);
                    if (d1 > 200)
                    {
                        aHPer.SetTextColor(Color.Red);
                    }
                    else
                    {
                        aHPer.SetTextColor(Color.Black);
                       
                    }

                }
            };

        }
        }
    }

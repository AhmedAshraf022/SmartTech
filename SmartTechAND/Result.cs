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
using BarChart;

namespace SmartTechAND
{
    [Activity(Label = "Result", Icon = "@drawable/smarttech")]
    public class Result : Activity
    {
        string q1, q2, q3, q4;
        float q1f, q2f, q3f, q4f;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // set view
            SetContentView(Resource.Layout.Result);

            // Results
            ConvertingResults();

            // Elements
            var barChart = FindViewById<BarChartView>(Resource.Id.barChart);

            // Chart Data
            var Data = new BarModel[] 
            {
            new BarModel() { Value = q1f, Legend = "Q1", Color = Android.Graphics.Color.Red },
            new BarModel() { Value = q2f, Legend = "Q2", Color = Android.Graphics.Color.Blue },
            new BarModel() { Value = q3f, Legend = "Q3", Color = Android.Graphics.Color.Green },
            new BarModel() { Value = q4f, Legend = "Q4", Color = Android.Graphics.Color.Orange }
            };

            // code
            barChart.ItemsSource = Data;
        }

        private void ConvertingResults()
        {
            q1 = Intent.GetStringExtra("q1") ?? "Data not available";
            q2 = Intent.GetStringExtra("q2") ?? "Data not available";
            q3 = Intent.GetStringExtra("q3") ?? "Data not available";
            q4 = Intent.GetStringExtra("q4") ?? "Data not available";

            switch (q1)
            {
                case "Excellent":
                    q1f = 4f;
                    break;

                case "Good":
                    q1f = 3f;
                    break;

                case "Fair":
                    q1f = 2f;
                    break;

                case "Poor":
                    q1f = 1f;
                    break;

                default:
                    break;
            }

            switch (q2)
            {
                case "Excellent":
                    q2f = 4f;
                    break;

                case "Good":
                    q2f = 3f;
                    break;

                case "Fair":
                    q2f = 2f;
                    break;

                case "Poor":
                    q2f = 1f;
                    break;

                default:
                    break;
            }

            switch (q3)
            {
                case "Excellent":
                    q3f = 4f;
                    break;

                case "Good":
                    q3f = 3f;
                    break;

                case "Fair":
                    q3f = 2f;
                    break;

                case "Poor":
                    q3f = 1f;
                    break;

                default:
                    break;
            }

            switch (q4)
            {
                case "Excellent":
                    q4f = 4f;
                    break;

                case "Good":
                    q4f = 3f;
                    break;

                case "Fair":
                    q4f = 2f;
                    break;

                case "Poor":
                    q4f = 1f;
                    break;

                default:
                    break;
            }

        }
    }
}
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using BarChart;

namespace SmartTechAND
{
    [Activity(Label = "SmartTech", Icon = "@drawable/smarttech")]
    public class MainActivity : Activity
    {
        string q1, q2, q3, q4;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Elements
            var btnAnswer1Excellent = FindViewById<Button>(Resource.Id.btnAnswer1Excellent);
            var btnAnswer1Good = FindViewById<Button>(Resource.Id.btnAnswer1Good);
            var btnAnswer1Fair = FindViewById<Button>(Resource.Id.btnAnswer1Fair);
            var btnAnswer1Poor = FindViewById<Button>(Resource.Id.btnAnswer1Poor);

            var btnAnswer2Excellent = FindViewById<Button>(Resource.Id.btnAnswer2Excellent);
            var btnAnswer2Good = FindViewById<Button>(Resource.Id.btnAnswer2Good);
            var btnAnswer2Fair = FindViewById<Button>(Resource.Id.btnAnswer2Fair);
            var btnAnswer2Poor = FindViewById<Button>(Resource.Id.btnAnswer2Poor);

            var btnAnswer3Excellent = FindViewById<Button>(Resource.Id.btnAnswer3Excellent);
            var btnAnswer3Good = FindViewById<Button>(Resource.Id.btnAnswer3Good);
            var btnAnswer3Fair = FindViewById<Button>(Resource.Id.btnAnswer3Fair);
            var btnAnswer3Poor = FindViewById<Button>(Resource.Id.btnAnswer3Poor);

            var btnAnswer4Excellent = FindViewById<Button>(Resource.Id.btnAnswer4Excellent);
            var btnAnswer4Good = FindViewById<Button>(Resource.Id.btnAnswer4Good);
            var btnAnswer4Fair = FindViewById<Button>(Resource.Id.btnAnswer4Fair);
            var btnAnswer4Poor = FindViewById<Button>(Resource.Id.btnAnswer4Poor);

            var txtResult1 = FindViewById<TextView>(Resource.Id.txtResult1);
            var txtResult2 = FindViewById<TextView>(Resource.Id.txtResult2);
            var txtResult3 = FindViewById<TextView>(Resource.Id.txtResult3);
            var txtResult4 = FindViewById<TextView>(Resource.Id.txtResult4);

            var btnResult = FindViewById<Button>(Resource.Id.btnResult);

            // Attach event to drop zone
            txtResult1.Drag += txtResult1_Drag;
            txtResult2.Drag += TxtResult2_Drag;
            txtResult3.Drag += TxtResult3_Drag;
            txtResult4.Drag += TxtResult4_Drag;

            // Events
            btnAnswer1Excellent.LongClick += BtnAnswer1Excellent_LongClick;
            btnAnswer1Good.LongClick += BtnAnswer1Good_LongClick;
            btnAnswer1Fair.LongClick += BtnAnswer1Fair_LongClick;
            btnAnswer1Poor.LongClick += BtnAnswer1Poor_LongClick;

            btnAnswer2Excellent.LongClick += BtnAnswer2Excellent_LongClick;
            btnAnswer2Good.LongClick += BtnAnswer2Good_LongClick;
            btnAnswer2Fair.LongClick += BtnAnswer2Fair_LongClick;
            btnAnswer2Poor.LongClick += BtnAnswer2Poor_LongClick;

            btnAnswer3Excellent.LongClick += BtnAnswer3Excellent_LongClick;
            btnAnswer3Good.LongClick += BtnAnswer3Good_LongClick;
            btnAnswer3Fair.LongClick += BtnAnswer3Fair_LongClick;
            btnAnswer3Poor.LongClick += BtnAnswer3Poor_LongClick;

            btnAnswer4Excellent.LongClick += BtnAnswer4Excellent_LongClick;
            btnAnswer4Good.LongClick += BtnAnswer4Good_LongClick;
            btnAnswer4Fair.LongClick += BtnAnswer4Fair_LongClick;
            btnAnswer4Poor.LongClick += BtnAnswer4Poor_LongClick;

            btnResult.Click += BtnResult_Click;
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            var Result = new Intent(this, typeof(Result));

            Result.PutExtra("q1",q1);
            Result.PutExtra("q2", q2);
            Result.PutExtra("q3", q3);
            Result.PutExtra("q4", q4);

            StartActivity(Result);
        }

        private void BtnAnswer4Poor_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Poor4");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer4Fair_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Good4");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer4Good_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Good4");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer4Excellent_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Excellent4");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer3Poor_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Poor3");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer3Fair_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Fair3");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer3Good_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Good3");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer3Excellent_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Excellent3");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer2Poor_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Poor2");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer2Fair_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Fair2");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer2Good_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Good2");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer2Excellent_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Excellent2");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer1Poor_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Poor1");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer1Fair_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Fair1");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer1Good_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Good1");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void BtnAnswer1Excellent_LongClick(object sender, View.LongClickEventArgs e)
        {
            // Generate clip data package to attach it to the drag
            var data = ClipData.NewPlainText("Answer", "Excellent1");

            // Start dragging and pass data
            ((sender) as Button).StartDrag(data, new View.DragShadowBuilder(((sender) as Button)), null, 0);
        }

        private void TxtResult4_Drag(object sender, View.DragEventArgs e)
        {
            var txtResult4 = FindViewById<TextView>(Resource.Id.txtResult4);

            // React on different dragging events
            var evt = e.Event;
            switch (evt.Action)
            {
                case DragAction.Ended:
                case DragAction.Started:
                    e.Handled = true;
                    break;
                // Dragged element enters the drop zone
                case DragAction.Entered:
                    txtResult4.Text = "Answer 4";
                    break;
                // Dragged element exits the drop zone
                case DragAction.Exited:
                    txtResult4.Text = "Drop?";
                    break;
                // Dragged element has been dropped at the drop zone
                case DragAction.Drop:
                    // You can check if element may be dropped here
                    // If not do not set e.Handled to true
                    e.Handled = true;

                    // Try to get clip data
                    var data = e.Event.ClipData;
                    if (data != null)
                    {
                        switch (data.GetItemAt(0).Text)
                        {
                            case "Excellent4":
                                txtResult4.Text = "Excellent";
                                break;

                            case "Good4":
                                txtResult4.Text = "Good";
                                break;

                            case "Fair4":
                                txtResult4.Text = "Fair";
                                break;

                            case "Poor4":
                                txtResult4.Text = "Poor";
                                break;

                            default:
                                break;
                        }

                        q4 = txtResult4.Text;
                    }
                    break;
            }
        }

        private void TxtResult3_Drag(object sender, View.DragEventArgs e)
        {
            var txtResult3 = FindViewById<TextView>(Resource.Id.txtResult3);

            // React on different dragging events
            var evt = e.Event;
            switch (evt.Action)
            {
                case DragAction.Ended:
                case DragAction.Started:
                    e.Handled = true;
                    break;
                // Dragged element enters the drop zone
                case DragAction.Entered:
                    txtResult3.Text = "Answer 3";
                    break;
                // Dragged element exits the drop zone
                case DragAction.Exited:
                    txtResult3.Text = "Drop?";
                    break;
                // Dragged element has been dropped at the drop zone
                case DragAction.Drop:
                    // You can check if element may be dropped here
                    // If not do not set e.Handled to true
                    e.Handled = true;

                    // Try to get clip data
                    var data = e.Event.ClipData;
                    if (data != null)
                    {
                        switch (data.GetItemAt(0).Text)
                        {
                            case "Excellent3":
                                txtResult3.Text = "Excellent";
                                break;

                            case "Good3":
                                txtResult3.Text = "Good";
                                break;

                            case "Fair3":
                                txtResult3.Text = "Fair";
                                break;

                            case "Poor3":
                                txtResult3.Text = "Poor";
                                break;

                            default:
                                break;
                        }

                        q3 = txtResult3.Text;
                    }
                    break;
            }
        }

        private void TxtResult2_Drag(object sender, View.DragEventArgs e)
        {
            var txtResult2 = FindViewById<TextView>(Resource.Id.txtResult2);

            // React on different dragging events
            var evt = e.Event;
            switch (evt.Action)
            {
                case DragAction.Ended:
                case DragAction.Started:
                    e.Handled = true;
                    break;
                // Dragged element enters the drop zone
                case DragAction.Entered:
                    txtResult2.Text = "Answer 2";
                    break;
                // Dragged element exits the drop zone
                case DragAction.Exited:
                    txtResult2.Text = "Drop?";
                    break;
                // Dragged element has been dropped at the drop zone
                case DragAction.Drop:
                    // You can check if element may be dropped here
                    // If not do not set e.Handled to true
                    e.Handled = true;

                    // Try to get clip data
                    var data = e.Event.ClipData;
                    if (data != null)
                    {
                        switch (data.GetItemAt(0).Text)
                        {
                            case "Excellent2":
                                txtResult2.Text = "Excellent";
                                break;

                            case "Good2":
                                txtResult2.Text = "Good";
                                break;

                            case "Fair2":
                                txtResult2.Text = "Fair";
                                break;

                            case "Poor2":
                                txtResult2.Text = "Poor";
                                break;

                            default:
                                break;
                        }

                        q2 = txtResult2.Text;
                    }
                    break;
            }
        }

        private void txtResult1_Drag(object sender, View.DragEventArgs e)
        {
            var txtResult1 = FindViewById<TextView>(Resource.Id.txtResult1);

            // React on different dragging events
            var evt = e.Event;
            switch (evt.Action)
            {
                case DragAction.Ended:
                case DragAction.Started:
                    e.Handled = true;
                    break;
                // Dragged element enters the drop zone
                case DragAction.Entered:
                    txtResult1.Text = "Answer 1";
                    break;
                // Dragged element exits the drop zone
                case DragAction.Exited:
                    txtResult1.Text = "Drop?";
                    break;
                // Dragged element has been dropped at the drop zone
                case DragAction.Drop:
                    // You can check if element may be dropped here
                    // If not do not set e.Handled to true
                    e.Handled = true;

                    // Try to get clip data
                    var data = e.Event.ClipData;
                    if (data != null)
                    {
                        switch (data.GetItemAt(0).Text)
                        {
                            case "Excellent1":
                                txtResult1.Text = "Excellent";
                                break;

                            case "Good1":
                                txtResult1.Text = "Good";
                                break;

                            case "Fair1":
                                txtResult1.Text = "Fair";
                                break;

                            case "Poor1":
                                txtResult1.Text = "Poor";
                                break;

                            default:
                                break;
                        }

                        q1 = txtResult1.Text;
                    }
                    break;
            }
        }
    }
}


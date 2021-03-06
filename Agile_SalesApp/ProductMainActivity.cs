using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Agile_SalesApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class ProductMainActivity : AppCompatActivity
    {
        Button btn1, btn2, btn3, btn4,btn5;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.product_main); 
            
            btn1 = FindViewById<Button>(Resource.Id.btn1);
            btn2 = FindViewById<Button>(Resource.Id.btn2);
            btn3 = FindViewById<Button>(Resource.Id.btn3);
            btn4 = FindViewById<Button>(Resource.Id.btn4);
            btn5 = FindViewById<Button>(Resource.Id.btn5);

            btn1.Click += Btn1_Click;
            btn2.Click += Btn2_Click;
            btn3.Click += Btn3_Click;
            btn4.Click += Btn4_Click;
            btn5.Click += Btn5_Click;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainActivity));
            Finish();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(DeleteProductActivity));
            Finish();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(EditProductActivity));
            Finish();
        }

        private void Btn2_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(ViewProductActivity));
            Finish();
        }

        private void Btn1_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(AddProductActivity));
            Finish();
        }
    }
}
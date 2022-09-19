using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace MyCounter
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            int counter = 0;
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText Title = FindViewById<EditText>(Resource.Id.Title);
            TextView Counter = FindViewById<TextView>(Resource.Id.Counter);
            Button Plus = FindViewById<Button>(Resource.Id.Plus);
            Button Minus = FindViewById<Button>(Resource.Id.Minus);

            Plus.Click += (sender, e) =>
            {
                counter++;
                Counter.Text = counter.ToString();
            };
            Minus.Click += (sender, e) =>
            {
                counter--;
                Counter.Text = counter.ToString();
            };
            
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
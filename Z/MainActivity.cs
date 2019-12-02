using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Z
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView number;
        int temp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            number = FindViewById<TextView>(Resource.Id.textNumber);
            FindViewById<Button>(Resource.Id.btnIncret).Click +=(o,e)=>
            number.Text = (++temp).ToString();

            FindViewById<Button>(Resource.Id.btnDecret).Click += (o, e) =>
            number.Text = (--temp).ToString();

            FindViewById<Button>(Resource.Id.clear).Click += delegate { Reset(); };
             
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public void Reset() {

            temp = 0;
            number.Text = temp.ToString();
        }
    }
}
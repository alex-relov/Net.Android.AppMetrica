using IO.Appmetrica.Analytics;

namespace AndroidSample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

           var config = AppMetricaConfig.NewConfigBuilder("")
            .Build();
        AppMetrica.Activate(this, config);
        
        SetContentView(Resource.Layout.activity_main);
    }
}
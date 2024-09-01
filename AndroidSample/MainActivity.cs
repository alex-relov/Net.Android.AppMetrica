using IO.Appmetrica.Analytics;

namespace AndroidSample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        var config = AppMetricaConfig
            .NewConfigBuilder("")
            .WithCrashReporting(true)
            .WithLogs()
            .WithNativeCrashReporting(true)
            .Build();
        AppMetrica.Activate(this, config);
        AppMetrica.ReportEvent("event");
        AppMetrica.SendEventsBuffer();
    }
}
using System;
using Android.App;
using Android.OS;
using Android.Views;
using Com.Tonestro.Exoplayerslim;

namespace Tonestro.Maui.ExoPlayerSlim.UsageChecker;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    private View _videoView;
    private IExoPlayerSlim _exoPlayerSlim;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        _videoView = ExoPlayerSlimViewFactory.Create(this);
        _exoPlayerSlim = ExoPlayerSlimFactory.Create(this,
            "https://bitdash-a.akamaihd.net/content/MI201109210084_1/m3u8s/f08e80da-bf1d-4e3d-8899-f0f6155f6efa.m3u8");

        _exoPlayerSlim.AttachPlayerView(_videoView, true, AspectRatios.Fit);

        _exoPlayerSlim.PlayWhenReady = true;

        // Set our view from the "main" layout resource
        SetContentView(_videoView);

        var exoPlayerVersion = ExoPlayerSlimFactory.ExoPlayerVersion;

        Console.WriteLine(exoPlayerVersion);

        _exoPlayerSlim.Play();
    }
}
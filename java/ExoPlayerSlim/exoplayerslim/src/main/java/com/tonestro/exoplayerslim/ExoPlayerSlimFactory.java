package com.tonestro.exoplayerslim;

import android.content.Context;

import com.google.android.exoplayer2.ExoPlayerLibraryInfo;

public class ExoPlayerSlimFactory {

    private ExoPlayerSlimFactory() {
    }

    public static ExoPlayerSlim create(Context context) {
        return new ExoPlayerSlimImpl(context);
    }

    public static ExoPlayerSlim create(Context context, String url) {
        ExoPlayerSlim player = new ExoPlayerSlimImpl(context);
        player.initializeFromUrl(url);
        return player;
    }

    public static String GetExoPlayerVersion() {
        return ExoPlayerLibraryInfo.VERSION;
    }
}

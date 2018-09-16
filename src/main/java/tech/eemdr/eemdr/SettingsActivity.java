package tech.eemdr.eemdr;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.Switch;

import tech.eemdr.vremdr.R;

public class SettingsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_settings);

        Switch useForestBackground = findViewById(R.id.use_forest_background);
        Switch useSlowBallSpeed = findViewById(R.id.use_slow_ball_speed);
        Switch playCalmingMusic = findViewById(R.id.play_calming_music);

        useForestBackground.setOnClickListener(view -> useForestBackground.setChecked(true));
        useSlowBallSpeed.setOnClickListener(view -> useSlowBallSpeed.setChecked(false));
        playCalmingMusic.setOnClickListener(view -> playCalmingMusic.setChecked(false));

        Button backToMenu = findViewById(R.id.back_to_menu);
        backToMenu.setOnClickListener(view -> finish());
    }

    @Override
    public void onResume() {
        super.onResume();
        hideSystemUI();
    }

    private void hideSystemUI() {
        // Enables regular immersive mode.
        // For "lean back" mode, remove SYSTEM_UI_FLAG_IMMERSIVE.
        // Or for "sticky immersive," replace it with SYSTEM_UI_FLAG_IMMERSIVE_STICKY
        View decorView = getWindow().getDecorView();
        decorView.setSystemUiVisibility(
                View.SYSTEM_UI_FLAG_IMMERSIVE
                        | View.SYSTEM_UI_FLAG_IMMERSIVE_STICKY
                        // Set the content to appear under the system bars so that the
                        // content doesn't resize when the system bars hide and show.
                        | View.SYSTEM_UI_FLAG_LAYOUT_STABLE
                        | View.SYSTEM_UI_FLAG_LAYOUT_HIDE_NAVIGATION
                        | View.SYSTEM_UI_FLAG_LAYOUT_FULLSCREEN
                        // Hide the nav bar and status bar
                        | View.SYSTEM_UI_FLAG_HIDE_NAVIGATION
                        | View.SYSTEM_UI_FLAG_FULLSCREEN);
    }
}

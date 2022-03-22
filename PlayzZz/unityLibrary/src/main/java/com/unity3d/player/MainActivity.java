package com.unity3d.player;

import android.content.Intent;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {
    private Button button;
    private Button button2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        button = (Button) findViewById(R.id.button1);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                OpenTricky();
            }
        });
        button2 = (Button) findViewById(R.id.button2);
        button2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                OpenFly();
            }
        });
    }
    public void OpenTricky(){
        Intent intent = new Intent(this, UnityPlayerActivity.class);
        startActivity(intent);
        final Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                UnityPlayer.UnitySendMessage("GameObject", "LoadScene", "TrickyDodge/Scenes/Main menue");}
        }, 5000);
    }
    public void OpenFly(){
        Intent intent = new Intent(this, UnityPlayerActivity.class);
        startActivity(intent);
        final Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                UnityPlayer.UnitySendMessage("GameObject", "LoadScene", "Flybird/Scenes/Mainmenu");}
        }, 5000);
    }

}
package com.example.spacezombie;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
// java основной код
/*
Так пишутся просто каментарийа
 */

public class MainActivity extends AppCompatActivity {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void click1(View view) {
        Intent intent = new Intent (MainActivity.this, knb.class);
        startActivity(intent);
        finish();
        System.exit(0);
    }

    public void click_xMif(View view) {

        Intent intent = new Intent (MainActivity.this, Web.class);
        startActivity(intent);
        finish();
        System.exit(0);
    }

    public void ClickEx(View view) {
        finish();
        System.exit(0);
    }

}

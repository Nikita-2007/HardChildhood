package com.hikkicoders.spacezombies;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;
import android.widget.TextView;

public class lvl1 extends AppCompatActivity {

    TextView textViewTest;
    ImageView bad, okno, door, zombie1, zombie2, hero1, hero2, hero3, hero4, doorclose;
    Animation alpha, comdo, rotate, scale, trans, animzombiewinndow, animhero3, click;
    String step;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lvl1);

        textViewTest = findViewById(R.id.textViewTest);

        bad = findViewById(R.id.bad);
        okno = findViewById(R.id.okno);
        door = findViewById(R.id.door);
        zombie1 = findViewById(R.id.zombie1);
        zombie2 = findViewById(R.id.zombie2);
        hero1 = findViewById(R.id.hero1);
        hero2 = findViewById(R.id.hero2);
        hero3 = findViewById(R.id.hero3);
        hero4 = findViewById(R.id.hero4);
        doorclose = findViewById(R.id.doorclose);

        alpha = AnimationUtils.loadAnimation(this, R.anim.myalpha);
        comdo = AnimationUtils.loadAnimation(this, R.anim.mycombo);
        rotate = AnimationUtils.loadAnimation(this, R.anim.myrotate);
        scale = AnimationUtils.loadAnimation(this, R.anim.myscale);
        click = AnimationUtils.loadAnimation(this, R.anim.click);
        trans = AnimationUtils.loadAnimation(this, R.anim.mytrans);
        animzombiewinndow = AnimationUtils.loadAnimation(this, R.anim.animzombiewinndow);
        animhero3 = AnimationUtils.loadAnimation(this, R.anim.animherow3);


        //Слушатель
        View.OnClickListener onClickListener = new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                zombie1.setVisibility(View.INVISIBLE);
                zombie2.setVisibility(View.INVISIBLE);
                hero1.setVisibility(View.INVISIBLE);
                hero2.setVisibility(View.INVISIBLE);
                hero3.setVisibility(View.INVISIBLE);
                hero4.setVisibility(View.INVISIBLE);
                doorclose.setVisibility(View.INVISIBLE);

                if (step == "door") {
                    Intent intent = new Intent (lvl1.this, lvl2.class);
                    startActivity(intent);
                    finish();
                    System.exit(0);
                }

                switch (v.getId()) {
                    case R.id.okno:
                        step = "okno";
                        okno.startAnimation(click);
                        clickokno();
                        break;

                    case R.id.bad:
                        if (step == "okno") {
                            step = "bad";
                            bad.startAnimation(click);
                            clickbad();
                        }
                        break;

                    case R.id.zombie2:
                        if (step == "bad") {
                            step = "door";
                            zombie2.startAnimation(click);
                            clickdoor();
                        }
                        break;
                }
            }
        };

        bad.setOnClickListener(onClickListener);
        okno.setOnClickListener(onClickListener);
        zombie2.setOnClickListener(onClickListener);

    }

private void clickokno() {
        zombie1.setVisibility(View.VISIBLE);
        zombie1.startAnimation(animzombiewinndow);
        hero1.startAnimation(alpha);
        hero3.startAnimation(animhero3);
        hero3.setVisibility(View.VISIBLE);
        textViewTest.setText("окно");
    }

    private void clickbad() {
        hero4.startAnimation(animhero3);
        hero4.setVisibility(View.VISIBLE);
        hero3.startAnimation(alpha);
        zombie2.setAnimation(animhero3);
        zombie2.setVisibility(View.VISIBLE);
        textViewTest.setText("кровать");
    }

    private void clickdoor() {
        hero2.startAnimation(animhero3);
        hero2.setVisibility(View.VISIBLE);
        hero4.startAnimation(alpha);
        textViewTest.setText("дверь");
        
    }

    public void btnEx2(View view) {
        finish();
        System.exit(0);
    }
}
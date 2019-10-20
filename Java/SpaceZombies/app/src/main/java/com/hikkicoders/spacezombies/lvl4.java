package com.hikkicoders.spacezombies;

import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;
import android.widget.TextView;

public class lvl4 extends AppCompatActivity {

    //Переменные текста
    TextView textViewNoFuel;

    //Переменные звука
    MediaPlayer zombie1, zombie2, zombie3, zombie4;

    //Переменные Анимации
    Animation click, myalpha;

    //Переменные елеменотов экрана
    ImageView imageViewBoat, imageViewTree,
            imageViewKey, imageViewCase, imageViewCanistra,
            imageViewHikkiMid, imageViewHikkiTree, imageViewFox,
            imageViewZombie1, imageViewZombie2, imageViewZombie3;

    String step;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_lvl4);

        //Присваеваем значение тексту
        textViewNoFuel = findViewById(R.id.textViewNoFuel);

        //Присваеваем значение переменным
        zombie1 = MediaPlayer.create(this, R.raw.zombd);
        zombie2 = MediaPlayer.create(this, R.raw.zombh);
        zombie3 = MediaPlayer.create(this, R.raw.zombr);
        zombie4 = MediaPlayer.create(this, R.raw.zombw);

        //Присваеваем значение анимации
        click = AnimationUtils.loadAnimation(this, R.anim.click);
        myalpha = AnimationUtils.loadAnimation(this, R.anim.myalpha);

        //Присваиваем значение елементам экрана
        imageViewBoat = findViewById(R.id.imageViewBoat);
        imageViewTree = findViewById(R.id.imageViewTree);
        imageViewKey = findViewById(R.id.imageViewKey);
        imageViewCase = findViewById(R.id.imageViewCase);
        imageViewCanistra = findViewById(R.id.imageViewCanistra);
        imageViewHikkiMid = findViewById(R.id.imageViewHikkiMid);
        imageViewHikkiTree = findViewById(R.id.imageViewHikkiTree);
        imageViewFox = findViewById(R.id.imageViewFox);
        imageViewZombie1 = findViewById(R.id.imageViewZombie1);
        imageViewZombie2 = findViewById(R.id.imageViewZombie2);
        imageViewZombie3 = findViewById(R.id.imageViewZombie3);

        //Слушатели
        View.OnClickListener onClickListener = new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                textViewNoFuel.setVisibility(View.INVISIBLE);
                imageViewHikkiTree.setVisibility(View.INVISIBLE);
                imageViewCanistra.setVisibility(View.INVISIBLE);
                imageViewZombie1.setVisibility(View.INVISIBLE);
                imageViewZombie2.setVisibility(View.INVISIBLE);
                imageViewZombie3.setVisibility(View.INVISIBLE);
                imageViewFox.setVisibility(View.INVISIBLE);
                imageViewKey.setVisibility(View.INVISIBLE);
                imageViewCanistra.setVisibility(View.INVISIBLE);

                switch (view.getId()) {

                    case R.id.imageViewTree:
                        step = "Tree";
                        imageViewTree.startAnimation(click);
                        imageViewHikkiMid.setVisibility(View.INVISIBLE);
                        imageViewHikkiTree.setVisibility(View.VISIBLE);
                        imageViewFox.setVisibility(View.VISIBLE);
                        imageViewKey.setVisibility(View.VISIBLE);
                        break;

                    case R.id.imageViewFox:
                        imageViewFox.startAnimation(click);
                        if (step == "Tree") {
                            step = "Fox";
                            imageViewFox.setVisibility(View.GONE);
                            imageViewZombie1.setVisibility(View.VISIBLE);
                            imageViewZombie2.setVisibility(View.VISIBLE);
                            imageViewZombie3.setVisibility(View.VISIBLE);
                            imageViewHikkiTree.setVisibility(View.VISIBLE);
                            imageViewKey.setVisibility(View.VISIBLE);
                        }
                        break;

                    case R.id.imageViewKey:
                        imageViewKey.startAnimation(click);
                        if (step == "Fox") {
                            step = "Key";
                            imageViewKey.setVisibility(View.INVISIBLE);
                            imageViewHikkiMid.setVisibility(View.VISIBLE);
                        }
                        break;

                    case R.id.imageViewCase:
                        imageViewCase.startAnimation(click);
                        imageViewHikkiMid.setVisibility(View.VISIBLE);
                        if (step == "Key") {
                            step = "Case";
                            imageViewCase.setVisibility(View.INVISIBLE);
                            imageViewCanistra.setVisibility(View.VISIBLE);
                        }
                        break;

                    case R.id.imageViewCanistra:
                        imageViewCanistra.startAnimation(click);
                        if (step == "Case") {
                            step = "Can";
                            imageViewCanistra.setVisibility(View.INVISIBLE);
                        }
                        break;

                    case R.id.imageViewBoat:
                        imageViewBoat.startAnimation(click);
                        imageViewHikkiMid.setVisibility(View.VISIBLE);
                        textViewNoFuel.setVisibility(View.VISIBLE);
                        if (step == "Can") {
                            textViewNoFuel.setVisibility(View.INVISIBLE
                            );
                        }
                        break;

                    case R.id.imageViewHikkiMid:
                        imageViewHikkiMid.startAnimation(click);
                        break;

                }
            }
        };

        imageViewBoat.setOnClickListener(onClickListener);
        imageViewTree.setOnClickListener(onClickListener);
        imageViewKey.setOnClickListener(onClickListener);
        imageViewCase.setOnClickListener(onClickListener);
        imageViewCanistra.setOnClickListener(onClickListener);
        imageViewHikkiMid.setOnClickListener(onClickListener);
        imageViewFox.setOnClickListener(onClickListener);
    }
}

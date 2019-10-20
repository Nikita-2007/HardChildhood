package com.example.spacezombie;

import android.content.Intent;
import android.graphics.Color;
import android.media.AudioManager;
import android.media.SoundPool;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageView;
import android.widget.TextView;

public class knb extends AppCompatActivity {

    //объекты
    ImageView kam, noj, bum, ImageViewUser, ImageViewComp;
    TextView textKNB, TextViewWin, TextViewLose, TextViewDraw, TextViewGame;
    int scoreWin, scoreLose, scoreDraw, scoreGame;

    //Звуки кнопки
    final SoundPool soundPool = new SoundPool(3, AudioManager.STREAM_MUSIC, 0);

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.knb);

        //Присваивоем переменые
        kam = findViewById(R.id.kam);
        noj = findViewById(R.id.noj);
        bum = findViewById(R.id.bum);

        textKNB = findViewById(R.id.textKNB);
        TextViewWin = findViewById(R.id.TextViewWin);
        TextViewLose = findViewById(R.id.TextViewLose);
        TextViewDraw = findViewById(R.id.TextViewDraw);
        TextViewGame = findViewById(R.id.TextViewGame);

        ImageViewComp = findViewById(R.id.ImageViewComp);
        ImageViewUser = findViewById(R.id.ImageViewUser);

        //Загружаем файл звука
        soundPool.load(this, R.raw.sound, 1);

        //Создение объекты
        final Player user = new Player();
        final Player comp = new Player();

        //Слушатель
        View.OnClickListener onClickListener = new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                switch (v.getId()) {
                    case R.id.kam:
                        user.hand = Player.Hands.KAM;
                        ImageViewUser.setImageResource(R.drawable.kamen);
                        break;
                    case R.id.noj:
                        user.hand = Player.Hands.NOJ;
                        ImageViewUser.setImageResource(R.drawable.nojnici);
                        anim = AnimationUtils.loadAnimation(this,R.anim.mycombo)
                        break;
                    case R.id.bum:
                        user.hand = Player.Hands.BUM;
                        ImageViewUser.setImageResource(R.drawable.bumaga);
                        break;
                }

                //Воспроизводим звук
                soundPool.play(1, 1, 1, 1, 0, 1);

                //Выбор Компьютера
                comp.hand = Player.randomMetod();
                Animation anim = null;
                switch (comp.hand) {
                    case KAM:
                        ImageViewComp.setImageResource(R.drawable.kamen);
                        break;
                    case NOJ:
                        ImageViewComp.setImageResource(R.drawable.nojnici);
                        break;
                    case BUM:
                        ImageViewComp.setImageResource(R.drawable.bumaga);
                        break;
                }

                if (comp.hand == user.hand) {
                    textKNB.setText("НИЧЬЯ");
                    textKNB.setTextColor(Color.YELLOW);
                    scoreDraw++;
                } else if (comp.hand == Player.Hands.KAM && user.hand == Player.Hands.BUM ||
                        comp.hand == Player.Hands.BUM && user.hand == Player.Hands.NOJ ||
                        comp.hand == Player.Hands.NOJ && user.hand == Player.Hands.KAM) {
                    textKNB.setText("ПОБЕДА");
                    textKNB.setTextColor(Color.GREEN);
                    scoreWin++;
                } else {
                    textKNB.setText("ПОРАЖЕНИЕ");
                    textKNB.setTextColor(Color.RED);
                    scoreLose++;
                }
                scoreGame++;

                TextViewLose.setText(String.valueOf(scoreLose));
                TextViewGame.setText(String.valueOf(scoreGame));
                TextViewWin.setText(String.valueOf(scoreWin));
                TextViewDraw.setText(String.valueOf(scoreDraw));
            }
        };
        kam.setOnClickListener(onClickListener);
        noj.setOnClickListener(onClickListener);
        bum.setOnClickListener(onClickListener);
    }


    public void click2(View view) {
        Intent intent = new Intent (knb.this, MainActivity.class);
        startActivity(intent);
        finish();
        System.exit(0);
    }

    public void ClickEx(View view) {
        finish();
        System.exit(0);
    }
}
package com.duy.lab_01_2;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;

import androidx.appcompat.app.AppCompatActivity;

public class HelloUser extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_hello_user);

        Button btnLoginAgain = findViewById(R.id.btnLoginAgin);

        btnLoginAgain.setOnClickListener(view ->
                startActivity(new Intent(HelloUser.this,MainActivity.class)));

    }
}
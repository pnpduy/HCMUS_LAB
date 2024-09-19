package com.duy.lab_03_listview;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

public class DetailActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detail);

        Bundle bundle = getIntent().getExtras();
        if (bundle == null){
            return;
        }

        Food food = (Food) bundle.get("Food");

        ImageView imgFoodDT = findViewById(R.id.imgFood_detail);
        TextView txtPriceDT = findViewById(R.id.price_detail);
        //Button btnBackList = findViewById(R.id.btnBackList);

        TextView txtFoodDT = findViewById(R.id.food_detail);
        txtFoodDT.setText(food.getName());
        txtPriceDT.setText(food.getPrice());
        imgFoodDT.setImageResource(food.getImage());
    }
}
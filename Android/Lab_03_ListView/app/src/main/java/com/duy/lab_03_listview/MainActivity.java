package com.duy.lab_03_listview;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.DividerItemDecoration;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.widget.LinearLayout;

import com.duy.lab_03_listview.my_interface.IClickItemFoodListener;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private RecyclerView rcvData;
    private FoodAdapter foodAdapter;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        rcvData = findViewById(R.id.rcv_Data);
        LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this);
        rcvData.setLayoutManager(linearLayoutManager);

        RecyclerView.ItemDecoration itemDecoration = new DividerItemDecoration(this,DividerItemDecoration.VERTICAL);
        rcvData.addItemDecoration(itemDecoration);

        foodAdapter = new FoodAdapter(getListFood(), new IClickItemFoodListener() {
            @Override
            public void OnClickItemFood(Food food) {
                onClickGoToDetail(food);
            }
        });
        rcvData.setAdapter(foodAdapter);
    }

    private List<Food> getListFood() {
        List<Food> list = new ArrayList<>();
        list.add(new Food(R.drawable.burger_1, "Burger","Beet Bugger","25.000đ"));
        list.add(new Food(R.drawable.pizza_cheese, "Pizza","Cheese Pizza","50.000đ"));
        list.add(new Food(R.drawable.burger_chicken, "Burger","Chicken Bugger","40.000đ"));
        list.add(new Food(R.drawable.chicken_fried_chilli, "Chicken Fried","Fried Chicken Chilli","70.000đ"));
        list.add(new Food(R.drawable.hot_dog, "Sandwich","Hot Dog Sandwich","45.000đ"));
        list.add(new Food(R.drawable.taco, "Taco","Taco Shrimp","60.000đ"));
        list.add(new Food(R.drawable.taco_beef, "Taco","Taco Beef","65.000đ"));
        list.add(new Food(R.drawable.coca_cola, "Coca","Coca Cola Original","15.000đ"));
        list.add(new Food(R.drawable.coca_cola_zezo, "Coca","Coca Cola Zero","15.000đ"));

        return list;
    }

    private void onClickGoToDetail (Food food) {
        Intent intent = new Intent(this, DetailActivity.class);
        Bundle bundle = new Bundle();
        bundle.putSerializable("Food", food);
        bundle.putSerializable("Price", food);
        intent.putExtras(bundle);
        startActivity(intent);

    }
}
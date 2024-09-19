package com.duy.lab_05;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;


import java.text.DecimalFormat;
import java.util.List;

public class FoodAdapter extends BaseAdapter {

    private MainActivity context;
    private int layout;
    private List<Food> foodList;

    public FoodAdapter(MainActivity context, int layout, List<Food> foodList) {
        this.context = context;
        this.layout = layout;
        this.foodList = foodList;
    }

    @Override
    public int getCount() {
        return foodList.size();
    }

    @Override
    public Object getItem(int i) {
        return null;
    }

    @Override
    public long getItemId(int i) {
        return 0;
    }

    private class ViewHolder{
        TextView txtFood,txtName,txtPrice;
        ImageView imgFood;
        LinearLayout layout_food;
        ImageButton imgBtnEdit, imgBtnDelete;
    }

    @Override
    public View getView(int i, View view, ViewGroup viewGroup) {

        ViewHolder holder;

        if (view == null){
            holder = new ViewHolder();
            LayoutInflater inflater = (LayoutInflater) context.getSystemService(context.LAYOUT_INFLATER_SERVICE);
            view = inflater.inflate(layout, null);
            holder.txtFood      = (TextView) view.findViewById(R.id.food);
            holder.txtName      = (TextView) view.findViewById(R.id.name);
            holder.txtPrice     = (TextView) view.findViewById(R.id.price);
            holder.imgFood      = (ImageView) view.findViewById(R.id.imgFood);
            holder.imgBtnEdit   = (ImageButton) view.findViewById(R.id.imgBtnEdit);
            holder.imgBtnDelete = (ImageButton) view.findViewById(R.id.imgBtnDelete);
            view.setTag(holder);
        }else {
            holder = (ViewHolder) view.getTag();
        }

        Food food = foodList.get(i);

        holder.txtFood.setText(food.getFood());
        holder.txtName.setText(food.getName());
        holder.txtPrice.setText(formatNumberCurrency(food.getPrice()) + "đ");
        //Change byte[] -> bitmap
        byte[] image    = food.getImage();
        Bitmap bitmap   = BitmapFactory.decodeByteArray(image,0,image.length);
        holder.imgFood.setImageBitmap(bitmap);
        holder.layout_food = (LinearLayout) view.findViewById(R.id.layout_item);

        //Edit Item Food
        holder.imgBtnEdit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                context.DialogEditItem(food.getId(),food.getFood(),food.getName(),food.getPrice(),food.getImage());
                Toast.makeText(context, "Open Edit Food", Toast.LENGTH_SHORT).show();
            }
        });

        //Delete Item Food
        holder.imgBtnDelete.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                context.DialogDeleteItem(food.getId(),food.getName());
            }
        });

        return view;
    }
    //Format 1000 -> 1.000
    private static String formatNumberCurrency(String number){
        DecimalFormat format = new DecimalFormat("#,###");
        return format.format(Double.parseDouble(number));
    }
}

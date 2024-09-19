package com.duy.lab_03_listview;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.duy.lab_03_listview.my_interface.IClickItemFoodListener;

import java.util.List;

public class FoodAdapter extends RecyclerView.Adapter<FoodAdapter.FoodViewHolder> {

    private List<Food> listFood;
    private IClickItemFoodListener iClickItemFoodListener;

    public FoodAdapter(List<Food> listFood,IClickItemFoodListener listener) {
        this.listFood = listFood;
        this.iClickItemFoodListener = listener;
    }

    @NonNull
    @Override
    public FoodViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(parent.getContext()).inflate(R.layout.item_food, parent, false);
        return new FoodViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull FoodViewHolder holder, int position) {
        final Food food = listFood.get(position);
        if (food == null){
            return;
        }
        holder.imgFood.setImageResource(food.getImage());
        holder.txtFood.setText(food.getFood());
        holder.txtName.setText(food.getName());
        holder.txtPrice.setText(food.getPrice());

        holder.layoutItem.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                iClickItemFoodListener.OnClickItemFood(food);
            }
        });
    }

    @Override
    public int getItemCount() {
        if (listFood != null){
            return listFood.size();
        }
        return 0;
    }

    public class FoodViewHolder extends RecyclerView.ViewHolder{

        private ImageView imgFood;
        private TextView txtFood;
        private TextView txtName;
        private TextView txtPrice;
        private RelativeLayout layoutItem;

        public FoodViewHolder(@NonNull View itemView) {
            super(itemView);
            imgFood = itemView.findViewById(R.id.imgFood);
            txtFood = itemView.findViewById(R.id.food);
            txtName = itemView.findViewById(R.id.name);
            txtPrice = itemView.findViewById(R.id.price);

            layoutItem = itemView.findViewById(R.id.layout_item);
        }
    }
}

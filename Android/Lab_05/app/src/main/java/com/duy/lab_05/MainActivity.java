package com.duy.lab_05;

import androidx.appcompat.app.AppCompatActivity;

import android.app.Dialog;
import android.content.Intent;
import android.database.Cursor;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    public static Database database;
    ListView lvFood;
    ArrayList<Food> arrayFood;
    FoodAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        lvFood = (ListView) findViewById(R.id.listViewFood);
        arrayFood = new ArrayList<>();

        adapter = new FoodAdapter(this, R.layout.list_food, arrayFood);
        lvFood.setAdapter(adapter);

        //Database
        database =  new Database(this,"DB_Food.sqlite", null,1);
        database.QueryData("CREATE TABLE IF NOT EXISTS " +
                "FoodList(Id INTEGER PRIMARY KEY AUTOINCREMENT,Food VARCHAR(250),Name VARCHAR(250), Price VARCHAR(100), Image BLOB)");
        GetDataFood();
    }

    private void GetDataFood() {
        //Get Data
        arrayFood.clear();
        Cursor cursor = database.GetData("SELECT * FROM FoodList");
        while (cursor.moveToNext()){
            arrayFood.add(new Food(
                    cursor.getInt(0),
                    cursor.getString(1),
                    cursor.getString(2),
                    cursor.getString(3),
                    cursor.getBlob(4)
            ));
        }
        adapter.notifyDataSetChanged();
    }

    //Edit Item Food
    public  void DialogEditItem(int id, String food, String name, String price, byte[] image) {
        Dialog dialog = new Dialog(this);
        dialog.setContentView(R.layout.dialog_edit_food);

        EditText editTextFood           = (EditText) dialog.findViewById(R.id.txtFood_edit);
        EditText editTextName           = (EditText) dialog.findViewById(R.id.txtName_edit);
        EditText editTextPrice          = (EditText) dialog.findViewById(R.id.txtPrice_edit);
        ImageView editImgFood           = (ImageView) dialog.findViewById(R.id.imgFood_edit);
        Button btnEdit                  = (Button) dialog.findViewById(R.id.btn_edit);
        Button btnCancelEdit            = (Button) dialog.findViewById(R.id.btn_cancel_edit);

        //Change byte -> bitmap
        Bitmap bitmap = BitmapFactory.decodeByteArray(image,0,image.length);

        //Display Unedited Text And Images
        editImgFood.setImageBitmap(bitmap);
        editTextFood.setText(food);
        editTextName.setText(name);
        editTextPrice.setText(price);

        //Button Cancel Edit Food
        btnCancelEdit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                dialog.cancel();
            }
        });

        //Button Edit Food
        btnEdit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String newFood  = editTextFood.getText().toString().trim();
                String newName  = editTextName.getText().toString().trim();
                String newPrice = editTextPrice.getText().toString().trim();

                database.QueryData("UPDATE FoodList SET Food = '"+ newFood +"',Name = '"+ newName +"',Price = '"+ newPrice +"'   WHERE Id ='"+ id +"'");
                Toast.makeText(MainActivity.this, "Successfully Updated!", Toast.LENGTH_SHORT).show();
                dialog.dismiss();
                GetDataFood();
                //database.QueryData("DELETE FROM FoodList WHERE Id = 4");
            }
        });
        dialog.show();
    }

    //Delete Item Food
    public void DialogDeleteItem(int id,String fdName){
        Dialog dialog = new Dialog(this);
        dialog.setContentView(R.layout.dialog_delete_food);

        TextView txtDelete = (TextView) dialog.findViewById(R.id.txtDelete);
        Button btnYes      = (Button) dialog.findViewById(R.id.btn_yes);
        Button btnNo       = (Button) dialog.findViewById(R.id.btn_no);

        txtDelete.setText("Do you want to delete this " + fdName +" ?");

        btnYes.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                database.QueryData("DELETE FROM FoodList WHERE Id = '"+ id +"'");
                Toast.makeText(MainActivity.this, "Deleted " + fdName + " Successfully", Toast.LENGTH_SHORT).show();
                dialog.dismiss();
                GetDataFood();
            }
        });
        
        btnNo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Toast.makeText(MainActivity.this, "Cancel Delete!", Toast.LENGTH_SHORT).show();
                dialog.cancel();
            }
        });

        dialog.show();
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.add_food, menu);
        return super.onCreateOptionsMenu(menu);
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {

        if (item.getItemId() == R.id.menuAdd){
            AddFood();
        }
        return super.onOptionsItemSelected(item);
    }

    private void AddFood(){
        startActivity(new Intent(MainActivity.this, add_food.class));
    }
}
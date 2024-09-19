package com.duy.lab_05;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.view.View;
import android.view.inspector.IntFlagMapping;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.ImageView;
import android.widget.Toast;

import java.io.ByteArrayOutputStream;
import java.io.FileNotFoundException;
import java.io.InputStream;

public class add_food extends AppCompatActivity {

    Button btnAdd, btnCancel;
    EditText edtFood, edtName, edtPrice;
    ImageButton imgbtnCamera, imgbtnFolder;
    ImageView imageFood;

    int REQUEST_CODE_CAMERA = 100;
    int REQUEST_CODE_FOLDER = 200;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_add_food);

        Add_Food();

        btnAdd.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                //change data imageview -> byte[]
                BitmapDrawable bitmapDrawable = (BitmapDrawable) imageFood.getDrawable();
                Bitmap bitmap = bitmapDrawable.getBitmap();
                ByteArrayOutputStream byteArray = new ByteArrayOutputStream();
                bitmap.compress(Bitmap.CompressFormat.PNG, 100, byteArray);
                byte[] Image = byteArray.toByteArray();

                MainActivity.database.INSERT_FOOD(
                        edtFood.getText().toString().trim(),
                        edtName.getText().toString().trim(),
                        edtPrice.getText().toString().trim(),
                        Image
                );
                Toast.makeText(add_food.this, "Added To Database", Toast.LENGTH_SHORT).show();
                startActivity(new Intent(add_food.this, MainActivity.class));
            }
        });

        btnCancel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Toast.makeText(add_food.this, "Cancel Add Complete!", Toast.LENGTH_SHORT).show();
                startActivity(new Intent(add_food.this, MainActivity.class));
            }
        });

        //Open Camera
        imgbtnCamera.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(MediaStore.ACTION_IMAGE_CAPTURE);
                startActivityForResult(intent,REQUEST_CODE_CAMERA);
            }
        });
        //Open Folder(Gallery)
        imgbtnFolder.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = new Intent(Intent.ACTION_PICK);
                intent.setType("image/*");
                startActivityForResult(intent, REQUEST_CODE_FOLDER);
            }
        });
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, @Nullable Intent data) {
        if (requestCode == REQUEST_CODE_CAMERA && resultCode == RESULT_OK && data != null){
            Bitmap bitmap = (Bitmap) data.getExtras().get("data");
            imageFood.setImageBitmap(bitmap);
        }

        if (requestCode == REQUEST_CODE_FOLDER && resultCode == RESULT_OK && data != null){
            Uri uri = data.getData();
            try {
                InputStream inputStream = getContentResolver().openInputStream(uri);
                Bitmap bitmap = BitmapFactory.decodeStream(inputStream);
                imageFood.setImageBitmap(bitmap);
            } catch (FileNotFoundException e) {
                e.printStackTrace();
            }
        }
        super.onActivityResult(requestCode, resultCode, data);
    }

    private void Add_Food() {
        btnAdd       = (Button) findViewById(R.id.btn_add);
        btnCancel    = (Button) findViewById(R.id.btn_cancel);
        edtFood      = (EditText) findViewById(R.id.editTextFood);
        edtName      = (EditText) findViewById(R.id.editTextName);
        edtPrice     = (EditText) findViewById(R.id.editTextPrice);
        imgbtnCamera = (ImageButton) findViewById(R.id.ImgBtnCamera);
        imgbtnFolder = (ImageButton) findViewById(R.id.ImgBtnFolder);
        imageFood    = (ImageView) findViewById(R.id.imageFood);
    }
}
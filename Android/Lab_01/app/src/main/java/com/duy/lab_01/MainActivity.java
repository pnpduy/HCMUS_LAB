package com.duy.lab_01;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import java.util.HashMap;
import java.util.Map;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //Tự tạo một danh sách người dùng gồm username và password
        Map<String, String> myMap = new HashMap<>();
        myMap.put("key1", "value1");
        myMap.put("key2","value2");
        myMap.put("key3", "value3");

        Button btnDN = (Button)findViewById (R.id.btnDangNhap);
        btnDN.setOnClickListener (v -> {
            EditText taiKhoan = (EditText) findViewById(R.id.editTaiKhoan);
            EditText matKhau = (EditText) findViewById(R.id.editMatKhau);
            String txtTK = taiKhoan.getText().toString();
            String txtMK = matKhau.getText().toString();
            if (myMap.containsKey(txtTK) && myMap.containsValue(txtMK)){
                Intent intent = new Intent(MainActivity.this, SecondActivity.class);
                Toast.makeText(MainActivity.this, "Hello " + txtTK +" !"
                        , Toast.LENGTH_SHORT).show();
                startActivity(intent);
            }
            else{
                Toast.makeText(getApplicationContext(), "Đăng Nhập thất bại!"
                        , Toast.LENGTH_SHORT).show();
            }
        });
    }
}
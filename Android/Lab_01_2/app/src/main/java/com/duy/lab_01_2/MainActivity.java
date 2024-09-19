package com.duy.lab_01_2;

import android.annotation.SuppressLint;
import android.content.Intent;
import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class
MainActivity extends AppCompatActivity {

    DatabaseReference databaseReference = FirebaseDatabase.getInstance()
            .getReferenceFromUrl("https://loginregister-a1a3f-default-rtdb.firebaseio.com/");
    
    private EditText userName;
    private EditText passWord;
    private Button btnLogin;
    private TextView intApptempts;
    private int Attempts = 5;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        userName = findViewById (R.id.editUserName);
        passWord = findViewById (R.id.editPassWord);
        btnLogin = findViewById (R.id.btnLogin);
        Button btnCNA = findViewById(R.id.btnCNA);
        intApptempts = findViewById(R.id.txtAttempts);

        btnLogin.setOnClickListener(v -> {

              final  String txtUserName = userName.getText().toString();
              final  String txtPassWord = passWord.getText().toString();

              if (txtUserName.isEmpty() || txtPassWord.isEmpty()){
                  Toast.makeText(MainActivity.this, "Bạn cần phải nhập Username hoặc Password"
                          ,Toast.LENGTH_LONG).show();
              }else {
                  databaseReference.child("users")
                  .addListenerForSingleValueEvent(new ValueEventListener() {
                      @SuppressLint("SetTextI18n")
                      @Override
                      public void onDataChange(@NonNull DataSnapshot snapshot) {
                          if (snapshot.hasChild(txtUserName))
                          {
                              final String getPassWord = snapshot.child(txtUserName)
                                      .child("PassWord").getValue(String.class);

                              assert getPassWord != null;
                              if (getPassWord.equals(txtPassWord)) {
                                  Toast.makeText(MainActivity.this, "Đăng nhập Thành Công! \n" + txtUserName
                                          , Toast.LENGTH_SHORT).show();
                                  startActivity(new Intent(MainActivity.this,HelloUser.class));
                                  finish();
                              } else {
                                  //Decrement the attempts
                                  Attempts--;
                                  //Output Attempts
                                  intApptempts.setText("Attempts: " + Attempts);
                                  if (Attempts == 0) {
                                      btnLogin.setEnabled(false);
                                      Toast.makeText(MainActivity.this, "Tài khoản của bạn bị khóa trong vòng 1 ngày"
                                              , Toast.LENGTH_LONG).show();
                                  } else {
                                      Toast.makeText(MainActivity.this, "Password không chính xác"
                                              ,Toast.LENGTH_LONG).show();
                                  }
                              }
                          }
                          else
                          {
                              Toast.makeText(MainActivity.this, "Username không chính xác"
                                      ,Toast.LENGTH_LONG).show();
                          }
                      }
                      @Override
                      public void onCancelled(@NonNull DatabaseError error) {

                      }
                  });
              }
        });
        //Button Create New Account
        btnCNA.setOnClickListener(view -> Register());
    }
    //Button Create New Account
    public void Register(){
        Intent intent = new Intent(this, Register.class);
        startActivity(intent);
    }
}
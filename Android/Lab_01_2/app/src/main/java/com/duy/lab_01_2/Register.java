package com.duy.lab_01_2;

import android.os.Bundle;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import com.google.firebase.database.DataSnapshot;
import com.google.firebase.database.DatabaseError;
import com.google.firebase.database.DatabaseReference;
import com.google.firebase.database.FirebaseDatabase;
import com.google.firebase.database.ValueEventListener;

public class Register extends AppCompatActivity {

    //Kết nối đến firedase
    DatabaseReference databaseReference = FirebaseDatabase.getInstance()
            .getReferenceFromUrl("https://loginregister-a1a3f-default-rtdb.firebaseio.com/");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_register);

        final EditText email = findViewById(R.id.editEmail);
        final EditText userName = findViewById(R.id.editUserName);
        final EditText passWord = findViewById(R.id.editPassWord);
        final EditText retypePw = findViewById(R.id.editRetypePW);

        final Button btnCreatAcc = findViewById(R.id.btnCreateAcc);

        btnCreatAcc.setOnClickListener(view -> {
            final String txtEmail = email.getText().toString();
            final String txtUserName = userName.getText().toString();
            final String txtPassWord = passWord.getText().toString();
            final String txtRetypePW = retypePw.getText().toString();

            if (txtEmail.isEmpty() || txtUserName.isEmpty()
                    || txtPassWord.isEmpty() || txtRetypePW.isEmpty()){
                Toast.makeText(Register.this,"Chưa nhập đầy đủ thông tin!"
                        ,Toast.LENGTH_SHORT).show();
            }else if (!txtRetypePW.equals(txtPassWord)){
                Toast.makeText(Register.this,"Password không khới nhau!"
                        ,Toast.LENGTH_SHORT).show();
            }
            else{
                databaseReference.child("users").addListenerForSingleValueEvent(new ValueEventListener() {
                    @Override
                    //Check tài khoản đã tạo trước đây chưa
                    public void onDataChange(@NonNull DataSnapshot snapshot) {
                        if (snapshot.hasChild(txtUserName) && snapshot.hasChild(txtEmail)){
                            Toast.makeText(Register.this,"Tài Khoản đã được tạo rồi!"
                                    ,Toast.LENGTH_SHORT).show();
                        }else {

                            databaseReference.child("users").child(txtUserName).child("Email").setValue(txtEmail);
                            databaseReference.child("users").child(txtUserName).child("UserName").setValue(txtUserName);
                            databaseReference.child("users").child(txtUserName).child("PassWord").setValue(txtPassWord);

                            Toast.makeText(Register.this, "Tài Khoản đã được tạo thành công!",
                                    Toast.LENGTH_SHORT).show();
                            finish();
                        }
                    }
                    @Override
                    public void onCancelled(@NonNull DatabaseError error) {
                    }
                });
            }
        });
    }
}

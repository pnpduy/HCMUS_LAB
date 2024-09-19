package com.duy.bmicalculator;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;


public class MainActivity extends AppCompatActivity {

    EditText height, weight;
    TextView BMIresult;
    Button btnResult;
    String Output, BMI_Calculation;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.bmi_layout);

        height = findViewById(R.id.editHeight);
        weight = findViewById(R.id.editWeight);
        BMIresult = findViewById(R.id.txtOutput);
        btnResult = findViewById(R.id.btnResult);

        btnResult.setOnClickListener(v -> {
            String txtHeight = height.getText().toString();
            String txtWeight = weight.getText().toString();

            float heightValue = Float.parseFloat(txtHeight);
            float weightValue = Float.parseFloat(txtWeight);
            float BMI = weightValue / ((heightValue/100 * heightValue/100));

            if(txtHeight.isEmpty() || txtWeight.isEmpty()){
                Toast.makeText(this, "Please enter the full height and weight!", Toast.LENGTH_LONG).show();
            } else if(BMI < 18.5){
                Output = "You are categorized as underweight";
            } else if(BMI >= 18.5 && BMI < 24.5  ){
                Output = "You are categorized as normal weight";
            } else if(BMI >= 24.5 && BMI < 29.9  ){
                Output = "You are categorized as overweight.";
            } else if(BMI >= 29.9 && BMI < 34.9  ){
                Output = "You are categorized as obese class I (Moderately obese)";
            } else if(BMI >= 34.9 && BMI < 39.9  ){
                Output = "You are categorized as obese class II (Severely obese)";
            } else if(BMI >= 39.9 ){
                Output = "You are categorized as obese class III (Very severely)";
            }
            String a = String.format("%.2f", BMI);
            BMI_Calculation = "Your BMI is " + a + "\n"
                    + Output;
            BMIresult.setText(BMI_Calculation);
        });
    }
}
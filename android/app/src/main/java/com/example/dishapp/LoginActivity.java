package com.example.dishapp;

import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;

import org.json.JSONException;

public class LoginActivity extends AppCompatActivity implements View.OnClickListener {
    DBHelperURL dbHelperURL = new DBHelperURL(this);

    EditText editText_name;
    EditText editText_pass;

    Button button_logIn;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        editText_name = findViewById(R.id.editText_login);
        editText_pass = findViewById(R.id.editText_pass);

        button_logIn = findViewById(R.id.button_logIn);
        button_logIn.setOnClickListener(this);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.refresh, menu);

        return true;
    }

    @Override
    public boolean onOptionsItemSelected(@NonNull MenuItem item) {
        dbHelperURL.getUsers();
        return true;
    }

    @Override
    public void onClick(View v) {
        try {
            if (dbHelperURL.checkUserPass(
                    editText_name.getText().toString(),
                    editText_pass.getText().toString())) {
                Intent tempIntent = new Intent(this, MainActivity.class);
                startActivity(tempIntent);
            } else {
                Toast.makeText(getApplicationContext(),
                        "Неверное имя пользователя или пароль (Не забудьте про кнопку обновления)!",
                        Toast.LENGTH_SHORT).show();
            }
        } catch (JSONException e) {
            e.printStackTrace();
        }
    }
}

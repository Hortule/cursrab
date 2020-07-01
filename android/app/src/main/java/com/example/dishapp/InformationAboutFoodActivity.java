package com.example.dishapp;

import androidx.appcompat.app.AppCompatActivity;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.widget.ImageView;
import android.widget.TextView;

public class InformationAboutFoodActivity extends AppCompatActivity {
    String id;
    ImageView imageViewFood;
    TextView textViewPrice;
    TextView textViewSostav;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_information_about_food);

        setTitle(getIntent().getStringExtra("name"));

        imageViewFood = findViewById(R.id.imageView_foodPic);
        textViewPrice = findViewById(R.id.textView_price);
        textViewSostav = findViewById(R.id.textView_sostav);
        id = getIntent().getStringExtra("id");

        DBHelper dbHelper = new DBHelper(this);
        SQLiteDatabase sqLiteDatabase = dbHelper.getWritableDatabase();
        String selection = DBHelper.KEY_ID + " = ?";
        Cursor cursor = sqLiteDatabase.query(DBHelper.TABLE_MEAL,
                null, selection,
                new String[]{id},
                null, null, null);
        cursor.moveToFirst();
        int sostavIndex = cursor.getColumnIndex(DBHelper.KEY_SOSTAV);
        String temp = cursor.getString(sostavIndex);
        int firstDoubleDot = temp.indexOf(':');
        int firstSlash = temp.indexOf('/');
        int secondSlash = temp.indexOf('/', firstSlash + 1);

        textViewPrice.setText("Текущая цена:\n" + temp.substring(0, firstDoubleDot) + " рублей");

        String[] tempSostav = temp.substring(firstSlash + 1, secondSlash).split(",");
        StringBuilder tempSostavFinal = new StringBuilder();
        for (String s : tempSostav) tempSostavFinal.append(s).append("\n");
        textViewSostav.setText(tempSostavFinal.toString());

        String base64Image = temp.substring(secondSlash + 1).split(",")[1];
        byte[] decodedString = Base64.decode(base64Image, Base64.DEFAULT);
        Bitmap decodedByte = BitmapFactory.decodeByteArray(decodedString, 0, decodedString.length);
        imageViewFood.setImageBitmap(decodedByte);

        cursor.close();
        sqLiteDatabase.close();
        dbHelper.close();
    }
}

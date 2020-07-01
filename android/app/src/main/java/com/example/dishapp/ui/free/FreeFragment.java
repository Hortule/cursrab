package com.example.dishapp.ui.free;

import android.content.ContentValues;
import android.content.Intent;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import com.example.dishapp.DBHelper;
import com.example.dishapp.FoodListView;
import com.example.dishapp.R;

import java.util.ArrayList;

public class FreeFragment extends Fragment implements View.OnClickListener, AdapterView.OnItemClickListener, AdapterView.OnItemLongClickListener {
    private ListView listView_allFood;

    private ArrayList<String> prices = new ArrayList<>();
    private ArrayList<String> titles = new ArrayList<>();
    private ArrayList<Bitmap> images = new ArrayList<>();
    private ArrayList<String> fullSostavStrings = new ArrayList<>();

    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        View root = inflater.inflate(R.layout.fragment_free, container, false);

        listView_allFood = root.findViewById(R.id.list_mealsFree);
        listView_allFood.setOnItemClickListener(this);
        listView_allFood.setOnItemLongClickListener(this);

        Button button_searchFood = root.findViewById(R.id.button_searchFood);
        button_searchFood.setOnClickListener(this);

        makeListFood();

        return root;
    }

    private void makeListFood() {
        prices.clear();
        titles.clear();
        images.clear();
        fullSostavStrings.clear();

        DBHelper dbHelper = new DBHelper(getContext());
        SQLiteDatabase sqLiteDatabase = dbHelper.getWritableDatabase();
        Cursor cursor =sqLiteDatabase.query(DBHelper.TABLE_MEAL, null, null,
                null, null, null, null);

        if (cursor.moveToFirst()) {
            int sostavIndex = cursor.getColumnIndex(DBHelper.KEY_SOSTAV);
            int idIndex = cursor.getColumnIndex(DBHelper.KEY_ID);
            do {
                String temp = cursor.getString(sostavIndex);
                fullSostavStrings.add(temp);
                int firstDoubleDot = temp.indexOf(':');
                int firstSlash = temp.indexOf('/');
                int secondSlash = temp.indexOf('/', firstSlash + 1);

                prices.add(temp.substring(0, firstDoubleDot) + " рублей");
                titles.add(temp.substring(firstDoubleDot + 1, firstSlash) +
                        " (id " + cursor.getInt(idIndex) + ")");

                String base64Image = temp.substring(secondSlash + 1).split(",")[1];
                byte[] decodedString = Base64.decode(base64Image, Base64.DEFAULT);
                Bitmap decodedByte = BitmapFactory.decodeByteArray(decodedString, 0, decodedString.length);
                images.add(decodedByte);
            } while (cursor.moveToNext());
        }

        FoodListView foodListView = new FoodListView(
                getActivity(),
                titles.toArray(new String[0]),
                prices.toArray(new String[0]),
                images.toArray(new Bitmap[0])
        );
        listView_allFood.setAdapter(foodListView);

        cursor.close();
        dbHelper.close();
    }

    @Override
    public void onClick(View v) {
        makeListFood();
    }

    @Override
    public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
        String tempString = titles.get(position);

        Intent intent_information = new Intent(getActivity(), com.example.dishapp.InformationAboutFoodActivity.class);
        intent_information.putExtra("id",
                tempString.substring(tempString.indexOf("(") + 3, tempString.indexOf(")")));
        intent_information.putExtra("name", tempString.substring(0, tempString.indexOf("(")));
        startActivity(intent_information);
    }

    @Override
    public boolean onItemLongClick(AdapterView<?> parent, View view, int position, long id) {
        String tempTitles = titles.get(position);
        String foodId = tempTitles.substring(tempTitles.indexOf("(") + 3, tempTitles.indexOf(")"));

        DBHelper dbHelper = new DBHelper(getContext());
        SQLiteDatabase sqLiteDatabase = dbHelper.getWritableDatabase();
        Cursor cursor = sqLiteDatabase.query(DBHelper.TABLE_ZAKAZ, null, null,
                null, null, null, null);
        cursor.moveToFirst();
        int firstIndex = cursor.getColumnIndex(DBHelper.KEY_ONE);
        int twoIndex = cursor.getColumnIndex(DBHelper.KEY_TWO);
        int threeIndex = cursor.getColumnIndex(DBHelper.KEY_THREE);
        int fourIndex = cursor.getColumnIndex(DBHelper.KEY_FOUR);
        int fiveIndex = cursor.getColumnIndex(DBHelper.KEY_FIVE);
        int sixIndex = cursor.getColumnIndex(DBHelper.KEY_SIX);

        boolean setIs = false;
        if (cursor.getInt(firstIndex) == 0) {
            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelper.KEY_ONE, foodId);
            sqLiteDatabase.update(DBHelper.TABLE_ZAKAZ, contentValues, null, null);

            setIs = true;
        } else if (cursor.getInt(twoIndex) == 0) {
            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelper.KEY_TWO, foodId);
            sqLiteDatabase.update(DBHelper.TABLE_ZAKAZ, contentValues, null, null);

            setIs = true;
        } else if (cursor.getInt(threeIndex) == 0) {
            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelper.KEY_THREE, foodId);
            sqLiteDatabase.update(DBHelper.TABLE_ZAKAZ, contentValues, null, null);

            setIs = true;
        } else if (cursor.getInt(fourIndex) == 0) {
            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelper.KEY_FOUR, foodId);
            sqLiteDatabase.update(DBHelper.TABLE_ZAKAZ, contentValues, null, null);

            setIs = true;
        } else if (cursor.getInt(fiveIndex) == 0) {
            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelper.KEY_FIVE, foodId);
            sqLiteDatabase.update(DBHelper.TABLE_ZAKAZ, contentValues, null, null);

            setIs = true;
        } else if (cursor.getInt(sixIndex) == 0) {
            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelper.KEY_SIX, foodId);
            sqLiteDatabase.update(DBHelper.TABLE_ZAKAZ, contentValues, null, null);

            setIs = true;
        } else
            Toast.makeText(getContext(), "Не более шести позиций в составе заказа!", Toast.LENGTH_SHORT).show();

        if (setIs) {
            Toast.makeText(getContext(), "Блюдо добавлено в заказ", Toast.LENGTH_SHORT).show();

            ContentValues contentValues = new ContentValues();
            contentValues.put(DBHelper.KEY_SOSTAV, addChar(fullSostavStrings.get(position), fullSostavStrings.get(position).indexOf(':') + 1));
            sqLiteDatabase.update(DBHelper.TABLE_MEAL, contentValues, DBHelper.KEY_ID + " = ?", new String[] {foodId});

            makeListFood();
        }

        cursor.close();
        sqLiteDatabase.close();
        dbHelper.close();

        return true;
    }

    private String addChar(String str, int position) {
        int len = str.length();
        char[] updatedArr = new char[len + 1];
        str.getChars(0, position, updatedArr, 0);
        updatedArr[position]= '!';
        str.getChars(position, len, updatedArr, position + 1);
        return new String(updatedArr);
    }
}
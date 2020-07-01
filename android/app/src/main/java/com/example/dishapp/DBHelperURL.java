package com.example.dishapp;

import android.content.ContentValues;
import android.content.Context;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;

import com.loopj.android.http.AsyncHttpClient;
import com.loopj.android.http.JsonHttpResponseHandler;

import org.json.JSONArray;
import org.json.JSONException;

import cz.msebera.android.httpclient.Header;

public class DBHelperURL{
    private String URL_ADD_ZAKAZ = "http://cherrypinata.online:1884/add/zakaz";

    private JSONArray jsonArray_users;

    private JSONArray jsonArray_meals;

    private Context context;

    private int usrId;

    DBHelperURL(Context context) {
        this.context = context;
    }

    void getUsers() {
        AsyncHttpClient asyncHttpClient = new AsyncHttpClient();

        String URL_SELECT_USERS = "http://cherrypinata.online:1884/select/users";
        asyncHttpClient.get(URL_SELECT_USERS, new JsonHttpResponseHandler() {
            @Override
            public void onSuccess(int statusCode, Header[] headers, JSONArray response) {
                jsonArray_users = response;

                Intent tempIntent = new Intent(context, TempActivity.class);
                context.startActivity(tempIntent);
            }
        });
    }

    void getMeals() {
        AsyncHttpClient asyncHttpClient = new AsyncHttpClient();

        String URL_SELECT_MEALS = "http://cherrypinata.online:1884/select/meal";
        asyncHttpClient.get(URL_SELECT_MEALS, new JsonHttpResponseHandler() {
            @Override
            public void onSuccess(int statusCode, Header[] headers, JSONArray response) {
                jsonArray_meals = response;

                Intent tempIntent = new Intent(context, TempActivity.class);
                context.startActivity(tempIntent);

                DBHelper dbHelper = new DBHelper(context);
                SQLiteDatabase sqLiteDatabase = dbHelper.getWritableDatabase();
                sqLiteDatabase.delete(DBHelper.TABLE_MEAL, null, null);
                sqLiteDatabase.close();

                for (int i = 0; i < jsonArray_meals.length(); ++i) {
                    ContentValues contentValues = new ContentValues();
                    try {
                        contentValues.put(DBHelper.KEY_TYPE, jsonArray_meals.getJSONObject(i).getInt("type"));
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                    try {
                        contentValues.put(DBHelper.KEY_RESTRICTION_ID, jsonArray_meals.getJSONObject(i).getInt("restriction_id"));
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                    try {
                        contentValues.put(DBHelper.KEY_SOSTAV, jsonArray_meals.getJSONObject(i).getString("sostav"));
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                    sqLiteDatabase = dbHelper.getWritableDatabase();
                    sqLiteDatabase.insert(DBHelper.TABLE_MEAL, null, contentValues);

                    sqLiteDatabase.close();
                    dbHelper.close();
                }

                sqLiteDatabase = dbHelper.getWritableDatabase();
                sqLiteDatabase.delete(DBHelper.TABLE_ZAKAZ, null, null);

                ContentValues contentValues = new ContentValues();
                contentValues.put(DBHelper.KEY_USER_ID, usrId);
                sqLiteDatabase.insert(DBHelper.TABLE_ZAKAZ, null, contentValues);
            }
        });
    }

    boolean checkUserPass(String name, String pass) throws JSONException {
        boolean was = false;

        if (jsonArray_users == null)
            return false;

        for (int i = 0; i < jsonArray_users.length(); ++i) {
            String tempName = jsonArray_users.getJSONObject(i).getString("name").substring(0,
                    jsonArray_users.getJSONObject(i).getString("name").indexOf("/"));

            if (tempName.equalsIgnoreCase(name) &&
                    jsonArray_users.getJSONObject(i).getString("password").equalsIgnoreCase(pass)) {
                was = true;

                DBHelper dbHelper = new DBHelper(context);
                SQLiteDatabase sqLiteDatabase = dbHelper.getWritableDatabase();
                sqLiteDatabase.delete(DBHelper.TABLE_USERS_ID, null, null);

                ContentValues contentValues = new ContentValues();
                contentValues.put(DBHelper.KEY_ID, jsonArray_users.getJSONObject(i).getInt("id"));
                contentValues.put(DBHelper.KEY_USER_NAME, jsonArray_users.getJSONObject(i).getString("name"));
                contentValues.put(DBHelper.KEY_IGOT, jsonArray_users.getJSONObject(i).getBoolean("lgot") ? 1 : 0);
                contentValues.put(DBHelper.KEY_RESTRICTION_ID, jsonArray_users.getJSONObject(i).getInt("restriction_id"));
                sqLiteDatabase.insert(DBHelper.TABLE_USERS_ID, null, contentValues);

                usrId = jsonArray_users.getJSONObject(i).getInt("id");

                sqLiteDatabase.close();

                sqLiteDatabase = dbHelper.getWritableDatabase();
                sqLiteDatabase.delete(DBHelper.TABLE_ZAKAZ, null, null);

                contentValues = new ContentValues();
                contentValues.put(DBHelper.KEY_USER_ID, jsonArray_users.getJSONObject(i).getInt("id"));
                sqLiteDatabase.insert(DBHelper.TABLE_ZAKAZ, null, contentValues);

                sqLiteDatabase.close();
                dbHelper.close();

                break;
            }
        }

        return was;
    }
}

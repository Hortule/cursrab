package com.example.dishapp;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

import androidx.annotation.Nullable;

public class DBHelper extends SQLiteOpenHelper {
    // Данные бд
    private static final int DATABASE_VERSION = 1;
    private static final String DATABASE_NAME = "Db";
    public static final String TABLE_USERS_ID = "users_id";
    public static final String TABLE_ZAKAZ = "zakaz";
    public static final String TABLE_MEAL = "meal";

    public static final String KEY_ID = "id";
    public static final String KEY_USER_NAME = "name";
    static final String KEY_IGOT = "igot";
    static final String KEY_USER_ID = "user_id";
    private static final String KEY_DATE = "date";
    public static final String KEY_ONE = "one";
    public static final String KEY_TWO = "two";
    public static final String KEY_THREE = "three";
    public static final String KEY_FOUR = "four";
    public static final String KEY_FIVE = "five";
    public static final String KEY_SIX = "six";
    public static final String KEY_TYPE = "type";
    static final String KEY_RESTRICTION_ID = "restriction_id";
    public static final String KEY_SOSTAV = "sostav";


    public DBHelper(@Nullable Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }

    // Если базы данных нет - создай ее!
    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(
                "create table " + TABLE_USERS_ID + " (" +
                        KEY_ID + " integer," +
                        KEY_USER_NAME + " text," +
                        KEY_IGOT + " integer," +
                        KEY_RESTRICTION_ID + " integer" + ");"
        );
        db.execSQL(
                "create table " + TABLE_ZAKAZ + " (" +
                        KEY_ID + " integer primary key autoincrement," +
                        KEY_USER_ID + " integer," +
                        KEY_DATE + " text," +
                        KEY_ONE + " integer," +
                        KEY_TWO + " integer," +
                        KEY_THREE + " integer," +
                        KEY_FOUR + " integer," +
                        KEY_FIVE + " integer," +
                        KEY_SIX + " integer" + ");"
        );
        db.execSQL(
                "create table " + TABLE_MEAL + " (" +
                        KEY_ID + " integer primary key autoincrement," +
                        KEY_TYPE + " integer," +
                        KEY_RESTRICTION_ID + " integer," +
                        KEY_SOSTAV + " text" + ");"
        );
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        // TODO здесь просто пока заглушка
    }
}

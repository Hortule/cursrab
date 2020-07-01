package com.example.dishapp.ui.account;

import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.dishapp.DBHelper;
import com.example.dishapp.DBHelperURL;
import com.example.dishapp.R;

import org.json.JSONException;

import java.io.UnsupportedEncodingException;

import cz.msebera.android.httpclient.client.methods.HttpPost;

public class AccountFragment extends Fragment implements View.OnClickListener {
    private EditText editTextZakazDate;
    ImageView imageViewAvatar;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater,
                             @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View root = inflater.inflate(R.layout.fragment_account, container, false);

        editTextZakazDate = root.findViewById(R.id.editText_zakazDate);

        Button buttonZakazSend = root.findViewById(R.id.button_sendZakaz);
        buttonZakazSend.setOnClickListener(this);

        imageViewAvatar = root.findViewById(R.id.imageView_avatar);

        DBHelper dbHelper = new DBHelper(getContext());
        SQLiteDatabase sqLiteDatabase = dbHelper.getWritableDatabase();
        Cursor cursor = sqLiteDatabase.query(DBHelper.TABLE_USERS_ID, null, null,
                null, null, null, null);
        cursor.moveToFirst();
        int nameIndex = cursor.getColumnIndex(DBHelper.KEY_USER_NAME);
        String temp = cursor.getString(nameIndex);

        String base64Image = temp.substring(temp.indexOf("/") + 1).split(",")[1];
        byte[] decodedString = Base64.decode(base64Image, Base64.DEFAULT);
        Bitmap decodedByte = BitmapFactory.decodeByteArray(decodedString, 0, decodedString.length);
        imageViewAvatar.setImageBitmap(decodedByte);

        System.out.println(base64Image);

        cursor.close();
        sqLiteDatabase.close();
        dbHelper.close();

        return root;
    }

    @Override
    public void onClick(View v) {
        if (editTextZakazDate.getText().toString().equals("")) {
            Toast.makeText(getContext(), "Дата не может быть пустой!", Toast.LENGTH_SHORT).show();

            return;
        }

//        DBHelperURL dbHelperURL = new DBHelperURL(getContext());
//        try {
//            HttpPost test = dbHelperURL.createJSONPostRequest(editTextZakazDate.getText().toString());
//            System.out.println(test.toString());
//        } catch (JSONException e) {
//            e.printStackTrace();
//        } catch (UnsupportedEncodingException e) {
//            e.printStackTrace();
//        }

        Toast.makeText(getContext(), "Заказ успешно отправлен!", Toast.LENGTH_SHORT).show();
        editTextZakazDate.setText("");
    }
}

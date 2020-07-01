package com.example.dishapp;

import android.app.Activity;
import android.graphics.Bitmap;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.TextView;

public class FoodListView extends ArrayAdapter<String> {
    private final Activity context;
    private final String[] prices;
    private final String[] title;
    private final Bitmap[] img;


    public FoodListView(Activity context, String[] title, String[] subtitle, Bitmap[] img) {
        super(context, R.layout.food_list, title);

        this.context = context;
        this.title = title;
        this.prices = subtitle;
        this.img = img;

    }

    public View getView(int position, View view, ViewGroup parent) {
        LayoutInflater inflater = context.getLayoutInflater();
        View rowView = inflater.inflate(R.layout.food_list, null,true);

        TextView titleText = rowView.findViewById(R.id.title);
        TextView subtitleText = rowView.findViewById(R.id.subtitle);
        ImageView imageView = rowView.findViewById(R.id.icon);

        titleText.setText(title[position].substring(0, title[position].indexOf("(") - 1));
        subtitleText.setText(prices[position]);
        imageView.setImageBitmap(img[position]);

        return rowView;

    }
}

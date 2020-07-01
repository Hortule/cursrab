package com.example.dishapp.ui.review;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

import com.example.dishapp.R;

public class ReviewFragment extends Fragment implements View.OnClickListener {
    EditText editTextName;
    EditText editTextClass;
    EditText editTextComm;
    Button buttonSend;

    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater,
                             @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {
        View root = inflater.inflate(R.layout.fragment_review, container, false);

        editTextName = root.findViewById(R.id.text_name);
        editTextClass = root.findViewById(R.id.text_class);
        editTextComm = root.findViewById(R.id.text_changeling);

        buttonSend = root.findViewById(R.id.button_confirm);
        buttonSend.setOnClickListener(this);

        return root;
    }

    @Override
    public void onClick(View v) {
        editTextName.setText("");
        editTextClass.setText("");
        editTextComm.setText("");

        Toast.makeText(getContext(), "Отправлено!", Toast.LENGTH_SHORT).show();
    }
}

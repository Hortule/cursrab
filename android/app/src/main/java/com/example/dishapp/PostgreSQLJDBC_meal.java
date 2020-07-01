package com.example.dishapp;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.LinkedList;

public class PostgreSQLJDBC_meal {
    private Connection connection = null;

    private Boolean error = false;

    public PostgreSQLJDBC_meal() {
        String db_URL = "95.216.199.92:5432";
        String db_DB = "db";
        String db_USER = "mp";
        String db_PASS = "qwerty";
        try {
            Class.forName("org.postgresql.Driver");
            connection = DriverManager.getConnection(
                "jdbc:postgresql://" + db_URL + "/" + db_DB,
                    db_USER,
                    db_PASS
            );
            connection.setAutoCommit(false);
        } catch (ClassNotFoundException e) {
            error = true;
        } catch (SQLException e) {
            error = true;
        }
    }

    LinkedList<String> getMeals(int type) {
        // TODO Сделай типы
        LinkedList<String> allMeals = new LinkedList<>();

        try {
            Statement statement = connection.createStatement();
            String db_TABLE = "meal";
            ResultSet resultSet = statement.executeQuery("SELECT * FROM " + db_TABLE + ";");

            while (resultSet.next()) {
                int mealType = resultSet.getInt("type");
                if (mealType == type || type == 3) {
                    // TODO Названия блюд!
//                String mealName = resultSet.getString("name");
                    String mealName = "";
                    String mealComposition = resultSet.getString("sostav");
                    // TODO Картинки еды!

                    allMeals.add(mealName);
                    allMeals.add(mealComposition);
                }
            }
            resultSet.close();
            statement.close();
        } catch (SQLException e) {
            return null;
        }

        return allMeals;
    }

    LinkedList<String> getMeals() {
        return getMeals(3);
    }

    Boolean isError() {
        return error;
    }

    Boolean close() {
        try {
            connection.close();

            return true;
        } catch (SQLException e) {
            return false;
        }
    }
}

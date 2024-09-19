package com.duy.lab_03_listview;

import java.io.Serializable;
public class Food implements Serializable {
    private int image;
    private String food;
    private String name;
    private String price;
    public Food(int image, String food, String name, String price) {
        this.image = image;
        this.food = food;
        this.name = name;
        this.price = price;
    }
    public int getImage() {
        return image;
    }

    public void setImage(int image) {
        this.image = image;
    }

    public String getFood() {
        return food;
    }

    public void setFood(String food) {
        this.food = food;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPrice() {
        return price;
    }

    public void setPrice(String price) {
        this.price = price;
    }
}

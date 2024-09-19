package com.duy.lab_05;

public class Food {
    private int Id;
    private String Food;
    private String Name;
    private String Price;
    private byte[] Image;

    public Food(int id, String food, String name, String price, byte[] image) {
        Id = id;
        Food = food;
        Name = name;
        Price = price;
        Image = image;
    }

    public int getId() {
        return Id;
    }
    public void setId(int id) {
        Id = id;
    }
    public String getFood() {
        return Food;
    }
    public void setFood(String food) {
        Food = food;
    }
    public String getName() {
        return Name;
    }
    public void setName(String name) {
        Name = name;
    }
    public String getPrice() {
        return Price;
    }
    public void setPrice(String price) {
        Price = price;
    }
    public byte[] getImage() {
        return Image;
    }
    public void setImage(byte[] image) {
        Image = image;
    }
}

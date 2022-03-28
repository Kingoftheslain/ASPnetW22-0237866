using System.Collections.Generic;

public class GroceryIsle{
    public List<FoodItem> listofFoodItem { get; set; }
    public int aisleNum { get; set; }
    public string aisleName { get; set; }

    public GroceryIsle() {
        listofFoodItem = new List<FoodItem>();
    }
    public void NewFood(FoodItem newFoodItem) {
        listofFoodItem.Add(newFoodItem);
    }
}



public class FoodItem {
    public int idNum { get; set;} 
    public int quantity { get; set;} 
    public string itemName { get; set;} 
    public string foodType { get; set;} 


public void quanIncrease() {
    if (quantity < 20)
        quantity++;
}

public void quanDecrease() {
    if (quantity > 0)
        quantity--;
}

}
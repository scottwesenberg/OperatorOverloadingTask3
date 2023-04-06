class InventoryItem
{
    public int? Quantity { get; set; }

    public static InventoryItem operator +(InventoryItem positiveItem, InventoryItem negativeItem)
    {
        int? result = positiveItem.Quantity + negativeItem.Quantity;
        return new InventoryItem { Quantity = result };
    }

    public static bool operator >(InventoryItem positiveItem, InventoryItem negativeItem)
    {
        return positiveItem.Quantity > negativeItem.Quantity;
    }

    public static bool operator <(InventoryItem positiveItem, InventoryItem negativeItem)
    {
        return positiveItem.Quantity < negativeItem.Quantity;
    }

    public static bool operator ==(InventoryItem positiveItem, InventoryItem negativeItem)
    {
        return positiveItem.Quantity == negativeItem.Quantity;
    }

    public static bool operator !=(InventoryItem positiveItem, InventoryItem negativeItem)
    {
        return positiveItem.Quantity != negativeItem.Quantity;
    }

    public static InventoryItem operator ++(InventoryItem item)
    {
        int? result = item.Quantity + 1;
        return new InventoryItem { Quantity = result };
    }

    public static InventoryItem operator --(InventoryItem item)
    {
        int? result = item.Quantity - 1;
        return new InventoryItem { Quantity = result };
    }

    public static bool operator !(InventoryItem item)
    {
        return item.Quantity == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        InventoryItem positiveItem = new InventoryItem { Quantity = 5 };
        InventoryItem negativeItem = new InventoryItem { Quantity = -6 };

        // Unary operators
        Console.WriteLine("Unary:");   
        Console.WriteLine($"Positive Inventory: {+positiveItem.Quantity}");
        Console.WriteLine($"Negative Inventory (Need Reorder): {-negativeItem.Quantity}");
        Console.WriteLine($"Equal Positive to Negative?: {!positiveItem}");
        Console.WriteLine($"Increment Positive Inventory: {(positiveItem++)?.Quantity}");
        Console.WriteLine($"Decrement Positive Inventory: {(positiveItem--)?.Quantity}");
        Console.WriteLine();

        // Binary operators
        Console.WriteLine("Binary:");
        InventoryItem item3 = positiveItem + negativeItem;
        Console.WriteLine($"Positive Inventory + Negative Inventory = {item3.Quantity}");
        Console.WriteLine($"Positive Inventory > Negative Inventory: {positiveItem > negativeItem}");
        Console.WriteLine($"Positive Inventory < Negative Inventory: {positiveItem < negativeItem}");
        Console.WriteLine($"Positive Inventory == Negative Inventory: {positiveItem == negativeItem}");
        Console.WriteLine($"Positive Inventory != Negative Inventory: {positiveItem != negativeItem}");
    }
}

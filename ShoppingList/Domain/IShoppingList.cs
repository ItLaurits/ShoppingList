namespace ShoppingList.Domain
{
    public interface IShoppingList
    {
        void AddItem(string itemName);
        void RemoveItem(ShoppingItem shoppingItem);

    }
}

using ShoppingList.Domain;

namespace ShoppingList.Repositories
{
    public interface IShoppingItemRepository
    {

        //One could use IoC here on "ShoppingItem"
        List<ShoppingItem> GetAll();

        List<ShoppingItem> GetAllInList(int shoppingListId);

        ShoppingItem GetItemById(int id);

        ShoppingItem AddItem(ShoppingItem item);

        ShoppingItem UpdateItem(ShoppingItem item);

        ShoppingItem RemoveItem(ShoppingItem item);

    }
}

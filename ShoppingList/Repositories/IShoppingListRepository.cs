namespace ShoppingList.Repositories
{

    //Could this be made generic?
    public interface IShoppingListRepository
    {

        List<ShoppingList> GetAll();

        ShoppingList GetListById(int id);

        ShoppingList AddList(ShoppingList list);

        ShoppingList UpdateList(ShoppingList list);

        ShoppingList RemoveList(ShoppingList list);
    }
}

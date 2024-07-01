using ShoppingList.Domain;
using ShoppingList.Repositories;
using ShoppingList.Services;

namespace ShoppingList
{
    public class ShoppingList : IShoppingList
    {
        //Using our IoC-container (hopefully)
        private readonly IShoppingListRepository _shoppingListRepository;
        private readonly UniqueIdService<IShoppingListRepository> _uniqueIdService;

        public List<ShoppingItem?> ShoppingItems;
        public int Id;
        public ShoppingList()
        {
            ShoppingItems = new List<ShoppingItem?>();
            Id = _uniqueIdService.GenerateUniqueId(_shoppingListRepository);
        }
        public void AddItem(string shoppingItemName)
        {
            ShoppingItems.Add(new ShoppingItem(shoppingItemName));
        }

        public void RemoveItem(ShoppingItem shoppingItem)
        {
            if (ShoppingItems.Contains(shoppingItem))
            {
                ShoppingItems.Remove(shoppingItem);
            }

        }
    }
}

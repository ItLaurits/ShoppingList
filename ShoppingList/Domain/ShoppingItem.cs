using ShoppingList.Repositories;
using ShoppingList.Services;

namespace ShoppingList.Domain

{
    public class ShoppingItem : IShoppingItem
    {
        private readonly IShoppingItemRepository _shoppingItemRepository;
        private readonly UniqueIdService<IShoppingItemRepository> _uniqueIdService;

        public string Name
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }

        public ShoppingItem(string name)
        {
            Name = name;
            Id = _uniqueIdService.GenerateUniqueId(_shoppingItemRepository);
        }


        public void UpdateName(string newName)
        {
            Name = newName;
        }
    }
}

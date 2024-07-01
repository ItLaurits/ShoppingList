using ShoppingList.Repositories;
using ShoppingList.Domain;

namespace ShoppingList.Services
{
    public class UniqueIdService<T>
    {

        private readonly IShoppingItemRepository _shoppingItemRepository;
        private readonly IShoppingListRepository _shoppingListRepository;
        public int GenerateUniqueId(T data)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            int uniqueId = -1;
            if (data.GetType() == typeof(ShoppingItem))
            {
                int highestExistingId = _shoppingItemRepository.GetAll().Max(x => x.Id);
                uniqueId = highestExistingId++;
                return uniqueId;
            }
            else if (data.GetType() == typeof(ShoppingList))
            {
                int highestExistingId = _shoppingListRepository.GetAll().Max(x => x.Id);
                uniqueId = highestExistingId++;
                return uniqueId;
            }


            throw new Exception("Data type could not be determined. Id has not been generated");

        }


    }
}

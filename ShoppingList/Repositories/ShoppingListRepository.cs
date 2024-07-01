namespace ShoppingList.Repositories
{
    //This is more or less pseudo code




    public class ShoppingListRepository : IShoppingListRepository
    {
        //private dbObject variable up here for class-wide scope

        public ShoppingList AddList(ShoppingList list)
        {
            var newList = new ShoppingList { Name = list.Name, ShoppingItems = list.ShoppingItems };
            dbObject.ShoppingList.Add(newList);
            dbObject.SaveChanges();
            return newList; //If we want to use it we have it now, otherwise we can freely discard it

        }

        public List<ShoppingList> GetAll()
        {
            var dbShoppingObject = dbObject.ShoppingList;
            var list = dbObject.ToList();
            return list;
        }

        public ShoppingList GetListById(int id)
        {
            var list = dbObject.ShoppingLists.Where(l => l.id == id);
            if (list.count != 1)
                throw new Exception("Data not consistent. Unable to retrieve list");
            else
                return list;
        }

        public ShoppingList RemoveList(ShoppingList list)
        {
            var listToRemove = dbObject.ShoppingLists.Where(l => l.id == list.id);
            if (listToRemove.count != 1)
                throw new Exception("Data not consistent. List was not deleted");
            else
            {
                dbObject.ShoppingLists.Remove(listToRemove);
                dbObject.SaveChanges();
                return listToRemove;
            }

        }

        public ShoppingList UpdateList(ShoppingList list)
        {
            var listToUpdate = dbObject.ShoppingLists.Where(l => l.id == list.id);
            if (listToUpdate.count != 1)
                throw new Exception("Data not consistent. List not found");
            else
            {
                listToUpdate.Name = list.Name;
                listToUpdate.ShoppingItems = list.ShoppingItems;
                dbObject.SaveChanges();
            }
        }
    }
}

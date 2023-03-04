using System.Collections.ObjectModel;
using Xamarin.Forms;
using XFDelivery.Models;

namespace XFDelivery.Service
{
    public class DataService
    {
        public static ObservableCollection<Group> GetGroups()
        {
            return new ObservableCollection<Group>()
            {
                new Group()
                {
                     description = "Tutto",
                     image = "brigadeiro",
                     selected = true,
                     backgroundColor = Color.FromHex("#FF8920")
                },
                new Group()
                {
                    description = "Pizza",
                    image = "pizza",
                    selected = false,
                     backgroundColor = Color.FromHex("#FFFFFF")
                },
                new Group()
                {
                    description = "Burgers",
                    image = "burger",
                    selected = false,
                     backgroundColor = Color.FromHex("#FFFFFF")
                },
                new Group()
                {
                    description = "Asian",
                    image = "junk_food",
                    selected = false,
                    backgroundColor = Color.FromHex("#FFFFFF")
                }
            };
        }

        public static ObservableCollection<Item> GetItems()
        {
            return new ObservableCollection<Item>()
            {
                new Item()
                {
                     description = "Margherita",
                     complement = "Pomodoro, Mozzarella, olive, basica",
                     image = "item1",
                     calories = 76,
                     price = 45,
                     rating = 4.2,
                     favorite = true
                },
                new Item()
                {
                     description = "Rughetta",
                     complement = "Rucola, Pomodorini, Carciofi, Parmigiano A Scaglie, Limone/E.V.O.O. Vestirsi",
                     calories = 70,
                     image = "item2",
                     price = 59,
                     rating = 3.8,
                     favorite = false
                },
                new Item()
                {
                     description = "Torta Banoffee",
                     complement = "Pollo impanato, prosciutto e pancetta, condito con rach fatto in casa",
                     image = "item3",
                     calories = 85,
                     rating = 4.9,
                     price = 106,
                     favorite = true
                },
            };
        }
    }
}

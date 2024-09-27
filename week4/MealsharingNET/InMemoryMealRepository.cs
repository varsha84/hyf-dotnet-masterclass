namespace MealsharingNET
{
    using System.Linq;
    public class InMemoryMealRepository : IMealRepository
    {

        private static List<Meal> Meals { get; set; } = new List<Meal>(){
        new Meal(){ID = 1, Title="chicken curry", Description="chicken curry mady by boneless chicken",Cost = 130, ImageUrl="img_chania.jpg", Location="valby",MaxReservations=12},
        new Meal(){ID = 2, Title="veg pasta", Description="veg pasta with white sauce",Cost = 95, ImageUrl="img_chania.jpg", Location="søborg",MaxReservations = 8},
        new Meal(){ID = 3, Title="Lamb curry", Description=" Lamb curry mady by boneless Lamb",Cost = 145, ImageUrl="img_chania.jpg", Location="ballerup",MaxReservations = 9}
        };
        public void AddMeal(Meal meal)
        {
            Meals.Add(meal);
        }
        public IEnumerable<Meal> MealList()
        {
            return Meals;
        }

        public Meal GetMealByID(int ID)
        {
            var meal = Meals.FirstOrDefault(meal => meal.ID == ID);
            return meal;
        }
    }
}
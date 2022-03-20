namespace MealsharingNET;

public interface IMealRepository
{

    void AddMeal(Meal meal);
    IEnumerable<Meal> MealList();

    Meal GetMealByID(int ID);
}
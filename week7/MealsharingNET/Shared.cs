/* public class Shared
{
    public const string ConnectionString = "server=localhost;port=3306;database=meal-sharing;Uid=root;Pwd=root;";
} */

public class Shared
{
  public static string ConnectionString = string.IsNullOrEmpty (Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb")) ? 
 "server=localhost;port=3306;database=meal-sharing;Uid=root;Pwd=root;Convert Zero Datetime=True"   :
 Environment.GetEnvironmentVariable("MYSQLCONNSTR_MealSharingDb");
}
/*


Define enumerations for the three variations on food: type (soup, stew, gumbo), main ingredient
(mushrooms, chicken, carrots, potatoes), and seasoning (spicy, salty, sweet).


Make a tuple variable to represent a soup composed of the three above enumeration types.


Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple
with the results. Hint: You could give the user a menu to pick from or simply compare the user’s
text input against specific strings to determine which enumeration value represents their choice.


When done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.”
Hint: You don’t need to convert the enumeration value back to a string. Simply displaying an
enumeration value with Write or WriteLine will display the name of the enumeration value.)


*/


Console.WriteLine("What would be your order today?");


var dishNameTuple = new Tuple<string, string, string>(
   nameof(DishName.soup),
   nameof(DishName.stew),
   nameof(DishName.gumbo)
);


var dishMainIngredientTuple = new Tuple<string, string, string, string>(


   nameof(DishMainIngredient.mushroom),
   nameof(DishMainIngredient.chicken),
   nameof(DishMainIngredient.carrot),
   nameof(DishMainIngredient.potatoe)


);


var dishSeasoningTypeTuple = new Tuple<string, string, string>(
   nameof(DishSeasoningType.spicy),
   nameof(DishSeasoningType.salty),
   nameof(DishSeasoningType.sweet)
);


Console.WriteLine($"We are offering {dishNameTuple} with the following main ingredients {dishMainIngredientTuple} and with the following seasonings {dishSeasoningTypeTuple}.");
Console.WriteLine("Make your choice please.");


string userInput = Console.ReadLine();
string [] userInputParts = userInput.Split(' ');


if (userInputParts.Length == 3 &&
   Enum.TryParse<DishSeasoningType>(userInputParts[0], true, out var seasoning) &&         //how does this TryParse exactly work?
   Enum.TryParse<DishMainIngredient>(userInputParts[1], true, out var ingredient) &&
   Enum.TryParse<DishName>(userInputParts[2], true, out var dish))


{
   var
}




//var orderedDishTuple = (DishSeasoningType.spicy, DishMainIngredient.mushroom, DishName.soup);


//Console.WriteLine("Here is your dish: " + orderedDishTuple);
enum DishName
{
   soup,
   stew,
   gumbo
}


enum DishMainIngredient
{
   mushroom,
   chicken,
   carrot,
   potatoe
}


enum DishSeasoningType
{
   spicy,
   salty,
   sweet
}


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

//converting enum values to the tuple
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
Console.WriteLine("Make your choice please in the format of <spicy>, <mushroom>, <soup>");

// in the code below we are assigning a string value to a user's string input 
// and then are creating a new array called userInputParts while splitting user's input in a few strings.

string userInput = Console.ReadLine();
string [] userInputParts = userInput.Split(' ');

//here we are checking whether userInputParts has 3 elements and then are comparing those elements
//with those stored in the corresponding enums. 

if (userInputParts.Length == 3 &&
   Enum.TryParse<DishSeasoningType>(userInputParts[0], true, out var seasoning) &&      //checks the first element in the array userInputParts[] VS   
   Enum.TryParse<DishMainIngredient>(userInputParts[1], true, out var ingredient) &&      //enum userInputParts. Return, if true and the code continues
   Enum.TryParse<DishName>(userInputParts[2], true, out var dish))


{
   var orderedDishTuple = (seasoning, ingredient, dish);                //for example, the result in this variable looks something like this:
   Console.WriteLine($"Please check your order {orderedDishTuple} ");   //seasoning = DishSeasoningType.spicy
                                                                        //ingredient = DishMainIngredient.mushroom
                                                                        //dish = DishName.soup
}
else 
{
   Console.WriteLine("We are sorry, we are missing that from the menu.");
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


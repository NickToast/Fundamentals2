//THREE BASIC ARRAYS
//Create an integer array with the values 0 through 9 inside
int[] intArray = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

//testing in console
foreach (int integer in intArray)
{
    Console.WriteLine(intArray[integer]);
}

//Create a string array with the names "Tim", "Martin", "Nikki", and "Sara"
string[] namesArray = {"Tim", "Martin", "Nikki", "Sara"};

//Testing in console
foreach (string name in namesArray)
{
    Console.WriteLine($"{name}");
}

//Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in)
bool[] boolArray = new bool[10];

for (int i = 0; i < boolArray.Length; i++) 
{
    if (i % 2 == 0)
    {
        boolArray[i] = true;
    } else {
        boolArray[i] = false;
    }
}

//Testing in console
foreach (bool val in boolArray)
{
    Console.WriteLine(val);
}

//LIST OF FLAVORS
//Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5)
List<string> flavors = new List<string> ();

flavors.Add("Cookie Monster");
flavors.Add("Cotton Candy");
flavors.Add("Vanilla");
flavors.Add("Strawberry Shortcake");
flavors.Add("Cookie Dough");

//Testing
//Lists uses Count, not length
for (int i = 0; i < flavors.Count; i++)
{
    Console.WriteLine(flavors[i]);
}

//Output the length of the List after you added the flavors
Console.WriteLine(flavors.Count);

//Output the third flavor in the List
Console.WriteLine(flavors[2]);

//Now remove the third flavor using its index location
flavors.RemoveAt(2);

//Output the length of the List again, it should now be one fewer
Console.WriteLine(flavors.Count);

//USER DICTIONARY
//Create a dictionary that will store string keys and string values
Dictionary<string, string> people = new Dictionary<string, string> ();

//Add key/value pairs to the dictionary where: each key is a name from names array and each value is a randomly selected flavor from flavors list
foreach (string name in namesArray)
{
    //Create instance of the Random class
    Random rand = new Random();
    people.Add(name, flavors[rand.Next(flavors.Count)]);
}

//Loop through the dictionary and print out each user's name and their associated ice cream flavor
foreach (KeyValuePair<string, string> person in people)
{
    Console.WriteLine($"{person.Key} - {person.Value}");
}


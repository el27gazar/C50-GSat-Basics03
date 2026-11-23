#region Question 1

//Q1. Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
//both title and upperTitle to show that title did not change.

//string title = "clean code";
//string upperTitle = title.ToUpper();
//Console.WriteLine(title);
//Console.WriteLine(upperTitle);
#endregion

#region Question 2
//Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
//to check if they point to the same object in memory.

string s1 = "Clean Code";
string s2 = "Clean Code";

Console.WriteLine(ReferenceEquals(s1, s2));

#endregion
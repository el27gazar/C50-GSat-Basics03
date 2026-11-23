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

//string s1 = "Clean Code";
//string s2 = "Clean Code";

//Console.WriteLine(ReferenceEquals(s1, s2));

#endregion

#region Question 3

//Q3. Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
//object.Print the final result.

//using System.Text;

//StringBuilder sb = new StringBuilder();
//sb.Append("Book List");
//sb.Append(" - Updated");
//Console.WriteLine(sb);
#endregion

#region Question 4
//Q4. Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
//Print the result.
//sb.Replace("Book List", "Library");
//Console.WriteLine(sb);

#endregion

#region Question 5,6
//Q5. Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
//Pages: 464" using the + operator.

string title = "Clean Code";
int pages = 464;
Console.WriteLine("Book: " + title + ", Pages: " + pages);

//Q6. Build the same sentence as above, but using string interpolation ($"...")
Console.WriteLine($"Book: {title}, Pages: {pages}");
#endregion


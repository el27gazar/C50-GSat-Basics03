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

#region Question 5,6,7
//Q5. Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
//Pages: 464" using the + operator.

//string title = "Clean Code";
//int pages = 464;
//Console.WriteLine("Book: " + title + ", Pages: " + pages);

////Q6. Build the same sentence as above, but using string interpolation ($"...")
//Console.WriteLine($"Book: {title}, Pages: {pages}");

////Q7. Build the same sentence again, but using string.Format().
//Console.WriteLine(string.Format("Book: {0}, Pages: {1}", title, pages));
#endregion

#region Question 8
//Q8. Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
//300, otherwise prints "Short Book".

//int pages = 464;
//if(pages > 300)
//{
//    Console.WriteLine("Long Book");
//}
//else
//{
//    Console.WriteLine("Short Book");
//}
#endregion

#region Question 9
//Q9. Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
//greater than 300 and isAvailable is true. Use the && operator.

//int pages = 464;
//bool isAvailable = true;

//if(pages > 300 && isAvailable)
//{
//    Console.WriteLine("You can borrow this book");
//}
//else
//{
//    Console.WriteLine("You cannot borrow this book");
//}
#endregion

#region Question 10
//Q10. Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
//"Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

string title = "Refactoring";

switch (title)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heard of it");
        break;
}
#endregion
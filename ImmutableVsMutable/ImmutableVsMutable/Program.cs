using System.Collections.Immutable;
using ImmutableVsMutable;
using ImmutableVsMutable.Mutable;

// ImmutableVsMutable.Book immutable = new(Title.Create("Design Patterns")!);
// string immut_line = new('-', immutable.Title.Value.Length);
// ThisIsSoSmart(immutable);
// Console.WriteLine($"{immutable.Title.Value}{Environment.NewLine}{immut_line}");
// Console.WriteLine();
// ImmutableVsMutable.Book next = immutable with {Title = Title.Create("Refactoring")!};


List<string> keywords = ["design"];
keywords.ToImmutableList();
ImmutableVsMutable.Book book = new ImmutableVsMutable.Book(Title.Create("DP")!, []).AddKeyword("patterns");
keywords.Add("pa");






ImmutableVsMutable.Mutable.Book mutable = new("Design Patterns", []);
string mut_line = new('-', mutable.Title.Length);
ThisIsTooSoSmartToBeGood(mutable);
Console.WriteLine($"{mutable.Title}{Environment.NewLine}{mut_line}");
// Book immutable = new(dp);

// Book next = immutable with { Title = Title.Create("Refactoring")! };


void ThisIsSoSmart(ImmutableVsMutable.Book immutable)
{
    ImmutableVsMutable.Book other = immutable with {Title = Title.Create("Refactoring")!};
}

void ThisIsTooSoSmartToBeGood(ImmutableVsMutable.Mutable.Book mutable)
{
    mutable.Title = "Refactoring";
}
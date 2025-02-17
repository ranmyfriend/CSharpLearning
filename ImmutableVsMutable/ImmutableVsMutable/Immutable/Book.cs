using System;
using System.Collections.Immutable;

namespace ImmutableVsMutable;

// public record Book(Title Title);
//Title is Primitive Obsession!
// {
//Here the init is called primary constructor!
// public string Title { get; } =
// string.IsNullOrWhiteSpace(Title) ? 
// throw new ArgumentException(nameof(Title)) : Title.Trim();

// public string[] Keywords {get;} = Keywords.Concat(Title.Split(' ')).ToArray();
// }

public record Title(string Value)
{
    // public string Value { get; } =

    //   string.IsNullOrWhiteSpace(Value) ?
    // throw new ArgumentException(nameof(Value)) : Value.Trim();

    public static Title? Create(string value) => string.IsNullOrWhiteSpace(value) ? null : new(value.Trim());
}

public record Book(Title Title, ImmutableList<string> Keywords)
{
    public Book AddKeyword(string keyword) => 
        this with { Keywords = Keywords.Add(keyword) };
}

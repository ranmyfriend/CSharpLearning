using System;

namespace ImmutableVsMutable.Mutable;

public class Book(string title, string[] keywords)
{
    private string _title = ValidTitle(title);
    private List<string> _externalKeywords = keywords.ToList();
    private string[] _titleKeywords = title.Split(' ');
    // private string[] _keywords = keywords.Concat(title.Split(' ')).ToArray();


    public string Title
    {
        get => _title;
        set 
        {
            _title = ValidTitle(value);
            _titleKeywords = ExtractKeywords(value);
        }
    }

    public bool AnyKeywordSatisfies(Func<string, bool> predicate) =>
    _externalKeywords.Concat(_titleKeywords).Any(predicate);

    private static string[] ExtractKeywords(string title) => ValidTitle(title).Split(' ');
    public void AddKeyword(string keyword) => _externalKeywords.Add(keyword);

    private static string ValidTitle(string title) =>
        string.IsNullOrWhiteSpace(title) ? throw new ArgumentNullException(nameof(title)) : title.Trim();

}

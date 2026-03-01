using Cadmus.Refs.Bricks;
using System.Collections.Generic;
using System.Text;

namespace Cadmus.Ndp.Parts;

/// <summary>
/// A single passage of a text.
/// </summary>
public class TextPassage
{
    /// <summary>
    /// The text passage location, like If.1,23.
    /// </summary>
    public DocReference Location { get; set; } = new();

    /// <summary>
    /// A generic tag for the passage. Usually derived from thesaurus
    /// <c>text-passage-tags</c>.
    /// </summary>
    public string? Tag { get; set; }

    /// <summary>
    /// The optional features of the passage, like "poetic", "prose", "epic",
    /// etc. They are usually derived from thesaurus <c>text-passage-features</c>.
    /// </summary>
    public List<string>? Features { get; set; }

    /// <summary>
    /// The passage's text. It may be null if the passage is not transcribed.
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// A generic free text note about the passage.
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Returns a string representation of the current object, including the
    /// citation and optional text.
    /// </summary>
    /// <returns>String.</returns>
    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append(Location);
        if (!string.IsNullOrEmpty(Text)) sb.Append(": " + Text);
        return sb.ToString();
    }
}

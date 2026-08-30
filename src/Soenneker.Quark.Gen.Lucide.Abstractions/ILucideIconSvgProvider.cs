namespace Soenneker.Quark.Gen.Lucide.Abstractions;

/// <summary>
/// Provides SVG markup for Lucide icons by their PascalCase member names.
/// </summary>
public interface ILucideIconSvgProvider
{
    /// <summary>
    /// Gets the SVG markup for a Lucide icon.
    /// </summary>
    /// <param name="iconName">The PascalCase icon member name, such as <c>Check</c>.</param>
    /// <returns>The SVG markup, or <see langword="null"/> when the icon is unavailable.</returns>
    string? GetSvg(string iconName);
}

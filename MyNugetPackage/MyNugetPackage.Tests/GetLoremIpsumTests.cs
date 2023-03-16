using NUnit.Framework;

namespace MyNugetPackage.Tests;

public class GetLoremIpsumTests
{
    [Test]
    public void ShouldGetText()
    {
        var content = GetLoremIpsum.Get();

        Assert.NotNull(content);
        Assert.IsNotEmpty(content);
    }

    [Test]
    public void ShouldGetImage()
    {
        var content = GetLoremIpsum.GetImage();

        Assert.NotNull(content);
        Assert.IsNotEmpty(content);
    }
}
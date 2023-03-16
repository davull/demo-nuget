using NUnit.Framework;

namespace ConsumingApplication.Tests;

public class ConsumingClassTests
{
    [Test]
    public void Test()
    {
        var text = ConsumingClass.GetContentFromPackage();
        var image = ConsumingClass.GetImageFromPackage();

        Assert.NotNull(text);
        Assert.IsNotEmpty(text);

        Assert.NotNull(image);
        Assert.IsNotEmpty(image);
    }
}
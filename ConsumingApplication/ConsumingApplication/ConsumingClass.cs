namespace ConsumingApplication;

public static class ConsumingClass
{
    public static string GetContentFromPackage() => MyNugetPackage.GetLoremIpsum.Get();

    public static byte[] GetImageFromPackage() => MyNugetPackage.GetLoremIpsum.GetImage();
}
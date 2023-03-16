namespace MyNugetPackage;

public static class GetLoremIpsum
{
    public static string Get()
    {
        var path = Path.Combine(
            Path.GetDirectoryName(typeof(GetLoremIpsum).Assembly.Location)!,
            "Assets", "Documents", "loremipsum.de.txt");

        var content = File.ReadAllText(path);
        return content;
    }

    public static byte[] GetImage()
    {
        var path = Path.Combine(
            Path.GetDirectoryName(typeof(GetLoremIpsum).Assembly.Location)!,
            "Assets", "Images", "dotnet.png");

        var content = File.ReadAllBytes(path);
        return content;
    }
}
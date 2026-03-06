namespace GERM.Common
{
    internal class HtmlHelper
    {
    }
}

// https://downloads.godotengine.org/?version=4.7&flavor=dev2&slug=android_editor.apk&platform=android.apk
/*
slug=android_editor.apk&platform=android.apk
slug=linux.x86_64.zip&platform=linux.64
slug=mono_linux_x86_64.zip&platform=linux.64
slug=macos.universal.zip&platform=macos.universal
slug=mono_macos.universal.zip&platform=macos.universal
slug=win64.exe.zip&platform=windows.64
slug=mono_win64.zip&platform=windows.64
slug=web_editor.zip&platform=web
slug=export_templates.tpz&platform=templates
slug=mono_export_templates.tpz&platform=templates
*/


//public List<string> Slugs = new List<string>()
//{
//    "android_editor.apk",
//    "linux.x86_64",
//    "mono_linux_x86_64",
//    "macos.universal.zip",
//    "mono_macos.universal.zip",
//    "win64.exe.zip",
//    "mono_win64.zip",
//    "web_editor.zip",
//    "export_templates.tpz",
//    "mono_export_templates.tpz"
//};

//public class Platforms
//{
//    public static string Android = "android.apk";
//    public static string Linux = "linux.64";
//    public static string macOS = "macos.universal";
//    public static string Windows = "windows.64";
//    public static string WebEditor = "web";
//    public static string ExportTemplates = "templates";

//};

//async Task Main()
//{
//    var url = "https://godotengine.org/download/archive/";
//    var handler = new HttpClientHandler { AllowAutoRedirect = true };
//    using var http = new HttpClient(handler);
//    http.DefaultRequestHeaders.UserAgent.ParseAdd("ReleaseScraper/1.0 (+https://example.com)");

//    try
//    {
//        var html = await http.GetStringAsync(url);

//        var doc = new HtmlDocument();
//        doc.LoadHtml(html);

//        // Collect text and hrefs from links (most likely where versions appear)
//        var nodes = doc.DocumentNode.SelectNodes("//a") ?? new HtmlNodeCollection(null);

//        var versionPattern = new Regex(@"\b\d+\.\d+(?:\.\d+){0,2}(?:-(?:alpha|beta|rc|stable|dev|preview)[\.\-]?\d*)?\b",
//            RegexOptions.IgnoreCase | RegexOptions.Compiled);

//        var versions = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

//        foreach (var a in nodes)
//        {
//            var text = a.InnerText ?? string.Empty;
//            //foreach (Match m in versionPattern.Matches(text))
//            //versions.Add(Normalize(m.Value));

//            var href = a.GetAttributeValue("href", "");
//            foreach (Match m in versionPattern.Matches(href))
//                versions.Add(Normalize(m.Value));
//        }

//        var sorted = new List<string>(versions);
//        sorted.Sort(SemverishCompare);

//        Console.WriteLine("Found versions:");
//        foreach (var v in sorted)
//            Console.WriteLine(v);
//    }
//    catch (Exception ex)
//    {
//        Console.Error.WriteLine(ex);
//    }
//}

//static string Normalize(string v) => v.Trim().ToLowerInvariant();

//static int SemverishCompare(string a, string b)
//{
//    (string numsA, string preA) = SplitPreRelease(a);
//    (string numsB, string preB) = SplitPreRelease(b);

//    var pa = numsA.Split('.');
//    var pb = numsB.Split('.');

//    int max = Math.Max(pa.Length, pb.Length);
//    for (int i = 0; i < max; i++)
//    {
//        int ai = i < pa.Length && int.TryParse(pa[i], out var av) ? av : 0;
//        int bi = i < pb.Length && int.TryParse(pb[i], out var bv) ? bv : 0;
//        if (ai != bi) return ai.CompareTo(bi);
//    }

//    if (string.IsNullOrEmpty(preA) && string.IsNullOrEmpty(preB)) return 0;
//    if (string.IsNullOrEmpty(preA)) return 1;
//    if (string.IsNullOrEmpty(preB)) return -1;
//    return string.Compare(preA, preB, StringComparison.OrdinalIgnoreCase);
//}

//static (string core, string pre) SplitPreRelease(string v)
//{
//    var idx = v.IndexOf('-');
//    if (idx < 0) return (v, "");
//    return (v.Substring(0, idx), v.Substring(idx + 1));
//}


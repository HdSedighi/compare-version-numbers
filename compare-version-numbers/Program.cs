using System;

public class VersionComparison
{
    public int CompareVersion(string version1, string version2)
    {
        // Split both version strings by '.'
        var v1 = version1.Split('.');
        var v2 = version2.Split('.');
        
        // Determine the maximum length between the two arrays
        int length = Math.Max(v1.Length, v2.Length);
        
        // Compare each revision of the versions
        for (int i = 0; i < length; i++)
        {
            // Parse revision numbers or treat missing revisions as 0
            int revision1 = (i < v1.Length) ? int.Parse(v1[i]) : 0;
            int revision2 = (i < v2.Length) ? int.Parse(v2[i]) : 0;
            
            // Compare the revisions
            if (revision1 < revision2)
            {
                return -1;
            }
            else if (revision1 > revision2)
            {
                return 1;
            }
        }
        
        // If all revisions are equal, return 0
        return 0;
    }

    public static void Main(string[] args)
    {
        VersionComparison versionComparison = new VersionComparison();
        
        // Test examples
        Console.WriteLine(versionComparison.CompareVersion("1.01", "1.001")); // Output: 0
        Console.WriteLine(versionComparison.CompareVersion("1.0", "1.0.0")); // Output: 0
        Console.WriteLine(versionComparison.CompareVersion("0.1", "1.1")); // Output: -1
    }
}

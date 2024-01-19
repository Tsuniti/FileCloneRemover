namespace FileCloneRemover;

public class RecursiveFunction
{
    public HashSet<string> uniqueDirectories = new HashSet<string>();
    public void CheckDirectories(string path)
    {
        DeleteFiles(path);
        List<string> directories = Directory.GetDirectories(path).ToList();
        if (directories.Count != 0)
        {
            foreach (string directory in Directory.GetDirectories(path))
            {
                if (uniqueDirectories.Add(directory))
                {
                    CheckDirectories(directory);
                }
            }
        }
    }
    public void DeleteFiles(string path)
    {
        string[] files = Directory.GetFiles(path);

        HashSet<string> uniqueContent = new HashSet<string>();

        foreach (string file in files)
        {

            string fileContent = File.ReadAllText(file);

            if (!uniqueContent.Add(fileContent))
            {
                File.Delete(file);
            }
        }

    }

}
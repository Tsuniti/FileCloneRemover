using System.Diagnostics;

string path = @"C:\Users\Tsuni\Desktop\13.01.2024";

//string firstContent = File.ReadAllText(path + @"\one.txt");
//string secondContent = File.ReadAllText(path + @"\two.txt");

//Console.WriteLine(firstContent);
//Console.WriteLine(secondContent);

Stopwatch stopwatch = new Stopwatch();

Console.WriteLine("Start");
stopwatch.Start();

string[] files = Directory.GetFiles(path);

//for (int i = 0; i < files.Count; i++)
//{
//    string leftFile = File.ReadAllText(files[i]);

//    for (int j = i + 1; j < files.Count; j++)
//    {
//        string rightFile = File.ReadAllText(files[j]);

//        if(leftFile == rightFile)
//        {
//            File.Delete(files[j]);
//            files.RemoveAt(j);
//            j--;
//        }
//    }
//}

HashSet<string> uniqueContent = new HashSet<string>();

foreach (string file in files)
{

    string fileContent = File.ReadAllText(file);

    if (!uniqueContent.Add(fileContent))
    {
        File.Delete(file);
    }
}
stopwatch.Stop();
Console.WriteLine("Finish");
Console.WriteLine(stopwatch.ElapsedMilliseconds);
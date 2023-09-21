File.WriteAllText("filename.txt", "a");
string readText = File.ReadAllText("filename.txt");
Console.WriteLine(readText);
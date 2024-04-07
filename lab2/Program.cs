
const string path = @"D:\text1.txt";
StreamReader reader = new StreamReader(path);
string? line = reader.ReadLine();

StreamWriter writer = new StreamWriter(@"D:\text2.txt");

while (line != null)
{
    int total = 0;
    string[] linesplit = line.Split(' ');
    for (int i = 0; i < linesplit.Length; i++)
    {
        total = total + Convert.ToInt32(linesplit[i]); 
    }
    writer.WriteLine(line + "=" + total);

    line = reader.ReadLine();   
    
}

reader.Close();
writer.Close();







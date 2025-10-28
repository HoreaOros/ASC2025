StreamReader sr = new StreamReader("input.txt");
string line; 
List<int> list1 = new List<int>();
List<int> list2 = new List<int>();
while((line = sr.ReadLine()) != null)
{
    string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    list1.Add(int.Parse(tokens[0]));
    list2.Add(int.Parse(tokens[1]));
}

list1.Sort();
list2.Sort();

int suma = 0;

for (int i = 0; i < list1.Count; i++)
    suma += Math.Abs(list1[i] - list2[i]);

Console.WriteLine(suma);


// LINQ
int similarityScore = 0;
foreach (int nr in list1)
{
    similarityScore += nr * list2.Count<int>(x => x == nr);
}

Console.WriteLine(similarityScore);
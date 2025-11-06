#region Input parsing
string text = File.ReadAllText("input.txt");
string[] lines = text.Split(Environment.NewLine);
List<List<int>> records = new List<List<int>>();
foreach (string line in lines)
{
    string[] t = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var lst = new List<int>();
    foreach (var item in t)
    {
        lst.Add(int.Parse(item));
    }
    records.Add(lst);
}
Console.WriteLine();
#endregion

#region Part1
Part1(records);
void Part1(List<List<int>> records)
{
    int safeRecords = 0;
    
    foreach (var item in records)
        if (IsRecordSafe(item))
            safeRecords++;
    Console.WriteLine(safeRecords);

    //Console.WriteLine(records.Count<List<int>>(item => IsRecordSafe(item)));
}

bool IsRecordSafe(List<int> lst)
{
    return (IsIncreasing(lst) || IsDecreasing(lst)) && IsOK(lst);
}

bool IsOK(List<int> lst)
{
    for (int i = 0; i < lst.Count - 1; i++)
        if (Math.Abs(lst[i] - lst[i + 1]) < 1 || Math.Abs(lst[i] - lst[i + 1]) > 3)
            return false;
    return true;
}

bool IsDecreasing(List<int> lst)
{
    for (int i = 0; i < lst.Count - 1; i++)
        if (lst[i] <= lst[i + 1])
            return false;
    return true;
}

bool IsIncreasing(List<int> lst)
{
    for (int i = 0; i < lst.Count - 1; i++)
        if (lst[i] >= lst[i + 1])
            return false;
    return true;
}


#endregion

#region Part2
int safeRecords2 = 0;
foreach (var item in records)
{
    if (IsRecordSafe(item))
        safeRecords2++;
    else
    {
        for (int i = 0; i < item.Count; i++)
        {
            List<int> r = new();
            for (int j = 0; j < item.Count; j++)
                if (i != j)
                    r.Add(item[j]);
            if (IsRecordSafe(r))
            {
                safeRecords2++;
                break;
            }
        }
    }
}

Console.WriteLine(safeRecords2);
#endregion
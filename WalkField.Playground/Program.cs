using Newtonsoft.Json;
using WalkField.Core.Interfaces;
using WalkField.Core.Models;

Game game1 = new Game(Tag.Red);


string field1 = JsonConvert.SerializeObject(game1.Field);
Console.WriteLine(field1);
Tag[][] a = JsonConvert.DeserializeObject<Tag[][]>(field1)!;
for (int i = 0; i < a.Length; i++)
{
    for(int j = 0; j < a[i].Length; j++)
        Console.Write($"{((int)a[i][j])}");
    Console.WriteLine();
}
game1.Field = a;

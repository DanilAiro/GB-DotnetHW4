int[,,] lab = new int[5, 5, 5]
  {
    {
      {0, 0, 1, 1, 1},
      {1, 0, 1, 1, 1},
      {1, 1, 1, 1, 1},
      {1, 1, 0, 1, 1},
      {1, 1, 1, 1, 1}
    },
    {
      {1, 1, 1, 0, 1},
      {1, 0, 0, 0, 0},
      {1, 0, 1, 1, 1},
      {0, 0, 0, 0, 1},
      {1, 1, 0, 1, 1}
    },
    {
      {1, 1, 1, 0, 1},
      {1, 0, 0, 0, 0},
      {1, 0, 1, 1, 1},
      {0, 0, 0, 0, 1},
      {1, 1, 0, 1, 1}
    },
    {
      {1, 1, 1, 0, 1},
      {1, 0, 0, 0, 0},
      {1, 0, 1, 1, 1},
      {0, 0, 0, 0, 1},
      {1, 1, 0, 1, 1}
    },
    {
      {1, 1, 1, 1, 1},
      {1, 1, 0, 1, 1},
      {1, 1, 1, 1, 1},
      {1, 1, 0, 1, 1},
      {1, 1, 1, 1, 1}
    }
  };

Console.WriteLine(Find(1, 2, 1, lab));

PrintArray(lab);

int Find(int x, int y, int z, int[,,] arr)
{
  if (!isEmpty(x, y, z, arr))
    return 0;

  arr[x, y, z] = 2;

  int count = 0;
  
  if (x == 0 || x == arr.GetLength(0) - 1 || y == 0 || y == arr.GetLength(1) - 1 || z == 0 || z == arr.GetLength(2) - 1)
  {
    arr[x, y, z] = 3;
    count += 1;
  }

  count += Find(x + 1, y, z, arr);
  count += Find(x, y + 1, z, arr);
  count += Find(x, y, z + 1, arr);
  count += Find(x - 1, y, z, arr);
  count += Find(x, y - 1, z, arr);
  count += Find(x, y, z - 1, arr);


  return count;
}

bool isEmpty(int x, int y, int z, int[,,] arr)
{
  if (x < 0 || x >= arr.GetLength(0) || y < 0 || y >= arr.GetLength(1) || z < 0 || z >= arr.GetLength(2))
    return false;
  if (arr[x, y, z] != 0)
    return false;
  return true;
}

void PrintArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]} ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
  Console.ReadLine();
}


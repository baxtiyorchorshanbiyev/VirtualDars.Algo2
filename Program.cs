const int NUMBER_OF_ELEMENTS = 4;
int[] arr = { 10, 1, 2, 5, 4 };
// MinMaxSum(arr);
MinSum(arr);
MaxSum(arr);

// static void MinMaxSum(int[] arr)
// {
//   int temp;
//   for (int i = 0; i < arr.Length; i++)
//   {
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//       if (arr[i] > arr[j])
//       {
//         temp = arr[i];
//         arr[i] = arr[j];
//         arr[j] = temp;
//       }
//     }
//   }

//   int minSum = 0;
//   for (int i = 0; i < NUMBER_OF_ELEMENTS; i++)
//   {
//     minSum += arr[i];
//   }
//   int maxSum = 0;

//   for (int k = arr.Length - 1; k >= (arr.Length - NUMBER_OF_ELEMENTS); k--)
//   {
//     maxSum += arr[k];

//   }
//   Console.WriteLine($"Eng kichik {NUMBER_OF_ELEMENTS} son yi'gindisi: {minSum}");
//   Console.WriteLine($"Eng katta {NUMBER_OF_ELEMENTS} son yig'indisi: {maxSum}");
// }

static void MinSum(int[] arr)
{
  int[] minArr = new int[NUMBER_OF_ELEMENTS];

  if (arr.Length < NUMBER_OF_ELEMENTS)
  {
    Console.WriteLine("Arrayda elementlar soni yetarli emas.");
    return;
  }

  for (int i = 0; i < NUMBER_OF_ELEMENTS; i++)
  {
    int min = arr.Min();
    minArr[i] = min;
    arr = arr.Where(val => val != min).ToArray();
  }
  double minSum = CalculateSum(minArr);
  Console.WriteLine($"Eng kichik {NUMBER_OF_ELEMENTS} son yi'gindisi: {minSum}");
}

static void MaxSum(int[] arr)
{
  int[] maxArr = new int[NUMBER_OF_ELEMENTS];

  if (arr.Length < NUMBER_OF_ELEMENTS)
  {
    Console.WriteLine("Arrayda elementlar soni yetarli emas.");
    return;
  }

  for (int i = 0; i < NUMBER_OF_ELEMENTS; i++)
  {
    int max = arr.Max();
    maxArr[i] = max;
    arr = arr.Where(val => val != max).ToArray();
  }
  double maxSum = CalculateSum(maxArr);
  Console.WriteLine($"Eng katta {NUMBER_OF_ELEMENTS} son yi'gindisi: {maxSum}");
}

static double CalculateSum(int[] arr)
{
  int sum = 0;
  foreach (int num in arr)
  {
    sum += num;
  }
  return sum;
}




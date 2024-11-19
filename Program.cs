const int NUMBER_OF_ELEMENTS = 4;
int[] arr = { 10, 1, 2, 3, 6, 4, 8 };
minMaxSum(arr);

static void minMaxSum(int[] arr)
{
  int temp;
  for (int i = 0; i < arr.Length; i++)
  {
    for (int j = i + 1; j < arr.Length; j++)
    {
      if (arr[i] > arr[j])
      {
        temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
      }
    }
  }

  int minSum = 0;
  for (int i = 0; i < NUMBER_OF_ELEMENTS; i++)
  {
    minSum += arr[i];
  }
  int maxSum = 0;

  for (int k = arr.Length - 1; k >= (arr.Length - NUMBER_OF_ELEMENTS); k--)
  {
    maxSum += arr[k];

  }
  Console.WriteLine($"Eng kichik {NUMBER_OF_ELEMENTS} son yi'gindisi: {minSum}");
  Console.WriteLine($"Eng katta {NUMBER_OF_ELEMENTS} son yig'indisi: {maxSum}");

}




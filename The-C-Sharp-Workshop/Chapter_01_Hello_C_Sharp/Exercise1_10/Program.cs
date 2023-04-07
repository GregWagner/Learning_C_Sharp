static int[] BubbleSort(int[] array) {

    // iterate over the array
    for (int j = 0; j < array.Length - 1; ++j) {
        for (int i = 0; i < array.Length - 1; ++i) {
            if (array[i] <= array[i + 1]) {
                continue;
            }
            (array[i + 1], array[i]) = (array[i], array[i + 1]);
        }
    }
    return array;
}

int[] randomNumbers = {123, 22, 53, 91, 787, 0, -23, 5};
int[] sortedArray = BubbleSort(randomNumbers);

foreach (int item in sortedArray) {
    Console.Write($"{item} ");
}
Console.WriteLine();

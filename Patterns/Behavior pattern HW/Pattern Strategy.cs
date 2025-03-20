
//interface ISort
//{
//    void Sort(int[] array);
//    void Show();
//}

//class Sort
//{
//    private ISort isort;

//    public Sort(ISort isort)
//    {
//        this.isort = isort;
//    }

//    public void SetStrategy(ISort isort)
//    {
//        this.isort = isort;
//    }

//    public void ExecuteSort(int[] array)
//    {
//        isort.Show();
//        isort.Sort(array);
//    }
//}

//class BubbleSort : ISort
//{
//    public void Sort(int[] array)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (array[j] > array[j + 1])
//                {
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }

//    public void Show()
//    {
//        Console.WriteLine("bubble sort is selected");
//    }
//}

//class InsertionSort : ISort
//{
//    public void Sort(int[] array)
//    {
//        for (int i = 1; i < array.Length; i++)
//        {
//            int key = array[i];
//            int j = i - 1;

//            while (j >= 0 && array[j] > key)
//            {
//                array[j + 1] = array[j];
//                j--;
//            }
//            array[j + 1] = key;
//        }
//    }

//    public void Show()
//    {
//        Console.WriteLine("insertion sort is selected");
//    }
//}


//class Program
//{
//    static void Main()
//    {
//        int[] array = { 72, 10, 66, 44, 272, 200, 109 };

//        Sort sort = new Sort(new BubbleSort());
//        sort.ExecuteSort(array);
//        Console.WriteLine("Sorted array: " + string.Join(", ", array));

//        sort.SetStrategy(new InsertionSort());
//        sort.ExecuteSort(array);
//        Console.WriteLine("Sorted array: " + string.Join(", ", array));
//    }
//}

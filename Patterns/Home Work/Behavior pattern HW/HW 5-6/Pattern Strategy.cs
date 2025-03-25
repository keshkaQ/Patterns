//class Program
//{
//    static void Main()
//    {
//        // Исходный массив для сортировки
//        int[] array = { 72, 10, 66, 44, 272, 200, 109 };
//        int[] array2 = { 12, 10, 16, 14, 112, 100, 9 };


//        // Создаем объект сортировки с стратегией BubbleSort
//        Sort sort = new Sort(new BubbleSort());
//        sort.ExecuteSort(array);
//        Console.WriteLine("Sorted array: " + string.Join(", ", array));

//        // Меняем стратегию на InsertionSort
//        sort.SetStrategy(new InsertionSort());
//        sort.ExecuteSort(array2);
//        Console.WriteLine("Sorted array: " + string.Join(", ", array2));
//    }
//}

//// Интерфейс для всех стратегий сортировки
//interface ISort
//{
//    void Sort(int[] array);  // Метод для выполнения сортировки
//    void Show();             // Метод для отображения информации о стратегии
//}

//// Класс-контекст, использующий стратегию сортировки
//class Sort
//{
//    private ISort isort;  // Текущая стратегия сортировки

//    // Конструктор, принимающий начальную стратегию сортировки
//    public Sort(ISort isort)
//    {
//        this.isort = isort;
//    }

//    // Метод для изменения стратегии сортировки во время выполнения
//    public void SetStrategy(ISort isort)
//    {
//        this.isort = isort;
//    }

//    // Метод для выполнения сортировки с текущей стратегией
//    public void ExecuteSort(int[] array)
//    {
//        isort.Show();    // Показываем информацию о стратегии
//        isort.Sort(array); // Выполняем сортировку
//    }
//}

//// Реализация стратегии пузырьковой сортировки
//class BubbleSort : ISort
//{
//    // Метод сортировки пузырьком
//    public void Sort(int[] array)
//    {
//        for (int i = 0; i < array.Length - 1; i++)
//        {
//            for (int j = 0; j < array.Length - i - 1; j++)
//            {
//                if (array[j] > array[j + 1])
//                {
//                    // Обмен элементов местами
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }

//    // Метод для отображения информации о стратегии
//    public void Show()
//    {
//        Console.WriteLine("Bubble sort is selected");
//    }
//}

//// Реализация стратегии сортировки вставками
//class InsertionSort : ISort
//{
//    // Метод сортировки вставками
//    public void Sort(int[] array)
//    {
//        for (int i = 1; i < array.Length; i++)
//        {
//            int key = array[i];
//            int j = i - 1;

//            // Сдвигаем элементы, которые больше key
//            while (j >= 0 && array[j] > key)
//            {
//                array[j + 1] = array[j];
//                j--;
//            }
//            array[j + 1] = key;
//        }
//    }

//    // Метод для отображения информации о стратегии
//    public void Show()
//    {
//        Console.WriteLine("Insertion sort is selected");
//    }
//}
try
{
    //створюємо функію для обміну значень змінних
    void Swap(ref int element1, ref int element2)
    {
        //присвоюємо тимчасовій змінній значення першого елементу
        var temp = element1;
        //присвоюємо першому елементу значення другого елемену
        element1 = element2;
        //присвоюємо другому елементу значення тимчасової змінної
        element2 = temp;
    }

    //створюємо функцію бульбашкового сортування
    int[] BubbleSort(int[] array)
    {
        //дізнаємося довжину масиву
        var length = array.Length;
        //цикл для повторного проходження
        for (var i = 1; i < length; i++)
        {
            //цикл для порівняння сусідніх елементів масиву
            for (var j = 0; j < length - i; j++)
            {
                //порівння сусідніх елементів масиву
                if (array[j] > array[j + 1])
                {
                    //виклик функції для обміну значень
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
        //повертає відсортований масив
        return array;
    }
    //створюємо константу для розміру масиву
    const int arrSize = 30;
    //створюємо масив і берем розмір з константи
    var array = new int[arrSize];
    //створюємо клас Рандом 
    var rnd = new Random();

    //цикл для проходження всіх елементів масиву
    for (int i = 0; i < arrSize; i++)
    {
        //використовуємо клас Рандом для заповнення масиву
        array[i] = rnd.Next(1, 100);
    }
    //виводимо невідсортований масив і обʼєднуємо в стрінгу за допомогою функції string.Join
    Console.WriteLine("Array: {0} ", string.Join(", ", array));
    //виводимо відсортований масив і обʼєднуємо в стрінгу за допомогою функції string.Join
    Console.WriteLine("Sorted array: {0} ", string.Join(", ", BubbleSort(array)));

    //створюємо функцію сортування вставкою
    void InsertionSort(int[] arr)
    {
        //проходимось по масиву за допомогою циклу
        for (int i = 1; i < arr.Length; i++)
        {
            //створюємо змінну, беручи значення наступного елементу масиву
            var key = arr[i];
            //створюємо змінну для переривання циклу
            var flag = false;
            //використовуємо цикл для порівняння елементів масиву
            for (int j = i - 1; j >= 0 && flag != true;)
            {
                //порівнюємо елементи масиву, щоб знати чи переставляти їх
                if (key < arr[j])
                {
                    //обмінюємо значення елементів масиву
                    arr[j + 1] = arr[j];
                    j--;
                    arr[j + 1] = key;
                }
                //встановлюємо значення тру для переривання циклу
                else
                {
                    flag = true;
                }
            }
        }
    }

    //створюємо функцію сортування рекурсією
    void InsertionSortRecursive(int[] arr, int length)
    {
        //якщо довжина менше або рівна одиниці виконується вихід з функції
        if (length <= 1)
            return;

        //рекурсія - викликаємо функцію з довжиною -1
        InsertionSortRecursive(arr, length - 1);

        //берем елемент масиву з кінця
        var key = arr[length - 1];
        //берем попередній елемент перед ключем
        var i = length - 2;

        //використовуємо цикл для обміну елементів
        while (i >= 0 && arr[i] > key)
        {
            //присвоюємо наступному елементу значення попереднього
            arr[i + 1] = arr[i];
            i--;
        }

        //ставимо змінну ключ в правильне місце
        arr[i + 1] = key;
    }

    //створюємо функцію вибіркового сортування
    void SelectionSort(int[] arr)
    {
        //проходимось по масиву за допомогою циклу
        for (int i = 0; i < arr.Length - 1; i++)
        {
            //встановлюємо найменший індекс по замовчуванню з першого циклу
            var smallestValueIndex = i;

            //використовуємо цикл, для знаходження елементу з найменшим значенням
            for (int j = i + 1; j < arr.Length; j++)
            {
                //порівнюємо поточний елемент з найменшим знайденим
                if (arr[j] < arr[smallestValueIndex])
                {
                    //задаємо індекс нового найменшого елементу
                    smallestValueIndex = j;
                }
            }

            // swap
            //ставимо найменший знайдений елемент на місце першого елементу масиву
            var temp = arr[smallestValueIndex];
            arr[smallestValueIndex] = arr[i];
            arr[i] = temp;
        }
    }
}
catch (FormatException ex)
{
    Console.WriteLine("Incorrect data format.");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error has occurred.");
    Console.WriteLine(ex.Message);
}


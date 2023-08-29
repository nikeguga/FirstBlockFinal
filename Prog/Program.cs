/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.*/

using System.Runtime.Serialization;

string[] ArrayOfShorts(string[] array) //принимаем строчный массив и выдаём новый строчный массив коротышек
{
    int count = 1;
    for (int i = 0; i < array.Length; i++) //проходим по первому массиву
    {
        if (array[i].Length <= 3)
            count++; //собираем длинну для нашего нового массива
    }
    string[] shorts = new string[count];
    if (count > 1) //проверка на то, появились ли нужные элементы
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++) //проходим по первому массиву
        {
            if (array[i].Length <= 3) //проверка на условие
            {
                shorts[j] = array[i]; //запись элемента первого массива во второй массив
                j++;
            }
            else continue;
        }
    }

    else shorts[0] = "you've entered nothing of value, you scum! We need shoooooorties!"; //вывод, если коротких элементов не найдено
    return shorts;
}

string[] CreateArray(int length)
{
    string[] myArray = new string[length];
    int i = 0;
    while (i < length)
    {
        Console.WriteLine("input array element: "); // тут проверка просится, но не проходили пока. Я погуглил, конечно) Но не думаю, что нужно на данном этапе включать такое сюда.
        myArray[i] = Console.ReadLine();
        i++;
    }
    return myArray;
}

void ShowArr(string[] array)
{

    Console.Write("Your array is [ "); // для красоты
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


Console.WriteLine("input array length: ");
int length = Convert.ToInt32(Console.ReadLine()); // тут проверку бы, но мы пока не проходили
string[] myArray = CreateArray(length);
ShowArr(myArray);
string[] shorty = ArrayOfShorts(myArray);
Console.WriteLine(); //для красоты
ShowArr(shorty); // вы в танцах


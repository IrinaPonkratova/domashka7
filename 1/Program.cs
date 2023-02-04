//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
int InputData(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int [] CreateArray(string msg)
{
    
    int size = InputData(msg); 
    int [] mass = new int [size];
    return mass;
}
void FillArray(int [] array, string msg)
{
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i] =  InputData(msg);
    }

}
int CheckPositive (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] > 0)
        {
            count  +=1;
        }
    }
    return count;
}


int [] arr = CreateArray("сколько чисел вы хотите ввести?");
FillArray(arr, "введите число");
System.Console.WriteLine(CheckPositive(arr));

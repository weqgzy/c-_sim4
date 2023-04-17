int lenArray = ReadInt("введите длинну массива");

System.Console.Write("[ ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1 , 99);
    System.Console.Write(randomArray[i] + ", ");
}

int ReadInt(string massage)
{
    System.Console.Write(massage + ":");
    return Convert.ToInt32(Console.ReadLine());

}

System.Console.Write("]");
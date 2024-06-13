using System.ComponentModel;
using System.Data;

Console.WriteLine("Define the size of an  array between 1 and 1000: ");
string arrayLengthToConvert = Console.ReadLine(); // user enters the size of the array
int arrayLength = Convert.ToInt32(arrayLengthToConvert); // convert the entered array
int[] numbers = new int[arrayLength];
Random random = new Random();

if (arrayLength >= 1 && arrayLength <= 1000) // possible case
{
    for (int i = 0; i < arrayLength - 1; i++) // loop into array numbers
    {
        if (arrayLength == 0) // case arrayLength is 0
        {
            numbers[i] = 0;
        }
        else
        {
            int randomNumber = random.Next(-10, 10); // generates a random number (defines minimum and maximum)
            numbers[i] = randomNumber; // add the generated random number to the array numbers
            
           /* for (int j = 0; j < numbers.Length; j++)
            {
                while (numbers[i] == numbers [j])
                randomNumber = random.Next(-100, 100); // generates a random number (defines minimum and maximum)
                numbers[i] = randomNumber; // add the generated random number to the array numbers
            
            }*/
        }
    }

    int sum = 0;
    for (int i = 0; i < numbers.Length; i++) // loop into aray numbers -1 (last element)
    {
        sum += numbers[i]; // sum of all the elements of array number except the last element
    }
    numbers[arrayLength - 1] = sum * -1; // convert the sum into negative or positive
}
else
{
    Console.WriteLine("Invalid number.");
}

/* Print the array in the console */
foreach (int number in numbers)
{
    Console.Write(number + ", ");
}

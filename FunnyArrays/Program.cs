var manipulateInput = (int[] input) =>
{
    var total = 0;
    int isEvenOrOdd(int number)
    {
        return number % 2 == 0 ? total += 1 : total += 3;
    }

    int isEight(int number)
    {
        return number == 8 ? total += 5 : total;
    }
    foreach (var number in input)
    {
        isEvenOrOdd(number);
        isEight(number);
    }
    return total;
};


var input1 = new int[] { 1, 2, 3, 4, 5 }; // 11
var input2 = new int[] { 15, 25, 35 }; // 9
var input3 = new int[] { 8, 8 }; // 12

foreach (var array in new int[][] { input1, input2, input3 })
{
    Console.WriteLine(manipulateInput(array));
}

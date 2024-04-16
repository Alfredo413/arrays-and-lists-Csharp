//   .____________________________________________________________________________________________________________.
//   |                                           -=IMPORTANT=-                                                    |
//   |                     (This legit got me going in circles trying to figure-out)                              |
//   |    For some ungodly reason, what would be called an array in languages such as Python and Javascript is    |
//   |     specifically referred-to as a list in C#, whereas an array is specifically a static array. What C#     |
//   |                  calls an array cannot change in length after it has been declared.                        |
//   |____________________________________________________________________________________________________________|



// A fixed or static array is faster, but not usually necessary. Its length cannot be changed after creation.

int[] fixedArray1 = new int[2];       //creates an array of integers with a FIXED length of 2 spaces --- will start as 0
string[] fixedArray2 = new string[3]; //creates an array of strings with a FIXED length of 3 spaces ---- will start as null

fixedArray1[0] = 1;
fixedArray2[2] = "goober";

printIntArr(fixedArray1);
printStrArr(fixedArray2);

//=============================================================================================================================================


// A list is dynamic. Its length can be manipulated to your liking.

List<int> dynamList1 = [1,2,3];
dynamList1.Add(6);

var dynamList2 = new List<string> { "Type", "iclum", "to", "affirm." };
dynamList2.Add("ICLUM!!!");

var dynamList3 = new List<int>();
dynamList3.Add(1);
dynamList3.Add(5);


printIntList(dynamList1);
printStrList(dynamList2);
printIntList(dynamList3);

//=============================================================================================================================================







void printIntArr(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} \n");
    }
    Console.WriteLine("--==[end of arr]==--");
}
void printStrArr(string[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} \n");
    }
    Console.WriteLine("--==[end of arr]==--");
}


static void printIntList(List<int> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("--==[end of arr]==--");
}
static void printStrList(List<string> list)
{
    foreach (var item in list)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("--==[end of arr]==--");
}
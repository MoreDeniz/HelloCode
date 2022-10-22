int Max(int arg1, int arg2, int arg3)   //func Max
{
    int result = arg1;      //max
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

//  index        0   1   2   3   4   5   6   7  8
int[] array = { 11, 21, 33, 47, 157, 64, 27, 58, 9 }; //init massiv
//array[0]=12;    //obratitsa k massivu, zapisat znachenie
//Console.WriteLine(array[0]); //vyvesti znachenie

int result = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
);
    
Console.WriteLine(result);
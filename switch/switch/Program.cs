using System;


int DoOperation(int op, int a, int b)
{
    switch (op)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
        case 4: return a / b;
        default: return 0;
    }
    
int result1 = DoOperation(1, 2, 3); //
Console.WriteLine(result1);



int result2 = DoOperation(2, 3, 4);
Console.WriteLine(result2);


int result3 = DoOperation(3, 4, 5);
Console.WriteLine(result3);


int result4 = DoOperation(4, 2, 10);
Console.WriteLine(result4); 
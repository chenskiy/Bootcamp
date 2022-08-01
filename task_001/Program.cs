// НОД (наибольший общий делитель) (Алгоритм Евклида)
//НОК (наименьшее общее кратное)

int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{ 
    if (n > m) 
        n = n - m; 
    else 
        m = m - n; 
        
    Console.WriteLine(n); 
    Console.WriteLine(m); 
    Console.WriteLine();
}
Console.WriteLine(count/(n+m));
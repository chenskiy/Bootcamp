// Написать программу на вход получает строкуБ а на выходе удалены все символы

// и1тсчияст324иь123т2т --> итсчиястиьтт


string ClearString(string s)
{
    string result = String.Empty;

    for (int i = 0; i < s.Length; i++)
    {
        if (
            s[i] == '0'
            || s[i] == '1'
            || s[i] == '2'
            || s[i] == '3'
            || s[i] == '4'
            || s[i] == '5'
            || s[i] == '6'
            || s[i] == '7'
            || s[i] == '8'
            || s[i] == '9'
        ) { }
        else result = result+$"{s[i]}";
    }

    return result;
}

void ClearStringTest01()
{
    bool res =  "итсчиястиьтт" 
    ==  ClearString("и1тсчияст324иь123т2т");
    Console.WriteLine(res);
}

void ClearStringTest02()
{
    bool res =  "итсчиястиьтт" 
    ==  ClearString("и1тсч87ияст324иь123т2т");
    Console.WriteLine(res);
}

void ClearStringTest03()
{
    bool res =  "qwertasdfzxcv" 
    ==  ClearString("q0w12e9rt34asd7fz65xc8v");
    Console.WriteLine(res);
}

ClearStringTest01();
ClearStringTest02();
ClearStringTest03();
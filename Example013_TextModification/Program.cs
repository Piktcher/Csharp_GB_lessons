//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”

string text = "— Я думаю, — Сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);

newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText);
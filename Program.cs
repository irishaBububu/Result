// В переданом массиве находим предлоги и слова с символами меньше 4 и
// формируем новый масив
string[] ArrayShortWords(string[] subs)
{
    string[] arSub = new string[subs.Length];
    int i = 0;
    foreach (string sub in subs)
    {
        if (sub.Length < 4)
        {
            arSub[i] = sub;
            i++;
        }
    }
    Array.Resize(ref arSub, i);
    return arSub;
}

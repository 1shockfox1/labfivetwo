try
{
    Console.WriteLine("Введите предложение");
    string x = Console.ReadLine();
    string result = delete(x);
    Console.WriteLine(result);
    static string delete (string str)
    {
        return str[0] + str[^1].ToString();
    }
}
catch
{
    Console.WriteLine("ошмбочка 404....");
}
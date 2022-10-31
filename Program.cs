// можно обойтись и без массива и без коллекций
/*Console.Clear();

Console.WriteLine("Введите слово или число количество символов которого не более 3х:");
string input = Console.ReadLine();
string str1 = string.Empty;
if (input.Length<=3){
    str1=input;
}
else{
    System.Console.WriteLine("Ввод не соответсвует условию");
}
 System.Console.WriteLine(str1);
*/
string a = string.Empty;
string[] b = new string[100];
int i=0;
Console.WriteLine("Введите слово или число количество символов которого не более 3х:");
 
while ((a = Console.ReadLine()) != "end") 
    b[i++] = a; 
        
        Console.Clear();

for (int k = 0; k < i; k++)
{
   if(b[k].Length <= 3)

    Console.WriteLine(b[k]);
}
            
Console.WriteLine("Введите пятизначное число");
int a=Convert.ToInt32(Console.ReadLine());
if (a/1000%10 == a/10%10) 
{

}
else
{
   System.Console.WriteLine("Число не является палиндромом"); 
}
if (a/10000%10 == a/100000*10+a%10)
{
System.Console.WriteLine("Число является палиндромом");
}
else
{
System.Console.WriteLine("Число не является палиндромом");
}

  

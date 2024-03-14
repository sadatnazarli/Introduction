// 1) Bir integer arrayi yaradın, daha sonra istifadəçidən yaşını soruşun, əgər istifadəçinin yaşı bu arrayda varsa true əks halda false çap edin
//int[] arr = {12 , 13 , 14 , 15, 16 ,17 , 18 };
//Console.WriteLine("Yasinizi daxil edin");
//int age = Convert.ToInt32(Console.ReadLine());
//bool result = false;
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == age)
//    {
//        result = true;
//        break;
//    }
//}
//Console.WriteLine(result);

// 2) Bir a yararraydın, bu massivdə sinifdəki tələbələrin adlarını saxlasın. Sonra, istifadəçidən bir tələbə adı daxil etməsini istəyin. Əgər daxil edilən ad array-də varsa,
// "Tələbənin adını" çap edin, əks halda "Bu "Adda" Tələbə tapılmadı!" çap edin.


string[] array = { "Aysel", "Nigar", "Elvin", "Aytac", "Nurlan", "Aytac" };
Console.WriteLine("Adinizi daxil edin");
string name = Console.ReadLine();
if (array.Contains(name))
{
    Console.WriteLine(name);
}
else
{
    Console.WriteLine($" {name} adinda telebe tapilmadi");
}

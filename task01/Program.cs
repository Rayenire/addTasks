// Улитка ползёт по вертикальному шесту высотой h метров, поднимаясь за день на a метров, 
//а за ночь спускаясь на b метров. На какой день улитка доползёт до вершины шеста?
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Улитка доползёт до вершины шеста за {h / (a - b)} дней");
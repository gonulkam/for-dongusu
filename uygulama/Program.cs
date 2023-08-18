// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Security.Cryptography.X509Certificates;
// ekrana meyve listesi getiren program
List<string> meyveler = new List<string>();
meyveler.Add("elma");
meyveler.Add("armut");
meyveler.Add("muz");
meyveler.Add("kivi");
meyveler.Add("çilek");
meyveler.Add("avakado");
 for ( int i =0; i<meyveler.Count(); i++)
{
    Console.WriteLine("meyveler:" + meyveler[i]);
}

 //bir sınav notu listesi ve bu sınav notunun listesinin for döngüsü ile ekrana yazdırma
 List<int> sınavnotu =new List < int > ();
sınavnotu.Add(30);
sınavnotu.Add(80);
sınavnotu.Add(10);
sınavnotu.Add(45);
sınavnotu.Add(51);
sınavnotu.Add(13);
sınavnotu.Add(13)
for (int i = 0; i < sınavnotu.Count(); i++)
    {
    Console.WriteLine("sınavnotu:" +sınavnotu[i]);
}





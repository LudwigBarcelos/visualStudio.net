using System.Collections.Generic;
/*var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var pares = new List<int>();
foreach (var valor in valores){
    if (valor % 2 == 0) {
        pares.Add(valor);   
    }
}
foreach (int i in pares) {
    Console.Write(" " + i);
}
*/
//-------------------------
/*
var valores = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var pares = valores.Where(x => x % 2 == 0).ToList();
foreach (int i in pares) {
    Console.Write(" " + i);
}
//-------------------------
Console.WriteLine(" ");
IEnumerable<int> numerosPares = from numero in valores where numero % 2 == 0 select numero;
foreach (int i in numerosPares){
    Console.Write(" " + i);
}
*/
//--------------
/*
string[] nombres = { "Maria", "Alberto", "Juan", "Pedro", "Manuel", "Jorge", "Ricardo", "David" };
IEnumerable<string> query = from s in nombres where s.Length == 5 orderby s
                                select s.ToUpper();
foreach (string item in query) {
    Console.WriteLine(item);
}
//-------------
string[] nombres2 = { "Maria", "Alberto", "Juan", "Pedro", "Manuel", "Jorge", "Ricardo", "David" };
IEnumerable<string> query2 = nombres2.Where(s=>s.Length == 5).OrderBy (s=>s).Select (s=>s.ToUpper());
foreach (string item2 in query2)
{
    Console.WriteLine(item2);
}
*/
//-----------------------



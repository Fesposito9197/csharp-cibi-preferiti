string[] myFavoriteFood = {"pasta al pesto","pasta al sugo","patatine fritte","hamburger","pizza"};
//Stampo la lunghezza del array
Console.WriteLine(myFavoriteFood.Length);

for (int i = 0; i < myFavoriteFood.Length; i++)
{
    //stampo per intero la lista del array 
    Console.WriteLine(i+1 + "" + myFavoriteFood[i]);
}

//stampo il prima in classifica 
Console.WriteLine("La prima classificata e' " + myFavoriteFood[0]);
//stampo l'ultima in classifica
Console.WriteLine("L'ultima classificata e' " + myFavoriteFood[myFavoriteFood.Length - 1]);
//stampo la meta classifica 

if (myFavoriteFood.Length % 2 == 0)
{
    Console.WriteLine("A meta classifica ci sono " + myFavoriteFood[myFavoriteFood.Length / 2 - 1] + "e" + myFavoriteFood[myFavoriteFood.Length/2]);
    
}
else
{
    Console.WriteLine("a meta classifica c'e " + myFavoriteFood[myFavoriteFood.Length / 2]);
}


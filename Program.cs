// Andrea Burr
//10-20-2022
// restraunt picker - Github
// 3 kinds - 10 for each kind + random
// amercian- MCD, KFC, DQ, carlsJr, jacknthebox, dennys, inNout, applebees, red robin, chillis
// Chinese- golden star, suns garden, china express, louies chinese, china village, sherman chinese
// Spanish - La Cocina, La Mesa, Tio Peps, La Plaita, Fondita Elisa, El Azadero Mich, Tierra Caliente, Los Agaves market, La Loca, Taqueria La Fortuna
Console.Clear();
bool playagain = true;

while (playagain){

Console.WriteLine("Its food time, what kind of dinner do you want Amercian, Chinese, or Spanish food?");
//Console.ReadLine();
string foodPick = Console.ReadLine();
string[] amercianFood = { "McDonalds", "KFC", "Dairy Queen", "Carls Jr", "Jack in the Box", "Dennys", "In n Out", "applebees", "red robin", "chillis" };
string[] chineseFood = { "golden star", "suns garden", "china express", "louies chinese", "china village", "sherman chinese", "New Fu Lim", "Hong Kong Restraunt", "panda express", "China express 4 less" };
string[] spanishFood = { "La Cocina", "La Mesa", "Tio Peps", "La Plaita", "Fondita Elisa", "El Azadero Mich", "Tierra Caliente", "Los Agaves market", "La Loca", "Taqueria La Fortuna" };

if (foodPick == "Amercian")
{
    Random r = new Random();
    int randomNumber = r.Next(0, 10);
    Console.WriteLine(amercianFood[randomNumber]);
}else 
if (foodPick == "Chinese"){
    Random r = new Random();
     int randomNumber = r.Next(0, 10);
     Console.WriteLine(chineseFood[randomNumber]);
}else
if (foodPick == "Spanish"){
     Random r = new Random();
     int randomNumber = r.Next(0, 10);
     Console.WriteLine(spanishFood[randomNumber]);
}else 
Console.WriteLine("did you enter a valid choice?");
Console.WriteLine("if you are done playing type no or press any key to continue");
string contPlay = Console.ReadLine();

  if (contPlay == "no"){

 playagain = false; 
  }else{
    playagain = true;
  }
}





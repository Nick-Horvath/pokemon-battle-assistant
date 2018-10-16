using System;

class stats //holds all the stats of a pokemon together
{
int hp;
int attack;
int defense;
int specialAttack;
int specialDefense;
int speed;
}

class attacks  //holds all the attacks of a pokemon together
{
  string atk1;
  string atk2;
  string atk3;
  string atk4;

  public attacks() //defaut constructor
  {
    atk1 = "";
    atk2 = "";
    atk3 = "";
    atk4 = "";
  }
}

class poke //object to represent a pokemon
{
  string name;
  string ability;
  string type;

  public poke() //default constructor
  {
    name = "null";
    ability = "null";
    type = "null";
    stats nums = new stats();
    attacks atks = new attacks();
  }

  public poke(string readIn) //single arg constructor
  {
    name = readIn;
    ability = "";
    type = "";
    stats nums = new stats();
    attacks atks = new attacks();
  }

  public void dispMon()
  {
    Console.Write(name + " ");
  }
}

namespace pba
{
  class program
  {
    static void Main()
    {

      poke p1Poke1 = new poke(); //i need pointers
      poke p1Poke2 = new poke();
      poke p1Poke3 = new poke();
      poke p1Poke4 = new poke();
      poke p1Poke5 = new poke();
      poke p1Poke6 = new poke();

      poke p2Poke1 = new poke();
      poke p2Poke2 = new poke();
      poke p2Poke3 = new poke();
      poke p2Poke4 = new poke();
      poke p2Poke5 = new poke();
      poke p2Poke6 = new poke();

      Console.Write("Welcome to the Pokemon Battle Simulator! Please being entering your pokemon." + Environment.NewLine);

      for(int i = 0; i < 6; i++) // a loop to add all the pokemon of a team to the data and switch the read i/o to the appropriate number
      {
        Console.Write("Pokemon " + i + ": ");
        switch(i)
        {
          case 0:
            p1Poke1 = new poke(Console.ReadLine());
            break;
          case 1:
            p1Poke2 = new poke(Console.ReadLine());
            break;
          case 2:
            p1Poke3 = new poke(Console.ReadLine());
            break;
          case 3:
            p1Poke4 = new poke(Console.ReadLine());
            break;
          case 4:
            p1Poke5 = new poke(Console.ReadLine());
            break;
          case 5:
            p1Poke6 = new poke(Console.ReadLine());
            break;
        }
      }

      Console.Write("Now enter the pokemon on your opponent's team: " + Environment.NewLine);

      for(int k = 0; k < 6; k++)
      {
        Console.Write("Pokemon " + k + ": ");
        switch(k)
        {
          case 0:
            p2Poke1 = new poke(Console.ReadLine());
            break;
            //dispMon(p1Poke1)
          case 1:
            p2Poke2 = new poke(Console.ReadLine());
            break;
            //dispMon(p1Poke1)
          case 2:
            p2Poke3 = new poke(Console.ReadLine());
            break;
            //dispMon(p1Poke1)
          case 3:
            p2Poke4 = new poke(Console.ReadLine());
            break;
            //dispMon(p1Poke1)
          case 4:
            p2Poke5 = new poke(Console.ReadLine());
            break;
            //dispMon(p1Poke1)
          case 5:
            p2Poke6 = new poke(Console.ReadLine());
            break;
            //dispMon(p1Poke1)
        }
      }
      Console.Write("Your Team:" + Environment.NewLine);
      p1Poke1.dispMon();
      p1Poke2.dispMon();
      p1Poke3.dispMon();
      p1Poke4.dispMon();
      p1Poke5.dispMon();
      p1Poke6.dispMon();
      Console.Write(Environment.NewLine);
      Console.Write("Opponent's Team: " + Environment.NewLine);
    }
  }
}

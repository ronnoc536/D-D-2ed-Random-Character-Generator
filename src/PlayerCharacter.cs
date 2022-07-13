using System;

namespace DungeonsAndDragons
{
  public class PlayerCharacter
  {
    public PlayerCharacter()
    {
      public int m_CharAge = 0;
      public string m_CharName = "";
      // Personhood GenInfo; // the above info can go in a general info class
      public ClassObj m_CharClass; // FIXME: Need to make Class Class
      public RaceObj m_CharRase; // FIXME: Need to make Rase Class
      public Stats SDCIWC; // this needs to be a base class for all the stat atributes
      // weapons?
      // proficencies?
      // blah blah blah



    }

    public PlayerCharacter(string Name, int Age)
    {
      m_CharAge = Age;
      m_CharName =  Name;


    }

    //member vars
    public string?  m_CharName{get;set;}
    public int? m_CharAge{get;set;}

    
  }
}
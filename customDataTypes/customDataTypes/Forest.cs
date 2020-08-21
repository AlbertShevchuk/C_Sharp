using System;

namespace StaticMembers
{
  class Forest
  {
    public int age;
    private string biome;
	private static int forestsCreated;
	private static string treeFacts;
    
    public Forest(string name, string biome)
    {
      this.Name = name;
      this.Biome = biome;
      Age = 0;
	  Forest.forestsCreated++;
    }
    
    public Forest(string name) : this(name, "Unknown")
    { }
	
	static Forest()
    {
      treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
      Forest.forestsCreated = 0;
      
    }
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
	
	public static void PrintTreeFacts()
    {
      Console.WriteLine(Forest.treeFacts);
	}
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
  }
}

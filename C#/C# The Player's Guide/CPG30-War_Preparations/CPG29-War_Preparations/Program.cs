// See https://aka.ms/new-console-template for more information

Sword sword1 = new Sword(Swords.Iron, Gemstones.None, 1,1);
Sword sword2 = new Sword(Swords.Iron, Gemstones.None, 21,12);
Sword sword3 = new Sword(Swords.Iron, Gemstones.None, 31,14);

// Swords can be made out of any of the following materials: wood, bronze, iron, steel, and the rare binarium.
// Create an enumeration to represent the material type.

// Gemstones can be attached to a sword, which gives them strange powers through Cygnus and Lyra’s touch.
// Gemstone types include emerald, amber, sapphire, diamond, and the rare bitstone. Or no gemstone at all.
// Create an enumeration to represent a gemstone type.

// Create a Sword record with a material, gemstone, length, and cross-guard width.

// In your main program, create a basic Sword instance made out of iron and with no gemstone.
// Then create two variations on the basic sword using with expressions.

// Display all three sword instances with code like Console.WriteLine(original);.

public record Sword(Swords Type, Gemstones Gem, double Length, double Width);

public enum Swords {Wood, Bronze, Iron, Steel, Binarium}
public enum Gemstones {Emerald, Amber, Sapphire, Diamond, Bitstone, None}
using System.Diagnostics.SymbolStore;

var aGolden = new GoldenRetriever() { Name = "Aspen" };
var anotherGolden = new GoldenRetriever() { Name = "Aspen" };

var aBorder = new BorderCollie() { Name = "Aspen" };
var anotherBorder = new BorderCollie() { Name = "Aspen" };

var aBernese = new Bernese() { Name = "Aspen" };
var anotherBernese = new Bernese() { Name = "Aspen" };

var goldenComparision = aGolden.Equals(anotherGolden)
    ? "These Golden Retrievers have the same names"
    : "These Golden Retrievers have the different names";

var borderComparision = aBorder.Equals(anotherBorder)
    ? "These Border Collies have the same names"
    : "These Border Collies have the different names";

var berneseComparision = aBernese.Equals(anotherBernese)
    ? "These Bernese dogs have the same names"
    : "These Bernese dogs have the different names";

// structs checks struct properties
Console.WriteLine(goldenComparision);

// classes check references
Console.WriteLine(borderComparision);

// this class overrides equals
Console.WriteLine(berneseComparision);



struct GoldenRetriever {
    public string Name { get; set; }
}

class BorderCollie {
    public string Name { get; set; }
}

class Bernese {
    public string Name { get; set; }

    public override bool Equals(object obj) {
        if (obj is Bernese borderCollie && obj != null) {
            return this.Name == borderCollie.Name;
        }
        return false;
    }
}

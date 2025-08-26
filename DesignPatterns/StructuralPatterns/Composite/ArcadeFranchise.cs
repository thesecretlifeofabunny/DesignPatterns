using DesignPatterns.Classes.Arcade;

namespace DesignPatterns.StructuralPatterns.Composite;

/// <summary>
/// Implementation influenced by
/// Geekific. “ The Composite Pattern Explained and Implemented in Java | Structural Design Patterns | Geekific .” YouTube, YouTube, 4 Dec. 2021, www.youtube.com/watch?v=oo9AsGqnisk. 
/// </summary>
public class ArcadeFranchise
{
    private IArcade? Arcade { get; set; }

    public void CreateFranchisee(List<IArcade> arcadesOfFranchisee)
    {
        Arcade = new ArcadeComposite(arcadesOfFranchisee);
    }

    public int CalculateFranchiseeArcadeGameCost() => Arcade?.CalculatePrice() ?? 0;
}
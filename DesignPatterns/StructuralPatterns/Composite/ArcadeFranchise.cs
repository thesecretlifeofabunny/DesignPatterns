using DesignPatterns.Classes.Arcade;

namespace DesignPatterns.StructuralPatterns.Composite;

public class ArcadeFranchise
{
    private IArcade? Arcade { get; set; }

    public void CreateFranchisee(List<IArcade> arcadesOfFranchisee)
    {
        Arcade = new ArcadeComposite(arcadesOfFranchisee);
    }

    public int CalculateFranchiseeArcadeGameCost() => Arcade?.CalculatePrice() ?? 0;
}
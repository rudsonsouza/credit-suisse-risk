using credit_risk_solution.interfaces;

namespace credit_risk_solution.models;

public class MediumRiskCategory : TradeCategory
{
    public override string Classify(ITrade trade, DateTime referenceDate)
    {
        if (trade.Value > 1000000 && trade.ClientSector == "Public")
            return "MEDIUMRISK";
        return null;
    }
}
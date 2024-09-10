using credit_risk_solution.interfaces;

namespace credit_risk_solution.models;

public class HighRiskCategory : TradeCategory
{
    public override string Classify(ITrade trade, DateTime referenceDate)
    {
        if (trade.Value > 1000000 && trade.ClientSector == "Private")
            return "HIGHRISK";

        return null;
    }
}
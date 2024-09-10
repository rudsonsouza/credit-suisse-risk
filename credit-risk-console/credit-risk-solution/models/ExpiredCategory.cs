using credit_risk_solution.interfaces;

namespace credit_risk_solution.models;

public class ExpiredCategory : TradeCategory
{
    public override string Classify(ITrade trade, DateTime referenceDate)
    {
        if ((referenceDate - trade.NextPaymentDate).Days > 30)
            return "EXPIRED";

        return null;
    }
}
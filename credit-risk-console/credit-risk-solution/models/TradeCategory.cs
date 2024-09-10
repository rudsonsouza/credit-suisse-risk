using credit_risk_solution.interfaces;

namespace credit_risk_solution.models;

public abstract class TradeCategory
{
    public abstract string Classify(ITrade trade, DateTime referenceDate);
}
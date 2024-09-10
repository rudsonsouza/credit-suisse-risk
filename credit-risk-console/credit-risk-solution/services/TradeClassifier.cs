using credit_risk_solution.interfaces;
using credit_risk_solution.models;

namespace credit_risk_solution.services;

public class TradeClassifier
{
    private List<TradeCategory> _categories;

    public TradeClassifier()
    {
        _categories = new List<TradeCategory>
        {
            new ExpiredCategory(),
            new HighRiskCategory(),
            new MediumRiskCategory()
        };
    }
    
    public string ClassifyTrade(ITrade trade, DateTime referenceDate)
    {
        foreach (var category in _categories)
        {
            var result = category.Classify(trade, referenceDate);
            if (result != null)
                return result;
        }
        return "UNCLASSIFIED"; // In case no category matches
    }
}
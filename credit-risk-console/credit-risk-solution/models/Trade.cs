using credit_risk_solution.interfaces;

namespace credit_risk_solution.models;

public class Trade : ITrade
{
    public double Value { get; private set; }
    public string ClientSector { get; private set; }
    public DateTime NextPaymentDate { get; private set; }

    public Trade(double value, string clientSector, DateTime nextPaymentDate)
    {
        Value = value;
        ClientSector = clientSector;
        NextPaymentDate = nextPaymentDate;
    }
}
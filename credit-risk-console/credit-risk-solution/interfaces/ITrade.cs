namespace credit_risk_solution.interfaces;

public interface ITrade
{
    double Value { get; }
    string ClientSector { get; }
    DateTime NextPaymentDate { get; }
}
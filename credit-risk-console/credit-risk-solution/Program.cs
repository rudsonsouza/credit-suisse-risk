using credit_risk_solution.interfaces;
using credit_risk_solution.models;
using credit_risk_solution.services;


/* Question 01
 *
 * 
 */
DateTime referenceDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
int n = int.Parse(Console.ReadLine());

List<ITrade> trades = new List<ITrade>();

for (int i = 0; i < n; i++)
{
    var line = Console.ReadLine().Split(' ');
    double value = double.Parse(line[0]);
    string clientSector = line[1];
    DateTime nextPaymentDate = DateTime.ParseExact(line[2], "MM/dd/yyyy", null);
    
    trades.Add(new Trade(value, clientSector, nextPaymentDate));
}

TradeClassifier classifier = new TradeClassifier();
foreach (var trade in trades)
{
    string category = classifier.ClassifyTrade(trade, referenceDate);
    Console.WriteLine(category);
}

/* Question 02
 * 
 * Para levar em conta a nova categoria PEP (Pessoa Politicamente Exposta) no design, preciso adicionar uma nova
 * propriedade booleana IsPoliicallyExposed na interface ITrade e, em seguida, criar uma nova classe que estenda
 * TradeCategory, especificamente para classificação PEP. A nova classe de categoria PEP implementaria o método
 * Classify para verificar se a propriedade IsPoliicallyExposed está definida como verdadeira para uma
 * determinada negociação. Além disso, eu atualizaria a classe Trade para implementar esta nova propriedade e
 * garantir que as instâncias de trades possam especificar corretamente se envolvem pessoas politicamente expostas.
 * Por fim, eu incluiria a nova classe de categoria PEP na lista de categorias do TradeClassifier para garantir que
 * ela seja considerada durante o processo de classificação.   
 * 
 * To account for the new PEP (Politically Exposed Person) category in the design, I need to add a new boolean
 * property IsPoliticallyExposed in the ITrade interface and then create a new class that extends TradeCategory.
 * The new PEP category class would implement the Classify method to check if the IsPoliticallyExposed property is
 * set to true for a given trade.
 * Additionally, I would update the Trade class to implement this new property and ensure that instances of trades
 * can correctly specify whether they involve politically exposed persons.
 * Finally, I would include the new PEP category class in the TradeClassifier's category list to ensure it is
 * considered during the classification process.
 * 
 */


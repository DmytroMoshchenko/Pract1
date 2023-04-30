internal interface ICalculator
{
    ValueTask<double> GetCalculationResultAsync(int x);
}
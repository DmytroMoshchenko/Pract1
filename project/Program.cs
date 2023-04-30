internal class Calculator : ICalculator
{
    public ValueTask<double> GetCalculationResultAsync(int x)
    {
        double result;
        if (x < -1D)
        {
            result = (x - 1D) / (x + 1D);
            return new ValueTask<double>(result);
        }

        if (x >= 20D)
        {
            double product = 1D;
            for (double iterator = 20; iterator <= x; iterator++)
            {
                product *= (iterator / 3 + 1);
            }

            return new ValueTask<double>((1F / 2)*product);
        }

        double sum = 0D;
        if (x >= -1D && x < 20D)
        {
            for (double iterator = -1; iterator <= x ; iterator++)
            {
                sum += iterator / 2;
            }
        }
        return new ValueTask<double>(4 - sum);
    }
}
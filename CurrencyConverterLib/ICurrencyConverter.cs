namespace CurrencyConverterLib
{
    public interface ICurrencyConverter
    {
        decimal GetConvertedAmount(string fromCountryCode, string toCountryCode, decimal fromAmount);
    }
}
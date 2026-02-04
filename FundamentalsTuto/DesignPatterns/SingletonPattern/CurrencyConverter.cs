namespace SingletonPattern
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;
        private CurrencyConverter()
        {
            LoadExchangeRates();
        }
        
        private static object _lock = new();
        private static CurrencyConverter _instance;
        public static CurrencyConverter Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new();
                    }
                }
                return _instance;
            }
        } // Double Lock

        private void LoadExchangeRates()
        {
            Thread.Sleep(3000); // waiting for 3 seconds to simulate heavy work
            _exchangeRates = new[]
            {
                new ExchangeRate("USD", "TND", 2.89m),
                new ExchangeRate("USD", "MYR", 3.93m),
                new ExchangeRate("MYR", "TND", 0.74m)
            };
        }

        public decimal Convert(string baseCurrency, string targetCurrency, decimal amount)
        {
            var exchangeRate = _exchangeRates.FirstOrDefault(rate => rate.BaseCurrency == baseCurrency && rate.TargetCurrency == targetCurrency);
            return amount * exchangeRate.Rate;
        }
    }
}

// Singleton is good load all data first time and use directly after without timeout
// static classes is good for small data but not good in big data (Limited use.)
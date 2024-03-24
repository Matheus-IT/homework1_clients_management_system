namespace Management
{
    class LegalEntity : Client
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public override void PayTax(float value)
        {
            Value = value;
            TaxValue = Value * 20 / 100;
            Total = Value + TaxValue;
        }
    }
}
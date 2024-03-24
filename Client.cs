namespace Management
{
    class Client
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public float Value { get; protected set; }
        public float TaxValue { get; protected set; }
        public float Total { get; protected set; }

        public virtual void PayTax(float value)
        {
            Value = value;
            TaxValue = Value * 10 / 100;
            Total = Value + TaxValue;
        }
    }

}
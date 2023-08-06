public class CreditCard
{
    private string cardNumber;
    private int cvcCode;
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    public CreditCard(string cardNumber, int cvcCode, decimal balance)
    {
        this.cardNumber = cardNumber;
        this.cvcCode = cvcCode;
        this.balance = balance;
    }

    public static CreditCard operator +(CreditCard card, decimal amount)
    {
        card.Balance += amount;
        return card;
    }

    public static CreditCard operator -(CreditCard card, decimal amount)
    {
        card.Balance -= amount;
        return card;
    }

    public static bool operator ==(CreditCard card, int cvcCode)
    {
        return card.cvcCode == cvcCode;
    }

    public static bool operator !=(CreditCard card, int cvcCode)
    {
        return card.cvcCode != cvcCode;
    }

    public static bool operator <(CreditCard card1, CreditCard card2)
    {
        return card1.balance < card2.balance;
    }

    public static bool operator >(CreditCard card1, CreditCard card2)
    {
        return card1.balance > card2.balance;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || !(obj is CreditCard))
        {
            return false;
        }

        CreditCard card = (CreditCard)obj;
        return this.cardNumber == card.cardNumber && this.cvcCode == card.cvcCode;
    }
}
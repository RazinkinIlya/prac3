
SmsMessage Sms= new SmsMessage(2.5, 100, -60);
string text = "21321312312sadasdsadsadasdasdasdasdasdasdasdasdsadasdsadsadasdsadasdsd21321312312sadasdsadsadasdasdasdasdasdasdasdasdsadasdsadsadasdsadasdsd21321312312sadasdsadsadasdasdasdasdasdasdasdasdsadasdsadsadasdsadasdsd";


Sms.Message(text);



class SmsMessage
{
    private double price;
    private int maxLenght;
    private double tax;
    public double Price
    {
        get { return price; }
        set { price = NormalizePrice(value); }
    }
    public int MaxLenght
    {
        get { return maxLenght; }
        set { maxLenght = NormalizeMaxLenght(value); }
    }

    public double Tax
    {
        get { return tax; }
        set { tax = NormalizeTaxValue(value); }
    }
    private double NormalizePrice(double price)
    {
        if (price <= 0)
        {
            return 1.5;
        }
        return price;
    }
    private int NormalizeMaxLenght(int maxLenght)
    {
        if (maxLenght <= 0)
        {
            return 255;
        }
        return maxLenght;
    }
    private double NormalizeTaxValue(double Tax)
    {
        if (Tax <= 0)
        {
            return 0.5;
        }
        return (double)Tax;
    }
    public  SmsMessage() { }
    public  SmsMessage(double price, int maxLenght, double tax)
    {
        Price = price;
        MaxLenght = maxLenght;
        Tax = tax;

    }
    public void Message(string messageText)
    {


        if (messageText.Length < 65)
        {
            Console.WriteLine($"Ваше сообщение отправлено \n Текст вашего сообщения {messageText} \n Стоимость отправки сообщения {price} Рубля");
        }
        else
        {

            messageText = messageText.Substring(0, maxLenght);
            Console.WriteLine(messageText.Length);
            Console.WriteLine($"Ваше сообщение отправлено \n Текст вашего сообщения {messageText} \n Стоимость отправки сообщения {price + (messageText.Length - 65) * Tax} Рублей");

        }
    }
}
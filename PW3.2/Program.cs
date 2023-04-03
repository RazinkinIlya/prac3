
SmsMessage Sms = new SmsMessage();
string textMax = "123456789101112131415161718192012345678910111213141516171819201234567891011121314151617181920123456789101112131415161718192012345678910111213141516171819201234567891011121314151617181920" +
    "123456789101112131415161718192012345678910111213141516171819201234567891011121314151617181920123456789101112131415161718192012345678910111213141516171819201234567891011121314151617181920";
string textMin = "dsadsadasdasdsadasdsadsadasd";
Sms.Message(textMin);

Sms.Message(textMax);



class SmsMessage
{
    private double price;
    public void Message(string messageText)
    {
        price = 1.5;
        if (messageText.Length < 65)
        {
            Console.WriteLine($"Ваше сообщение отправлено \n Текст вашего сообщения {messageText} \n Стоимость отправки сообщения {price} Рубля");
        }
        else { 
            
        messageText = messageText.Substring(0, 250);
            Console.WriteLine(messageText.Length);
        Console.WriteLine($"Ваше сообщение отправлено \n Текст вашего сообщения {messageText} \n Стоимость отправки сообщения {price +(messageText.Length-65)*0.5} Рубля");

        }
    }
}
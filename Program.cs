namespace ExchangeCurrency;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("EXCHANGE_____ USD to AMD ");

        int usd_amount = 89;

        USDtoAMD(usd_amount);


        Console.WriteLine("EXCHANGE_____ AMD to USD");

        int amd_amount = 4109800;

        AMDtoUSD(amd_amount);

        Console.ReadKey();
    }

    public static void USDtoAMD(int amount)
    {
        float result = amount * 400;
        ReturnAMD(result);
    }

    public static void AMDtoUSD(int amount)
    {
        float result = amount * 100 / 410;
        ReturnUSD(result);

    }
 
    public static void ReturnAMD(float result)
    {
        const int AMD10 = 10;
        const int AMD50 = 50;
        const int AMD100 = 100;
        const int AMD200 = 200;
        const int AMD500 = 500;
        const int AMD1000 = 1000;
        const int AMD5000 = 5000;
        const int AMD10000 = 10000;
        const int AMD20000 = 20000;
        const int AMD50000 = 50000;
        const int AMD100000 = 100000;


        int qtyAMD10;
        int qtyAMD50;
        int qtyAMD100;
        int qtyAMD200;
        int qtyAMD500;
        int qtyAMD1000;
        int qtyAMD5000;
        int qtyAMD10000;
        int qtyAMD20000;
        int qtyAMD50000;
        int qtyAMD100000;

        qtyAMD100000 = (int)result / AMD100000;
        result %= AMD100000;

        qtyAMD50000 = (int)result / AMD50000; ;
        result %= AMD50000;

        qtyAMD20000 = (int)result / AMD20000; ;
        result %= AMD20000;

        qtyAMD10000 = (int)result / AMD10000; ;
        result %= AMD10000;

        qtyAMD5000 = (int)result / AMD5000; ;
        result %= AMD5000;

        qtyAMD1000 = (int)result / AMD1000; ;
        result %= AMD1000;

        qtyAMD500 = (int)result / AMD500; ;
        result %= AMD500;

        qtyAMD200 = (int)result / AMD200; ;
        result %= AMD200;

        qtyAMD100 = (int)result / AMD100; ;
        result %= AMD100;

        qtyAMD50 = (int)result / AMD50; ;
        result %= AMD50;

        qtyAMD10 = (int)result / AMD10; ;
        result %= AMD10;


        Console.WriteLine(
        qtyAMD10 + " * AMD10 \n" +
        qtyAMD50 + " * AMD50\n" +
        qtyAMD100 + " * AMD100\n" +
        qtyAMD200 + " * AMD200\n" +
        qtyAMD500 + " * AMD500\n" +
        qtyAMD1000 + " * AMD1000\n" +
        qtyAMD5000 + " * AMD5000\n" +
        qtyAMD10000 + " * AMD10000\n" +
        qtyAMD20000 + " * AMD20000\n" +
        qtyAMD50000 + " * AMD50000\n" +
        qtyAMD100000 + " * AMD100000\n" );


    }

    public static void ReturnUSD(float result)
    {
        const int cent1 = 1;
        const int cent5 = 5;
        const int cent10 = 10;
        const int cent20 = 20;
        const int cent50 = 50;
        const int USD1 = 100;
        const int USD5 = 500;
        const int USD10 = 1000;
        const int USD20 = 2000;
        const int USD50 = 5000;
        const int USD100 = 10000;
        const int USD500 = 50000;
        const int USD1000 = 100000;


        int qtycent1;
        int qtycent5;
        int qtycent10;
        int qtycent20;
        int qtycent50;
        int qtyUSD1;
        int qtyUSD5;
        int qtyUSD10;
        int qtyUSD20;
        int qtyUSD50;
        int qtyUSD100;
        int qtyUSD500;
        int qtyUSD1000;

        qtyUSD1000 = (int)result / USD1000;
        result %= USD1000;

        qtyUSD500 = (int)result / USD500;
        result %= USD500;

        qtyUSD100 = (int)result / USD100;
        result %= USD100;

        qtyUSD50 = (int)result / USD50;
        result %= USD50;

        qtyUSD20 = (int)result / USD20;
        result %= USD20;

        qtyUSD10 = (int)result / USD10;
        result %= USD10;

        qtyUSD5 = (int)result / USD5;
        result %= USD5;

        qtyUSD1 = (int)result / USD1;
        result %= USD1;

        qtycent50 = (int)result / cent50;
        result %= cent50;

        qtycent20 = (int)result / cent20;
        result %= cent20;

        qtycent10 = (int)result / cent10;
        result %= cent10;

        qtycent5 = (int)result / cent5;
        result %= cent5;

        qtycent1 = (int)result / cent1;
        result %= cent1;



        Console.WriteLine(
        qtycent1 + " * cent1 \n" +
        qtycent5 + " * cent5\n" +
        qtycent10 + " * cent10\n" +
        qtycent20 + " * cent20\n" +
        qtycent50 + " * cent50\n" +
        qtyUSD1 + " * USD1\n" +
        qtyUSD5 + " * USD5\n" +
        qtyUSD10 + " * USD10\n" +
        qtyUSD20 + " * USD20\n" +
        qtyUSD50 + " * USD50\n" +
        qtyUSD100 + " * USD100\n" +
        qtyUSD500 + " * USD500\n" +
        qtyUSD1000 + " * USD1000\n"
        );


    }








}


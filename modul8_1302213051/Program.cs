using modul8_1302213051;

BankTransferConfig config = new BankTransferConfig();

if(config.lang == "en")
{
    Console.WriteLine("Please insert the amount of money to transfer: \n");
}else
{
    Console.WriteLine("Masukkan jumlah yang akan ditransfer: \n");
}
var input = int.Parse(Console.ReadLine());

int total = 0;
if (input == config.threshold)
{
    Console.WriteLine("Biaya transfer : " + config.low_fee);
    //total = input + config.low_fee;
}
else if (input > config.threshold)
{
    Console.WriteLine("Biaya transfer : " + config.high_fee);
    //total = input + config.high_fee;
}

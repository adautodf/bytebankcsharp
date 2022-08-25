using bytebank;
using bytebank.Owner;

Console.WriteLine("Welcome to your bank, ByteBank");

//checkingAccount account1 = new checkingAccount();
//account1.owner = "Adauto Filho";
//account1.account = "10123-X";
//account1.branch_number = 23;
//account1.agency_name = "Central Agency";
//account1.balance = 1000000;

//checkingAccount account2 = new checkingAccount();
//account2.owner = "Gabriel Fruet";
//account2.account = "32101-X";
//account2.branch_number = 22;
//account2.agency_name = "Central Agency";
//account2.balance = 0;

customer client1 = new customer();
client1.name = "Adauto Filho";
client1.cpf = "15467254144";
client1.profession = "Software Developer";

checkingAccount account3 = new checkingAccount();
account3.owner = client1;
account3.account = "2513252-X";
account3.branch_number = 35;
account3.agency_name = "Central Agency";

Console.WriteLine(client1.name);

Console.WriteLine("Tecle Enter para fechar.");
Console.ReadKey();
// readline
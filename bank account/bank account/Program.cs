using System;
class BankAccount{
private decimal balance;
private string accountNumber;
private string ownerName;
public BankAccount(decimal balance, string accountNumber, string ownerName)
{

this.balance = balance;
this.accountNumber = accountNumber;
this.ownerName = ownerName;

}
public void deposit(decimal amount){
if (amount <= 0){
    Console.WriteLine("You must add a positive amount.");
}
else{
    balance = amount + balance;
    Console.WriteLine($" {amount} added successfully");
}
}


public void Withdraw(decimal amount){
   if(amount <=0){
    Console.WriteLine("You must add a positive number");
   }
   else if (amount>balance){
    Console.WriteLine("The balance is insufficient");
   }
   else{
        balance -= amount;
        Console.WriteLine($"Withdrawal {amount} completed successfully");

   }
 
}
public void CheckBalance(){
Console.WriteLine($"Te balance for account {ownerName} is : {balance}.");
}
public void Transfer(BankAccount targetAccount, decimal amount){
    if (amount <= 0){
        Console.WriteLine("You must add an amount with a positive number ");
    }
    else if (amount> balance){
        Console.WriteLine("The amount is not enough ");
    }
    else {
        balance -= amount;
        targetAccount.deposit(amount);
        Console.WriteLine($"{amount}  successfully transferred from account {ownerName} to account {targetAccount.ownerName}.");
    }
}
public decimal Balance()=> balance;
public string AccountNumber()=> accountNumber;
public string OwnerName()=> ownerName;


}



using System;
public class bank{
    public static void Main(){
       BankAccount bankAccount1= new BankAccount(0,"111","Sara");
       BankAccount bankAccount2= new BankAccount(0,"222","Hala");

       bankAccount1.deposit(1600);
       bankAccount1.CheckBalance();

       bankAccount1.Withdraw(100);
       bankAccount1.CheckBalance();
       
       bankAccount1.Transfer(bankAccount2,500);
        bankAccount1.CheckBalance();
        bankAccount2.CheckBalance();
    }
}
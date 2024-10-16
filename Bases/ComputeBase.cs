using Microsoft.AspNetCore.Components;
//namespace Calculator.Components.Pages;
namespace demo.Bases;

public class ComputeBase :ComponentBase{
    public int num1{set;get;}
    public int num2{set;get;}
    public int num{set;get;}

    public void Form_Calculate()
    {
        num=num1+num2;
    }
    public void Form_Clear(){
        num1=0;
        num2=0;
        num=0;
    }
}
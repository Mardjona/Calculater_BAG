using System;
using System.Globalization;
using System.Runtime.InteropServices.JavaScript;
using Avalonia.Controls;
using Avalonia.Interactivity;
namespace Calculater;
public partial class MainWindow : Window
{
    private string Number;
    private string Temp;
    private string Operation;
    private double ravno;
    public MainWindow()
    {
        InitializeComponent();
        ButtonZerro.Click += ButtonZerroOnClick; //0
        ButtonOne.Click += ButtonOneOnClick; //1
        ButtonTwo.Click += ButtonTwoOnclick; //2
        ButtonThree.Click += ButtonThreeOnClick; //3
        ButtonFour.Click += ButtonFourOnclick; //4
        ButtonFive.Click += ButtonFiveOnClick; //5
        ButtonSix.Click += ButtonSixOnclick; //6
        ButtonSeven.Click += ButtonSevenOnclick; //7
        ButtonEight.Click += ButtonEightOnclick; //8
        ButtonNine.Click += ButtonNineOnClick; //9
        ButtonDelite.Click += ButtonDeliteOnClick; // удалить Се
        ButtonPlus.Click += ButtonPlusOnClick; // +
        ButtonMinus.Click += ButtonMinusOnClick; // - 
        ButtonMulti.Click += ButtonMultiOnClick; // *
        ButtonDivision.Click += ButtonDivisonOnClick; //  деление /
        ButtonEquals.Click += ButtonEqualsOnClick; //=
        ButtonRoot.Click += ButtonRootOnClick; // корень 
        ButtonPersent.Click += ButtonPersentOnClick; //  процент 
        ButtonSom.Click += ButtonSomOnclick; // 1 деленное на х 
        ButtonPlusMinus.Click += ButtonPlusMinusOnclick; // 1 деленное на х 
        ButtonSquare.Click += ButtonSquaresOnclick; //  число в квадрате 
        ButtonСube.Click += ButtonСubeOnClick; //   число в кубе
        ButtonXY.Click += ButtonXYOnclick; //   число в числе
        ButtonRootThree.Click += ButtonRootThreeOnClick; //   корень из числа 
        ButtonTenX.Click += ButtonTenXOnClick; // десять в какой то степени
        ButtonPI.Click += ButtonPIOnClick; // пи
        ButtonSin.Click += ButtonSinOnClick; // синус
        ButtonCos.Click += ButtonCosOnClick; // косинус
        ButtonTgn.Click += ButtonTgnOnClick; // тангенс
        ButtonFactorial.Click += ButtonFactorialOnClick; // факториал
        ButtonLog.Click += ButtonLogOnClick;
        ButtonСomma.Click += ButtonСommaOnClick; // запятая
        ButtonBack.Click += ButtonBackOnClick; // удаление по одной цыфре 
        

    }

    bool   ButtonEqualsClick = false;

    private void Operation_Click(object? sender, RoutedEventArgs e)
    {
        ButtonEqualsClick = true;
    }

    private void ButtonBackOnClick(object? sender, RoutedEventArgs e)
    {
        if (Operation == null)
        {
            Number = Number.Remove(Number.Length - 1);
            NumberDisplay.Text = Number;
        }
        else
        {
            Temp = Temp.Remove(Temp.Length - 1);
            NumberDisplay.Text = Temp;
        }

    }
    private void ButtonDeliteOnClick(object? sender, RoutedEventArgs e) // удалить Се
    {
        Number = "";
        Temp = "";
        Operation = null;
        NumberDisplay.Text = null;
    }
    private void ButtonZerroOnClick(object? sender, RoutedEventArgs e)   // 0
    {
        if (Operation == null)
        {
            Number += 0.ToString();
            NumberDisplay.Text = Number;
        }
        else
        {
            Temp += 0.ToString();
            NumberDisplay.Text = Temp;
        }
    }
    private void ButtonOneOnClick(object? sender, RoutedEventArgs e) //1
    {
        if (Operation == null)
        {
            Number += 1.ToString();
            NumberDisplay.Text = Number;

        }
        else
        {
            Temp += 1.ToString();
            NumberDisplay.Text = Temp;

        }
    }
    private void ButtonTwoOnclick(object? sender, RoutedEventArgs e)  //2
    {
        if (Operation == null)
        {
            Number += 2.ToString();
            NumberDisplay.Text = Number;
        }
        else
        {
            Temp += 2.ToString();
            NumberDisplay.Text =Temp;

        }
    }
    private void ButtonThreeOnClick(object? sender, RoutedEventArgs e)  //3
    {
        if (Operation == null)
        {
            Number += 3.ToString();
            NumberDisplay.Text = Number;

        }
        else
        {
            Temp += 3.ToString();
            NumberDisplay.Text = Temp;

        }
    }
    private void ButtonFourOnclick(object? sender, RoutedEventArgs e)  //4
    {
        if (Operation == null)
        {
            Number += 4.ToString();
            NumberDisplay.Text = Number;

        }
        else
        {
            Temp +=4.ToString();
            NumberDisplay.Text = Temp;

        }
    }
    private void ButtonFiveOnClick(object? sender, RoutedEventArgs e)  //5
    {
        if (Operation == null)
        {
            Number += 5.ToString();
            NumberDisplay.Text = Number;
        }
        else
        {
            Temp += 5.ToString();
            NumberDisplay.Text = Temp;
        }
    }

    private void ButtonSixOnclick(object? sender, RoutedEventArgs e) //6
    {
        if (Operation == null)
        {
            Number += 6.ToString();
            NumberDisplay.Text = Number;

        }
        else
        {
            Temp += 6.ToString();
            NumberDisplay.Text = Number;

        }
    }
    private void ButtonSevenOnclick(object? sender, RoutedEventArgs e)  //7
    {
        if (Operation == null)
        {
            Number += 7.ToString();
            NumberDisplay.Text = Number;
        }
        else
        {
            Temp += 7;
            NumberDisplay.Text = 7.ToString();

        }
    }
    private void ButtonEightOnclick(object? sender, RoutedEventArgs e)  //8
    {
        if (Operation == null)
        {
            Number += 8.ToString();
            NumberDisplay.Text = Number;

        }
        else
        {
            Temp += 8.ToString();
            NumberDisplay.Text =Temp;
        }
    }

    private void ButtonNineOnClick(object? sender, RoutedEventArgs e) //9
    {
        if (Operation == null)
        {
            Number += 9.ToString();
            NumberDisplay.Text = Number;
        }
        else
        {
            Temp += 9.ToString();
            NumberDisplay.Text =Temp;
        }
    }
    private void ButtonEqualsOnClick(object? sender, RoutedEventArgs e) // равно 
    {
     
           if (!ButtonEqualsClick)
           {
               Number = Convert.ToString(Calc(Operation));
               NumberDisplay.Text = Number;
               Temp =  " ";
               ButtonEqualsClick = false;


           }
    }
    private void ButtonСommaOnClick(object? sender, RoutedEventArgs e) // плавающая запятая
    {
        if (Operation == null)
        {
            Number += ",";
            NumberDisplay.Text = Number;
        }
        else
        {
            Temp += ",";
            NumberDisplay.Text = Temp;
        }
    }
    private void ButtonPlusOnClick(object? sender, RoutedEventArgs e)
    {
        Operation = "plus";
        NumberDisplay.Text = "+";
       
    } // плюс
    private void ButtonMinusOnClick(object? sender, RoutedEventArgs e)
    {
        Operation = "minus";
        NumberDisplay.Text = "-";
    } // минус
    private void ButtonMultiOnClick(object? sender, RoutedEventArgs e) // умножить
    {
        Operation = "multi";
        NumberDisplay.Text = "*";
    }
    private void ButtonDivisonOnClick(object? sender, RoutedEventArgs e) // делить
    {
        Operation = "division";
        NumberDisplay.Text = "/";
    }
    private void ButtonRootOnClick(object? sender, RoutedEventArgs e)
    {
        Operation = "koren";
        NumberDisplay.Text = "0";
    } // Число в корне 
    private void ButtonPersentOnClick(object? sender, RoutedEventArgs e)
    {
        Operation = "persent";
        NumberDisplay.Text = "%";
    } // процент
    private void ButtonSomOnclick(object? sender, RoutedEventArgs e) // 1 деленное на число
    {
        Operation = "som";
        NumberDisplay.Text = "0";
    }
    private void ButtonPlusMinusOnclick(object? sender, RoutedEventArgs e) //  число отрицательное 
    {
        Operation = "PlusMinus";
        NumberDisplay.Text = "0";
    }
    private void ButtonSquaresOnclick(object? sender, RoutedEventArgs e) //  число в квадрате 
    {
        Operation = "Squares";
        NumberDisplay.Text = "0";
    }
    private void ButtonСubeOnClick(object? sender, RoutedEventArgs e) //  число в кубе 
    {
        Operation = "Cube";
        NumberDisplay.Text = "0";
    }
    private void ButtonXYOnclick(object? sender, RoutedEventArgs e) //  число в степени 
    {
        Operation = "XY";
        NumberDisplay.Text = "0";
    }
    private void ButtonRootThreeOnClick(object? sender, RoutedEventArgs e) //  корень из числа 3 
    {
        Operation = "RootThree";
        NumberDisplay.Text = "0";
    }
    private void ButtonTenXOnClick(object? sender, RoutedEventArgs e) //  число 10 в степени
    {
        Operation = "TenX";
        NumberDisplay.Text = "0";
    }
    private void ButtonPIOnClick(object? sender, RoutedEventArgs e) //  число П
    {
        if (Operation == null)
        {
            Number += Math.PI.ToString();
            NumberDisplay.Text = Number;

        }
        else
        {
            Temp += Math.PI.ToString();
            NumberDisplay.Text = Temp;

        }

    }
    private void ButtonSinOnClick(object? sender, RoutedEventArgs e) //   синус
    {
        Operation = "Sin";
        NumberDisplay.Text = "0";
    }
    private void ButtonCosOnClick(object? sender, RoutedEventArgs e) //   косинус
    {
        Operation = "Cos";
        NumberDisplay.Text = "0";
    } 
    private void ButtonTgnOnClick(object? sender, RoutedEventArgs e) //  тангенс 
    {
        Operation = "Tang";
        NumberDisplay.Text = "0";
    }
    private void ButtonFactorialOnClick(object? sender, RoutedEventArgs e) //  факториал  
    {
        Operation = "Factorial";
        NumberDisplay.Text = "0";
    }
    private double Factorial(double f)
    {
        var result = 1;
        for (var i = 2; i <= f; i++)
        {
            result *= i;
        }

        return result;
    }
                                        
    private void ButtonLogOnClick(object? sender, RoutedEventArgs e) //  логарифм 
    {
        Operation = "Log";
        NumberDisplay.Text = "0";
    }
    private double Calc(string c)
    {
        ravno = c switch
        {
            "plus" => Convert.ToDouble(Number) + Convert.ToDouble(Temp),
            "minus" => Convert.ToDouble(Number) - Convert.ToDouble(Temp),
            "multi" => Convert.ToDouble(Number) * Convert.ToDouble(Temp),
            "division" => Convert.ToDouble(Number) / Convert.ToDouble(Temp),
            "koren" => Math.Sqrt(Convert.ToDouble(Number)),
            "persent" => Convert.ToDouble(Number) / 100,
            "som" => 1 / Convert.ToDouble(Number),
            "PlusMinus" => -Convert.ToDouble(Number),
            "Squares" => Convert.ToDouble(Number) * Convert.ToDouble(Number),
            "Cube" => Convert.ToDouble(Number) * Convert.ToDouble(Number) * Convert.ToDouble(Number),
            "XY" => Math.Pow(Convert.ToDouble(Number), Convert.ToDouble(Temp)),
            "RootThree" => Math.Pow(Convert.ToDouble(Number), 1.0 / 3.0),
            "TenX" => Math.Pow(10, Convert.ToDouble(Number)),
            "Pi" => 2 * Math.PI * Convert.ToDouble(Temp),
            "Sin" => Math.Sin(Convert.ToDouble(Number)),
            "Cos" => Math.Cos(Convert.ToDouble(Number)),
            "Tang " => Math.Tan(Convert.ToDouble(Number)),
            "Factorial" => Factorial(Convert.ToDouble(Number)),
            "Log" => Math.Log(Convert.ToDouble(Number)),
            _ => ravno
        };
        Number = ravno.ToString();

        return ravno;
    }
}



using System.Windows.Input;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public ICommand CCommand { private set; get; }

    bool one;
    bool two;
    bool three;

    public MainPage()
	{
		


        CCommand = new Command<string>(
            execute: (string arg) =>
            {
                l.Text = $"Нажата кнопка: {arg}";
            },

            canExecute: (string arg) =>
            {
                return Check(Convert.ToInt32(arg));
            }

        );

        BindingContext = this;
        InitializeComponent();
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        one = e.Value;
        ((Command)CCommand).ChangeCanExecute();
    }

    private void Switch_Toggled2(object sender, ToggledEventArgs e)
    {
        two = e.Value;
        ((Command)CCommand).ChangeCanExecute();
    }

    private void Switch_Toggled3(object sender, ToggledEventArgs e)
    {
        three = e.Value;
        ((Command)CCommand).ChangeCanExecute();
    }

    public bool Check(int value)
    {
        if (value < 4)
        {
            return one;
        }
        else if (value >= 4 && value < 7)
        {
            return two;
        }
        else
        {
            return three;
        }
    }
}
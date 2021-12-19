using BasePlug;
using System;

[assembly: Name("Add ModButtons")]

namespace ButtonsPlugins
{
    class Plugin3 : IPlugin 
    {
        public void Run(IHost host)
        {
            yt_Button Button_yt1 = new yt_Button 
            { 
                Text = "MyButton", 
                Top = 120, Left = 5, 
                Width = 135, 
                BackColor = FlatColors.PurpleDark 
            };
            yt_Button Button_Rounded = new yt_Button
            {
                Text = "MyButton",
                Top = 155,
                Left = 5,
                Width = 135,
                BackColor = FlatColors.GreenDark,
                RoundingEnable = true,
                Rounding = 100
            };

            yt_Button Button_Gradient = new yt_Button
            {
                Top = 190,
                Left = 5,
                Width = 135,
                BackColorGradientEnabled = true,
                BackColor = FlatColors.PurpleDark,
                BackColorAdditional = FlatColors.RedDark
            };

            yt_Button Button_Gradient_Rounded = new yt_Button
            {
                Top = 225,
                Left = 5,
                Width = 135,
                BackColorGradientEnabled = true,
                BackColor = FlatColors.Blue,
                BackColorAdditional = FlatColors.GreenSeaDark,
                RoundingEnable = true,
                Rounding = 100
            };
            Animator.Start();
            host.AddControlToMainForm(Button_yt1);
            host.AddControlToMainForm(Button_Rounded);
            host.AddControlToMainForm(Button_Gradient);
            host.AddControlToMainForm(Button_Gradient_Rounded);
        }
    }
}
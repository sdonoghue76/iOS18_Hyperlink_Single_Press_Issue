using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace iOS18_Hyperlink_Single_Press_Issue;

class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}
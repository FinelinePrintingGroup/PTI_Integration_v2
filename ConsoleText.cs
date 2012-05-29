using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml;
using System.IO;
using System.Data;

class ConsoleText
{
    ///
    /// CONSOLE.WRITE 
    ///
    public static void Write_Red<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_Blue<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_DarkBlue<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_DarkGreen<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_DarkCyan<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_DarkRed<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_DarkYellow<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_DarkMagenta<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_White<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_Cyan<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_Yellow<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_Green<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_Magenta<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_Gray<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(value);
        Console.ResetColor();
    }
    public static void Write_DarkGray<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(value);
        Console.ResetColor();
    }


    ///
    /// BACKGROUND COLOR HIGHLIGHTING
    ///
    public static void Highlight_Red()
    {
        Console.BackgroundColor = ConsoleColor.Red;
    }
    public static void Highlight_Blue()
    {
        Console.BackgroundColor = ConsoleColor.Blue;
    }
    public static void Highlight_White()
    {
        Console.BackgroundColor = ConsoleColor.White;
    }
    public static void Highlight_Yellow()
    {
        Console.BackgroundColor = ConsoleColor.Yellow;
    }
    public static void Highlight_Magenta()
    {
        Console.BackgroundColor = ConsoleColor.Magenta;
    }
    public static void Highlight_DarkRed()
    {
        Console.BackgroundColor = ConsoleColor.DarkRed;
    }
    public static void Highlight_DarkGray()
    {
        Console.BackgroundColor = ConsoleColor.DarkGray;
    }
    public static void Highlight_Reset()
    {
        Console.BackgroundColor = ConsoleColor.Black;
    } 


    ///
    /// CONSOLE.WRITELINE
    ///
    public static void WriteLine_Red<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_Blue<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_DarkBlue<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_DarkGreen<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_DarkCyan<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_DarkRed<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_DarkYellow<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_DarkMagenta<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_White<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_Cyan<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_Yellow<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_Green<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_Magenta<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_Gray<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }
    public static void WriteLine_DarkGray<T>(ref T value)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(value);
        Console.ResetColor();
        Console.Write(Environment.NewLine);
    }


    ///
    /// XML => CONSOLE 
    ///
    public static void ConsOut_Red(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_Blue(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_Cyan(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_DarkBlue(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_DarkCyan(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_DarkGray(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_DarkGreen(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_DarkMagenta(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_DarkRed(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_DarkYellow(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_Gray(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_Green(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_Magenta(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_White(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.White;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
    public static void ConsOut_Yellow(XmlDocument xml)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        xml.Save(Console.Out); 
        Console.WriteLine(Environment.NewLine);
        Console.ResetColor();
    }
}


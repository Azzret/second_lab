using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace _43_TextToHTML
{
    class Main1
    {
        void Main()
        {
            Builder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
        }
        internal  string HTML_RGBHex(byte R, byte G, byte B)
        {

            Object HexR, HexB, HexG = new Object();

            //Красный
            HexR = string.Format("{0:X}", R);
            if (HexR.ToString().Length < 2) { HexR = "0" + HexR; }

            //Зеленый
            HexG = string.Format("{0:X}", G);
            if (HexG.ToString().Length < 2) { HexG = "0" + HexG; }

            //Голубой
            HexB = string.Format("{0:X}", B);
            if (HexB.ToString().Length < 2) { HexB = "0" + HexB; }

            return "#" + HexR + HexG + HexB;
        }
        internal string BuildPartC(RichTextBox Rtb)
        {
            // ---------------------------------- '' Инициализация переменных '' -----------------------------------
            int Spam = 0;

            byte R, G, B;

            string BackColorNow = "";//Текущий фоновый цвет
            string BackColorPrevios = "";//Предыдущий фоновый цвет

            string ColorNow = "";//Текущий цвет
            string ColorPrevios = "";//Предыдущий цвет

            string FontNow = "";//Текущий шрифт
            string FontPrevios = "";//Предыдущий шрифт

            float SizeNow = 0;//Текущий размер
            float SizePrevios = 0;//Предыдущий размер


            System.Drawing.FontStyle EstiloAtual = 0;
            System.Drawing.FontStyle EstiloAnterior = 0;

            string Texto;
            //-----------------------------------------------------------------------------------------

            Texto = "Paragraph in Markdown";

            for (int Cont = 0; Cont <= Rtb.Text.Length - 1; Cont++)
            {

                // Выбрать
                Rtb.Select(Cont, 1);

                if (Rtb.SelectedText == "\n")
                {
                    Texto += "<br>";
                }
                else
                    if (Rtb.SelectedText != "")
                {

                    // -------------------------'' Выбор значений ''---------------------------
                    //цвет шрифта
                    R = Rtb.SelectionColor.R;
                    G = Rtb.SelectionColor.G;
                    B = Rtb.SelectionColor.B;
                    ColorNow = HTML_RGBHex(R, G, B);

                    // для цвета фона''
                    R = Rtb.SelectionBackColor.R;
                    G = Rtb.SelectionBackColor.G;
                    B = Rtb.SelectionBackColor.B;
                    BackColorNow = HTML_RGBHex(R, G, B);

                    FontNow = Rtb.SelectionFont.Name;
                    SizeNow = Rtb.SelectionFont.Size;
                    EstiloAtual = Rtb.SelectionFont.Style;

                    // -------------------'' Перенос кода в html''---------------------


                    // Цвет ''--------------------------------------------------------------
                    if (ColorNow != ColorPrevios)
                    {
                        Texto += "Color:" + ColorNow;
                        Spam += 1;
                    }

                    // Цвет фона ''-------------------------------------------------
                    if (BackColorNow != BackColorPrevios)
                    {
                        Texto += "Background-color:" + BackColorNow;
                        Spam += 1;
                    }

                    // Шрифт ''---------------------------------------------------------------
                    if (FontNow != FontPrevios)
                    {
                        Texto += "Font: " + FontNow;
                        Spam += 1;
                    }

                    // Размер шрифта ''---------------------------------------------------------------
                    if (SizeNow != SizePrevios)
                    {
                        Texto += "Font-size:" + SizeNow;
                        Spam += 1;
                    }

                    // Стиль текста ''-------------------------------------------------------
                    switch (EstiloAtual)
                    {
                        case System.Drawing.FontStyle.Bold:
                            Texto += "**rendered as bold text**" + Rtb.SelectedText;
                            break;

                        case System.Drawing.FontStyle.Italic:
                            Texto += "_rendered as italicized text_" + Rtb.SelectedText;
                            break;

                        case System.Drawing.FontStyle.Underline:
                            Texto += "*" + Rtb.SelectedText;
                            break;

                        case System.Drawing.FontStyle.Strikeout:
                            Texto += "~~Strike through this text.~~" + Rtb.SelectedText;
                            break;

                        default:
                            // Поместить текст
                            Texto += Rtb.SelectedText;
                            break;

                    }

                    // -------------------------'' Подать прошлые переменные ''---------------------------
                    SizePrevios = SizeNow;
                    FontPrevios = FontNow;
                    ColorPrevios = ColorNow;
                    BackColorPrevios = BackColorNow;
                    EstiloAnterior = EstiloAtual;
                }
            }

            // Закрыть span
            for (int cont = 1; cont <= Spam; cont++)
            {
                Texto += "Paragraph in span";
            }

            // Закрыть div
            Texto += "Paragraph in Markdown";

            return Texto;
        }
        internal string BuildPartA(RichTextBox Rtb)
        {
            // ---------------------------------- '' Инициализация переменных '' -----------------------------------
            int Spam = 0;

            byte R, G, B;

            string BackColorNow = "";//Текущий фоновый цвет
            string BackColorPrevios = "";//Предыдущий фоновый цвет

            string ColorNow = "";//Текущий цвет
            string ColorPrevios = "";//Предыдущий цвет

            string FontNow = "";//Текущий шрифт
            string FontPrevios = "";//Предыдущий шрифт

            float SizeNow = 0;//Текущий размер
            float SizePrevios = 0;//Предыдущий размер


            System.Drawing.FontStyle EstiloAtual = 0;
            System.Drawing.FontStyle EstiloAnterior = 0;

            string Texto;
            //-----------------------------------------------------------------------------------------

            Texto = "<div>";

            for (int Cont = 0; Cont <= Rtb.Text.Length - 1; Cont++)
            {

                // Выбрать
                Rtb.Select(Cont, 1);

                if (Rtb.SelectedText == "\n")
                {
                    Texto += "<br>";
                }
                else
                    if (Rtb.SelectedText != "")
                {

                    // -------------------------'' Выбор значений ''---------------------------
                    //цвет шрифта
                    R = Rtb.SelectionColor.R;
                    G = Rtb.SelectionColor.G;
                    B = Rtb.SelectionColor.B;
                    ColorNow = HTML_RGBHex(R, G, B);

                    // для цвета фона''
                    R = Rtb.SelectionBackColor.R;
                    G = Rtb.SelectionBackColor.G;
                    B = Rtb.SelectionBackColor.B;
                    BackColorNow = HTML_RGBHex(R, G, B);

                    FontNow = Rtb.SelectionFont.Name;
                    SizeNow = Rtb.SelectionFont.Size;
                    EstiloAtual = Rtb.SelectionFont.Style;

                    // -------------------'' Перенос кода в html''---------------------


                    // Цвет ''--------------------------------------------------------------
                    if (ColorNow != ColorPrevios)
                    {
                        Texto += "<span style=color:" + ColorNow + ">";
                        Spam += 1;
                    }

                    // Цвет фона ''-------------------------------------------------
                    if (BackColorNow != BackColorPrevios)
                    {
                        Texto += "<span style=background-color:" + BackColorNow + ">";
                        Spam += 1;
                    }

                    // Шрифт ''---------------------------------------------------------------
                    if (FontNow != FontPrevios)
                    {
                        Texto += "<span style=font:" + FontNow + ">";
                        Spam += 1;
                    }

                    // Размер шрифта ''---------------------------------------------------------------
                    if (SizeNow != SizePrevios)
                    {
                        Texto += "<span style=font-size:" + SizeNow + "px>";
                        Spam += 1;
                    }

                    // Стиль текста ''-------------------------------------------------------
                    switch (EstiloAtual)
                    {
                        case System.Drawing.FontStyle.Bold:
                            Texto += "<strong>" + Rtb.SelectedText + "</strong>";
                            break;

                        case System.Drawing.FontStyle.Italic:
                            Texto += "<em>" + Rtb.SelectedText + "</em>";
                            break;

                        case System.Drawing.FontStyle.Underline:
                            Texto += "<u>" + Rtb.SelectedText + "</u>";
                            break;

                        case System.Drawing.FontStyle.Strikeout:
                            Texto += "<strike>" + Rtb.SelectedText + "</strike>";
                            break;

                        default:
                            // Поместить текст
                            Texto += Rtb.SelectedText;
                            break;

                    }

                    // -------------------------'' Подать прошлые переменные ''---------------------------
                    SizePrevios = SizeNow;
                    FontPrevios = FontNow;
                    ColorPrevios = ColorNow;
                    BackColorPrevios = BackColorNow;
                    EstiloAnterior = EstiloAtual;
                }
            }

            // Закрыть span
            for (int cont = 1; cont <= Spam; cont++)
            {
                Texto += "</span>";
            }

            // Закрыть div
            Texto += "</div>";

            return Texto;
            throw new NotImplementedException();
        }
    }
  

 



}

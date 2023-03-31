using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _4лаба_Андреева
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void ReplaceTextOfButton(Button b, TextBox t)
        {
            b.Text = t.Text;
        }

        public static void RefreshColor(Button b, TextBox t)
        {
            Dictionary<string, Color> colors = new Dictionary<string, Color>() {
                { "красный", Color.Red },
                { "оранжевый", Color.Orange },
                {"желтый", Color.Yellow },
                {"зеленый", Color.Green },
                {"синий", Color.Blue },
                {"голубой", Color.SkyBlue },
                {"фиолетовый", Color.Purple }
            };

            string color = t.Text.ToLower().Trim();

            if (colors.ContainsKey(color))
            {
                b.BackColor = colors[color];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _2gzsdanie3
{
    internal class Program
    {
        static void Main()
        {
            int number, delenie;
            number = Int32.Parse(
                Interaction.InputBox(
                    "Введите целое число:")
                );
            delenie = number / 4;
            string txt = "Число " + number + "";
            bool nemenshe = delenie < 10;
            txt += (nemenshe == false ? " число деленная на 4 и больше 10" : " число меньше 10");
            MessageBox.Show(txt);
        }
    }
}

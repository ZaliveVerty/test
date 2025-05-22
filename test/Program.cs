using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Media;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "#FFFFFF#EAEAE9#EAEBEA#C4C4C4#C3C3C3#C2C2C2#BDBDBD#F4F5F5#E1E2E2#E3E3E2#E5E4E5#E2E3E2#EBECEB#F4F5F5#F4F4F4#E6E6E7#C2C3C2#D5D6D6#D2D2D3#D5D4D5#D2D3D2#D0CED0#CDCDCD#DDDDDD#C8C7C8#CBCCCB#EEEFEE#E4E5E4";
            string[] token = text.Split('#');

            int b = 0;
            for (int i = 0; i < token.Length; i++) {
                Color color = (Color)ColorConverter.ConvertFromString(" #" + token[i]);
                Debug.WriteLine(b + " #" + token[i]);
                b++;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTi_cryptage_BeaujeanNathan
{
    public class MethodesDeProjet
    {
        public static void CryptVignere(string phClaire, string clef, out string[,] matVigenere)
        {
            if (phClaire == null) phClaire = "";
            if (clef == null || clef.Length == 0) clef = "A";

            phClaire = phClaire.ToUpper();
            clef = clef.ToUpper();

            matVigenere = new string[4, phClaire.Length];
            int iClef = 0;
            int codeAscii;
            for (int iClair = 0; iClair < phClaire.Length; iClair++)
            {
                char plain = phClaire[iClair];
                if (iClef == clef.Length)
                {
                    iClef = 0;
                }
                char keyChar = clef[iClef];

                matVigenere[0, iClair] = plain.ToString();
                matVigenere[1, iClair] = keyChar.ToString();

                int shift = (int)keyChar - 65;              // A->0, B->1, ...
                if (shift < 0) shift = 0;
                matVigenere[2, iClair] = shift.ToString();  // stocke le décalage en string

                codeAscii = (int)plain + shift;
                if (codeAscii > 90) codeAscii -= 26;       // wrap si dépasse 'Z'

                matVigenere[3, iClair] = ((char)codeAscii).ToString();

                iClef += 1;
            }
        }

        public static void cryptAffine(string phClaire, int a, int b, out string[,] matAffine)
        {
            if (phClaire == null) phClaire = "";
            phClaire = phClaire.ToUpper();

            matAffine = new string[4, phClaire.Length];
            for (int iClair = 0; iClair < phClaire.Length; iClair++)
            {
                char plain = phClaire[iClair];
                matAffine[0, iClair] = plain.ToString();

                int x = ((int)plain - 65);
                if (x < 0) x = 0;
                matAffine[1, iClair] = x.ToString();

                int y = (a * x + b) % 26;
                if (y < 0) y += 26;
                matAffine[2, iClair] = y.ToString();

                matAffine[3, iClair] = ((char)(y + 65)).ToString();
            }
        }
    }
}

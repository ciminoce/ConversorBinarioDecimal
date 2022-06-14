using System;

namespace ConversorBinarioDecimal
{
    public static class Conversor
    {
        public static long ConvertirDecimalBinario(int numero)
        {
            int digitoBinario = 1;
            int nroBinario = 0;
            while (numero>=1)
            {
                if (numero % 2==1)
                {
                    nroBinario = digitoBinario;
                }

                numero /= 2;
                digitoBinario *= 10;
            }

            return nroBinario;
        }

        public static int ConvertirBinarioDecimal(int numero)
        {
            int nroDecimal=0;
            int posicion = 0;
            int digitoBinario=0;
            while (numero>0)
            {
                digitoBinario = numero % 10;
                nroDecimal=nroDecimal+ (digitoBinario *(int) Math.Pow(2,posicion));
                numero = numero / 10;
                posicion++;
            }

            return nroDecimal;
        }
    }
}

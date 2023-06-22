using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int RomanToInt(string s)
    {
        var simbolos = s.ToCharArray();
        int valor = 0;

        for (int i = 0; i < simbolos.Length; i++)
        {
            var simboloAtual = simbolos[i];

            if (i < simbolos.Length - 1)
            {
                var proximoSimbolo = simbolos[i + 1];

                if (TraduzirAlgoritmo(simboloAtual) < TraduzirAlgoritmo(proximoSimbolo))
                {
                    valor += TraduzirAlgoritmo(proximoSimbolo) - TraduzirAlgoritmo(simboloAtual);
                    i++;
                    continue;
                }
            }

            valor += TraduzirAlgoritmo(simboloAtual);
        }

        return valor;
    }

    public int TraduzirAlgoritmo(char Simbolo)
    {
        switch (Simbolo)
        {
            case 'I':
                return 1;

            case 'V':
                return 5;

            case 'X':
                return 10;

            case 'L':
                return 50;

            case 'C':
                return 100;

            case 'D':
                return 500;

            case 'M':
                return 1000;

            default:
                return 0;
        }
    }
}

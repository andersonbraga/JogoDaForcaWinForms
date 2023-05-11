using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaForca.WinFormsApp
{
    public  class Forca
    {

        public string currentWord = "";
        public string palavraSecreta { get; set; }
        public  char[] letrasEncontradas { get; set; }  
        private int erros { get; set; }
        public string mensagemFinal { get; set; }

        public bool JogadorPerdeu()
        {
            return erros == 5;
        }

        public Forca()
        {
         
            palavraSecreta = ObterPalavraSecreta();
            letrasEncontradas = PopularLetrasEncontradas(palavraSecreta.Length);

            erros = 0;
        }


        private char[] PopularLetrasEncontradas(int tamanho)
        {
            char[] letrasEncontradas = new char[tamanho];

            for (int carectere = 0; carectere < letrasEncontradas.Length; carectere++)
                letrasEncontradas[carectere] = '_';

            return letrasEncontradas;
        }

        public string ObterPalavraSecreta()
        {
            string[] palavras = {
                "ABACATE",
                "ABACAXI",
                "ACEROLA",
                "ACAI",
                "ARACA",
                "ABACATE",
                "BACABA",
                "BACURI",
                "BANANA",
                "CAJA",
                "CAJU",
                "CARAMBOLA",
                "CUPUACU",
                "GRAVIOLA",
                "GOIABA",
                "JABUTICABA",
                "JENIPAPO",
                "MACA",
                "MANGABA",
                "MANGA",
                "MARACUJA",
                "MURICI",
                "PEQUI",
                "PITANGA",
                "PITAYA",
                "SAPOTI",
                "TANGERINA",
                "UMBU",
                "UVA",
                "UVAIA"
            };

            int indiceAleatorio = new Random().Next(palavras.Length);

            return palavras[indiceAleatorio];
        }

        public bool JogadorAcertou(char palpite)
        {
            bool letraFoiEncontrada = false;

            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (palpite == palavraSecreta[i])
                {
                    letrasEncontradas[i] = palpite;
                    letraFoiEncontrada = true;
                }
            }

            if (letraFoiEncontrada == false)
                erros++;

            bool jogadorAcertou = new string(letrasEncontradas) == palavraSecreta;

            if (jogadorAcertou)
                mensagemFinal = $"Você acertou a palavra {palavraSecreta}, parabéns!";

            else if (JogadorPerdeu())
                mensagemFinal = "Você perdeu! Tente novamente...";

            return jogadorAcertou;
        }

        public void ApresentarMensagem(string mensagem)
        {
            Console.WriteLine();
            Console.WriteLine(mensagem);
        }






    }
}

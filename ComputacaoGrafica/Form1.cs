using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ComputacaoGrafica
{
    public partial class Form1 : Form
    {
        Bitmap areaDesenho;
        Color corPreenche;

        public Form1()
        {
            InitializeComponent();

            areaDesenho = new Bitmap(imagem.Size.Width, imagem.Size.Height);
            corPreenche = Color.Black;
        }

        int[,] Resultado = new int[3, 3];
        double[,] ResultRotacao = new double[3, 3];
        int[,] MatrizTranslacao = new int[3, 3] { { 1, 0, 9999 }, { 0, 1, 9999 }, { 0, 0, 1 } };
        int[,] MatrizEscala = new int[3, 3] { { 9999, 0, 0 }, { 0, 9999, 0 }, { 0, 0, 1 } };
        int[,] MatrizReflexaoX = new int[3, 3] { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
        int[,] MatrizReflexaoY = new int[3, 3] { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
        int[,] MatrizReflexaoOrigem = new int[3, 3] { { -1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };
        int[,] MatrizCisalhamentoVertical = new int[3, 3] { { 1, 0, 0 }, { 9999, 1, 0 }, { 0, 0, 1 } };
        int[,] MatrizCisalhamentoHorizontal = new int[3, 3] { { 1, 9999, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
        double[,] MatrizRotacao = new double[3, 3] { { 9999, 8888, 0 }, { 8888, 9999, 0 }, { 0, 0, 1 } };

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (x1.Text == "" || y1.Text == "" || anguloText.Text == "" || x2.Text == "" || y2.Text == "" || forceText.Text == "")
            {
                MessageBox.Show("Favor informar todos os campos !");
                return;
            }

            int[,] Coef = new int[3, 1];
            Coef[0, 0] = int.Parse(x1.Text);
            Coef[1, 0] = int.Parse(y1.Text);
            Coef[2, 0] = 1;

            //Esta dando erro nessa conversão ao executar o codigo
            double cos = Math.Cos(Double.Parse(anguloText.Text));
            double sen = Math.Sin(Convert.ToDouble(anguloText.Text));

            int T1 = Convert.ToInt32(x2.Text);
            int T2 = Convert.ToInt32(y2.Text);
            int F = Convert.ToInt32(forceText.Text);

            areaDesenho.SetPixel(int.Parse(x1.Text), int.Parse(y1.Text), corPreenche);
            areaDesenho.SetPixel(int.Parse(x2.Text), int.Parse(y2.Text), corPreenche);

            switch (Metodo.Text.ToString())
            {
                case "Translação":
                    Resultado = Translacao(MatrizTranslacao, Coef, T1, T2);
                    ApresentarResultado(Resultado);
                    break;
                case "Escala":
                    Resultado = Escala(MatrizEscala, Coef, T1, T2);
                    ApresentarResultado(Resultado);
                    break;
                case "Rotação":
                    ResultRotacao = Rotacao(MatrizRotacao, Coef, sen, cos);
                    ApresentarResultado(ResultRotacao);
                    break;
                case "Reflexão(Eixo X)":
                    Resultado = ReflexaoX(MatrizReflexaoX, Coef);
                    ApresentarResultado(Resultado);
                    break;
                case "Reflexão(Eixo Y)":
                    Resultado = ReflexaoY(MatrizReflexaoY, Coef);
                    ApresentarResultado(Resultado);
                    break;
                case "Reflexão(Origem)":
                    Resultado = ReflexaoOrigem(MatrizReflexaoOrigem, Coef);
                    ApresentarResultado(Resultado);
                    break;
                case "Cisalhamento Vertical":
                    Resultado = CisalhamentoVertical(MatrizCisalhamentoVertical, Coef, F);
                    ApresentarResultado(Resultado);
                    break;
                case "Cisalhamento Horizontal":
                    Resultado = CisalhamentoHorizontal(MatrizCisalhamentoHorizontal, Coef, F);
                    ApresentarResultado(Resultado);
                    break;
                default:
                    break;
            }

        }

        public static int[,] Translacao(int[,] A, int[,] Coef, int T1, int T2)
        {
            int[,] C = new int[3, 1];

            A[0, 2] = T1;
            A[1, 2] = T2;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * Coef[k, j];
                    }

            return C;
        }

        public static int[,] Escala(int[,] A, int[,] Coef, int T1, int T2)
        {
            int[,] C = new int[3, 1];

            A[0, 0] = T1;
            A[1, 1] = T2;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * Coef[k, j];
                    }

            return C;
        }

        public static double[,] Rotacao(double[,] A, int[,] Coef, double seno, double cosseno)
        {
            double[,] C = new double[3, 1];

            A[0, 0] = cosseno;
            A[0, 1] = seno * (-1);
            A[1, 0] = seno;
            A[1, 1] = cosseno;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                        C[i, j] += A[i, k] * Convert.ToDouble(Coef[k, j]);

            return C;
        }

        public static int[,] ReflexaoX(int[,] A, int[,] Coef)
        {
            int[,] C = new int[3, 1];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * Coef[k, j];
                    }

            return C;
        }

        public static int[,] ReflexaoY(int[,] A, int[,] Coef)
        {
            int[,] C = new int[3, 1];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * Coef[k, j];
                    }

            return C;
        }

        public static int[,] ReflexaoOrigem(int[,] A, int[,] Coef)
        {
            int[,] C = new int[3, 1];

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * Coef[k, j];
                    }

            return C;
        }

        public static int[,] CisalhamentoVertical(int[,] A, int[,] Coef, int F)
        {
            int[,] C = new int[3, 1];

            A[0, 1] = F;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * Coef[k, j];
                    }

            return C;
        }

        public static int[,] CisalhamentoHorizontal(int[,] A, int[,] Coef, int F)
        {
            int[,] C = new int[3, 1];

            A[1, 0] = F;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 1; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        C[i, j] += A[i, k] * Coef[k, j];
                    }

            return C;
        }

        //Falta implementar a função para apresentar o resultado na labelResultado
        public void ApresentarResultado(int[,] Result)
        {
            //string resultado = "";

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        resultado += String.Format(@"[{0},{1}] {2}"
            //                                    , i
            //                                    , j
            //                                    , Result[i, j]);
            //        resultado += "\n";

            //        areaDesenho.SetPixel(i, j, corPreenche);
            //    }
            //}

            areaDesenho.SetPixel(Result[0, 0], Result[1, 0], corPreenche);

            //labelResultado.Text = resultado;

            //areaDesenho.SetPixel(x, y, corPreenche);
            imagem.Image = areaDesenho;

        }

        public void ApresentarResultado(double[,] Result)
        {
            //A impresão da função de rotação recebe double por causa das operaçoes com seno e cosseno
        }

    }
}

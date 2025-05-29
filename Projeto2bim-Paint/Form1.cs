using global::System;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using global::System.Windows.Forms;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Threading.Tasks.Sources;
using System.Runtime.ConstrainedExecution;

namespace Projeto2bim_Paint
{
    public partial class Form1 : Form
    {
        int[] reta = new int[4];
        int[] triangulo = new int[6];
        int[] retangulo = new int[4];
        int[] losangulo = new int[8];
        int[] pentagono = new int[10];

        int[] elipse = new int[4];
        int[] circulo = new int[3];

        Dictionary<string, List<(int[] posicoes, Pen caneta)>> formas = new();

        public Form1()
        {
            InitializeComponent();

            IniciarContornos();
            IniciarTamanhos();

            panel_cor_principal.BackColor = Color.LightGray;

            formas["Retangulos"] = new List<(int[], Pen)>();
            formas["Losangulos"] = new List<(int[], Pen)>();
            formas["Circulos"] = new List<(int[], Pen)>();
            formas["Retas"] = new List<(int[], Pen)>();
            formas["Elipses"] = new List<(int[], Pen)>();
            formas["Pentagonos"] = new List<(int[], Pen)>();
            formas["Triangulos"] = new List<(int[], Pen)>();

            cbbox_preenchimento.Enabled = false;

        }

        void IniciarTamanhos()
        {
            cbbox_tamanho.Items.Add("Tamanho");
            cbbox_tamanho.Items.Add("1");
            cbbox_tamanho.Items.Add("2");
            cbbox_tamanho.Items.Add("3");
            cbbox_tamanho.Items.Add("4");
            cbbox_tamanho.Items.Add("5");

            cbbox_tamanho.SelectedIndex = 0;
        }

        void IniciarContornos()
        {
            cbbox_contorno.Items.Add("Contorno");
            cbbox_contorno.Items.Add("Linha Sólida");
            cbbox_contorno.Items.Add("Linha Tracejada");
            cbbox_contorno.Items.Add("Linha Traço Ponto");
            cbbox_contorno.Items.Add("Linha Traço dois pontos");
            cbbox_contorno.Items.Add("Linha Pontilhada");

            cbbox_contorno.SelectedIndex = 0;
        }

        //PRIMITIVAS ---------------------------------------------------------------------
        Color Cor_primitiva(int red = 0, int green = 0, int blue = 0)
        {
            return Color.FromArgb(red, green, blue);
        }

        Pen caneta_estilo(int espessura, Color cor, float[] estilo = null)
        {
            Pen caneta = new Pen(cor, espessura);
            caneta.DashPattern = estilo;
            return caneta;
        }

        void DesenharElipse(PaintEventArgs e, Pen caneta)
        {
            e.Graphics.DrawEllipse(caneta, elipse[0], elipse[1], elipse[2], elipse[3]);
        }

        void DesenharCirculo(PaintEventArgs e, Pen caneta)
        {
            e.Graphics.DrawEllipse(caneta, circulo[0], circulo[1], circulo[2] * 2, circulo[2] * 2);
        }

        void DesenharReta(int x0, int y0, int x1, int y1, Pen caneta, PaintEventArgs e)
        {
            e.Graphics.DrawLine(caneta, x0, y0, x1, y1);
        }

        void DesenharRetangulo(PaintEventArgs e, int x0, int y0, int x1, int y1, Pen caneta)
        {
            DesenharReta(x0, y0, x1, y0, caneta, e);
            DesenharReta(x1, y0, x1, y1, caneta, e);
            DesenharReta(x1, y1, x0, y1, caneta, e);
            DesenharReta(x0, y1, x0, y0, caneta, e);
        }

        void DesenharLosangulo(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            for (int i = 0; i < 5; i += 2)
            {
                DesenharReta(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            DesenharReta(pontos[6], pontos[7], pontos[0], pontos[1], caneta, e);
        }

        void DesenharPentagono(PaintEventArgs e, int[] pontos, Pen caneta)
        {
            for (int i = 0; i < 7; i += 2)
            {
                DesenharReta(pontos[i], pontos[i + 1], pontos[i + 2], pontos[i + 3], caneta, e);
            }
            DesenharReta(pontos[8], pontos[9], pontos[0], pontos[1], caneta, e);
        }

        void DesenharTriangulo(PaintEventArgs e, int x0, int y0, int x1, int y1, int x2, int y2, Pen caneta)
        {
            DesenharReta(x0, y0, x1, y1, caneta, e);
            DesenharReta(x1, y1, x2, y2, caneta, e);
            DesenharReta(x2, y2, x0, y0, caneta, e);
        }

        void DesenharTudo(PaintEventArgs e)
        {
            foreach (var (pos, pen) in formas["Retas"])
                DesenharReta(pos[0], pos[1], pos[2], pos[3], pen, e);

            foreach (var (pos, pen) in formas["Triangulos"])
                DesenharTriangulo(e, pos[0], pos[1], pos[2], pos[3], pos[4], pos[5], pen);

            foreach (var (pos, pen) in formas["Retangulos"])
                DesenharRetangulo(e, pos[0], pos[1], pos[2], pos[3], pen);

            foreach (var (pos, pen) in formas["Elipses"])
                e.Graphics.DrawEllipse(pen, pos[0], pos[1], pos[2], pos[3]);

            foreach (var (pos, pen) in formas["Circulos"])
                e.Graphics.DrawEllipse(pen, pos[0], pos[1], pos[2] * 2, pos[2] * 2);

            foreach (var (pos, pen) in formas["Losangulos"])
                DesenharLosangulo(e, pos, pen);

            foreach (var (pos, pen) in formas["Pentagonos"])
                DesenharPentagono(e, pos, pen);

        }

        //--------------------------------------------------------------------------------


        //CORES-----------------------------------------------------------------------------------
        void TrocaCorButton(Color cor, object sender, EventArgs e)
        {
            if (panel_cor_principal.BackColor == Color.LightGray)
            {
                btn_cor_selecionada.BackColor = cor;
                btn_cor_selecionada_Click(sender, e);
            }
            else if (panel_cor_sec.BackColor == Color.LightGray)
            {
                btn_cor_secundaria.BackColor = cor;
                btn_cor_secundaria_Click(sender, e);
            }
        }

        private void btn_preto_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_preto.BackColor, sender, e);
        }

        private void btn_branco_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_branco.BackColor, sender, e);
        }

        private void btn_cinza_escuro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_cinza_escuro.BackColor, sender, e);
        }

        private void btn_cinza_claro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_cinza_claro.BackColor, sender, e);
        }

        private void btn_vinho_escuro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_vinho_escuro.BackColor, sender, e);
        }

        private void btn_marrom_claro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_marrom_claro.BackColor, sender, e);
        }

        private void btn_vermelho_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_vermelho.BackColor, sender, e);
        }

        private void btn_rosa_claro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_rosa_claro.BackColor, sender, e);
        }

        private void btn_laranja_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_laranja.BackColor, sender, e);
        }

        private void btn_amarelo_alaranjado_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_amarelo_alaranjado.BackColor, sender, e);
        }

        private void btn_amarelo_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_amarelo.BackColor, sender, e);
        }

        private void btn_bege_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_bege.BackColor, sender, e);
        }

        private void btn_verde_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_verde.BackColor, sender, e);
        }

        private void btn_verde_limao_claro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_verde_limao_claro.BackColor, sender, e);
        }

        private void btn_azul_claro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_azul_claro.BackColor, sender, e);
        }

        private void btn_azul_pastel_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_azul_pastel.BackColor, sender, e);
        }

        private void btn_azul_escuro_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_azul_escuro.BackColor, sender, e);
        }

        private void btn_azul_acizentado_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_azul_acizentado.BackColor, sender, e);
        }

        private void btn_roxo_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_roxo.BackColor, sender, e);
        }

        private void btn_lilas_Click(object sender, EventArgs e)
        {
            TrocaCorButton(btn_lilas.BackColor, sender, e);
        }

        private void btn_cor_selecionada_Click(object sender, EventArgs e)
        {
            panel_cor_principal.BackColor = Color.LightGray;
            if (panel_cor_sec.BackColor == Color.LightGray)
            {
                panel_cor_sec.BackColor = Color.Transparent;
            }
        }

        private void btn_cor_secundaria_Click(object sender, EventArgs e)
        {
            panel_cor_sec.BackColor = Color.LightGray;
            if (panel_cor_principal.BackColor == Color.LightGray)
            {
                panel_cor_principal.BackColor = Color.Transparent;
            }
        }
        //----------------------------------------------------------------------------------------


        void DesativarCorFormas(Button btn)
        {
            foreach (Control ctrl in panel_formas.Controls)
            {
                if (ctrl is Button b)
                {
                    if (b == btn)
                        b.BackColor = Color.LightGray;
                    else
                        b.BackColor = Color.White;
                }
            }
        }

        private void btn_reta_Click(object sender, EventArgs e)
        {
            DesativarCorFormas(btn_reta);
            ZerarArrays();
        }

        private void btn_square_Click(object sender, EventArgs e)
        {
            DesativarCorFormas(btn_square);
            ZerarArrays();
        }

        private void btn_circle_Click(object sender, EventArgs e)
        {
            DesativarCorFormas(btn_circle);
            ZerarArrays();
        }

        private void btn_pentagono_Click(object sender, EventArgs e)
        {
            DesativarCorFormas(btn_pentagono);
            ZerarArrays();
        }

        private void btn_triangulo_Click(object sender, EventArgs e)
        {
            DesativarCorFormas(btn_triangulo);
            ZerarArrays();
        }

        private void btn_losangulo_Click(object sender, EventArgs e)
        {
            DesativarCorFormas(btn_losangulo);
            ZerarArrays();
        }

        private void btn_elipse_Click(object sender, EventArgs e)
        {
            DesativarCorFormas(btn_elipse);
            ZerarArrays();
        }

        Color verificarCor()
        {
            if (panel_cor_principal.BackColor == Color.LightGray) return Cor_primitiva(btn_cor_selecionada.BackColor.R, btn_cor_selecionada.BackColor.G, btn_cor_selecionada.BackColor.B);
            else if (panel_cor_sec.BackColor == Color.LightGray) return Cor_primitiva(btn_cor_secundaria.BackColor.R, btn_cor_secundaria.BackColor.G, btn_cor_secundaria.BackColor.B);
            return Color.Empty;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (btn_elipse.BackColor == Color.LightGray)
            {
                string alturaStr = Interaction.InputBox("Digite a altura da elipse:", "Altura da Elipse", "Digite aqui...");
                int altura;

                if (!string.IsNullOrEmpty(alturaStr) && int.TryParse(alturaStr, out altura))
                {
                    string larguraStr = Interaction.InputBox("Digite a largura da elipse:", "Largura da Elipse", "Digite aqui...");
                    int largura;

                    if (!string.IsNullOrEmpty(larguraStr) && int.TryParse(larguraStr, out largura))
                    {
                        elipse[0] = e.X; elipse[1] = e.Y;
                        elipse[2] = largura; elipse[3] = altura;
                        Color cor = verificarCor();
                        if (cor != Color.Empty)
                        {
                            formas["Elipses"].Add((elipse.ToArray(), caneta_estilo(setTamanho(), cor, setStyle())));
                            ZerarArrays();
                            Invalidate();
                        }
                    }
                }
            }
            else if (btn_circle.BackColor == Color.LightGray)
            {
                string raioStr = Interaction.InputBox("Digite o raio do círculo:", "Raio do Círculo", "Digite aqui...");
                int raio;

                if (!string.IsNullOrEmpty(raioStr) && int.TryParse(raioStr, out raio))
                {
                    circulo[0] = e.X; circulo[1] = e.Y;
                    circulo[2] = raio;
                    Color cor = verificarCor();
                    if (cor != Color.Empty)
                    {
                        formas["Circulos"].Add((circulo.ToArray(), caneta_estilo(setTamanho(), cor, setStyle())));
                        ZerarArrays();
                        Invalidate();
                    }
                }
            }
            else if (btn_reta.BackColor == Color.LightGray)
            {
                for (int i = 0; i <= reta.Length - 1; i += 2)
                {
                    if (reta[i] == 0)
                    {
                        reta[i] = e.X; reta[i + 1] = e.Y;
                        break;
                    }
                }
                if (reta[3] != 0)
                {
                    Color cor = verificarCor();
                    if (cor != Color.Empty)
                    {
                        formas["Retas"].Add((reta.ToArray(), caneta_estilo(setTamanho(), cor, setStyle())));
                        ZerarArrays();
                        Invalidate();
                    }
                }
            }
            else if (btn_square.BackColor == Color.LightGray)
            {
                for (int i = 0; i <= retangulo.Length - 1; i += 2)
                {
                    if (retangulo[i] == 0)
                    {
                        retangulo[i] = e.X; retangulo[i + 1] = e.Y;
                        break;
                    }
                }
                if (retangulo[3] != 0)
                {
                    Color cor = verificarCor();
                    if (cor != Color.Empty)
                    {
                        formas["Retangulos"].Add((retangulo.ToArray(), caneta_estilo(setTamanho(), cor, setStyle())));
                        ZerarArrays();
                        Invalidate();
                    }
                }
            }
            else if (btn_pentagono.BackColor == Color.LightGray)
            {
                for (int i = 0; i <= pentagono.Length - 1; i += 2)
                {
                    if (pentagono[i] == 0)
                    {
                        pentagono[i] = e.X; pentagono[i + 1] = e.Y;
                        break;
                    }
                }
                if (pentagono[9] != 0)
                {
                    Color cor = verificarCor();
                    if (cor != Color.Empty)
                    {
                        formas["Pentagonos"].Add((pentagono.ToArray(), caneta_estilo(setTamanho(), cor, setStyle())));
                        ZerarArrays();
                        Invalidate();
                    }
                }
            }
            else if (btn_triangulo.BackColor == Color.LightGray)
            {
                for (int i = 0; i <= triangulo.Length - 1; i += 2)
                {
                    if (triangulo[i] == 0)
                    {
                        triangulo[i] = e.X; triangulo[i + 1] = e.Y;
                        break;
                    }
                }
                if (triangulo[5] != 0)
                {
                    Color cor = verificarCor();
                    if (cor != Color.Empty)
                    {
                        formas["Triangulos"].Add((triangulo.ToArray(), caneta_estilo(setTamanho(), cor, setStyle())));
                        ZerarArrays();
                        Invalidate();
                    }
                }
            }
            else if (btn_losangulo.BackColor == Color.LightGray)
            {
                for (int i = 0; i <= losangulo.Length - 1; i += 2)
                {
                    if (losangulo[i] == 0)
                    {
                        losangulo[i] = e.X; losangulo[i + 1] = e.Y;
                        break;
                    }
                }
                if (losangulo[7] != 0)
                {
                    Color cor = verificarCor();
                    if (cor != Color.Empty)
                    {
                        formas["Losangulos"].Add((losangulo.ToArray(), caneta_estilo(setTamanho(), cor, setStyle())));
                        ZerarArrays();
                        Invalidate();
                    }
                }
            }
        }
        float[] setStyle()
        {
            if (cbbox_contorno.SelectedIndex == 1)
            {
                return new float[] { 1f };
            }
            else if (cbbox_contorno.SelectedIndex == 2)
            {
                return new float[] { 4f, 2f };
            }
            else if (cbbox_contorno.SelectedIndex == 3)
            {
                return new float[] { 4f, 2f, 1f, 2f };
            }
            else if (cbbox_contorno.SelectedIndex == 4)
            {
                return new float[] { 4f, 2f, 1f, 2f, 1f, 2f };
            }
            else if (cbbox_contorno.SelectedIndex == 5)
            {
                return new float[] { 1f, 2f };
            }
            else
            {
                return new float[] { 1f };
            }
        }

        int setTamanho()
        {
            if (cbbox_tamanho.SelectedIndex == 1)
            {
                return 1;
            }
            else if (cbbox_tamanho.SelectedIndex == 2)
            {
                return 2;
            }
            else if (cbbox_tamanho.SelectedIndex == 3)
            {
                return 3;
            }
            else if (cbbox_tamanho.SelectedIndex == 4)
            {
                return 4;
            }
            else if (cbbox_tamanho.SelectedIndex == 5)
            {
                return 5;
            }
            else
            {
                return 1;
            }
        }

        void ZerarArrays()
        {
            for (int c = 0; c < reta.Length; c++) reta[c] = 0;
            for (int c = 0; c < pentagono.Length; c++) pentagono[c] = 0;
            for (int c = 0; c < triangulo.Length; c++) triangulo[c] = 0;
            for (int c = 0; c < retangulo.Length; c++) retangulo[c] = 0;
            for (int c = 0; c < losangulo.Length; c++) losangulo[c] = 0;

            for (int c = 0; c < elipse.Length; c++) elipse[c] = 0;
            for (int c = 0; c < circulo.Length; c++) circulo[c] = 0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DesenharTudo(e);
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            foreach (var lista in formas.Values)
            {
                lista.Clear();
            }
            Invalidate();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string caminho = @"C:\Arquivos\dados.dat";
            Directory.CreateDirectory(Path.GetDirectoryName(caminho));

            using (StreamWriter writer = new StreamWriter(caminho, false)) // sobrescreve
            {
                foreach (var par in formas)
                {
                    string tipo = par.Key;

                    foreach (var (posicoes, caneta) in par.Value)
                    {
                        writer.WriteLine($"{tipo}");
                        writer.WriteLine(string.Join(",", posicoes));
                        writer.WriteLine($"{caneta.Color.R},{caneta.Color.G},{caneta.Color.B}");
                        writer.WriteLine($"{(int)caneta.Width}");
                        writer.WriteLine(string.Join(",", caneta.DashPattern));

                        writer.WriteLine();
                    }
                }
            }

            MessageBox.Show("Formas salvas em C:\\Arquivos\\dados.txt");
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            CarregarFormasDeArquivo();
        }

        void CarregarFormasDeArquivo()
        {
            string caminho = @"C:\Arquivos\dados.dat";

            if (!File.Exists(caminho))
            {
                MessageBox.Show("Arquivo não encontrado!");
                return;
            }

            foreach (var lista in formas.Values)
                lista.Clear();

            string[] linhas = File.ReadAllLines(caminho);
            string tipo = "";
            int[] posicoes = null;
            Color cor = Color.Black;
            int espessura = 1;
            float[] estilo = null;
            int etapa = 0;

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                {
                    if (!string.IsNullOrEmpty(tipo) && posicoes != null)
                    {
                        Pen pen = new Pen(cor, espessura);
                        if (estilo != null && !(estilo.Length == 1 && estilo[0] == 1f))
                            pen.DashPattern = estilo;

                        if (formas.ContainsKey(tipo))
                            formas[tipo].Add((posicoes, pen));
                    }

                    tipo = "";
                    posicoes = null;
                    cor = Color.Black;
                    espessura = 1;
                    estilo = null;
                    etapa = 0;
                    continue;
                }

                switch (etapa)
                {
                    case 0:
                        tipo = linha.Trim();
                        break;
                    case 1:
                        posicoes = linha.Split(',').Select(int.Parse).ToArray();
                        break;
                    case 2:
                        var rgb = linha.Split(',').Select(int.Parse).ToArray();
                        cor = Color.FromArgb(rgb[0], rgb[1], rgb[2]);
                        break;
                    case 3:
                        espessura = int.Parse(linha.Trim());
                        break;
                    case 4:
                        estilo = linha.Split(',')
                                      .Select(s => float.TryParse(s.Trim(), out float f) ? f : 1f)
                                      .ToArray();
                        break;
                }

                etapa++;
            }

            Invalidate();
            MessageBox.Show("Figuras carregadas de C:\\Arquivos\\dados.dat");
        }

    }
}

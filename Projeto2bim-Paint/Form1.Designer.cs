using global::System;
using global::System.Collections.Generic;
using global::System.Drawing;
using global::System.IO;
using global::System.Linq;
using global::System.Net.Http;
using global::System.Threading;
using global::System.Threading.Tasks;
using global::System.Windows.Forms;

namespace Projeto2bim_Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_formas = new Panel();
            btn_losangulo = new Button();
            btn_elipse = new Button();
            btn_triangulo = new Button();
            btn_pentagono = new Button();
            btn_circle = new Button();
            btn_square = new Button();
            btn_reta = new Button();
            lbl_formas = new Label();
            panel_contorno = new Panel();
            cbbox_preenchimento = new ComboBox();
            cbbox_contorno = new ComboBox();
            panel_tamanho = new Panel();
            pictureBox1 = new PictureBox();
            cbbox_tamanho = new ComboBox();
            panel1 = new Panel();
            lbl_cores = new Label();
            panel_cor_sec = new Panel();
            btn_cor_secundaria = new Button();
            lbl_cor_sec = new Label();
            panel_cor_principal = new Panel();
            btn_cor_selecionada = new Button();
            lbl_cor_princial = new Label();
            btn_lilas = new Button();
            btn_azul_acizentado = new Button();
            btn_azul_pastel = new Button();
            btn_verde_limao_claro = new Button();
            btn_bege = new Button();
            btn_amarelo_alaranjado = new Button();
            btn_rosa_claro = new Button();
            btn_marrom_claro = new Button();
            btn_cinza_claro = new Button();
            btn_branco = new Button();
            btn_roxo = new Button();
            btn_azul_escuro = new Button();
            btn_azul_claro = new Button();
            btn_verde = new Button();
            btn_amarelo = new Button();
            btn_laranja = new Button();
            btn_vermelho = new Button();
            btn_vinho_escuro = new Button();
            btn_cinza_escuro = new Button();
            btn_preto = new Button();
            panel_utilites = new Panel();
            btn_import = new Button();
            btn_limpar = new Button();
            btn_save = new Button();
            lbl_utilidades = new Label();
            panel2 = new Panel();
            panel_formas.SuspendLayout();
            panel_contorno.SuspendLayout();
            panel_tamanho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel_cor_sec.SuspendLayout();
            panel_cor_principal.SuspendLayout();
            panel_utilites.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel_formas
            // 
            panel_formas.BackColor = SystemColors.Menu;
            panel_formas.BorderStyle = BorderStyle.FixedSingle;
            panel_formas.Controls.Add(btn_losangulo);
            panel_formas.Controls.Add(btn_elipse);
            panel_formas.Controls.Add(btn_triangulo);
            panel_formas.Controls.Add(btn_pentagono);
            panel_formas.Controls.Add(btn_circle);
            panel_formas.Controls.Add(btn_square);
            panel_formas.Controls.Add(btn_reta);
            panel_formas.Location = new Point(17, 3);
            panel_formas.Name = "panel_formas";
            panel_formas.Size = new Size(406, 122);
            panel_formas.TabIndex = 0;
            // 
            // btn_losangulo
            // 
            btn_losangulo.FlatAppearance.BorderColor = Color.White;
            btn_losangulo.FlatStyle = FlatStyle.Flat;
            btn_losangulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_losangulo.Location = new Point(345, 3);
            btn_losangulo.Name = "btn_losangulo";
            btn_losangulo.Size = new Size(51, 51);
            btn_losangulo.TabIndex = 5;
            btn_losangulo.Text = "♢";
            btn_losangulo.UseVisualStyleBackColor = true;
            btn_losangulo.Click += btn_losangulo_Click;
            // 
            // btn_elipse
            // 
            btn_elipse.FlatAppearance.BorderColor = Color.White;
            btn_elipse.FlatStyle = FlatStyle.Flat;
            btn_elipse.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_elipse.Location = new Point(288, 3);
            btn_elipse.Name = "btn_elipse";
            btn_elipse.Size = new Size(51, 51);
            btn_elipse.TabIndex = 3;
            btn_elipse.Text = "⬭";
            btn_elipse.UseVisualStyleBackColor = true;
            btn_elipse.Click += btn_elipse_Click;
            // 
            // btn_triangulo
            // 
            btn_triangulo.FlatAppearance.BorderColor = Color.White;
            btn_triangulo.FlatStyle = FlatStyle.Flat;
            btn_triangulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_triangulo.Location = new Point(231, 3);
            btn_triangulo.Name = "btn_triangulo";
            btn_triangulo.Size = new Size(51, 51);
            btn_triangulo.TabIndex = 3;
            btn_triangulo.Text = "△";
            btn_triangulo.UseVisualStyleBackColor = true;
            btn_triangulo.Click += btn_triangulo_Click;
            // 
            // btn_pentagono
            // 
            btn_pentagono.FlatAppearance.BorderColor = Color.White;
            btn_pentagono.FlatStyle = FlatStyle.Flat;
            btn_pentagono.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_pentagono.Location = new Point(174, 3);
            btn_pentagono.Name = "btn_pentagono";
            btn_pentagono.Size = new Size(51, 51);
            btn_pentagono.TabIndex = 3;
            btn_pentagono.Text = "⌂";
            btn_pentagono.UseVisualStyleBackColor = true;
            btn_pentagono.Click += btn_pentagono_Click;
            // 
            // btn_circle
            // 
            btn_circle.BackColor = SystemColors.Menu;
            btn_circle.FlatAppearance.BorderColor = Color.White;
            btn_circle.FlatStyle = FlatStyle.Flat;
            btn_circle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_circle.Location = new Point(117, 3);
            btn_circle.Name = "btn_circle";
            btn_circle.Size = new Size(51, 51);
            btn_circle.TabIndex = 3;
            btn_circle.Text = "⭕";
            btn_circle.UseVisualStyleBackColor = false;
            btn_circle.Click += btn_circle_Click;
            // 
            // btn_square
            // 
            btn_square.FlatAppearance.BorderColor = Color.White;
            btn_square.FlatStyle = FlatStyle.Flat;
            btn_square.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_square.Location = new Point(60, 3);
            btn_square.Name = "btn_square";
            btn_square.Size = new Size(51, 51);
            btn_square.TabIndex = 3;
            btn_square.Text = "▭";
            btn_square.UseVisualStyleBackColor = true;
            btn_square.Click += btn_square_Click;
            // 
            // btn_reta
            // 
            btn_reta.FlatAppearance.BorderColor = Color.White;
            btn_reta.FlatStyle = FlatStyle.Flat;
            btn_reta.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_reta.Location = new Point(3, 3);
            btn_reta.Name = "btn_reta";
            btn_reta.Size = new Size(51, 51);
            btn_reta.TabIndex = 2;
            btn_reta.Text = "/";
            btn_reta.UseVisualStyleBackColor = true;
            btn_reta.Click += btn_reta_Click;
            // 
            // lbl_formas
            // 
            lbl_formas.AutoSize = true;
            lbl_formas.Location = new Point(288, 128);
            lbl_formas.Name = "lbl_formas";
            lbl_formas.Size = new Size(46, 15);
            lbl_formas.TabIndex = 2;
            lbl_formas.Text = "Formas";
            // 
            // panel_contorno
            // 
            panel_contorno.BorderStyle = BorderStyle.FixedSingle;
            panel_contorno.Controls.Add(cbbox_preenchimento);
            panel_contorno.Controls.Add(cbbox_contorno);
            panel_contorno.Location = new Point(429, 3);
            panel_contorno.Name = "panel_contorno";
            panel_contorno.Size = new Size(131, 122);
            panel_contorno.TabIndex = 2;
            // 
            // cbbox_preenchimento
            // 
            cbbox_preenchimento.FormattingEnabled = true;
            cbbox_preenchimento.Location = new Point(3, 35);
            cbbox_preenchimento.Name = "cbbox_preenchimento";
            cbbox_preenchimento.Size = new Size(121, 23);
            cbbox_preenchimento.TabIndex = 6;
            cbbox_preenchimento.Text = "Preenchimento";
            // 
            // cbbox_contorno
            // 
            cbbox_contorno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_contorno.FormattingEnabled = true;
            cbbox_contorno.Location = new Point(3, 6);
            cbbox_contorno.Name = "cbbox_contorno";
            cbbox_contorno.Size = new Size(121, 23);
            cbbox_contorno.TabIndex = 2;
            // 
            // panel_tamanho
            // 
            panel_tamanho.BorderStyle = BorderStyle.FixedSingle;
            panel_tamanho.Controls.Add(pictureBox1);
            panel_tamanho.Controls.Add(cbbox_tamanho);
            panel_tamanho.Location = new Point(566, 3);
            panel_tamanho.Name = "panel_tamanho";
            panel_tamanho.Size = new Size(132, 122);
            panel_tamanho.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cbbox_tamanho
            // 
            cbbox_tamanho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbox_tamanho.FormattingEnabled = true;
            cbbox_tamanho.Location = new Point(6, 94);
            cbbox_tamanho.Name = "cbbox_tamanho";
            cbbox_tamanho.Size = new Size(121, 23);
            cbbox_tamanho.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbl_cores);
            panel1.Controls.Add(panel_cor_sec);
            panel1.Controls.Add(panel_cor_principal);
            panel1.Controls.Add(btn_lilas);
            panel1.Controls.Add(btn_azul_acizentado);
            panel1.Controls.Add(btn_azul_pastel);
            panel1.Controls.Add(btn_verde_limao_claro);
            panel1.Controls.Add(btn_bege);
            panel1.Controls.Add(btn_amarelo_alaranjado);
            panel1.Controls.Add(btn_rosa_claro);
            panel1.Controls.Add(btn_marrom_claro);
            panel1.Controls.Add(btn_cinza_claro);
            panel1.Controls.Add(btn_branco);
            panel1.Controls.Add(btn_roxo);
            panel1.Controls.Add(btn_azul_escuro);
            panel1.Controls.Add(btn_azul_claro);
            panel1.Controls.Add(btn_verde);
            panel1.Controls.Add(btn_amarelo);
            panel1.Controls.Add(btn_laranja);
            panel1.Controls.Add(btn_vermelho);
            panel1.Controls.Add(btn_vinho_escuro);
            panel1.Controls.Add(btn_cinza_escuro);
            panel1.Controls.Add(btn_preto);
            panel1.Location = new Point(704, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 122);
            panel1.TabIndex = 4;
            // 
            // lbl_cores
            // 
            lbl_cores.AutoSize = true;
            lbl_cores.Location = new Point(391, 100);
            lbl_cores.Name = "lbl_cores";
            lbl_cores.Size = new Size(37, 15);
            lbl_cores.TabIndex = 5;
            lbl_cores.Text = "Cores";
            // 
            // panel_cor_sec
            // 
            panel_cor_sec.BackColor = Color.Transparent;
            panel_cor_sec.Controls.Add(btn_cor_secundaria);
            panel_cor_sec.Controls.Add(lbl_cor_sec);
            panel_cor_sec.Location = new Point(95, 3);
            panel_cor_sec.Name = "panel_cor_sec";
            panel_cor_sec.Size = new Size(86, 114);
            panel_cor_sec.TabIndex = 7;
            // 
            // btn_cor_secundaria
            // 
            btn_cor_secundaria.BackColor = Color.White;
            btn_cor_secundaria.FlatStyle = FlatStyle.Flat;
            btn_cor_secundaria.ForeColor = SystemColors.ControlText;
            btn_cor_secundaria.Location = new Point(15, 10);
            btn_cor_secundaria.Name = "btn_cor_secundaria";
            btn_cor_secundaria.Size = new Size(56, 56);
            btn_cor_secundaria.TabIndex = 0;
            btn_cor_secundaria.UseVisualStyleBackColor = false;
            btn_cor_secundaria.Click += btn_cor_secundaria_Click;
            // 
            // lbl_cor_sec
            // 
            lbl_cor_sec.AutoSize = true;
            lbl_cor_sec.Location = new Point(23, 69);
            lbl_cor_sec.Name = "lbl_cor_sec";
            lbl_cor_sec.Size = new Size(29, 15);
            lbl_cor_sec.TabIndex = 5;
            lbl_cor_sec.Text = " Cor";
            // 
            // panel_cor_principal
            // 
            panel_cor_principal.Controls.Add(btn_cor_selecionada);
            panel_cor_principal.Controls.Add(lbl_cor_princial);
            panel_cor_principal.Location = new Point(3, 3);
            panel_cor_principal.Name = "panel_cor_principal";
            panel_cor_principal.Size = new Size(86, 114);
            panel_cor_principal.TabIndex = 6;
            // 
            // btn_cor_selecionada
            // 
            btn_cor_selecionada.BackColor = SystemColors.ActiveCaptionText;
            btn_cor_selecionada.FlatStyle = FlatStyle.Flat;
            btn_cor_selecionada.Location = new Point(9, 3);
            btn_cor_selecionada.Name = "btn_cor_selecionada";
            btn_cor_selecionada.Size = new Size(68, 68);
            btn_cor_selecionada.TabIndex = 0;
            btn_cor_selecionada.UseVisualStyleBackColor = false;
            btn_cor_selecionada.Click += btn_cor_selecionada_Click;
            // 
            // lbl_cor_princial
            // 
            lbl_cor_princial.AutoSize = true;
            lbl_cor_princial.Location = new Point(9, 74);
            lbl_cor_princial.Name = "lbl_cor_princial";
            lbl_cor_princial.Size = new Size(44, 30);
            lbl_cor_princial.TabIndex = 5;
            lbl_cor_princial.Text = "      Cor\r\n        1";
            // 
            // btn_lilas
            // 
            btn_lilas.BackColor = Color.FromArgb(200, 191, 231);
            btn_lilas.FlatStyle = FlatStyle.Flat;
            btn_lilas.ForeColor = SystemColors.ActiveCaptionText;
            btn_lilas.Location = new Point(637, 53);
            btn_lilas.Name = "btn_lilas";
            btn_lilas.Size = new Size(44, 44);
            btn_lilas.TabIndex = 9;
            btn_lilas.UseVisualStyleBackColor = false;
            btn_lilas.Click += btn_lilas_Click;
            // 
            // btn_azul_acizentado
            // 
            btn_azul_acizentado.BackColor = Color.FromArgb(112, 146, 190);
            btn_azul_acizentado.FlatStyle = FlatStyle.Flat;
            btn_azul_acizentado.ForeColor = SystemColors.ActiveCaptionText;
            btn_azul_acizentado.Location = new Point(587, 53);
            btn_azul_acizentado.Name = "btn_azul_acizentado";
            btn_azul_acizentado.Size = new Size(44, 44);
            btn_azul_acizentado.TabIndex = 9;
            btn_azul_acizentado.UseVisualStyleBackColor = false;
            btn_azul_acizentado.Click += btn_azul_acizentado_Click;
            // 
            // btn_azul_pastel
            // 
            btn_azul_pastel.BackColor = Color.FromArgb(153, 217, 234);
            btn_azul_pastel.FlatStyle = FlatStyle.Flat;
            btn_azul_pastel.ForeColor = SystemColors.ActiveCaptionText;
            btn_azul_pastel.Location = new Point(537, 53);
            btn_azul_pastel.Name = "btn_azul_pastel";
            btn_azul_pastel.Size = new Size(44, 44);
            btn_azul_pastel.TabIndex = 8;
            btn_azul_pastel.UseVisualStyleBackColor = false;
            btn_azul_pastel.Click += btn_azul_pastel_Click;
            // 
            // btn_verde_limao_claro
            // 
            btn_verde_limao_claro.BackColor = Color.FromArgb(181, 230, 29);
            btn_verde_limao_claro.FlatStyle = FlatStyle.Flat;
            btn_verde_limao_claro.ForeColor = SystemColors.ActiveCaptionText;
            btn_verde_limao_claro.Location = new Point(487, 53);
            btn_verde_limao_claro.Name = "btn_verde_limao_claro";
            btn_verde_limao_claro.Size = new Size(44, 44);
            btn_verde_limao_claro.TabIndex = 8;
            btn_verde_limao_claro.UseVisualStyleBackColor = false;
            btn_verde_limao_claro.Click += btn_verde_limao_claro_Click;
            // 
            // btn_bege
            // 
            btn_bege.BackColor = Color.FromArgb(239, 228, 176);
            btn_bege.FlatStyle = FlatStyle.Flat;
            btn_bege.ForeColor = SystemColors.ActiveCaptionText;
            btn_bege.Location = new Point(437, 53);
            btn_bege.Name = "btn_bege";
            btn_bege.Size = new Size(44, 44);
            btn_bege.TabIndex = 8;
            btn_bege.UseVisualStyleBackColor = false;
            btn_bege.Click += btn_bege_Click;
            // 
            // btn_amarelo_alaranjado
            // 
            btn_amarelo_alaranjado.BackColor = Color.FromArgb(255, 201, 14);
            btn_amarelo_alaranjado.FlatStyle = FlatStyle.Flat;
            btn_amarelo_alaranjado.ForeColor = SystemColors.ActiveCaptionText;
            btn_amarelo_alaranjado.Location = new Point(387, 53);
            btn_amarelo_alaranjado.Name = "btn_amarelo_alaranjado";
            btn_amarelo_alaranjado.Size = new Size(44, 44);
            btn_amarelo_alaranjado.TabIndex = 8;
            btn_amarelo_alaranjado.UseVisualStyleBackColor = false;
            btn_amarelo_alaranjado.Click += btn_amarelo_alaranjado_Click;
            // 
            // btn_rosa_claro
            // 
            btn_rosa_claro.BackColor = Color.FromArgb(255, 174, 201);
            btn_rosa_claro.FlatStyle = FlatStyle.Flat;
            btn_rosa_claro.ForeColor = SystemColors.ActiveCaptionText;
            btn_rosa_claro.Location = new Point(337, 53);
            btn_rosa_claro.Name = "btn_rosa_claro";
            btn_rosa_claro.Size = new Size(44, 44);
            btn_rosa_claro.TabIndex = 8;
            btn_rosa_claro.UseVisualStyleBackColor = false;
            btn_rosa_claro.Click += btn_rosa_claro_Click;
            // 
            // btn_marrom_claro
            // 
            btn_marrom_claro.BackColor = Color.FromArgb(185, 122, 87);
            btn_marrom_claro.FlatStyle = FlatStyle.Flat;
            btn_marrom_claro.ForeColor = SystemColors.ActiveCaptionText;
            btn_marrom_claro.Location = new Point(287, 53);
            btn_marrom_claro.Name = "btn_marrom_claro";
            btn_marrom_claro.Size = new Size(44, 44);
            btn_marrom_claro.TabIndex = 8;
            btn_marrom_claro.UseVisualStyleBackColor = false;
            btn_marrom_claro.Click += btn_marrom_claro_Click;
            // 
            // btn_cinza_claro
            // 
            btn_cinza_claro.BackColor = Color.FromArgb(195, 195, 195);
            btn_cinza_claro.FlatStyle = FlatStyle.Flat;
            btn_cinza_claro.ForeColor = SystemColors.ActiveCaptionText;
            btn_cinza_claro.Location = new Point(237, 53);
            btn_cinza_claro.Name = "btn_cinza_claro";
            btn_cinza_claro.Size = new Size(44, 44);
            btn_cinza_claro.TabIndex = 7;
            btn_cinza_claro.UseVisualStyleBackColor = false;
            btn_cinza_claro.Click += btn_cinza_claro_Click;
            // 
            // btn_branco
            // 
            btn_branco.BackColor = Color.White;
            btn_branco.FlatStyle = FlatStyle.Flat;
            btn_branco.ForeColor = SystemColors.ActiveCaptionText;
            btn_branco.Location = new Point(187, 53);
            btn_branco.Name = "btn_branco";
            btn_branco.Size = new Size(44, 44);
            btn_branco.TabIndex = 6;
            btn_branco.UseVisualStyleBackColor = false;
            btn_branco.Click += btn_branco_Click;
            // 
            // btn_roxo
            // 
            btn_roxo.BackColor = Color.FromArgb(163, 73, 164);
            btn_roxo.FlatStyle = FlatStyle.Flat;
            btn_roxo.ForeColor = SystemColors.ActiveCaptionText;
            btn_roxo.Location = new Point(637, 3);
            btn_roxo.Name = "btn_roxo";
            btn_roxo.Size = new Size(44, 44);
            btn_roxo.TabIndex = 13;
            btn_roxo.UseVisualStyleBackColor = false;
            btn_roxo.Click += btn_roxo_Click;
            // 
            // btn_azul_escuro
            // 
            btn_azul_escuro.BackColor = Color.FromArgb(63, 72, 164);
            btn_azul_escuro.FlatStyle = FlatStyle.Flat;
            btn_azul_escuro.ForeColor = SystemColors.ActiveCaptionText;
            btn_azul_escuro.Location = new Point(587, 3);
            btn_azul_escuro.Name = "btn_azul_escuro";
            btn_azul_escuro.Size = new Size(44, 44);
            btn_azul_escuro.TabIndex = 12;
            btn_azul_escuro.UseVisualStyleBackColor = false;
            btn_azul_escuro.Click += btn_azul_escuro_Click;
            // 
            // btn_azul_claro
            // 
            btn_azul_claro.BackColor = Color.FromArgb(0, 162, 232);
            btn_azul_claro.FlatStyle = FlatStyle.Flat;
            btn_azul_claro.ForeColor = SystemColors.ActiveCaptionText;
            btn_azul_claro.Location = new Point(537, 3);
            btn_azul_claro.Name = "btn_azul_claro";
            btn_azul_claro.Size = new Size(44, 44);
            btn_azul_claro.TabIndex = 11;
            btn_azul_claro.UseVisualStyleBackColor = false;
            btn_azul_claro.Click += btn_azul_claro_Click;
            // 
            // btn_verde
            // 
            btn_verde.BackColor = Color.FromArgb(34, 177, 76);
            btn_verde.FlatStyle = FlatStyle.Flat;
            btn_verde.ForeColor = SystemColors.ActiveCaptionText;
            btn_verde.Location = new Point(487, 3);
            btn_verde.Name = "btn_verde";
            btn_verde.Size = new Size(44, 44);
            btn_verde.TabIndex = 10;
            btn_verde.UseVisualStyleBackColor = false;
            btn_verde.Click += btn_verde_Click;
            // 
            // btn_amarelo
            // 
            btn_amarelo.BackColor = Color.FromArgb(255, 242, 0);
            btn_amarelo.FlatStyle = FlatStyle.Flat;
            btn_amarelo.ForeColor = SystemColors.ActiveCaptionText;
            btn_amarelo.Location = new Point(437, 3);
            btn_amarelo.Name = "btn_amarelo";
            btn_amarelo.Size = new Size(44, 44);
            btn_amarelo.TabIndex = 9;
            btn_amarelo.UseVisualStyleBackColor = false;
            btn_amarelo.Click += btn_amarelo_Click;
            // 
            // btn_laranja
            // 
            btn_laranja.BackColor = Color.FromArgb(255, 127, 39);
            btn_laranja.FlatStyle = FlatStyle.Flat;
            btn_laranja.ForeColor = SystemColors.ActiveCaptionText;
            btn_laranja.Location = new Point(387, 3);
            btn_laranja.Name = "btn_laranja";
            btn_laranja.Size = new Size(44, 44);
            btn_laranja.TabIndex = 8;
            btn_laranja.UseVisualStyleBackColor = false;
            btn_laranja.Click += btn_laranja_Click;
            // 
            // btn_vermelho
            // 
            btn_vermelho.BackColor = Color.FromArgb(237, 28, 36);
            btn_vermelho.FlatStyle = FlatStyle.Flat;
            btn_vermelho.ForeColor = SystemColors.ActiveCaptionText;
            btn_vermelho.Location = new Point(337, 3);
            btn_vermelho.Name = "btn_vermelho";
            btn_vermelho.Size = new Size(44, 44);
            btn_vermelho.TabIndex = 8;
            btn_vermelho.UseVisualStyleBackColor = false;
            btn_vermelho.Click += btn_vermelho_Click;
            // 
            // btn_vinho_escuro
            // 
            btn_vinho_escuro.BackColor = Color.FromArgb(136, 0, 21);
            btn_vinho_escuro.FlatStyle = FlatStyle.Flat;
            btn_vinho_escuro.ForeColor = SystemColors.ActiveCaptionText;
            btn_vinho_escuro.Location = new Point(287, 3);
            btn_vinho_escuro.Name = "btn_vinho_escuro";
            btn_vinho_escuro.Size = new Size(44, 44);
            btn_vinho_escuro.TabIndex = 7;
            btn_vinho_escuro.UseVisualStyleBackColor = false;
            btn_vinho_escuro.Click += btn_vinho_escuro_Click;
            // 
            // btn_cinza_escuro
            // 
            btn_cinza_escuro.BackColor = Color.FromArgb(127, 127, 127);
            btn_cinza_escuro.FlatStyle = FlatStyle.Flat;
            btn_cinza_escuro.ForeColor = SystemColors.ActiveCaptionText;
            btn_cinza_escuro.Location = new Point(237, 3);
            btn_cinza_escuro.Name = "btn_cinza_escuro";
            btn_cinza_escuro.Size = new Size(44, 44);
            btn_cinza_escuro.TabIndex = 6;
            btn_cinza_escuro.UseVisualStyleBackColor = false;
            btn_cinza_escuro.Click += btn_cinza_escuro_Click;
            // 
            // btn_preto
            // 
            btn_preto.BackColor = Color.FromArgb(8, 8, 8);
            btn_preto.FlatStyle = FlatStyle.Flat;
            btn_preto.ForeColor = SystemColors.ActiveCaptionText;
            btn_preto.Location = new Point(187, 3);
            btn_preto.Name = "btn_preto";
            btn_preto.Size = new Size(44, 44);
            btn_preto.TabIndex = 5;
            btn_preto.UseVisualStyleBackColor = false;
            btn_preto.Click += btn_preto_Click;
            // 
            // panel_utilites
            // 
            panel_utilites.BorderStyle = BorderStyle.FixedSingle;
            panel_utilites.Controls.Add(btn_import);
            panel_utilites.Controls.Add(btn_limpar);
            panel_utilites.Controls.Add(btn_save);
            panel_utilites.Location = new Point(1402, 3);
            panel_utilites.Name = "panel_utilites";
            panel_utilites.Size = new Size(129, 122);
            panel_utilites.TabIndex = 5;
            // 
            // btn_import
            // 
            btn_import.FlatAppearance.BorderColor = Color.White;
            btn_import.FlatStyle = FlatStyle.Flat;
            btn_import.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_import.Image = (Image)resources.GetObject("btn_import.Image");
            btn_import.Location = new Point(69, 3);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(51, 51);
            btn_import.TabIndex = 7;
            btn_import.UseVisualStyleBackColor = true;
            btn_import.Click += btn_import_Click;
            // 
            // btn_limpar
            // 
            btn_limpar.FlatAppearance.BorderColor = Color.White;
            btn_limpar.FlatStyle = FlatStyle.Flat;
            btn_limpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpar.Image = (Image)resources.GetObject("btn_limpar.Image");
            btn_limpar.Location = new Point(3, 66);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(51, 51);
            btn_limpar.TabIndex = 6;
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += btn_limpar_Click;
            // 
            // btn_save
            // 
            btn_save.FlatAppearance.BorderColor = Color.White;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.Image = (Image)resources.GetObject("btn_save.Image");
            btn_save.Location = new Point(3, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(51, 51);
            btn_save.TabIndex = 6;
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // lbl_utilidades
            // 
            lbl_utilidades.AutoSize = true;
            lbl_utilidades.Location = new Point(1464, 128);
            lbl_utilidades.Name = "lbl_utilidades";
            lbl_utilidades.Size = new Size(59, 15);
            lbl_utilidades.TabIndex = 6;
            lbl_utilidades.Text = "Utilidades";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel_formas);
            panel2.Controls.Add(lbl_utilidades);
            panel2.Controls.Add(panel_tamanho);
            panel2.Controls.Add(panel_utilites);
            panel2.Controls.Add(panel_contorno);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(lbl_formas);
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1626, 156);
            panel2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 698);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            MouseClick += Form1_MouseClick;
            panel_formas.ResumeLayout(false);
            panel_contorno.ResumeLayout(false);
            panel_tamanho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_cor_sec.ResumeLayout(false);
            panel_cor_sec.PerformLayout();
            panel_cor_principal.ResumeLayout(false);
            panel_cor_principal.PerformLayout();
            panel_utilites.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_formas;
        private Button btn_reta;
        private Button btn_circle;
        private Button btn_square;
        private Button btn_elipse;
        private Button btn_triangulo;
        private Button btn_pentagono;
        private Label lbl_formas;
        private Panel panel_tamanho;
        private ComboBox cbbox_tamanho;
        private Panel panel_contorno;
        private ComboBox cbbox_contorno;
        private Panel panel1;
        private Label lbl_cor_princial;
        private Button btn_cor_selecionada;
        private Button btn_amarelo;
        private Button btn_laranja;
        private Button btn_vermelho;
        private Button btn_vinho_escuro;
        private Button btn_cinza_escuro;
        private Button btn_preto;
        private Button btn_amarelo_alaranjado;
        private Button btn_rosa_claro;
        private Button btn_marrom_claro;
        private Button btn_cinza_claro;
        private Button btn_branco;
        private Button btn_roxo;
        private Button btn_azul_escuro;
        private Button btn_azul_claro;
        private Button btn_verde;
        private Button btn_lilas;
        private Button btn_azul_acizentado;
        private Button btn_azul_pastel;
        private Button btn_verde_limao_claro;
        private Button btn_bege;
        private PictureBox pictureBox1;
        private Panel panel_cor_principal;
        private Panel panel_cor_sec;
        private Button btn_cor_secundaria;
        private Label lbl_cor_sec;
        private Label lbl_cores;
        private Button btn_losangulo;
        private Panel panel_utilites;
        private Button btn_save;
        private Button btn_limpar;
        private ComboBox cbbox_preenchimento;
        private Button btn_import;
        private Label lbl_utilidades;
        private Panel panel2;
    }
}

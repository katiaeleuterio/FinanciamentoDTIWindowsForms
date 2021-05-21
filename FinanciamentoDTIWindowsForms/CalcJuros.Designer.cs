
namespace FinanciamentoDTIWindowsForms
{
    partial class CalcJuros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.DadosEmpresasTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblAnosD = new System.Windows.Forms.Label();
            this.lblAnosA = new System.Windows.Forms.Label();
            this.lblAnosC = new System.Windows.Forms.Label();
            this.lblVlA = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblAnosB = new System.Windows.Forms.Label();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.lblVlD = new System.Windows.Forms.Label();
            this.lblEntrEmpA = new System.Windows.Forms.Label();
            this.lblVlC = new System.Windows.Forms.Label();
            this.lblTxD = new System.Windows.Forms.Label();
            this.lblVlB = new System.Windows.Forms.Label();
            this.lblEmpresaB = new System.Windows.Forms.Label();
            this.lblTxC = new System.Windows.Forms.Label();
            this.lblEmpresaA = new System.Windows.Forms.Label();
            this.lblTxB = new System.Windows.Forms.Label();
            this.lblEmpresaD = new System.Windows.Forms.Label();
            this.lblTxA = new System.Windows.Forms.Label();
            this.lblEmpresaC = new System.Windows.Forms.Label();
            this.lblQtdAnos = new System.Windows.Forms.Label();
            this.lblVl = new System.Windows.Forms.Label();
            this.lblTxJuros = new System.Windows.Forms.Label();
            this.lblEntrEmpB = new System.Windows.Forms.Label();
            this.lblEntrEmpC = new System.Windows.Forms.Label();
            this.lblEntrEmpD = new System.Windows.Forms.Label();
            this.ResultadoLbl = new System.Windows.Forms.Label();
            this.lblTituloResult = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.DadosEmpresasTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(165, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Empresas selecionadas para calcular menor montante final";
            // 
            // DadosEmpresasTable
            // 
            this.DadosEmpresasTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DadosEmpresasTable.ColumnCount = 5;
            this.DadosEmpresasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.Controls.Add(this.lblAnosD, 4, 4);
            this.DadosEmpresasTable.Controls.Add(this.lblAnosA, 4, 1);
            this.DadosEmpresasTable.Controls.Add(this.lblAnosC, 4, 3);
            this.DadosEmpresasTable.Controls.Add(this.lblVlA, 3, 1);
            this.DadosEmpresasTable.Controls.Add(this.lblEmpresa, 0, 0);
            this.DadosEmpresasTable.Controls.Add(this.lblAnosB, 4, 2);
            this.DadosEmpresasTable.Controls.Add(this.lblEntrada, 1, 0);
            this.DadosEmpresasTable.Controls.Add(this.lblVlD, 3, 4);
            this.DadosEmpresasTable.Controls.Add(this.lblEntrEmpA, 1, 1);
            this.DadosEmpresasTable.Controls.Add(this.lblVlC, 3, 3);
            this.DadosEmpresasTable.Controls.Add(this.lblTxD, 2, 4);
            this.DadosEmpresasTable.Controls.Add(this.lblVlB, 3, 2);
            this.DadosEmpresasTable.Controls.Add(this.lblEmpresaB, 0, 2);
            this.DadosEmpresasTable.Controls.Add(this.lblTxC, 2, 3);
            this.DadosEmpresasTable.Controls.Add(this.lblEmpresaA, 0, 1);
            this.DadosEmpresasTable.Controls.Add(this.lblTxB, 2, 2);
            this.DadosEmpresasTable.Controls.Add(this.lblEmpresaD, 0, 4);
            this.DadosEmpresasTable.Controls.Add(this.lblTxA, 2, 1);
            this.DadosEmpresasTable.Controls.Add(this.lblEmpresaC, 0, 3);
            this.DadosEmpresasTable.Controls.Add(this.lblQtdAnos, 4, 0);
            this.DadosEmpresasTable.Controls.Add(this.lblVl, 3, 0);
            this.DadosEmpresasTable.Controls.Add(this.lblTxJuros, 2, 0);
            this.DadosEmpresasTable.Controls.Add(this.lblEntrEmpB, 1, 2);
            this.DadosEmpresasTable.Controls.Add(this.lblEntrEmpC, 1, 3);
            this.DadosEmpresasTable.Controls.Add(this.lblEntrEmpD, 1, 4);
            this.DadosEmpresasTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DadosEmpresasTable.Location = new System.Drawing.Point(151, 96);
            this.DadosEmpresasTable.Name = "DadosEmpresasTable";
            this.DadosEmpresasTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DadosEmpresasTable.RowCount = 5;
            this.DadosEmpresasTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.25888F));
            this.DadosEmpresasTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.33503F));
            this.DadosEmpresasTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.DadosEmpresasTable.Size = new System.Drawing.Size(798, 197);
            this.DadosEmpresasTable.TabIndex = 1;
            // 
            // lblAnosD
            // 
            this.lblAnosD.AutoSize = true;
            this.lblAnosD.Location = new System.Drawing.Point(639, 156);
            this.lblAnosD.Name = "lblAnosD";
            this.lblAnosD.Size = new System.Drawing.Size(27, 20);
            this.lblAnosD.TabIndex = 13;
            this.lblAnosD.Text = "10";
            this.lblAnosD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnosA
            // 
            this.lblAnosA.AutoSize = true;
            this.lblAnosA.Location = new System.Drawing.Point(639, 34);
            this.lblAnosA.Name = "lblAnosA";
            this.lblAnosA.Size = new System.Drawing.Size(27, 20);
            this.lblAnosA.TabIndex = 10;
            this.lblAnosA.Text = "10";
            this.lblAnosA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnosC
            // 
            this.lblAnosC.AutoSize = true;
            this.lblAnosC.Location = new System.Drawing.Point(639, 117);
            this.lblAnosC.Name = "lblAnosC";
            this.lblAnosC.Size = new System.Drawing.Size(27, 20);
            this.lblAnosC.TabIndex = 12;
            this.lblAnosC.Text = "12";
            this.lblAnosC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVlA
            // 
            this.lblVlA.AutoSize = true;
            this.lblVlA.Location = new System.Drawing.Point(480, 34);
            this.lblVlA.Name = "lblVlA";
            this.lblVlA.Size = new System.Drawing.Size(36, 20);
            this.lblVlA.TabIndex = 6;
            this.lblVlA.Text = "500";
            this.lblVlA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(3, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(83, 20);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "Empresa";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnosB
            // 
            this.lblAnosB.AutoSize = true;
            this.lblAnosB.Location = new System.Drawing.Point(639, 78);
            this.lblAnosB.Name = "lblAnosB";
            this.lblAnosB.Size = new System.Drawing.Size(18, 20);
            this.lblAnosB.TabIndex = 11;
            this.lblAnosB.Text = "8";
            this.lblAnosB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(162, 0);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(117, 20);
            this.lblEntrada.TabIndex = 3;
            this.lblEntrada.Text = "Entrada (R$)";
            this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVlD
            // 
            this.lblVlD.AutoSize = true;
            this.lblVlD.Location = new System.Drawing.Point(480, 156);
            this.lblVlD.Name = "lblVlD";
            this.lblVlD.Size = new System.Drawing.Size(36, 20);
            this.lblVlD.TabIndex = 9;
            this.lblVlD.Text = "350";
            this.lblVlD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrEmpA
            // 
            this.lblEntrEmpA.AutoSize = true;
            this.lblEntrEmpA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrEmpA.Location = new System.Drawing.Point(162, 34);
            this.lblEntrEmpA.Name = "lblEntrEmpA";
            this.lblEntrEmpA.Size = new System.Drawing.Size(54, 20);
            this.lblEntrEmpA.TabIndex = 2;
            this.lblEntrEmpA.Text = "10000";
            this.lblEntrEmpA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVlC
            // 
            this.lblVlC.AutoSize = true;
            this.lblVlC.Location = new System.Drawing.Point(480, 117);
            this.lblVlC.Name = "lblVlC";
            this.lblVlC.Size = new System.Drawing.Size(36, 20);
            this.lblVlC.TabIndex = 8;
            this.lblVlC.Text = "600";
            this.lblVlC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxD
            // 
            this.lblTxD.AutoSize = true;
            this.lblTxD.Location = new System.Drawing.Point(321, 156);
            this.lblTxD.Name = "lblTxD";
            this.lblTxD.Size = new System.Drawing.Size(31, 20);
            this.lblTxD.TabIndex = 5;
            this.lblTxD.Text = "0.5";
            this.lblTxD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVlB
            // 
            this.lblVlB.AutoSize = true;
            this.lblVlB.Location = new System.Drawing.Point(480, 78);
            this.lblVlB.Name = "lblVlB";
            this.lblVlB.Size = new System.Drawing.Size(36, 20);
            this.lblVlB.TabIndex = 7;
            this.lblVlB.Text = "500";
            this.lblVlB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresaB
            // 
            this.lblEmpresaB.AutoSize = true;
            this.lblEmpresaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaB.Location = new System.Drawing.Point(3, 78);
            this.lblEmpresaB.Name = "lblEmpresaB";
            this.lblEmpresaB.Size = new System.Drawing.Size(22, 20);
            this.lblEmpresaB.TabIndex = 2;
            this.lblEmpresaB.Text = "B";
            this.lblEmpresaB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxC
            // 
            this.lblTxC.AutoSize = true;
            this.lblTxC.Location = new System.Drawing.Point(321, 117);
            this.lblTxC.Name = "lblTxC";
            this.lblTxC.Size = new System.Drawing.Size(31, 20);
            this.lblTxC.TabIndex = 4;
            this.lblTxC.Text = "1,5";
            this.lblTxC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresaA
            // 
            this.lblEmpresaA.AutoSize = true;
            this.lblEmpresaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaA.Location = new System.Drawing.Point(3, 34);
            this.lblEmpresaA.Name = "lblEmpresaA";
            this.lblEmpresaA.Size = new System.Drawing.Size(21, 20);
            this.lblEmpresaA.TabIndex = 2;
            this.lblEmpresaA.Text = "A";
            this.lblEmpresaA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxB
            // 
            this.lblTxB.AutoSize = true;
            this.lblTxB.Location = new System.Drawing.Point(321, 78);
            this.lblTxB.Name = "lblTxB";
            this.lblTxB.Size = new System.Drawing.Size(31, 20);
            this.lblTxB.TabIndex = 3;
            this.lblTxB.Text = "0,7";
            this.lblTxB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresaD
            // 
            this.lblEmpresaD.AutoSize = true;
            this.lblEmpresaD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaD.Location = new System.Drawing.Point(3, 156);
            this.lblEmpresaD.Name = "lblEmpresaD";
            this.lblEmpresaD.Size = new System.Drawing.Size(23, 20);
            this.lblEmpresaD.TabIndex = 2;
            this.lblEmpresaD.Text = "D";
            this.lblEmpresaD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxA
            // 
            this.lblTxA.AutoSize = true;
            this.lblTxA.Location = new System.Drawing.Point(321, 34);
            this.lblTxA.Name = "lblTxA";
            this.lblTxA.Size = new System.Drawing.Size(18, 20);
            this.lblTxA.TabIndex = 2;
            this.lblTxA.Text = "1";
            this.lblTxA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmpresaC
            // 
            this.lblEmpresaC.AutoSize = true;
            this.lblEmpresaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresaC.Location = new System.Drawing.Point(3, 117);
            this.lblEmpresaC.Name = "lblEmpresaC";
            this.lblEmpresaC.Size = new System.Drawing.Size(22, 20);
            this.lblEmpresaC.TabIndex = 2;
            this.lblEmpresaC.Text = "C";
            this.lblEmpresaC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdAnos
            // 
            this.lblQtdAnos.AutoSize = true;
            this.lblQtdAnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAnos.Location = new System.Drawing.Point(639, 0);
            this.lblQtdAnos.Name = "lblQtdAnos";
            this.lblQtdAnos.Size = new System.Drawing.Size(87, 20);
            this.lblQtdAnos.TabIndex = 6;
            this.lblQtdAnos.Text = "Qtd Anos";
            this.lblQtdAnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVl
            // 
            this.lblVl.AutoSize = true;
            this.lblVl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVl.Location = new System.Drawing.Point(480, 0);
            this.lblVl.Name = "lblVl";
            this.lblVl.Size = new System.Drawing.Size(96, 20);
            this.lblVl.TabIndex = 5;
            this.lblVl.Text = "Vl Parcela";
            this.lblVl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTxJuros
            // 
            this.lblTxJuros.AutoSize = true;
            this.lblTxJuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxJuros.Location = new System.Drawing.Point(321, 0);
            this.lblTxJuros.Name = "lblTxJuros";
            this.lblTxJuros.Size = new System.Drawing.Size(118, 20);
            this.lblTxJuros.TabIndex = 4;
            this.lblTxJuros.Text = "Tx Juros (%)";
            this.lblTxJuros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrEmpB
            // 
            this.lblEntrEmpB.AutoSize = true;
            this.lblEntrEmpB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrEmpB.Location = new System.Drawing.Point(162, 78);
            this.lblEntrEmpB.Name = "lblEntrEmpB";
            this.lblEntrEmpB.Size = new System.Drawing.Size(54, 20);
            this.lblEntrEmpB.TabIndex = 2;
            this.lblEntrEmpB.Text = "30000";
            this.lblEntrEmpB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrEmpC
            // 
            this.lblEntrEmpC.AutoSize = true;
            this.lblEntrEmpC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrEmpC.Location = new System.Drawing.Point(162, 117);
            this.lblEntrEmpC.Name = "lblEntrEmpC";
            this.lblEntrEmpC.Size = new System.Drawing.Size(45, 20);
            this.lblEntrEmpC.TabIndex = 2;
            this.lblEntrEmpC.Text = "5000";
            this.lblEntrEmpC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntrEmpD
            // 
            this.lblEntrEmpD.AutoSize = true;
            this.lblEntrEmpD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrEmpD.Location = new System.Drawing.Point(162, 156);
            this.lblEntrEmpD.Name = "lblEntrEmpD";
            this.lblEntrEmpD.Size = new System.Drawing.Size(54, 20);
            this.lblEntrEmpD.TabIndex = 2;
            this.lblEntrEmpD.Text = "50000";
            this.lblEntrEmpD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResultadoLbl
            // 
            this.ResultadoLbl.AutoSize = true;
            this.ResultadoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultadoLbl.Location = new System.Drawing.Point(148, 422);
            this.ResultadoLbl.Name = "lblResultado";
            this.ResultadoLbl.Size = new System.Drawing.Size(0, 24);
            this.ResultadoLbl.TabIndex = 14;
            // 
            // lblTituloResult
            // 
            this.lblTituloResult.AutoSize = true;
            this.lblTituloResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResult.Location = new System.Drawing.Point(148, 364);
            this.lblTituloResult.Name = "lblTituloResult";
            this.lblTituloResult.Size = new System.Drawing.Size(261, 25);
            this.lblTituloResult.TabIndex = 15;
            this.lblTituloResult.Text = "Resultado do comparativo";
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(1004, 510);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(119, 40);
            this.btnFechar.TabIndex = 16;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // CalcJuros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 578);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTituloResult);
            this.Controls.Add(this.ResultadoLbl);
            this.Controls.Add(this.DadosEmpresasTable);
            this.Controls.Add(this.lblTitulo);
            this.Name = "CalcJuros";
            this.Text = "Comparação de cálculo de juros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CalcJuros_FormClosing);
            this.DadosEmpresasTable.ResumeLayout(false);
            this.DadosEmpresasTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel DadosEmpresasTable;
        private System.Windows.Forms.Label lblQtdAnos;
        private System.Windows.Forms.Label lblVl;
        private System.Windows.Forms.Label lblTxJuros;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label lblEntrEmpC;
        private System.Windows.Forms.Label lblAnosD;
        private System.Windows.Forms.Label lblAnosA;
        private System.Windows.Forms.Label lblAnosC;
        private System.Windows.Forms.Label lblVlA;
        private System.Windows.Forms.Label lblAnosB;
        private System.Windows.Forms.Label lblVlD;
        private System.Windows.Forms.Label lblEntrEmpA;
        private System.Windows.Forms.Label lblVlC;
        private System.Windows.Forms.Label lblTxD;
        private System.Windows.Forms.Label lblVlB;
        private System.Windows.Forms.Label lblEmpresaB;
        private System.Windows.Forms.Label lblTxC;
        private System.Windows.Forms.Label lblEmpresaA;
        private System.Windows.Forms.Label lblTxB;
        private System.Windows.Forms.Label lblEmpresaD;
        private System.Windows.Forms.Label lblTxA;
        private System.Windows.Forms.Label lblEmpresaC;
        private System.Windows.Forms.Label lblEntrEmpB;
        private System.Windows.Forms.Label lblEntrEmpD;
        private System.Windows.Forms.Label ResultadoLbl;
        private System.Windows.Forms.Label lblTituloResult;
        private System.Windows.Forms.Button btnFechar;
    }
}


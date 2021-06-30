namespace FNE
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInfacion = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtInversion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Inversion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtVPN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvFNE = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtIngreso);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtEgresos);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtVS);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.txtInfacion);
            this.splitContainer1.Panel1.Controls.Add(this.txtTasa);
            this.splitContainer1.Panel1.Controls.Add(this.txtPlazo);
            this.splitContainer1.Panel1.Controls.Add(this.txtInversion);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Inversion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2.Controls.Add(this.txtVPN);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.dgvFNE);
            this.splitContainer1.Size = new System.Drawing.Size(1067, 591);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(27, 471);
            this.txtIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(300, 22);
            this.txtIngreso.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 435);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ingreso";
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(29, 518);
            this.txtEgresos.Margin = new System.Windows.Forms.Padding(4);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(299, 22);
            this.txtEgresos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 497);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Egresos";
            // 
            // txtVS
            // 
            this.txtVS.Location = new System.Drawing.Point(29, 393);
            this.txtVS.Margin = new System.Windows.Forms.Padding(4);
            this.txtVS.Name = "txtVS";
            this.txtVS.Size = new System.Drawing.Size(299, 22);
            this.txtVS.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Valor salvante";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 548);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtInfacion
            // 
            this.txtInfacion.Location = new System.Drawing.Point(29, 308);
            this.txtInfacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfacion.Name = "txtInfacion";
            this.txtInfacion.Size = new System.Drawing.Size(299, 22);
            this.txtInfacion.TabIndex = 7;
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(29, 233);
            this.txtTasa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.Size = new System.Drawing.Size(299, 22);
            this.txtTasa.TabIndex = 6;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(29, 146);
            this.txtPlazo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(299, 22);
            this.txtPlazo.TabIndex = 5;
            // 
            // txtInversion
            // 
            this.txtInversion.Location = new System.Drawing.Point(28, 66);
            this.txtInversion.Margin = new System.Windows.Forms.Padding(4);
            this.txtInversion.Name = "txtInversion";
            this.txtInversion.Size = new System.Drawing.Size(299, 22);
            this.txtInversion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 274);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inflacion(porcentaje)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "tasa(en porcentaje)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Plazo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Inversion
            // 
            this.Inversion.AutoSize = true;
            this.Inversion.Location = new System.Drawing.Point(25, 31);
            this.Inversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Inversion.Name = "Inversion";
            this.Inversion.Size = new System.Drawing.Size(65, 17);
            this.Inversion.TabIndex = 0;
            this.Inversion.Text = "Inversion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 547);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 22);
            this.textBox2.TabIndex = 4;
            // 
            // txtVPN
            // 
            this.txtVPN.Location = new System.Drawing.Point(79, 548);
            this.txtVPN.Name = "txtVPN";
            this.txtVPN.Size = new System.Drawing.Size(170, 22);
            this.txtVPN.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "PR:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "VPN:";
            // 
            // dgvFNE
            // 
            this.dgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFNE.Location = new System.Drawing.Point(4, 4);
            this.dgvFNE.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFNE.Name = "dgvFNE";
            this.dgvFNE.RowHeadersWidth = 51;
            this.dgvFNE.Size = new System.Drawing.Size(699, 536);
            this.dgvFNE.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FNE sin financiamiento";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFNE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtVS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInfacion;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtInversion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Inversion;
        private System.Windows.Forms.DataGridView dgvFNE;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtVPN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}


namespace Gestion_Estudiantes
{
    partial class Mostrar_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mostrar_Curso));
            this.btnRefrescarTabla = new System.Windows.Forms.Button();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCedula = new System.Windows.Forms.Button();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnHombres = new System.Windows.Forms.Button();
            this.btnMujeres = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefrescarTabla
            // 
            this.btnRefrescarTabla.Location = new System.Drawing.Point(12, 12);
            this.btnRefrescarTabla.Name = "btnRefrescarTabla";
            this.btnRefrescarTabla.Size = new System.Drawing.Size(138, 27);
            this.btnRefrescarTabla.TabIndex = 20;
            this.btnRefrescarTabla.Text = "Refrescar Tabla";
            this.btnRefrescarTabla.UseVisualStyleBackColor = true;
            this.btnRefrescarTabla.Click += new System.EventHandler(this.btnRefrescarTabla_Click);
            // 
            // dgvCurso
            // 
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Location = new System.Drawing.Point(12, 62);
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.Size = new System.Drawing.Size(644, 301);
            this.dgvCurso.TabIndex = 19;
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnMenor);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.btnMayor);
            this.panel4.Location = new System.Drawing.Point(12, 392);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 60);
            this.panel4.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estudiante Mayor y Menor Nota";
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(39, 22);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(77, 27);
            this.btnMayor.TabIndex = 6;
            this.btnMayor.Text = "Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(173, 22);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(77, 27);
            this.btnMenor.TabIndex = 8;
            this.btnMenor.Text = "Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnCedula);
            this.panel2.Controls.Add(this.txtCI);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(321, 392);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 60);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar Cédula";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCedula
            // 
            this.btnCedula.Location = new System.Drawing.Point(246, 22);
            this.btnCedula.Name = "btnCedula";
            this.btnCedula.Size = new System.Drawing.Size(77, 27);
            this.btnCedula.TabIndex = 6;
            this.btnCedula.Text = "Mostrar";
            this.btnCedula.UseVisualStyleBackColor = true;
            this.btnCedula.Click += new System.EventHandler(this.btnCedula_Click);
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(61, 26);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(179, 20);
            this.txtCI.TabIndex = 4;
            this.txtCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCI_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cédula:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(206, 484);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(190, 36);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnHombres
            // 
            this.btnHombres.Location = new System.Drawing.Point(364, 12);
            this.btnHombres.Name = "btnHombres";
            this.btnHombres.Size = new System.Drawing.Size(138, 27);
            this.btnHombres.TabIndex = 47;
            this.btnHombres.Text = "Estudiantes Hombres";
            this.btnHombres.UseVisualStyleBackColor = true;
            this.btnHombres.Click += new System.EventHandler(this.btnHombres_Click);
            // 
            // btnMujeres
            // 
            this.btnMujeres.Location = new System.Drawing.Point(518, 12);
            this.btnMujeres.Name = "btnMujeres";
            this.btnMujeres.Size = new System.Drawing.Size(138, 27);
            this.btnMujeres.TabIndex = 48;
            this.btnMujeres.Text = "Estudiantes Mujeres";
            this.btnMujeres.UseVisualStyleBackColor = true;
            this.btnMujeres.Click += new System.EventHandler(this.btnMujeres_Click);
            // 
            // Mostrar_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(664, 546);
            this.Controls.Add(this.btnMujeres);
            this.Controls.Add(this.btnHombres);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRefrescarTabla);
            this.Controls.Add(this.dgvCurso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mostrar_Curso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar_Curso";
            this.Load += new System.EventHandler(this.Mostrar_Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefrescarTabla;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCedula;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnHombres;
        private System.Windows.Forms.Button btnMujeres;
    }
}
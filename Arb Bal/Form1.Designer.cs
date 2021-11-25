
namespace Arb_Bal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPreorden = new System.Windows.Forms.Button();
            this.buttonInorden = new System.Windows.Forms.Button();
            this.buttonPosorden = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.textBoxEliminar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(70, 15);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(63, 20);
            this.textBoxNumero.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(70, 48);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(63, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(36, 78);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 24);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dataGridView.Location = new System.Drawing.Point(12, 288);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(245, 150);
            this.dataGridView.TabIndex = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numero";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // buttonPreorden
            // 
            this.buttonPreorden.Location = new System.Drawing.Point(280, 323);
            this.buttonPreorden.Name = "buttonPreorden";
            this.buttonPreorden.Size = new System.Drawing.Size(75, 23);
            this.buttonPreorden.TabIndex = 6;
            this.buttonPreorden.Text = "Preorden";
            this.buttonPreorden.UseVisualStyleBackColor = true;
            this.buttonPreorden.Click += new System.EventHandler(this.buttonPreorden_Click);
            // 
            // buttonInorden
            // 
            this.buttonInorden.Location = new System.Drawing.Point(280, 368);
            this.buttonInorden.Name = "buttonInorden";
            this.buttonInorden.Size = new System.Drawing.Size(75, 23);
            this.buttonInorden.TabIndex = 7;
            this.buttonInorden.Text = "Inorden";
            this.buttonInorden.UseVisualStyleBackColor = true;
            this.buttonInorden.Click += new System.EventHandler(this.buttonInorden_Click);
            // 
            // buttonPosorden
            // 
            this.buttonPosorden.Location = new System.Drawing.Point(280, 413);
            this.buttonPosorden.Name = "buttonPosorden";
            this.buttonPosorden.Size = new System.Drawing.Size(75, 23);
            this.buttonPosorden.TabIndex = 8;
            this.buttonPosorden.Text = "Posorden";
            this.buttonPosorden.UseVisualStyleBackColor = true;
            this.buttonPosorden.Click += new System.EventHandler(this.buttonPosorden_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Recorridos:";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(12, 255);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(37, 13);
            this.labelAltura.TabIndex = 10;
            this.labelAltura.Text = "Altura:";
            // 
            // textBoxEliminar
            // 
            this.textBoxEliminar.Location = new System.Drawing.Point(70, 15);
            this.textBoxEliminar.Name = "textBoxEliminar";
            this.textBoxEliminar.Size = new System.Drawing.Size(63, 20);
            this.textBoxEliminar.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Numero:";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(36, 45);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 24);
            this.buttonEliminar.TabIndex = 13;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxEliminar);
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(29, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 85);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGuardar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxNumero);
            this.groupBox2.Controls.Add(this.textBoxNombre);
            this.groupBox2.Location = new System.Drawing.Point(29, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 116);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Insertar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPosorden);
            this.Controls.Add(this.buttonInorden);
            this.Controls.Add(this.buttonPreorden);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Arbol Balanceado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button buttonPreorden;
        private System.Windows.Forms.Button buttonInorden;
        private System.Windows.Forms.Button buttonPosorden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.TextBox textBoxEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


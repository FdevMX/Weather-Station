
namespace Weather_Station
{
    partial class datos
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
            this.wsDatos = new System.Windows.Forms.DataGridView();
            this.Temperatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Humedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lluvia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.wsDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // wsDatos
            // 
            this.wsDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wsDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Temperatura,
            this.Humedad,
            this.Aire,
            this.Viento,
            this.Lluvia,
            this.Fecha,
            this.Hora});
            this.wsDatos.Location = new System.Drawing.Point(12, 107);
            this.wsDatos.Name = "wsDatos";
            this.wsDatos.Size = new System.Drawing.Size(743, 198);
            this.wsDatos.TabIndex = 0;
            // 
            // Temperatura
            // 
            this.Temperatura.HeaderText = "Temperatura";
            this.Temperatura.Name = "Temperatura";
            // 
            // Humedad
            // 
            this.Humedad.HeaderText = "Humedad";
            this.Humedad.Name = "Humedad";
            // 
            // Aire
            // 
            this.Aire.HeaderText = "Aire";
            this.Aire.Name = "Aire";
            // 
            // Viento
            // 
            this.Viento.HeaderText = "Viento";
            this.Viento.Name = "Viento";
            // 
            // Lluvia
            // 
            this.Lluvia.HeaderText = "Lluvia";
            this.Lluvia.Name = "Lluvia";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wsDatos);
            this.Name = "datos";
            this.Text = "datos";
            ((System.ComponentModel.ISupportInitialize)(this.wsDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView wsDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Humedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lluvia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.TextBox textBox1;
    }
}
/*
 * Creado por SharpDevelop.
 * Usuario: lopza
 * Fecha: 26/10/2026
 * Hora: 05:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace practica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.btnSumar = new System.Windows.Forms.Button();
			this.btnRestar = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.lblRespuesta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNum1
			// 
			this.lblNum1.Location = new System.Drawing.Point(31, 29);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(100, 23);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "Numero1:";
			// 
			// lblNum2
			// 
			this.lblNum2.Location = new System.Drawing.Point(31, 69);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(100, 23);
			this.lblNum2.TabIndex = 1;
			this.lblNum2.Text = "Numero2:";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(188, 29);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 22);
			this.txt1.TabIndex = 2;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(188, 69);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 22);
			this.txt2.TabIndex = 3;
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(31, 161);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 4;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.BtnSumarClick);
			// 
			// btnRestar
			// 
			this.btnRestar.Location = new System.Drawing.Point(31, 220);
			this.btnRestar.Name = "btnRestar";
			this.btnRestar.Size = new System.Drawing.Size(75, 23);
			this.btnRestar.TabIndex = 5;
			this.btnRestar.Text = "Restar";
			this.btnRestar.UseVisualStyleBackColor = true;
			this.btnRestar.Click += new System.EventHandler(this.BtnRestarClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.Location = new System.Drawing.Point(188, 151);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(75, 23);
			this.btnMultiplicar.TabIndex = 6;
			this.btnMultiplicar.Text = "Multiplicar";
			this.btnMultiplicar.UseVisualStyleBackColor = true;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnDividir
			// 
			this.btnDividir.Location = new System.Drawing.Point(188, 220);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(75, 23);
			this.btnDividir.TabIndex = 7;
			this.btnDividir.Text = "Dividir";
			this.btnDividir.UseVisualStyleBackColor = true;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(355, 206);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 8;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// lblRespuesta
			// 
			this.lblRespuesta.Location = new System.Drawing.Point(21, 285);
			this.lblRespuesta.Name = "lblRespuesta";
			this.lblRespuesta.Size = new System.Drawing.Size(188, 47);
			this.lblRespuesta.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(572, 354);
			this.Controls.Add(this.lblRespuesta);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnRestar);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.lblNum1);
			this.Name = "MainForm";
			this.Text = "practica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblRespuesta;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnRestar;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblNum1;
	}
}

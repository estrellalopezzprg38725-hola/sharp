/*
 * Creado por SharpDevelop.
 * Usuario: lopza
 * Fecha: 26/10/2026
 * Hora: 06:12 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace practica
{
	partial class Form1
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
			this.txtA = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtC = new System.Windows.Forms.TextBox();
			this.btnCalcularX1Y1 = new System.Windows.Forms.Button();
			this.lblResultadoX1 = new System.Windows.Forms.Label();
			this.lblResltadoY2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtA
			// 
			this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtA.Location = new System.Drawing.Point(13, 42);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(100, 22);
			this.txtA.TabIndex = 0;
			// 
			// txtB
			// 
			this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtB.Location = new System.Drawing.Point(174, 42);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(100, 22);
			this.txtB.TabIndex = 1;
			// 
			// txtC
			// 
			this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.txtC.Location = new System.Drawing.Point(334, 42);
			this.txtC.Name = "txtC";
			this.txtC.Size = new System.Drawing.Size(100, 22);
			this.txtC.TabIndex = 2;
			// 
			// btnCalcularX1Y1
			// 
			this.btnCalcularX1Y1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnCalcularX1Y1.Location = new System.Drawing.Point(55, 160);
			this.btnCalcularX1Y1.Name = "btnCalcularX1Y1";
			this.btnCalcularX1Y1.Size = new System.Drawing.Size(123, 70);
			this.btnCalcularX1Y1.TabIndex = 3;
			this.btnCalcularX1Y1.Text = "Calcular X1 Y1";
			this.btnCalcularX1Y1.UseVisualStyleBackColor = false;
			this.btnCalcularX1Y1.Click += new System.EventHandler(this.BtnCalcularX1Y1Click);
			// 
			// lblResultadoX1
			// 
			this.lblResultadoX1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblResultadoX1.Location = new System.Drawing.Point(360, 196);
			this.lblResultadoX1.Name = "lblResultadoX1";
			this.lblResultadoX1.Size = new System.Drawing.Size(100, 23);
			this.lblResultadoX1.TabIndex = 4;
			// 
			// lblResltadoY2
			// 
			this.lblResltadoY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.lblResltadoY2.Location = new System.Drawing.Point(563, 196);
			this.lblResltadoY2.Name = "lblResltadoY2";
			this.lblResltadoY2.Size = new System.Drawing.Size(100, 23);
			this.lblResltadoY2.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(705, 309);
			this.Controls.Add(this.lblResltadoY2);
			this.Controls.Add(this.lblResultadoX1);
			this.Controls.Add(this.btnCalcularX1Y1);
			this.Controls.Add(this.txtC);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.txtA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblResltadoY2;
		private System.Windows.Forms.Label lblResultadoX1;
		private System.Windows.Forms.Button btnCalcularX1Y1;
		private System.Windows.Forms.TextBox txtC;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.TextBox txtA;
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: lopza
 * Fecha: 26/10/2026
 * Hora: 05:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace practica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSumarClick(object sender, EventArgs e)
		{
			double num1,num2,suma;
			num1=Convert.ToDouble(txt1.Text);
			num2=Convert.ToDouble(txt2.Text);
			suma=num1+num2;
			lblRespuesta.Text=txt1.Text+" + "+txt2.Text+"="+Convert.ToString(suma);
		}
		
		void BtnRestarClick(object sender, EventArgs e)
		{
			double num1,num2,resta;
			num1=Convert.ToDouble(txt1.Text);
			num2=Convert.ToDouble(txt2.Text);
			resta=num1-num2;
			lblRespuesta.Text=txt1.Text+" - "+txt2.Text+"="+Convert.ToString(resta);
		}
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double num1,num2,multiplica;
			num1=Convert.ToDouble(txt1.Text);
			num2=Convert.ToDouble(txt2.Text);
			multiplica=num1*num2;
			lblRespuesta.Text=txt1.Text+"*"+txt2.Text+"="+Convert.ToString(multiplica);
		}
		
		void BtnDividirClick(object sender, EventArgs e)
		{
			double num1,num2,dividir;
			num1=Convert.ToDouble(txt1.Text);
			num2=Convert.ToDouble(txt2.Text);
			dividir=num1/num2;
			lblRespuesta.Text=txt1.Text+"/"+txt2.Text+"="+Convert.ToString(dividir);
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txt1.Text="";
			txt2.Text="";
			lblRespuesta.Text="";
		}
		
		void BtnModuloClick(object sender, EventArgs e)
		{
			double num1 = Convert.ToDouble(txt1.Text);
			double num2 = Convert.ToDouble(txt2.Text);
			double rest = num1%num2;
			lblRespuesta.Text=txt1.Text+"%"+txt2.Text+"="+Convert.ToString(rest);
		}
	}
}

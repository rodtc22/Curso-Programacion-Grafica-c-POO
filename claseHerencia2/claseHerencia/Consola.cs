/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 11:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace claseHerencia
{
	/// <summary>
	/// Description of Consola.
	/// </summary>
	public partial class Consola : Form
	{
		AsociacionPeriodistas a;
		ConductorTV c;
		Escritor e;
		public Consola()
		{
			InitializeComponent();			
			a = new AsociacionPeriodistas();
			c = new ConductorTV();
			e = new Escritor();
			mostrarConsola();
		}
		
		void mostrarConsola() {
			textBoxConsola.Text = a.ToString();
			textBoxConsola.Text += "\n\r\n";
			textBoxConsola.Text += c.ToString();
			textBoxConsola.Text += "\n\r\n";
			textBoxConsola.Text += e.ToString();
			textBoxConsola.Text += "\n\r\n";
			textBoxConsola.Text += a.ToString();
			textBoxConsola.Text += "\n\r\n";
			textBoxConsola.Text += a.ToString();
			textBoxConsola.Text += "\n\r\n";
			textBoxConsola.Text += a.ToString();
		}
	}
}

/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 22/7/2022
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseAgreComp
{
	/// <summary>
	/// Description of CitasMedicas.
	/// </summary>
	public class CitasMedicas
	{
		private string dia; 
		private string horario;
		private bool esReservado;
		private string idAsegurado;
		
		public CitasMedicas()
		{
			dia = "01-01-2020";
			horario = "00:00";
			esReservado = true;
			idAsegurado = "ASE-XXXX";
		}
		
		public override string ToString()
		{
			string s=  string.Format("   [CitasMedicas Dia={0}, Horario={1}, EsReservado={2}, IdAsegurado={3}]\n", dia, horario, esReservado, idAsegurado);
			return s;
		}
		
		public string Dia {
			get { return dia; }
			set { dia = value; }
		}

		public string Horario {
			get { return horario; }
			set { horario = value; }
		}

		public bool EsReservado {
			get { return esReservado; }
			set { esReservado = value; }
		}

		public string IdAsegurado {
			get { return idAsegurado; }
			set { idAsegurado = value; }
		}

	}
}

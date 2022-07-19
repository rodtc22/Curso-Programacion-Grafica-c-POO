/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 10:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseHerencia
{
	/// <summary>
	/// Description of Periodista.
	/// </summary>
	public class Periodista : Persona
	{
		private int idPeriodista;
		private bool empleado;
		private double sueldo;
		
		public Periodista() : base()
		{
			idPeriodista = 1;
			empleado = true; //si esta trabajando
			sueldo = 1234.56;
		}
		
		public Periodista (string n, string f, int c, int i, bool e, double s) : base(n,f,c) {
			idPeriodista = i;
			empleado = e;
			sueldo = s;
		}
		
		public override string ToString()
		{
			string s = base.ToString();
			s = s + string.Format("[Periodista IdPeriodista={0}, Empleado={1}, Sueldo={2}]\n\r\n", idPeriodista, empleado, sueldo);
			return s;
		}

		
		public int IdPeriodista {
			get { return idPeriodista; }
			set { idPeriodista = value; }
		}

		public bool Empleado {
			get { return empleado; }
			set { empleado = value; }
		}

		public double Sueldo {
			get { return sueldo; }
			set { sueldo = value; }
		}
	}
}

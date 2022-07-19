/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 14/7/2022
 * Time: 10:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseHerencia
{
	/// <summary>
	/// Description of Escritor.
	/// </summary>
	public class Escritor : Periodista
	{
		private string nombrePeriodico;
		private string sector;
		
		public Escritor() {
			nombrePeriodico = "la razon";
			sector = "deportes";
		}
		
		public Escritor (string n, string f, int c, int i, bool e, double s, string pe, string se) : base(n,f,c,i,e,s) {
			nombrePeriodico = pe;
			sector = se;
		}
		
		public override string ToString()
		{
			string s = base.ToString();
			s = s + string.Format("[Escritor NombrePeriodico={0}, Sector={1}]\n\r\n", nombrePeriodico, sector);
			return s;
		}
		
		public string NombrePeriodico {
			get { return nombrePeriodico; }
			set { nombrePeriodico = value; }
		}

		public string Sector {
			get { return sector; }
			set { sector = value; }
		}
	}
}

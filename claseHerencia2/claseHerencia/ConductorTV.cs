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
	/// Description of ConductorTV.
	/// </summary>
	public class ConductorTV : Periodista
	{
		private string casatelevisiva;
		private string programa;
		
		public ConductorTV() : base()
		{
			casatelevisiva = "bolivision";
			programa = "noticiero";
		}
		
		public ConductorTV (string n, string f, int c, int i, bool e, double s, string ca, string pr) : base(n,f,c,i,e,s) {
			casatelevisiva = ca;
			programa = pr;
		}
		
		public override string ToString()
		{
			string s = base.ToString();
			s = s + string.Format("[ConductorTV Casatelevisiva={0}, Programa={1}]\n\r\n", casatelevisiva, programa);
			return s;
		}

		
		public string Casatelevisiva {
			get { return casatelevisiva; }
			set { casatelevisiva = value; }
		}

		public string Programa {
			get { return programa; }
			set { programa = value; }
		}
	}
}

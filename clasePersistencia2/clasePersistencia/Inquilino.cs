/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace clasePersistencia
{
	
	public class Inquilino : Persona //hereda de persona
	{
		private string idInquilino;
		private ContratoAlquiler contrato;
		
		public Inquilino() : base() //llamar al contructor de la clase padre
		{
			idInquilino = "INQ-XXX";
			contrato = new ContratoAlquiler();
		}
		
		public Inquilino(string nom, string pat, string mat, int ci, string naci) : base(nom,pat,mat,ci,naci) //llamar al contructor de la clase padre
		{
			idInquilino = "INQ-XXX";
			contrato = new ContratoAlquiler();
		}
		
		public override string ToString()
		{
			string s = base.ToString(); //muestro a la clase padre
			s +=  string.Format("[Inquilino IdInquilino={0}, Contrato={1}]\n", idInquilino, contrato);
			return s;
		}
		
		public void escrituraInquilino (BinaryWriter escritor) {
			base.escrituraPersona(escritor); // escribo los datos que tiene mi clase padre
			escritor.Write(idInquilino);
			contrato.escrituraContrato(escritor); //como es objeto se hace asi
		}
		
		public void lecturaInquilino (BinaryReader lector) {
			base.lecturaPersona(lector);
			idInquilino = lector.ReadString();
			contrato.lecturaContrato(lector);
		}
			
		public string IdInquilino {
			get { return idInquilino; }
			set { idInquilino = value; }
		}

		public ContratoAlquiler Contrato {
			get { return contrato; }
			set { contrato = value; }
		}
	}
}

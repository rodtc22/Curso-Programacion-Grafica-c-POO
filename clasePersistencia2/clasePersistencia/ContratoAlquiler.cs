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
	public class ContratoAlquiler
	{
		private string idDepartamento;
		private string fechainicio;
		private string fechafin;
		
		public ContratoAlquiler()
		{
			idDepartamento = "DEP-XXX";
			fechainicio = "01-01-2000";
			fechafin = "01-01-2000";
		}
		
		public ContratoAlquiler(string id, string ini, string fin)
		{
			idDepartamento = id;
			fechainicio = ini;
			fechafin = fin;
		}
		
		public override string ToString()
		{
			string s =  string.Format("[ContratoAlquiler IdDepartamento={0}, Fechainicio={1}, Fechafin={2}]\n", idDepartamento, fechainicio, fechafin);
			return s;
		}
		
		public void escrituraContrato (BinaryWriter escritor) {
			escritor.Write (idDepartamento);
			escritor.Write (fechainicio);
			escritor.Write (fechafin);
		}
	
		public void lecturaContrato (BinaryReader lector) {
			idDepartamento = lector.ReadString();
			fechainicio = lector.ReadString();
			fechafin = lector.ReadString();
		}
		
		public string IdDepartamento {
			get { return idDepartamento; }
			set { idDepartamento = value; }
		}

		public string Fechainicio {
			get { return fechainicio; }
			set { fechainicio = value; }
		}

		public string Fechafin {
			get { return fechafin; }
			set { fechafin = value; }
		}
	}
}

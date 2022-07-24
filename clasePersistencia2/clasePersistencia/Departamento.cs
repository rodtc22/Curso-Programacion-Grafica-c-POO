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
	public class Departamento
	{
		private string idDepartamento;
		private double costo;
		private int superficie; //en m^2
		private int tipo; //dato extra para la interfaz, y para mostrarle imagen
		
		public Departamento()
		{
			idDepartamento = "DEP-XXX";
			costo = -1; // u otro valor
			superficie = 20;
			tipo = 0;
		}
		
		public Departamento(double co,  int su, int ti)
		{
			idDepartamento = "DEP-XXX";
			costo = co;
			superficie = su;
			tipo = ti;
		}
		
		public override string ToString()
		{
			string s = string.Format("[Departamento IdDepartamento={0}, Costo={1}, Superficie={2}, Tipo={3}]\n", idDepartamento, costo, superficie,tipo);
			return s;
		}
		
		public void escrituraDepartamento (BinaryWriter escritor) {
			escritor.Write (idDepartamento);
			escritor.Write (costo);
			escritor.Write (superficie);
			escritor.Write (tipo);
		}
		
		public void lecturaDepartamento (BinaryReader lector) {
			idDepartamento = lector.ReadString();
			costo = lector.ReadDouble();
			superficie = lector.ReadInt32();
			tipo = lector.ReadInt32();
		}
		
		public int Tipo {
			get { return tipo; }
			set { tipo = value; }
		}
		
		public string IdDepartamento {
			get { return idDepartamento; }
			set { idDepartamento = value; }
		}

		public double Costo {
			get { return costo; }
			set { costo = value; }
		}

		public int Superficie {
			get { return superficie; }
			set { superficie = value; }
		}

	}
}

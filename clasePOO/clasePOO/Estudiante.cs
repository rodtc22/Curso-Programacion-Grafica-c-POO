using System;

namespace clasePOO
{

	public class Estudiante
	{
		private int idEstudiante;
		private string carrera;
		private int ci;
		private string fechanac;
		private string nombre, paterno, materno;
		
		public Estudiante() //por defecto
		{
			idEstudiante = 123;
			carrera = "informatica";
			ci = 456;
			fechanac = "06/09/1999";
			nombre = "rodrigo";
			paterno = "ticona";
			materno = "coronel";
		}
		
		public Estudiante(int id, string ca, int c, string fe, string nom, string pat, string mat) //con parametros
		{
			idEstudiante = id;
			carrera = ca;
			ci = c;
			fechanac = fe;
			nombre = nom;
			paterno = pat;
			materno = mat;
		}
		
		public string mostrar() {
			string s = "";
			s += idEstudiante + "\n";
			s += carrera + "\n";
			s += ci + "\n";
			s += fechanac + "\n";
			s += nombre + "\n";
			s += paterno + "\n";
			s += materno + "\n";
			return s;
		}
	}
}

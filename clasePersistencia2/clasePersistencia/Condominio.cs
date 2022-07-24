/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 23/7/2022
 * Time: 17:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace clasePersistencia
{
	public class Condominio
	{
		private Persona duenio;
		private string nombreCondominio;
		private string direccion;
		private int telefono;
		private int nroDepa;
		private Departamento [] depa = new Departamento[100];
		private int nroInqu;
		private Inquilino [] inqu = new Inquilino[100];
		
		public Condominio()
		{
			duenio = new Persona();
			nombreCondominio = "Buena Vida";
			direccion = "Av. Juan Pablo II";
			telefono = 223344;
			
//			nroDepa = 2;
			for (int i = 0 ; i < 2; i++)
				agregarDepartamento(new Departamento());
			
			nroInqu = 0;
		}
		
		public override string ToString()
		{
			string s = "====================CONDOMINIO===============\n"; 
			s +=  string.Format("[Condominio Duenio={0}, NombreCondominio={1}, Direccion={2}, Telefono={3}, NroDepa={4}]\n", duenio, nombreCondominio, direccion, telefono, nroDepa);
			s += "\n   nroDepartamentos " + nroDepa + "\n";
			for (int i = 0 ;i < nroDepa ;i++ ) 
				s += depa[i].ToString();
			
			s += "\n   nroInquilinos " + nroInqu + "\n";
			for (int i = 0 ;i < nroInqu ;i++ ) 
				s += inqu[i].ToString();
			
			return s;
		}
		
		
		
		public void agregarInquilino (Inquilino i) {
			i.IdInquilino = "INQ-" + (nroInqu+1).ToString("D3"); //asignarle un id con el formato
			inqu[nroInqu] = i;
			nroInqu++;
		}
		
		public void quitarInquilino (string id) {  
			int index = buscarInquilino(id);
			for (int i = index ; i < nroInqu - 1; i++) //solapamiento con el siguiente a la derecha
				inqu[i] = inqu[i+1];
			nroInqu--;
		}
		
		public int buscarInquilino (string idbuscado) {
			int index = -1;
			for (int i = 0 ;i < nroInqu ;i++) {
				if (inqu[i].IdInquilino == idbuscado) {
					index = i;
				}
			}
			return index;
		}
		
		
		public void agregarDepartamento (Departamento d) { //o construir departamento
			d.IdDepartamento = "DEP-" + (nroDepa+1).ToString("D3");
			depa[nroDepa] = d;
			nroDepa++;
		}
		
		public void quitarDepartamento () { //o demoler el piso de arriba		
			nroDepa--;
		}
		
		
		public void escrituraCondominio (BinaryWriter escritor) {
			duenio.escrituraPersona(escritor);
			
			escritor.Write(nombreCondominio);
			escritor.Write(direccion);
			escritor.Write(telefono);
			
			escritor.Write(nroDepa);
			for (int i = 0 ;i < nroDepa ;i++) //asi se escriben los vectores , para matrices se usan 2 for, como siempre
				depa[i].escrituraDepartamento(escritor);
			
			escritor.Write(nroInqu);
			for (int i = 0 ;i < NroInqu; i++) 
				inqu[i].escrituraInquilino(escritor);
		}
		
		public void lecturaCondominio (BinaryReader lector) {
			duenio = new Persona(); // si no esta instanciado en el contructor, nunca olvidar instanciarlo, antes de usar el metodo de lectura
			duenio.lecturaPersona(lector);
			
			nombreCondominio = lector.ReadString();
			direccion = lector.ReadString();
			telefono = lector.ReadInt32();
			
			nroDepa = lector.ReadInt32();
			for (int i = 0 ;i < nroDepa ;i++) { //asi se leen los vectores , para matrices se usan 2 for, como siempre
				depa[i] = new Departamento(); //NUNCA OLVIDAR INSTANCIAR EL OBJECTO ANTES DE LEERLO DEL ARCHIVO
				depa[i].lecturaDepartamento(lector);
			}
				
			nroInqu = lector.ReadInt32();
			for (int i = 0 ;i < nroInqu ;i++) { //asi se leen los vectores , para matrices se usan 2 for, como siempre
				inqu[i] = new Inquilino(); //NUNCA OLVIDAR INSTANCIAR EL OBJECTO ANTES DE LEERLO DEL ARCHIVO
				inqu[i].lecturaInquilino(lector);
			}
		}
		
		public Persona Duenio {
			get { return duenio; }
			set { duenio = value; }
		}

		public string NombreCondominio {
			get { return nombreCondominio; }
			set { nombreCondominio = value; }
		}

		public string Direccion {
			get { return direccion; }
			set { direccion = value; }
		}

		public int Telefono {
			get { return telefono; }
			set { telefono = value; }
		}

		public int NroDepa {
			get { return nroDepa; }
			set { nroDepa = value; }
		}

		public Departamento[] Depa {
			get { return depa; }
			set { depa = value; }
		}

		public int NroInqu {
			get { return nroInqu; }
			set { nroInqu = value; }
		}

		public Inquilino[] Inqu {
			get { return inqu; }
			set { inqu = value; }
		}

	}
}

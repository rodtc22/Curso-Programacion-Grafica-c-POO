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
	public class ArchivoCondominio
	{
		string ruta; //no es necesario poner C:/.... , es suficiente con poner el nombre del archivo, ej: datos.txt o datos.dat ,...
		
		public ArchivoCondominio (string r) {
			ruta = r;
		}
		
		public void crearArchivo () {
			if (File.Exists(ruta)) {
				File.Delete(ruta);
			}
		}
		
		public void agregarCondominio (Condominio con) {
			Stream arch = File.Open(ruta, FileMode.Append);
			BinaryWriter escritor = new BinaryWriter (arch);
			
			try {
				con.escrituraCondominio(escritor); //le digo que se escriba mediante el binarywriter llamado escritor
			} catch (Exception) {
			} finally {
				arch.Close();
			}
		}
		
		public void agregarInquilinoArchivo (Inquilino i) {
			Condominio con = dameCondominio();
			con.agregarInquilino(i);
			
			Stream archtmp = File.Open("tmp.txt", FileMode.Append);
			BinaryWriter escritor = new BinaryWriter (archtmp);
			con.escrituraCondominio(escritor);
			archtmp.Close();
			
			File.Copy("tmp.txt",ruta,true);
			File.Delete("tmp.txt");
		}
		
		public Condominio dameCondominio() {
			Stream arch = File.Open(ruta,FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(arch);
			
			Condominio con = new Condominio();
			con.NombreCondominio = "-1";
			try {
				con.lecturaCondominio(lector);
			} catch (Exception) {
			} finally {
				arch.Close();
			}
			return con;
		}
		
		public string listarCondominios () {
			Stream arch = File.Open(ruta,FileMode.OpenOrCreate);
			BinaryReader lector = new BinaryReader(arch);
			
			Condominio con = new Condominio();
			string consola = "";
			try {
				while (true) {
					con.lecturaCondominio(lector);
					consola += con.ToString();
				}
			} catch {
				// no hacer nada por que si entra al catch significa que ya hizo la lectura de todo
				
			} finally {
				arch.Close();
				
			}
			
			return consola;
		}
	}
}

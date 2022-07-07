/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 7/7/2022
 * Time: 9:10 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseSobrecarga
{
	/// <summary>
	/// Description of Pasteleria.
	/// </summary>
	public class Pasteleria
	{
		private string duenio;
		private string direccion;
		private int telefono;
		private int nroproductos;
		private string [,] producto = new string[100,4]; //manejamos index 0
		
		public Pasteleria()
		{
			duenio = "Don Jorge";
			direccion = "Av. Juan Pablo II";
			telefono = 1234567;
			nroproductos = 2;
			
			//primer producto
			producto[0,0] = "latte";	//nombre del producto
			producto[0,1] = "20"; 		//precio del producto
			producto[0,2] = "12"; 		//cantidad disponible del producto
			producto[0,3] = "bebida";	//tipo de producto (bebida, comida, postre)

			//segundo producto
			producto[1,0] = "rebanada pastel"; 
			producto[1,1] = "8"; 
			producto[1,2] = "7"; 
			producto[1,3] = "postre";		
		}
		
		public Pasteleria(string du, string di, int te)
		{
			duenio = du;
			direccion = di;
			telefono = te;
			nroproductos = 0;		
		}
		
		public string mostrar() {
			string s = ".............PASTELERIA..............\n"; 
			s += "duenio: " + duenio + "\n";
			s += "direccion: " + direccion + "\n";
			s += "telefono: " + telefono + "\n";
			s += "nroproductos: " + nroproductos + "\n";
			s += "==========PRODUCTOS==========\n";
			for (int i = 0 ;i < nroproductos ;i++) {
				s += "prod " + i + ": " + producto[i,0] + " " + producto[i,1] + " " + producto[i,2] + " " + producto[i,3] + "\n";    
			}
			s += "\n";
			return s;
		}
		
		
		//getters y setters
		public string Duenio {
			get { return duenio; }
			set { duenio = value; }
		}

		public string Direccion {
			get { return direccion; }
			set { direccion = value; }
		}

		public int Telefono {
			get { return telefono; }
			set { telefono = value; }
		}

		public int Nroproductos {
			get { return nroproductos; }
			set { nroproductos = value; }
		}

		public string[,] Producto {
			get { return producto; }
			set { producto = value; }
		}
	}
}

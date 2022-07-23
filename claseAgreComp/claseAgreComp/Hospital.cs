/*
 * Created by SharpDevelop.
 * User: rodrix
 * Date: 22/7/2022
 * Time: 13:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace claseAgreComp
{
	/// <summary>
	/// Description of Hospital.
	/// </summary>
	public class Hospital
	{
		private Doctor doctorEncargado; //director
		private int nroDoctores;
		private Doctor [] doc = new Doctor[100];
		private int nroAsegurados;
		private Asegurado [] aseg = new Asegurado[100];
		
		public Hospital()
		{
			doctorEncargado = new Doctor("DOC-000",  "Jorge", "Oftalmologia");  //director hospital
			
			nroDoctores= 1;
			for (int i = 0 ;i < nroDoctores ;i++) {
				doc[i] = new Doctor();
				doc[i].IdDoctor = "DOC-" + (i+1).ToString("D3");  // DOC-001
			}
			
			nroAsegurados = 1;
			for (int i = 0 ;i < nroAsegurados ;i ++) {
				aseg[i] = new Asegurado();
				aseg[i].IdAsegurado = "ASE-"+ (i+1).ToString("D4"); //ASE-0001
			}
				
			
		}
		
		public override string ToString()
		{
			string s = "=========HOSPITAL=========\n";
			s += "Diretor del hospital: " + doctorEncargado + "\n";
			s += "nroDoctores: " + nroDoctores + "\n";
			for (int i = 0 ;i < nroDoctores; i++ ) 
				s += "doc "+(i+1) + ": " + doc[i].ToString();
			s += "\n";
			s += "nroAsegurados: " + nroAsegurados+ "\n";
			for (int i = 0 ;i < nroAsegurados; i++ ) 
				s += "aseg"+(i+1) + ": " + aseg[i].ToString();
			return s;
		}
		
		public void agregaDoctor (Doctor d) {
			d.IdDoctor = "DOC-" + (nroDoctores+1).ToString("D3");
			doc[nroDoctores] = d;
			nroDoctores++;
		}
		
		public void eliminaDoctor (string iddoc) {
			int index = buscarDoctor (iddoc);
			for (int i = index; i < nroDoctores - 1;i++) 
				doc[i] = doc[i+1];
			nroDoctores--;
		}
		
		int buscarDoctor (string id) {
			int index = -1;
			for (int i = 0 ;i < nroDoctores ;i++) {
				if (id == doc[i].IdDoctor) {
					index = i;
				}
			}	
			return index;
		}
		
		public void agregaAsegurado (Asegurado a) {
			a.IdAsegurado = "ASE-" + (nroAsegurados+1).ToString("D4");
			aseg[nroAsegurados] = a;
			nroAsegurados++;
		}
		
		public void eliminaAsegurado (int index) {
			for (int i = index ;i < nroAsegurados - 1 ;i++ ){
				aseg[i] = aseg[i+1];
			}
			nroAsegurados--;
		}

		
		public int NroDoctores {
			get { return nroDoctores; }
			set { nroDoctores = value; }
		}

		public Doctor[] Doc {
			get { return doc; }
			set { doc = value; }
		}

		public int NroAsegurados {
			get { return nroAsegurados; }
			set { nroAsegurados = value; }
		}

		public Asegurado[] Aseg {
			get { return aseg; }
			set { aseg = value; }
		}

		public Doctor DoctorEncargado {
			get { return doctorEncargado; }
			set { doctorEncargado = value; }
		}
	}
}

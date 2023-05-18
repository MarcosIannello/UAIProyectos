﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjclase6
{
    public class Estacionamiento
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}


		private int capacidadPlantaAlta;

		public int CapacidadPlantaAlta
		{
			get { return capacidadPlantaAlta; }
			set { capacidadPlantaAlta = value; }
		}

        private int capacidadPlantaBaja;

        public int CapacidadPlantaBaja
        {
            get { return capacidadPlantaBaja;}
            set { capacidadPlantaBaja = value; }
        }

		private int disponibilidadAlta;

		public int DisponibilidadAlta
        {
			get { return disponibilidadAlta; }
			set { disponibilidadAlta = value; }
		}

		private int disponibilidadBaja;

		public int DisponibilidadBaja
        {
			get { return disponibilidadBaja; }
			set { disponibilidadBaja = value; }
		}



		private List<Estacionamiento> estacionamientos;

		public List<Estacionamiento> Estacionamientos
		{
			get { return estacionamientos; }
			set { estacionamientos = value; }
		}


	}
}
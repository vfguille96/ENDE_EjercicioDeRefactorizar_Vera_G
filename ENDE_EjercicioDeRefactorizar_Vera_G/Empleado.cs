using System;
using System.Collections.Generic;

namespace Refactorizar
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.ReadLine();
		}
	}

	public class Persona
	{
		private string _nombre;
		private uint _edad;
		private DateTime _fechaNacimiento;
		private string _telefonoPrincipal;
		private List<string> _listaTelefonoMovil;

		public string Nombre
		{
			get { return _nombre; }
			set
			{
				if (_nombre != value)
					_nombre = value;
			}
		}

		public uint Edad
		{
			get { return _edad; }
			set
			{
				if (_edad != value)
					_edad = value;
			}
		}

		public DateTime FechaNacimiento
		{
			get { return _fechaNacimiento; }
			set
			{
				if (_fechaNacimiento != value)
					_fechaNacimiento = value;
			}
		}

		public string TelefonoPrincipal
		{
			get { return _telefonoPrincipal; }
			set
			{
				if (_telefonoPrincipal != value)
					_telefonoPrincipal = value;
			}
		}

		public List<string> ListaTelefonoMovil
		{
			get { return _listaTelefonoMovil; }
			set
			{
				if (_listaTelefonoMovil != value)
					_listaTelefonoMovil = value;
			}
		}

		public Persona(string telefonoMovil)
		{
			ListaTelefonoMovil.Add(telefonoMovil);
		}

		public Persona(string nombre, DateTime fechaNacimiento, string telefono)
		{
			this._nombre = nombre;
			this._fechaNacimiento = fechaNacimiento;
			this._edad = CalcularEdad(_fechaNacimiento);
			this._telefonoPrincipal = telefono;
		}

		/// <summary>
		/// Método que calcula la edad actual a partir de la fecha de nacimiento.
		/// </summary>
		/// <param name="FechaNacimiento"></param>
		/// <returns>La edad actual calculada.</returns>
		public static uint CalcularEdad(DateTime FechaNacimiento)
		{
			DateTime fechaHoy = DateTime.Today;
			int edad = fechaHoy.Year - FechaNacimiento.Year;

			if (FechaNacimiento > fechaHoy.AddYears(-edad))
				edad--;

			return uint.Parse(edad.ToString());
		}

		public void ImprimeInformacionPersonal()
		{
			Console.WriteLine(ToString());
		}

		public override string ToString()
		{
			return "Nombre: " + Nombre + "Edad: " + Edad + "Telefono: " + TelefonoPrincipal;
		}
	}

	internal class Empleado : Persona
	{
		public Empleado(string telefonoMovil) : base(telefonoMovil)
		{
			if (telefonoMovil == null)
				ListaTelefonoMovil.Add("<desconocido>");
			else
				ListaTelefonoMovil.Add(telefonoMovil);
		}

		public void ImprimirInformeCompleto()
		{
			ImprimeInformacionPersonal();
			Console.WriteLine("Telefonos moviles: ");
			foreach (string telefonoMovil in ListaTelefonoMovil)
				Console.WriteLine("Movil: {0}", telefonoMovil);
		}
	}
}
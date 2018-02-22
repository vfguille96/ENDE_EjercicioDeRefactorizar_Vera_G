using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactorizar
{
	public class Empleado: Persona {
public string str;
public int edad;
public string numTelefono;
public List<string> moviles;
public Empleado (string telefono):base(telefono) { moviles.Add("<desconocido>");
}
public void ImprimeInfoPersonal () {
Console.WriteLine("Nombre: {0}, Edad: {1}, Telefono: {2}", str, edad, numTelefono);
}
public void ImprimeTodo () { 
	Console.WriteLine ("Nombre: {0}, Edad: {1}, Telefono: {2}", str, edad, numTelefono);
Console.WriteLine ("Telefonos moviles: ");
foreach (string s in moviles) {
Console.WriteLine("Movil: {0}",s);
}
}
}
}
}

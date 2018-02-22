using System;
using System.Collections.Generic;

namespace Refactorizar
{
 public class Persona {
 public string numeroDeTelefono;
 public Persona() {
 Console.WriteLine("Error: este constructor " +
"no deberia ser llamado");
}
public Persona (string telefono) {
 this.numeroDeTelefono = telefono;
}
public string getNumeroDeTelefono () {
 return this.numeroDeTelefono;
}
public void setNumeroDeTelefono (string numero) {
 this.numeroDeTelefono = numero;
}
}
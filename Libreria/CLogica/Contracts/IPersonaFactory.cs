using CEntidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CLogica.Contracts
{
    public interface IPersonaFactory
    {
        Persona CrearPersona(Persona personaDto);
        Autor CrearAutor(Autor autorDto);
        Cliente CrearCliente(Cliente clienteDto);
        Empleado CrearEmpleado(Empleado empleadoDto);
    }
}

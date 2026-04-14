using Clase_ICDIA_Unidad3.Programas;

namespace Clase_ICDIA_Unidad3.Runners;

public class Runner01_ArchivoAlumno
{
    public Runner01_ArchivoAlumno()
    {
        Alumno al1 = new Alumno(1,"Juan Perez");
        Alumno al2 = new Alumno(2,"Emilio Perez");
        Alumno al3 = new Alumno(3,"Juan Segundo"); 
        
        StreamWriter sw = new StreamWriter("alumnos.csv", true);
        
        sw.WriteLine(al1.Matricula + "," + al1.Nombre);
        sw.WriteLine(al2.Matricula + "," + al2.Nombre);
        sw.WriteLine(al3.Matricula + "," + al3.Nombre);
        
        sw.Flush();
        sw.Close();
        
    }
}
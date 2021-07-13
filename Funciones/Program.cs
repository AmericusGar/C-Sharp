using System;

 namespace funciones
{
     class Program
     {
         
        static  void  Main (string [] argumentos )
        {
            Alumno a  =  new  alumno ( 1 , " Juan " , " Pérez " );
            Alumno  b  =  new alumno ( 2 , " Maria " , " Martínez " );

            a.inactivarAlumno ();

            Console. WriteLine ( a . NombreCompleto ());
            Console. WriteLine ( b . NombreCompleto ());

            a.activarAlumno ();

            Console.WriteLine ( " " );

            Console.WriteLine ( a . NombreCompleto ());
            Console.WriteLine ( b . NombreCompleto ());
        }
    }
}
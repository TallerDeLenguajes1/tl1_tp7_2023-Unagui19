using EmpEspace;


Empleados empleado1 = new Empleados();
empleado1.Nombre="Franco";
empleado1.Apellido="Rodriguez";
empleado1.FechaNac=new DateTime(1996,12,19);
empleado1.Genero='M';
empleado1.EstadoCivil='C';
empleado1.Cargo=Cargos.Ingeniero;
empleado1.SueldoBasico=(double)Cargos.Ingeniero;
empleado1.FechaIngreso=new DateTime(2015, 03, 15);
Console.WriteLine("\n\tEmpleado 1\n");
Console.WriteLine("Nombre: "+empleado1.Nombre);
Console.WriteLine("Apellido: "+empleado1.Apellido);
Console.WriteLine("Fecha de nacimiento: "+empleado1.FechaNac);
Console.WriteLine("Genero: "+empleado1.Genero+" (M: masculino, F: femenino)");
Console.WriteLine("Estado Civil: "+empleado1.EstadoCivil+" (C: casado, S: soltero)");
Console.WriteLine("Cargo: "+empleado1.Cargo);
Console.WriteLine("Sueldo básico: "+empleado1.SueldoBasico);
Console.WriteLine("Fecha de ingreso: "+empleado1.FechaIngreso);
Console.WriteLine("Edad:"+empleado1.edad(empleado1.FechaNac));
Console.WriteLine("Faltan "+empleado1.jubilacion(empleado1.Genero,empleado1.FechaIngreso)+" años para jubilarese\n");
Console.WriteLine("Edad:"+empleado1.salario(empleado1.SueldoBasico, empleado1.FechaIngreso, empleado1.Cargo, empleado1.EstadoCivil));




Empleados empleado2 = new Empleados();
empleado2.Nombre="Lourdes";
empleado2.Apellido="Velazquez";
empleado2.FechaNac=new DateTime(1995,01,12);
empleado2.Genero='F';
empleado2.EstadoCivil='S';
empleado2.Cargo=Cargos.Especialista;
empleado2.SueldoBasico=(double)Cargos.Especialista;
empleado2.FechaIngreso=new DateTime(2014, 07, 25);
Console.WriteLine("\n\tEmpleado 2\n");
Console.WriteLine("Nombre: "+empleado2.Nombre);
Console.WriteLine("Apellido: "+empleado2.Apellido);
Console.WriteLine("Fecha de nacimiento: "+empleado2.FechaNac);
Console.WriteLine("Genero: "+empleado2.Genero+" (M: masculino, F: femenino)");
Console.WriteLine("Estado Civil: "+empleado2.EstadoCivil+" (C: casado, S: soltero)");
Console.WriteLine("Cargo: "+empleado2.Cargo);
Console.WriteLine("Sueldo básico: "+empleado2.SueldoBasico);
Console.WriteLine("Fecha de ingreso: "+empleado2.FechaIngreso);
Console.WriteLine("Edad:"+empleado2.edad(empleado2.FechaNac));
Console.WriteLine("Faltan "+empleado2.jubilacion(empleado2.Genero,empleado2.FechaIngreso)+" años para jubilarese\n");
Console.WriteLine("Salario:"+empleado2.salario(empleado2.SueldoBasico, empleado2.FechaIngreso, empleado2.Cargo, empleado2.EstadoCivil));


Empleados empleado3 = new Empleados();
empleado3.Nombre="Norma";
empleado3.Apellido="Romano";
empleado3.FechaNac=new DateTime(1967,09,21);
empleado3.Genero='F';
empleado3.EstadoCivil='C';
empleado3.Cargo=Cargos.Administrativo;
empleado3.SueldoBasico=(double)Cargos.Especialista;
empleado3.FechaIngreso=new DateTime(1990, 10, 08);
Console.WriteLine("\n\tEmpleado 3\n");
Console.WriteLine("Nombre: "+empleado3.Nombre);
Console.WriteLine("Apellido: "+empleado3.Apellido);
Console.WriteLine("Fecha de nacimiento: "+empleado3.FechaNac);
Console.WriteLine("Genero: "+empleado3.Genero+" (M: masculino, F: femenino)");
Console.WriteLine("Estado Civil: "+empleado3.EstadoCivil+" (C: casado, S: soltero)");
Console.WriteLine("Cargo: "+empleado3.Cargo);
Console.WriteLine("Sueldo básico: "+empleado3.SueldoBasico);
Console.WriteLine("Fecha de ingreso: "+empleado3.FechaIngreso);
Console.WriteLine("Edad:"+empleado3.edad(empleado3.FechaNac));
Console.WriteLine("Faltan "+empleado3.jubilacion(empleado3.Genero,empleado3.FechaIngreso)+" años para jubilarese\n");
Console.WriteLine("Salario:"+empleado3.salario(empleado3.SueldoBasico, empleado3.FechaIngreso, empleado3.Cargo, empleado3.EstadoCivil));

// Instanciar la clase Persona y asignar valores a sus propiedades

DateTime nacimiento = Convert.ToDateTime("1990-01-01");

Persona persona = new Persona(
    name: "Juan",
    edad: 20,
    apellidoP: "Pérez",
    apellidoM: "García",
    fechaNacimiento: nacimiento
);


DateTime nacimiento2 = Convert.ToDateTime("1995-05-15");

Persona persona2 = new Persona(
    name: "Maria",
    edad: 33,
    apellidoP: "López",
    apellidoM: "Hernández",
    fechaNacimiento: nacimiento2
);


// Mostrar la información de las personas

Console.WriteLine(
    $"La persona 1 es {persona.Name} {persona.ApellidoP} " +
    $"{persona.ApellidoM}, tiene {persona.Edad} años y nació el " +
    $"{persona.FechaNacimiento.ToShortDateString()}"
);

Console.WriteLine(
    $"La persona 2 es {persona2.Name} {persona2.ApellidoP} " +
    $"{persona2.ApellidoM}, tiene {persona2.Edad} años y nació el " +
    $"{persona2.FechaNacimiento.ToShortDateString()}"
);
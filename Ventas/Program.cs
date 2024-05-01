// See https://aka.ms/new-console-template for more information

int precioCodigo(string codigo)
{
    int precio;

    switch (codigo)
    {
        case "DES":
            precio = 200;
            break;
        case "JP":
            precio = 300;
            break;
        case "DET":
            precio = 250;
            break;
        default:
            precio = 0;
            break;
    }

    return precio;
}

void venta()
{
    string codigo = "";
    int cantProductos;
    int montoAPagar = 0;
    string confirmacion;

    Console.WriteLine("Estos son nuestros productos");
    Console.WriteLine("Código        Descripción        Precio\r\nDES          Desodorante        200\r\nJP           Jabón en Polvo        300\r\nDET         Detergente       250");

    while (codigo != "FIN")
    {
        Console.WriteLine("Ingrese el codigo que desea comprar");
        codigo = Console.ReadLine().ToUpper();

        if (codigo == "FIN")
        {
            break;
        }
        int precio = precioCodigo(codigo);

        Console.WriteLine("Ingrese la cantidad que desea comprar");
        cantProductos = int.Parse(Console.ReadLine());

        montoAPagar += cantProductos * precio;

    }
    //TODO el final de la compra
    Console.WriteLine("Su monto a pagar es {0}", montoAPagar);
    Console.WriteLine("Desea realizar la compra? Si/No");
    confirmacion = Console.ReadLine().ToUpper();

    if (confirmacion == "SI")
    {
        Console.WriteLine("Gracias por la compra!!");
    }
}

bool validarPassword(string password)
{
    return password.Equals("abc123");
}

void validarIngreso()
{
    string usuario;
    string password;
    bool ingreso = true;
    int intentos = 0;
    int restantes;

    while (ingreso)
    {
        Console.WriteLine("Login en Ecommerce\r\n");
        Console.WriteLine("Usuario: ");
        usuario = Console.ReadLine();
        Console.WriteLine("contraseña: ");
        password = Console.ReadLine();
        intentos++;

        if (validarPassword(password))
        {
            Console.WriteLine($"Bienvenido al Ecommerce {usuario}!");
            venta();
            break;
        }
        else if(intentos >= 5)
        {
            Console.WriteLine("Se agotó la cantidad de reintentos permitidos");
            break;
        }
        restantes = 5 - intentos;
        Console.WriteLine($"Credenciales inválidas. Reingrese sus credenciales de acceso. Le quedan {restantes} reintentos\n");
    }
}

validarIngreso();


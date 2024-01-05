ProcesoDeVenta();

void ProcesoDeVenta()
{
    //Mostrar opciones de códigos de compra
    Console.WriteLine("Use los siguientes códigos para seleccionar un producto y agregarlos :\n1. DES(Desodorante)=200$\n2. JP(Jabón en polvo)=300$\n3. DET(Detergente)=250\nUse el código FIN para dejar de agregar productos y ver su monto final");
    //Mostrar opciones de códigos de compra

    //Muestra del monto final y respuesta de la compra
    int Monto_a_Pagar = CalculoDeMonto();

    Console.WriteLine("El monto a pagar es:" + Monto_a_Pagar);
    Console.WriteLine("Opciones:\nsi. Para confirmar su compra\nno. Para cancelar su compra");

    string Respuesta;
    Console.Write("Respuesta:");
    Respuesta = Console.ReadLine();

    switch (Respuesta)
    {
        case "si":
            Console.WriteLine("Gracias por comprar en nuestra tienda");
            break;

        case "no":
            Console.WriteLine("Compra cancelada, saliendo del sistema");
            break;

        case "SI":
            Console.WriteLine("Gracias por comprar en nuestra tienda");
            break;

        case "NO":
            Console.WriteLine("Compra cancelada, saliendo del sistema");
            break;

        default:
            Console.WriteLine("Usted no ha elegido ninguna opción");
            break;
    }
    //Muestra del monto final y respuesta de la compra
}

int CalculoDeMonto()
{
    //Variables a usar como cantidad para multiplicar a su monto
    string CodigoProducto;
    int Desodorante = 0;
    int Detergente = 0;
    int JabonEnPolvo = 0;
    int MontoTotal = 0;
    //Variables a usar como cantidad para multiplicar a su monto

    //Eleccion de productos con sus respectivos codigos
    Console.Write("Ingrese el código del producto:");
    CodigoProducto = Console.ReadLine();
    switch (CodigoProducto)
    {
        case "DES":
            Desodorante++;
            break;

        case "JP":
            JabonEnPolvo++;
            break;

        case "DET":
            Detergente++;
            break;
    }

    while (CodigoProducto != "FIN")
    {
        Console.Write("Ingrese el código del producto:");
        CodigoProducto = Console.ReadLine();

        switch (CodigoProducto)
        {
            case "DES":
                Desodorante++;
                break;

            case "JP":
                JabonEnPolvo++;
                break;

            case "DET":
                Detergente++;
                break;
        }
    }
    //Eleccion de productos con sus respectivos codigos

    //Calculo y devolucion del monto para luego informarlos en la funcion ProcesoDeVenta
    MontoTotal = 200 * Desodorante + 300 * JabonEnPolvo + 250 * Detergente;
    return MontoTotal;
}

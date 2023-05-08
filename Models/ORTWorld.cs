class ORTWorld{
    public static List<string> ListaDestinos {get;private set;} = new List<string> (){"Orlando","Paris","Londres","Tokyo","Amsterdam","Florencia","Bariloche","Ottawa","Punta Cana","Seoul"};
    public static List<string> ListaHoteles {get;private set;} = new List<string> (){"Sheraton","Novotel","Marriot","Llao Llao","Ibis","Iberostar","Holiday Inn","Hilton","Club Med","Four Seasons"};
    //descargar imagenes aerolineas
    public static List<string> ListaAereos {get; private set;} = new List<string> (){"Latam","American Airlines","Aeromexico","Air Canada","Boa","AirFrance","British Airways","Iberia","Avianca","Emirates"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string> (){"Teatro","Ski","Helicoptero","Museo","Tirolesa","Parque de Agua","Buceo","Ciclismo","Canotaje","Trekking"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        bool coincidencia=false;
        if(Paquetes.ContainsKey(destinoSeleccionado)){
            coincidencia=true;
            Paquetes.Add(destinoSeleccionado,paquete);
        }
        return coincidencia;
    }
}
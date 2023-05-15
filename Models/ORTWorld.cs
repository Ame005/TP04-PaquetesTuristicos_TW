class ORTWorld{
    public static List<string> ListaDestinos {get;private set;} = new List<string> (){"Orlando","Paris","Londres","Tokyo","Amsterdam","Florencia","Bariloche","Ottawa","Punta Cana","Seoul"};
    public static List<string> ListaHoteles {get;private set;} = new List<string> (){"sheraton.jpg","novotel.jpg","marriot.jpg","llaollao.jpg","ibis.jpg","iberostar.jpg","holidayInn.jpg","hilton.jpg","clubMedSandPiper.jpg","4Seasons.jpg"};
    public static List<string> ListaAereos {get; private set;} = new List<string> (){"latam.jpg","americanAirlines.jpg","aeromexico.jpg","airCanada.jpg","boa.jpg","airFrance.jpg","british.jpg","iberia.jpg","avianca.jpg","emirates.jpg"};
    public static List<string> ListaExcursiones {get; private set;} = new List<string> (){"teatro.jpg","ski.jpg","helicoptero.jpg","museo.jpg","tirolesa.jpg","parqueAgua.jpg","buceo.jpg","ciclismo.jpg","canotaje.jpg","trekking.jpg"};
    public static Dictionary<string, Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete){
        bool coincidencia=false;
        if(!Paquetes.ContainsKey(destinoSeleccionado)){
            coincidencia=true;
            Paquetes.Add(destinoSeleccionado,paquete);
        }
        return coincidencia;
    }
}
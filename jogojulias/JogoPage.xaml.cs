namespace jogojulias;

public partial class JogoPage : ContentPage
{
	List<LinhaHistoria> historia = new List<LinhaHistoria>();
  LinhaHistoria LinhaHistoriaAtual;

	public JogoPage()
	{
		InitializeComponent();

		 historia.Add(new LinhaHistoria()
		   {
              Id = 0,
			 Texto ="Durante um passeio de barco em suas férias, você e seu irmão Lucas passam por uma intensa tempestade, o que desestabiliza a embarcação...",
             TemEscolha=false,
			 TemFoto=true,
			 UrlDaFoto="foto1barco.jpg"
			 });
	}



    
}
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
			UrlDaFoto="foto1barco.jpg",
			TamanhoFonte=30,
			IdLevelProximo=1
		});

		historia.Add(new LinhaHistoria()
		{
			Id = 1,
			Texto = "Após o naufrágio, você e seu irmão estão perdidos na ilha. Um morador local chamado Leo os aborda, e pergunta:vocês estão dispostos a desvendar os mistérios da ilha para encontrar o caminho de volta para casa?",
			TemEscolha=true,
			TemFoto=true,
			UrlDaFoto="fotochegando.png",
			TextoDaPrimeiraOpcao="Sim, aceitamos ",
			TextoDaSegundaOpcao="Não, estamos bem",
			TamanhoFonte=25,
			IdLevelPrimeiraOpcao=2,
			IdLevelSegundaOpcao=50
		});

			historia.Add(new LinhaHistoria()
			{
			Id = 50,
			Texto="Voce morreu de fome sem a ajuda do morador local",
			TamanhoFonte=30,
		    TemEscolha=false,
			TemFoto=false,
			PersonagemPerdeu=true
		});

		Iniciar();
	}

	void Iniciar()
	{
		TrocaLinhaHistoriaAtual(0);
	}
     
	void PreencherPagina()
    {

		    labelTexto.Text = LinhaHistoriaAtual.Texto;

		    if (LinhaHistoriaAtual.PersonagemPerdeu)
      frameperdeu.IsVisible = true;
    else
      frameperdeu.IsVisible = false;


		labelTexto.FontSize=LinhaHistoriaAtual.TamanhoFonte;

        if (LinhaHistoriaAtual.TemEscolha)
		{
			botaoProximo.IsVisible = false;
			BotaoPrimeiraOpcao.IsVisible = true;
			BotaoSegundaOpcao.IsVisible = true;
			BotaoPrimeiraOpcao.Text =LinhaHistoriaAtual.TextoDaPrimeiraOpcao;
			BotaoSegundaOpcao.Text =LinhaHistoriaAtual.TextoDaSegundaOpcao;

		}
		else
		{
			botaoProximo.IsVisible = true;
			BotaoPrimeiraOpcao.IsVisible = false;
			BotaoSegundaOpcao.IsVisible = false;
		}

		if(LinhaHistoriaAtual.TemFoto)
			imagem.Source=LinhaHistoriaAtual.UrlDaFoto;

  	}
	
	void TrocaLinhaHistoriaAtual(int id)
	{
		LinhaHistoriaAtual = historia.Where(d => d.Id == id).First();
		PreencherPagina();
	}    
	void BotaoProximoClicado (object sender, EventArgs args)
  {
   TrocaLinhaHistoriaAtual(LinhaHistoriaAtual.IdLevelProximo);
  }
  private void BotaoRecomecarClicado(object sender, EventArgs args)
  {
      Application.Current.MainPage = new MainPage();
  }
  void PrimeiroBotaoClicado(object sender, EventArgs args)
  {
    TrocaLinhaHistoriaAtual(LinhaHistoriaAtual.IdLevelPrimeiraOpcao);
  }
  void SegundoBotaoClicado(object sender, EventArgs args)
  {
   TrocaLinhaHistoriaAtual(LinhaHistoriaAtual.IdLevelSegundaOpcao);
  }
}
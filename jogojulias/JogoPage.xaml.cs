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
			IdLevelProximo=1
		});

		historia.Add(new LinhaHistoria()
		{
			Id = 1,
			Texto = "Desculpe tantas perguntas! Não vemos muitas pessoas diferentes por aqui! Você aceita água?",
			TemEscolha=true,
			TextoDaPrimeiraOpcao="Sim, por favor",
			TextoDaSegundaOpcao="Não, estou bem",
			IdLevelPrimeiraOpcao=2,
			IdLevelSegundaOpcao=4998
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
}
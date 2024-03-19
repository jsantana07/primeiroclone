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
			TemFoto=true,
			UrlDaFoto="gameover.jpg",
			TamanhoFonte=30,
		    TemEscolha=false,
			PersonagemPerdeu=true
		});

			historia.Add(new LinhaHistoria()
			{
			Id = 2,
			Texto="Vocês se deparam com a descoberta de ruínas antigas na ilha e são confrontados com a decisão de optar entre dois caminhos distintos: um rio com correnteza vigorosa e uma caverna.",
			TemFoto=true,
			UrlDaFoto="fotoescolhacaminho.png",
			TamanhoFonte=30,
		    TemEscolha=true,
			PersonagemPerdeu=false,
			TextoDaPrimeiraOpcao="Seguir pelo rio",
			TextoDaSegundaOpcao="Adentrar a caverna",
			IdLevelPrimeiraOpcao=60,
			IdLevelSegundaOpcao=3
		});
			
			historia.Add(new LinhaHistoria()
			{
			Id = 60,
			Texto="Você morreu afogado devido a correnteza",
			TemFoto=true,
			UrlDaFoto="gameover.jpg",
			TamanhoFonte=30,
		    TemEscolha=false,
			PersonagemPerdeu=true
		});

			historia.Add(new LinhaHistoria()
			{
			Id = 3,
			Texto="Dentro da caverna, vocês deparam-se com escrituras antigas e um cofre enferrujado. Diante dessas descobertas, vocês têm a opção de investigar as escrituras ou abrir o cofre.",
			TemFoto=true,
			UrlDaFoto="escolhacaverna.png",
			TamanhoFonte=30,
		    TemEscolha=true,
			PersonagemPerdeu=false,
			TextoDaPrimeiraOpcao="Abrir o cofre",
			TextoDaSegundaOpcao="Investigar as escrituras",
			IdLevelPrimeiraOpcao=70,
			IdLevelSegundaOpcao=4
		});

		historia.Add(new LinhaHistoria()
			{
			Id = 70,
			Texto="Havia uma bomba pré ativada no cofre, vocês morreram devido a explosão",
			TemFoto=true,
			UrlDaFoto="gameover.jpg",
			TamanhoFonte=30,
		    TemEscolha=false,
			PersonagemPerdeu=true
		});
		historia.Add(new LinhaHistoria()
			{
			Id = 4,
			Texto="Ao investigarem as escrituras, vocês descobrem um mapa que leva a um tesouro de alto valor, além de encontrar o caminho de volta para casa.",
			TemFoto=true,
			UrlDaFoto="tesouro.jpg",
			TamanhoFonte=30,
		    TemEscolha=true,
			PersonagemPerdeu=false,
			TextoDaPrimeiraOpcao="Pegar o tesouro e voltar para casa",
			TextoDaSegundaOpcao="Pegar o tesouro mas continuar na ilha",
			IdLevelPrimeiraOpcao=5,
			IdLevelSegundaOpcao=80
		});
		historia.Add(new LinhaHistoria()
			{
			Id = 80,
			Texto="Um guardião da caverna recuperou o tesouro e tomou medidas extremas, resultando em sua perda de vida.",
			TemFoto=true,
			UrlDaFoto="gameover.jpg",
			TamanhoFonte=30,
		    TemEscolha=false,
			PersonagemPerdeu=true
		});
		historia.Add(new LinhaHistoria()
			{
			Id = 5,
			Texto="Você retornou a sua casa com o tesouro",
			TemFoto=true,
			UrlDaFoto="ultimafota.jpg",
			TamanhoFonte=30,
		    TemEscolha=false,
			PersonagemGanhou=true
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

			if (LinhaHistoriaAtual.PersonagemGanhou)
      frameganhou.IsVisible = true;
    else
      frameganhou.IsVisible = false;

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
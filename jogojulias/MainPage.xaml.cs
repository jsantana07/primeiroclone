namespace jogojulias;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}
 private void BotaoSobreFoiClicado(object sender, EventArgs args)
  {
    frameSobre.IsVisible = true;
  }
  private void BotaoVoltarFoiClicado(object sender, EventArgs args)
  {
    frameSobre.IsVisible = false;
  }
 private void BotaoIniciarFoiClicado(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new JogoPage();
  }
}
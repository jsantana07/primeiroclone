public class LinhaHistoria
{
  public int Id;
  public string? Texto; 
   public bool TemFoto = false; 
   public string? UrlDaFoto; 
   public bool TemEscolha = false;
   public string? TextoDaPrimeiraOpcao;
   public string? TextoDaSegundaOpcao;
    public int IdLevelPrimeiraOpcao;
    public int IdLevelSegundaOpcao;
    
     public int TamanhoFonte;

    public int IdLevelProximo;

   
   public bool PersonagemPerdeu = false;
   public bool PersonagemGanhou = false;

   }
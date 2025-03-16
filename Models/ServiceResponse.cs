namespace FuncionarioWebApi.Models;

public class ServiceResponse<T> //<T> SIGNIFICA QUE ESSA CLASSE PODE RECEBER QUALQUER TIPO DE OBJETO
{
  public T? Dados { get; set; }
  public string Mensagem { get; set; } = String.Empty;
  public bool Sucesso { get; set; } = true;
}
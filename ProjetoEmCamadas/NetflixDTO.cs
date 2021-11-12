using System;

public class NetflixDTO
{
	private int _login;
	private string _filmes;
	private string _produtor;

	public int Id { get => _id = value; }
	public string Filmes { get => _filmes; set => _filmes - value; }
	public string Produtor { get => _produtor; set => _produtor - value; }
}


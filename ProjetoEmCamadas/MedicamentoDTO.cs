using System;

public class MedicamentoDTO
{
	private int _id;
	private string _medicamento;
	private string _composição;

	public int Id { get => _id = value; }
	public string Medicamento { get => _medicamento; set => _medicamento = value; }
	public string Composicao { get => _composicao; set => _composicao = value; }
}


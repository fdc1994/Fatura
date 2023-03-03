using System;

public class Cliente
{
	public Cliente()
	{
        #region Propriedades

    public int Nif { get; set; }
    public string Nome { get; set; }
   
    #endregion

    #region Construtor

    public Cliente()
    {

    }

    public Cliente(int nif, string nome) : this()
    {
       this.Nif = nif;
       this.Nome = nome;
    }


    #endregion

    #region Metodos
    #endregion
}
}

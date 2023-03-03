using System;

public class Fatura
{
    #region Propriedades
    public Cliente Cliente { get; set; }
    public List<Item> ListaDeItems { get; set; }
    #endregion

    #region Construtores
    public Fatura()
    {

    }

    public Fatura(Cliente cliente, List<Item> listaDeItems) : this()
    {
        this.Cliente = cliente;
        this.ListaDeItems = listaDeItems;
    }
    #endregion

}

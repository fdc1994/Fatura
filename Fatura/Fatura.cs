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

    #region Metodos
    public float valorTotal()
    {
        float valorTotal = 0f;
        foreach(Item item in ListaDeItems)
        {
            valorTotal += item.produto.precoComDesconto();
        }
        return valorTotal;
    }
    #endregion

}

using System;

public class Item
{

    #region Propriedades

    public Produto produto { get; set; }
    public int Quantidade { get; set; }
    public float Preco { get; set; }

    #endregion

    #region Construtor
    public Item()
    {

    }

    public Item(Produto produto, int quantidade, float preco) : this()
    {
        this.produto = produto;
        this.Quantidade = quantidade;
        this.Preco = preco;
    }


    #endregion

    #region Metodos
 
    #endregion

    
}

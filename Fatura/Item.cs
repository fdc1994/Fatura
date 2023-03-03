using System;
using System.Reflection.Metadata.Ecma335;

public class Item
{

    #region Propriedades

    public Produto produto {

        get; set;
    }
    public int Quantidade { get; set; }
    public float Preco {
        get; set;
    }

    #endregion

    #region Construtor
    public Item()
    {

    }

    public Item(Produto produtoNovo, int quantidade) : this()
    {
        this.produto = produtoNovo;
        this.Quantidade = quantidade;
        this.Preco = produto.precoComDesconto()*quantidade;
    }


    #endregion

    #region Metodos
 
    #endregion

    
}

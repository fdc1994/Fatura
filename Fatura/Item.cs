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
        get => Preco;
        set
        {
            if (value > 0) { 
            Preco= value;
            } else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
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

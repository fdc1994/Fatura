using System;
using System.Reflection.Metadata.Ecma335;

public class Item
{

    #region Propriedades

    private Produto _produto;
    public Produto produto {

        get
        {
            return _produto;
        }
        set
        {
           if(value!= _produto && value != null)
            {
                _produto= value;    
            } 
            else
            {
                throw new ArgumentNullException("O produto não pode ser nulo");
            }
        }
    }
    public int quantidade { get; set; }

    private float _preco;

    public float preco
    {
        get
        {
            return _preco;
        }
        set
        {
            if(value <= 0) { 
                throw new ArgumentOutOfRangeException("O preço deve ser superior a 0");
            } else
            {
                _preco = value;
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
        this.quantidade = quantidade;
        this.preco = produto.precoComDesconto()*quantidade;
    }


    #endregion

    #region Metodos
 
    #endregion

    
}

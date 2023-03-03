using System;

public class Produto
{
    #region Propriedades

    public int Codigo { get; set; }
    public string Nome { get; set; }
    public float Preco { get; set; }
    public float Desconto { get; set; }

    #endregion

    #region Construtor
    public Produto()
    {

    }

    public Produto(int codigo, string nome, float preco, float desconto) : this() {
        this.Codigo = codigo;    
        this.Nome = nome;
        this.Preco = preco;
        this.Desconto = desconto;
    }


    #endregion

    #region Metodos

    public float precoComDesconto() {
        if (this.Preco == 0) {
            throw new Exception("preço deve ser superior a 0");
        }

        return this.Preco - (this.Preco * this.Desconto);
    }
    #endregion
}

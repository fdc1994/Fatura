// See https://aka.ms/new-console-template for more information


Console.OutputEncoding = System.Text.Encoding.UTF8;

//Arrange

Cliente cliente = new Cliente(123456789, "Fábio");
Produto produto = new Produto(1,"escova elétrica", 20.0f, 0.1f);
Produto produto2 = new Produto(1,"teclado RGB", 39.0f, 0.3f);
Produto produto3 = new Produto(1,"teclado RGB", 0f, 0f);
Item item1 = new Item(produto, 2); 
Item item2 = new Item(produto2, 1);

//Act
try
{
    Item item3 = new Item(null, 1);

} catch (Exception e) { 
    //Imprimir excepção Produto nulo
    Console.WriteLine(e.ToString());    
}

try
{
    Item item3 = new Item(produto3, 1);

}
catch (Exception e)
{
    //Imprimir excepção preço igual ou inferior a zero
    Console.WriteLine(e.ToString());
}
List<Item> listaDeItems = new List<Item> { item1, item2 };  
Fatura fatura = new Fatura(cliente, listaDeItems);

//Show

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("--------------------------------------------");
Console.WriteLine("Início Fatura:");
Console.WriteLine();
Console.WriteLine("O valor total da fatura é : " + fatura.valorTotal().ToString() + "\u20AC");
Console.WriteLine();
Console.WriteLine("--------------------------------------------");
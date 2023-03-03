// See https://aka.ms/new-console-template for more information

//Arrange

Cliente cliente = new Cliente(123456789, "Fábio");
Produto produto = new Produto(1,"escova elétrica", 20f, 0.1f);
Produto produto2 = new Produto(1,"teclado RGB", 39f, 0.3f);
Item item1 = new Item(produto, 2); 
Item item2 = new Item(produto2, 1); 
List<Item> listaDeItems = new List<Item> { item1, item2 };  
Fatura fatura = new Fatura(cliente, listaDeItems);

Console.WriteLine(fatura.valorTotal().ToString());

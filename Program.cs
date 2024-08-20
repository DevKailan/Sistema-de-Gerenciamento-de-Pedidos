double totalPedido = 0;
bool pedidoAberto = true;

while (pedidoAberto)
{
    Console.WriteLine("Sistema de Gerenciamento de Pedidos");
    Console.WriteLine("1- Adicionar item ao pedido");
    Console.WriteLine("2- Exibir total do pedido");
    Console.WriteLine("3- Finalizar pedido e sair");
    Console.WriteLine("Escolha uma opção:");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Escolha um item:");
            Console.WriteLine("1- Pizza (R$30,00)");
            Console.WriteLine("2- Hamburguer (R$15,00)");
            Console.WriteLine("3- Refrigerante (R$5,00)");
            Console.WriteLine("Digite o número do item:");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                totalPedido += 30.00;
            }
            else if (escolha == "2")
            {
                totalPedido += 15.00;
            }
            else if (escolha == "3")
            {
                totalPedido += 5.00;
            }
            else
            {
                Console.WriteLine("Escolha inválida");
            }
            break;

        case "2":
            Console.WriteLine("Total do pedido: R$ " + totalPedido);
            break;

        case "3":
            Console.WriteLine("Encerrando pedido do sistema, obrigado pela preferência.");
            pedidoAberto = false;
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

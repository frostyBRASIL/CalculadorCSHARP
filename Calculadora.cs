class Calculadora
{
    
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Definindo a acentuação
        
        //Variáveis operadores
        double[] soma = new double[2];
        double[] subtracao = new double[2];
        double[] multiplicacao = new double[2];
        double[] divisao = new double[2];
        
        char escolha = ' '; //char da escolha do usuário
        char escolhaMenu = ' ';
        string[] operadores = { "Somar", "Subtrair", "Multiplicar", "Dividir" }; 
            
        inicioDoMenu: //Inicialização de uma GoTo
        
        Console.WriteLine("\nCalculadora básica em C#");
        Console.WriteLine($"\nEscolha uma das opções para calcular: (1) {operadores[0]} || (2) {operadores[1]} || (3) {operadores[2]} || (4) {operadores[3]} ");
        escolha = char.Parse(Console.ReadKey().KeyChar.ToString());
        Console.WriteLine("");

        switch (escolha)
        {
            case '1':
                Console.WriteLine($"Você escolheu a opção {operadores[0]}!");
                
                Console.WriteLine();
                Console.WriteLine("Digite o primeiro valor: ");
                soma[0] = double.Parse(Console.ReadLine());
        
                Console.WriteLine("Digite o segundo valor: ");
                soma[1] = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"{soma[0]} + {soma[1]} = {soma[0] + soma[1]}");
            break;
            
            case '2':
                Console.WriteLine($"Você escolheu a opção: {operadores[1]}!");
                
                Console.WriteLine();
                Console.WriteLine("Digite o primeiro valor: ");
                subtracao[0] = double.Parse(Console.ReadLine());
        
                Console.WriteLine("Digite o segundo valor: ");
                subtracao[1] = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"{subtracao[0]} - {subtracao[1]} = {subtracao[0] - subtracao[1]}");
            break;
            
            case '3':
                Console.WriteLine($"Você escolheu a opção: {operadores[2]}!");
                
                Console.WriteLine();
                Console.WriteLine("Digite o primeiro valor: ");
                multiplicacao[0] = double.Parse(Console.ReadLine());
        
                Console.WriteLine("Digite o segundo valor: ");
                multiplicacao[1] = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"{multiplicacao[0]} * {multiplicacao[1]} = {multiplicacao[0] * multiplicacao[1]}");
            break;
            
            case '4':
                Console.WriteLine($"Você escolheu a opção: {operadores[3]}!");
                
                Console.WriteLine();
                Console.WriteLine("Digite o primeiro valor: ");
                divisao[0] = double.Parse(Console.ReadLine());
        
                Console.WriteLine("Digite o segundo valor: ");
                divisao[1] = double.Parse(Console.ReadLine());
                
                Console.WriteLine($"{divisao[0]} / {divisao[1]} = {divisao[0] / divisao[1]}");
            break;
            
            default:
                Console.WriteLine($"{escolha} é uma opção inválida!");
            break;
        }
        
        Console.WriteLine();
        Console.WriteLine("Deseja voltar para o menu? (S/N)");
        escolhaMenu = char.Parse(Console.ReadKey().KeyChar.ToString());
        
        switch (escolhaMenu)
        {
            case 's':
            case 'S':
                goto inicioDoMenu;
            break;
            
            case 'n':
            case 'N':
                Console.WriteLine("\nFim do programa, obrigado por utilizar!");
            break;
            
            default:
                Console.WriteLine("Opção inválida!");
            break;
        }


    }
}
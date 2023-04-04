//Menu bebidas 

//Logica - Algoritmo

//1. Entrada das bebidas
//2. Informar bebida solicitada
//3. Adicionar opção de gelo ou sem gelo

//ENTRADA:
Console.WriteLine(@$"
 ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦
 ☆                    Menu Bebidas                        ☆  
 ★ Informe a bebida desejada:                             ★      
 ☆ 1- Coca-Cola                                           ☆ 
 ★ 2- Fanta Laranja                                       ★
 ☆ 3- H20                                                 ☆ 
 ★ 4- Tonica                                              ★
 ☆ 5- Guarana                                             ☆
 ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦ ◦  
");

//RECEBER BEBIDA
int bebida = int.Parse(Console.ReadLine());

//ACRESCENTAR GELO OU NÃO
Console.WriteLine($"Gostaria de acrescentar gelo? (Sim) ou (Não)");
string gelo = Console.ReadLine().ToLower();

string comGelo = "sim";

// PROCESSAMENTO
switch (bebida)
{
    case 1:
        Console.WriteLine($"Você pediu uma Coca-Cola, aguarde no balcão!");
        
        if (gelo == comGelo)
        {
            Console.WriteLine($"OBS: Sua bebida irá vir com gelo.");
        }
        else
        {
            Console.WriteLine($"OBS: Sua bebida não irá vir com gelo.");
        }
    break;
    
    case 2:
        Console.WriteLine($"Você pediu uma Fanta laranja, aguarde no balcão!");
        
        if (gelo == comGelo)
        {
            Console.WriteLine($"OBS: Sua bebida irá vir com gelo.");
        }
        else
        {
            Console.WriteLine($"OBS: Sua bebida não irá vir com gelo.");
        }
    break;
    
    case 3:
        Console.WriteLine($"Você pediu uma H20, aguarde no balcão!");
       
        if (gelo == comGelo)
        {
            Console.WriteLine($"OBS: Sua bebida irá vir com gelo.");
        }
        else
        {
            Console.WriteLine($"OBS: Sua bebida não irá vir com gelo.");
        }
    break;
    
    case 4:
        Console.WriteLine($"Você pediu uma Tonica, aguarde no balcão!");
       
        if (gelo == comGelo)
        {
            Console.WriteLine($"OBS: Sua bebida irá vir com gelo.");
        }
        else
        {
            Console.WriteLine($"OBS: Sua bebida não irá vir com gelo.");
        }
    break;
    
    case 5:
        Console.WriteLine($"Você pediu uma Guarana, aguarde no balcão!");
       
        if (gelo == comGelo)
        {
            Console.WriteLine($"OBS: Sua bebida irá vir com gelo.");
        }
        else
        {
            Console.WriteLine($"OBS: Sua bebida não irá vir com gelo.");
        }
    break;
    
    default:
        Console.WriteLine($"Informe uma bebida válida em nosso cardápio!");
    break;
}

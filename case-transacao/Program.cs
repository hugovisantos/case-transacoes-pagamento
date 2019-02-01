using System;
using System.Collections.Generic;

namespace case_transacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            double valorDaCompra = 0;
            int quantidadeDeParcelas = 0;
            int IdTransacao = 0;
            

            
            List<Transacao> transacoesEfetuadas = new List<Transacao>();

            while(escolha != -1)
            {
            Console.WriteLine("Escolha uma opcao: \n 1 - Crédito \n 2 - Débito \n 3 - Voucher \n 4- Crediário \n 5- Estorno \n sair : -1" );
            escolha = Convert.ToInt32(Console.ReadLine());         

                switch(escolha)
                {
                    case -1:{
                        break;
                    }
                    //credito
                    case 1 : {
                        Console.WriteLine("Insira o Valor da Compra");
                        valorDaCompra = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Insira a quantidade de parcelas");
                        quantidadeDeParcelas = Convert.ToInt32(Console.ReadLine());
                        try{
                            Credito credito = new Credito(valorDaCompra, quantidadeDeParcelas, transacoesEfetuadas);
                            Console.WriteLine("Estado da transacao: {0}", (credito.Estado)? "Aprovada" : "Recusada" );
                            System.Console.WriteLine("O id da transação é {0}", credito.IdTransacao);
                        }catch(ArgumentException ex){
                            Console.WriteLine("Argumento inválido!"); 
                        }
                                                                                                        
                        break;
                    }

                    //debito
                    case 2 : {
                    Console.WriteLine("Insira o Valor da Compra");
                        valorDaCompra = Convert.ToDouble(Console.ReadLine());
                        try{
                            Debito debito = new Debito(valorDaCompra, transacoesEfetuadas);
                            Console.WriteLine("Estado da transacao: {0}", (debito.Estado)? "Aprovada" : "Recusada" );
                            System.Console.WriteLine("O id da transação é {0}", debito.IdTransacao);
                        }catch(ArgumentException ex){
                            Console.WriteLine("Argumento inválido!"); 
                        }

                        break;
                    }
                    //voucher
                    case 3 : {
                        Console.WriteLine("Insira o Valor da Compra");
                        valorDaCompra = Convert.ToDouble(Console.ReadLine());
                        try{
                            Voucher voucher = new Voucher(valorDaCompra, transacoesEfetuadas);                            
                            Console.WriteLine("Estado da transacao: {0}", (voucher.Estado)? "Aprovada" : "Recusada" );
                            System.Console.WriteLine("O id da transação é {0}", voucher.IdTransacao);
                        }catch(ArgumentException ex){
                            Console.WriteLine("Argumeto inválido!");                        
                        }
                                                                                                    
                        break;
                    }
                    //crediario
                    case 4:{
                        Console.WriteLine("Insira o valor da Compra");
                        valorDaCompra = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Insira a quantidade de parcelas");
                        quantidadeDeParcelas = Convert.ToInt32(Console.ReadLine());
                        try{
                            Crediario crediario = new Crediario(valorDaCompra, quantidadeDeParcelas, transacoesEfetuadas);
                            Console.WriteLine("Estado da transacao: {0}", (crediario.Estado)? "Aprovada" : "Recusada" );
                            System.Console.WriteLine("O id da transação é {0}", crediario.IdTransacao);
                        }catch(ArgumentException ex){
                            Console.WriteLine("Argumento inválido!");
                        }
                        break; 
                        
                    }
                    //estorno
                    case 5:{
                        Console.WriteLine("Insira id gerado pela compra");
                        IdTransacao = Convert.ToInt32(Console.ReadLine());

                        try{
                            TransacaoDeEstorno estorno = new TransacaoDeEstorno(IdTransacao, transacoesEfetuadas);
                            System.Console.WriteLine("Estorno realizado!");
                        }
                        catch(Exception ex)
                        {
                            System.Console.WriteLine(ex.Message);
                        }

                        break;
                    }
                    default : {
                    System.Console.WriteLine("Opção inválida!");
                    break;
                    }
                }

            }
        }
    }
}

using System;

namespace TrabalhoATP {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("BEM VINDO AO BANCO CV");
            Console.WriteLine("DIGITE SUA SENHA");
            Console.WriteLine("__  __  __  __");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("DIGITE SUA SENHA");
            Console.WriteLine(" *  __  __  __");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("DIGITE SUA SENHA");
            Console.WriteLine(" *   *  __  __");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("DIGITE SUA SENHA");
            Console.WriteLine(" *   *   *  __");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("DIGITE SUA SENHA");
            Console.WriteLine(" *   *   *   *");
            Console.Clear();

            Console.WriteLine("BEM VINDO, USUÁRIO!");

            Console.WriteLine("INFORME O SALDO:");
            Console.Write("DA CONTA CORRENTE: R$ ");
            double saldoContaCorrente = double.Parse(Console.ReadLine());
            Console.Write("DA CONTA COM CHEQUE ESPECIAL: R$ ");
            double saldoContaChequeEspecial = double.Parse(Console.ReadLine());
            Console.Write("DA CONTA POUPANÇA: R$ ");
            double saldoContaPoupanca = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("AGORA, INFORME:");
            Console.Write("QUAL LIMITE DO CHEQUE ESPECIAL:R$ ");
            double limiteChequeEspecial = double.Parse(Console.ReadLine());
            Console.Write("QUAL O PERCENTIL DA TAXA DE JUROS DO CHEQUE ESPECIAL: ");
            double taxaJurosChequeEspecial = double.Parse(Console.ReadLine());
            Console.Write("QUAL O PERCENTIL DE RENDIMENTO DA CONTA POUPANÇA: ");
            double taxaJurosRendimento = double.Parse(Console.ReadLine());

            Console.Clear();

            int instrucao, tipoConta, tempoPoupanca = 0, tempoCheque = 0;
            bool usoCheque = false, acaoRealizada = false;
            double saldoDevedorChequeEspecial = 0;
            do
            {
                Console.WriteLine("------BANCO VC------");
                Console.WriteLine();
                Console.WriteLine($"SALDO CONTA CORRENTE: R$ {saldoContaCorrente}\nSALDO CONTA CORRENTE C/CHEQUE ESPECIAL: R$ {saldoContaChequeEspecial}\nSALDO CONTA POUPANÇA: R$ {saldoContaPoupanca}");
                if (saldoDevedorChequeEspecial > 0)
                {
                    Console.WriteLine($"SALDO DEVEDOR CHEQUE ESPECIAL: R$ {saldoDevedorChequeEspecial}");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------");
                Console.WriteLine($"{tempoPoupanca}, {tempoCheque}");
                Console.WriteLine();
                Console.WriteLine("INFORME O QUE SERÁ REALIZADO NA CONTA");
                Console.WriteLine("1 - CONSULTAR SALDO \n2 - REALIZAR SAQUE \n3 - REALIZAR DEPÓSITO \n4 - PAGAR CONTA \n5 - REALIZAR TRANSFÊRENCIA \n6 - ENCERRAR");
                instrucao = int.Parse(Console.ReadLine());


                Console.Clear();

                if (instrucao == 1)
                {
                    do
                    {
                        Console.WriteLine("EM QUAL CONTA VOCÊ VAI REALIZAR O SAQUE?");
                        Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
                        tipoConta = int.Parse(Console.ReadLine());
                    } while (tipoConta > 3);

                    switch (tipoConta)
                    {
                        case 1:
                            Console.WriteLine($"SALDO DA CONTA CORRENTE É: {saldoContaCorrente}");
                            break;
                        case 2:
                            Console.WriteLine($"SALDO DA CONTA CORRENTE COM CHEQUE ESPECIAL É: {saldoContaChequeEspecial}");
                            break;
                        case 3:
                            Console.WriteLine($"SALDO DA CONTA POUPANÇA É: {saldoContaPoupanca}");
                            break;

                    }
                    Console.ReadKey();
                    Console.Clear();
                    acaoRealizada = true;

                }
                else if (instrucao == 2)
                {
                    do
                    {
                        Console.WriteLine("EM QUAL CONTA VOCÊ VAI REALIZAR O SAQUE?");
                        Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
                        tipoConta = int.Parse(Console.ReadLine());
                    } while (tipoConta > 3);


                    Console.WriteLine("QUAL VALOR DO SAQUE?");
                    double valorSaque = double.Parse(Console.ReadLine());

                    switch (tipoConta)
                    {
                        case 1:
                            if (valorSaque < 0)
                            {
                                Console.WriteLine("VALOR INVÁLIDO");
                            }
                            else if (saldoContaCorrente < valorSaque)
                            {
                                Console.WriteLine("SALDO INSUFICIENTE");
                            }
                            else
                            {
                                saldoContaCorrente -= valorSaque;
                                Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaCorrente}");
                                acaoRealizada = true;
                            }
                            break;
                        case 2:
                            if (valorSaque < 0)
                            {
                                Console.WriteLine("VALOR INVÁLIDO");
                            }
                            else if (saldoContaChequeEspecial + limiteChequeEspecial <= valorSaque)
                            {
                                Console.WriteLine("SALDO INSUFICIENTE");
                            }
                            else if (valorSaque <= saldoContaChequeEspecial)
                            {
                                saldoContaChequeEspecial -= valorSaque;
                                Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaChequeEspecial}");
                                acaoRealizada = true;
                            }
                            else if (saldoContaChequeEspecial + limiteChequeEspecial > valorSaque)
                            {
                                int respostaUsuarioUtilizarCheque = 0;
                                do
                                {
                                    Console.WriteLine($"SEU SALDO DE {saldoContaChequeEspecial} É INSUFICIENTE, DESEJA UTILIZAR {valorSaque - saldoContaChequeEspecial} CHEQUE ESPECIAL??");
                                    Console.WriteLine("1 - SIM \n2 - NÃO");
                                    respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                                } while (respostaUsuarioUtilizarCheque > 2);

                                if (respostaUsuarioUtilizarCheque == 1)
                                {
                                    limiteChequeEspecial = limiteChequeEspecial - (valorSaque - saldoContaChequeEspecial);
                                    saldoDevedorChequeEspecial += valorSaque - saldoContaChequeEspecial;
                                    saldoContaChequeEspecial = 0;
                                    Console.WriteLine($"SEU SALDO É DE: {saldoContaChequeEspecial}");
                                    Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {limiteChequeEspecial}");
                                    usoCheque = true;
                                    acaoRealizada = true;

                                }
                                else
                                {
                                    Console.WriteLine("SAQUE NÃO REALIZADO");
                                }

                            }
                            break;

                        case 3:
                            if (valorSaque < 0)
                            {
                                Console.WriteLine("VALOR INVÁLIDO");
                            }
                            else if (saldoContaPoupanca < valorSaque)
                            {
                                Console.WriteLine("SALDO INSUFICIENTE");
                            }
                            else
                            {
                                saldoContaPoupanca -= valorSaque;
                                Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaPoupanca}");
                                acaoRealizada = true;
                            }

                            break;

                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (instrucao == 3)
                {
                    do
                    {
                        Console.WriteLine("EM QUAL CONTA VOCÊ VAI REALIZAR O DEPOSITO?");
                        Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
                        tipoConta = int.Parse(Console.ReadLine());
                    } while (tipoConta > 3);

                    double valorDeposito = double.Parse(Console.ReadLine());

                    switch (tipoConta)
                    {
                        case 1:
                            if (valorDeposito < 0)
                            {
                                Console.WriteLine("VALOR INVÁLIDO");
                            }
                            else
                            {
                                saldoContaCorrente += valorDeposito;
                                Console.WriteLine($"SALDO DA CONTA CORRENTE ATUAL: {saldoContaCorrente}");
                            }
                            break;
                        case 2:
                            if (valorDeposito < 0)
                            {
                                Console.WriteLine("VALOR INVÁLIDO");
                            }
                            else
                            {
                                saldoContaChequeEspecial += valorDeposito;
                                Console.WriteLine($"SALDO DA CONTA CORRENTE ATUAL: {saldoContaChequeEspecial}");
                            }
                            break;
                        case 3:
                            if (valorDeposito < 0)
                            {
                                Console.WriteLine("VALOR INVÁLIDO");
                            }
                            else
                            {
                                saldoContaPoupanca += valorDeposito;
                                Console.WriteLine($"SALDO DA CONTA CORRENTE ATUAL: {saldoContaPoupanca}");
                            }
                            break;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (instrucao == 4)
                {
                    if (saldoDevedorChequeEspecial > 0)
                    {
                        int respostaUsuario;
                        do
                        {
                            Console.WriteLine("EXISTE UM DÉBITO DO CHEQUE ESPECIAL A SER PAGO, DESEJA PAGA-LO? ");
                            Console.WriteLine("1 - SIM \n2 - NÃO");
                            respostaUsuario = int.Parse(Console.ReadLine());
                        } while (respostaUsuario > 2);

                        if (respostaUsuario == 1)
                        {
                            do
                            {
                                Console.WriteLine("EM QUAL CONTA VOCÊ VAI USAR PARA EFETUAR O PAGAMENTO?");
                                Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
                                tipoConta = int.Parse(Console.ReadLine());
                            } while (tipoConta > 3);

                            switch (tipoConta)
                            {
                                case 1:
                                    if (saldoContaCorrente < saldoDevedorChequeEspecial)
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                    }
                                    else
                                    {
                                        saldoContaCorrente -= saldoDevedorChequeEspecial;
                                        saldoDevedorChequeEspecial = 0;
                                        Console.WriteLine($"SEU SALDO ATUAL NA CONTA CORRENTE É DE: {saldoContaCorrente}");
                                        acaoRealizada = true;
                                    }
                                    break;
                                case 2:
                                    if (saldoContaChequeEspecial < saldoDevedorChequeEspecial)
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                    }
                                    else
                                    {
                                        saldoContaChequeEspecial -= saldoDevedorChequeEspecial;
                                        saldoDevedorChequeEspecial = 0;
                                        Console.WriteLine($"SEU SALDO ATUAL NA CONTA COM CHEQUE ESPECIAL É DE: R$ {saldoContaChequeEspecial}");
                                        acaoRealizada = true;
                                    }
                                    break;
                                case 3:
                                    if (saldoContaPoupanca < saldoDevedorChequeEspecial)
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                    }
                                    else
                                    {
                                        saldoContaPoupanca -= saldoDevedorChequeEspecial;
                                        saldoDevedorChequeEspecial = 0;
                                        Console.WriteLine($"SEU SALDO ATUAL NA CONTA POUPANÇA É DE: R${saldoContaPoupanca}");
                                        acaoRealizada = true;
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("OK, ENTÃO QUAL CONTA SERÁ PAGA? EX: LUZ, AGUA, INTERNET");
                                string nomeContaASerPaga = Console.ReadLine();
                                Console.WriteLine("EM QUAL CONTA VOCÊ VAI USAR PARA EFETUAR O PAGAMENTO?");
                                Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
                                tipoConta = int.Parse(Console.ReadLine());
                            } while (tipoConta > 3);


                            Console.WriteLine("QUAL VALOR DA CONTA QUE SERÁ PAGA?");
                            double valorPagarConta = double.Parse(Console.ReadLine());

                            switch (tipoConta)
                            {
                                case 1:
                                    if (valorPagarConta < 0)
                                    {
                                        Console.WriteLine("VALOR INVÁLIDO");
                                    }
                                    else if (saldoContaCorrente < valorPagarConta)
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                    }
                                    else
                                    {
                                        saldoContaCorrente -= valorPagarConta;
                                        Console.WriteLine($"SEU SALDO ATUAL NA CONTA CORRENTE É DE: R${saldoContaCorrente}");
                                    }
                                    break;
                                case 2:
                                    if (valorPagarConta < 0)
                                    {
                                        Console.WriteLine("VALOR INVÁLIDO");
                                    }
                                    else if (saldoContaChequeEspecial + limiteChequeEspecial <= valorPagarConta)
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                    }
                                    else if (valorPagarConta <= saldoContaChequeEspecial)
                                    {
                                        saldoContaChequeEspecial -= valorPagarConta;
                                        Console.WriteLine($"SEU SALDO ATUAL NA CONTA CORRENTE COM CHEQUE ESPECIAL É DE: R$ {saldoContaChequeEspecial}");
                                    }
                                    else if (saldoContaChequeEspecial + limiteChequeEspecial > valorPagarConta)
                                    {
                                        int respostaUsuarioUtilizarCheque = 0;
                                        do
                                        {
                                            Console.WriteLine($"SEU SALDO DE {saldoContaChequeEspecial} É INSUFICIENTE, DESEJA UTILIZAR {valorPagarConta - saldoContaChequeEspecial} CHEQUE ESPECIAL??");
                                            Console.WriteLine("1 - SIM \n2 - NÃO");
                                            respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                                        } while (respostaUsuarioUtilizarCheque > 2);

                                        if (respostaUsuarioUtilizarCheque == 1)
                                        {
                                            limiteChequeEspecial = limiteChequeEspecial - (valorPagarConta - saldoContaChequeEspecial);
                                            saldoDevedorChequeEspecial += valorPagarConta - saldoContaChequeEspecial;
                                            saldoContaChequeEspecial = 0;
                                            Console.WriteLine($"SEU SALDO ATUAL NA CONTA CORRENTE COM CHEQUE ESPECIAL É DE: R$ {saldoContaChequeEspecial}");
                                            Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: R$ {limiteChequeEspecial}");
                                        }
                                        else
                                        {
                                            Console.WriteLine("SAQUE NÃO REALIZADO");
                                        }
                                    }
                                    break;

                                case 3:
                                    if (valorPagarConta < 0)
                                    {
                                        Console.WriteLine("VALOR INVÁLIDO");
                                    }
                                    else if (saldoContaPoupanca < valorPagarConta)
                                    {
                                        Console.WriteLine("SALDO INSUFICIENTE");
                                    }
                                    else
                                    {
                                        saldoContaPoupanca -= valorPagarConta;
                                        Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaPoupanca}");
                                    }

                                    break;
                            }
                        }

                    }
                    else
                    {

                        do
                        {
                            Console.WriteLine("EM QUAL CONTA VOCÊ VAI USAR PARA EFETUAR O PAGAMENTO?");
                            Console.WriteLine("1 - CONTA CORRENTE \n2 - CONTA CORRENTE COM CHEQUE ESPECIAL \n3 - CONTA POUPANÇA. ");
                            tipoConta = int.Parse(Console.ReadLine());
                        } while (tipoConta > 3);


                        Console.WriteLine("QUAL VALOR DA CONTA QUE SERÁ PAGA?");
                        double valorPagarConta = double.Parse(Console.ReadLine());

                        switch (tipoConta)
                        {
                            case 1:
                                if (valorPagarConta < 0)
                                {
                                    Console.WriteLine("VALOR INVÁLIDO");
                                }
                                else if (saldoContaCorrente < valorPagarConta)
                                {
                                    Console.WriteLine("SALDO INSUFICIENTE");
                                }
                                else
                                {
                                    saldoContaCorrente -= valorPagarConta;
                                    Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaCorrente}");
                                }
                                break;
                            case 2:
                                if (valorPagarConta < 0)
                                {
                                    Console.WriteLine("VALOR INVÁLIDO");
                                }
                                else if (saldoContaChequeEspecial + limiteChequeEspecial <= valorPagarConta)
                                {
                                    Console.WriteLine("SALDO INSUFICIENTE");
                                }
                                else if (valorPagarConta <= saldoContaChequeEspecial)
                                {
                                    saldoContaChequeEspecial -= valorPagarConta;
                                    Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaChequeEspecial}");
                                }
                                else if (saldoContaChequeEspecial + limiteChequeEspecial > valorPagarConta)
                                {
                                    int respostaUsuarioUtilizarCheque = 0;
                                    do
                                    {
                                        Console.WriteLine($"SEU SALDO DE {saldoContaChequeEspecial} É INSUFICIENTE, DESEJA UTILIZAR {valorPagarConta - saldoContaChequeEspecial} CHEQUE ESPECIAL??");
                                        Console.WriteLine("1 - SIM \n2 - NÃO");
                                        respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                                    } while (respostaUsuarioUtilizarCheque > 2);

                                    if (respostaUsuarioUtilizarCheque == 1)
                                    {
                                        limiteChequeEspecial = limiteChequeEspecial - (valorPagarConta - saldoContaChequeEspecial);
                                        saldoDevedorChequeEspecial += valorPagarConta - saldoContaChequeEspecial;
                                        saldoContaChequeEspecial = 0;
                                        Console.WriteLine($"SEU SALDO É DE: {saldoContaChequeEspecial}");
                                        Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {limiteChequeEspecial}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("SAQUE NÃO REALIZADO");
                                    }
                                }
                                break;

                            case 3:
                                if (valorPagarConta < 0)
                                {
                                    Console.WriteLine("VALOR INVÁLIDO");
                                }
                                else if (saldoContaPoupanca < valorPagarConta)
                                {
                                    Console.WriteLine("SALDO INSUFICIENTE");
                                }
                                else
                                {
                                    saldoContaPoupanca -= valorPagarConta;
                                    Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaPoupanca}");
                                }

                                break;
                        }
                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (instrucao == 5)
                {
                    Console.WriteLine("ESCOLHA DE QUAL CONTA VAI SAIR O VALOR");
                    Console.WriteLine("1- CONTA CORRENTE 2- CONTA CORRENTE C/ CHEQUE ESPECIAL 3- CONTA POUPANÇA");
                    int contaSaida = int.Parse(Console.ReadLine());
                    Console.WriteLine("ESCOLHA DE QUAL CONTA VAI ENTRAR O VALOR");
                    Console.WriteLine("1- CONTA CORRENTE 2- CONTA CORRENTE C/ CHEQUE ESPECIAL 3- CONTA POUPANÇA");
                    int contaEntrada = int.Parse(Console.ReadLine());

                    Console.WriteLine("QUAL O VALOR");
                    double valorTransferencia = int.Parse(Console.ReadLine());

                    bool verificador = true;
                    if (contaSaida == 1)
                    {

                        if (valorTransferencia < 0)
                        {
                            Console.WriteLine("VALOR INVÁLIDO");
                            verificador = false;
                        }
                        else if (saldoContaCorrente < valorTransferencia)
                        {
                            Console.WriteLine("SALDO INSUFICIENTE");
                            verificador = false;
                        }
                        else
                        {
                            saldoContaCorrente -= valorTransferencia;
                            Console.WriteLine($"SEU SALDO ATUAL DA CONTA CORRENTE É: {saldoContaCorrente}");
                            acaoRealizada = true;

                        }
                    }
                    else if (contaSaida == 2)
                    {
                        if (valorTransferencia < 0)
                        {
                            Console.WriteLine("VALOR INVÁLIDO");
                            verificador = false;
                        }
                        else if (saldoContaChequeEspecial + limiteChequeEspecial <= valorTransferencia)
                        {
                            Console.WriteLine("SALDO INSUFICIENTE");
                            verificador = false;
                        }
                        else if (valorTransferencia <= saldoContaChequeEspecial)
                        {
                            saldoContaChequeEspecial -= valorTransferencia;
                            Console.WriteLine($"SEU SALDO ATUAL É: {saldoContaChequeEspecial}");
                        }
                        else if (saldoContaChequeEspecial + limiteChequeEspecial > valorTransferencia)
                        {
                            int respostaUsuarioUtilizarCheque = 0;
                            do
                            {
                                Console.WriteLine($"SEU SALDO DE {saldoContaChequeEspecial} É INSUFICIENTE, DESEJA UTILIZAR {valorTransferencia - saldoContaChequeEspecial} CHEQUE ESPECIAL??");
                                Console.WriteLine("1 - SIM \n2 - NÃO");
                                respostaUsuarioUtilizarCheque = int.Parse(Console.ReadLine());
                            } while (respostaUsuarioUtilizarCheque > 2);

                            if (respostaUsuarioUtilizarCheque == 1)
                            {
                                limiteChequeEspecial = limiteChequeEspecial - (valorTransferencia - saldoContaChequeEspecial);
                                saldoDevedorChequeEspecial += valorTransferencia - saldoContaChequeEspecial;
                                saldoContaChequeEspecial = 0;
                                Console.WriteLine($"SEU SALDO É DE: {saldoContaChequeEspecial}");
                                Console.WriteLine($"SEU LIMITE PARA CHEQUE ESPECIAL ATUAL: {limiteChequeEspecial}");
                                acaoRealizada = true;
                            }
                            else
                            {
                                Console.WriteLine("SAQUE NÃO REALIZADO");
                                verificador = false;
                            }
                        }
                    }
                    else if (contaSaida == 3)
                    {
                        if (valorTransferencia < 0)
                        {
                            Console.WriteLine("VALOR INVÁLIDO.");
                            verificador = false;
                        }
                        else if (saldoContaPoupanca < valorTransferencia)
                        {
                            Console.WriteLine("SALDO INSUFICIENTE");
                            verificador = false;
                        }
                        else
                        {
                            saldoContaPoupanca -= valorTransferencia;
                            Console.WriteLine($"SEU SALDO ATUAL DA CONTA POUPANÇA É: {saldoContaPoupanca}");
                            acaoRealizada = true;
                        }
                    }


                    if (verificador == true)
                    {

                        if (contaEntrada == 1)
                        {
                            if (contaSaida != 1)
                            {
                                saldoContaCorrente += valorTransferencia;
                                Console.WriteLine($"SALDO DA CONTA CORRENTE:{saldoContaCorrente}");
                                acaoRealizada = true;
                            }
                            else
                            {
                                Console.Clear();
                                saldoContaCorrente += valorTransferencia;
                                Console.WriteLine("TRANSFERENCIA NÃO REALIZADA - MESMA CONTA");
                            }
                        }
                        else if (contaEntrada == 2)
                        {
                            if (contaSaida != 2)
                            {
                                saldoContaChequeEspecial += valorTransferencia;
                                Console.WriteLine($"SALDO DA CONTA CHEQUE ESPECIAL:{saldoContaChequeEspecial}");
                                acaoRealizada = true;
                            }
                            else
                            {
                                Console.Clear();
                                saldoContaCorrente += valorTransferencia;
                                Console.WriteLine("TRANSFERENCIA NÃO REALIZADA - MESMA CONTA");
                            }
                        }
                        else if (contaEntrada == 3)
                        {
                            if (contaSaida != 3)
                            {
                                saldoContaPoupanca += valorTransferencia;
                                Console.WriteLine($"SALDO DA CONTA POUPANÇA:{saldoContaPoupanca}");
                                acaoRealizada = true;
                            }
                            else
                            {
                                Console.Clear();
                                saldoContaCorrente += valorTransferencia;
                                Console.WriteLine("TRANSFERENCIA NÃO REALIZADA - MESMA CONTA");

                            }
                        }

                    }

                    Console.ReadKey();
                    Console.Clear();
                }

                if (acaoRealizada == true)
                {
                    if (usoCheque == true)
                    {
                        tempoCheque++;
                        tempoPoupanca++;
                    }
                    else
                    {
                        tempoPoupanca++;
                    }
                }

                if (tempoPoupanca % 5 == 0 && tempoPoupanca > 0)
                {
                    saldoContaPoupanca = saldoContaPoupanca + ((taxaJurosRendimento / 100) * saldoContaPoupanca);
                }
                if (tempoCheque % 5 == 0 && tempoCheque > 0)
                {
                    saldoDevedorChequeEspecial = saldoDevedorChequeEspecial + ((taxaJurosChequeEspecial / 100) * saldoDevedorChequeEspecial);
                }

            } while (instrucao != 6);
        }
    }
}


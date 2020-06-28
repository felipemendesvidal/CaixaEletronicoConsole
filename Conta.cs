//atividade para praticar POO em C# e logica de programação
//Feito por: Felipe Vidal
//Objetivos:
 /*  abrir conta
        corrente 
            ganha 50 reais
         poupança
            ganha 50 reais
    contas iniciam fechadas
    numero da conta
        so aparece se conta for aberta
    saldo
        inicia zerado
    status da conta
         inicia fechada
    depositar dinheiro
        so pode ser usado se tiver conta aberta
    sacar dinheiro
        so pode se tiver saldo
    pagar conta    
        so pode se tiver saldo suficiente
    fechar conta
        so pode se nao tiver saldo*/
namespace conta_no_console
{
    public class Conta
    {
       
        private string Dono{get; set;}
        private float Saldo{get; set;}
        public bool Status{get; set;}
        protected int NumeroConta = 123456;
        protected string TipoConta{get; set;}

         //contrutor inicializando variaveis com valores pre-definidos
        public Conta(){
            Status = false;
            Saldo = 0;
        }

        /// <summary>
        /// Muda o status de falso para verdadeiro, acrescenta valores no saldo
        /// </summary>
        /// <param name="tipo"> pega uma string e anliza se é corrente ou poupança</param>
        /// <returns>Retorna mensagem positiva e valores novos da variavel</returns>
        public string abrirConta(string tipo){
            switch(tipo){
                case "corrente":
                    Status = true;
                    TipoConta = "corrente";
                    Saldo = 50;
                break;
                case "pupança":
                    Status = true;
                    TipoConta = "pupança";
                    Saldo = 150;
                break;
                default:
                    return "tipo de conta não existente no sistema";
                break;
            }
            //fim swt
            return $"Conta aberta com sucesso.\nTipo da conta: {TipoConta}\nNovo saldo: {Saldo}.";
        }
        //fim do primeiro metodo
    
     /// <summary>
     /// Mostra o valor das variaveis status, tipoconta, saldo, numero conta
     /// </summary>
     /// <returns>string</returns>
    public string VerStatus(){
        return $"O status da sua conta é: {Status}\nSua conta é do tipo:{TipoConta}\nSeu saldo é:{Saldo}\no numero da sua conta é:{NumeroConta}";
    }
    //sim do metodo
   
    /// <summary>
    /// verifica se status é verdadeiro
    /// </summary>
    /// <param name="deposito">parametro para receber valor</param>
    /// <returns>string</returns>
    public string DepositarDinheiro(string deposito){
        if(Status == true){
            deposito = "deposito feito com sucesso";
        }else{
            deposito = "é necessario abrir uma conta";
        }
        return deposito;
    }
    //     fim do metodo

    /// <summary>
    /// confere se o dinheiro digitado é maior que o saldo
    /// </summary>
    /// <param name="dinheiro"> dinheiro numero</param>
    /// <returns>string</returns>
    public string SacarDinheiro(float dinheiro){
        string msgSacar;
        if(dinheiro > Saldo){
            msgSacar = "não é possivel fazer essa operação, saldo insuficiente";
        }else{
            msgSacar = "transação feita com sucesso";
        }
        return msgSacar;
    }
    //     fim  metodo


    /// <summary>
    /// Confere se o valor do saldo é maior que o valor digitado
    /// </summary>
    /// <param name="valor"> dinheiro, numero, precisa de parce para float</param>
    /// <returns>string</returns>
    public string PagarConta(float valor){
        string msgPagar;
        if(Saldo < valor){
            msgPagar = $"desculpe seu saldo é: {Saldo}, não foi possivel realizar essa operação";
        }else{
            msgPagar = "operação realizada com sucesso";
        }

        return msgPagar;
    }   
    // fim do metodo

    // fechar conta
    public string FecarConta(){
        string msgFecharConta;
        if (Saldo == 0){
            msgFecharConta = "Conta fechada com sucesso";
        }else{
            msgFecharConta = " existe saldo disponivel, retire o dinheiro e efetue novamente a operação";
        }
        return msgFecharConta;
    }
    //     so pode se nao tiver saldo*/
       
    }
}
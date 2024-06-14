/* TI1B - Bryan Matheus Dos Santos Mota - Augusto Aristides Deolindo  - Raul Pereira*/
using System;
using System.IO;
class titulos{
    public void Principal_title(){ //titulo principal do programa
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t\t♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t\t♥　　 Seja bem-vindo ao     ♥");
        Console.WriteLine("\t\t\t♥　　Hospital Vida Feliz    ♥");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t\t♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ");
        Console.WriteLine("\n");
        Console.ResetColor();
    }
    public void tipo_pessoa(){ //pergunta sobre que tipo de pessoa o usuario é
        Console.WriteLine("\t\tPor favor digite oque você é: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t---------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|Funcionario | Paciente  | Atendimento de Urgencia|");
        Console.WriteLine("\t\t| digite: 1  | digite: 2 |        digite: 3       |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t---------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("\n");
    }
    public void tipo_infos(){ //pergunta se quer cadastro ou login 
        Console.WriteLine("\t\tPor favor escolha uma das opções: ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t--------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t| Cadastro   | Login     |");
        Console.WriteLine("\t\t| digite: 1  | digite: 2 |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t--------------------------");
        Console.ResetColor();
        Console.WriteLine("\n"); 
    }
    public void cadastro_titulo(){ //titulo do cadastro
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|          Vamos começar o seu cadastro           |");
        Console.WriteLine("\t\t|   Digite as informações conforme solicitadas    |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ResetColor();
    }
    public void cadastro_emergencia(){ //titulo do cadastro de emergencia
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|          Vamos começar o seu cadastro           |");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\t|    DIGITE ESSAS INFORMAÇÕES PARA EMERGÊNCIA     |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ResetColor();
    }
    public void login_titulo(){ //titulo login
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|           Vamos começar o seu Login             |");
        Console.WriteLine("\t\t|   Digite as informações conforme solicitadas    |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ResetColor();
    }
    public void informacao_invalida(){//titulo para valores invalidos
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tVocê digitou um valor inválido");
        Console.WriteLine("\t\t       Começe novamente       ");
        Console.ResetColor();
    }
    public void codigo_acesso_invalido(){//Menssagem para codigo de acesso invalido
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tVocê digitou um código de acesso inválido");
        Console.WriteLine("\t\t            Começe novamente             ");
        Console.ResetColor();
    }
    public void usuario_nao_encontrado(){//Menssagem para usuario não encontrado
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\t              O usuário não foi encontrado                    ");
        Console.WriteLine("\t\t Faça um cadastro ou verifique as informações tente novamente ");
        Console.WriteLine("\n");
        Console.ResetColor();
    }
    public void fim(){//Menssagem de finalização do programa
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t   ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|           Muito obrigado por utilizar nosso hospital         |");
        Console.WriteLine("\t\t|                 Esperamos que tenha gostado                  |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t   ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ");
        Console.ResetColor();
    }
    public void cadastro_sucesso_paciente(){//Mensagem de sucesso ao cadastrar paciente
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|        PACIENTE CADASTRADO COM SUCESSO          |");
        Console.WriteLine("\t\t|     para ser atendido faça login no sistema     |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ResetColor();
    }
    public void cadastro_sucesso_funcionario(){//Mensagem de sucesso ao cadastrar funcionário
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|      FUNCIONÁRIO CADASTRADO COM SUCESSO         |");
        Console.WriteLine("\t\t|    para marcar presença faça login no sistema   |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ResetColor();
    }
    public void cadastro_sucesso_emergencia(){//Mensagem de sucesso ao cadastrar Emergência
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t ---------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|              CADASTRADO COM SUCESSO               |");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\t|    DIRIJA-SE IMEDIATAMENTE AO PRONTO ATENDIMENTO  |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t ---------------------------------------------------");
        Console.ResetColor();
    }
    public void saudacao_paciente(){//Menssagem de boas vindas ao cadastro paciente
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|        Bem vindo ao cadastro de pacientes       |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ResetColor();
    }
    public void saudacao_funcionario(){//Menssagem de boas vindas ao cadastro funcionario
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\t\t|        Bem vindo ao cadastro de funcionarios    |");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\t\t -------------------------------------------------");
        Console.ResetColor();
    }
}
class pessoas{ //classe pai
    public string nome;
    public string email;
    public string sexo;
    public string data_nascimento;
    public long cpf;
    public long rg;
    public long telefone;
    public string cod_acesso;
    
    public string nome_login;
    public string cod_acesso_login;
    public string infos_gerais;
}

class paciente : pessoas{// classe dos pacientes
    titulos titulo = new titulos();
    public long num_convenio;
    public long atendimento;
    public string pessoa = "Paciente";
    public string arq_paciente = "reg_paciente.txt";
    public string pesquisa;
    public int num_localPessoa;
    public int tamanho;
    public string localizacaoPessoa;
    
    public void cadastro(){ //método para cadastro de pacientes
        if(!File.Exists(arq_paciente)){// verificando se o arquivo não existe
            File.WriteAllText(arq_paciente,"Nome:Codigo de acesso; E-mail; Sexo; Nascimento; CPF; RG; Telefone; Convenio; Codigo(atendimento)\n");
        }
        titulo.saudacao_paciente();
        titulo.cadastro_titulo();
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite o seu e-mail: ");
        email = Console.ReadLine();
        Console.Write("Digite o seu sexo: ");
        sexo = Console.ReadLine();
        Console.Write("Digite o sua data de nascimento (modelo DD/MM/AAAA): ");
        data_nascimento = Console.ReadLine();
        Console.Write("Digite o seu cpf: ");
        cpf = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o seu RG: ");
        rg = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o seu telefone: ");
        telefone = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o numero do seu convenio: ");
        num_convenio = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o codigo do atendimento: ");
        atendimento = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o seu codigo de acesso (digite um numero de 6 caracteres): ");
        cod_acesso = Console.ReadLine();
        if(cod_acesso.Length != 6){
            Console.Clear();
            titulo.codigo_acesso_invalido();
            cadastro();
        }
        infos_gerais = string.Concat(nome,":",cod_acesso,";",email,";",sexo,";",data_nascimento,";",cpf,";",rg,";",telefone,";",num_convenio,";",atendimento,"\n");
        File.AppendAllText(arq_paciente,infos_gerais);//Inserindo informações cadastradas ao fim do arquivo de texto 
        Console.Clear();
    }
    
    public void login(){//Método para login de pacientes
        if(!File.Exists(arq_paciente)){//verificando se o arquivo não existe
            File.WriteAllText(arq_paciente,"Nome:Codigo de acesso; E-mail; Sexo; Nascimento; CPF; RG; Telefone; Convenio; Codigo(atendimento)\n");
        }
        string infos_arq = File.ReadAllText(arq_paciente);//Lendo informações do arquivo texto 
        titulo.login_titulo();
        Console.Write("Digite o seu nome: ");
        nome_login = Console.ReadLine();
        Console.Write("Digite aqui seu codigo de acesso: ");
        cod_acesso_login = Console.ReadLine();
        Console.Clear();
        
        try{
            pesquisa = string.Concat(nome_login,":",cod_acesso_login); //concatena nome digitado e codigo para pesquisa no arq
            num_localPessoa = infos_arq.IndexOf(pesquisa); //verifica a posição das informações no arquivo
            tamanho = nome_login.Length + 7; //define o tamanho que deve ser procurado no arquivo
            localizacaoPessoa = infos_arq.Substring(num_localPessoa,tamanho);//encontra oque esta sendo procurado
                if(localizacaoPessoa == pesquisa){ //verifica se oque foi digitado é igual ao encontrado no arquivo
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n\n♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("♥      Seja Bem-Vindo de volta ao hospital "+nome_login.ToUpper()+"   ♥");
                    Console.WriteLine("♥      Aguarde seu atendimento, em instantes o    ♥");
                    Console.WriteLine("♥   Medico irá te chamar, enquanto isso assista   ♥");
                    Console.WriteLine("♥     um filme ou utilize a nossa rede de wifi    ♥");
                    Console.WriteLine("♥                   Muito Obrigado                ♥");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥\n\n");
                    Console.ResetColor();
                }else{
                    titulo.usuario_nao_encontrado();//Informações não bateram
                }
        }catch(Exception){
            titulo.usuario_nao_encontrado();//Erro ao encontrar o usuario
        }
    }
}
class funcionario : pessoas{// classe dos funcionarios
    titulos titulo = new titulos();
    public string funcao;
    public long num_resgistro;
    public string pessoa = "Funcionario";
    public string arq_funcionario = "reg_funcionario.txt";
    public string pesquisa;
    public int num_localPessoa;
    public int tamanho;
    public string localizacaoPessoa;
    
    public void cadastro(){//Método de cadastro de funcionarios 
        if(!File.Exists(arq_funcionario)){//Verificando se o arquivo não existe
            File.WriteAllText(arq_funcionario,"Nome:Codigo de acesso; E-mail; Sexo; Nascimento; CPF; RG; Telefone; Função; Número de Registro\n");//Criando arquivo e inserindo informações
        }
        titulo.saudacao_funcionario();
        titulo.cadastro_titulo();
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite o seu e-mail: ");
        email = Console.ReadLine();
        Console.Write("Digite o seu sexo: ");
        sexo = Console.ReadLine();
        Console.Write("Digite o sua data de nascimento (modelo DD/MM/AAAA): ");
        data_nascimento = Console.ReadLine();
        Console.Write("Digite o seu cpf: ");
        cpf = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o seu RG: ");
        rg = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o seu telefone: ");
        telefone = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite aqui sua função: ");
        funcao = Console.ReadLine();
        Console.Write("Digite seu numero de registro: ");
        num_resgistro = Convert.ToInt64(Console.ReadLine());
        Console.Write("Digite o seu codigo de acesso (digite um numero de 6 caracteres): ");
        cod_acesso = Console.ReadLine();
        if(cod_acesso.Length != 6){
            Console.Clear();
            titulo.codigo_acesso_invalido();
            cadastro();
        }
        infos_gerais = string.Concat(nome,":",cod_acesso,";",email,";",sexo,";",data_nascimento,";",cpf,";",rg,";",telefone,";",funcao,";",num_resgistro,"\n");
        File.AppendAllText(arq_funcionario,infos_gerais);//Inserindo informações cadastradas ao fim do arquivo de texto 
        
        Console.Clear();
    }
    
    public void login(){
        if(!File.Exists(arq_funcionario)){ //Verificando se o arquivo não existe
            File.WriteAllText(arq_funcionario,"Nome:Codigo de acesso; E-mail; Sexo; Nascimento; CPF; RG; Telefone; Função; Número de Registro\n");
        }
        string infos_arq = File.ReadAllText(arq_funcionario);//Lendo informações do arquivo texto
        titulo.login_titulo();
        Console.Write("Digite o seu nome: ");
        nome_login = Console.ReadLine();
        Console.Write("Digite aqui seu codigo de acesso: ");
        cod_acesso_login = Console.ReadLine();
         Console.Clear();
        
        try{
                    pesquisa = string.Concat(nome_login,":",cod_acesso_login);//Concatenando informações digitadas pelo usuario
                    num_localPessoa = infos_arq.IndexOf(pesquisa);//Procurando posição em que se encontra a pesquisa
                    tamanho = nome_login.Length + 7;//Definindo tamanho a ser procurado no arquivo
                    localizacaoPessoa = infos_arq.Substring(num_localPessoa,tamanho);//Encontrando oque está sendo procurado
                    if(localizacaoPessoa == pesquisa){//verifica se oque foi digitado é igual ao encontrado no arquivo
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n\n♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("♥      Seja Bem-Vindo de volta ao serviço "+nome_login.ToUpper()+"   ♥");
                        Console.WriteLine("♥     Seu horario de chegada ja foi marcado      ♥");
                        Console.WriteLine("♥ Existem muitas pessoas precisando de você hoje ♥");
                        Console.WriteLine("♥        Aproveite o seu dia de trabalho         ♥");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥\n\n");
                        Console.ResetColor();
                    }else{
                        titulo.usuario_nao_encontrado();//Informações não bateram
                    }
        }catch(Exception){
            titulo.usuario_nao_encontrado();//Erro ao encontrar o usuario
        }
    }
}
class emergencia : paciente{
    titulos titulo = new titulos();
    public string tipo_emergencia;
    public string arq_emergencia = "reg_emergencias.txt";
    
    public void cadastroRapido(){//Método de cadastro de emergencias
        if(!File.Exists(arq_emergencia)){//Verificando se o arquivo existe
            File.WriteAllText(arq_emergencia,"Nome; Sexo; Data de nascimento; tipo de emergência\n");
        }
        titulo.cadastro_emergencia();
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Digite o seu sexo: ");
        sexo = Console.ReadLine();
        Console.Write("Digite o sua data de nascimento (modelo DD/MM/AAAA): ");
        data_nascimento = Console.ReadLine();
        Console.Write("Qual o tipo de emergência: ");
        tipo_emergencia = Console.ReadLine();
        Console.Clear();
        
        infos_gerais = string.Concat(nome,";",sexo,";",data_nascimento,";",tipo_emergencia,"\n");
        File.AppendAllText(arq_emergencia,infos_gerais);//Inserindo informações cadastradas ao fim do arquivo de texto 
    }
}

class principal_program {
  static void Main() {
    
    titulos titulo = new titulos();
    paciente paciente = new paciente();
    funcionario funcionario =  new funcionario();
    emergencia emergencia = new emergencia();
    int continuar = 0;
    int tipo_pessoa;
    int tipo_acao;
    
    titulo.Principal_title(); //titulo principal
    
    for(int i = 0; continuar != 1; i++){
        titulo.tipo_pessoa();
        Console.Write("Escolha uma das opções aqui: ");
        tipo_pessoa = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if(tipo_pessoa == 1){//verificando a escolha do usuário sobre opções
            titulo.tipo_infos();
            Console.Write("Escolha uma das opções aqui: ");
            tipo_acao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(tipo_acao == 1){
                funcionario.cadastro();
                titulo.cadastro_sucesso_funcionario();
            }else if(tipo_acao == 2){
                funcionario.login();
            }else{
                titulo.informacao_invalida();
            }
        }else if(tipo_pessoa == 2){
            titulo.tipo_infos();
            Console.Write("Escolha uma das opções aqui: ");
            tipo_acao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if(tipo_acao == 1){
                paciente.cadastro();
                titulo.cadastro_sucesso_paciente();
            }else if(tipo_acao == 2){
                paciente.login();
            }else{
                titulo.informacao_invalida();
            }
        }else if(tipo_pessoa == 3){
            emergencia.cadastroRapido();
            titulo.cadastro_sucesso_emergencia();
        }else{
           titulo.informacao_invalida(); 
        }
        Console.Write("Para continuar digite 0, para finalizar digite 1: ");
        continuar = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
    }
        titulo.fim();
  }
}



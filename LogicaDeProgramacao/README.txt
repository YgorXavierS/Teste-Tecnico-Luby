Quest�es para candidato ao programa de est�gio incubadora ASP.NET Luby

        Esse teste inclui 10 quest�es envolvendo l�gica de programa��o e estrutura de dados.
        10 quest�es envolvendo cria��es de scripts SQL.
        Desafio para cria��o de um pequeno aplicativo que replica um funcionamento de uma m�quina de venda de bebidas em lata, utilizando os conceitos de orienta��o a objetos.
        As 10 quest�es envolvendo l�gica de programa��o e estrutura de dados + desafio de POO devem ser realizados usando a linguagem C#.
        Pode ser utilizado qualquer fun��o nativa da pr�pria linguagem.
        N�o utilizar depend�ncias ou bibliotecas externas.

Crie um reposit�rio no github para envio do c�digo com as repostas.
1 L�gica de Programa��o

    1.1 Implemente a fun��o abaixo para calcular fatorial de um n�mero.

    // 5! = 5 � 4 � 3 � 2 � 1 = 120
    CalcularFatorial(5) == 120//true

    1.2 Implemente a fun��o abaixo que calcula o valor total do pr�mio somando fator do tipo do pr�mio conforme valores:
        Tipo: "basic" fator multiplica��o do pr�mio: 1
        Tipo: "vip" fator multiplica��o do pr�mio: 1.2
        Tipo: "premium" fator multiplica��o do pr�mio: 1.5
        Tipo: "deluxe" fator multiplica��o do pr�mio: 1.8
        Tipo: "special" fator multiplica��o do pr�mio: 2
    Regras
        A fun��o tamb�m dever� provir um par�metro para que seja passado fator de multiplica��o pr�prio.
        Quando par�metro de fator de multiplica��o pr�prio for informado e v�lido o mesmo deve sobrescrever o c�lculo do tipo de pr�mio.
        O pr�mio nunca deve ter um valor negativo ou igual a zero.

CalcularPremio(100, "vip", null) == 120.00;//true
CalcularPremio(100, "basic", 3) == 300.00;//true

    1.3 Implemente a fun��o abaixo para contar quantos n�meros primos existem at� o n�mero informado.

    //N�mero primo: 2
    //N�mero primo: 3
    //N�mero primo: 5
    //N�mero primo: 7
    //Total de n�meros primos: 4
    ContarNumerosPrimos(10) == 4//true

    1.4 Implemente a fun��o abaixo que conta e calcula a quantidade de vogais dentro de uma string.

    CalcularVogais("Luby Software") == 4//true

    1.5 Implemente a fun��o abaixo que aplica uma porcentagem de desconto a um valor e retorna o resultado.
    Lembre-se que as entradas e sa�das dos dados s�o strings que devem ser tratadas.

    CalcularValorComDescontoFormatado("R$ 6.800,00", "30%") == "R$ 4.760,00"; //true 

    1.6 Implemente a fun��o abaixo que obt�m duas string de datas e calcula a diferen�a de dias entre elas.

    CalcularDiferencaData("10122020", "25122020") == 15; //true 

    1.7 Implemente a fun��o abaixo que retorna um novo vetor com todos elementos pares do vetor informado.

    int[] vetor = new int[] { 1,2,3,4,5 };
    ObterElementosPares(vetor) == new int { 2, 4 }; //true 

    1.8 Implemente a fun��o abaixo que deve buscar um ou mais elementos no vetor que cont�m o valor ou parte do valor informado na busca.

    string[] vetor = new string[] {
        "John Doe",
        "Jane Doe",
        "Alice Jones",
        "Bobby Louis",
        "Lisa Romero"
    };

    BuscarPessoa(vetor, "Doe") == new string[] { "John Doe", "Jane Doe" };//true
    BuscarPessoa(vetor, "Alice") == new string[] { "Alice Jones" };//true
    BuscarPessoa(vetor, "James") == new string[] { };//true

    1.9 Implemente a fun��o abaixo que obt�m uma string com n�meros separados por v�rgula e transforma em um array de array de inteiros com no m�ximo dois elementos.

    TransformarEmMatriz("1,2,3,4,5,6") == new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 } }; //true 

    1.10 Implemente a fun��o abaixo que compara dois vetores e cria um novo vetor com os elementos faltantes de ambos.

    // faltam elementos no vetor2
    int[] vetor1 = new int[] { 1,2,3,4,5 };
    int[] vetor2 = new int[] { 1,2,5 };
    ObterElementosFaltantes(vetor1, vetor2) == new int[] { 3, 4 }; //true 

    // faltam elementos no vetor3
    int[] vetor3 = new int[] { 1,4,5 };
    int[] vetor4 = new int[] { 1,2,3,4,5 };
    ObterElementosFaltantes(vetor3, vetor4) == new int[] { 2, 3 }; //true

    // faltam elementos em ambos vetores
    int[] vetor5 = new int[] { 1,2,3,4 };
    int[] vetor6 = new int[] { 2,3,4,5 };
    ObterElementosFaltantes(vetor5, vetor6) == new int[] { 1, 5 }; //true

    // n�o faltam items
    int[] vetor7 = new int[] { 1,3,4,5 };
    int[] vetor8 = new int[] { 1,3,4,5 };
    ObterElementosFaltantes(vetor7, vetor8) == new int[] { }; //true

2 SQL

    Resolva as quest�es utilizando as tabelas abaixo como refer�ncia\

+----+--------------+
| tabela_pessoa     |
+----+--------------+
| id | nome         |
+----+--------------+
|  1 | John Doe     |
|  2 | Jane Doe     |
|  3 | Alice Jones  |
|  4 | Bobby Louis  |
|  5 | Lisa Romero  |
+----+--------------+
+----+----------------+-----------+
| tabela_evento                   |
+----+----------------+-----------+
| id | evento         | pessoa_id |
+----+----------------+-----------+
|  1 | Evento A       |  2        |
|  2 | Evento B       |  3        |
|  3 | Evento C       |  2        |
|  4 | Evento D       |  NULL     |
+----+----------------+-----------+

    2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' e os respectivos eventos 'tabela_evento' o qual elas participam.
    2.2 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
    2.3 Crie uma query para adicionar um novo evento 'tabela_evento' e relacionar � pessoa 'Lisa Romero'.
    2.4 Crie uma query para atualizar 'Evento D' na 'tabela_evento' e relacionar � pessoa 'Joh Doe'
    2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'.
    2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa' que n�o possuem eventos 'tabela_evento' relacionados.

    Ger�nciamento de tabelas

    2.7 Crie uma query para alterar a tabela 'tabela_pessoa' e adicionar a coluna 'idade' (int)
    2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' que pertence a uma pessoa com seguintes campos:\

    id: int (PK)
    telefone: varchar(200)
    pessoa_id: int(FK)

    2.9 Crie uma query para criar uma �ndice do tipo �nico na coluna telefone da 'tabela_telefone'.
    2.10 Crie uma query para remover a 'tabela_telefone'.

3 Desafio em Orienta��o a Objetos
Desenvolver programa que rode uma Vending Machine (M�quina de venda de bebidas em lata) utilizando orienta��o objetos conforme as regras abaixo.

        Crie uma interface de usu�rio simples para execu��o da m�quina. (Utilizando Console por exemplo)
        A m�quina dever� possuir um estoque de produtos com valor e quantidade de cada produto. A quantidade de produto no estoque da m�quina deve ser alterado conforme realiza��o de vendas dos produtos.
        A m�quina dever� ter op��o para visualizar estoque e quantidade dispon�vel.
        A m�quina s� pode vender produtos com quantidade em estoque dispon�vel.
        A m�quina dever� contabilizar as vendas e mostrar o valor total das vendas realizadas.
        Uma venda s� poder� ser conclu�da ao inserir o valor total do produto.
        A m�quina dever� contabilizar e solicitar o valor faltante para finalizar a venda, caso haja valor de troco para dever� informar o valor.
        A m�quina n�o necessita de l�gica de contagem de notas, ser� apenas necess�rio informar os valores.
        N�o � necess�rio criar um banco de dados para o desafio, podendo ser utilizados dados est�ticos
        Caso necess�rio crie um documento simples com informa��es de como executar o programa.


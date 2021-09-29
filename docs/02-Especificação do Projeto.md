# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão realizado pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas, ou clientes típicos levantados no decorrer do procedimento de elucidação do problema, são descritas nas figuras que se seguem:

![Persona 01](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-4/blob/main/docs/img/Matheus.png)

![Persna 02](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-4/blob/main/docs/img/Bruna.png)

![Persona 03](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-4/blob/main/docs/img/Jos%C3%A9.png)

![Persona 04](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-4/blob/main/docs/img/Carla.png)

![Persona 05](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-4/blob/main/docs/img/Luiz.png)

![Persona 06](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2021-2-e2-proj-int-t1-t1-grupo-4/blob/main/docs/img/Davi.png)

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Cássia dos Santos Jardim  | Visualizar os pontos de coleta seletiva perto de casa. | A mãe gosta de separar o lixo corretamente, mas não sabe onde descartá-lo. |
|Daiane Azevedo  | Visualizar informações sobre a coleta seletiva na cidade. | Interessa-se pelo bem-estar do planeta e quer fazer sua parte para mantê-lo. |
|Ciro Antônio de Almeida  | manter um registro dos pontos de coleta seletiva. | Quer incentivar clientes e fornecedores a iniciar a coleta seletiva.  |
|Marcela de Albuquerque  | Fazer uma parceria da associação de moradores do bairro onde mora com centros de coleta seletiva. | Facilitar o descarte sustentável em seu bairro. |
|Luiz Henrique Viana  | Ser informado acerca dos pontos de coleta seletiva da cidade. | Começar a realizar a coleta seletiva em sua casa. |


## Requisitos

Esta seção apresenta os requisitos funcionais e não funcionais do projeto, com suas respectivas descrições e prioridades de implementação. 

### Requisitos Funcionais

Os requisitos funcionais representam as necessidades, características e recursos fornecidos pelo icook.


|ID           | Descrição do Requisito  | Prioridade |
|-------------|------------------------------|----|
|RF-001| O sistema deve oferecer funcionalidade de login e cadastro de usuários. | ALTA | 
|RF-002| O sistema deve estabelecer distintos níveis de acesso, categorizando funcionalidades e conteúdos segundo o seguinte critério: visitante, usuário padrão e usuário administrador (os usuários devem realizar login para poder visualizar funcionalidades exclusivas).  | ALTA |
|RF-003| O usuário padrão terá um perfil de usuário, por meio do qual poderá interagir com as receitas da plataforma. | ALTA | 
|RF-004| O sistema deve permitir que o usuário realize todas as operações de CRUD (Create/Retrieve/Update/Delete) na plataforma. Somente o usuário administrador poderá deletar e atualizar receitas que não sejam de sua autoria | ALTA | 
|RF-005| O sistema deve permitir que o usuário adicione comentários e imagens às receitas da plataforma.  | ALTA |  



### Requisitos não Funcionais

Os requisitos não-funcionais descrevem características de caráter mais técnico a serem observadas, com o objetivo de assegurar que os requisitos funcionais sejam devidamente atendidos. 

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Plataforma online gratuita para hospedagem da página (Heroku). | ALTA | 
|RNF-002| Banco de dados gratuito para armazenamento da informação (MySql). | ALTA | 
|RNF-003| Implementação de Back-end com linguagem a ser definida. | ALTA | 
|RNF-004| Definição de modelo de dados que permita a implementação de futuras funcionalidades de forma simples. | MÉDIA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir:

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 15/12/2021. |
|RE-02| O aplicativo deve utilizar conhecimentos de SQL e Modelagem de Dados, Engenharia de Requisitos de Software, Programação Modular, Algoritmos e Estruturas de Dados, Desenvolvimento Web Back End e Front End e Fundamentos de Redes de Computadores.  |
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho. |


## Diagrama de Casos de Uso

![Diagrama de Caso de Uso](https://images2.imgbox.com/4d/0f/HywU7vTc_o.png)

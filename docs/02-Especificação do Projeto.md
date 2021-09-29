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

Os requisitos funcionais representam as necessidades, características e recursos fornecidos pelo Colet@.


|ID           | Descrição do Requisito  | Prioridade |
|-------------|------------------------------|----|
| RF-001 | A plataforma deverá permitir um CRUD de pontos de coleta. | ALTA | 
| RF-002 | O usuário poderá visualizar, através de uma interface intuitiva e amigável, a localização do ponto de coleta.  | ALTA |
| RF-003 | O usuário terá um link para a plataforma do Google Maps, caso deseje visualizar o caminho até o ponto de coleta escolhido. | ALTA | 
| RF-004 | O usuário poderá buscar pontos de coleta seletiva por bairros de Belo Horizonte. | ALTA | 
| RF-005 | O usuário poderá buscar pontos de coleta para lixo eletrônico.  | ALTA | 
| RF-006 | Login para administrador com autorização para operações CRUD de pontos de coleta. | MÉDIA | 
| RF-007 | A plataforma poderá ser reutilizada em outras cidades. | MÉDIA | 



### Requisitos não Funcionais

Os requisitos não-funcionais descrevem características de caráter mais técnico a serem observadas, com o objetivo de assegurar que os requisitos funcionais sejam devidamente atendidos. 

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Obtenção e atualização dos dados de pontos de coleta seletiva em Belo Horizonte e Região Metropolitana. | ALTA | 
|RNF-002| Plataforma online gratuita para hospedagem da página (Heroku). | ALTA | 
|RNF-003| Banco de dados gratuito para armazenamento da informação (MySql). | ALTA | 
|RNF-004| Implementação de Back-end com linguagem a ser definida. | ALTA | 
|RNF-005| Integração com a API do Google Maps para visualização, em forma de mapa, dos pontos de coleta.| ALTA | 
|RNF-006| Definição de um modelo de criação e inserção de dados que facilite a reutilização e constante atualização da plataforma. | MÉDIA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir:

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 15/12/2021. |
|RE-02| O aplicativo deve utilizar conhecimentos de SQL e Modelagem de Dados, Engenharia de Requisitos de Software, Programação Modular, Algoritmos e Estruturas de Dados, Desenvolvimento Web Back End e Front End e Fundamentos de Redes de Computadores.  |
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho. |


## Diagrama de Casos de Uso

![Diagrama de Caso de Uso](https://images2.imgbox.com/4d/0f/HywU7vTc_o.png)

## S.O.L.I.D

SOLID é um acrônimo para principios base no desenvolvimento de software. Ele representa 5 principios de boas práticas em POO que ajudam a escrever códigos mais robustos e limpos, mais fáceis de estender, entender, testar, reutilizar e manter.

- S — Single Responsiblity Principle (Princípio da responsabilidade única)
- O — Open-Closed Principle (Princípio Aberto-Fechado)
- L — Liskov Substitution Principle (Princípio da substituição de Liskov)
- I — Interface Segregation Principle (Princípio da Segregação da Interface)
- D — Dependency Inversion Principle (Princípio da inversão da dependência)

[Exemplo de implementação SOLID em Java](https://github.com/caiofrz/clean-code-rocketseat/tree/master/src/main/java/com/caiofrz/solid)

### DRY - Don't Repeat Yourself

Apesar não fazer parte da sigla, DRY está diretamente relacionado a SOLID e Clean Code. O principio DRY tem haver com duplicação de lógica de conhecimento, e não só sobre duplicação de código. 

- Não copie e cole partes de funcionalidades no seu código
- Não coloque a mesma responsabilidade em camadas deiferentes da aplicação
- Não use nomes diferentes que representem a mesma lógica ou conhecimento
- Evite código ambíguo ou duplicado

### Single Responsiblity Principle (Princípio da responsabilidade única)

Princípio da Responsabilidade Única — _"Uma classe deve ter um, e somente um, motivo para mudar"_.

Esse princípio declara que uma classe deve ser especializada em um único assunto e possuir apenas uma responsabilidade dentro do software, ou seja, a classe deve ter uma única tarefa ou ação para executar. Ela deve ter apenas *um* motivo para mudar.

### Open-Closed Principle (Princípio Aberto-Fechado)

Princípio Aberto-Fechado — *Objetos ou entidades devem estar abertos para extensão, mas fechados para modificação*, ou seja, quando novos comportamentos e recursos precisam ser adicionados no software, devemos estender e não alterar o código fonte original.

### Liskov Substitution Principle (Princípio da substituição de Liskov)

Princípio da substituição de Liskov — _Uma classe derivada deve ser substituível por sua classe base_.

Exemplos de violação do LSP:

- Sobrescrever/implementar um método que não faz nada
- Lançar uma exceção inesperada
- Retornar valores de tipos diferentes da classe base

Seguir o LSP permite usar polimorfismo com mais confiança. Podemos chamar nossas classes derivadas referindo-se à sua classe base sem preocupações com resultados inesperados.

### Interface Segregation Principle (Princípio da Segregação da Interface)

Princípio da Segregação da Interface — _Uma classe não deve ser forçada a implementar interfaces e métodos que não irão utilizar._

É melhor criar várias interfaces específicas do que uma interface genérica.

### Dependency Inversion Principle (Princípio da inversão da dependência)

Princípio da Inversão de Dependência — _Dependa de abstrações e não de implementações_.

- Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender da abstração.
- Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.

O princípio da Inversão de Dependência tem como objetivo manter o foco no design da tarefa, deixando este design independente ou desacoplado do componente que vai executar as tarefas de baixo nivel que não fazem parte da modelagem do negocio.

Inversão de Dependência não é igual a Injeção de Dependência. A Inversão de Dependência é um princípio (Conceito) e a Injeção de Dependência é um padrão de projeto (Design Pattern). São coisas distintas, mas que relacionam entre si com um proposito em comum, deixar o código desacoplado.

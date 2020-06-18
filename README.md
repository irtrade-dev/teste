# Avaliação de Conhecimentos – Programador C#


# Enunciado do teste:
Criar uma listagem de fornecedores relacionado a uma empresa;

A empresa deverá ser composta por:
* UF;
* Nome Fantasia;
* CNPJ.

# O fornecedor deverá ser composto por:
* Empresa;
* Nome;
* CPF ou CNPJ;
* Data/hora de cadastro;
* Telefone (Quantidade de telefones é variável).

# Regras:
* O campo ‘Empresa’ será um cadastro a parte;
* Caso a empresa seja do Paraná, não permitir cadastrar um fornecedor pessoa física menor de idade;
* Caso o fornecedor seja pessoa física, também é necessário cadastrar o RG e a data de nascimento;
* A listagem de fornecedores deverá conter filtros por Nome, CPF/CNPJ e data de cadastro.

# Acesso ao banco de dados
* Cadeia de conexão: Server=tcp:irtrade.database.windows.net,1433;Initial Catalog=dbteste;Persist Security Info=False;User ID=irtrade;Password={dbFornecedor00};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

# Observação:
Apenas para conhecimento, aqui trabalhamos com ASP.NET MVC 5 e .NET CORE, WebAPI 2, VS2019, VSCode, Bootstrap, Angular.
Para controle de fontes, utilizamos o AzureDevOps.
Importante minimizar o uso do Scaffolding (geração automatizada de código), pois o objetivo do teste é analisar o seu conhecimento.
Questões tecnológicas/frameworks, ficam a sua escolha (sugerimos você utilizar o que mais conhece).

### * Não há necessidade de criar a UI para o usuário. Apenas criar os end-points para consumo via postman.

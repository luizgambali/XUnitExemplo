# ExemploXUnit

Exemplo MUITO simples de utilização com XUnit. O objetivo é demonstrar as chamadas e testes no Asserts, como chamadas simples, 
driven data, comparação de valores, saída de mensagens no output dos testes, comparação de objetos.

## Relatorio de Cobertura de Testes

Dentro do projeto de testes, adicionar o seguinte pacote:

dotnet add package coverlet.msbuild

Para rodar os testes e exibir o relatorio de cobertura:

dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=src/Test/lcov.info [path-do-seu-projeto-de-testes]

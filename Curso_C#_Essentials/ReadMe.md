## C# .Net

.Net é uma plataforma de código aberto, multiplataforma, usada para construção de apps em C#, principalmente. Version 8.0 atualmente.


- CIL -> Common Intermediate language
- CLR -> Common Runtime Language
- JIT -> Just In Time
									
### Processos de Compilação e Gerenciamento
.cs -> Compiled -> CIL  / Bytecode -> CLR / JIT -> Native Code (Win, Linux, Mac)
|_______________________________||_____________________________|
		Compilação                                          Gerenciamento / Runtime
		

- Sdk é similar ao jdk. 
- C# acompanha a versão MVStudio. 

### CLI:
*dotnet* : comando base
```cmd
dotnet --version
dotnet new "typeProject"
dotnet --list-runtime/sdks
dotnet run
```

### SDK's diferentes

Para criar um projeto com uma versão de sdk diferente é necessário criar um ./global.json com a seguinte estrutura:
```json
{
	"sdk": {
		"version":"7.0"
	}
}
```

Ou usar o comando ```dotnet new globaljson --sdk-version 7.0 --force```


### Convenções

- Usar maisuclas para constantes
```c# 
const double PI = 3.14;
```
- Pascal Case para nome de métodos, classes, e propriedades 
```c# 
Console.WriteLine("Hello, World!");
```
- Camel Case para variaveis e 
```c#  
string nomeCompleto = "Caio Ferraz";
```
- Para propriedades privadas, começar com _ e usar Camal Case.
```c#  
private string _nomeCompleto = "Caio Ferraz";
```

### Nullable Types

Tipos primitivos não aceitam null. São tipos não nulos. Algumas alternativas São
```c#  
Nullable<string> nomeCompleto = null;
```
```c#  
string nomeCompleto? = null;
```

Verifica se nomeCompleto é nulo, se for, atribui "N/A".
```c#  
string nome = nomeCompleto ?? "N/A";
```

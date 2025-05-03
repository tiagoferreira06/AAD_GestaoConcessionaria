# 🚗 Sistema de Gestão - Stand Automóvel Ferrari
Cadeira - Armazenamento e Acesso a Dados

Este projeto consiste no desenvolvimento de uma aplicação de gestão para um stand automóvel da Ferrari, com foco no registo e administração de clientes, funcionários, veículos e vendas.

## 🧰 Tecnologias Utilizadas

- **Linguagem:** C#
- **Framework:** .NET Windows Forms
- **Base de Dados:** SQL Server
- **IDE:** Visual Studio

---

## 📋 Algumas das Funcionalidades

### 🔹 Clientes
- Inserção, consulta e listagem de clientes
- Dados armazenados: nome, data de nascimento, morada, telefone, email

### 🔹 Funcionários
- Inserção e gestão de funcionários
- Atributos: nome, cargo, contacto

### 🔹 Carros
- Registo de veículos disponíveis para venda
- Campos: modelo, ano, preço, estado (disponível/vendido)

### 🔹 Vendas
- Associação de carros vendidos a clientes e funcionários
- Registo da data e valor da venda
- Atualização automática do estado do carro

### 🔹 Orçamentos
- Criação de orçamentos para potenciais clientes
- Inclui valor proposto e dados do veículo

---

## 🗃️ Base de Dados

A estrutura da base de dados é composta por tabelas relacionadas com chaves primárias e estrangeiras, sendo algumas delas:

- `Clientes`
- `Funcionarios`
- `Carros`
- `Vendas`

As operações CRUD são realizadas através de comandos SQL diretamente no C#, com segurança e validação de dados.

---

## 🧪 Testes

O sistema foi testado com dados simulados para garantir:
- Registos consistentes entre vendas e carros
- Atualização correta do estado dos veículos
- Integridade referencial entre as tabelas

---

## 📌 Conclusão

Este projeto permitiu aplicar conhecimentos práticos em programação orientada a objetos com C#, desenvolvimento de interfaces gráficas e integração com bases de dados relacionais. O sistema é funcional, escalável e preparado para cenários reais de gestão automóvel.

---

## 👨‍💻 Autor

Trabalho desenvolvido no âmbito da unidade curricular de **Armazenamento e Acesso a Dados**.

- **Nome:** _[Tiago Nunes Ferreira e Yuri Santos Nascimento]_  
- **Instituição:** _[Instituto Politécnico do Cávado e do Avé]_  

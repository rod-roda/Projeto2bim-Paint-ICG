# 🖌️ Projeto Paint em Windows Forms

Este é um projeto bimestral feito em C# com Windows Forms que simula as funcionalidades básicas do famoso **Microsoft Paint**, com uma interface intuitiva e suporte a múltiplas formas geométricas.

## 🎯 Objetivo

Recriar uma versão simplificada do Paint utilizando Windows Forms, explorando conceitos como:
- Manipulação de eventos de mouse
- Desenho com `Graphics`
- Interface gráfica com `WinForms`
- Organização de dados em memória
- Leitura e escrita de arquivos (`.dat`)

---

## 🧱 Funcionalidades

### ✏️ Ferramentas de desenho
Você pode desenhar as seguintes formas:
- Linha reta
- Retângulo
- Círculo
- Elipse
- Triângulo
- Losango
- Pentágono

### 🎨 Personalização
- Escolha da **cor primária** e **cor secundária**
- Seleção de **espessura da linha**
- Estilos de contorno:
  - Sólido
  - Tracejado
  - Traço e ponto
  - Traço e dois pontos
  - Pontilhado

### 💾 Salvamento e carregamento
- Salve os desenhos em um arquivo `dados.dat` no caminho `C:\Arquivos\`
- Reabra o arquivo posteriormente e continue de onde parou

Cada forma é salva com:
- Nome do tipo
- Coordenadas
- Cor RGB
- Espessura
- Estilo do traço

---

## 🖼️ Interface

A interface é composta por:
- Paleta de cores com 20 opções
- Área de seleção de forma geométrica
- Combobox de espessura e estilo
- Área de desenho interativa
- Botões de **limpar**, **salvar** e **carregar**

---

## 🧠 Como funciona

O desenho é feito utilizando a API `System.Drawing`. As formas são armazenadas em um `Dictionary<string, List<(int[], Pen)>>`, onde:
- A **chave** representa o tipo da forma (ex: "Retas", "Elipses")
- O **valor** é uma lista de tuplas contendo as posições e a caneta usada

### Exemplo de desenho:
```csharp
e.Graphics.DrawEllipse(caneta, x, y, largura, altura);
```
---

## 🚀 Como executar
1. Abra o projeto no Visual Studio  
2. Compile e execute  
3. Use o mouse para desenhar formas  
4. Clique nos botões de cor para definir as cores  
5. Selecione espessura e estilo  
6. Use os botões **Salvar** e **Importar** conforme necessário

---

## 🛠️ Tecnologias utilizadas
- C#  
- Windows Forms  
- .NET Framework  
- Biblioteca System.Drawing

---

## 🙋‍♂️ Autores
Desenvolvido por **Rodrigo Roda** e **Thiago Alexander** como parte de um projeto bimestral de Introdução a Computação Gráfica.  

---

## 📜 Licença
Este projeto é livre para fins acadêmicos e educacionais.

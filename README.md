# LDP_AS
Repositório dedicado ao envio e visualização do código de Avaliação Final da cadeira de Laboratório de Programação

O projeto utiliza de conceitos da Progrmação Orientada a Objeto por meio de seus quatro pilares
1 - Abstração:
Utilizou-se classes que correspondem ao ambiente de uma biblioteca. A classe Item Biblioteca pode ser usada para representar qualquer item presente no ambiente de uma biblioteca com um ID e Título para identificação, poderia ser desde uma mesa até um livro de uma estante. A classe Livro tem suas caracteristícas que também correspondem a uma adaptação da realidade, contendo ID, título, autor, e descrição.

2 - Encapsulamento
Para encapsular, ou seja, proteger a funcionamento interno de determinadas características de uma classe, foi usado o modificador de acesso "protected", pois foi preciso que a "descrição" fosse acessada pelas classes herdeiras da ItemBiblioteca, tornando a descrição padrão protegida e permitindo um reaproveitamento de sua estrutura, sem modificá-la.

3 - Herança
Foi usada a classe Livro para herdar as características da ItemBiblioteca, pois além de conter as propriedades de ID e Título, o livro também precisa conter o autor e sua descrição. A herança além de reaproveitar a estrutura da matriz, proporciona uma maior organização e aproveitamento de linhas de código.

4- Polimorfismo:
Os métodos de BuscarItemPorId e BuscarItemPorTítulo obteram uma sobrecarga de método para garantir uma pesquisa de dois parâmetros, os quais sofreram a adição da propriedade "autor". Isso permite que além de usar um parâmetro único, pode ser usada a adição de "autor" ao garantir que este é de fato o livro que está sendo procurado, essa escolha pode ser justificada em uma biblioteca de grande escala onde a chance de ocorrer dois livros de mesmo título é significativa.

Outros conceitos também foram aplicados ao script, exemplos disso são a as classes abstratas que definem uma base de para as herdeiras seguirem, a qual não pode ser atribuída com valores impostos, além do método de remoção de livros, o qual gera uma busca do ID especificado e remova da lista Biblioteca criada.
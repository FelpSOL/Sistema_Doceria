CREATE DATABASE db_doceria2;
USE db_doceria2;

CREATE TABLE tb_usuarios (
	id_usuario int auto_increment,
    cpf varchar (12) unique,
    nome varchar(50),
    email varchar (150) unique,
    senha varchar (50),
    controle_acesso int (3),
    
    primary key (id_usuario)
    );
 
CREATE TABLE tb_categorias (
	id_categoria int auto_increment,
    nome_categoria varchar(30) unique,
    
    primary key (id_categoria)
);

CREATE TABLE tb_sabores (
	id_sabor int auto_increment,
	nome_sabor varchar(30) unique,
    
    primary key (id_sabor)
);

CREATE TABLE tb_produtos (
	id_produto int auto_increment,
    
    imagem varchar (300),
    nome varchar (50),
    descricao varchar (200),
    valor decimal (6,2),
    promocao bool,
    
    id_categoria int,
	id_sabor int,
    
    primary key (id_produto),
    foreign key (id_categoria) references tb_categorias(id_categoria),
	foreign key (id_sabor) references tb_sabores(id_sabor)
);


INSERT INTO tb_usuarios (cpf, nome, email, senha) VALUES 
('123456', 'Mariana', 'mariana@email.com', 'adm12345'),
('12345678', 'Felipe', 'felipe@email.com', 'adm123'),
('1234567', 'Leticia', 'leticia@email.com', 'adm1234'),
('100', 'serasa', 'serasa.com.br', '123'),
('123', '123', '123', '123')
;
 SELECT * FROM tb_usuarios;
 
INSERT INTO tb_categorias (nome_categoria) VALUES
('Bolo de pote'),
('Bolo de festa'),
('Brigadeiros'),
('Trufas'),
('Brownie'),
('Pâo de mel'),
('Bebidas');
 SELECT * FROM tb_categorias;
 
INSERT INTO tb_sabores (nome_sabor) VALUES 
('Chocolate'),
('Morango'),
('Abacaxi'),
('Maracujá'),
('Prestígio'),
('Paçoca'),
('Côco com Abacaxi'),
('Cenoura com chocolate'),
('Laranja'),
('Beijinho'),
('Bicho de pé'),
('Black'),
('Café'),
('Ninho com Nutella'),
('Churros'),
('Ferrero Rocher'),
('Oreo'),
('Torta de Limão'),
('Surpresa de Uva'),
('Red Velvet'),
('Cacau, côco e avelã'),
('Ninho com Morango'),
('Nutella'),
('Doce de Leite'),
('Amêndoas'),
('Sem recheio'),
('Pasta de Amendoim'),
('Água'),
('Café com Leite'),
('Capuccino'),
('Chá Mate'),
('Cola-Cola'),
('Guaraná'),
('Sprite');
 SELECT * FROM tb_sabores;
 
/*SELECTs -> */
 SELECT * FROM tb_usuarios;
 SELECT * FROM tb_categorias;
 SELECT * FROM tb_sabores;
 SELECT * FROM tb_produtos;
 
INSERT INTO tb_produtos (imagem, nome, descricao, valor, promocao, id_categoria, id_sabor)
VALUES 
/*Bolos de Pote ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(2).png', 'Chocolate', 'Massa de Chocolate, macia e fofinha', 10.00, FALSE, 1, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(3).png', 'Maracujá', 'O verdadeiro sabor do maracujá com Massa de Chocolate', 10.00, FALSE, 1, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(4).png', 'Maracujá', 'O verdadeiro sabor do maracujá com Massa Branca', 10.00, FALSE, 1, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(6).png', 'Morango', 'Morangos fesquinhos e saborosos com Massa de Chocolate', 10.00, FALSE, 1, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(5).png', 'Morango', 'Morangos fesquinhos e saborosos com Massa Branca', 10.00, FALSE, 1, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(7).png', 'Abacaxi', 'Abacaxi doce e suculento com Massa Branca', 10.00, FALSE, 1, 3),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolosDePote/Frame%209%20(8).png', 'Prestígio', 'Feito com recheio de beijinho e Massa de Chocolate', 10.00, FALSE, 1, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolodepote4.png', 'Morango', 'Low Carb de Morangos saborosos com Massa de Chocolate', 10.00, FALSE, 1, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolodepote3.png', 'Paçoca', 'Low Carb com amendois de qualidade e Massa Branca', 10.00, FALSE, 1, 6),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/boodepote2.png', 'Coco com Abacaxi', 'Low Carb uma junção saborosa com Massa Branca', 10.00, FALSE, 1, 7),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolodepode1.png', 'Cenoura com Chocolate', 'Low Carb de um clássico da vovó com Massa de Chocolate', 8.99, TRUE, 1, 8),
/*Bolos de Festas ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(2).png', 'Chocolate', 'Massa de Chocolate com recheio cremoso', '80.00', FALSE, 2, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(3).png', 'Maracujá', 'Recheio de maracujá natural com Massa de Chocolate', 80.00, FALSE, 2, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(4).png', 'Maracujá', 'Recheio de maracujá natural com Massa Branca', 80.00, FALSE, 2, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(6).png', 'Morango', 'Com morangos selecionados e Massa de Chocolate', 80.00, FALSE, 2, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(5).png', 'Morango', 'Com morangos selecionados e Massa Branca', 80.00, FALSE, 2, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%209%20(7).png', 'Abacaxi', 'Com abacaxi fresco e Massa Branca', 80.00, FALSE, 2, 3),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bolos/Frame%20(1).png', 'Prestígio', 'Feito com recheio de beijinho e Massa de Chocolate', 80.00, FALSE, 2, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolo1.png', 'Morango', 'Low Carb sem perder o doce do morango, Massa Branca', 80.00, FALSE, 2, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolo2.png', 'Prestígio', 'Low Carb sem perder o doce do prestígio com Massa de Chocolate', 80.00, FALSE, 2, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/bolo3.png', 'Laranja', 'Low Carb com laranja natural e Massa Branca', 69.99, TRUE, 2, 9),
/*Brigadeiros ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(13).png', 'Chocolate', 'Cremoso e com sabor intenso de chocolate, envolto em granulado', 1.50, FALSE, 3, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(12).png', 'Beijinho', 'Cremoso e com sabor suave de coco, coberto com açucar', 1.50, FALSE, 3, 10),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(11).png', 'Bicho de Pé', 'Cremoso e com sabor delicado de morango', 2.50, FALSE, 3, 11),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209.png', 'Black', 'Sabor intenso de chocolate amargo, coberto com granulado de chocolate', 2.50, FALSE, 3, 12),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(10).png', 'Café', 'Cremoso e com sabor marcante de café', 2.50, FALSE, 3, 13),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(1).png', 'Ninho com Nutella', 'Sabor delicado do leite Ninho combinado com o toque aveludado da Nutella', 2.50, FALSE, 3, 14),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(9).png', 'Churros', 'Cremoso e com sabor de canela e doce de leite', 2.50, FALSE, 3, 15),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(8).png', 'Ferrero Rocher', 'Sabor de avelã e chocolate, coberto com granulado crocante de avelã', 3.00, FALSE, 3, 16),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(7).png', 'Maracujá', 'Cremoso e com sabor tropical e ácido do maracujá', 3.00, FALSE, 3, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(6).png', 'Oreo', 'Cremoso e com pedaços de biscoito Oreo misturados', 3.00, FALSE, 3, 17),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(5).png', 'Torta de Limão', 'Com sabor refrescante de limão e toque suave de leite condensado', 3.00, FALSE, 3, 18),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(4).png', 'Paçoca', 'Sabor marcante de amendoim, coberto com pedaços de paçoca triturada', 2.50, FALSE, 3, 6),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(3).png', 'Surpresa de Uva', 'Com uma uva dentro e cremoso com sabor doce de uva e um toque ácido', 2.50, FALSE, 3, 19),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brigadeiros/Frame%209%20(2).png', 'Red Velvet', 'Cremoso com sabor suave de baunilha e creme tize', 3.00, FALSE, 3, 20),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/brigadeiro1.png', 'Cacau, Coco e Avelã', 'Low Carb cremoso com o sabor intenso de cacau, a suavidade do coco e o toque crocante da avelã', 3.00, FALSE, 3, 21),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/brigadeiro2.png', 'Chocolate', 'Low Carb cremoso e com sabor intenso de chocolate', 1.99, TRUE, 3, 1),
/*Trufas ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(5).png', 'Ferrero Rocher', 'Trufas sabor Ferrero Rocher, com creme de avelã, pedaços crocantes e cobertura de chocolate', 5.00, FALSE, 4, 16),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(6).png', 'Morango', 'Trufas de morango suaves, com recheio cremoso e sabor delicadamente frutado', 5.00, FALSE, 4, 2),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(4).png', 'Chocolate', 'Trufas de chocolate cremosas, com sabor intenso e cobertura delicada', 5.00, FALSE, 4, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(3).png', 'Maracujá', 'Trufas de maracujá cremosas, com sabor tropical e toque cítrico', 5.00, FALSE, 4, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_trufas/Frame%209%20(2).png', 'Prestígio', 'Trufas Prestígio, com recheio cremoso de coco e cobertura de chocolate', 5.00, FALSE, 4, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/trufa.png', 'Chocolate', 'Low Carb de chocolate cremosas, com sabor intenso e cobertura delicada', 3.99, TRUE, 4, 1),
/*Brownie ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(2).png', 'Sem Recheio', 'Simples mas com massa densa e sabor intenso de chocolate, sem recheio', 5.00, FALSE, 5, 26),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(3).png', 'Chocolate', 'Macio por dentro, com sabor intenso e cobertura levemente crocante', 7.00, FALSE, 5, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(4).png', 'Ninho com Morango', ' Massa macia com cobertura cremosa e toque frutado', 7.00, FALSE, 5, 22),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(5).png', 'Prestígio', 'Com base de chocolate, recheio de coco cremoso e cobertura de chocolate', 7.00, FALSE, 5, 5),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(6).png', 'Nutella', 'Com massa úmida e recheio cremoso de avelã e chocolate', 7.00, FALSE, 5, 23),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_brownies/Frame%209%20(7).png', 'Doce de Leite', 'Massa macia e recheio cremoso de doce de leite', 7.00, FALSE, 5, 24),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/brownie.png', 'Amêndoas', 'Low Carb com massa rica e pedaços crocantes de amêndoas', 5.99, TRUE, 5, 25),
/*Pão de Mel ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_paesdemel/Frame%209%20(4).png', 'Doce de Leite', 'Com doce de leite cremoso, Uma combinação clássica e irresistível', 8.00, FALSE, 6, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_paesdemel/Frame%209%20(3).png', 'Prestígio', 'Delicioso creme de coco com chocolate, Uma explosão de sabor a cada mordida ', 8.00, FALSE, 6, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_paesdemel/Frame%209%20(2).png', 'Chocolate', 'Com cremoso brigadeiro, Perfeito para os amantes de chocolate ', 8.00, FALSE, 6, 1),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_low/paodemel.png', 'Pasta de Amendoim', 'Low Carb com um sabor marcante e irresistível', 6.99, TRUE, 6, 1),
/*Bebidas ->*/
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(12).png', 'Água', 'Água mineral e purificada', 3.00, FALSE, 7, 28),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(2).png', 'Café', 'Café puro e moido na hora', 5.00, FALSE, 7, 13),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(4).png', 'Café com Leite', 'Uma mistura perfeita de sabor', 6.00, FALSE, 7, 29),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(3).png', 'Cappuccino', 'Bebida italiana à base de café espresso', 7.00, FALSE, 7, 30),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(5).png', 'Chá Mate', 'Chá com sabor suave e relaxante', 6.00, FALSE, 7, 31),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(6).png', 'Coca-Cola', 'Refrigerante gaseificado à base de cafeina', 8.00, FALSE, 7, 32),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(7).png', 'Guaraná Antartica', 'Refrigerante gaseificado à base de guaraná', 8.00, FALSE, 7, 33),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(8).png', 'Sprite', 'Refrigerante gaseificado à base de limão', 8.00, FALSE, 7, 34),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(9).png', 'Suco de Laranja', 'Suco natural de laranja feito na hora', 9.00, FALSE, 7, 9),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(11).png', 'Suco de Maracujá', 'Suco natural de maracujá feito na hora', 9.00, FALSE, 7, 4),
('https://raw.githubusercontent.com/Leticia3carvalho/Projeto-Mari-Doces/refs/heads/main/imagensProjeto/imagensProjeto/img_bebidas/Frame%209%20(10).png', 'Suco de Abacaxi', 'Suco natural de abacaxi feito na hora', 7.99, TRUE, 7, 3)
;

SELECT * FROM tb_produtos;
SELECT * FROM tb_produtos WHERE descricao = 'Low Carb';
SELECT * FROM tb_produtos WHERE descricao = 'Massa Branca';
SELECT * FROM tb_produtos WHERE descricao = 'Massa Chocolate';

DROP TABLE tb_produtos;


CREATE TABLE tb_notas_pedidos(
	id_nota_pedido varchar(20),
    
    id_item int,
	id_usuario int,
	id_produto int,
    
    primary key (id_nota_pedido),
    
    foreign key (id_item) references tb_items(id_item),
	foreign key (id_usuario) references tb_usuarios(id_usuario),
	foreign key (id_produto) references tb_produtos(id_produto)
);

CREATE TABLE tb_items(
	id_item int auto_increment,
    
    quantidade_produto int(4),
    valor_total decimal (6,2),
	para_viagem bool,
    forma_pagamento varchar(15),
	metodo_de_pagamento varchar(20),
	status_pagamento varchar(20),
    
	primary key (id_item)
);









/* comentarios-------------------------------------------------------*/

/* 
DROP TABLE tb_usuarios;
DROP TABLE tb_produtos;
DROP TABLE tb_categorias;
DROP TABLE tb_sabores;
DROP TABLE tb_promocoes;

DELETE FROM tb_;
DROP TABLE tb_;
TRUNCATE TABLE tb_;
 
SELECT * FROM tb_sabores;
SELECT DISTINCT nome_sabor FROM tb_sabores;
 
DELETE FROM tb_bebidas WHERE id_bebida > 12; 
 
SELECT * FROM tb_sabores;
SELECT DISTINCT nome_sabor FROM tb_sabores;
DELETE FROM tb_sabores WHERE id_sabor > 27;
ALTER TABLE tb;

SELECT tb_produtos.*, tb_categorias.nome_categoria FROM tb_produtos
INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria;

/*SELECT * FROM tb_produtos 
INNER JOIN tb_categorias ON id_categoria = 
WHERE quantidade > 0 
*/
 
/*-----------------------tabelas possivelmente apagadas--------------------------------------*/
/*CREATE TABLE tb_nf_pagamentos(
	id_pagamento varchar(20),
    status_pagamento varchar(20),
	forma_de_pagamento varchar(20),
   /* id_nota_fiscal varchar(20),*/
    
	/*primary key (id_pagamento)
    /*foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);*/

/*CREATE TABLE tb_notas_fiscais(
	id_nota_fiscal varchar(20),
    
	valor_total decimal (6,2),
    forma_de_pagamento varchar(20),
	/*status_pagamento varchar(20),
    
	id_usuario varchar(20),
    /*id_item varchar(20),
	
    primary key (id_nota_fiscal),
	foreign key (id_usuario) references tb_usuarios(id_usuario)
    /*foreign key (id_item) references tb_nf_item(id_item)
);

CREATE TABLE tb_nf_item(
	id_nf_item int auto_increment,
    
    quantidade_produto int(4),
	id_produto int,
    id_nota_fiscal varchar(20),
    
	primary key (id_nf_item),
	foreign key (id_produto) references tb_produtos(id_produto),
    foreign key (id_nota_fiscal) references tb_notas_fiscais(id_nota_fiscal)
);*/

 /*
CREATE TABLE tb_promocoes (
	id_promocao bool,
    
    id_produto int,
    
    primary key (id_promocao),
    foreign key (id_produto) references tb_produtos(id_produto)
);

SELECT tb_produtos.*, tb_categorias.nome_categoria, tb_sabores.nome_sabor FROM tb_produtos 
INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria 
INNER JOIN tb_sabores ON tb_produtos.id_sabor = tb_sabores.id_sabor 
WHERE tb_produtos.id_categoria = id_categoria AND descricao LIKE '%Low Carb%';

SELECT tb_produtos.*, tb_categorias.nome_categoria, tb_sabores.nome_sabor FROM tb_produtos 
INNER JOIN tb_categorias ON tb_produtos.id_categoria = tb_categorias.id_categoria 
INNER JOIN tb_sabores ON tb_produtos.id_sabor = tb_sabores.id_sabor 
WHERE tb_produtos.id_categoria = id_categoria;*/
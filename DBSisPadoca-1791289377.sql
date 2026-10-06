CREATE TABLE IF NOT EXISTS `cliente` (
	`cpf` int AUTO_INCREMENT NOT NULL UNIQUE,
	`nome` varchar(100) NOT NULL,
	`telefone` varchar(20) NOT NULL,
	`email` varchar(150),
	`data_nascimento` date,
	`ativo` boolean NOT NULL,
	PRIMARY KEY (`cpf`)
);
CREATE TABLE IF NOT EXISTS `Funcionário` (
	`id_funcionario` int AUTO_INCREMENT NOT NULL UNIQUE,
	`nome` varchar(100) NOT NULL,
	`cep` varchar(8),
	`data_nascimento` date NOT NULL,
	`cargo` int NOT NULL,
	`email` varchar(150),
	`telefone` varchar(13) NOT NULL,
	`cpf` varchar(11) NOT NULL,
	PRIMARY KEY (`id_funcionario`)
);
CREATE TABLE IF NOT EXISTS `cargo` (
	`id_cargo` int AUTO_INCREMENT NOT NULL UNIQUE,
	`nome` varchar(50) NOT NULL,
	`descricao` varchar(150) NOT NULL,
	PRIMARY KEY (`id_cargo`)
);
CREATE TABLE IF NOT EXISTS `venda` (
	`id_venda` int AUTO_INCREMENT NOT NULL UNIQUE,
	`data_hora` datetime NOT NULL,
	`valor_total` decimal(10,2) NOT NULL,
	`desconto` decimal(10,2) NOT NULL,
	`status` varchar(20) NOT NULL,
	`cpf_cliente` varchar(14) NOT NULL,
	`id_funcionario` int NOT NULL,
	PRIMARY KEY (`id_venda`)
);
CREATE TABLE IF NOT EXISTS `produtos` (
	`id_produto` int AUTO_INCREMENT NOT NULL UNIQUE,
	`nome` varchar(100) NOT NULL,
	`descricao` varchar(250) NOT NULL,
	`preco_venda` decimal(10,2) NOT NULL,
	`preco_custo` decimal(10,2) NOT NULL,
	`estoque_atual` int NOT NULL,
	`estoque_minimo` int NOT NULL,
	`ativo` boolean NOT NULL,
	`id_categoria` int NOT NULL,
	PRIMARY KEY (`id_produto`)
);
CREATE TABLE IF NOT EXISTS `categoria` (
	`id_categoria` int AUTO_INCREMENT NOT NULL UNIQUE,
	`nome` varchar(100) NOT NULL,
	`descricao` varchar(250) NOT NULL,
	PRIMARY KEY (`id_categoria`)
);
CREATE TABLE IF NOT EXISTS `item_venda` (
	`id_item` int AUTO_INCREMENT NOT NULL UNIQUE,
	`id_venda` int NOT NULL,
	`id_produto` int NOT NULL,
	`quantidade` decimal(10,3) NOT NULL,
	`preco_unit` decimal(10,2) NOT NULL,
	`subtotal` decimal(10,2) NOT NULL,
	PRIMARY KEY (`id_item`)
);
CREATE TABLE IF NOT EXISTS `pagamento` (
	`id_pagamento` int AUTO_INCREMENT NOT NULL UNIQUE,
	`id_venda` int NOT NULL,
	`tipo` varchar(20) NOT NULL,
	`valor` decimal(10,2) NOT NULL,
	`data_hora` datetime NOT NULL,
	`status` varchar(20) NOT NULL,
	PRIMARY KEY (`id_pagamento`)
);
CREATE TABLE IF NOT EXISTS `fornecedor` (
	`id_fornecedor` int AUTO_INCREMENT NOT NULL UNIQUE,
	`razao_social` varchar(150) NOT NULL,
	`nome_fantasia` varchar(100) NOT NULL,
	`cnpj` varchar(15) NOT NULL,
	`telefone` varchar(20) NOT NULL,
	`email` varchar(100) NOT NULL,
	`cep` varchar(8) NOT NULL,
	PRIMARY KEY (`id_fornecedor`)
);
CREATE TABLE IF NOT EXISTS `compra` (
	`id_compra` int AUTO_INCREMENT NOT NULL UNIQUE,
	`id_fornecedor` int NOT NULL,
	`id_funcionario` int NOT NULL,
	`data_hora` datetime NOT NULL,
	`valor_total` decimal(10,2) NOT NULL,
	`status` varchar(20) NOT NULL,
	PRIMARY KEY (`id_compra`)
);
CREATE TABLE IF NOT EXISTS `item_compra` (
	`id_item_compra` int AUTO_INCREMENT NOT NULL UNIQUE,
	`id_compra` int NOT NULL,
	`id_produto` int NOT NULL,
	`quantidade` decimal(10,3) NOT NULL,
	`preco_unit` decimal(10,2) NOT NULL,
	`subtotal` decimal(10,2) NOT NULL,
	PRIMARY KEY (`id_item_compra`)
);
ALTER TABLE `Funcionário` ADD CONSTRAINT `Funcionário_fk4` FOREIGN KEY (`cargo`) REFERENCES `cargo`(`id_cargo`);
ALTER TABLE `venda` ADD CONSTRAINT `venda_fk5` FOREIGN KEY (`cpf_cliente`) REFERENCES `cliente`(`cpf`);
ALTER TABLE `venda` ADD CONSTRAINT `venda_fk6` FOREIGN KEY (`id_funcionario`) REFERENCES `Funcionário`(`id_funcionario`);
ALTER TABLE `produtos` ADD CONSTRAINT `produtos_fk8` FOREIGN KEY (`id_categoria`) REFERENCES `categoria`(`id_categoria`);
ALTER TABLE `item_venda` ADD CONSTRAINT `item_venda_fk1` FOREIGN KEY (`id_venda`) REFERENCES `venda`(`id_venda`);
ALTER TABLE `item_venda` ADD CONSTRAINT `item_venda_fk2` FOREIGN KEY (`id_produto`) REFERENCES `produtos`(`id_produto`);
ALTER TABLE `pagamento` ADD CONSTRAINT `pagamento_fk1` FOREIGN KEY (`id_venda`) REFERENCES `venda`(`id_venda`);
ALTER TABLE `compra` ADD CONSTRAINT `compra_fk1` FOREIGN KEY (`id_fornecedor`) REFERENCES `fornecedor`(`id_fornecedor`);
ALTER TABLE `compra` ADD CONSTRAINT `compra_fk2` FOREIGN KEY (`id_funcionario`) REFERENCES `Funcionário`(`id_funcionario`);
ALTER TABLE `item_compra` ADD CONSTRAINT `item_compra_fk1` FOREIGN KEY (`id_compra`) REFERENCES `compra`(`id_compra`);
ALTER TABLE `item_compra` ADD CONSTRAINT `item_compra_fk2` FOREIGN KEY (`id_produto`) REFERENCES `produtos`(`id_produto`);
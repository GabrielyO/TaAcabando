-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.22-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              9.4.0.5125
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para caderno
CREATE DATABASE IF NOT EXISTS `caderno` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `caderno`;

-- Copiando estrutura para tabela caderno.aluno
CREATE TABLE IF NOT EXISTS `aluno` (
  `matricula` char(20) NOT NULL,
  `usuario` char(15) NOT NULL,
  `senha` char(20) NOT NULL,
  PRIMARY KEY (`matricula`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela caderno.aluno: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` (`matricula`, `usuario`, `senha`) VALUES
	('231101015', 'gaby', '123'),
	('231101515', 'Ursula', 'ur00');
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;

-- Copiando estrutura para tabela caderno.caderno
CREATE TABLE IF NOT EXISTS `caderno` (
  `idCaderno` char(30) NOT NULL,
  `turma` char(15) NOT NULL DEFAULT '0',
  `ano` char(15) NOT NULL DEFAULT '0',
  `senha` char(20) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idCaderno`),
  KEY `idCaderno` (`idCaderno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela caderno.caderno: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `caderno` DISABLE KEYS */;
INSERT INTO `caderno` (`idCaderno`, `turma`, `ano`, `senha`) VALUES
	('IN106/2017', 'IN106', '2017', '123'),
	('in108/2017', 'in108', '2017', '123'),
	('in307/2017', 'in307', '2017', '123');
/*!40000 ALTER TABLE `caderno` ENABLE KEYS */;

-- Copiando estrutura para tabela caderno.conteudo
CREATE TABLE IF NOT EXISTS `conteudo` (
  `idConteudo` char(80) NOT NULL,
  `idCaderno` char(80) NOT NULL,
  `nome` char(20) NOT NULL,
  `titulo` char(30) NOT NULL,
  `conteudo` longtext NOT NULL,
  PRIMARY KEY (`idConteudo`),
  KEY `idCaderno` (`idCaderno`),
  KEY `idMateria` (`nome`),
  KEY `idConteudo` (`idConteudo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela caderno.conteudo: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `conteudo` DISABLE KEYS */;
INSERT INTO `conteudo` (`idConteudo`, `idCaderno`, `nome`, `titulo`, `conteudo`) VALUES
	('cc', 'in307/2017', 'FÍSICA', 'TA ACABANDO', 'DGSDGGSDGDFGFDGDF'),
	('fs', 'in108/2017', 'FÍSICA', 'dsgds', 'dssdg');
/*!40000 ALTER TABLE `conteudo` ENABLE KEYS */;

-- Copiando estrutura para tabela caderno.materia
CREATE TABLE IF NOT EXISTS `materia` (
  `idMateria` char(20) NOT NULL,
  `nome` char(15) NOT NULL,
  PRIMARY KEY (`idMateria`),
  KEY `nome` (`nome`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela caderno.materia: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `materia` DISABLE KEYS */;
INSERT INTO `materia` (`idMateria`, `nome`) VALUES
	('IDBIOLOGIA', 'BIOLOGIA'),
	('IDFÍSICA', 'FÍSICA'),
	('IDQUÍMICA', 'QUÍMICA'),
	('IDSOCIOLOGIA', 'SOCIOLOGIA');
/*!40000 ALTER TABLE `materia` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

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

-- Copiando dados para a tabela caderno.aluno: ~3 rows (aproximadamente)
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` (`matricula`, `usuario`, `senha`) VALUES
	('231100815', 'ivad', 'batata123'),
	('231101015', 'Gabriely', '040400'),
	('231101515', 'Ursula', 'ur00');
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;

-- Copiando dados para a tabela caderno.caderno: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `caderno` DISABLE KEYS */;
INSERT INTO `caderno` (`idCaderno`, `turma`, `ano`, `senha`) VALUES
	('123123', '123', '123', '123');
/*!40000 ALTER TABLE `caderno` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;

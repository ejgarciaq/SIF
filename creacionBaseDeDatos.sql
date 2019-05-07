-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema sif_db
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `sif_db` ;

-- -----------------------------------------------------
-- Schema sif_db
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sif_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `sif_db` ;

-- -----------------------------------------------------
-- Table `sif_db`.`categoria`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`categoria` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`categoria` (
  `CAT_IDCATEGORIA` INT(11) NOT NULL,
  `CAT_DESCRIPCION` VARCHAR(50) NOT NULL,
  `ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`CAT_IDCATEGORIA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`persona`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`persona` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`persona` (
  `PER_IDPERSONA` INT(11) NOT NULL,
  `PER_NOMBRE` VARCHAR(50) NOT NULL,
  `PER_APELLIDO1` VARCHAR(50) NOT NULL,
  `PER_APELLIDO2` VARCHAR(50) NOT NULL,
  `PER_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`PER_IDPERSONA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`cliente` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`cliente` (
  `CLI_IDPERSONA` INT(11) NOT NULL,
  `CLI_TOTALCOMPRADO` DECIMAL(10,0) NOT NULL,
  `CLI_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`CLI_IDPERSONA`),
  CONSTRAINT `fk_cliente_persona1`
    FOREIGN KEY (`CLI_IDPERSONA`)
    REFERENCES `sif_db`.`persona` (`PER_IDPERSONA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`local`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`local` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`local` (
  `EMP_IDEMPRESA` INT(11) NOT NULL,
  `LOC_NOMBRE` VARCHAR(50) NOT NULL,
  `LOC_ACTIVO` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`EMP_IDEMPRESA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`tipoconectividad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`tipoconectividad` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`tipoconectividad` (
  `TIP_IDTIPO` INT(11) NOT NULL,
  `TIP_DESCRIPCION` VARCHAR(50) NOT NULL,
  `ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`TIP_IDTIPO`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`conectividadlocal`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`conectividadlocal` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`conectividadlocal` (
  `CON_IDCONECTIVIDAD` INT(11) NOT NULL,
  `EMP_IDEMPRESA` INT(11) NOT NULL,
  `TIP_IDTIPO` INT(11) NOT NULL,
  `CON_DESCRIPCION` VARCHAR(50) NOT NULL,
  `CON_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`CON_IDCONECTIVIDAD`, `EMP_IDEMPRESA`),
  INDEX `fk_conectividad_tipoConectividad1_idx` (`TIP_IDTIPO` ASC) VISIBLE,
  INDEX `fk_conectividadLocal_Local1_idx` (`EMP_IDEMPRESA` ASC) VISIBLE,
  CONSTRAINT `fk_conectividadLocal_Local1`
    FOREIGN KEY (`EMP_IDEMPRESA`)
    REFERENCES `sif_db`.`local` (`EMP_IDEMPRESA`),
  CONSTRAINT `fk_conectividad_tipoConectividad1`
    FOREIGN KEY (`TIP_IDTIPO`)
    REFERENCES `sif_db`.`tipoconectividad` (`TIP_IDTIPO`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`conectividadpersona`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`conectividadpersona` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`conectividadpersona` (
  `TEL_IDTELEFONO` INT(11) NOT NULL,
  `PER_IDPERSONA` INT(11) NOT NULL,
  `TIP_IDTIPO` INT(11) NOT NULL,
  `CON_DESCRIPCION` VARCHAR(50) NOT NULL,
  `CON_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`TEL_IDTELEFONO`, `PER_IDPERSONA`),
  INDEX `fk_telefono_persona1_idx` (`PER_IDPERSONA` ASC) VISIBLE,
  INDEX `fk_conectividadPersona_tipoConectividad1_idx` (`TIP_IDTIPO` ASC) VISIBLE,
  CONSTRAINT `fk_conectividadPersona_tipoConectividad1`
    FOREIGN KEY (`TIP_IDTIPO`)
    REFERENCES `sif_db`.`tipoconectividad` (`TIP_IDTIPO`),
  CONSTRAINT `fk_telefono_persona1`
    FOREIGN KEY (`PER_IDPERSONA`)
    REFERENCES `sif_db`.`persona` (`PER_IDPERSONA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`rol`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`rol` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`rol` (
  `ROL_IDROL` INT(11) NOT NULL,
  `ROL_DESCRIPCION` VARCHAR(50) NOT NULL,
  `ROL_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`ROL_IDROL`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`usuario`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`usuario` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`usuario` (
  `USU_IDPERSONA` INT(11) NOT NULL,
  `ROL_IDROL` INT(11) NOT NULL,
  `USU_USERNAME` VARCHAR(50) NOT NULL,
  `USU_PASSWORD` VARCHAR(50) NOT NULL,
  `USU_INTENTOS` TINYINT(4) NOT NULL,
  `USU_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`USU_IDPERSONA`),
  INDEX `fk_usuario_persona1_idx` (`USU_IDPERSONA` ASC) VISIBLE,
  INDEX `fk_usuario_rol1_idx` (`ROL_IDROL` ASC) VISIBLE,
  CONSTRAINT `fk_usuario_persona1`
    FOREIGN KEY (`USU_IDPERSONA`)
    REFERENCES `sif_db`.`persona` (`PER_IDPERSONA`),
  CONSTRAINT `fk_usuario_rol1`
    FOREIGN KEY (`ROL_IDROL`)
    REFERENCES `sif_db`.`rol` (`ROL_IDROL`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`factura`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`factura` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`factura` (
  `FAC_IDFACTURA` INT(11) NOT NULL,
  `EMP_IDEMPRESA` INT(11) NOT NULL,
  `CLI_IDPERSONA` INT(11) NOT NULL,
  `USU_IDPERSONA` INT(11) NOT NULL,
  `FAC_FECHA` DATETIME NOT NULL,
  `FAC_TOTAL` DECIMAL(10,0) NOT NULL,
  `FAC_ACTIVA` BIT(1) NOT NULL,
  PRIMARY KEY (`FAC_IDFACTURA`, `EMP_IDEMPRESA`, `CLI_IDPERSONA`, `USU_IDPERSONA`),
  INDEX `fk_factura_Local1_idx` (`EMP_IDEMPRESA` ASC) VISIBLE,
  INDEX `fk_factura_cliente1_idx` (`CLI_IDPERSONA` ASC) VISIBLE,
  INDEX `fk_factura_usuario1_idx` (`USU_IDPERSONA` ASC) VISIBLE,
  CONSTRAINT `fk_factura_Local1`
    FOREIGN KEY (`EMP_IDEMPRESA`)
    REFERENCES `sif_db`.`local` (`EMP_IDEMPRESA`),
  CONSTRAINT `fk_factura_cliente1`
    FOREIGN KEY (`CLI_IDPERSONA`)
    REFERENCES `sif_db`.`cliente` (`CLI_IDPERSONA`),
  CONSTRAINT `fk_factura_usuario1`
    FOREIGN KEY (`USU_IDPERSONA`)
    REFERENCES `sif_db`.`usuario` (`USU_IDPERSONA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`estado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`estado` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`estado` (
  `EST_IDESTADO` INT(11) NOT NULL,
  `EST_DESCRIPCION` VARCHAR(50) NOT NULL,
  `EST_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`EST_IDESTADO`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`unidad`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`unidad` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`unidad` (
  `UNI_IDUNIDAD` INT(11) NOT NULL,
  `UNI_DESCRIPCION` VARCHAR(50) NOT NULL,
  `UNI_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`UNI_IDUNIDAD`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`producto` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`producto` (
  `PRO_IDPRODUCTO` INT(11) NOT NULL,
  `PRO_IDCATEGORIA` INT(11) NOT NULL,
  `PRO_IDUNIDAD` INT(11) NOT NULL,
  `PRO_IDESTADO` INT(11) NOT NULL,
  `PRO_NOMBRE` VARCHAR(50) NOT NULL,
  `PRO_CANTIDAD` INT(11) NOT NULL,
  `PRO_PRECIO` DECIMAL(10,0) NOT NULL,
  `PRO_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`PRO_IDPRODUCTO`),
  INDEX `FK_IDCATEGORIA_idx` (`PRO_IDCATEGORIA` ASC) VISIBLE,
  INDEX `FK_IDESTADO_idx` (`PRO_IDESTADO` ASC) VISIBLE,
  INDEX `FK_IDUNIDAD_idx` (`PRO_IDUNIDAD` ASC) VISIBLE,
  CONSTRAINT `FK_IDCATEGORIA`
    FOREIGN KEY (`PRO_IDCATEGORIA`)
    REFERENCES `sif_db`.`categoria` (`CAT_IDCATEGORIA`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_IDESTADO`
    FOREIGN KEY (`PRO_IDESTADO`)
    REFERENCES `sif_db`.`estado` (`EST_IDESTADO`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `FK_IDUNIDAD`
    FOREIGN KEY (`PRO_IDUNIDAD`)
    REFERENCES `sif_db`.`unidad` (`UNI_IDUNIDAD`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`detalle`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`detalle` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`detalle` (
  `DET_IDDETALLE` INT(11) NOT NULL,
  `FAC_IDFACTURA` INT(11) NOT NULL,
  `PRO_IDPRODUCTO` INT(11) NOT NULL,
  `DET_CANTIDAD` INT(11) NOT NULL,
  `DET_PRECIO` DECIMAL(10,0) NOT NULL,
  PRIMARY KEY (`DET_IDDETALLE`, `FAC_IDFACTURA`),
  INDEX `fk_detalle_producto1_idx` (`PRO_IDPRODUCTO` ASC) VISIBLE,
  INDEX `fk_detalle_factura1` (`FAC_IDFACTURA` ASC) VISIBLE,
  CONSTRAINT `fk_detalle_factura1`
    FOREIGN KEY (`FAC_IDFACTURA`)
    REFERENCES `sif_db`.`factura` (`FAC_IDFACTURA`),
  CONSTRAINT `fk_detalle_producto1`
    FOREIGN KEY (`PRO_IDPRODUCTO`)
    REFERENCES `sif_db`.`producto` (`PRO_IDPRODUCTO`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`formapago`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`formapago` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`formapago` (
  `FOR_IDFORMAPAGO` INT(11) NOT NULL,
  `FOR_DESCRIPCION` VARCHAR(50) NOT NULL,
  `FOR_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`FOR_IDFORMAPAGO`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `sif_db`.`pago`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `sif_db`.`pago` ;

CREATE TABLE IF NOT EXISTS `sif_db`.`pago` (
  `PAG_IDPAGO` INT(11) NOT NULL,
  `FAC_IDFACTURA` INT(11) NOT NULL,
  `FOR_IDFORMAPAGO` INT(11) NOT NULL,
  `PAG_MONTO` DECIMAL(10,0) NOT NULL,
  `PAG_COMPROBANTE` VARCHAR(50) NOT NULL,
  `PAG_ACTIVO` BIT(1) NOT NULL,
  PRIMARY KEY (`PAG_IDPAGO`, `FAC_IDFACTURA`),
  INDEX `FK_IDFORMAPAGO_idx` (`FOR_IDFORMAPAGO` ASC) VISIBLE,
  INDEX `fk_pago_factura1_idx` (`FAC_IDFACTURA` ASC) VISIBLE,
  CONSTRAINT `FK_IDFORMAPAGO`
    FOREIGN KEY (`FOR_IDFORMAPAGO`)
    REFERENCES `sif_db`.`formapago` (`FOR_IDFORMAPAGO`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_pago_factura1`
    FOREIGN KEY (`FAC_IDFACTURA`)
    REFERENCES `sif_db`.`factura` (`FAC_IDFACTURA`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

INSERT INTO `sif_db`.`rol` (`ROL_IDROL`, `ROL_DESCRIPCION`, `ROL_ACTIVO`) VALUES (0, "Administrador", true);
INSERT INTO `sif_db`.`rol` (`ROL_IDROL`, `ROL_DESCRIPCION`, `ROL_ACTIVO`) VALUES (1, "Vendedor", true);

INSERT INTO `sif_db`.`persona` (`PER_IDPERSONA`, `PER_NOMBRE`, `PER_APELLIDO1`, `PER_APELLIDO2`, `PER_ACTIVO`) VALUES (117570961, "Andres", "Zuniga", "Mora", true);
INSERT INTO `sif_db`.`usuario` (`USU_IDPERSONA`, `ROL_IDROL`, `USU_USERNAME`, `USU_PASSWORD`, `USU_INTENTOS`, `USU_ACTIVO`) VALUES (117570961, 1, "Andreszm2009", "Chupi2013.", 3, true);
INSERT INTO `sif_db`.`persona` (`PER_IDPERSONA`, `PER_NOMBRE`, `PER_APELLIDO1`, `PER_APELLIDO2`, `PER_ACTIVO`) VALUES (111240424, "Edson", "Garcia", "Quiros", true);
INSERT INTO `sif_db`.`usuario` (`USU_IDPERSONA`, `ROL_IDROL`, `USU_USERNAME`, `USU_PASSWORD`, `USU_INTENTOS`, `USU_ACTIVO`) VALUES (111240424, 0, "egarcia", "T4rtaro1981.", 3, true);
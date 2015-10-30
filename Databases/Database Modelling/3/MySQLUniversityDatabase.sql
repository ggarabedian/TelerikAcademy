-- MySQL Script generated by MySQL Workbench
-- 10/09/15 15:44:22
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema university
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema university
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `university` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `university` ;

-- -----------------------------------------------------
-- Table `university`.`Faculties`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`Faculties` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` NVARCHAR(100) NOT NULL COMMENT '',
  PRIMARY KEY (`id`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`Departaments`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`Departaments` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` NVARCHAR(200) NOT NULL COMMENT '',
  `Faculties_id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`id`, `Faculties_id`)  COMMENT '',
  INDEX `fk_Departaments_Faculties1_idx` (`Faculties_id` ASC)  COMMENT '',
  CONSTRAINT `fk_Departaments_Faculties1`
    FOREIGN KEY (`Faculties_id`)
    REFERENCES `university`.`Faculties` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`Professors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`Professors` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` NVARCHAR(150) NOT NULL COMMENT '',
  `Departaments_id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`id`, `Departaments_id`)  COMMENT '',
  INDEX `fk_Professors_Departaments1_idx` (`Departaments_id` ASC)  COMMENT '',
  CONSTRAINT `fk_Professors_Departaments1`
    FOREIGN KEY (`Departaments_id`)
    REFERENCES `university`.`Departaments` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`Titles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`Titles` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` NVARCHAR(200) NOT NULL COMMENT '',
  PRIMARY KEY (`id`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`ProfessorTitles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`ProfessorTitles` (
  `Titles_id` INT NOT NULL COMMENT '',
  `Professors_id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Titles_id`, `Professors_id`)  COMMENT '',
  INDEX `fk_ProfessorTitles_Titles1_idx` (`Titles_id` ASC)  COMMENT '',
  INDEX `fk_ProfessorTitles_Professors1_idx` (`Professors_id` ASC)  COMMENT '',
  CONSTRAINT `fk_ProfessorTitles_Titles1`
    FOREIGN KEY (`Titles_id`)
    REFERENCES `university`.`Titles` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProfessorTitles_Professors1`
    FOREIGN KEY (`Professors_id`)
    REFERENCES `university`.`Professors` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`Courses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`Courses` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` NVARCHAR(200) NOT NULL COMMENT '',
  `Departaments_id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`id`, `Departaments_id`)  COMMENT '',
  INDEX `fk_Courses_Departaments1_idx` (`Departaments_id` ASC)  COMMENT '',
  CONSTRAINT `fk_Courses_Departaments1`
    FOREIGN KEY (`Departaments_id`)
    REFERENCES `university`.`Departaments` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`ProfessorCourses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`ProfessorCourses` (
  `Professors_id` INT NOT NULL COMMENT '',
  `Courses_id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Professors_id`, `Courses_id`)  COMMENT '',
  INDEX `fk_ProfessorCourses_Professors1_idx` (`Professors_id` ASC)  COMMENT '',
  INDEX `fk_ProfessorCourses_Courses1_idx` (`Courses_id` ASC)  COMMENT '',
  CONSTRAINT `fk_ProfessorCourses_Professors1`
    FOREIGN KEY (`Professors_id`)
    REFERENCES `university`.`Professors` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ProfessorCourses_Courses1`
    FOREIGN KEY (`Courses_id`)
    REFERENCES `university`.`Courses` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`Students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`Students` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` NVARCHAR(150) NOT NULL COMMENT '',
  `facultyId` INT NOT NULL COMMENT '',
  PRIMARY KEY (`id`, `facultyId`)  COMMENT '')
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `university`.`StudentCourses`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `university`.`StudentCourses` (
  `Courses_id` INT NOT NULL COMMENT '',
  `Students_id` INT NOT NULL COMMENT '',
  PRIMARY KEY (`Courses_id`, `Students_id`)  COMMENT '',
  INDEX `fk_StudentCourses_Courses1_idx` (`Courses_id` ASC)  COMMENT '',
  INDEX `fk_StudentCourses_Students1_idx` (`Students_id` ASC)  COMMENT '',
  CONSTRAINT `fk_StudentCourses_Courses1`
    FOREIGN KEY (`Courses_id`)
    REFERENCES `university`.`Courses` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_StudentCourses_Students1`
    FOREIGN KEY (`Students_id`)
    REFERENCES `university`.`Students` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

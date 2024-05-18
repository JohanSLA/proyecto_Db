-- crea la base de datos en caso de no existir con el nombre apiDb
CREATE DATABASE IF NOT EXISTS bank;

-- Comando para indicar que se quiere usar esa base de datos
USE bank;

-- Crear la tabla usuarios en caso de que no exista con esos atributos
CREATE TABLE IF NOT EXISTS usuario (
    id INT PRIMARY KEY,
    login VARCHAR(100),
    clave VARCHAR(100),
    fechaCreacion DATE,
    nivel VARCHAR(100)
);

-- Crea la tabla empleado en caso de que no exista
CREATE TABLE IF NOT EXISTS empleado (
    codigo INT PRIMARY KEY,
    cedula VARCHAR(100),
    nombreCompleto VARCHAR(100),
    direccion VARCHAR(100),
    telefono VARCHAR(20)
);

-- Crea la tabla profesion en caso de que no exista
CREATE TABLE IF NOT EXISTS profesion (
    codigo INT PRIMARY KEY,
    nombre VARCHAR(100)    
);

-- Crea la tabla cargo en caso de que no exista
CREATE TABLE IF NOT EXISTS cargo (
    codigo INT PRIMARY KEY,
    nombre VARCHAR(100),
    salario DOUBLE    
);

-- Crea la tabla funcion en caso de que no exista
CREATE TABLE IF NOT EXISTS funcion (
    codigo INT PRIMARY KEY,
    nombre VARCHAR(100),
    descripcion VARCHAR(200)    
);

-- Crea la tabla bitacora en caso de que no exista
CREATE TABLE IF NOT EXISTS bitacora (
    numeroIngreso INT PRIMARY KEY,
    fechaIngreso DATE,
    fechaSalida DATE,
    horaIngreso TIME,
    horaSalida TIME   
);

-- Crea la tabla sucursal en caso de que no exista
CREATE TABLE IF NOT EXISTS sucursal (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200),
    direccion VARCHAR(250),
    presupuesto DOUBLE  
);

-- Crea la tabla municipio en caso de que no exista
CREATE TABLE IF NOT EXISTS municipio (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200),
    poblacion INT  
);

-- Crea la tabla prioridad en caso de que no exista
CREATE TABLE IF NOT EXISTS prioridad (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200)  
);

-- Crea la tabla departamento en caso de que no exista
CREATE TABLE IF NOT EXISTS departamento (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200),
    poblacion INT 
);


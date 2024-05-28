-- crea la base de datos en caso de no existir con el nombre apiDb
CREATE DATABASE IF NOT EXISTS bank;

-- Comando para indicar que se quiere usar esa base de datos
USE bank;

-- Crear la tabla usuarios en caso de que no exista con esos atributos
CREATE TABLE IF NOT EXISTS usuario (
    id VARCHAR(50) PRIMARY KEY,
    login VARCHAR(100) NOT NULL,
    clave VARCHAR(100) NOT NULL,
    fechaCreacion DATE,
    nivel VARCHAR(100)
);

-- Crea la tabla bitacora en caso de que no exista
CREATE TABLE IF NOT EXISTS bitacora (
    numeroIngreso INT PRIMARY KEY,
    fechaIngreso DATE NOT NULL,
    fechaSalida DATE NOT NULL,
    horaIngreso TIME NOT NULL,
    horaSalida TIME NOT NULL,
    usuario_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (usuario_id) REFERENCES usuario(id)
);
-- Crea la tabla profesion en caso de que no exista
CREATE TABLE IF NOT EXISTS profesion (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL   
);

-- Crea la tabla cargo en caso de que no exista
CREATE TABLE IF NOT EXISTS cargo (
    codigo VARCHAR(100) PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    salario DOUBLE NOT NULL
);

-- Crea la tabla departamento en caso de que no exista
CREATE TABLE IF NOT EXISTS departamento (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200) NOT NULL,
    poblacion INT NOT NULL
);
-- Crea la tabla prioridad en caso de que no exista
CREATE TABLE IF NOT EXISTS prioridad (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200) NOT NULL
);

-- Crea la tabla funcion en caso de que no exista
CREATE TABLE IF NOT EXISTS funcion (
    codigo INT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(200) NOT NULL,
    cargo_codigo VARCHAR(100) NOT NULL,
    FOREIGN KEY (cargo_codigo) REFERENCES cargo(codigo)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- Crea la tabla municipio en caso de que no exista
CREATE TABLE IF NOT EXISTS  municipio (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200) NOT NULL,
    poblacion INT NOT NULL,
    departamento_codigo VARCHAR(50)NOT NULL,
    prioridad_codigo VARCHAR(50) NOT NULL,
    FOREIGN KEY (departamento_codigo) REFERENCES departamento(codigo)
     ON DELETE CASCADE
    ON UPDATE CASCADE,
    FOREIGN KEY (prioridad_codigo) REFERENCES prioridad(codigo)
     ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- Crea la tabla sucursal en caso de que no exista
CREATE TABLE IF NOT EXISTS sucursal (
    codigo VARCHAR(50) PRIMARY KEY,
    nombre VARCHAR(200) NOT NULL,
    direccion VARCHAR(250) NOT NULL,
    presupuesto DOUBLE NOT NULL,  
    codigo_municipio varchar(50) NOT NULL,
    FOREIGN KEY(codigo_municipio) references municipio(codigo)
    ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- Crea la tabla contrato en caso de que no exista
CREATE TABLE  IF NOT EXISTS contrato (
    codigo VARCHAR(50) PRIMARY KEY,
    fechaInicio DATE NOT NULL,
    fechaFinalizacion DATE NOT NULL,
    fechaContrato DATE NOT NULL,
    sucursal_codigo VARCHAR(50) NOT NULL,
    FOREIGN KEY (sucursal_codigo) REFERENCES sucursal(codigo)
	ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- Crea la tabla empleado en caso de que no exista
CREATE TABLE IF NOT EXISTS empleado (
    codigo VARCHAR(50) PRIMARY KEY,
    cedula VARCHAR(100) NOT NULL,
    nombreCompleto VARCHAR(100) NOT NULL,
    direccion VARCHAR(100)NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    contrato_codigo VARCHAR(50) UNIQUE NOT NULL,
    codigo_sucursal VARCHAR(50) NOT NULL,
    codigo_cargo varchar(100) NOT NULL,
    FOREIGN KEY (contrato_codigo) REFERENCES contrato(codigo)
     ON DELETE CASCADE
    ON UPDATE CASCADE,
    FOREIGN KEY (codigo_sucursal) REFERENCES sucursal(codigo)
     ON DELETE CASCADE
    ON UPDATE CASCADE,
    FOREIGN KEY (codigo_cargo) REFERENCES cargo(codigo)
     ON DELETE CASCADE
    ON UPDATE CASCADE
);

-- Crea la tabla detalleEmpleadoProfesion en caso de que no exista
CREATE TABLE IF NOT EXISTS detalleEmpleadoProfesion (
    empleado_codigo VARCHAR(50) NOT NULL,
    profesion_codigo VARCHAR(50) NOT NULL,
    PRIMARY KEY (empleado_codigo, profesion_codigo),
    FOREIGN KEY (empleado_codigo) REFERENCES empleado(codigo)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
    FOREIGN KEY (profesion_codigo) REFERENCES profesion(codigo)  
    ON DELETE CASCADE
    ON UPDATE CASCADE
);


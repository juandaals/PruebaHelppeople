



/*
Crear tabla Ciudadanos

*/

CREATE TABLE Ciudadanos (
  id              INT           NOT NULL    IDENTITY    PRIMARY KEY,
  cedula VARCHAR(50) UNIQUE,
  nombre VARCHAR(50) not null,
  apellido VARCHAR(50) NOT NULL,
  correo VARCHAR(100) NOT NULL,
  fechaNacimiento DATETIME NOT NULL,
  profesion VARCHAR(50) NOT NULL,
  aspiracionSalarial INT NOT NULL,
  tipoDocumento INT NOT NULL
);

/*
Crear tabla Vacantes

*/
CREATE TABLE Vacantes (

id INT NOT NULL IDENTITY PRIMARY KEY,
codigo VARCHAR(50) UNIQUE,
cargo VARCHAR(50) NOT NULL,
descripcion VARCHAR(300) NOT NULL,
empresa VARCHAR(50) NOT NULL,
salario INT NOT NULL,
ciudadanoId INT NULL, 
CONSTRAINT FK_Ciudadano_Vacantes FOREIGN KEY (ciudadanoId)
REFERENCES Ciudadanos (id)
ON DELETE CASCADE
ON UPDATE CASCADE
)


/*
Ingresar vacantes 

*/
INSERT into vacantes (codigo, cargo,descripcion,empresa,salario) VALUES (
'RS001', 'Ingeniero Industrial','Se requiere Ingeniero Industrial con mínimo 2 años', 'EPM' ,2500000)

INSERT into vacantes (codigo, cargo,descripcion,empresa,salario) VALUES (
'RS002', 'Profesor de Quimica','Se requiere Quimico con minimo 3 años de experiencia en docencia', 'INSTITUCION EDUCATIVA IES' ,1900000)
INSERT into vacantes (codigo, cargo,descripcion,empresa,salario) VALUES (
'RS003', 'Ingeniero de Desarrollo Junior','Se requiere Ingeniero de Sistemas con minimo 1 año de experiencia en Desarrollo de Software en tecnologia JAVA', 'XRM SERVICES' ,2600000)
INSERT into vacantes (codigo, cargo,descripcion,empresa,salario) VALUES (
'RS004', 'Coordinador de Mercadeo','Se necesita Coordinador de Mercadeo con estudios Tecnológicos graduado y
experiencia mínima de un
año', 'INSERCOL' ,1350000)
INSERT into vacantes (codigo, cargo,descripcion,empresa,salario)  VALUES (
'RS005', 'Profesor de Matemáticas','Se requiere Licenciado en Matemáticas o Ingeniero con
mínimo 2 años de
experiencia en docencia', 'SENA' ,1750000)
INSERT into vacantes (codigo, cargo,descripcion,empresa,salario) VALUES (
'RS006', 'Mensajero','Se requiere mensajero con moto, con documentos al
día y buenas relaciones
personales', 'XRM SERVICES' ,2600000)
INSERT into vacantes (codigo, cargo,descripcion,empresa,salario) VALUES (
'RS007', 'Cajero','Se requiere cajero para almacén de cadena con experiencia mínima de un
año, debe disponer de
tiempo por cambios de
turnos', 'ALMACENES ÉXITO' ,850000)
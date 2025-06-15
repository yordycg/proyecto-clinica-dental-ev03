CREATE DATABASE clinicaDentalDB;
GO -- Forzar la ejecucion del comando anterio.
USE clinicaDentalDB;
GO

CREATE TABLE pacientes (
    run VARCHAR(15) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    -- sexo CHAR NOT NULL CHECK (sexo in ('M', 'F')),
    sexo VARCHAR(50) NOT NULL,
    telefono VARCHAR(15),
    correo VARCHAR(100),
    fecha_registro DATE DEFAULT GETDATE()
);

CREATE TABLE tipos_empleados (
    tipo_id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL UNIQUE -- dentista | secretari@ | auxiliar | administrador
);

CREATE TABLE empleados (
    run VARCHAR(15) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    tipo_empleado_id INT NOT NULL,
    -- sexo CHAR NOT NULL CHECK (sexo in ('M', 'F')),
    sexo VARCHAR(50) NOT NULL,
    telefono VARCHAR(15),
    correo VARCHAR(100),
    fecha_registro DATE DEFAULT GETDATE(),
    FOREIGN KEY (tipo_empleado_id) REFERENCES tipos_empleados (tipo_id)
);

CREATE TABLE usuarios (
    usuario_id INT PRIMARY KEY IDENTITY(1,1),
    empleado_run VARCHAR(15) NOT NULL,
    nombre VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(50) NOT NULL,
    fecha_registro DATE DEFAULT GETDATE(),
    FOREIGN KEY (empleado_run) REFERENCES empleados (run)
);

CREATE TABLE servicios (
    servicio_id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL UNIQUE,
    costo INT NOT NULL CHECK(costo > 0) DEFAULT 0,
    duracion INT NOT NULL --  minutos
);

CREATE TABLE citas (
    cita_id INT PRIMARY KEY IDENTITY(1,1),
    run_paciente VARCHAR(15) NOT NULL,
    dentista_id VARCHAR(15) NOT NULL, -- solo dentista
    estado VARCHAR(50) NOT NULL,
    fecha DATE NOT NULL,
    hora TIME NOT NULL,
    creado_por VARCHAR(15) NOT NULL,  -- secretari@ | dentista | etc.
    FOREIGN KEY (run_paciente) REFERENCES pacientes (run),
    FOREIGN KEY (dentista_id) REFERENCES empleados (run),
    FOREIGN KEY (creado_por) REFERENCES empleados (run)
);

CREATE TABLE detalle_cita ( -- detalle cita?
    detalle_cita_id INT PRIMARY KEY IDENTITY(1,1),
    cita_id INT NOT NULL,
    servicio_id INT NOT NULL,
    FOREIGN KEY (cita_id) REFERENCES citas (cita_id),
    FOREIGN KEY (servicio_id) REFERENCES servicios (servicio_id)
);

-- CREATE TABLE estado_cita (
--     estado_id INT PRIMARY KEY IDENTITY(1,1),
--     nombre VARCHAR(50) NOT NULL -- Programada | Confirmada | Completada | Cancelada | Reprogramada.
-- );

CREATE TABLE pagos (
    pago_id INT PRIMARY KEY IDENTITY(1,1),
    cita_id INT NOT NULL,
    monto INT NOT NULL CHECK(monto > 0),
    fecha DATETIME NOT NULL,
    metodo_pago VARCHAR(50) NOT NULL CHECK(metodo_pago IN ('Efectivo', 'Tarjeta de Credito', 'Transferencia')),
    estado_pago VARCHAR(50) NOT NULL CHECK(estado_pago IN ('Pagado', 'Pendiente', 'Reembolso')),
    FOREIGN KEY (cita_id) REFERENCES citas (cita_id)
);

-- Insertar datos iniciales...
INSERT INTO tipos_empleados VALUES
('Dentista'),
('Auxiliar'),
('Secretari@'),
('Admin');

-- SQL query.
SELECT * FROM empleados;
SELECT * FROM usuarios;
SELECT * FROM pacientes;
SELECT * FROM citas;
SELECT * FROM detalle_cita;
SELECT * FROM servicios;
SELECT * FROM tipos_empleados;

-- Empleados del tipo 'Dentista'.
SELECT * FROM empleados e
INNER JOIN tipos_empleados te ON e.tipo_empleado_id = te.tipo_id
WHERE te.nombre = 'Dentista';

-- Empleados sin un usuario creado.
SELECT * FROM empleados e
LEFT JOIN usuarios u ON e.run = u.empleado_run
WHERE u.usuario_id IS NULL;

-- Modificar columna 'sexo' en empleados.
-- Verificar que el constraint existe
IF EXISTS (SELECT *
           FROM INFORMATION_SCHEMA.CHECK_CONSTRAINTS
           WHERE CONSTRAINT_NAME = 'CK__pacientes__sexo__37A5467C')
    BEGIN
        ALTER TABLE pacientes
            DROP CONSTRAINT CK__pacientes__sexo__37A5467C;
        PRINT 'Constraint eliminado correctamente';
    END

-- Cambiar tipo de columna
ALTER TABLE pacientes
    ALTER COLUMN sexo VARCHAR(50) NOT NULL;
PRINT 'Columna modificada a VARCHAR(50)';

UPDATE pacientes SET sexo = 'Masculino'
WHERE sexo = 'M';

UPDATE pacientes SET sexo = 'Femenino'
WHERE sexo = 'F';

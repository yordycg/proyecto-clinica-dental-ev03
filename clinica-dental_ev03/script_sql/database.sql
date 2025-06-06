CREATE DATABASE clinicaDentalDB;
USE clinicaDentalDB;

CREATE TABLE pacientes (
    rut VARCHAR(15) PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    sexo CHAR NOT NULL CHECK (sexo in ('M', 'F')),
    telefono VARCHAR(15),
    correo VARCHAR(100),
    fecha_registro DATE DEFAULT GETDATE()
);

CREATE TABLE dentistas (
    dentista_id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    telefono VARCHAR(15),
    correo VARCHAR(100),
    fecha_registro DATE DEFAULT GETDATE()
);

CREATE TABLE servicios (
    servicio_id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL UNIQUE,
    costo INT NOT NULL CHECK(costo > 0) DEFAULT 0,
    duracion TIME NOT NULL
);

CREATE TABLE estado_cita (
    estado_id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL -- Programada | Confirmada | Completada | Cancelada | Reprogramada.
);

CREATE TABLE citas (
    cita_id INT PRIMARY KEY IDENTITY(1,1),
    rut_paciente VARCHAR(15) NOT NULL,
    dentista_id INT NOT NULL,
    estado_id INT NOT NULL,
    fecha DATE NOT NULL,
    hora TIME NOT NULL,
    FOREIGN KEY (rut_paciente) REFERENCES pacientes (rut),
    FOREIGN KEY (dentista_id) REFERENCES dentistas (dentista_id),
    FOREIGN KEY (estado_id) REFERENCES estado_cita (estado_id)
);

CREATE TABLE cita_servicio (
    cita_servicio_id INT PRIMARY KEY IDENTITY(1,1),
    cita_id INT NOT NULL,
    servicio_id INT NOT NULL,
    FOREIGN KEY (cita_id) REFERENCES citas (cita_id),
    FOREIGN KEY (servicio_id) REFERENCES servicios (servicio_id)
);

CREATE TABLE pagos (
    pago_id INT PRIMARY KEY IDENTITY(1,1),
    cita_id INT NOT NULL,
    monto INT NOT NULL CHECK(monto > 0),
    fecha DATETIME NOT NULL,
    metodo_pago VARCHAR(50) NOT NULL CHECK(metodo_pago IN ('Efectivo', 'Tarjeta de Credito', 'Transferencia')),
    estado_pago VARCHAR(50) NOT NULL CHECK(estado_pago IN ('Pagado', 'Pendiente', 'Reembolso')),
    FOREIGN KEY (cita_id) REFERENCES citas (cita_id)
);



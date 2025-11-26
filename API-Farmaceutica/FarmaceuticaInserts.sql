-- 1) TIPOS_DOCUMENTOS (15)
INSERT INTO tipos_documentos (descripcion) VALUES ('DNI');
INSERT INTO tipos_documentos (descripcion) VALUES ('CUIL');
INSERT INTO tipos_documentos (descripcion) VALUES ('LC');
INSERT INTO tipos_documentos (descripcion) VALUES ('LE');
INSERT INTO tipos_documentos (descripcion) VALUES ('Pasaporte');
INSERT INTO tipos_documentos (descripcion) VALUES ('CI');
INSERT INTO tipos_documentos (descripcion) VALUES ('Documento Extranjero');
INSERT INTO tipos_documentos (descripcion) VALUES ('Tarjeta de Identidad');
INSERT INTO tipos_documentos (descripcion) VALUES ('Certificado de Nacimiento');
INSERT INTO tipos_documentos (descripcion) VALUES ('DNI Extranjero');
INSERT INTO tipos_documentos (descripcion) VALUES ('Carnet de Conducir');
INSERT INTO tipos_documentos (descripcion) VALUES ('Permiso de Residencia');
INSERT INTO tipos_documentos (descripcion) VALUES ('Identidad Militar');
INSERT INTO tipos_documentos (descripcion) VALUES ('Identidad Policial');
INSERT INTO tipos_documentos (descripcion) VALUES ('Otro');

-- 2) PAISES (15)
INSERT INTO paises (descripciones) VALUES ('Argentina');
INSERT INTO paises (descripciones) VALUES ('Uruguay');
INSERT INTO paises (descripciones) VALUES ('Chile');
INSERT INTO paises (descripciones) VALUES ('Brasil');
INSERT INTO paises (descripciones) VALUES ('Paraguay');
INSERT INTO paises (descripciones) VALUES ('Bolivia');
INSERT INTO paises (descripciones) VALUES ('Perú');
INSERT INTO paises (descripciones) VALUES ('Ecuador');
INSERT INTO paises (descripciones) VALUES ('Colombia');
INSERT INTO paises (descripciones) VALUES ('Venezuela');
INSERT INTO paises (descripciones) VALUES ('México');
INSERT INTO paises (descripciones) VALUES ('España');
INSERT INTO paises (descripciones) VALUES ('Estados Unidos');
INSERT INTO paises (descripciones) VALUES ('Canadá');
INSERT INTO paises (descripciones) VALUES ('Italia');

-- 3) PROVINCIAS (15)
INSERT INTO provincias (paisid, descripcion) VALUES (1,'Buenos Aires');
INSERT INTO provincias (paisid, descripcion) VALUES (2,'Montevideo');
INSERT INTO provincias (paisid, descripcion) VALUES (3,'Santiago');
INSERT INTO provincias (paisid, descripcion) VALUES (4,'São Paulo');
INSERT INTO provincias (paisid, descripcion) VALUES (5,'Asunción');
INSERT INTO provincias (paisid, descripcion) VALUES (6,'La Paz');
INSERT INTO provincias (paisid, descripcion) VALUES (7,'Lima');
INSERT INTO provincias (paisid, descripcion) VALUES (8,'Quito');
INSERT INTO provincias (paisid, descripcion) VALUES (9,'Bogotá');
INSERT INTO provincias (paisid, descripcion) VALUES (10,'Caracas');
INSERT INTO provincias (paisid, descripcion) VALUES (11,'Ciudad de México');
INSERT INTO provincias (paisid, descripcion) VALUES (12,'Madrid');
INSERT INTO provincias (paisid, descripcion) VALUES (13,'Nueva York');
INSERT INTO provincias (paisid, descripcion) VALUES (14,'Ontario');
INSERT INTO provincias (paisid, descripcion) VALUES (15,'Lombardía');

-- 4) LOCALIDADES (15)
INSERT INTO localidades (descripcion, provinciaid) VALUES ('La Plata',1);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Ciudad Vieja',2);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Providencia',3);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Campinas',4);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Lambaré',5);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('El Alto',6);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Miraflores',7);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Quito Centro',8);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Chapinero',9);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Caracas Este',10);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Coyoacán',11);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Centro',12);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Manhattan',13);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Toronto Downtown',14);
INSERT INTO localidades (descripcion, provinciaid) VALUES ('Milán Centro',15);

-- 5) TIPOS_PRESENTACIONES (15)
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Caja');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Frasco');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Blister');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Jarabe');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Inyectable');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Ampolla');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Sobre');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Tubo');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Spray');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Gotas');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Crema');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Ungüento');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Tableta');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Solución');
INSERT INTO tipos_presentaciones (descripcion) VALUES ('Bolsa');

-- 6) UNIDADES_MEDIDAS (15)
INSERT INTO unidades_medidas (descripcion) VALUES ('Unidad');
INSERT INTO unidades_medidas (descripcion) VALUES ('Caja');
INSERT INTO unidades_medidas (descripcion) VALUES ('ml');
INSERT INTO unidades_medidas (descripcion) VALUES ('mg');
INSERT INTO unidades_medidas (descripcion) VALUES ('g');
INSERT INTO unidades_medidas (descripcion) VALUES ('IU');
INSERT INTO unidades_medidas (descripcion) VALUES ('Sobre');
INSERT INTO unidades_medidas (descripcion) VALUES ('Paquete');
INSERT INTO unidades_medidas (descripcion) VALUES ('Ampolla');
INSERT INTO unidades_medidas (descripcion) VALUES ('Litro');
INSERT INTO unidades_medidas (descripcion) VALUES ('Kilo');
INSERT INTO unidades_medidas (descripcion) VALUES ('Gramo');
INSERT INTO unidades_medidas (descripcion) VALUES ('Mililitro');
INSERT INTO unidades_medidas (descripcion) VALUES ('Miligramos por ml');
INSERT INTO unidades_medidas (descripcion) VALUES ('Miliequivalentes');

-- 7) TIPOS_SUMINISTROS (15)
INSERT INTO tipos_suministros (descripcion) VALUES ('Medicamento');
INSERT INTO tipos_suministros (descripcion) VALUES ('Insumo Médico');
INSERT INTO tipos_suministros (descripcion) VALUES ('Cosmético');
INSERT INTO tipos_suministros (descripcion) VALUES ('Dispositivo Médico');
INSERT INTO tipos_suministros (descripcion) VALUES ('Vitamina');
INSERT INTO tipos_suministros (descripcion) VALUES ('Suplemento');
INSERT INTO tipos_suministros (descripcion) VALUES ('Vacuna');
INSERT INTO tipos_suministros (descripcion) VALUES ('Material Quirúrgico');
INSERT INTO tipos_suministros (descripcion) VALUES ('Herbal');
INSERT INTO tipos_suministros (descripcion) VALUES ('Higiene');
INSERT INTO tipos_suministros (descripcion) VALUES ('Nutricional');
INSERT INTO tipos_suministros (descripcion) VALUES ('Desinfectante');
INSERT INTO tipos_suministros (descripcion) VALUES ('Equipo');
INSERT INTO tipos_suministros (descripcion) VALUES ('Reactivo');
INSERT INTO tipos_suministros (descripcion) VALUES ('Otro');

-- 8) CLASIFICACIONES_SUMINISTROS (15)
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Antibiótico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Analgésico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Antiinflamatorio');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Antihistamínico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Cardiológico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Endocrino');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Dermatológico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Gastrointestinal');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Neurológico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Respiratorio');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Pediátrico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Ginecológico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Oftálmico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Otorrinolaringológico');
INSERT INTO clasificaciones_suministros (descripcion) VALUES ('Oncológico');

-- 9) RESTRICCIONES (15)
INSERT INTO restricciones (descripcion) VALUES ('Venta libre');
INSERT INTO restricciones (descripcion) VALUES ('Venta con receta');
INSERT INTO restricciones (descripcion) VALUES ('Controlada - prescripción especial');
INSERT INTO restricciones (descripcion) VALUES ('Venta sólo a profesionales');
INSERT INTO restricciones (descripcion) VALUES ('Requiere autorización');
INSERT INTO restricciones (descripcion) VALUES ('Uso hospitalario');
INSERT INTO restricciones (descripcion) VALUES ('Prohibido menor de 18');
INSERT INTO restricciones (descripcion) VALUES ('Venta con receta archivada');
INSERT INTO restricciones (descripcion) VALUES ('Conservación en frío');
INSERT INTO restricciones (descripcion) VALUES ('Manipulación especial');
INSERT INTO restricciones (descripcion) VALUES ('Dosis controlada');
INSERT INTO restricciones (descripcion) VALUES ('Receta magistral');
INSERT INTO restricciones (descripcion) VALUES ('Sujeto a registro');
INSERT INTO restricciones (descripcion) VALUES ('Venta restringida por lote');
INSERT INTO restricciones (descripcion) VALUES ('Sin restricciones adicionales');

-- 10) TIPOS_DESCUENTOS (15)
INSERT INTO tipos_descuentos (descripcion) VALUES ('Porcentaje por obra social');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Monto fijo');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Promoción 2x1');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento por volumen');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento por temporada');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento por fidelidad');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento por estudiante');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento por jubilado');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento corporativo');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Con cupon');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento bancario');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento por primer compra');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento por referencia');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Promoción combo');
INSERT INTO tipos_descuentos (descripcion) VALUES ('Descuento especial');

-- 11) METODOS_PAGOS (15)
INSERT INTO metodos_pagos (descripcion) VALUES ('Efectivo');
INSERT INTO metodos_pagos (descripcion) VALUES ('Tarjeta de crédito');
INSERT INTO metodos_pagos (descripcion) VALUES ('Tarjeta de débito');
INSERT INTO metodos_pagos (descripcion) VALUES ('Transferencia bancaria');
INSERT INTO metodos_pagos (descripcion) VALUES ('MercadoPago');
INSERT INTO metodos_pagos (descripcion) VALUES ('Cheque');
INSERT INTO metodos_pagos (descripcion) VALUES ('Pago móvil');
INSERT INTO metodos_pagos (descripcion) VALUES ('A cuenta');
INSERT INTO metodos_pagos (descripcion) VALUES ('Contra reembolso');
INSERT INTO metodos_pagos (descripcion) VALUES ('Gift Card');
INSERT INTO metodos_pagos (descripcion) VALUES ('Débito automático');
INSERT INTO metodos_pagos (descripcion) VALUES ('Apple Pay');
INSERT INTO metodos_pagos (descripcion) VALUES ('Google Pay');
INSERT INTO metodos_pagos (descripcion) VALUES ('Pago en cuotas');
INSERT INTO metodos_pagos (descripcion) VALUES ('Pago parcial');

-- 12) ESPECIALIDADES_MEDICOS (15)
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Cardiología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Endocrinología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Dermatología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Pediatría');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Ginecología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Neurología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Gastroenterología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Oftalmología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Psiquiatría');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Traumatología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Oncología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Otorrinolaringología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Urología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Neumonología');
INSERT INTO especialidades_medicos (nombre_especialidad) VALUES ('Medicina General');

-- 13) OBRAS_SOCIALES (15)
INSERT INTO obras_sociales (descripcion) VALUES ('OSDE');
INSERT INTO obras_sociales (descripcion) VALUES ('PAMI');
INSERT INTO obras_sociales (descripcion) VALUES ('Swiss Medical');
INSERT INTO obras_sociales (descripcion) VALUES ('Galeno');
INSERT INTO obras_sociales (descripcion) VALUES ('OMINT');
INSERT INTO obras_sociales (descripcion) VALUES ('Medicus');
INSERT INTO obras_sociales (descripcion) VALUES ('Sancor Salud');
INSERT INTO obras_sociales (descripcion) VALUES ('Federada Salud');
INSERT INTO obras_sociales (descripcion) VALUES ('Ateneo');
INSERT INTO obras_sociales (descripcion) VALUES ('OSDEPY');
INSERT INTO obras_sociales (descripcion) VALUES ('Nación Salud');
INSERT INTO obras_sociales (descripcion) VALUES ('SwissCare');
INSERT INTO obras_sociales (descripcion) VALUES ('Hospital Privado Plan');
INSERT INTO obras_sociales (descripcion) VALUES ('Obra Social Municipal');
INSERT INTO obras_sociales (descripcion) VALUES ('Obra Social Regional');

-- 14) PLANES_OBRAS_SOCIALES (15)
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('OSDE Médico Integral',1);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('PAMI Básico',2);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Swiss Premium',3);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Galeno Plan I',4);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('OMINT Plus',5);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Medicus Básico',6);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Sancor Familiar',7);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Federada Select',8);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Ateneo Plan',9);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('OSDEPY Plus',10);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Nación Salud Plan',11);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('SwissCare Familiar',12);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Hospital Privado VIP',13);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Municipal Plus',14);
INSERT INTO planes_obras_sociales (descripcion, obra_socialid) VALUES ('Regional Básico',15);

-- 15) PROVEEDORES (15)
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Laboratorios Argentinos S.A.','30-12345678-1','Av. Siempre Viva 100','+54 11 4000-0001','ventas@labarg.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Distribuidora Farma SRL','30-87654321-2','Calle Falsa 200','+54 11 4000-0002','contacto@distfarma.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Insumos Médicos SA','30-11223344-3','Rivadavia 300','+54 11 4000-0003','info@insumosmed.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Cosméticos del Plata','30-55667788-4','Florida 400','+54 11 4000-0004','ventas@cosplat.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Vacunas Globales','30-99887766-5','Av. Norte 500','+54 11 4000-0005','vacunas@global.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Equipos Médicos SA','30-22334455-6','Industrial 600','+54 11 4000-0006','equipos@medicos.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Herbolario Natural','30-66778899-7','Río 700','+54 11 4000-0007','pedidos@herbal.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Suministros Quirúrgicos','30-33445566-8','Salud 800','+54 11 4000-0008','suministros@quirurg.com',FALSE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Distribuciones Norte','30-44556677-9','Norte 900','+54 11 4000-0009','norte@dist.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Farmacia Mayorista','30-55664433-0','Mercado 1000','+54 11 4000-0010','mayorista@farma.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Logística Pharma','30-66775544-1','Logística 1100','+54 11 4000-0011','logistica@pharma.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Laboratorio Central','30-77886655-2','Centro 1200','+54 11 4000-0012','central@lab.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Proveedora Sur','30-88997766-3','Sur 1300','+54 11 4000-0013','sur@provee.com',FALSE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Insumos Dentales','30-99008877-4','Odontología 1400','+54 11 4000-0014','dental@insumos.com',TRUE);
INSERT INTO proveedores (razonsocial, cuit, direccionproveedor, telefonoproveedor, emailproveedor, activo) VALUES ('Productos Hospitalarios','30-10101010-5','Hospital 1500','+54 11 4000-0015','hospital@prod.com',TRUE);

-- 16) REPARTIDORES (15)
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Juan','Pérez','+54 9 11 5555-0001','juan.perez@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('María','González','+54 9 11 5555-0002','maria.gonzalez@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Carlos','Rodríguez','+54 9 11 5555-0003','carlos.rodriguez@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Luisa','Martínez','+54 9 11 5555-0004','luisa.martinez@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Diego','Fernández','+54 9 11 5555-0005','diego.fernandez@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Sofía','López','+54 9 11 5555-0006','sofia.lopez@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Martín','Gómez','+54 9 11 5555-0007','martin.gomez@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Carolina','Ruiz','+54 9 11 5555-0008','carolina.ruiz@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Federico','Sosa','+54 9 11 5555-0009','federico.sosa@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Paula','Vega','+54 9 11 5555-0010','paula.vega@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Gustavo','Ibarra','+54 9 11 5555-0011','gustavo.ibarra@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Valeria','Alonso','+54 9 11 5555-0012','valeria.alonso@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Sergio','Castro','+54 9 11 5555-0013','sergio.castro@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Natalia','Ramos','+54 9 11 5555-0014','natalia.ramos@reparto.com');
INSERT INTO repartidores (nombrerepartidor, apellidorepartidor, telefonorepartidor, emailrepartidor) VALUES ('Emilio','Torres','+54 9 11 5555-0015','emilio.torres@reparto.com');

-- 17) SUCURSALES (15)
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Centro','Av. Central 123',1);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Ciudad Vieja','Calle Principal 45',2);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Providencia','Av. Providencia 10',3);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Campinas','Rua das Flores 200',4);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Asunción','Calle 5 de Mayo 77',5);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal El Alto','Av. Bolivia 500',6);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Miraflores','Av. Larco 120',7);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Quito','Av. Amazonas 88',8);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Bogotá','Calle 85 35',9);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Caracas','Av. Libertador 101',10);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Coyoacán','Insurgentes 200',11);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Madrid Centro','Gran Vía 25',12);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Manhattan','5th Ave 350',13);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Toronto','King St 75',14);
INSERT INTO sucursales (descripcion, direccion, localidadid) VALUES ('Sucursal Milán','Via Dante 2',15);

-- 18) PRODUCTOS (15)
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000001','Termómetro Digital',1200.00,13,15,1,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000002','Jeringa 5ml',45.00,8,15,9,11,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000003','Guantes Nitrilo',350.00,8,15,8,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000004','Mascarilla Quirúrgica',80.00,8,15,8,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000005','Termo para suero',2000.00,13,15,1,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000006','Bata descartable',150.00,8,15,8,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000007','Alcohol en gel 500ml',380.00,12,15,3,2,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000008','Termómetro infrarrojo',5500.00,13,15,1,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000009','Sonda nasogástrica',900.00,8,15,8,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000010','Esfigmomanómetro',3200.00,13,15,1,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000011','Termómetro de mercurio',800.00,13,15,1,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000012','Pañales adultos',950.00,11,15,8,13,FALSE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000013','Sueros isotónicos 500ml',420.00,13,15,10,14,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000014','Aspirina 500mg',70.00,1,2,4,13,TRUE);
INSERT INTO productos (codigo_barra_productoid, nombre_producto, precio_producto, tipo_suministroid, clasificacion_suministroid, unidad_medidaid, tipo_presentacionid, activo) VALUES ('P000000015','Venda elástica',120.00,8,15,8,13,FALSE);

-- 19) MEDICAMENTOS (15)
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000001','Amoxicilina 500mg',350.00,4,13,1,1,2,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000002','Ibuprofeno 600mg',120.00,4,13,3,1,1,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000003','Loratadina 10mg',250.00,4,13,4,1,1,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000004','Metformina 850mg',180.00,4,13,6,1,1,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000005','Omeprazol 20mg',210.00,4,13,8,1,1,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000006','Prednisona 20mg',300.00,4,13,3,1,2,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000007','Vacuna Influenza 2025',1200.00,10,2,7,7,9,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000008','Crema Dermática 30g',480.00,5,11,6,1,6,FALSE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000009','Salbutamol inhalador',950.00,1,13,10,1,2,FALSE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000010','Paracetamol 500mg',60.00,4,13,2,1,1,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000011','Enalapril 10mg',340.00,4,13,5,1,2,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000012','Vitamina D 1000IU',220.00,6,13,5,5,1,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000013','Insulina NPH 100U',1800.00,6,2,6,1,2,TRUE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000014','Crema Antifúngica 20g',260.00,5,11,6,1,6,FALSE);
INSERT INTO medicamentos (codigo_barra_medicamentoid, nombre_medicamento, precio_medicamento, unidad_medidaid, tipo_presentacionid, clasificacion_suministroid, tipo_suministroid, restriccionid, activo) VALUES ('M000000015','Antibiótico tópico',310.00,5,11,1,1,2,TRUE);

-- 20) LOTES_PRODUCTOS (15)
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2026-06-30 00:00:00','2025-01-01 00:00:00',100,1);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2027-03-15 00:00:00','2025-02-01 00:00:00',500,2);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2026-11-10 00:00:00','2025-03-01 00:00:00',200,3);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2028-01-01 00:00:00','2025-04-01 00:00:00',300,4);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2029-12-31 00:00:00','2025-05-01 00:00:00',50,5);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2026-07-20 00:00:00','2025-02-15 00:00:00',150,6);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2025-11-30 00:00:00','2024-11-01 00:00:00',600,7);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2027-08-05 00:00:00','2025-03-15 00:00:00',80,8);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2026-05-10 00:00:00','2025-01-25 00:00:00',250,9);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2026-10-10 00:00:00','2025-02-28 00:00:00',120,10);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2026-04-01 00:00:00','2025-01-10 00:00:00',75,11);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2025-09-15 00:00:00','2024-12-01 00:00:00',400,12);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2027-02-28 00:00:00','2025-04-10 00:00:00',90,13);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2026-12-12 00:00:00','2025-03-05 00:00:00',220,14);
INSERT INTO lotes_productos (fecha_vencimiento, fecha_elaboracion, cantidad, productoid) VALUES ('2028-06-06 00:00:00','2025-05-20 00:00:00',130,15);

-- 21) LOTES_MEDICAMENTOS (15)
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (1,'2026-01-01 00:00:00','2024-12-01 00:00:00',200);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (2,'2025-08-15 00:00:00','2024-08-01 00:00:00',500);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (3,'2027-05-10 00:00:00','2025-01-10 00:00:00',300);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (4,'2026-09-30 00:00:00','2025-02-20 00:00:00',250);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (5,'2028-03-31 00:00:00','2025-03-01 00:00:00',180);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (6,'2025-12-31 00:00:00','2024-11-15 00:00:00',220);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (7,'2026-04-01 00:00:00','2025-02-01 00:00:00',150);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (8,'2027-07-07 00:00:00','2025-03-15 00:00:00',90);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (9,'2026-02-20 00:00:00','2024-12-20 00:00:00',130);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (10,'2025-11-11 00:00:00','2024-11-11 00:00:00',700);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (11,'2027-10-10 00:00:00','2025-04-01 00:00:00',95);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (12,'2026-06-06 00:00:00','2025-01-05 00:00:00',260);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (13,'2025-09-09 00:00:00','2024-10-10 00:00:00',110);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (14,'2026-08-08 00:00:00','2025-02-12 00:00:00',175);
INSERT INTO lotes_medicamentos (medicamentoid, fecha_vencimiento, fecha_elaboracion, cantidad) VALUES (15,'2027-01-01 00:00:00','2025-03-03 00:00:00',85);

-- 22) CLIENTES (15)
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Lucas','Martínez','1985-05-12','+54 9 11 6000-0001',1,'Calle 1 #100',1,'lucas.martinez@example.com','12345678');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('María','Gómez','1990-03-02','+54 9 11 6000-0002',2,'Calle 2 #200',2,'maria.gomez@example.com','20-12345678-2');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Pedro','López','1975-07-22','+54 9 11 6000-0003',3,'Calle 3 #300',3,'pedro.lopez@example.com','A1234567');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Ana','Fernández','1988-11-11','+54 9 11 6000-0004',4,'Av. Libertad 400',4,'ana.fernandez@example.com','B7654321');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Diego','Sánchez','2000-01-05','+54 9 11 6000-0005',5,'Boulevard 500',5,'diego.sanchez@example.com','P1234567');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Lucía','Torres','1995-12-30','+54 9 11 6000-0006',6,'Pasaje 6 #6',6,'lucia.torres@example.com','C9876543');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Matías','Romero','1982-09-09','+54 9 11 6000-0007',7,'Av. 7 #700',7,'matias.romero@example.com','D2345678');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Sofía','Vargas','1979-06-18','+54 9 11 6000-0008',8,'Calle 8 #80',8,'sofia.vargas@example.com','E3456789');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Hernán','Pérez','1968-04-04','+54 9 11 6000-0009',9,'Av. 9 #900',9,'hernan.perez@example.com','F4567890');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Carla','Rossi','1992-02-20','+54 9 11 6000-0010',10,'Rua 10 10',10,'carla.rossi@example.com','G5678901');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Andrés','Morales','1987-08-08','+54 9 11 6000-0011',11,'Col. 11 #11',11,'andres.morales@example.com','H6789012');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Julia','Núñez','1998-10-10','+54 9 11 6000-0012',12,'C/12 12',12,'julia.nunez@example.com','I7890123');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Sergio','Giménez','1970-07-07','+54 9 11 6000-0013',13,'St. 13 13',13,'sergio.gimenez@example.com','J8901234');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Valentina','Herrera','2002-05-05','+54 9 11 6000-0014',14,'Str. 14 14',14,'valentina.herrera@example.com','K9012345');
INSERT INTO clientes (nombrecliente, apellidocliente, fecha_nacimiento_cliente, telefonocliente, tipo_documentoid, direccioncliente, localidadid, emailcliente, documentocliente) VALUES ('Raúl','Ibáñez','1960-03-03','+54 9 11 6000-0015',15,'Via 15 15',15,'raul.ibanez@example.com','L0123456');

-- 23) EMPLEADOS (15)
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Marcos','Alvarez','1980-01-20','Av. Empleado 1', '+54 9 11 7000-0001','marcos.alvarez@empresa.com',1,1,'20123456');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Silvia','Castro','1985-02-14','Calle Empleado 2', '+54 9 11 7000-0002','silvia.castro@empresa.com',2,2,'20-22334455-2');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Hugo','Benítez','1974-03-30','Calle Empleado 3', '+54 9 11 7000-0003','hugo.benitez@empresa.com',3,3,'C3344556');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Natalia','Duarte','1991-04-25','Av. Empleado 4', '+54 9 11 7000-0004','natalia.duarte@empresa.com',4,4,'D4455667');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Ezequiel','Muñoz','1989-06-18','Calle Empleado 5', '+54 9 11 7000-0005','ezequiel.munoz@empresa.com',5,5,'E5566778');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Belén','Paz','1993-07-07','Calle Empleado 6', '+54 9 11 7000-0006','belen.paz@empresa.com',6,6,'F6677889');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Rodrigo','Suárez','1978-08-08','Av. Empleado 7', '+54 9 11 7000-0007','rodrigo.suarez@empresa.com',7,7,'G7788990');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Marta','Cárdenas','1983-09-09','Calle Empleado 8', '+54 9 11 7000-0008','marta.cardenas@empresa.com',8,8,'H8899001');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Ignacio','Arias','1996-10-10','Av. Empleado 9', '+54 9 11 7000-0009','ignacio.arias@empresa.com',9,9,'I9900112');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Patricia','Molina','1976-11-11','Calle Empleado 10', '+54 9 11 7000-0010','patricia.molina@empresa.com',10,10,'J0011223');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Fabián','Sánchez','1981-12-12','Av. Empleado 11', '+54 9 11 7000-0011','fabian.sanchez@empresa.com',11,11,'K1122334');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Carolina','Ortiz','1994-01-01','Calle Empleado 12', '+54 9 11 7000-0012','carolina.ortiz@empresa.com',12,12,'L2233445');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Alberto','Suárez','1972-02-02','Av. Empleado 13', '+54 9 11 7000-0013','alberto.suarez@empresa.com',13,13,'M3344556');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Verónica','Cruz','1986-03-03','Calle Empleado 14', '+54 9 11 7000-0014','veronica.cruz@empresa.com',14,14,'N4455667');
INSERT INTO empleados (nombreempleado, apellidoempleado, fecha_nacimiento_empleado, direccionempleado, telefonoempleado, emailempleado, localidadid, tipo_documentoid, documentoempleado) VALUES ('Horacio','Méndez','1965-04-04','Av. Empleado 15', '+54 9 11 7000-0015','horacio.mendez@empresa.com',15,15,'O5566778');

-- 24) AFILIADOS (15)
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (1,1);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (2,2);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (3,3);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (4,4);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (5,5);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (6,6);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (7,7);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (8,8);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (9,9);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (10,10);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (11,11);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (12,12);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (13,13);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (14,14);
INSERT INTO afiliados (plan_obra_socialid, clienteid) VALUES (15,15);

-- 25) DOCTORES (15)
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Alejandro','Marín','MAT-1001',1);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Patricia','Salas','MAT-1002',2);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Ricardo','Vila','MAT-1003',3);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Beatriz','Luna','MAT-1004',4);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Marcelo','Ibáñez','MAT-1005',5);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Silvana','Rey','MAT-1006',6);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Germán','Quiroga','MAT-1007',7);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Lorena','Cano','MAT-1008',8);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Félix','Morán','MAT-1009',9);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Irene','Polo','MAT-1010',10);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Óscar','Díaz','MAT-1011',11);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Mónica','Roldán','MAT-1012',12);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Bruno','León','MAT-1013',13);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Daniela','Serrano','MAT-1014',14);
INSERT INTO doctores (nombre_doctor, apellido_doctor, matricula_doctor, especialidadid) VALUES ('Esteban','Navarro','MAT-1015',15);

-- 26) RECETAS (15)
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-01 10:00:00',1,1);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-02 11:30:00',2,2);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-03 09:15:00',3,3);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-04 14:00:00',4,4);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-05 16:45:00',5,5);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-06 08:20:00',6,6);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-07 13:00:00',7,7);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-08 15:30:00',8,8);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-09 10:10:00',9,9);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-10 12:00:00',10,10);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-11 09:40:00',11,11);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-12 17:20:00',12,12);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-13 11:05:00',13,13);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-14 14:50:00',14,14);
INSERT INTO recetas (fecha, afiliadoid, doctorid) VALUES ('2025-06-15 08:00:00',15,15);

-- 27) ESTADOS_COBERTURAS (15)
INSERT INTO estados_coberturas (descripcion) VALUES ('Pendiente');
INSERT INTO estados_coberturas (descripcion) VALUES ('Aprobado');
INSERT INTO estados_coberturas (descripcion) VALUES ('Rechazado');
INSERT INTO estados_coberturas (descripcion) VALUES ('En revisión');
INSERT INTO estados_coberturas (descripcion) VALUES ('Completado');
INSERT INTO estados_coberturas (descripcion) VALUES ('Parcial');
INSERT INTO estados_coberturas (descripcion) VALUES ('Sin validar');
INSERT INTO estados_coberturas (descripcion) VALUES ('Validado');
INSERT INTO estados_coberturas (descripcion) VALUES ('Observado');
INSERT INTO estados_coberturas (descripcion) VALUES ('Cancelado');
INSERT INTO estados_coberturas (descripcion) VALUES ('Requerido trámite');
INSERT INTO estados_coberturas (descripcion) VALUES ('A la espera de documentación');
INSERT INTO estados_coberturas (descripcion) VALUES ('Procesado');
INSERT INTO estados_coberturas (descripcion) VALUES ('Aplicado');
INSERT INTO estados_coberturas (descripcion) VALUES ('No corresponde');

-- 28) COBERTURAS (15)
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,1,1,1);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (FALSE,2,2,2);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,3,3,3);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (FALSE,4,4,4);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,5,5,5);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (FALSE,6,6,6);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,7,7,7);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (FALSE,8,8,8);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,9,9,9);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (FALSE,10,10,10);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,11,11,11);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (FALSE,12,12,12);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,13,13,13);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (FALSE,14,14,14);
INSERT INTO coberturas (validacion_obra_social, estado_coberturaid, afiliadoid, recetaid) VALUES (TRUE,15,15,15);

-- 29) DETALLES_RECETAS (15)
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (1,20,1);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (2,10,2);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (3,6,3);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (4,30,4);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (5,14,5);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (6,28,6);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (7,1,7);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (8,2,8);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (9,3,9);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (10,12,10);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (11,7,11);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (12,4,12);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (13,2,13);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (14,5,14);
INSERT INTO detalles_recetas (recetaid, cantidad, medicamentoid) VALUES (15,8,15);

-- 30) DESCUENTOS (15)
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (1,'2025-06-01 00:00:00',1,1,10.00,1);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (2,'2025-06-05 00:00:00',2,2,5.00,2);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (3,'2025-06-10 00:00:00',3,3,20.00,3);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (4,'2025-07-01 00:00:00',4,4,15.00,4);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (5,'2025-07-15 00:00:00',5,5,12.50,5);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (6,'2025-08-01 00:00:00',6,6,8.00,6);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (7,'2025-08-15 00:00:00',7,7,18.00,7);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (8,'2025-09-01 00:00:00',8,8,7.50,8);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (9,'2025-09-10 00:00:00',9,9,25.00,9);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (10,'2025-10-01 00:00:00',10,10,30.00,10);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (11,'2025-10-15 00:00:00',11,11,6.00,11);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (12,'2025-11-01 00:00:00',12,12,9.00,12);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (13,'2025-11-10 00:00:00',13,13,11.00,13);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (14,'2025-12-01 00:00:00',14,14,14.00,14);
INSERT INTO descuentos (localidadid, fecha_descuento, tipo_suministroid, obra_socialid, porcentaje_descuento, tipo_descuentoid) VALUES (15,'2025-12-15 00:00:00',15,15,5.50,15);

-- 31) FACTURAS (15)
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-01 10:05:00',1,1,1,1);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-02 11:35:00',2,2,2,2);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-03 09:20:00',3,3,3,3);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-04 14:10:00',4,4,4,4);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-05 16:50:00',5,5,5,5);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-06 08:25:00',6,6,6,6);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-07 13:05:00',7,7,7,7);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-08 15:35:00',8,8,8,8);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-09 10:15:00',9,9,9,9);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-10 12:05:00',10,10,10,10);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-11 09:45:00',11,11,11,11);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-12 17:25:00',12,12,12,12);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-13 11:10:00',13,13,13,13);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-14 14:55:00',14,14,14,14);
INSERT INTO facturas (fecha_facturacion, empleadoid, clienteid, sucursalid, metodo_pagoid) VALUES ('2025-06-15 08:05:00',15,15,15,15);

-- 32) DETALLES_FACTURAS (15)
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (1,1,NULL,1,1200.00,1,1);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (2,NULL,2,2,120.00,2,2);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (3,3,NULL,5,350.00,3,3);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (4,NULL,4,1,180.00,4,4);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (5,5,NULL,1,2000.00,5,5);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (6,NULL,6,3,300.00,6,6);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (7,7,NULL,4,380.00,7,7);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (8,NULL,8,2,480.00,8,8);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (9,9,NULL,2,900.00,9,9);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (10,NULL,10,10,60.00,10,10);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (11,11,NULL,1,800.00,11,11);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (12,NULL,12,2,220.00,12,12);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (13,13,NULL,6,420.00,13,13);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (14,NULL,14,1,260.00,14,14);
INSERT INTO detalles_facturas (descuentoid, productoid, medicamentoid, cantidad, precio, coberturaid, facturaid) VALUES (15,15,NULL,3,120.00,15,15);

-- 33) COMPRAS (15)
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-01 09:00:00',1,1,1,1, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-02 10:00:00',2,2,2,2, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-03 11:00:00',3,3,3,3, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-04 12:00:00',4,4,4,4, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-05 13:00:00',5,5,5,5, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-06 14:00:00',6,6,6,6, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-07 15:00:00',7,7,7,7, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-08 16:00:00',8,8,8,8, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-09 17:00:00',9,9,9,9, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-10 18:00:00',10,10,10,10, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-11 08:00:00',11,11,11,11, FALSE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-12 09:30:00',12,12,12,12, FALSE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-13 10:15:00',13,13,13,13, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-14 11:45:00',14,14,14,14, TRUE);
INSERT INTO compras (fecha_compra, empleadoid, proveedorid, repartidorid, sucursalid, activo) VALUES ('2025-05-15 12:30:00',15,15,15,15, TRUE);

-- 34) DETALLES_COMPRAS (15)
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (1,1,NULL,'P000000001',10,NULL,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (2,NULL,'M000000002',NULL,50,2,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (3,3,NULL,'P000000003',100,NULL,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (4,NULL,'M000000004',NULL,30,4,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (5,5,NULL,'P000000005',5,NULL,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (6,NULL,'M000000006',NULL,20,6,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (7,7,NULL,'P000000007',60,NULL,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (8,NULL,'M000000008',NULL,12,8,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (9,9,NULL,'P000000009',40,NULL,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (10,NULL,'M000000010',NULL,200,10,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (11,11,NULL,'P000000011',15,NULL,FALSE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (12,NULL,'M000000012',NULL,80,12,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (13,13,NULL,'P000000013',25,NULL,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (14,NULL,'M000000014',NULL,35,14,TRUE);
INSERT INTO detalles_compras (compraid, lote_productoid, codigo_barra_medicamentoid, codigo_barra_productoid, cantidad, lote_medicamentoid, activo) VALUES (15,15,NULL,'P000000015',45,NULL,TRUE);

-- 35) INVENTARIOS_PRODUCTOS (15)
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (1,1,5,100,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (2,2,10,500,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (3,3,20,200,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (4,4,15,300,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (5,5,2,50,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (6,6,8,150,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (7,7,25,600,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (8,8,7,80,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (9,9,10,250,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (10,10,5,120,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (11,11,3,75,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (12,12,30,400,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (13,13,6,90,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (14,14,12,220,TRUE);
INSERT INTO inventarios_productos (sucursalid, productoid, stock_minimo, stock_actual, activo) VALUES (15,15,4,130,TRUE);

-- 36) INVENTARIOS_MEDICAMENTOS (15)
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (1,1,10,200,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (2,2,20,500,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (3,3,15,300,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (4,4,8,250,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (5,5,6,180,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (6,6,12,220,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (7,7,5,150,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (8,8,10,90,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (9,9,7,130,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (10,10,30,700,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (11,11,4,95,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (12,12,9,260,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (13,13,2,110,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (14,14,7,175,TRUE);
INSERT INTO inventarios_medicamentos (sucursalid, medicamentoid, stock_minimo, stock_actual, activo) VALUES (15,15,5,85,TRUE);

-- 37) EMPLEADOS_SUCURSALES (15)
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (1,1,'2022-01-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (2,2,'2022-02-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (3,3,'2022-03-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (4,4,'2022-04-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (5,5,'2022-05-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (6,6,'2022-06-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (7,7,'2022-07-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (8,8,'2022-08-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (9,9,'2022-09-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (10,10,'2022-10-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (11,11,'2022-11-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (12,12,'2022-12-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (13,13,'2023-01-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (14,14,'2023-02-01 08:00:00',NULL);
INSERT INTO empleados_sucursales (empleadoid, sucursalid, fecha_inicio, fecha_fin) VALUES (15,15,'2023-03-01 08:00:00',NULL);